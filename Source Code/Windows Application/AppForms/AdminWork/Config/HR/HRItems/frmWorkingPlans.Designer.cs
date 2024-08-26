namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmWorkingPlans
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
            this.txtWorkingTimesID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpList = new System.Windows.Forms.DataGridView();
            this.txtEmploymentGroupID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtAttStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.dgvWorkingTime = new System.Windows.Forms.DataGridView();
            this.workingTimeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingTimeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupWorkingTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.hR_Lup_WorkingTimesTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesTableAdapter();
            this.hRLupWorkingTimesComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_WorkingTimesComboTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesComboTableAdapter();
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            this.gridGroupMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_GroupMembersTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_GroupMembersTableAdapter();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGroupTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoopingTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupMembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWorkingTimesID
            // 
            this.txtWorkingTimesID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWorkingTimesID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtWorkingTimesID.DataSource = this.hRLupWorkingTimesComboBindingSource;
            this.txtWorkingTimesID.DisplayMember = "WorkingTimeTitle";
            this.txtWorkingTimesID.FormattingEnabled = true;
            this.txtWorkingTimesID.Location = new System.Drawing.Point(419, 19);
            this.txtWorkingTimesID.Name = "txtWorkingTimesID";
            this.txtWorkingTimesID.Size = new System.Drawing.Size(248, 25);
            this.txtWorkingTimesID.TabIndex = 0;
            this.txtWorkingTimesID.ValueMember = "WorkingTimeID";
            this.txtWorkingTimesID.SelectedIndexChanged += new System.EventHandler(this.txtWorkingTimesID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "أسم الورديه:";
            // 
            // dgvEmpList
            // 
            this.dgvEmpList.AllowUserToAddRows = false;
            this.dgvEmpList.AllowUserToDeleteRows = false;
            this.dgvEmpList.AutoGenerateColumns = false;
            this.dgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.empGroupTitleArDataGridViewTextBoxColumn,
            this.Column1,
            this.empNameARDataGridViewTextBoxColumn});
            this.dgvEmpList.DataSource = this.gridGroupMembersBindingSource;
            this.dgvEmpList.Location = new System.Drawing.Point(28, 50);
            this.dgvEmpList.Name = "dgvEmpList";
            this.dgvEmpList.ReadOnly = true;
            this.dgvEmpList.Size = new System.Drawing.Size(298, 303);
            this.dgvEmpList.TabIndex = 3;
            this.dgvEmpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpList_CellContentClick);
            // 
            // txtEmploymentGroupID
            // 
            this.txtEmploymentGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmploymentGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmploymentGroupID.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.txtEmploymentGroupID.DisplayMember = "EmpGroupTitleAr";
            this.txtEmploymentGroupID.FormattingEnabled = true;
            this.txtEmploymentGroupID.Location = new System.Drawing.Point(419, 50);
            this.txtEmploymentGroupID.Name = "txtEmploymentGroupID";
            this.txtEmploymentGroupID.Size = new System.Drawing.Size(248, 25);
            this.txtEmploymentGroupID.TabIndex = 4;
            this.txtEmploymentGroupID.ValueMember = "EmpGroupID";
            this.txtEmploymentGroupID.SelectedIndexChanged += new System.EventHandler(this.txtEmploymentGroupID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "أسم المجموعه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "من :";
            // 
            // dtAttStartDate
            // 
            this.dtAttStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAttStartDate.Location = new System.Drawing.Point(527, 94);
            this.dtAttStartDate.Name = "dtAttStartDate";
            this.dtAttStartDate.Size = new System.Drawing.Size(140, 24);
            this.dtAttStartDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "لمدة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "الموظفين:";
            // 
            // CmdSave
            // 
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(560, 182);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(107, 34);
            this.CmdSave.TabIndex = 11;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // dgvWorkingTime
            // 
            this.dgvWorkingTime.AllowUserToAddRows = false;
            this.dgvWorkingTime.AllowUserToDeleteRows = false;
            this.dgvWorkingTime.AutoGenerateColumns = false;
            this.dgvWorkingTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkingTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workingTimeIDDataGridViewTextBoxColumn,
            this.workingTimeTitleDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dgvWorkingTime.DataSource = this.hRLupWorkingTimesBindingSource;
            this.dgvWorkingTime.Location = new System.Drawing.Point(419, 271);
            this.dgvWorkingTime.Name = "dgvWorkingTime";
            this.dgvWorkingTime.ReadOnly = true;
            this.dgvWorkingTime.Size = new System.Drawing.Size(376, 82);
            this.dgvWorkingTime.TabIndex = 12;
            this.dgvWorkingTime.Visible = false;
            // 
            // workingTimeIDDataGridViewTextBoxColumn
            // 
            this.workingTimeIDDataGridViewTextBoxColumn.DataPropertyName = "WorkingTimeID";
            this.workingTimeIDDataGridViewTextBoxColumn.HeaderText = "WorkingTimeID";
            this.workingTimeIDDataGridViewTextBoxColumn.Name = "workingTimeIDDataGridViewTextBoxColumn";
            this.workingTimeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingTimeTitleDataGridViewTextBoxColumn
            // 
            this.workingTimeTitleDataGridViewTextBoxColumn.DataPropertyName = "WorkingTimeTitle";
            this.workingTimeTitleDataGridViewTextBoxColumn.HeaderText = "WorkingTimeTitle";
            this.workingTimeTitleDataGridViewTextBoxColumn.Name = "workingTimeTitleDataGridViewTextBoxColumn";
            this.workingTimeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupWorkingTimesBindingSource
            // 
            this.hRLupWorkingTimesBindingSource.DataMember = "HR_Lup_WorkingTimes";
            this.hRLupWorkingTimesBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Lup_WorkingTimesTableAdapter
            // 
            this.hR_Lup_WorkingTimesTableAdapter.ClearBeforeFill = true;
            // 
            // hRLupWorkingTimesComboBindingSource
            // 
            this.hRLupWorkingTimesComboBindingSource.DataMember = "HR_Lup_WorkingTimesCombo";
            this.hRLupWorkingTimesComboBindingSource.DataSource = this.traDataSet;
            // 
            // hR_Lup_WorkingTimesComboTableAdapter
            // 
            this.hR_Lup_WorkingTimesComboTableAdapter.ClearBeforeFill = true;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gridGroupMembersBindingSource
            // 
            this.gridGroupMembersBindingSource.DataMember = "Grid_GroupMembers";
            this.gridGroupMembersBindingSource.DataSource = this.empDataSet;
            // 
            // grid_GroupMembersTableAdapter
            // 
            this.grid_GroupMembersTableAdapter.ClearBeforeFill = true;
            // 
            // recordSerialDataGridViewTextBoxColumn
            // 
            this.recordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.Name = "recordSerialDataGridViewTextBoxColumn";
            this.recordSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empGroupTitleArDataGridViewTextBoxColumn
            // 
            this.empGroupTitleArDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.HeaderText = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.Name = "empGroupTitleArDataGridViewTextBoxColumn";
            this.empGroupTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            this.empGroupTitleArDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "اختيار";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtLoopingTime
            // 
            this.txtLoopingTime.Location = new System.Drawing.Point(605, 123);
            this.txtLoopingTime.Name = "txtLoopingTime";
            this.txtLoopingTime.Size = new System.Drawing.Size(62, 24);
            this.txtLoopingTime.TabIndex = 13;
            this.txtLoopingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "يوم";
            // 
            // frmWorkingPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoopingTime);
            this.Controls.Add(this.dgvWorkingTime);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtAttStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmploymentGroupID);
            this.Controls.Add(this.dgvEmpList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorkingTimesID);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmWorkingPlans";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خطط العمل";
            this.Load += new System.EventHandler(this.frmWorkingPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupMembersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtWorkingTimesID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpList;
        private System.Windows.Forms.ComboBox txtEmploymentGroupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtAttStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.DataGridView dgvWorkingTime;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource hRLupWorkingTimesBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesTableAdapter hR_Lup_WorkingTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingTimeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingTimeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hRLupWorkingTimesComboBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesComboTableAdapter hR_Lup_WorkingTimesComboTableAdapter;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
        private System.Windows.Forms.BindingSource gridGroupMembersBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_GroupMembersTableAdapter grid_GroupMembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtLoopingTime;
        private System.Windows.Forms.Label label6;
    }
}