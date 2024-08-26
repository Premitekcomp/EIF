namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmMilitaryService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMilitaryService));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.militaryServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militaryServiceNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupMilitaryServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtMilitaryServiceNameEn = new System.Windows.Forms.TextBox();
            this.txtMilitaryServiceNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_GenderTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter();
            this.hR_Lup_MilitaryServiceTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMilitaryServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.militaryServiceIDDataGridViewTextBoxColumn,
            this.militaryServiceNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupMilitaryServiceBindingSource;
            this.gvForm.Location = new System.Drawing.Point(21, 32);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(520, 243);
            this.gvForm.TabIndex = 4;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // militaryServiceIDDataGridViewTextBoxColumn
            // 
            this.militaryServiceIDDataGridViewTextBoxColumn.DataPropertyName = "MilitaryServiceID";
            this.militaryServiceIDDataGridViewTextBoxColumn.HeaderText = "MilitaryServiceID";
            this.militaryServiceIDDataGridViewTextBoxColumn.Name = "militaryServiceIDDataGridViewTextBoxColumn";
            this.militaryServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.militaryServiceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // militaryServiceNameArDataGridViewTextBoxColumn
            // 
            this.militaryServiceNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.militaryServiceNameArDataGridViewTextBoxColumn.DataPropertyName = "MilitaryServiceNameAr";
            this.militaryServiceNameArDataGridViewTextBoxColumn.HeaderText = "اسم الموقف (العربي)";
            this.militaryServiceNameArDataGridViewTextBoxColumn.Name = "militaryServiceNameArDataGridViewTextBoxColumn";
            this.militaryServiceNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupMilitaryServiceBindingSource
            // 
            this.hRLupMilitaryServiceBindingSource.DataMember = "HR_Lup_MilitaryService";
            this.hRLupMilitaryServiceBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(21, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 54;
            // 
            // txtMilitaryServiceNameEn
            // 
            this.txtMilitaryServiceNameEn.Location = new System.Drawing.Point(576, 139);
            this.txtMilitaryServiceNameEn.Name = "txtMilitaryServiceNameEn";
            this.txtMilitaryServiceNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtMilitaryServiceNameEn.TabIndex = 1;
            // 
            // txtMilitaryServiceNameAr
            // 
            this.txtMilitaryServiceNameAr.Location = new System.Drawing.Point(576, 62);
            this.txtMilitaryServiceNameAr.Name = "txtMilitaryServiceNameAr";
            this.txtMilitaryServiceNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtMilitaryServiceNameAr.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(576, 190);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 3;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(724, 190);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "اسم النوع (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "اسم النوع (عربي)";
            // 
            // hR_Lup_GenderTableAdapter
            // 
            this.hR_Lup_GenderTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_MilitaryServiceTableAdapter
            // 
            this.hR_Lup_MilitaryServiceTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(858, 299);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 71;
            this.PictureBG.TabStop = false;
            // 
            // frmMilitaryService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(858, 299);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtMilitaryServiceNameEn);
            this.Controls.Add(this.txtMilitaryServiceNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMilitaryService";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الموقف من التجنيد";
            this.Load += new System.EventHandler(this.frmMilitaryService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMilitaryServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtMilitaryServiceNameEn;
        private System.Windows.Forms.TextBox txtMilitaryServiceNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter hR_Lup_GenderTableAdapter;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupMilitaryServiceBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter hR_Lup_MilitaryServiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn militaryServiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn militaryServiceNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn militaryServiceNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}