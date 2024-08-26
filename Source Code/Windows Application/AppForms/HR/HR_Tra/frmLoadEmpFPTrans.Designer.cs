namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmLoadEmpFPTrans
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.dtStartRange = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_NameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndRange = new System.Windows.Forms.DateTimePicker();
            this.CmdShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hRTraEmpAttendanceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.hR_Tra_EmpAttendanceViewTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_EmpAttendanceViewTableAdapter();
            this.CmdXLS = new System.Windows.Forms.Button();
            this.CmdShowTotals = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.employeeFPNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMorningLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumLeaveLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumPermissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumVacationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRTraEmpAttendanceTotalsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Tra_EmpAttendanceTotalsViewTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_EmpAttendanceTotalsViewTableAdapter();
            this.employeeAttendanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatePenality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOutDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inMissionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leavePermissionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HourCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inVacationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VacationNameAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenalityByDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenalityByValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyNameAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BouncByDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BounceByValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonusNameAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraEmpAttendanceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraEmpAttendanceTotalsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1071, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboNameListBindingSource;
            this.txtEmpID.DisplayMember = "EmpNameAR";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(777, 0);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(182, 25);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.ValueMember = "EmployeeID";
            // 
            // comboNameListBindingSource
            // 
            this.comboNameListBindingSource.DataMember = "Combo_NameList";
            this.comboNameListBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtStartRange
            // 
            this.dtStartRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartRange.Location = new System.Drawing.Point(520, 0);
            this.dtStartRange.Name = "dtStartRange";
            this.dtStartRange.Size = new System.Drawing.Size(129, 24);
            this.dtStartRange.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "أسم الموظف:";
            // 
            // combo_NameListTableAdapter
            // 
            this.combo_NameListTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "عن الفترة من:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ألي:";
            // 
            // dtEndRange
            // 
            this.dtEndRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndRange.Location = new System.Drawing.Point(346, 0);
            this.dtEndRange.Name = "dtEndRange";
            this.dtEndRange.Size = new System.Drawing.Size(129, 24);
            this.dtEndRange.TabIndex = 6;
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Location = new System.Drawing.Point(273, -4);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(67, 30);
            this.CmdShow.TabIndex = 7;
            this.CmdShow.Text = "تفصيلي";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeAttendanceIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.missionIDDataGridViewTextBoxColumn,
            this.permissionIDDataGridViewTextBoxColumn,
            this.vacationtypeIDDataGridViewTextBoxColumn,
            this.empNameARDataGridViewTextBoxColumn,
            this.employeeFPNoDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.expectedFromDataGridViewTextBoxColumn,
            this.actualFromDataGridViewTextBoxColumn,
            this.cInDiffDataGridViewTextBoxColumn,
            this.LatePenality,
            this.expectedToDataGridViewTextBoxColumn,
            this.actualToDataGridViewTextBoxColumn,
            this.cOutDiffDataGridViewTextBoxColumn,
            this.inMissionDataGridViewCheckBoxColumn,
            this.leavePermissionDataGridViewCheckBoxColumn,
            this.HourCount,
            this.inVacationDataGridViewCheckBoxColumn,
            this.VacationNameAr,
            this.PenalityByDay,
            this.PenalityByValue,
            this.PenaltyNameAr,
            this.BouncByDay,
            this.BounceByValue,
            this.BonusNameAr});
            this.dataGridView1.DataSource = this.hRTraEmpAttendanceViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 444);
            this.dataGridView1.TabIndex = 8;
            // 
            // hRTraEmpAttendanceViewBindingSource
            // 
            this.hRTraEmpAttendanceViewBindingSource.DataMember = "HR_Tra_EmpAttendanceView";
            this.hRTraEmpAttendanceViewBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Tra_EmpAttendanceViewTableAdapter
            // 
            this.hR_Tra_EmpAttendanceViewTableAdapter.ClearBeforeFill = true;
            // 
            // CmdXLS
            // 
            this.CmdXLS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmdXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdXLS.Location = new System.Drawing.Point(225, -4);
            this.CmdXLS.Name = "CmdXLS";
            this.CmdXLS.Size = new System.Drawing.Size(42, 30);
            this.CmdXLS.TabIndex = 9;
            this.CmdXLS.Text = "XLS";
            this.CmdXLS.UseVisualStyleBackColor = false;
            this.CmdXLS.Click += new System.EventHandler(this.CmdXLS_Click);
            // 
            // CmdShowTotals
            // 
            this.CmdShowTotals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmdShowTotals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShowTotals.Location = new System.Drawing.Point(123, -5);
            this.CmdShowTotals.Name = "CmdShowTotals";
            this.CmdShowTotals.Size = new System.Drawing.Size(67, 30);
            this.CmdShowTotals.TabIndex = 10;
            this.CmdShowTotals.Text = "إجمالي";
            this.CmdShowTotals.UseVisualStyleBackColor = false;
            this.CmdShowTotals.Click += new System.EventHandler(this.CmdShowTotals_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeFPNoDataGridViewTextBoxColumn1,
            this.empNameARDataGridViewTextBoxColumn1,
            this.sumMorningLateDataGridViewTextBoxColumn,
            this.sumLeaveLateDataGridViewTextBoxColumn,
            this.totalMinDataGridViewTextBoxColumn,
            this.sumMissionDataGridViewTextBoxColumn,
            this.sumPermissionDataGridViewTextBoxColumn,
            this.sumHoursDataGridViewTextBoxColumn,
            this.sumVacationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hRTraEmpAttendanceTotalsViewBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 444);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.Visible = false;
            // 
            // employeeFPNoDataGridViewTextBoxColumn1
            // 
            this.employeeFPNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeFPNoDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeFPNo";
            this.employeeFPNoDataGridViewTextBoxColumn1.HeaderText = "كود البصمه";
            this.employeeFPNoDataGridViewTextBoxColumn1.Name = "employeeFPNoDataGridViewTextBoxColumn1";
            this.employeeFPNoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.employeeFPNoDataGridViewTextBoxColumn1.Width = 97;
            // 
            // empNameARDataGridViewTextBoxColumn1
            // 
            this.empNameARDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn1.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn1.HeaderText = "أسم الموظف";
            this.empNameARDataGridViewTextBoxColumn1.Name = "empNameARDataGridViewTextBoxColumn1";
            this.empNameARDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sumMorningLateDataGridViewTextBoxColumn
            // 
            this.sumMorningLateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumMorningLateDataGridViewTextBoxColumn.DataPropertyName = "SumMorningLate";
            this.sumMorningLateDataGridViewTextBoxColumn.HeaderText = "تأخير حضور";
            this.sumMorningLateDataGridViewTextBoxColumn.Name = "sumMorningLateDataGridViewTextBoxColumn";
            this.sumMorningLateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMorningLateDataGridViewTextBoxColumn.Width = 96;
            // 
            // sumLeaveLateDataGridViewTextBoxColumn
            // 
            this.sumLeaveLateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumLeaveLateDataGridViewTextBoxColumn.DataPropertyName = "SumLeaveLate";
            this.sumLeaveLateDataGridViewTextBoxColumn.HeaderText = "أنصراف مبكر";
            this.sumLeaveLateDataGridViewTextBoxColumn.Name = "sumLeaveLateDataGridViewTextBoxColumn";
            this.sumLeaveLateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumLeaveLateDataGridViewTextBoxColumn.Width = 101;
            // 
            // totalMinDataGridViewTextBoxColumn
            // 
            this.totalMinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalMinDataGridViewTextBoxColumn.DataPropertyName = "TotalMin";
            this.totalMinDataGridViewTextBoxColumn.HeaderText = "إجمالي التأخير";
            this.totalMinDataGridViewTextBoxColumn.Name = "totalMinDataGridViewTextBoxColumn";
            this.totalMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalMinDataGridViewTextBoxColumn.Width = 116;
            // 
            // sumMissionDataGridViewTextBoxColumn
            // 
            this.sumMissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumMissionDataGridViewTextBoxColumn.DataPropertyName = "SumMission";
            this.sumMissionDataGridViewTextBoxColumn.HeaderText = "عدد المأموريات";
            this.sumMissionDataGridViewTextBoxColumn.Name = "sumMissionDataGridViewTextBoxColumn";
            this.sumMissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMissionDataGridViewTextBoxColumn.Width = 117;
            // 
            // sumPermissionDataGridViewTextBoxColumn
            // 
            this.sumPermissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumPermissionDataGridViewTextBoxColumn.DataPropertyName = "SumPermission";
            this.sumPermissionDataGridViewTextBoxColumn.HeaderText = "عدد الإذون";
            this.sumPermissionDataGridViewTextBoxColumn.Name = "sumPermissionDataGridViewTextBoxColumn";
            this.sumPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumPermissionDataGridViewTextBoxColumn.Width = 94;
            // 
            // sumHoursDataGridViewTextBoxColumn
            // 
            this.sumHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumHoursDataGridViewTextBoxColumn.DataPropertyName = "SumHours";
            this.sumHoursDataGridViewTextBoxColumn.HeaderText = "مجموع الاذون";
            this.sumHoursDataGridViewTextBoxColumn.Name = "sumHoursDataGridViewTextBoxColumn";
            this.sumHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumHoursDataGridViewTextBoxColumn.Width = 111;
            // 
            // sumVacationDataGridViewTextBoxColumn
            // 
            this.sumVacationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumVacationDataGridViewTextBoxColumn.DataPropertyName = "SumVacation";
            this.sumVacationDataGridViewTextBoxColumn.HeaderText = "عدد الاجازات";
            this.sumVacationDataGridViewTextBoxColumn.Name = "sumVacationDataGridViewTextBoxColumn";
            this.sumVacationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumVacationDataGridViewTextBoxColumn.Width = 104;
            // 
            // hRTraEmpAttendanceTotalsViewBindingSource
            // 
            this.hRTraEmpAttendanceTotalsViewBindingSource.DataMember = "HR_Tra_EmpAttendanceTotalsView";
            this.hRTraEmpAttendanceTotalsViewBindingSource.DataSource = this.traDataSet;
            // 
            // hR_Tra_EmpAttendanceTotalsViewTableAdapter
            // 
            this.hR_Tra_EmpAttendanceTotalsViewTableAdapter.ClearBeforeFill = true;
            // 
            // employeeAttendanceIDDataGridViewTextBoxColumn
            // 
            this.employeeAttendanceIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeAttendanceID";
            this.employeeAttendanceIDDataGridViewTextBoxColumn.HeaderText = "EmployeeAttendanceID";
            this.employeeAttendanceIDDataGridViewTextBoxColumn.Name = "employeeAttendanceIDDataGridViewTextBoxColumn";
            this.employeeAttendanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeAttendanceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // missionIDDataGridViewTextBoxColumn
            // 
            this.missionIDDataGridViewTextBoxColumn.DataPropertyName = "MissionID";
            this.missionIDDataGridViewTextBoxColumn.HeaderText = "MissionID";
            this.missionIDDataGridViewTextBoxColumn.Name = "missionIDDataGridViewTextBoxColumn";
            this.missionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.missionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // permissionIDDataGridViewTextBoxColumn
            // 
            this.permissionIDDataGridViewTextBoxColumn.DataPropertyName = "PermissionID";
            this.permissionIDDataGridViewTextBoxColumn.HeaderText = "PermissionID";
            this.permissionIDDataGridViewTextBoxColumn.Name = "permissionIDDataGridViewTextBoxColumn";
            this.permissionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vacationtypeIDDataGridViewTextBoxColumn
            // 
            this.vacationtypeIDDataGridViewTextBoxColumn.DataPropertyName = "VacationtypeID";
            this.vacationtypeIDDataGridViewTextBoxColumn.HeaderText = "VacationtypeID";
            this.vacationtypeIDDataGridViewTextBoxColumn.Name = "vacationtypeIDDataGridViewTextBoxColumn";
            this.vacationtypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationtypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameARDataGridViewTextBoxColumn.Width = 69;
            // 
            // employeeFPNoDataGridViewTextBoxColumn
            // 
            this.employeeFPNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeFPNoDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFPNo";
            this.employeeFPNoDataGridViewTextBoxColumn.HeaderText = "رقم البصمه";
            this.employeeFPNoDataGridViewTextBoxColumn.Name = "employeeFPNoDataGridViewTextBoxColumn";
            this.employeeFPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeFPNoDataGridViewTextBoxColumn.Width = 98;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            this.attendanceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceDateDataGridViewTextBoxColumn.Width = 68;
            // 
            // expectedFromDataGridViewTextBoxColumn
            // 
            this.expectedFromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expectedFromDataGridViewTextBoxColumn.DataPropertyName = "ExpectedFrom";
            this.expectedFromDataGridViewTextBoxColumn.HeaderText = "الوصول المتوقع";
            this.expectedFromDataGridViewTextBoxColumn.Name = "expectedFromDataGridViewTextBoxColumn";
            this.expectedFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.expectedFromDataGridViewTextBoxColumn.Width = 117;
            // 
            // actualFromDataGridViewTextBoxColumn
            // 
            this.actualFromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actualFromDataGridViewTextBoxColumn.DataPropertyName = "ActualFrom";
            this.actualFromDataGridViewTextBoxColumn.HeaderText = "الوصول الحقيقي";
            this.actualFromDataGridViewTextBoxColumn.Name = "actualFromDataGridViewTextBoxColumn";
            this.actualFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualFromDataGridViewTextBoxColumn.Width = 126;
            // 
            // cInDiffDataGridViewTextBoxColumn
            // 
            this.cInDiffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cInDiffDataGridViewTextBoxColumn.DataPropertyName = "CInDiff";
            this.cInDiffDataGridViewTextBoxColumn.HeaderText = "تأخير";
            this.cInDiffDataGridViewTextBoxColumn.Name = "cInDiffDataGridViewTextBoxColumn";
            this.cInDiffDataGridViewTextBoxColumn.ReadOnly = true;
            this.cInDiffDataGridViewTextBoxColumn.Width = 61;
            // 
            // LatePenality
            // 
            this.LatePenality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LatePenality.DataPropertyName = "LatePenality";
            this.LatePenality.HeaderText = "خصم التأخير (ايام)";
            this.LatePenality.Name = "LatePenality";
            this.LatePenality.ReadOnly = true;
            this.LatePenality.Width = 124;
            // 
            // expectedToDataGridViewTextBoxColumn
            // 
            this.expectedToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expectedToDataGridViewTextBoxColumn.DataPropertyName = "ExpectedTo";
            this.expectedToDataGridViewTextBoxColumn.HeaderText = "المغادره المتوقع";
            this.expectedToDataGridViewTextBoxColumn.Name = "expectedToDataGridViewTextBoxColumn";
            this.expectedToDataGridViewTextBoxColumn.ReadOnly = true;
            this.expectedToDataGridViewTextBoxColumn.Width = 114;
            // 
            // actualToDataGridViewTextBoxColumn
            // 
            this.actualToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actualToDataGridViewTextBoxColumn.DataPropertyName = "ActualTo";
            this.actualToDataGridViewTextBoxColumn.HeaderText = "المغادره الحقيقي";
            this.actualToDataGridViewTextBoxColumn.Name = "actualToDataGridViewTextBoxColumn";
            this.actualToDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualToDataGridViewTextBoxColumn.Width = 122;
            // 
            // cOutDiffDataGridViewTextBoxColumn
            // 
            this.cOutDiffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOutDiffDataGridViewTextBoxColumn.DataPropertyName = "COutDiff";
            this.cOutDiffDataGridViewTextBoxColumn.HeaderText = "الفرق";
            this.cOutDiffDataGridViewTextBoxColumn.Name = "cOutDiffDataGridViewTextBoxColumn";
            this.cOutDiffDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOutDiffDataGridViewTextBoxColumn.Width = 65;
            // 
            // inMissionDataGridViewCheckBoxColumn
            // 
            this.inMissionDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inMissionDataGridViewCheckBoxColumn.DataPropertyName = "InMission";
            this.inMissionDataGridViewCheckBoxColumn.HeaderText = "مأموريه";
            this.inMissionDataGridViewCheckBoxColumn.Name = "inMissionDataGridViewCheckBoxColumn";
            this.inMissionDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inMissionDataGridViewCheckBoxColumn.Width = 55;
            // 
            // leavePermissionDataGridViewCheckBoxColumn
            // 
            this.leavePermissionDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leavePermissionDataGridViewCheckBoxColumn.DataPropertyName = "leavePermission";
            this.leavePermissionDataGridViewCheckBoxColumn.HeaderText = "إذن ";
            this.leavePermissionDataGridViewCheckBoxColumn.Name = "leavePermissionDataGridViewCheckBoxColumn";
            this.leavePermissionDataGridViewCheckBoxColumn.ReadOnly = true;
            this.leavePermissionDataGridViewCheckBoxColumn.Width = 33;
            // 
            // HourCount
            // 
            this.HourCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HourCount.DataPropertyName = "HourCount";
            this.HourCount.HeaderText = "عدد الساعات";
            this.HourCount.Name = "HourCount";
            this.HourCount.ReadOnly = true;
            // 
            // inVacationDataGridViewCheckBoxColumn
            // 
            this.inVacationDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inVacationDataGridViewCheckBoxColumn.DataPropertyName = "InVacation";
            this.inVacationDataGridViewCheckBoxColumn.HeaderText = "إجازه";
            this.inVacationDataGridViewCheckBoxColumn.Name = "inVacationDataGridViewCheckBoxColumn";
            this.inVacationDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inVacationDataGridViewCheckBoxColumn.Width = 42;
            // 
            // VacationNameAr
            // 
            this.VacationNameAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VacationNameAr.DataPropertyName = "VacationNameAr";
            this.VacationNameAr.HeaderText = "نوع الاجازه";
            this.VacationNameAr.Name = "VacationNameAr";
            this.VacationNameAr.ReadOnly = true;
            this.VacationNameAr.Width = 85;
            // 
            // PenalityByDay
            // 
            this.PenalityByDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PenalityByDay.DataPropertyName = "PenalityByDay";
            this.PenalityByDay.HeaderText = "خصم (بالايام)";
            this.PenalityByDay.Name = "PenalityByDay";
            this.PenalityByDay.ReadOnly = true;
            this.PenalityByDay.Width = 101;
            // 
            // PenalityByValue
            // 
            this.PenalityByValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PenalityByValue.DataPropertyName = "PenalityByValue";
            this.PenalityByValue.HeaderText = "خصم (مبلغ)";
            this.PenalityByValue.Name = "PenalityByValue";
            this.PenalityByValue.ReadOnly = true;
            this.PenalityByValue.Width = 94;
            // 
            // PenaltyNameAr
            // 
            this.PenaltyNameAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PenaltyNameAr.DataPropertyName = "PenaltyNameAr";
            this.PenaltyNameAr.HeaderText = "نوع الخصم";
            this.PenaltyNameAr.Name = "PenaltyNameAr";
            this.PenaltyNameAr.ReadOnly = true;
            this.PenaltyNameAr.Width = 86;
            // 
            // BouncByDay
            // 
            this.BouncByDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BouncByDay.DataPropertyName = "BouncByDay";
            this.BouncByDay.HeaderText = "مكافاه (بالايام)";
            this.BouncByDay.Name = "BouncByDay";
            this.BouncByDay.ReadOnly = true;
            this.BouncByDay.Width = 105;
            // 
            // BounceByValue
            // 
            this.BounceByValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BounceByValue.DataPropertyName = "BounceByValue";
            this.BounceByValue.HeaderText = "مكافاه (مبلغ)";
            this.BounceByValue.Name = "BounceByValue";
            this.BounceByValue.ReadOnly = true;
            this.BounceByValue.Width = 98;
            // 
            // BonusNameAr
            // 
            this.BonusNameAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BonusNameAr.DataPropertyName = "BonusNameAr";
            this.BonusNameAr.HeaderText = "نوع المكافاه";
            this.BonusNameAr.Name = "BonusNameAr";
            this.BonusNameAr.ReadOnly = true;
            this.BonusNameAr.Width = 91;
            // 
            // frmLoadEmpFPTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 469);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CmdShowTotals);
            this.Controls.Add(this.CmdXLS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.dtEndRange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStartRange);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoadEmpFPTrans";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض حركة الحضور و الانصراف لموظف";
            this.Load += new System.EventHandler(this.frmLoadEmpFPTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraEmpAttendanceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraEmpAttendanceTotalsViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.DateTimePicker dtStartRange;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource comboNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter combo_NameListTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndRange;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource hRTraEmpAttendanceViewBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_EmpAttendanceViewTableAdapter hR_Tra_EmpAttendanceViewTableAdapter;
        private System.Windows.Forms.Button CmdXLS;
        private System.Windows.Forms.Button CmdShowTotals;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hRTraEmpAttendanceTotalsViewBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_EmpAttendanceTotalsViewTableAdapter hR_Tra_EmpAttendanceTotalsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFPNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMorningLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumLeaveLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumPermissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumVacationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAttendanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatePenality;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOutDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inMissionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leavePermissionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inVacationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationNameAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenalityByDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenalityByValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyNameAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn BouncByDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BounceByValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonusNameAr;
    }
}