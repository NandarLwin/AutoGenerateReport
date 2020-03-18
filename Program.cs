using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IS21DotNet.DataModels;
using IS21DotNet.Utilities;
using IS21DotNet.Reports.Shared;
using IS21DotNet.Reports.Properties;
using System.IO;
using System.Threading;
using System.Data;
using NPOI.SS.UserModel;
using System.Web;
using IS21DotNet.Reports.Alert;

namespace IS21DotNet.Reports
{
    class Program
    {
        public static object progRptList { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(System.String[] argss)
        {
            string[] args = { "report", "334", "PCD", "0000003,0000005,Job0000000001" };
            Dictionary<string, object> dicto = new Dictionary<string, object>();
            Utility.SetDefaultFormat(Thread.CurrentThread.CurrentCulture.Name);
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ReportingForm());
            }
            else
            {
                if (args[0].ToLower() == "report")
                {
                    //Call and execute ALL the valid report jobs 
                    string sLogFile = "" ;
                    InfowareDataContext context = new InfowareDataContext();

                    IQueryable<rptmallst> rptMaster = from rptmaster in context.rptmallsts
                                                      where rptmaster.rptmltenab.Equals("Y")
                                                      orderby rptmaster.rptmltseqn ascending
                                                      select rptmaster;


                    IQueryable<rptJobMst_rptDetail> progRptQuery = from rptlist in context.rptjobmsts
                                                                   from rptdetail in context.rptmaldtls
                                                                   where rptlist.rptmstbrcd == rptdetail.rptmdlbrcd &&
                                                                   rptlist.rptmstcpcd == rptdetail.rptmdlcpcd &&
                                                                   rptlist.rptmstjbcd == rptdetail.rptmdljbcd &&
                                                                   rptdetail.rptmdlenab.Equals("Y")
                                                                   select new rptJobMst_rptDetail { detail = rptdetail, master = rptlist };


                    Dictionary<String, EmailServerInfo> emailInfoDict = new Dictionary<string, EmailServerInfo>();

                    emailInfoDict = (from rptlist in progRptQuery
                                     join emailSer in context.emrcorcmps
                                     on rptlist.detail.rptmdlcpcd equals emailSer.emrcmpcpcd
                                     select new
                                     {
                                         Key = rptlist.detail.rptmdlcpcd.Trim(),
                                         Value = new EmailServerInfo
                                         {
                                             ServerName = emailSer.emrcmpemsr == null ? "" : emailSer.emrcmpemsr.Trim(),
                                             UserID = emailSer.emrcmpesur == null ? "" : emailSer.emrcmpesur.Trim(),
                                             Password = emailSer.emrcmpespd == null ? "" : emailSer.emrcmpespd.Trim()
                                         }
                                     }).Distinct().ToDictionary(p => p.Key, p => p.Value);
                    Email emailService = Email.Instance;
                    EmailServerInfo emailInfo = new EmailServerInfo();
                    if (String.IsNullOrWhiteSpace(emailInfo.ServerName))
                    {
                        emailInfo.ServerName = Settings.Default.DefaultEmailServerName;
                        emailInfo.UserID = Settings.Default.DefaultEmailServerLogin;
                        emailInfo.Password = Settings.Default.DefaultEmailServerPasword;
                    }

                    List<rptJobMst_rptDetail> progRptList = new List<rptJobMst_rptDetail>();
                    List<rptmallst> progRptMasterList = new List<rptmallst>();
                    if (args.Length == 3)
                    {
                        if (!string.IsNullOrEmpty(args[1]) && !string.IsNullOrEmpty(args[2]))
                        {
                            rptMaster = rptMaster.Where(x => x.rptmltcpcd == args[1] && x.rptmltbrcd == args[2]);
                            progRptQuery = progRptQuery.Where(x => x.detail.rptmdlcpcd == args[1] && x.detail.rptmdlbrcd == args[2]);

                        }
                    }
                    if (args.Length == 4)
                    {
                        String[] code = args[3].Split(',');
                        List<string> codeList = new List<string>();
                        for (int i = 0; i < code.Length; i++)
                        {
                            if (code[i].Trim() != "")
                                codeList.Add(code[i]);
                        }
                        rptMaster = rptMaster.Where(x => x.rptmltcpcd == args[1] && x.rptmltbrcd == args[2] && codeList.Contains(x.rptmltmlcd));
                        progRptQuery = progRptQuery.Where(x => x.detail.rptmdlcpcd == args[1] && x.detail.rptmdlbrcd == args[2] && codeList.Contains(x.detail.rptmdlmlcd));

                    }
                    progRptMasterList = rptMaster.ToList();
                    foreach (var value in progRptMasterList)
                    {
                        sLogFile = Settings.Default.DefaultLogPath + Path.DirectorySeparatorChar + value.rptmltcpcd + Path.DirectorySeparatorChar + value.rptmltbrcd + Path.DirectorySeparatorChar + value.rptmltmlcd + Path.DirectorySeparatorChar + "log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                        progRptList = progRptQuery.Where(x => x.detail.rptmdlmlcd == value.rptmltmlcd && x.detail.rptmdlcpcd == value.rptmltcpcd && x.detail.rptmdlbrcd == value.rptmltbrcd).ToList();
                            Dictionary<String, List<string>> attachDic = new Dictionary<string, List<string>>();
                            List<string> attachmentList = new List<string>();
                            string result = "";
                            foreach (var rptValue in progRptList)
                            {
                                    String sCpcd = Utility.NullToString(rptValue.detail.rptmdlcpcd.TrimEnd());
                                    String sBrcd = Utility.NullToString(rptValue.detail.rptmdlbrcd.TrimEnd());
                                    String sJbcd = Utility.NullToString(rptValue.detail.rptmdljbcd.TrimEnd());

                                    String sModuleID = Utility.NullToString(rptValue.master.rptmstmdcd);
                                    String sProgramID = Utility.NullToString(rptValue.master.rptmstpgid);
                                    String sReportDesc = Utility.NullToString(rptValue.master.rptmstdesc);
                                    if (sReportDesc == "")
                                    {
                                        sReportDesc = sProgramID;

                                    }
                                    string sepMail = Utility.NullToString(value.rptmltemal.TrimEnd());
                                    IQueryable<rptjobpam> paramQuery = from rptpar in context.rptjobpams
                                                                       where rptpar.rptpamjbcd.Equals(sJbcd)
                                                                       && rptpar.rptpamcpcd.Equals(sCpcd)
                                                                       && rptpar.rptpambrcd.Equals(sBrcd)
                                                                       orderby rptpar.rptpampram ascending
                                                                       select rptpar;

                            #region reportGeneration

                            try
                            {
                                String sFileDirectory = Settings.Default.OutputFilePath + Path.DirectorySeparatorChar + sCpcd + Path.DirectorySeparatorChar + sBrcd + Path.DirectorySeparatorChar + sJbcd;
                                if (!Directory.Exists(sFileDirectory))
                                {
                                    Directory.CreateDirectory(sFileDirectory);
                                }
                                string prefix = "";
                                if (Utility.NullToString(rptValue.master.rptmstrpnm) != "")
                                {
                                    prefix = Utility.NullToString(rptValue.master.rptmstrpnm);
                                }
                                else
                                {
                                    prefix = Utility.NullToString(rptValue.master.rptmstpgid);
                                }
                                string fileNameValue = prefix + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss");

                                String sFilePath = sFileDirectory + Path.DirectorySeparatorChar + fileNameValue + "." + rptValue.master.rptmstfmcd.TrimEnd();

                                    //if program id end with data, use the new approach
                                    if (sProgramID.Trim().EndsWith("Data"))
                                    {
                                        Type reportType = Type.GetType("IS21DotNet.Reports." + sModuleID + "." + sProgramID + "");
                                        BaseReportData report = (BaseReportData)Activator.CreateInstance(reportType);
                                        Dictionary<string, object> reportParameters = new Dictionary<string, object>();
                                        foreach (var row in paramQuery)//neeed to be ordered
                                        {
                                            String sKey = Utility.NullToString(row.rptpampram);
                                            String sType = Utility.NullToString(row.rptpamvtyp).ToUpper();
                                            Object oValue = Utility.NullToString(row.rptpampval);

                                            reportParameters[sKey] = CaseValueByDataType(oValue, sType);
                                        }
                                        report.createFile(report.export(reportParameters, sFilePath), sFileDirectory, fileNameValue + "." + rptValue.master.rptmstfmcd.TrimEnd());
                                        attachmentList.Add(sFilePath);

                                }
                                    else if (sProgramID.Trim().EndsWith("Alert"))
                                    {
                                        Dictionary<string, object> reportParameters = new Dictionary<string, object>();
                                        Dictionary<string, object> rptLocc = new Dictionary<string, object>();
                                        foreach (var row in paramQuery)//neeed to be ordered
                                        {
                                            String sKey = Utility.NullToString(row.rptpampram);
                                            String sType = Utility.NullToString(row.rptpamvtyp).ToUpper();
                                            Object oValue = Utility.NullToString(row.rptpampval);

                                            reportParameters[sKey] = CaseValueByDataType(oValue, sType);
                                        }

                                        Type reportType = Type.GetType("IS21DotNet.Reports.Alert." + sProgramID + "");
                                        BaseAlertData report = (BaseAlertData)Activator.CreateInstance(reportType,reportParameters);
                                        if(!report.IsAttachFile)
                                        {
                                            result += report.ExportToHTML(reportParameters) + "<br>";
                                    }
                                        else
                                        {
                                            report.createFile(report.export(reportParameters, sFilePath), sFileDirectory, fileNameValue + "." + rptValue.master.rptmstfmcd.TrimEnd());
                                            attachmentList.Add(sFilePath);
                                        }
                                            
                                    }
                                    else
                                    {
                                        Type reportType = Type.GetType("IS21DotNet.Reports." + sModuleID + "." + sProgramID + "Report");
                                        BaseReport xrreport = (BaseReport)Activator.CreateInstance(reportType);
                                        Dictionary<string, object> reportParameters = new Dictionary<string, object>();

                                        foreach (var row in paramQuery)
                                        {
                                            String sKey = Utility.NullToString(row.rptpampram);
                                            String sType = Utility.NullToString(row.rptpamvtyp).ToUpper();
                                            Object oValue = Utility.NullToString(row.rptpampval);

                                            reportParameters[sKey] = CaseValueByDataType(oValue, sType);
                                        }

                                        xrreport.SetParameters(reportParameters);
                                        xrreport.TranslateLabels(Translation.Instance, Settings.Default.Language);
                                        xrreport.RequestParameters = false;

                                        if (rptValue.master.rptmstfmcd.TrimEnd().Equals("pdf"))
                                        {
                                            xrreport.ExportToPdf(sFilePath);
                                        }
                                        else if (rptValue.master.rptmstfmcd.TrimEnd().Equals("xls"))
                                        {
                                            xrreport.ExportToXls(sFilePath);
                                        }
                                        else if (rptValue.master.rptmstfmcd.TrimEnd().Equals("xlsx"))
                                        {
                                            xrreport.ExportToXlsx(sFilePath);
                                        }
                                        attachmentList.Add(sFilePath);
                                    }
                            }
                            catch (System.Exception ex)
                            {
                                Utility.WriteLog(DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + ", ReportName: " + sReportDesc + ", Cannot generate Report : Failed\n Exception Message: " + ex.Message + ex.InnerException + "\n" + ex.StackTrace, sLogFile);
                            }

                                    #endregion
                                //}
                            }
                            if (emailInfoDict.ContainsKey(value.rptmltcpcd.TrimEnd()))
                            {
                                emailInfo = emailInfoDict[value.rptmltcpcd.TrimEnd()];
                            }
                            string message = GetMessage(value.rptmltmsgh, value.rptmltmsgc, value.rptmltmsgf,"","");
                            if (attachmentList.Count > 0 || result != "")
                            {
                                if (result != "")
                                {
                                    string sCpcdName = "";
                                    try
                                    {
                                        sCpcdName = Utility.NullToString(context.emrcorcmps
                                                        .Where(a => a.emrcmpcpcd == value.rptmltcpcd.TrimEnd())
                                                        .Select(b => b.emrcmpfnmp).SingleOrDefault(), "");
                                    }
                                    catch
                                    {
                                        sCpcdName = "";
                                    }

                                    message = GetMessage(value.rptmltmsgh, value.rptmltmsgc, value.rptmltmsgf, result, sCpcdName);
                                }
                                emailService.SendEmail(value.rptmltemal, value.rptmltsubj, message, attachmentList, emailInfo);
                            }
                    }
                }
            }
        }
        public static string GetMessage(string header, string content, string footer, string result, string cpcdName)
        {
            string html = "<html><body>";
            html += header + "<br>";
            html += content + " <br>";
            html += result + " <br>";
            html += footer + " <br>";
            html += "</body></html>";

            return html;
        }

        public static Object CaseValueByDataType(Object oValue, String sType)
        {
            //if(oValue!=null)
            //string[] splitedType = oValue.ToString().Split(';');

            if (sType == "DATETIME")
            {
                if (oValue.ToString() == "TODAY")
                {
                    oValue = DateTime.Today.AddDays(-1);
                }
                else if (oValue.ToString() == "MTD")
                {
                    DateTime dtToday = DateTime.Today.AddDays(-1);
                    oValue = new DateTime(dtToday.Year, dtToday.Month, 1);
                }
                else if (oValue.ToString() == "YTD")
                {
                    DateTime dtToday = DateTime.Today.AddDays(-1);
                    oValue = new DateTime(dtToday.Year, 1, 1);
                }
                else if (oValue.ToString() == "MIN" || oValue.ToString() == "EMPTY")
                {
                    DateTime dtToday = DateTime.MinValue;
                    oValue = new DateTime(dtToday.Year, dtToday.Month, dtToday.Day);
                }
                else if (oValue.ToString() == "MAX")
                {
                    DateTime dtToday = DateTime.MaxValue;
                    oValue = new DateTime(dtToday.Year, dtToday.Month, dtToday.Day);
                }
                else if (oValue.ToString() == "TODAY-7")
                {
                    oValue = DateTime.Today.AddDays(-7);
                }
                else
                {
                    DateTime dtValue = DateTime.Now;
                    if (DateTime.TryParse(oValue.ToString(), out dtValue))
                    {
                        oValue = dtValue;
                    }
                }
            }
            else if (sType == "INT" || sType == "INTEGER")
            {
                Int32 iValue = 0;
                if (Int32.TryParse(oValue.ToString(), out iValue))
                {
                    oValue = iValue;
                }
            }
            else if (sType == "DOUBLE")
            {
                Double dValue = 0.00;
                if (Double.TryParse(oValue.ToString(), out dValue))
                {
                    oValue = dValue;
                }
            }
            else if (sType == "DECIMAL")
            {
                Decimal dValue = 0.00M;
                if (Decimal.TryParse(oValue.ToString(), out dValue))
                {
                    oValue = dValue;
                }
            }
            else if (sType == "BOOLEAN")
            {
                Boolean bValue = false;
                if (Boolean.TryParse(oValue.ToString(), out bValue))
                {
                    oValue = bValue;
                }
            }

            return oValue;
        }
    }
    public class DistinctVal
    {
        public string cpcd { get; set; }
        public string brcd { get; set; }
        public string mlcd { get; set; }

        public string jbcd { get; set; }

    }
    public class rptJobMst_rptDetail
    {
        public rptjobmst master { get; set; }
        public rptmaldtl detail { get; set; }
    }

}
