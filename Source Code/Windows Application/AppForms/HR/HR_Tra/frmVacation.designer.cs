namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmVacation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacation));
            this.label5 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdVacation = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationFromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationToDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vacationNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTraVacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cbVacationTypeID = new System.Windows.Forms.ComboBox();
            this.hRLupVacationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVacationLength = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.empDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.hR_Lup_VacationTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_VacationTypesTableAdapter();
            this.grid_Tra_VacationsTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_VacationsTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraVacationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupVacationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "من تاريخ:";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(186, 79);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(125, 25);
            this.dtFromDate.TabIndex = 2;
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            this.dtFromDate.Leave += new System.EventHandler(this.dtFromDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "الى";
            // 
            // GrdVacation
            // 
            this.GrdVacation.AllowUserToAddRows = false;
            this.GrdVacation.AllowUserToDeleteRows = false;
            this.GrdVacation.AutoGenerateColumns = false;
            this.GrdVacation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVacation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.vacationFromDateDataGridViewTextBoxColumn,
            this.vacationToDateDataGridViewTextBoxColumn,
            this.vacationLengthDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.isApprovedDataGridViewCheckBoxColumn,
            this.vacationNameArDataGridViewTextBoxColumn});
            this.GrdVacation.DataSource = this.gridTraVacationsBindingSource;
            this.GrdVacation.Location = new System.Drawing.Point(12, 223);
            this.GrdVacation.Name = "GrdVacation";
            this.GrdVacation.ReadOnly = true;
            this.GrdVacation.Size = new System.Drawing.Size(859, 236);
            this.GrdVacation.TabIndex = 8;
            this.GrdVacation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVacation_CellClick);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vacationFromDateDataGridViewTextBoxColumn
            // 
            this.vacationFromDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vacationFromDateDataGridViewTextBoxColumn.DataPropertyName = "VacationFromDate";
            this.vacationFromDateDataGridViewTextBoxColumn.HeaderText = "من يوم";
            this.vacationFromDateDataGridViewTextBoxColumn.Name = "vacationFromDateDataGridViewTextBoxColumn";
            this.vacationFromDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationFromDateDataGridViewTextBoxColumn.Width = 53;
            // 
            // vacationToDateDataGridViewTextBoxColumn
            // 
            this.vacationToDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vacationToDateDataGridViewTextBoxColumn.DataPropertyName = "VacationToDate";
            this.vacationToDateDataGridViewTextBoxColumn.HeaderText = "الي يوم";
            this.vacationToDateDataGridViewTextBoxColumn.Name = "vacationToDateDataGridViewTextBoxColumn";
            this.vacationToDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationToDateDataGridViewTextBoxColumn.Width = 57;
            // 
            // vacationLengthDataGridViewTextBoxColumn
            // 
            this.vacationLengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vacationLengthDataGridViewTextBoxColumn.DataPropertyName = "VacationLength";
            this.vacationLengthDataGridViewTextBoxColumn.HeaderText = "المدة";
            this.vacationLengthDataGridViewTextBoxColumn.Name = "vacationLengthDataGridViewTextBoxColumn";
            this.vacationLengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationLengthDataGridViewTextBoxColumn.Width = 65;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isApprovedDataGridViewCheckBoxColumn
            // 
            this.isApprovedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isApprovedDataGridViewCheckBoxColumn.DataPropertyName = "IsApproved";
            this.isApprovedDataGridViewCheckBoxColumn.HeaderText = "تم الموافقه عليه";
            this.isApprovedDataGridViewCheckBoxColumn.Name = "isApprovedDataGridViewCheckBoxColumn";
            this.isApprovedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isApprovedDataGridViewCheckBoxColumn.Width = 105;
            // 
            // vacationNameArDataGridViewTextBoxColumn
            // 
            this.vacationNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vacationNameArDataGridViewTextBoxColumn.DataPropertyName = "VacationNameAr";
            this.vacationNameArDataGridViewTextBoxColumn.HeaderText = "المدير المباشر";
            this.vacationNameArDataGridViewTextBoxColumn.Name = "vacationNameArDataGridViewTextBoxColumn";
            this.vacationNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationNameArDataGridViewTextBoxColumn.Width = 110;
            // 
            // gridTraVacationsBindingSource
            // 
            this.gridTraVacationsBindingSource.DataMember = "Grid_Tra_Vacations";
            this.gridTraVacationsBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCansel
            // 
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Location = new System.Drawing.Point(558, 164);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(110, 37);
            this.btnCansel.TabIndex = 7;
            this.btnCansel.Text = "الغاء الامر";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Visible = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(674, 164);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(457, 76);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(312, 61);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbVacationTypeID
            // 
            this.cbVacationTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVacationTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVacationTypeID.DataSource = this.hRLupVacationTypesBindingSource;
            this.cbVacationTypeID.DisplayMember = "VacationNameAr";
            this.cbVacationTypeID.FormattingEnabled = true;
            this.cbVacationTypeID.Location = new System.Drawing.Point(18, 48);
            this.cbVacationTypeID.Name = "cbVacationTypeID";
            this.cbVacationTypeID.Size = new System.Drawing.Size(293, 25);
            this.cbVacationTypeID.TabIndex = 1;
            this.cbVacationTypeID.ValueMember = "VacationtypeID";
            // 
            // hRLupVacationTypesBindingSource
            // 
            this.hRLupVacationTypesBindingSource.DataMember = "HR_Lup_VacationTypes";
            this.hRLupVacationTypesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbEmpID
            // 
            this.CbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.CbEmpID.DisplayMember = "EmpNameAR";
            this.CbEmpID.FormattingEnabled = true;
            this.CbEmpID.Location = new System.Drawing.Point(558, 44);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(211, 25);
            this.CbEmpID.TabIndex = 0;
            this.CbEmpID.ValueMember = "EmployeeID";
            this.CbEmpID.SelectedIndexChanged += new System.EventHandler(this.CbEmpID_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(775, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "ملاحظـــات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "طبيعة الاجازات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "الموظف:";
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(18, 79);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(125, 25);
            this.dtToDate.TabIndex = 3;
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            this.dtToDate.Leave += new System.EventHandler(this.dtToDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "المدة:";
            // 
            // txtVacationLength
            // 
            this.txtVacationLength.Location = new System.Drawing.Point(186, 116);
            this.txtVacationLength.Name = "txtVacationLength";
            this.txtVacationLength.ReadOnly = true;
            this.txtVacationLength.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVacationLength.Size = new System.Drawing.Size(125, 25);
            this.txtVacationLength.TabIndex = 4;
            this.txtVacationLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(74, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 18);
            this.lblMsg.TabIndex = 47;
            // 
            // empDataSetBindingSource
            // 
            this.empDataSetBindingSource.DataSource = this.empDataSet;
            this.empDataSetBindingSource.Position = 0;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(457, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // hR_Lup_VacationTypesTableAdapter
            // 
            this.hR_Lup_VacationTypesTableAdapter.ClearBeforeFill = true;
            // 
            // grid_Tra_VacationsTableAdapter
            // 
            this.grid_Tra_VacationsTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(891, 479);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // frmVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 479);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtVacationLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdVacation);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cbVacationTypeID);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmVacation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاجازات";
            this.Load += new System.EventHandler(this.frmVacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraVacationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupVacationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdVacation;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbVacationTypeID;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVacationLength;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.BindingSource empDataSetBindingSource;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupVacationTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_VacationTypesTableAdapter hR_Lup_VacationTypesTableAdapter;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource gridTraVacationsBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_VacationsTableAdapter grid_Tra_VacationsTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationFromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationNameArDataGridViewTextBoxColumn;
    }
}