namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmQualificationsTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualificationsTypes));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.qualificationTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationTypeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupQualificationsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtQualificationTypeNameEn = new System.Windows.Forms.TextBox();
            this.txtQualificationTypeNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Lup_QualificationsTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationsTypesBindingSource)).BeginInit();
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
            this.qualificationTypeIDDataGridViewTextBoxColumn,
            this.qualificationTypeNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupQualificationsTypesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 141);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(520, 274);
            this.gvForm.TabIndex = 4;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // qualificationTypeIDDataGridViewTextBoxColumn
            // 
            this.qualificationTypeIDDataGridViewTextBoxColumn.DataPropertyName = "QualificationTypeID";
            this.qualificationTypeIDDataGridViewTextBoxColumn.HeaderText = "QualificationTypeID";
            this.qualificationTypeIDDataGridViewTextBoxColumn.Name = "qualificationTypeIDDataGridViewTextBoxColumn";
            this.qualificationTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qualificationTypeNameArDataGridViewTextBoxColumn
            // 
            this.qualificationTypeNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualificationTypeNameArDataGridViewTextBoxColumn.DataPropertyName = "QualificationTypeNameAr";
            this.qualificationTypeNameArDataGridViewTextBoxColumn.HeaderText = "نوع المؤهل (عربي)";
            this.qualificationTypeNameArDataGridViewTextBoxColumn.Name = "qualificationTypeNameArDataGridViewTextBoxColumn";
            this.qualificationTypeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupQualificationsTypesBindingSource
            // 
            this.hRLupQualificationsTypesBindingSource.DataMember = "HR_Lup_QualificationsTypes";
            this.hRLupQualificationsTypesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQualificationTypeNameEn
            // 
            this.txtQualificationTypeNameEn.Location = new System.Drawing.Point(102, 61);
            this.txtQualificationTypeNameEn.Name = "txtQualificationTypeNameEn";
            this.txtQualificationTypeNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtQualificationTypeNameEn.TabIndex = 1;
            // 
            // txtQualificationTypeNameAr
            // 
            this.txtQualificationTypeNameAr.Location = new System.Drawing.Point(102, 31);
            this.txtQualificationTypeNameAr.Name = "txtQualificationTypeNameAr";
            this.txtQualificationTypeNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtQualificationTypeNameAr.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(109, 99);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 3;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(257, 99);
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
            this.label2.Location = new System.Drawing.Point(376, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "اسم نوع المؤهل (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "اسم نوع المؤهل (عربي)";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(42, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // hR_Lup_QualificationsTypesTableAdapter
            // 
            this.hR_Lup_QualificationsTypesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(549, 421);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // frmQualificationsTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(549, 421);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtQualificationTypeNameEn);
            this.Controls.Add(this.txtQualificationTypeNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQualificationsTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل نوع المؤهل";
            this.Load += new System.EventHandler(this.frmQualificationsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtQualificationTypeNameEn;
        private System.Windows.Forms.TextBox txtQualificationTypeNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupQualificationsTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter hR_Lup_QualificationsTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationTypeNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationTypeNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}