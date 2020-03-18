using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IS21DotNet.Utilities;
using DevExpress.XtraReports.UI;
using System.Threading;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using IS21DotNet.DataModels;
using DevExpress.XtraReports.UI.PivotGrid;

namespace IS21DotNet.Reports
{
    public class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        //private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        //private DevExpress.XtraReports.UI.DetailBand detailBand1;
        //private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;

        private IQueryable<String> memberList;
        private IQueryable<String> productList;
        private IEnumerable<string> locationList;
        private IEnumerable<string> locationList2;
        private IEnumerable<string> viptypeList;
        private IEnumerable<decimal> tempdecimalList;
        private object resultQuery;
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;
        private InfowareDataContext context;

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // BaseReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        public void TranslateLabels(Translation translate, string lang)
        {
            for (int i = 0; i < this.Report.Bands.Count; i++)
            {
                TranslateLabels(translate, this.Report.Bands[i].Controls, lang);
            }
        }

        private void TranslateLabels(Translation translate, XRControlCollection Controls, string lang)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                XRControl item = Controls[i];

                if (item is XRSubreport)
                {
                    XRSubreport control = (XRSubreport)item;
                    if (control.ReportSource is BaseReport)
                    {
                        BaseReport report = (BaseReport)control.ReportSource;
                        report.TranslateLabels(translate, lang);
                    }
                    
                }
                else if (item is XRTable)
                {
                    XRTableRowCollection control = (XRTableRowCollection)item.Controls;
                    foreach (XRTableRow row in control)
                        TranslateLabels(translate, row.Controls, lang);
                }

                else if (item is XRTableCell)
                {
                    XRTableCell label = (XRTableCell)item;
                    if (label.Name.ToLower() == "programid")
                    {
                        string reportName = GetType().Name.Replace("Report", "");
                        label.Text = translate.GetProgramName(lang, reportName) + " (" + reportName + ")";
                    }
                    else
                    {
                        string caption = GetControlLabel(translate, label.Name, lang);
                        if (caption.Length > 0 && !caption.StartsWith("["))
                        {
                            label.Text = caption;
                        }
                    }
                    foreach (XRBinding binding in label.DataBindings)
                    {
                        if (binding.FormatString != null)
                        {
                            if (binding.FormatString.Contains("$"))
                            {
                                binding.FormatString = "{0:c}";
                            }
                            else if (binding.FormatString.Contains("%"))
                            {
                                binding.FormatString = "{0:p}";
                            }
                        }
                    }

                    if (item.Controls.Count > 0)
                        TranslateLabels(translate, item.Controls, lang);
                }

                else if (item is XRLabel)
                {
                    XRLabel label = (XRLabel)item;
                    if (label.Name.ToLower() == "programid")
                    {
                        string reportName = GetType().Name.Replace("Report", "");
                        label.Text = translate.GetProgramName(lang, reportName) + " (" + reportName + ")";
                    }
                    else
                    {
                        string caption = GetControlLabel(translate, label.Name, lang);
                        if (caption.Length > 0 && !caption.StartsWith("["))
                        {
                            label.Text = caption;
                        }
                    }

                    foreach (XRBinding binding in label.DataBindings)
                    {
                        if (binding.FormatString != null)
                        {
                            if (binding.FormatString.Contains("$"))
                            {
                                binding.FormatString = "{0:c}";
                            }
                            else if (binding.FormatString.Contains("%"))
                            {
                                binding.FormatString = "{0:p}";
                            }
                        }
                    }
                }
                else if (item is XRPivotGrid)
                {
                    XRPivotGrid grid = (XRPivotGrid)item;

                    foreach (XRPivotGridField field in grid.Fields)
                    {
                        string caption = GetControlLabel(translate, field.Name, lang);
                        if (caption.Length > 0 && !caption.StartsWith("["))
                        {
                            field.Caption = caption;
                        }

                        if (field.CellFormat.FormatType == DevExpress.Utils.FormatType.Numeric)
                        {
                            String sFormatString = field.CellFormat.FormatString.ToLower();
                            if (!sFormatString.Contains("c") && !sFormatString.Contains("n") && !sFormatString.Contains("p"))
                            {
                                if (sFormatString.Contains("$"))
                                {
                                    field.CellFormat.FormatString = "c";
                                }
                                else if (sFormatString.Contains("%"))
                                {
                                    field.CellFormat.FormatString = "p";
                                }
                                else
                                {
                                    field.CellFormat.FormatString = "n";
                                }
                            }
                        }

                        if (field.ValueFormat.FormatType == DevExpress.Utils.FormatType.Numeric)
                        {
                            String sFormatString = field.ValueFormat.FormatString.ToLower();
                            if (!sFormatString.Contains("c") && !sFormatString.Contains("n") && !sFormatString.Contains("p"))
                            {
                                if (sFormatString.Contains("$"))
                                {
                                    field.ValueFormat.FormatString = "c";
                                }
                                else if (sFormatString.Contains("%"))
                                {
                                    field.ValueFormat.FormatString = "p";
                                }
                                else
                                {
                                    field.ValueFormat.FormatString = "n";
                                }
                            }
                            field.CellFormat.FormatType = field.ValueFormat.FormatType;
                            field.CellFormat.FormatString = field.ValueFormat.FormatString;
                        }
                    }
                }
            }
        }

        private string GetControlLabel(Translation translate, string label, string lang)
        {
            string[] data = label.Split('_');
            string text = "";

            if (data.Length > 1)
            {
                text = "";
                for (int j = 1; j < data.Length; j++)
                {
                    if (data.Length < 3 || j < data.Length - 1)
                    {
                        if (lang != "")
                        { text += (translate.GetText(lang, data[j]) + " "); }
                        else
                        { text += (translate.GetText(data[j]) + " "); }
                    }
                }
                text = text.Trim();

                if (Thread.CurrentThread.CurrentCulture.Name.StartsWith("zh"))
                {
                    text = text.Replace(" ", "");
                }
            }
            return text;
        }

        public void SetParameters(Dictionary<string, object> parameters)
        {
            foreach(string key in parameters.Keys)
            {
                if (Parameters[key] != null)
                {
                    if (Parameters[key].Type == typeof(DateTime))
                    {
                        if (parameters[key].Equals("TODAY"))
                        {
                            Parameters[key].Value = DateTime.Today.AddDays(-1);
                        }
                        else if (parameters[key].Equals("MTD"))
                        {
                            DateTime dtToday = DateTime.Today.AddDays(-1);
                            Parameters[key].Value = new DateTime(dtToday.Year, dtToday.Month, 1);
                        }
                        else if (parameters[key].Equals("YTD"))
                        {
                            DateTime dtToday = DateTime.Today.AddDays(-1);
                            Parameters[key].Value = new DateTime(dtToday.Year, 1, 1);
                        }
                        else
                        {
                            Parameters[key].Value = Utility.GetValueByType(parameters[key], Parameters[key].Type);
                        }
                    }
                    else
                    {
                        if (Parameters[key].Type == typeof(String))
                        {
                            Parameters[key].Value = parameters[key];
                        }
                        else
                        {
                            Parameters[key].Value = Utility.GetValueByType(parameters[key], Parameters[key].Type);
                        }
                    }
                }
            }
        }

        public IQueryable<String> MemberList
        {
            get
            {
                return memberList;
            }

            set
            {
                memberList = value;
            }
        }

        public IQueryable<String> ProductList
        {
            get
            {
                return productList;
            }

            set
            {
                productList = value;
            }
        }

        public IEnumerable<string> LocationList
        {
            get
            {
                return locationList;
            }

            set
            {
                locationList = value;
            }
        }

        public IEnumerable<string> LocationList2
        {
            get
            {
                return locationList2;
            }

            set
            {
                locationList2 = value;
            }
        }

        public IEnumerable<string> VIPTypeList
        {
            get
            {
                return viptypeList;
            }

            set
            {
                viptypeList = value;
            }
        }

        public IEnumerable<decimal> TempDecimalList
        {
            get
            {
                return tempdecimalList;
            }

            set
            {
                tempdecimalList = value;
            }
        }

        public object ResultQuery
        {
            get
            {
                return resultQuery;
            }

            set
            {
                resultQuery = value;
            }
        }

        public InfowareDataContext Context
        {
            get
            {
                if (context == null)
                    context = new InfowareDataContext();
                return context;
            }

            set
            {
                context = value;
            }
        }
    }
}