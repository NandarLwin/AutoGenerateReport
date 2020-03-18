using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IS21DotNet.Reports
{
    public partial class ParameterPopup : Form
    {
        public ReportingForm parentform;
        public ParameterPopup(string name,string val,string desc)
        {
            InitializeComponent();
            lbl_popup_PamName.Text = name;
            lbl_popup_DescVal.Text = desc;
            txt_parVal.Text = val;
           
        }

        private void popupform_Load(object sender, EventArgs e)
        {
    

        }
       public  string parVal
        {
            get
            {
                return txt_parVal.Text;
            }
      
        }
       public string parDesc
       {
           get
           {
               return lbl_popup_DescVal.Text;
           }

       }

        public string parName
        {
            get
            {
                return lbl_popup_PamName.Text;
            }
           

        }

       

    
        
       
    }
}
