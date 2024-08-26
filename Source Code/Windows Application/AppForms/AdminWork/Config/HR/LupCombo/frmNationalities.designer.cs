namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmNationalities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNationalities));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.nationalityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupNationalitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtNationalityNameEn = new System.Windows.Forms.TextBox();
            this.txtNationalityNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_GenderTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter();
            this.hR_Lup_MilitaryServiceTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter();
            this.txtNationalityCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hR_Lup_NationalitiesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_NationalitiesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupNationalitiesBindingSource)).BeginInit();
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
            this.nationalityIDDataGridViewTextBoxColumn,
            this.nationalityNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupNationalitiesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 191);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(595, 243);
            this.gvForm.TabIndex = 5;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // nationalityIDDataGridViewTextBoxColumn
            // 
            this.nationalityIDDataGridViewTextBoxColumn.DataPropertyName = "NationalityID";
            this.nationalityIDDataGridViewTextBoxColumn.HeaderText = "NationalityID";
            this.nationalityIDDataGridViewTextBoxColumn.Name = "nationalityIDDataGridViewTextBoxColumn";
            this.nationalityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalityNameArDataGridViewTextBoxColumn
            // 
            this.nationalityNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationalityNameArDataGridViewTextBoxColumn.DataPropertyName = "NationalityNameAr";
            this.nationalityNameArDataGridViewTextBoxColumn.HeaderText = "اسم الجنسية (عربي)";
            this.nationalityNameArDataGridViewTextBoxColumn.Name = "nationalityNameArDataGridViewTextBoxColumn";
            this.nationalityNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupNationalitiesBindingSource
            // 
            this.hRLupNationalitiesBindingSource.DataMember = "HR_Lup_Nationalities";
            this.hRLupNationalitiesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(26, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 62;
            // 
            // txtNationalityNameEn
            // 
            this.txtNationalityNameEn.Location = new System.Drawing.Point(165, 98);
            this.txtNationalityNameEn.Name = "txtNationalityNameEn";
            this.txtNationalityNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtNationalityNameEn.TabIndex = 2;
            // 
            // txtNationalityNameAr
            // 
            this.txtNationalityNameAr.Location = new System.Drawing.Point(165, 68);
            this.txtNationalityNameAr.Name = "txtNationalityNameAr";
            this.txtNationalityNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtNationalityNameAr.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(452, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "اسم الجنسية (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "اسم الجنسية (عربي)";
            // 
            // hR_Lup_GenderTableAdapter
            // 
            this.hR_Lup_GenderTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_MilitaryServiceTableAdapter
            // 
            this.hR_Lup_MilitaryServiceTableAdapter.ClearBeforeFill = true;
            // 
            // txtNationalityCode
            // 
            this.txtNationalityCode.Location = new System.Drawing.Point(263, 38);
            this.txtNationalityCode.Name = "txtNationalityCode";
            this.txtNationalityCode.Size = new System.Drawing.Size(169, 24);
            this.txtNationalityCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "مختصر الدولة";
            // 
            // hR_Lup_NationalitiesTableAdapter
            // 
            this.hR_Lup_NationalitiesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(619, 443);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // frmNationalities
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.txtNationalityCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtNationalityNameEn);
            this.Controls.Add(this.txtNationalityNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNationalities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الجنسيات";
            this.Load += new System.EventHandler(this.frmNationalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupNationalitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtNationalityNameEn;
        private System.Windows.Forms.TextBox txtNationalityNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter hR_Lup_GenderTableAdapter;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter hR_Lup_MilitaryServiceTableAdapter;
        private System.Windows.Forms.TextBox txtNationalityCode;
        private System.Windows.Forms.Label label3;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupNationalitiesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_NationalitiesTableAdapter hR_Lup_NationalitiesTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityNameEnDataGridViewTextBoxColumn;
    }
}