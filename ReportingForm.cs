using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using IS21DotNet.Utilities;
using System.Threading;
using System.Globalization;
using IS21DotNet.Reports;
using System.Reflection;
using IS21DotNet.DataModels;
using System.Net;
using IS21DotNet.Reports.Properties;


using System.Diagnostics;
using System.IO;
using System.Net.Mail;


using System.Net.Mime;
using System.Configuration;
using System.Collections;

namespace IS21DotNet.Reports
{
    public partial class ReportingForm : Form
    {
        List<rptjobpam> parameterList = new List<rptjobpam>();
               
        InfowareDataContext context = new InfowareDataContext();
        string sLogFile=Settings.Default.DefaultLogPath + Path.DirectorySeparatorChar + "log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
     

        public ReportingForm()
        {
            InitializeComponent();
            

        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMasterGridData();

                #region DisableControls

                dgv_param.Visible = false;
                btn_generate.Visible = false;
                lbl_rptParam.Visible = false;

                #endregion
            }
            catch(Exception ex)
            {
                Utility.WriteLog("\n"+ DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " Error : "+ ex.Message, sLogFile);
         
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Boolean msgsend = true;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                #region getEmailUserServerPasword

                string sEmailServer = "";
                string sEmailUser = "";
                string sEmailPassword = "";


                var getServerDet = (from emailSer in context.emrcorcmps
                                    where emailSer.emrcmpcpcd.Equals(txt_company.Text.TrimEnd())
                                    select emailSer).SingleOrDefault();
                if (getServerDet != null)
                {
                    sEmailServer = Utility.NullToString(getServerDet.emrcmpemsr);
                    sEmailUser = Utility.NullToString(getServerDet.emrcmpesur);
                    sEmailPassword = Utility.NullToString(getServerDet.emrcmpespd);
                }

                if (String.IsNullOrWhiteSpace(sEmailServer))
                {
                    sEmailServer = Settings.Default.DefaultEmailServerName;
                    sEmailUser = Settings.Default.DefaultEmailServerLogin;
                    sEmailPassword = Settings.Default.DefaultEmailServerPasword;
                }

                /* Local Testing Only */
#if DEBUG
                sEmailServer = "mail13.infoware.com.hk";
#endif

                #endregion

                string email = txt_email.Text;
                string sEmail = "";
                string sEmailMsg = "";

                if (Utility.NullToString(txt_email.Text) != "")
                {
                    sEmail = Utility.NullToString(txt_email.Text);
                }
                else
                {
                    sEmail = GetAllMailByGroupCode(txt_company.Text.TrimEnd(), txt_branch.Text.TrimEnd(), txt_GroupCode.Text.TrimEnd());
                }

                sEmailMsg = "Dear user,\n\n" + "Here is the background job reporting process, and find the attached report.\n\n" + "Regards,\n" + "webmaster\n";


                String sFileDirectory = Settings.Default.OutputFilePath + Path.DirectorySeparatorChar + txt_rptJobId.Text.TrimEnd();
                if (!Directory.Exists(sFileDirectory))
                {
                    Directory.CreateDirectory(sFileDirectory);
                }

                String sFilePath = sFileDirectory + Path.DirectorySeparatorChar + txt_filename.Text + "." + cbx_fileformat.SelectedItem.ToString();


                String sModuleID = txt_module.Text.Trim();
                String sProgramID = txt_program.Text.Trim();

                Type reportType = Type.GetType("IS21DotNet.Reports." + sModuleID + "." + sProgramID + "Report");
                BaseReport xrreport = (BaseReport)Activator.CreateInstance(reportType);


                Dictionary<string, object> reportParameters = new Dictionary<string, object>();

                foreach (DataGridViewRow row in dgv_param.Rows)
                {
                    String sKey = Utility.NullToString(row.Cells[0].Value);
                    String sType = Utility.NullToString(row.Cells[3].Value).ToUpper();
                    Object oValue = row.Cells[1].Value;

                    reportParameters[sKey] = Program.CaseValueByDataType(oValue, sType);
                }
                xrreport.SetParameters(reportParameters);
                xrreport.TranslateLabels(Translation.Instance, Settings.Default.Language);

                xrreport.RequestParameters = false;


                if (cbx_fileformat.SelectedItem.Equals("pdf"))
                {
                    xrreport.ExportToPdf(sFilePath);
                }
                else if (cbx_fileformat.SelectedItem.Equals("xls"))
                {
                    xrreport.ExportToXls(sFilePath);

                }
                else if (cbx_fileformat.SelectedItem.Equals("xlsx"))
                {
                    xrreport.ExportToXlsx(sFilePath);
                }


                Email emailService = Email.Instance;
                EmailServerInfo emailInfo = new EmailServerInfo();
                emailInfo.ServerName = sEmailServer;
                emailInfo.UserID = sEmailUser;
                emailInfo.Password = sEmailPassword;

                List<String> attachmentList = new List<string>();
                attachmentList.Add(sFilePath);

                emailService.SendEmail(sEmail, "Reporting Mail for report " + txt_program.Text.Trim(), sEmailMsg, attachmentList, emailInfo);
                msgsend = true;

            }

            catch (System.Exception ex)
            {

                Utility.WriteLog(DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + ", ReportName: " + txt_program.Text.Trim() + ", Cannot generate Report : Failed\n Exception Message: " + ex.Message, sLogFile);
                Utility.WriteLog("\n" + ex.StackTrace, sLogFile);

                msgsend = false;
            }

            if (msgsend == true)
            {

                MessageBox.Show("Email Send Successfully ");
            }
            else
            {
                MessageBox.Show("Email Not Sent : ERROR ...Please check the Log");
            }
        }

        private void dgv_reportJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_company.Text = dgv_reportJob.CurrentRow.Cells[0].Value.ToString().TrimEnd();
                txt_branch.Text = dgv_reportJob.CurrentRow.Cells[1].Value.ToString().TrimEnd();
                txt_rptJobId.Text = dgv_reportJob.CurrentRow.Cells[2].Value.ToString().TrimEnd();
                txt_module.Text = dgv_reportJob.CurrentRow.Cells[3].Value.ToString().TrimEnd();
                txt_program.Text = dgv_reportJob.CurrentRow.Cells[4].Value.ToString().TrimEnd();
                txt_GroupCode.Text = dgv_reportJob.CurrentRow.Cells[21].Value.ToString().TrimEnd();
                if (dgv_reportJob.CurrentRow.Cells[22].Value.ToString() == "Y")
                {
                    radbtnYes.Checked = true;
                }
                else
                {
                    radbtnNo.Checked = true;
                }
                txt_filename.Text = txt_program.Text + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("hhmmss");
                
                LoadParameterGrid();
            }
            catch(Exception ex)
            {
                Utility.WriteLog("\n" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " Error : " + ex.Message, sLogFile);
         
            }
        }


        void LoadMasterGridData()
        {
            try
            {
                #region getGridData
                dgv_reportJob.DataSource = context.rptjobmsts;
                #endregion

            }
            catch (Exception ex)
            {
                Utility.WriteLog("\n" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " Error : " + ex.Message, sLogFile);

            }
        }


        void LoadParameterGrid()
        {


            try
            {
                #region getcontrolValues

                rptjobmst masterValue = (from rptmasvalues in context.rptjobmsts
                                         where rptmasvalues.rptmstjbcd == txt_rptJobId.Text
                                         && rptmasvalues.rptmstcpcd == txt_company.Text
                                         && rptmasvalues.rptmstbrcd == txt_branch.Text
                                         select rptmasvalues).FirstOrDefault();

                #endregion
                #region EnableControls

                dgv_param.Visible = true;
                btn_generate.Visible = true;
                lbl_rptParam.Visible = true;
                #endregion


                String sFileFormat = masterValue.rptmstfmcd.Trim().ToLower();

                cbx_fileformat.SelectedItem = sFileFormat;
                if (cbx_fileformat.SelectedItem == null)
                {
                    cbx_fileformat.SelectedItem = cbx_fileformat.Items[0];
                }

                txt_email.Text = masterValue.rptmstemal;
                
                #region LoadParameterGrid
                parameterList = (from rptpar in context.rptjobpams
                               where rptpar.rptpamjbcd.Equals(txt_rptJobId.Text.TrimEnd())
                               && rptpar.rptpamcpcd.Equals(txt_company.Text.TrimEnd())
                               && rptpar.rptpambrcd.Equals(txt_branch.Text.TrimEnd())
                               select rptpar).ToList();

                dgv_param.DataSource = parameterList;
                dgv_param.ReadOnly = false;
                dgv_param.EditMode = DataGridViewEditMode.EditOnEnter;


                #endregion

            }
            catch(Exception ex)
            {
                Utility.WriteLog("\n" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " Error : " + ex.Message, sLogFile);
         
            }


        }
        public static string GetAllMailByGroupCode(String rptegpcpcd, String rptegpbrcd, String rptegpgpcd)
        {
            InfowareDataContext DC = new InfowareDataContext();
            var DT = (from table in DC.GetTable<rptemlgrp>()
                      where table.rptegpcpcd == rptegpcpcd &&
                      table.rptegpbrcd == rptegpbrcd &&
                      table.rptegpgpcd == rptegpgpcd
                      select table.rptegpemal).
                      ToList();
            //DataTable dt = CommonSet.LINQtoDataTable(DT, DC, List);
            ArrayList al = new ArrayList();
            foreach (var value in DT)
            {
                al.Add(value);
            }
            return String.Join(";", al.ToArray());

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_reportJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dts_parameters_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dts_reports_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        //private void dgv_param_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string parname = "";
        //    string parval  = "";
        //    string pardesc = "";
        //    try
        //    {

        //        parname = (dgv_param.Rows[e.RowIndex].Cells[0].Value == null || dgv_param.Rows[e.RowIndex].Cells[0].Value.ToString().TrimEnd() == "") ? string.Empty : dgv_param.Rows[e.RowIndex].Cells[0].Value.ToString().TrimEnd();

        //        parval = (dgv_param.Rows[e.RowIndex].Cells[1].Value == null || dgv_param.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd() == "") ? string.Empty : dgv_param.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd();

        //        pardesc = (dgv_param.Rows[e.RowIndex].Cells[2].Value == null || dgv_param.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd() == "") ? string.Empty : dgv_param.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd();


        //        ParameterPopup popup = new ParameterPopup(parname, parval, pardesc);
        //        popup.Show();
        //        popup.Visible = false;
        //        DialogResult dialogresult = popup.ShowDialog();
        //        if (dialogresult == DialogResult.OK)
        //        {

        //            #region UpdateParameterstable
        //            foreach (var param in parameterList)
        //            {
        //                if (param.rptpampram.Trim() == popup.parName.Trim())
        //                {
        //                    param.rptpampval = (popup.parVal.ToString() == null || popup.parVal.ToString() == "") ? string.Empty : popup.parVal.ToString();

        //                }
        //            } 

        //            dgv_param.DataSource = parameterList;
        //            #endregion
        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        Utility.WriteLog("\n" + DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " Error : " + ex.Message, sLogFile);

        //    }
        //}


        //private void dgv_param_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    var cell = dgv_param.Rows[e.RowIndex].Cells[e.ColumnIndex];

        //    cell.ToolTipText = "Click on the cell to edit";
        //}

    }
}
    


    
