namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmGroupPloicies
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.ComboBox();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.CmdSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelayRuleID = new System.Windows.Forms.ComboBox();
            this.hRRulDelayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulDataSet = new TMS.AppDataSetsHR.RulDataSet();
            this.txtExtratimeRuleID = new System.Windows.Forms.ComboBox();
            this.hRRulExtraTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLeavPermissionRuleID = new System.Windows.Forms.ComboBox();
            this.hRRulLeavePermissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            this.hR_Rul_DelayTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter();
            this.hR_Rul_ExtraTimeTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_ExtraTimeTableAdapter();
            this.hR_Rul_LeavePermissionTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_LeavePermissionTableAdapter();
            this.gridGroupPloicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridGroupPloicyTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.GridGroupPloicyTableAdapter();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayRuleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraTimeRuleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavPermissionRuleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGroupTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayRuleNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraTimeRuleNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulExtraTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulLeavePermissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupPloicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 0;
            // 
            // txtGroupID
            // 
            this.txtGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtGroupID.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.txtGroupID.DisplayMember = "EmpGroupTitleAr";
            this.txtGroupID.FormattingEnabled = true;
            this.txtGroupID.Location = new System.Drawing.Point(486, 41);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(210, 25);
            this.txtGroupID.TabIndex = 1;
            this.txtGroupID.ValueMember = "EmpGroupID";
            this.txtGroupID.SelectedIndexChanged += new System.EventHandler(this.txtGroupID_SelectedIndexChanged);
            // 
            // hRLupEmplymentGroupBindingSource
            // 
            this.hRLupEmplymentGroupBindingSource.DataMember = "HR_Lup_EmplymentGroup";
            this.hRLupEmplymentGroupBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdSave
            // 
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(312, 126);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(101, 39);
            this.CmdSave.TabIndex = 2;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.delayRuleIDDataGridViewTextBoxColumn,
            this.extraTimeRuleIDDataGridViewTextBoxColumn,
            this.leavPermissionRuleIDDataGridViewTextBoxColumn,
            this.empGroupTitleArDataGridViewTextBoxColumn,
            this.delayRuleNameArDataGridViewTextBoxColumn,
            this.extraTimeRuleNameArDataGridViewTextBoxColumn,
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gridGroupPloicyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "لائحة الأضافي:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "لائحة التأخير:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "أسم المجموعه:";
            // 
            // txtDelayRuleID
            // 
            this.txtDelayRuleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDelayRuleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDelayRuleID.DataSource = this.hRRulDelayBindingSource;
            this.txtDelayRuleID.DisplayMember = "DelayRuleNameAr";
            this.txtDelayRuleID.FormattingEnabled = true;
            this.txtDelayRuleID.Location = new System.Drawing.Point(532, 72);
            this.txtDelayRuleID.Name = "txtDelayRuleID";
            this.txtDelayRuleID.Size = new System.Drawing.Size(164, 25);
            this.txtDelayRuleID.TabIndex = 7;
            this.txtDelayRuleID.ValueMember = "DelayRuleID";
            // 
            // hRRulDelayBindingSource
            // 
            this.hRRulDelayBindingSource.DataMember = "HR_Rul_Delay";
            this.hRRulDelayBindingSource.DataSource = this.rulDataSet;
            // 
            // rulDataSet
            // 
            this.rulDataSet.DataSetName = "RulDataSet";
            this.rulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtExtratimeRuleID
            // 
            this.txtExtratimeRuleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtExtratimeRuleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtExtratimeRuleID.DataSource = this.hRRulExtraTimeBindingSource;
            this.txtExtratimeRuleID.DisplayMember = "ExtraTimeRuleNameAr";
            this.txtExtratimeRuleID.FormattingEnabled = true;
            this.txtExtratimeRuleID.Location = new System.Drawing.Point(532, 103);
            this.txtExtratimeRuleID.Name = "txtExtratimeRuleID";
            this.txtExtratimeRuleID.Size = new System.Drawing.Size(164, 25);
            this.txtExtratimeRuleID.TabIndex = 8;
            this.txtExtratimeRuleID.ValueMember = "ExtraTimeRuleID";
            // 
            // hRRulExtraTimeBindingSource
            // 
            this.hRRulExtraTimeBindingSource.DataMember = "HR_Rul_ExtraTime";
            this.hRRulExtraTimeBindingSource.DataSource = this.rulDataSet;
            // 
            // txtLeavPermissionRuleID
            // 
            this.txtLeavPermissionRuleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLeavPermissionRuleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtLeavPermissionRuleID.DataSource = this.hRRulLeavePermissionBindingSource;
            this.txtLeavPermissionRuleID.DisplayMember = "LeavePermissionRuleNameAr";
            this.txtLeavPermissionRuleID.FormattingEnabled = true;
            this.txtLeavPermissionRuleID.Location = new System.Drawing.Point(532, 134);
            this.txtLeavPermissionRuleID.Name = "txtLeavPermissionRuleID";
            this.txtLeavPermissionRuleID.Size = new System.Drawing.Size(164, 25);
            this.txtLeavPermissionRuleID.TabIndex = 10;
            this.txtLeavPermissionRuleID.ValueMember = "LeavePermissionRuleID";
            // 
            // hRRulLeavePermissionBindingSource
            // 
            this.hRRulLeavePermissionBindingSource.DataMember = "HR_Rul_LeavePermission";
            this.hRRulLeavePermissionBindingSource.DataSource = this.rulDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "لائحة الأذون:";
            // 
            // hR_Lup_EmplymentGroupTableAdapter
            // 
            this.hR_Lup_EmplymentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Rul_DelayTableAdapter
            // 
            this.hR_Rul_DelayTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Rul_ExtraTimeTableAdapter
            // 
            this.hR_Rul_ExtraTimeTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Rul_LeavePermissionTableAdapter
            // 
            this.hR_Rul_LeavePermissionTableAdapter.ClearBeforeFill = true;
            // 
            // gridGroupPloicyBindingSource
            // 
            this.gridGroupPloicyBindingSource.DataMember = "GridGroupPloicy";
            this.gridGroupPloicyBindingSource.DataSource = this.rulDataSet;
            // 
            // gridGroupPloicyTableAdapter
            // 
            this.gridGroupPloicyTableAdapter.ClearBeforeFill = true;
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
            // delayRuleIDDataGridViewTextBoxColumn
            // 
            this.delayRuleIDDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.HeaderText = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.Name = "delayRuleIDDataGridViewTextBoxColumn";
            this.delayRuleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // extraTimeRuleIDDataGridViewTextBoxColumn
            // 
            this.extraTimeRuleIDDataGridViewTextBoxColumn.DataPropertyName = "ExtraTimeRuleID";
            this.extraTimeRuleIDDataGridViewTextBoxColumn.HeaderText = "ExtraTimeRuleID";
            this.extraTimeRuleIDDataGridViewTextBoxColumn.Name = "extraTimeRuleIDDataGridViewTextBoxColumn";
            this.extraTimeRuleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.extraTimeRuleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // leavPermissionRuleIDDataGridViewTextBoxColumn
            // 
            this.leavPermissionRuleIDDataGridViewTextBoxColumn.DataPropertyName = "LeavPermissionRuleID";
            this.leavPermissionRuleIDDataGridViewTextBoxColumn.HeaderText = "LeavPermissionRuleID";
            this.leavPermissionRuleIDDataGridViewTextBoxColumn.Name = "leavPermissionRuleIDDataGridViewTextBoxColumn";
            this.leavPermissionRuleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.leavPermissionRuleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empGroupTitleArDataGridViewTextBoxColumn
            // 
            this.empGroupTitleArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empGroupTitleArDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.HeaderText = "المجموعه";
            this.empGroupTitleArDataGridViewTextBoxColumn.Name = "empGroupTitleArDataGridViewTextBoxColumn";
            this.empGroupTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delayRuleNameArDataGridViewTextBoxColumn
            // 
            this.delayRuleNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delayRuleNameArDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleNameAr";
            this.delayRuleNameArDataGridViewTextBoxColumn.HeaderText = "لائحة التأخير";
            this.delayRuleNameArDataGridViewTextBoxColumn.Name = "delayRuleNameArDataGridViewTextBoxColumn";
            this.delayRuleNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleNameArDataGridViewTextBoxColumn.Width = 104;
            // 
            // extraTimeRuleNameArDataGridViewTextBoxColumn
            // 
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.DataPropertyName = "ExtraTimeRuleNameAr";
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.HeaderText = "لائحة الاضافي";
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.Name = "extraTimeRuleNameArDataGridViewTextBoxColumn";
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.extraTimeRuleNameArDataGridViewTextBoxColumn.Width = 115;
            // 
            // leavePermissionRuleNameArDataGridViewTextBoxColumn
            // 
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.DataPropertyName = "LeavePermissionRuleNameAr";
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.HeaderText = "لائحة الاذون";
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.Name = "leavePermissionRuleNameArDataGridViewTextBoxColumn";
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.leavePermissionRuleNameArDataGridViewTextBoxColumn.Width = 102;
            // 
            // frmGroupPloicies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 409);
            this.Controls.Add(this.txtLeavPermissionRuleID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExtratimeRuleID);
            this.Controls.Add(this.txtDelayRuleID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGroupPloicies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوائح المجموعات";
            this.Load += new System.EventHandler(this.frmGroupPloicies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulExtraTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulLeavePermissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupPloicyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox txtGroupID;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtDelayRuleID;
        private System.Windows.Forms.ComboBox txtExtratimeRuleID;
        private System.Windows.Forms.ComboBox txtLeavPermissionRuleID;
        private System.Windows.Forms.Label label5;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
        private AppDataSetsHR.RulDataSet rulDataSet;
        private System.Windows.Forms.BindingSource hRRulDelayBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter hR_Rul_DelayTableAdapter;
        private System.Windows.Forms.BindingSource hRRulExtraTimeBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_ExtraTimeTableAdapter hR_Rul_ExtraTimeTableAdapter;
        private System.Windows.Forms.BindingSource hRRulLeavePermissionBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_LeavePermissionTableAdapter hR_Rul_LeavePermissionTableAdapter;
        private System.Windows.Forms.BindingSource gridGroupPloicyBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.GridGroupPloicyTableAdapter gridGroupPloicyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraTimeRuleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavPermissionRuleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraTimeRuleNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavePermissionRuleNameArDataGridViewTextBoxColumn;
    }
}