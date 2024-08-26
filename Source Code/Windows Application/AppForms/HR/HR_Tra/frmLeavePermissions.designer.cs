namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmLeavePermissions
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtEmpName = new System.Windows.Forms.ComboBox();
            this.comboNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.txtFPID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTransType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTransDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTransStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtTransEndTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_NameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter();
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.traDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLeavePermissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_LeavePermissionTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.Grid_LeavePermissionTableAdapter();
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permissionTypeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeavePermissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم / كود الموظف:";
            // 
            // dtCount
            // 
            this.dtCount.Location = new System.Drawing.Point(53, 116);
            this.dtCount.Name = "dtCount";
            this.dtCount.Size = new System.Drawing.Size(81, 24);
            this.dtCount.TabIndex = 1;
            this.dtCount.Text = "0";
            this.dtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn,
            this.permissionTypeIndexDataGridViewTextBoxColumn,
            this.empNameARDataGridViewTextBoxColumn,
            this.traDateDataGridViewTextBoxColumn,
            this.permissionTypeDataGridViewTextBoxColumn,
            this.fromTimeDataGridViewTextBoxColumn,
            this.toTimeDataGridViewTextBoxColumn,
            this.hourCountDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gridLeavePermissionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // CmdSave
            // 
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(53, 191);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 33);
            this.CmdSave.TabIndex = 3;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpName.DataSource = this.comboNameListBindingSource;
            this.txtEmpName.DisplayMember = "EmpNameAR";
            this.txtEmpName.FormattingEnabled = true;
            this.txtEmpName.Location = new System.Drawing.Point(402, 24);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(288, 25);
            this.txtEmpName.TabIndex = 4;
            this.txtEmpName.ValueMember = "EmployeeID";
            this.txtEmpName.SelectedIndexChanged += new System.EventHandler(this.txtEmpName_SelectedIndexChanged);
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
            // txtFPID
            // 
            this.txtFPID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFPID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFPID.DataSource = this.comboExternalIDBindingSource;
            this.txtFPID.DisplayMember = "ExternalID";
            this.txtFPID.FormattingEnabled = true;
            this.txtFPID.Location = new System.Drawing.Point(280, 24);
            this.txtFPID.Name = "txtFPID";
            this.txtFPID.Size = new System.Drawing.Size(116, 25);
            this.txtFPID.TabIndex = 5;
            this.txtFPID.ValueMember = "EmployeeID";
            this.txtFPID.SelectedIndexChanged += new System.EventHandler(this.txtFPID_SelectedIndexChanged);
            // 
            // comboExternalIDBindingSource
            // 
            this.comboExternalIDBindingSource.DataMember = "Combo_ExternalID";
            this.comboExternalIDBindingSource.DataSource = this.empDataSet;
            // 
            // txtTransType
            // 
            this.txtTransType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTransType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTransType.FormattingEnabled = true;
            this.txtTransType.Items.AddRange(new object[] {
            "حضور متأخر",
            "أنصراف مبكر",
            "خلال اليوم"});
            this.txtTransType.Location = new System.Drawing.Point(517, 85);
            this.txtTransType.Name = "txtTransType";
            this.txtTransType.Size = new System.Drawing.Size(173, 25);
            this.txtTransType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "نوع الإذن:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "من الساعه:";
            // 
            // dtTransDate
            // 
            this.dtTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransDate.Location = new System.Drawing.Point(517, 55);
            this.dtTransDate.Name = "dtTransDate";
            this.dtTransDate.Size = new System.Drawing.Size(173, 24);
            this.dtTransDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "تاريخ الإذن:";
            // 
            // dtTransStartTime
            // 
            this.dtTransStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTransStartTime.Location = new System.Drawing.Point(517, 116);
            this.dtTransStartTime.Name = "dtTransStartTime";
            this.dtTransStartTime.Size = new System.Drawing.Size(173, 24);
            this.dtTransStartTime.TabIndex = 11;
            this.dtTransStartTime.Value = new System.DateTime(2015, 12, 13, 8, 30, 0, 0);
            // 
            // dtTransEndTime
            // 
            this.dtTransEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTransEndTime.Location = new System.Drawing.Point(258, 116);
            this.dtTransEndTime.Name = "dtTransEndTime";
            this.dtTransEndTime.Size = new System.Drawing.Size(138, 24);
            this.dtTransEndTime.TabIndex = 13;
            this.dtTransEndTime.Value = new System.DateTime(2015, 12, 13, 10, 30, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "الي الساعه:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "عدد الساعات:";
            // 
            // combo_NameListTableAdapter
            // 
            this.combo_NameListTableAdapter.ClearBeforeFill = true;
            // 
            // combo_ExternalIDTableAdapter
            // 
            this.combo_ExternalIDTableAdapter.ClearBeforeFill = true;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traDataSetBindingSource
            // 
            this.traDataSetBindingSource.DataSource = this.traDataSet;
            this.traDataSetBindingSource.Position = 0;
            // 
            // gridLeavePermissionBindingSource
            // 
            this.gridLeavePermissionBindingSource.DataMember = "Grid_LeavePermission";
            this.gridLeavePermissionBindingSource.DataSource = this.traDataSetBindingSource;
            // 
            // grid_LeavePermissionTableAdapter
            // 
            this.grid_LeavePermissionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeLeavePermissionIDDataGridViewTextBoxColumn
            // 
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLeavePermissionID";
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn.HeaderText = "EmployeeLeavePermissionID";
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn.Name = "employeeLeavePermissionIDDataGridViewTextBoxColumn";
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLeavePermissionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            this.isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // permissionTypeIndexDataGridViewTextBoxColumn
            // 
            this.permissionTypeIndexDataGridViewTextBoxColumn.DataPropertyName = "PermissionTypeIndex";
            this.permissionTypeIndexDataGridViewTextBoxColumn.HeaderText = "PermissionTypeIndex";
            this.permissionTypeIndexDataGridViewTextBoxColumn.Name = "permissionTypeIndexDataGridViewTextBoxColumn";
            this.permissionTypeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionTypeIndexDataGridViewTextBoxColumn.Visible = false;
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
            // traDateDataGridViewTextBoxColumn
            // 
            this.traDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.traDateDataGridViewTextBoxColumn.DataPropertyName = "Tra_Date";
            this.traDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الأذن";
            this.traDateDataGridViewTextBoxColumn.Name = "traDateDataGridViewTextBoxColumn";
            this.traDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.traDateDataGridViewTextBoxColumn.Width = 92;
            // 
            // permissionTypeDataGridViewTextBoxColumn
            // 
            this.permissionTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permissionTypeDataGridViewTextBoxColumn.DataPropertyName = "PermissionType";
            this.permissionTypeDataGridViewTextBoxColumn.HeaderText = "نوع الاذن";
            this.permissionTypeDataGridViewTextBoxColumn.Name = "permissionTypeDataGridViewTextBoxColumn";
            this.permissionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionTypeDataGridViewTextBoxColumn.Width = 83;
            // 
            // fromTimeDataGridViewTextBoxColumn
            // 
            this.fromTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fromTimeDataGridViewTextBoxColumn.DataPropertyName = "FromTime";
            this.fromTimeDataGridViewTextBoxColumn.HeaderText = "من الساعه";
            this.fromTimeDataGridViewTextBoxColumn.Name = "fromTimeDataGridViewTextBoxColumn";
            this.fromTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromTimeDataGridViewTextBoxColumn.Width = 97;
            // 
            // toTimeDataGridViewTextBoxColumn
            // 
            this.toTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.toTimeDataGridViewTextBoxColumn.DataPropertyName = "ToTime";
            this.toTimeDataGridViewTextBoxColumn.HeaderText = "الي الساعه";
            this.toTimeDataGridViewTextBoxColumn.Name = "toTimeDataGridViewTextBoxColumn";
            this.toTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourCountDataGridViewTextBoxColumn
            // 
            this.hourCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hourCountDataGridViewTextBoxColumn.DataPropertyName = "HourCount";
            this.hourCountDataGridViewTextBoxColumn.HeaderText = "عدد الساعات";
            this.hourCountDataGridViewTextBoxColumn.Name = "hourCountDataGridViewTextBoxColumn";
            this.hourCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.hourCountDataGridViewTextBoxColumn.Width = 109;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 84;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(258, 146);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(432, 78);
            this.txtNote.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "ملاحظات:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 17;
            // 
            // frmLeavePermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 435);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtTransEndTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtTransStartTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtTransDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTransType);
            this.Controls.Add(this.txtFPID);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLeavePermissions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإذون";
            this.Load += new System.EventHandler(this.frmLeavePermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeavePermissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dtCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.ComboBox txtEmpName;
        private System.Windows.Forms.ComboBox txtFPID;
        private System.Windows.Forms.ComboBox txtTransType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTransDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTransStartTime;
        private System.Windows.Forms.DateTimePicker dtTransEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource comboNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter combo_NameListTableAdapter;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.BindingSource traDataSetBindingSource;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource gridLeavePermissionBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.Grid_LeavePermissionTableAdapter grid_LeavePermissionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLeavePermissionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionTypeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMsg;
    }
}