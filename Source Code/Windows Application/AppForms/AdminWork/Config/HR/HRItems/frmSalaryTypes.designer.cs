namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmSalaryTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryTypes));
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSalaryTypeName = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.salaryTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupSalaryTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.hR_Lup_SalaryTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SalaryTypesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSalaryTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 8);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // txtSalaryTypeName
            // 
            this.txtSalaryTypeName.Location = new System.Drawing.Point(562, 51);
            this.txtSalaryTypeName.Name = "txtSalaryTypeName";
            this.txtSalaryTypeName.Size = new System.Drawing.Size(267, 24);
            this.txtSalaryTypeName.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(576, 91);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 2;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(710, 91);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 1;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "اسم نوع المرتب";
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryTypeIDDataGridViewTextBoxColumn,
            this.salaryTypeNameDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupSalaryTypesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 38);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(520, 243);
            this.gvForm.TabIndex = 3;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // salaryTypeIDDataGridViewTextBoxColumn
            // 
            this.salaryTypeIDDataGridViewTextBoxColumn.DataPropertyName = "SalaryTypeID";
            this.salaryTypeIDDataGridViewTextBoxColumn.HeaderText = "SalaryTypeID";
            this.salaryTypeIDDataGridViewTextBoxColumn.Name = "salaryTypeIDDataGridViewTextBoxColumn";
            this.salaryTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // salaryTypeNameDataGridViewTextBoxColumn
            // 
            this.salaryTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryTypeNameDataGridViewTextBoxColumn.DataPropertyName = "SalaryTypeName";
            this.salaryTypeNameDataGridViewTextBoxColumn.HeaderText = "اسم نوع المرتب";
            this.salaryTypeNameDataGridViewTextBoxColumn.Name = "salaryTypeNameDataGridViewTextBoxColumn";
            this.salaryTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupSalaryTypesBindingSource
            // 
            this.hRLupSalaryTypesBindingSource.DataMember = "HR_Lup_SalaryTypes";
            this.hRLupSalaryTypesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Lup_SalaryTypesTableAdapter
            // 
            this.hR_Lup_SalaryTypesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(841, 294);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmSalaryTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 294);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtSalaryTypeName);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSalaryTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل انواع المرتب";
            this.Load += new System.EventHandler(this.frmSalaryTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSalaryTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtSalaryTypeName;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvForm;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupSalaryTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SalaryTypesTableAdapter hR_Lup_SalaryTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTypeNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}