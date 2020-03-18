namespace IS21DotNet.Reports
{
    partial class ReportingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_generate = new System.Windows.Forms.Button();
            this.dgv_reportJob = new System.Windows.Forms.DataGridView();
            this.col_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstcpcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstbrcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstjbcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstmdcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstpgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmststdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmsteddtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstfmcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstrpnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstemalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstcrurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstcrdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstlmurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstlmdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstgpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptmstgpfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dts_reports = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_StDt = new System.Windows.Forms.Label();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_endDt = new System.Windows.Forms.Label();
            this.dtp_EndDt = new System.Windows.Forms.DateTimePicker();
            this.dts_parameters = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Compcd = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.lbl_Brchcd = new System.Windows.Forms.Label();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.lbl_EmailAddres = new System.Windows.Forms.Label();
            this.lbl_rptParam = new System.Windows.Forms.Label();
            this.lbl_Job_cd = new System.Windows.Forms.Label();
            this.txt_rptJobId = new System.Windows.Forms.TextBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_progname = new System.Windows.Forms.Label();
            this.lbl_file_format = new System.Windows.Forms.Label();
            this.cbx_fileformat = new System.Windows.Forms.ComboBox();
            this.lbl_rpt_data = new System.Windows.Forms.Label();
            this.lbl_program_id = new System.Windows.Forms.Label();
            this.lbl_module_id = new System.Windows.Forms.Label();
            this.txt_module = new System.Windows.Forms.TextBox();
            this.txt_program = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.txt_GroupCode = new System.Windows.Forms.TextBox();
            this.lbl_GroupCode = new System.Windows.Forms.Label();
            this.col_datatype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colp_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_param = new System.Windows.Forms.DataGridView();
            this.radbtnYes = new System.Windows.Forms.RadioButton();
            this.lblMailGroup = new System.Windows.Forms.Label();
            this.radbtnNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_parameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_param)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(266, 542);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(174, 26);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate Report";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // dgv_reportJob
            // 
            this.dgv_reportJob.AllowUserToAddRows = false;
            this.dgv_reportJob.AllowUserToDeleteRows = false;
            this.dgv_reportJob.AutoGenerateColumns = false;
            this.dgv_reportJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_company,
            this.col_Branch,
            this.col_jobid,
            this.col_module,
            this.col_program,
            this.col_description,
            this.rptmstcpcdDataGridViewTextBoxColumn,
            this.rptmstbrcdDataGridViewTextBoxColumn,
            this.rptmstjbcdDataGridViewTextBoxColumn,
            this.rptmstdescDataGridViewTextBoxColumn,
            this.rptmstmdcdDataGridViewTextBoxColumn,
            this.rptmstpgidDataGridViewTextBoxColumn,
            this.rptmststdtDataGridViewTextBoxColumn,
            this.rptmsteddtDataGridViewTextBoxColumn,
            this.rptmstfmcdDataGridViewTextBoxColumn,
            this.rptmstrpnmDataGridViewTextBoxColumn,
            this.rptmstemalDataGridViewTextBoxColumn,
            this.rptmstcrurDataGridViewTextBoxColumn,
            this.rptmstcrdtDataGridViewTextBoxColumn,
            this.rptmstlmurDataGridViewTextBoxColumn,
            this.rptmstlmdtDataGridViewTextBoxColumn,
            this.rptmstgpcd,
            this.rptmstgpfg});
            this.dgv_reportJob.DataSource = this.dts_reports;
            this.dgv_reportJob.Location = new System.Drawing.Point(116, 10);
            this.dgv_reportJob.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_reportJob.Name = "dgv_reportJob";
            this.dgv_reportJob.ReadOnly = true;
            this.dgv_reportJob.RowTemplate.Height = 24;
            this.dgv_reportJob.Size = new System.Drawing.Size(1234, 104);
            this.dgv_reportJob.TabIndex = 5;
            this.dgv_reportJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reportJob_CellClick);
            this.dgv_reportJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reportJob_CellContentClick);
            // 
            // col_company
            // 
            this.col_company.DataPropertyName = "rptmstcpcd";
            this.col_company.HeaderText = "Company Code";
            this.col_company.Name = "col_company";
            this.col_company.ReadOnly = true;
            // 
            // col_Branch
            // 
            this.col_Branch.DataPropertyName = "rptmstbrcd";
            this.col_Branch.HeaderText = "Branch Code";
            this.col_Branch.Name = "col_Branch";
            this.col_Branch.ReadOnly = true;
            // 
            // col_jobid
            // 
            this.col_jobid.DataPropertyName = "rptmstjbcd";
            this.col_jobid.HeaderText = "Job ID";
            this.col_jobid.Name = "col_jobid";
            this.col_jobid.ReadOnly = true;
            // 
            // col_module
            // 
            this.col_module.DataPropertyName = "rptmstmdcd";
            this.col_module.HeaderText = "Module ID";
            this.col_module.Name = "col_module";
            this.col_module.ReadOnly = true;
            // 
            // col_program
            // 
            this.col_program.DataPropertyName = "rptmstpgid";
            this.col_program.HeaderText = "Program ID";
            this.col_program.Name = "col_program";
            this.col_program.ReadOnly = true;
            // 
            // col_description
            // 
            this.col_description.DataPropertyName = "rptmstdesc";
            this.col_description.HeaderText = "Description";
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            // 
            // rptmstcpcdDataGridViewTextBoxColumn
            // 
            this.rptmstcpcdDataGridViewTextBoxColumn.DataPropertyName = "rptmstcpcd";
            this.rptmstcpcdDataGridViewTextBoxColumn.HeaderText = "rptmstcpcd";
            this.rptmstcpcdDataGridViewTextBoxColumn.Name = "rptmstcpcdDataGridViewTextBoxColumn";
            this.rptmstcpcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstbrcdDataGridViewTextBoxColumn
            // 
            this.rptmstbrcdDataGridViewTextBoxColumn.DataPropertyName = "rptmstbrcd";
            this.rptmstbrcdDataGridViewTextBoxColumn.HeaderText = "rptmstbrcd";
            this.rptmstbrcdDataGridViewTextBoxColumn.Name = "rptmstbrcdDataGridViewTextBoxColumn";
            this.rptmstbrcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstjbcdDataGridViewTextBoxColumn
            // 
            this.rptmstjbcdDataGridViewTextBoxColumn.DataPropertyName = "rptmstjbcd";
            this.rptmstjbcdDataGridViewTextBoxColumn.HeaderText = "rptmstjbcd";
            this.rptmstjbcdDataGridViewTextBoxColumn.Name = "rptmstjbcdDataGridViewTextBoxColumn";
            this.rptmstjbcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstdescDataGridViewTextBoxColumn
            // 
            this.rptmstdescDataGridViewTextBoxColumn.DataPropertyName = "rptmstdesc";
            this.rptmstdescDataGridViewTextBoxColumn.HeaderText = "rptmstdesc";
            this.rptmstdescDataGridViewTextBoxColumn.Name = "rptmstdescDataGridViewTextBoxColumn";
            this.rptmstdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstmdcdDataGridViewTextBoxColumn
            // 
            this.rptmstmdcdDataGridViewTextBoxColumn.DataPropertyName = "rptmstmdcd";
            this.rptmstmdcdDataGridViewTextBoxColumn.HeaderText = "rptmstmdcd";
            this.rptmstmdcdDataGridViewTextBoxColumn.Name = "rptmstmdcdDataGridViewTextBoxColumn";
            this.rptmstmdcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstpgidDataGridViewTextBoxColumn
            // 
            this.rptmstpgidDataGridViewTextBoxColumn.DataPropertyName = "rptmstpgid";
            this.rptmstpgidDataGridViewTextBoxColumn.HeaderText = "rptmstpgid";
            this.rptmstpgidDataGridViewTextBoxColumn.Name = "rptmstpgidDataGridViewTextBoxColumn";
            this.rptmstpgidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmststdtDataGridViewTextBoxColumn
            // 
            this.rptmststdtDataGridViewTextBoxColumn.DataPropertyName = "rptmststdt";
            this.rptmststdtDataGridViewTextBoxColumn.HeaderText = "rptmststdt";
            this.rptmststdtDataGridViewTextBoxColumn.Name = "rptmststdtDataGridViewTextBoxColumn";
            this.rptmststdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmsteddtDataGridViewTextBoxColumn
            // 
            this.rptmsteddtDataGridViewTextBoxColumn.DataPropertyName = "rptmsteddt";
            this.rptmsteddtDataGridViewTextBoxColumn.HeaderText = "rptmsteddt";
            this.rptmsteddtDataGridViewTextBoxColumn.Name = "rptmsteddtDataGridViewTextBoxColumn";
            this.rptmsteddtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstfmcdDataGridViewTextBoxColumn
            // 
            this.rptmstfmcdDataGridViewTextBoxColumn.DataPropertyName = "rptmstfmcd";
            this.rptmstfmcdDataGridViewTextBoxColumn.HeaderText = "rptmstfmcd";
            this.rptmstfmcdDataGridViewTextBoxColumn.Name = "rptmstfmcdDataGridViewTextBoxColumn";
            this.rptmstfmcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstrpnmDataGridViewTextBoxColumn
            // 
            this.rptmstrpnmDataGridViewTextBoxColumn.DataPropertyName = "rptmstrpnm";
            this.rptmstrpnmDataGridViewTextBoxColumn.HeaderText = "rptmstrpnm";
            this.rptmstrpnmDataGridViewTextBoxColumn.Name = "rptmstrpnmDataGridViewTextBoxColumn";
            this.rptmstrpnmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstemalDataGridViewTextBoxColumn
            // 
            this.rptmstemalDataGridViewTextBoxColumn.DataPropertyName = "rptmstemal";
            this.rptmstemalDataGridViewTextBoxColumn.HeaderText = "rptmstemal";
            this.rptmstemalDataGridViewTextBoxColumn.Name = "rptmstemalDataGridViewTextBoxColumn";
            this.rptmstemalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstcrurDataGridViewTextBoxColumn
            // 
            this.rptmstcrurDataGridViewTextBoxColumn.DataPropertyName = "rptmstcrur";
            this.rptmstcrurDataGridViewTextBoxColumn.HeaderText = "rptmstcrur";
            this.rptmstcrurDataGridViewTextBoxColumn.Name = "rptmstcrurDataGridViewTextBoxColumn";
            this.rptmstcrurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstcrdtDataGridViewTextBoxColumn
            // 
            this.rptmstcrdtDataGridViewTextBoxColumn.DataPropertyName = "rptmstcrdt";
            this.rptmstcrdtDataGridViewTextBoxColumn.HeaderText = "rptmstcrdt";
            this.rptmstcrdtDataGridViewTextBoxColumn.Name = "rptmstcrdtDataGridViewTextBoxColumn";
            this.rptmstcrdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstlmurDataGridViewTextBoxColumn
            // 
            this.rptmstlmurDataGridViewTextBoxColumn.DataPropertyName = "rptmstlmur";
            this.rptmstlmurDataGridViewTextBoxColumn.HeaderText = "rptmstlmur";
            this.rptmstlmurDataGridViewTextBoxColumn.Name = "rptmstlmurDataGridViewTextBoxColumn";
            this.rptmstlmurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstlmdtDataGridViewTextBoxColumn
            // 
            this.rptmstlmdtDataGridViewTextBoxColumn.DataPropertyName = "rptmstlmdt";
            this.rptmstlmdtDataGridViewTextBoxColumn.HeaderText = "rptmstlmdt";
            this.rptmstlmdtDataGridViewTextBoxColumn.Name = "rptmstlmdtDataGridViewTextBoxColumn";
            this.rptmstlmdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rptmstgpcd
            // 
            this.rptmstgpcd.DataPropertyName = "rptmstgpcd";
            this.rptmstgpcd.HeaderText = "rptmstgpcd";
            this.rptmstgpcd.Name = "rptmstgpcd";
            this.rptmstgpcd.ReadOnly = true;
            // 
            // rptmstgpfg
            // 
            this.rptmstgpfg.DataPropertyName = "rptmstgpfg";
            this.rptmstgpfg.HeaderText = "rptmstgpfg";
            this.rptmstgpfg.Name = "rptmstgpfg";
            this.rptmstgpfg.ReadOnly = true;
            // 
            // dts_reports
            // 
            this.dts_reports.DataSource = typeof(IS21DotNet.DataModels.rptjobmst);
            this.dts_reports.CurrentChanged += new System.EventHandler(this.dts_reports_CurrentChanged);
            // 
            // lbl_StDt
            // 
            this.lbl_StDt.AutoSize = true;
            this.lbl_StDt.Location = new System.Drawing.Point(9, 222);
            this.lbl_StDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StDt.Name = "lbl_StDt";
            this.lbl_StDt.Size = new System.Drawing.Size(55, 13);
            this.lbl_StDt.TabIndex = 6;
            this.lbl_StDt.Text = "Start Date";
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.CustomFormat = "yyyy-MM-dd";
            this.dtp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startdate.Location = new System.Drawing.Point(116, 215);
            this.dtp_startdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(123, 20);
            this.dtp_startdate.TabIndex = 8;
            this.dtp_startdate.Value = new System.DateTime(2016, 2, 19, 16, 22, 5, 0);
            // 
            // lbl_endDt
            // 
            this.lbl_endDt.AutoSize = true;
            this.lbl_endDt.Location = new System.Drawing.Point(299, 222);
            this.lbl_endDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_endDt.Name = "lbl_endDt";
            this.lbl_endDt.Size = new System.Drawing.Size(52, 13);
            this.lbl_endDt.TabIndex = 9;
            this.lbl_endDt.Text = "End Date";
            // 
            // dtp_EndDt
            // 
            this.dtp_EndDt.CustomFormat = "yyyy-MM-dd";
            this.dtp_EndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDt.Location = new System.Drawing.Point(410, 215);
            this.dtp_EndDt.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_EndDt.Name = "dtp_EndDt";
            this.dtp_EndDt.Size = new System.Drawing.Size(123, 20);
            this.dtp_EndDt.TabIndex = 11;
            // 
            // dts_parameters
            // 
            this.dts_parameters.DataSource = typeof(IS21DotNet.DataModels.rptjobpam);
            this.dts_parameters.CurrentChanged += new System.EventHandler(this.dts_parameters_CurrentChanged);
            // 
            // lbl_Compcd
            // 
            this.lbl_Compcd.AutoSize = true;
            this.lbl_Compcd.Location = new System.Drawing.Point(9, 160);
            this.lbl_Compcd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Compcd.Name = "lbl_Compcd";
            this.lbl_Compcd.Size = new System.Drawing.Size(79, 13);
            this.lbl_Compcd.TabIndex = 15;
            this.lbl_Compcd.Text = "Company Code";
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(116, 157);
            this.txt_company.Margin = new System.Windows.Forms.Padding(2);
            this.txt_company.Name = "txt_company";
            this.txt_company.ReadOnly = true;
            this.txt_company.Size = new System.Drawing.Size(123, 20);
            this.txt_company.TabIndex = 16;
            // 
            // lbl_Brchcd
            // 
            this.lbl_Brchcd.AutoSize = true;
            this.lbl_Brchcd.Location = new System.Drawing.Point(299, 160);
            this.lbl_Brchcd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Brchcd.Name = "lbl_Brchcd";
            this.lbl_Brchcd.Size = new System.Drawing.Size(69, 13);
            this.lbl_Brchcd.TabIndex = 17;
            this.lbl_Brchcd.Text = "Branch Code";
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(410, 150);
            this.txt_branch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.ReadOnly = true;
            this.txt_branch.Size = new System.Drawing.Size(123, 20);
            this.txt_branch.TabIndex = 18;
            // 
            // lbl_EmailAddres
            // 
            this.lbl_EmailAddres.AutoSize = true;
            this.lbl_EmailAddres.Location = new System.Drawing.Point(8, 320);
            this.lbl_EmailAddres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EmailAddres.Name = "lbl_EmailAddres";
            this.lbl_EmailAddres.Size = new System.Drawing.Size(73, 13);
            this.lbl_EmailAddres.TabIndex = 19;
            this.lbl_EmailAddres.Text = "Email Address";
            // 
            // lbl_rptParam
            // 
            this.lbl_rptParam.AutoSize = true;
            this.lbl_rptParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rptParam.Location = new System.Drawing.Point(0, 344);
            this.lbl_rptParam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rptParam.Name = "lbl_rptParam";
            this.lbl_rptParam.Size = new System.Drawing.Size(112, 13);
            this.lbl_rptParam.TabIndex = 25;
            this.lbl_rptParam.Text = "Report Parameters";
            // 
            // lbl_Job_cd
            // 
            this.lbl_Job_cd.AutoSize = true;
            this.lbl_Job_cd.Location = new System.Drawing.Point(10, 128);
            this.lbl_Job_cd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Job_cd.Name = "lbl_Job_cd";
            this.lbl_Job_cd.Size = new System.Drawing.Size(73, 13);
            this.lbl_Job_cd.TabIndex = 26;
            this.lbl_Job_cd.Text = "Report Job ID";
            // 
            // txt_rptJobId
            // 
            this.txt_rptJobId.Location = new System.Drawing.Point(116, 126);
            this.txt_rptJobId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rptJobId.Name = "txt_rptJobId";
            this.txt_rptJobId.ReadOnly = true;
            this.txt_rptJobId.Size = new System.Drawing.Size(123, 20);
            this.txt_rptJobId.TabIndex = 27;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(298, 128);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(51, 13);
            this.lbl_FileName.TabIndex = 30;
            this.lbl_FileName.Text = "FileName";
            // 
            // lbl_progname
            // 
            this.lbl_progname.AutoSize = true;
            this.lbl_progname.Location = new System.Drawing.Point(114, 29);
            this.lbl_progname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_progname.Name = "lbl_progname";
            this.lbl_progname.Size = new System.Drawing.Size(0, 13);
            this.lbl_progname.TabIndex = 32;
            // 
            // lbl_file_format
            // 
            this.lbl_file_format.AutoSize = true;
            this.lbl_file_format.Location = new System.Drawing.Point(9, 258);
            this.lbl_file_format.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_file_format.Name = "lbl_file_format";
            this.lbl_file_format.Size = new System.Drawing.Size(58, 13);
            this.lbl_file_format.TabIndex = 34;
            this.lbl_file_format.Text = "File Format";
            // 
            // cbx_fileformat
            // 
            this.cbx_fileformat.Items.AddRange(new object[] {
            "pdf",
            "xls",
            "xlsx"});
            this.cbx_fileformat.Location = new System.Drawing.Point(116, 251);
            this.cbx_fileformat.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_fileformat.Name = "cbx_fileformat";
            this.cbx_fileformat.Size = new System.Drawing.Size(123, 21);
            this.cbx_fileformat.TabIndex = 35;
            // 
            // lbl_rpt_data
            // 
            this.lbl_rpt_data.AutoSize = true;
            this.lbl_rpt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpt_data.Location = new System.Drawing.Point(8, 9);
            this.lbl_rpt_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rpt_data.Name = "lbl_rpt_data";
            this.lbl_rpt_data.Size = new System.Drawing.Size(76, 13);
            this.lbl_rpt_data.TabIndex = 36;
            this.lbl_rpt_data.Text = "Report Data";
            // 
            // lbl_program_id
            // 
            this.lbl_program_id.AutoSize = true;
            this.lbl_program_id.Location = new System.Drawing.Point(299, 189);
            this.lbl_program_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_program_id.Name = "lbl_program_id";
            this.lbl_program_id.Size = new System.Drawing.Size(60, 13);
            this.lbl_program_id.TabIndex = 37;
            this.lbl_program_id.Text = "Program ID";
            // 
            // lbl_module_id
            // 
            this.lbl_module_id.AutoSize = true;
            this.lbl_module_id.Location = new System.Drawing.Point(11, 187);
            this.lbl_module_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_module_id.Name = "lbl_module_id";
            this.lbl_module_id.Size = new System.Drawing.Size(56, 13);
            this.lbl_module_id.TabIndex = 38;
            this.lbl_module_id.Text = "Module ID";
            // 
            // txt_module
            // 
            this.txt_module.Location = new System.Drawing.Point(116, 185);
            this.txt_module.Margin = new System.Windows.Forms.Padding(2);
            this.txt_module.Name = "txt_module";
            this.txt_module.ReadOnly = true;
            this.txt_module.Size = new System.Drawing.Size(123, 20);
            this.txt_module.TabIndex = 40;
            // 
            // txt_program
            // 
            this.txt_program.Location = new System.Drawing.Point(410, 184);
            this.txt_program.Margin = new System.Windows.Forms.Padding(2);
            this.txt_program.Name = "txt_program";
            this.txt_program.ReadOnly = true;
            this.txt_program.Size = new System.Drawing.Size(123, 20);
            this.txt_program.TabIndex = 41;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(116, 320);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(217, 20);
            this.txt_email.TabIndex = 42;
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(410, 118);
            this.txt_filename.Margin = new System.Windows.Forms.Padding(2);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.ReadOnly = true;
            this.txt_filename.Size = new System.Drawing.Size(211, 20);
            this.txt_filename.TabIndex = 43;
            // 
            // txt_GroupCode
            // 
            this.txt_GroupCode.Location = new System.Drawing.Point(410, 283);
            this.txt_GroupCode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GroupCode.Name = "txt_GroupCode";
            this.txt_GroupCode.ReadOnly = true;
            this.txt_GroupCode.Size = new System.Drawing.Size(123, 20);
            this.txt_GroupCode.TabIndex = 44;
            // 
            // lbl_GroupCode
            // 
            this.lbl_GroupCode.AutoSize = true;
            this.lbl_GroupCode.Location = new System.Drawing.Point(299, 290);
            this.lbl_GroupCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GroupCode.Name = "lbl_GroupCode";
            this.lbl_GroupCode.Size = new System.Drawing.Size(64, 13);
            this.lbl_GroupCode.TabIndex = 45;
            this.lbl_GroupCode.Text = "Group Code";
            this.lbl_GroupCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // col_datatype
            // 
            this.col_datatype.DataPropertyName = "rptpamvtyp";
            this.col_datatype.HeaderText = "Data Type";
            this.col_datatype.Name = "col_datatype";
            this.col_datatype.ReadOnly = true;
            // 
            // colp_Description
            // 
            this.colp_Description.DataPropertyName = "rptpamdesc";
            this.colp_Description.HeaderText = "Description";
            this.colp_Description.Name = "colp_Description";
            this.colp_Description.ReadOnly = true;
            // 
            // col_value
            // 
            this.col_value.DataPropertyName = "rptpampval";
            this.col_value.HeaderText = "Value";
            this.col_value.Name = "col_value";
            // 
            // col_parameter
            // 
            this.col_parameter.DataPropertyName = "rptpampram";
            this.col_parameter.HeaderText = "Parameter";
            this.col_parameter.Name = "col_parameter";
            this.col_parameter.ReadOnly = true;
            // 
            // dgv_param
            // 
            this.dgv_param.AllowUserToAddRows = false;
            this.dgv_param.AllowUserToDeleteRows = false;
            this.dgv_param.AutoGenerateColumns = false;
            this.dgv_param.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_param.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_parameter,
            this.col_value,
            this.colp_Description,
            this.col_datatype});
            this.dgv_param.DataSource = this.dts_parameters;
            this.dgv_param.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_param.Location = new System.Drawing.Point(116, 344);
            this.dgv_param.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_param.Name = "dgv_param";
            this.dgv_param.RowTemplate.Height = 24;
            this.dgv_param.Size = new System.Drawing.Size(505, 194);
            this.dgv_param.TabIndex = 14;
            // 
            // radbtnYes
            // 
            this.radbtnYes.AutoSize = true;
            this.radbtnYes.Enabled = false;
            this.radbtnYes.Location = new System.Drawing.Point(117, 290);
            this.radbtnYes.Name = "radbtnYes";
            this.radbtnYes.Size = new System.Drawing.Size(43, 17);
            this.radbtnYes.TabIndex = 46;
            this.radbtnYes.Text = "Yes";
            this.radbtnYes.UseVisualStyleBackColor = true;
            this.radbtnYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblMailGroup
            // 
            this.lblMailGroup.AutoSize = true;
            this.lblMailGroup.Location = new System.Drawing.Point(8, 292);
            this.lblMailGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailGroup.Name = "lblMailGroup";
            this.lblMailGroup.Size = new System.Drawing.Size(75, 13);
            this.lblMailGroup.TabIndex = 47;
            this.lblMailGroup.Text = "Send in Group";
            this.lblMailGroup.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radbtnNo
            // 
            this.radbtnNo.AutoSize = true;
            this.radbtnNo.Checked = true;
            this.radbtnNo.Enabled = false;
            this.radbtnNo.Location = new System.Drawing.Point(166, 290);
            this.radbtnNo.Name = "radbtnNo";
            this.radbtnNo.Size = new System.Drawing.Size(39, 17);
            this.radbtnNo.TabIndex = 48;
            this.radbtnNo.TabStop = true;
            this.radbtnNo.Text = "No";
            this.radbtnNo.UseVisualStyleBackColor = true;
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 568);
            this.Controls.Add(this.radbtnNo);
            this.Controls.Add(this.lblMailGroup);
            this.Controls.Add(this.radbtnYes);
            this.Controls.Add(this.lbl_GroupCode);
            this.Controls.Add(this.txt_GroupCode);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_program);
            this.Controls.Add(this.txt_module);
            this.Controls.Add(this.lbl_module_id);
            this.Controls.Add(this.lbl_program_id);
            this.Controls.Add(this.lbl_rpt_data);
            this.Controls.Add(this.cbx_fileformat);
            this.Controls.Add(this.lbl_file_format);
            this.Controls.Add(this.lbl_progname);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.txt_rptJobId);
            this.Controls.Add(this.lbl_Job_cd);
            this.Controls.Add(this.lbl_rptParam);
            this.Controls.Add(this.lbl_EmailAddres);
            this.Controls.Add(this.txt_branch);
            this.Controls.Add(this.lbl_Brchcd);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.lbl_Compcd);
            this.Controls.Add(this.dgv_param);
            this.Controls.Add(this.dtp_EndDt);
            this.Controls.Add(this.lbl_endDt);
            this.Controls.Add(this.dtp_startdate);
            this.Controls.Add(this.lbl_StDt);
            this.Controls.Add(this.dgv_reportJob);
            this.Controls.Add(this.btn_generate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportingForm";
            this.Text = "ReportingForm";
            this.Load += new System.EventHandler(this.ReportingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reportJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_parameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_param)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DataGridView dgv_reportJob;
        private System.Windows.Forms.Label lbl_StDt;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label lbl_endDt;
        private System.Windows.Forms.DateTimePicker dtp_EndDt;
        private System.Windows.Forms.Label lbl_Compcd;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label lbl_Brchcd;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.Label lbl_EmailAddres;
        private System.Windows.Forms.Label lbl_rptParam;
        private System.Windows.Forms.Label lbl_Job_cd;
        private System.Windows.Forms.TextBox txt_rptJobId;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_progname;
        private System.Windows.Forms.Label lbl_file_format;
        private System.Windows.Forms.ComboBox cbx_fileformat;
      
        private System.Windows.Forms.Label lbl_rpt_data;
        private System.Windows.Forms.Label lbl_program_id;
        private System.Windows.Forms.Label lbl_module_id;
        private System.Windows.Forms.TextBox txt_module;
        private System.Windows.Forms.TextBox txt_program;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.BindingSource dts_reports;
        private System.Windows.Forms.BindingSource dts_parameters;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jobid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_module;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_program;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstcpcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstbrcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstjbcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstmdcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstpgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmststdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmsteddtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstfmcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstrpnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstemalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstcrurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstcrdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstlmurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstlmdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_GroupCode;
        private System.Windows.Forms.Label lbl_GroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstgpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datatype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colp_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_parameter;
        private System.Windows.Forms.DataGridView dgv_param;
        private System.Windows.Forms.RadioButton radbtnYes;
        private System.Windows.Forms.Label lblMailGroup;
        private System.Windows.Forms.RadioButton radbtnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptmstgpfg;
    }
}