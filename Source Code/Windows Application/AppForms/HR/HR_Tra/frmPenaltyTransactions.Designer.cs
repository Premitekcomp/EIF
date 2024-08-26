namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmPenaltyTransactions
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
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGroupID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hRTraPenalityTransactionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.hR_Tra_PenalityTransactionViewTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_PenalityTransactionViewTableAdapter();
            this.employeePenaltyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGroupTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byDayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.byAmountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.externalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpFileID = new System.Windows.Forms.ComboBox();
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraPenalityTransactionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(803, 48);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(129, 24);
            this.dtEndDate.TabIndex = 13;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(803, 18);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(129, 24);
            this.dtStartDate.TabIndex = 12;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeePenaltyIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.empGroupTitleArDataGridViewTextBoxColumn,
            this.byDayDataGridViewCheckBoxColumn,
            this.byAmountDataGridViewCheckBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.employeeFPNoDataGridViewTextBoxColumn,
            this.penaltyNameIDDataGridViewTextBoxColumn,
            this.externalIDDataGridViewTextBoxColumn,
            this.empNameARDataGridViewTextBoxColumn,
            this.traDateDataGridViewTextBoxColumn,
            this.penaltyNameArDataGridViewTextBoxColumn,
            this.netValueDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hRTraPenalityTransactionViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(759, 467);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtGroupID
            // 
            this.txtGroupID.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.txtGroupID.DisplayMember = "EmpGroupTitleAr";
            this.txtGroupID.FormattingEnabled = true;
            this.txtGroupID.Location = new System.Drawing.Point(771, 94);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(161, 25);
            this.txtGroupID.TabIndex = 9;
            this.txtGroupID.ValueMember = "EmpGroupID";
            this.txtGroupID.SelectedIndexChanged += new System.EventHandler(this.txtGroupID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "من:";
            // 
            // hRTraPenalityTransactionViewBindingSource
            // 
            this.hRTraPenalityTransactionViewBindingSource.DataMember = "HR_Tra_PenalityTransactionView";
            this.hRTraPenalityTransactionViewBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Tra_PenalityTransactionViewTableAdapter
            // 
            this.hR_Tra_PenalityTransactionViewTableAdapter.ClearBeforeFill = true;
            // 
            // employeePenaltyIDDataGridViewTextBoxColumn
            // 
            this.employeePenaltyIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeePenaltyID";
            this.employeePenaltyIDDataGridViewTextBoxColumn.HeaderText = "EmployeePenaltyID";
            this.employeePenaltyIDDataGridViewTextBoxColumn.Name = "employeePenaltyIDDataGridViewTextBoxColumn";
            this.employeePenaltyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeePenaltyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empGroupTitleArDataGridViewTextBoxColumn
            // 
            this.empGroupTitleArDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.HeaderText = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.Name = "empGroupTitleArDataGridViewTextBoxColumn";
            this.empGroupTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            this.empGroupTitleArDataGridViewTextBoxColumn.Visible = false;
            // 
            // byDayDataGridViewCheckBoxColumn
            // 
            this.byDayDataGridViewCheckBoxColumn.DataPropertyName = "ByDay";
            this.byDayDataGridViewCheckBoxColumn.HeaderText = "ByDay";
            this.byDayDataGridViewCheckBoxColumn.Name = "byDayDataGridViewCheckBoxColumn";
            this.byDayDataGridViewCheckBoxColumn.ReadOnly = true;
            this.byDayDataGridViewCheckBoxColumn.Visible = false;
            // 
            // byAmountDataGridViewCheckBoxColumn
            // 
            this.byAmountDataGridViewCheckBoxColumn.DataPropertyName = "ByAmount";
            this.byAmountDataGridViewCheckBoxColumn.HeaderText = "ByAmount";
            this.byAmountDataGridViewCheckBoxColumn.Name = "byAmountDataGridViewCheckBoxColumn";
            this.byAmountDataGridViewCheckBoxColumn.ReadOnly = true;
            this.byAmountDataGridViewCheckBoxColumn.Visible = false;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Visible = false;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.basicSalaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeFPNoDataGridViewTextBoxColumn
            // 
            this.employeeFPNoDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFPNo";
            this.employeeFPNoDataGridViewTextBoxColumn.HeaderText = "EmployeeFPNo";
            this.employeeFPNoDataGridViewTextBoxColumn.Name = "employeeFPNoDataGridViewTextBoxColumn";
            this.employeeFPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeFPNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // penaltyNameIDDataGridViewTextBoxColumn
            // 
            this.penaltyNameIDDataGridViewTextBoxColumn.DataPropertyName = "PenaltyNameID";
            this.penaltyNameIDDataGridViewTextBoxColumn.HeaderText = "PenaltyNameID";
            this.penaltyNameIDDataGridViewTextBoxColumn.Name = "penaltyNameIDDataGridViewTextBoxColumn";
            this.penaltyNameIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.penaltyNameIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // externalIDDataGridViewTextBoxColumn
            // 
            this.externalIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.externalIDDataGridViewTextBoxColumn.DataPropertyName = "ExternalID";
            this.externalIDDataGridViewTextBoxColumn.HeaderText = "رقم الملف";
            this.externalIDDataGridViewTextBoxColumn.Name = "externalIDDataGridViewTextBoxColumn";
            this.externalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.externalIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "أسم الموظف";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameARDataGridViewTextBoxColumn.Width = 108;
            // 
            // traDateDataGridViewTextBoxColumn
            // 
            this.traDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.traDateDataGridViewTextBoxColumn.DataPropertyName = "TraDate";
            this.traDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الخصم";
            this.traDateDataGridViewTextBoxColumn.Name = "traDateDataGridViewTextBoxColumn";
            this.traDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.traDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // penaltyNameArDataGridViewTextBoxColumn
            // 
            this.penaltyNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.penaltyNameArDataGridViewTextBoxColumn.DataPropertyName = "PenaltyNameAr";
            this.penaltyNameArDataGridViewTextBoxColumn.HeaderText = "سبب الخصم";
            this.penaltyNameArDataGridViewTextBoxColumn.Name = "penaltyNameArDataGridViewTextBoxColumn";
            this.penaltyNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.penaltyNameArDataGridViewTextBoxColumn.Width = 107;
            // 
            // netValueDataGridViewTextBoxColumn
            // 
            this.netValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.netValueDataGridViewTextBoxColumn.DataPropertyName = "NetValue";
            this.netValueDataGridViewTextBoxColumn.HeaderText = "قيمة الخصم";
            this.netValueDataGridViewTextBoxColumn.Name = "netValueDataGridViewTextBoxColumn";
            this.netValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.netValueDataGridViewTextBoxColumn.Width = 103;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1000, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "إلي:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "أسم المجموعه:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "أسم الموظف:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.DataSource = this.lupEmpNameListBindingSource;
            this.txtEmpName.DisplayMember = "EmpNameAR";
            this.txtEmpName.FormattingEnabled = true;
            this.txtEmpName.Location = new System.Drawing.Point(771, 125);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(161, 25);
            this.txtEmpName.TabIndex = 16;
            this.txtEmpName.ValueMember = "EmployeeID";
            this.txtEmpName.SelectedIndexChanged += new System.EventHandler(this.txtEmpName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(959, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "رقم الملف:";
            // 
            // txtEmpFileID
            // 
            this.txtEmpFileID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpFileID.DisplayMember = "ExternalID";
            this.txtEmpFileID.FormattingEnabled = true;
            this.txtEmpFileID.Location = new System.Drawing.Point(771, 156);
            this.txtEmpFileID.Name = "txtEmpFileID";
            this.txtEmpFileID.Size = new System.Drawing.Size(161, 25);
            this.txtEmpFileID.TabIndex = 18;
            this.txtEmpFileID.ValueMember = "EmployeeID";
            this.txtEmpFileID.SelectedIndexChanged += new System.EventHandler(this.txtEmpFileID_SelectedIndexChanged);
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lupEmpNameListBindingSource
            // 
            this.lupEmpNameListBindingSource.DataMember = "Lup_EmpNameList";
            this.lupEmpNameListBindingSource.DataSource = this.empDataSet;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
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
            // hRLupEmplymentGroupBindingSource
            // 
            this.hRLupEmplymentGroupBindingSource.DataMember = "HR_Lup_EmplymentGroup";
            this.hRLupEmplymentGroupBindingSource.DataSource = this.empDataSet;
            // 
            // hR_Lup_EmplymentGroupTableAdapter
            // 
            this.hR_Lup_EmplymentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // frmPenaltyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpFileID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPenaltyTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الخصومات";
            this.Load += new System.EventHandler(this.frmPenaltyTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRTraPenalityTransactionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtGroupID;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource hRTraPenalityTransactionViewBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Tra_PenalityTransactionViewTableAdapter hR_Tra_PenalityTransactionViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePenaltyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn byDayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn byAmountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtEmpFileID;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
    }
}