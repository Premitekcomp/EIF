namespace TMS.AppForms.HR.Emp
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.txtBasicSalaryWithoutAdvance = new System.Windows.Forms.TextBox();
            this.txtTotaLAdvance = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtVariantSalary = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaLAdvanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variantSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCurrentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridEmpSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_EmpSalaryTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpSalaryTableAdapter();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم / كود الموظف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "اجمالى المرتب الاساسى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "الحد الاقصي للمتغير";
            // 
            // cboEmpID
            // 
            this.cboEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.cboEmpID.DisplayMember = "EmpNameAR";
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(363, 25);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(296, 25);
            this.cboEmpID.TabIndex = 1;
            this.cboEmpID.ValueMember = "EmployeeID";
            this.cboEmpID.SelectedIndexChanged += new System.EventHandler(this.cboEmpID_SelectedIndexChanged);
            // 
            // lupEmpNameListBindingSource
            // 
            this.lupEmpNameListBindingSource.DataMember = "Lup_EmpNameList";
            this.lupEmpNameListBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBasicSalaryWithoutAdvance
            // 
            this.txtBasicSalaryWithoutAdvance.Location = new System.Drawing.Point(532, 56);
            this.txtBasicSalaryWithoutAdvance.Name = "txtBasicSalaryWithoutAdvance";
            this.txtBasicSalaryWithoutAdvance.Size = new System.Drawing.Size(127, 24);
            this.txtBasicSalaryWithoutAdvance.TabIndex = 2;
            this.txtBasicSalaryWithoutAdvance.Text = "0";
            this.txtBasicSalaryWithoutAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBasicSalaryWithoutAdvance.TextChanged += new System.EventHandler(this.txtBasicSalaryWithoutAdvance_TextChanged);
            this.txtBasicSalaryWithoutAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasicSalaryWithoutAdvance_KeyPress);
            // 
            // txtTotaLAdvance
            // 
            this.txtTotaLAdvance.Location = new System.Drawing.Point(251, 86);
            this.txtTotaLAdvance.Name = "txtTotaLAdvance";
            this.txtTotaLAdvance.Size = new System.Drawing.Size(31, 24);
            this.txtTotaLAdvance.TabIndex = 3;
            this.txtTotaLAdvance.Text = "0";
            this.txtTotaLAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotaLAdvance.Visible = false;
            this.txtTotaLAdvance.TextChanged += new System.EventHandler(this.txtTotaLAdvance_TextChanged);
            this.txtTotaLAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotaLAdvance_KeyPress);
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtBasicSalary.Location = new System.Drawing.Point(399, 86);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.ReadOnly = true;
            this.txtBasicSalary.Size = new System.Drawing.Size(127, 24);
            this.txtBasicSalary.TabIndex = 4;
            this.txtBasicSalary.Text = "0";
            this.txtBasicSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBasicSalary.Visible = false;
            // 
            // txtVariantSalary
            // 
            this.txtVariantSalary.Location = new System.Drawing.Point(532, 86);
            this.txtVariantSalary.Name = "txtVariantSalary";
            this.txtVariantSalary.Size = new System.Drawing.Size(127, 24);
            this.txtVariantSalary.TabIndex = 5;
            this.txtVariantSalary.Text = "0";
            this.txtVariantSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVariantSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVariantSalary_KeyPress);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(415, 134);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(540, 134);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 13;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNameARDataGridViewTextBoxColumn,
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn,
            this.totaLAdvanceDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.variantSalaryDataGridViewTextBoxColumn,
            this.isCurrentDataGridViewCheckBoxColumn});
            this.gvForm.DataSource = this.gridEmpSalaryBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 192);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(867, 248);
            this.gvForm.TabIndex = 23;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicSalaryWithoutAdvanceDataGridViewTextBoxColumn
            // 
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.DataPropertyName = "BasicSalaryWithoutAdvance";
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.HeaderText = "الأساسي بدون ع.خ";
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.Name = "basicSalaryWithoutAdvanceDataGridViewTextBoxColumn";
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.basicSalaryWithoutAdvanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // totaLAdvanceDataGridViewTextBoxColumn
            // 
            this.totaLAdvanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totaLAdvanceDataGridViewTextBoxColumn.DataPropertyName = "TotaLAdvance";
            this.totaLAdvanceDataGridViewTextBoxColumn.HeaderText = "إجمالي ع.خ";
            this.totaLAdvanceDataGridViewTextBoxColumn.Name = "totaLAdvanceDataGridViewTextBoxColumn";
            this.totaLAdvanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totaLAdvanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "الراتب الأساسي";
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.basicSalaryDataGridViewTextBoxColumn.Width = 117;
            // 
            // variantSalaryDataGridViewTextBoxColumn
            // 
            this.variantSalaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.variantSalaryDataGridViewTextBoxColumn.DataPropertyName = "VariantSalary";
            this.variantSalaryDataGridViewTextBoxColumn.HeaderText = "الراتب المتغير";
            this.variantSalaryDataGridViewTextBoxColumn.Name = "variantSalaryDataGridViewTextBoxColumn";
            this.variantSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCurrentDataGridViewCheckBoxColumn
            // 
            this.isCurrentDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isCurrentDataGridViewCheckBoxColumn.DataPropertyName = "IsCurrent";
            this.isCurrentDataGridViewCheckBoxColumn.HeaderText = "الحالي";
            this.isCurrentDataGridViewCheckBoxColumn.Name = "isCurrentDataGridViewCheckBoxColumn";
            this.isCurrentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCurrentDataGridViewCheckBoxColumn.Width = 53;
            // 
            // gridEmpSalaryBindingSource
            // 
            this.gridEmpSalaryBindingSource.DataMember = "Grid_EmpSalary";
            this.gridEmpSalaryBindingSource.DataSource = this.empDataSet;
            // 
            // grid_EmpSalaryTableAdapter
            // 
            this.grid_EmpSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(891, 440);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            this.PictureBG.Click += new System.EventHandler(this.PictureBG_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpID.DisplayMember = "ExternalID";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(251, 25);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(106, 25);
            this.txtEmpID.TabIndex = 140;
            this.txtEmpID.ValueMember = "EmployeeID";
            this.txtEmpID.SelectedIndexChanged += new System.EventHandler(this.txtEmpID_SelectedIndexChanged);
            // 
            // comboExternalIDBindingSource
            // 
            this.comboExternalIDBindingSource.DataMember = "Combo_ExternalID";
            this.comboExternalIDBindingSource.DataSource = this.empDataSet;
            // 
            // combo_ExternalIDTableAdapter
            // 
            this.combo_ExternalIDTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(891, 440);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtVariantSalary);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.txtTotaLAdvance);
            this.Controls.Add(this.txtBasicSalaryWithoutAdvance);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSalary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتبات العاملين";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.TextBox txtBasicSalaryWithoutAdvance;
        private System.Windows.Forms.TextBox txtTotaLAdvance;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtVariantSalary;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView gvForm;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource gridEmpSalaryBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpSalaryTableAdapter grid_EmpSalaryTableAdapter;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryWithoutAdvanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaLAdvanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCurrentDataGridViewCheckBoxColumn;
    }
}