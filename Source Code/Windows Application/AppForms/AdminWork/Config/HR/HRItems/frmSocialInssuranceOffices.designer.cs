namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmSocialInssuranceOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocialInssuranceOffices));
            this.txtSocialInssuranceOfficeCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupSocialInssuranceOfficesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSocialInssuranceOfficeNameEn = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSocialInssuranceOfficeNameAr = new System.Windows.Forms.TextBox();
            this.hR_Lup_SocialInssuranceOfficesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialInssuranceOfficesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialInssuranceOfficesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSocialInssuranceOfficeCode
            // 
            this.txtSocialInssuranceOfficeCode.Location = new System.Drawing.Point(263, 38);
            this.txtSocialInssuranceOfficeCode.Name = "txtSocialInssuranceOfficeCode";
            this.txtSocialInssuranceOfficeCode.Size = new System.Drawing.Size(169, 24);
            this.txtSocialInssuranceOfficeCode.TabIndex = 0;
            this.txtSocialInssuranceOfficeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "كود المكتب ";
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn,
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupSocialInssuranceOfficesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 191);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(595, 243);
            this.gvForm.TabIndex = 5;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // socialInssuranceOfficeIDDataGridViewTextBoxColumn
            // 
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn.DataPropertyName = "SocialInssuranceOfficeID";
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn.HeaderText = "SocialInssuranceOfficeID";
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn.Name = "socialInssuranceOfficeIDDataGridViewTextBoxColumn";
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.socialInssuranceOfficeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // socialInssuranceOfficeNameArDataGridViewTextBoxColumn
            // 
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn.DataPropertyName = "SocialInssuranceOfficeNameAr";
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn.HeaderText = "اسم المكتب (عربي)";
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn.Name = "socialInssuranceOfficeNameArDataGridViewTextBoxColumn";
            this.socialInssuranceOfficeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupSocialInssuranceOfficesBindingSource
            // 
            this.hRLupSocialInssuranceOfficesBindingSource.DataMember = "HR_Lup_SocialInssuranceOffices";
            this.hRLupSocialInssuranceOfficesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(9, 10);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 72;
            // 
            // txtSocialInssuranceOfficeNameEn
            // 
            this.txtSocialInssuranceOfficeNameEn.Location = new System.Drawing.Point(165, 98);
            this.txtSocialInssuranceOfficeNameEn.Name = "txtSocialInssuranceOfficeNameEn";
            this.txtSocialInssuranceOfficeNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtSocialInssuranceOfficeNameEn.TabIndex = 2;
            this.txtSocialInssuranceOfficeNameEn.Visible = false;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(165, 139);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 4;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(313, 139);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "اسم المكتب (انجليزي)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "اسم المكتب (عربي)";
            // 
            // txtSocialInssuranceOfficeNameAr
            // 
            this.txtSocialInssuranceOfficeNameAr.Location = new System.Drawing.Point(165, 68);
            this.txtSocialInssuranceOfficeNameAr.Name = "txtSocialInssuranceOfficeNameAr";
            this.txtSocialInssuranceOfficeNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtSocialInssuranceOfficeNameAr.TabIndex = 1;
            // 
            // hR_Lup_SocialInssuranceOfficesTableAdapter
            // 
            this.hR_Lup_SocialInssuranceOfficesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(624, 444);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 75;
            this.PictureBG.TabStop = false;
            // 
            // frmSocialInssuranceOffices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.txtSocialInssuranceOfficeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtSocialInssuranceOfficeNameEn);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSocialInssuranceOfficeNameAr);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSocialInssuranceOffices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل مكاتب التأمين الاجتماعي";
            this.Load += new System.EventHandler(this.frmSocialInssuranceOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialInssuranceOfficesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSocialInssuranceOfficeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtSocialInssuranceOfficeNameEn;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSocialInssuranceOfficeNameAr;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupSocialInssuranceOfficesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialInssuranceOfficesTableAdapter hR_Lup_SocialInssuranceOfficesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialInssuranceOfficeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialInssuranceOfficeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialInssuranceOfficeNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialInssuranceOfficeNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}