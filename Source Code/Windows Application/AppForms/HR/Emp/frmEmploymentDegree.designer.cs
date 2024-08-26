namespace TMS.AppForms.HR.Emp
{
    partial class frmEmploymentDegree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmploymentDegree));
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCurrentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpEmploymentDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.txtDegreeID = new System.Windows.Forms.ComboBox();
            this.hRLupDegreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hR_Lup_DegreesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DegreesTableAdapter();
            this.grid_Emp_EmploymentDegreeTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_EmploymentDegreeTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.IsCurrent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpEmploymentDegreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDegreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(607, 91);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(150, 24);
            this.dtFromDate.TabIndex = 3;
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
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.empNameARDataGridViewTextBoxColumn,
            this.degreeNameArDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.isCurrentDataGridViewCheckBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridEmpEmploymentDegreeBindingSource;
            this.gvForm.Location = new System.Drawing.Point(24, 197);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(874, 213);
            this.gvForm.TabIndex = 51;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeDegreeID";
            this.Column1.HeaderText = "EmployeeDegreeID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeNameArDataGridViewTextBoxColumn
            // 
            this.degreeNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.degreeNameArDataGridViewTextBoxColumn.DataPropertyName = "DegreeNameAr";
            this.degreeNameArDataGridViewTextBoxColumn.HeaderText = "الدرجة الوظيفية";
            this.degreeNameArDataGridViewTextBoxColumn.Name = "degreeNameArDataGridViewTextBoxColumn";
            this.degreeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeNameArDataGridViewTextBoxColumn.Width = 121;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "من تاريخ";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDateDataGridViewTextBoxColumn.Width = 82;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "الي تاريخ";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.toDateDataGridViewTextBoxColumn.Width = 85;
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
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 84;
            // 
            // gridEmpEmploymentDegreeBindingSource
            // 
            this.gridEmpEmploymentDegreeBindingSource.DataMember = "Grid_Emp_EmploymentDegree";
            this.gridEmpEmploymentDegreeBindingSource.DataSource = this.empDataSet;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(31, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 50;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(24, 155);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(149, 155);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "في الفترة من / الي:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "الوظيفه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "اسم / كود الموظف:";
            // 
            // CbEmpID
            // 
            this.CbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.CbEmpID.DisplayMember = "EmpNameAR";
            this.CbEmpID.FormattingEnabled = true;
            this.CbEmpID.Location = new System.Drawing.Point(471, 29);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(286, 25);
            this.CbEmpID.TabIndex = 1;
            this.CbEmpID.ValueMember = "EmployeeID";
            this.CbEmpID.SelectedIndexChanged += new System.EventHandler(this.CbEmpID_SelectedIndexChanged);
            // 
            // txtDegreeID
            // 
            this.txtDegreeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDegreeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDegreeID.DataSource = this.hRLupDegreesBindingSource;
            this.txtDegreeID.DisplayMember = "DegreeNameAr";
            this.txtDegreeID.FormattingEnabled = true;
            this.txtDegreeID.Location = new System.Drawing.Point(471, 60);
            this.txtDegreeID.Name = "txtDegreeID";
            this.txtDegreeID.Size = new System.Drawing.Size(286, 25);
            this.txtDegreeID.TabIndex = 2;
            this.txtDegreeID.ValueMember = "DegreeID";
            // 
            // hRLupDegreesBindingSource
            // 
            this.hRLupDegreesBindingSource.DataMember = "HR_Lup_Degrees";
            this.hRLupDegreesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(405, 121);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(352, 69);
            this.txtNote.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "ملاحظـــات:";
            // 
            // hR_Lup_DegreesTableAdapter
            // 
            this.hR_Lup_DegreesTableAdapter.ClearBeforeFill = true;
            // 
            // grid_Emp_EmploymentDegreeTableAdapter
            // 
            this.grid_Emp_EmploymentDegreeTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(913, 423);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpID.DisplayMember = "ExternalID";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(359, 29);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(106, 25);
            this.txtEmpID.TabIndex = 138;
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
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(451, 91);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(150, 24);
            this.dtEndDate.TabIndex = 139;
            // 
            // IsCurrent
            // 
            this.IsCurrent.AutoSize = true;
            this.IsCurrent.Location = new System.Drawing.Point(331, 94);
            this.IsCurrent.Name = "IsCurrent";
            this.IsCurrent.Size = new System.Drawing.Size(77, 21);
            this.IsCurrent.TabIndex = 140;
            this.IsCurrent.Text = "الحالي ؟";
            this.IsCurrent.UseVisualStyleBackColor = true;
            // 
            // frmEmploymentDegree
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(913, 423);
            this.Controls.Add(this.IsCurrent);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDegreeID);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEmploymentDegree";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدرجات الوظيفيه";
            this.Load += new System.EventHandler(this.frmEmploymentDegree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpEmploymentDegreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDegreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.ComboBox txtDegreeID;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupDegreesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DegreesTableAdapter hR_Lup_DegreesTableAdapter;
        private System.Windows.Forms.BindingSource gridEmpEmploymentDegreeBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_EmploymentDegreeTableAdapter grid_Emp_EmploymentDegreeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCurrentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.CheckBox IsCurrent;
    }
}