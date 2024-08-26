namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmHealthInsuranceTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHealthInsuranceTypes));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthInsuranceTypeArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupHealthInsuranceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtHealthInsuranceTypeEn = new System.Windows.Forms.TextBox();
            this.txtHealthInsuranceTypeAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.hR_Lup_HealthInsuranceTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_HealthInsuranceTypesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupHealthInsuranceTypesBindingSource)).BeginInit();
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
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn,
            this.healthInsuranceTypeArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupHealthInsuranceTypesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 184);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(788, 258);
            this.gvForm.TabIndex = 6;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // healthInsuranceTypeIDDataGridViewTextBoxColumn
            // 
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "HealthInsuranceTypeID";
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn.HeaderText = "HealthInsuranceTypeID";
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn.Name = "healthInsuranceTypeIDDataGridViewTextBoxColumn";
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.healthInsuranceTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // healthInsuranceTypeArDataGridViewTextBoxColumn
            // 
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.DataPropertyName = "HealthInsuranceTypeAr";
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.HeaderText = "الاسم عربي";
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.Name = "healthInsuranceTypeArDataGridViewTextBoxColumn";
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.ReadOnly = true;
            this.healthInsuranceTypeArDataGridViewTextBoxColumn.Width = 105;
            // 
            // hRLupHealthInsuranceTypesBindingSource
            // 
            this.hRLupHealthInsuranceTypesBindingSource.DataMember = "HR_Lup_HealthInsuranceTypes";
            this.hRLupHealthInsuranceTypesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 54;
            // 
            // txtHealthInsuranceTypeEn
            // 
            this.txtHealthInsuranceTypeEn.Location = new System.Drawing.Point(406, 60);
            this.txtHealthInsuranceTypeEn.Name = "txtHealthInsuranceTypeEn";
            this.txtHealthInsuranceTypeEn.Size = new System.Drawing.Size(267, 24);
            this.txtHealthInsuranceTypeEn.TabIndex = 1;
            this.txtHealthInsuranceTypeEn.Visible = false;
            // 
            // txtHealthInsuranceTypeAr
            // 
            this.txtHealthInsuranceTypeAr.Location = new System.Drawing.Point(406, 30);
            this.txtHealthInsuranceTypeAr.Name = "txtHealthInsuranceTypeAr";
            this.txtHealthInsuranceTypeAr.Size = new System.Drawing.Size(267, 24);
            this.txtHealthInsuranceTypeAr.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(21, 142);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 5;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(146, 142);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 4;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "الاسم إنجليزي:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "الاسم عربي:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(37, 87);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(131, 24);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "القيمة";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(286, 90);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(387, 88);
            this.txtNotes.TabIndex = 3;
            // 
            // hR_Lup_HealthInsuranceTypesTableAdapter
            // 
            this.hR_Lup_HealthInsuranceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(812, 449);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // frmHealthInsuranceTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtHealthInsuranceTypeEn);
            this.Controls.Add(this.txtHealthInsuranceTypeAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHealthInsuranceTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل انواع التأمين";
            this.Load += new System.EventHandler(this.frmHealthInsuranceTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupHealthInsuranceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtHealthInsuranceTypeEn;
        private System.Windows.Forms.TextBox txtHealthInsuranceTypeAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupHealthInsuranceTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_HealthInsuranceTypesTableAdapter hR_Lup_HealthInsuranceTypesTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInsuranceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInsuranceTypeArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthInsuranceTypeEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}