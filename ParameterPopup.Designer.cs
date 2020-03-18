namespace IS21DotNet.Reports
{
    partial class ParameterPopup
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
            this.lbl_popup_Par = new System.Windows.Forms.Label();
            this.txt_parVal = new System.Windows.Forms.TextBox();
            this.lbl_popup_PamName = new System.Windows.Forms.Label();
            this.lbl_popup_ParVal = new System.Windows.Forms.Label();
            this.btn_popup_ok = new System.Windows.Forms.Button();
            this.lbl_popup_Desc = new System.Windows.Forms.Label();
            this.lbl_popup_DescVal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_popup_Par
            // 
            this.lbl_popup_Par.AutoSize = true;
            this.lbl_popup_Par.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popup_Par.Location = new System.Drawing.Point(85, 29);
            this.lbl_popup_Par.Name = "lbl_popup_Par";
            this.lbl_popup_Par.Size = new System.Drawing.Size(88, 17);
            this.lbl_popup_Par.TabIndex = 0;
            this.lbl_popup_Par.Text = "Parameter ";
            // 
            // txt_parVal
            // 
            this.txt_parVal.Location = new System.Drawing.Point(199, 86);
            this.txt_parVal.Name = "txt_parVal";
            this.txt_parVal.Size = new System.Drawing.Size(168, 22);
            this.txt_parVal.TabIndex = 1;
           
            // 
            // lbl_popup_PamName
            // 
            this.lbl_popup_PamName.AutoSize = true;
            this.lbl_popup_PamName.Location = new System.Drawing.Point(196, 29);
            this.lbl_popup_PamName.Name = "lbl_popup_PamName";
            this.lbl_popup_PamName.Size = new System.Drawing.Size(113, 17);
            this.lbl_popup_PamName.TabIndex = 2;
            this.lbl_popup_PamName.Text = "Parametername ";
            // 
            // lbl_popup_ParVal
            // 
            this.lbl_popup_ParVal.AutoSize = true;
            this.lbl_popup_ParVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popup_ParVal.Location = new System.Drawing.Point(85, 89);
            this.lbl_popup_ParVal.Name = "lbl_popup_ParVal";
            this.lbl_popup_ParVal.Size = new System.Drawing.Size(49, 17);
            this.lbl_popup_ParVal.TabIndex = 3;
            this.lbl_popup_ParVal.Text = "Value";
            // 
            // btn_popup_ok
            // 
            this.btn_popup_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_popup_ok.Location = new System.Drawing.Point(166, 143);
            this.btn_popup_ok.Name = "btn_popup_ok";
            this.btn_popup_ok.Size = new System.Drawing.Size(145, 39);
            this.btn_popup_ok.TabIndex = 4;
            this.btn_popup_ok.Text = "Update Data";
            this.btn_popup_ok.UseVisualStyleBackColor = true;
            // 
            // lbl_popup_Desc
            // 
            this.lbl_popup_Desc.AutoSize = true;
            this.lbl_popup_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popup_Desc.Location = new System.Drawing.Point(85, 57);
            this.lbl_popup_Desc.Name = "lbl_popup_Desc";
            this.lbl_popup_Desc.Size = new System.Drawing.Size(90, 17);
            this.lbl_popup_Desc.TabIndex = 5;
            this.lbl_popup_Desc.Text = "Description";
            // 
            // lbl_popup_DescVal
            // 
            this.lbl_popup_DescVal.AutoSize = true;
            this.lbl_popup_DescVal.Location = new System.Drawing.Point(196, 57);
            this.lbl_popup_DescVal.Name = "lbl_popup_DescVal";
            this.lbl_popup_DescVal.Size = new System.Drawing.Size(115, 17);
            this.lbl_popup_DescVal.TabIndex = 6;
            this.lbl_popup_DescVal.Text = "DescriptionValue";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // popupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 233);
            this.Controls.Add(this.lbl_popup_DescVal);
            this.Controls.Add(this.lbl_popup_Desc);
            this.Controls.Add(this.btn_popup_ok);
            this.Controls.Add(this.lbl_popup_ParVal);
            this.Controls.Add(this.lbl_popup_PamName);
            this.Controls.Add(this.txt_parVal);
            this.Controls.Add(this.lbl_popup_Par);
            this.Name = "popupform";
            this.Text = "popupform";
            this.Load += new System.EventHandler(this.popupform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_popup_Par;
        private System.Windows.Forms.TextBox txt_parVal;
        private System.Windows.Forms.Label lbl_popup_PamName;
        private System.Windows.Forms.Label lbl_popup_ParVal;
        private System.Windows.Forms.Button btn_popup_ok;
        private System.Windows.Forms.Label lbl_popup_Desc;
        private System.Windows.Forms.Label lbl_popup_DescVal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}