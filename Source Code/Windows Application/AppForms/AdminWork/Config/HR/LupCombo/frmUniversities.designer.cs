namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmUniversities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUniversities));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.universityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupUniversitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtUniversityNameEn = new System.Windows.Forms.TextBox();
            this.txtUniversityNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Lup_UniversitiesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_UniversitiesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupUniversitiesBindingSource)).BeginInit();
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
            this.universityIDDataGridViewTextBoxColumn,
            this.universityNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupUniversitiesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 32);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(602, 280);
            this.gvForm.TabIndex = 67;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // universityIDDataGridViewTextBoxColumn
            // 
            this.universityIDDataGridViewTextBoxColumn.DataPropertyName = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.HeaderText = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.Name = "universityIDDataGridViewTextBoxColumn";
            this.universityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.universityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // universityNameArDataGridViewTextBoxColumn
            // 
            this.universityNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.universityNameArDataGridViewTextBoxColumn.DataPropertyName = "UniversityNameAr";
            this.universityNameArDataGridViewTextBoxColumn.HeaderText = "اسم الجامعة (عربي)";
            this.universityNameArDataGridViewTextBoxColumn.Name = "universityNameArDataGridViewTextBoxColumn";
            this.universityNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupUniversitiesBindingSource
            // 
            this.hRLupUniversitiesBindingSource.DataMember = "HR_Lup_Universities";
            this.hRLupUniversitiesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUniversityNameEn
            // 
            this.txtUniversityNameEn.Location = new System.Drawing.Point(629, 118);
            this.txtUniversityNameEn.Name = "txtUniversityNameEn";
            this.txtUniversityNameEn.Size = new System.Drawing.Size(231, 24);
            this.txtUniversityNameEn.TabIndex = 64;
            // 
            // txtUniversityNameAr
            // 
            this.txtUniversityNameAr.Location = new System.Drawing.Point(629, 56);
            this.txtUniversityNameAr.Name = "txtUniversityNameAr";
            this.txtUniversityNameAr.Size = new System.Drawing.Size(231, 24);
            this.txtUniversityNameAr.TabIndex = 63;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(629, 152);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(106, 36);
            this.btnSaveClose.TabIndex = 66;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(754, 152);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(106, 36);
            this.btnSaveNew.TabIndex = 65;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "اسم الجامعة (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "اسم الجامعة (عربي)";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(22, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // hR_Lup_UniversitiesTableAdapter
            // 
            this.hR_Lup_UniversitiesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(870, 320);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmUniversities
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(870, 320);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtUniversityNameEn);
            this.Controls.Add(this.txtUniversityNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUniversities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الجامعات";
            this.Load += new System.EventHandler(this.frmUniversities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupUniversitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtUniversityNameEn;
        private System.Windows.Forms.TextBox txtUniversityNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupUniversitiesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_UniversitiesTableAdapter hR_Lup_UniversitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}