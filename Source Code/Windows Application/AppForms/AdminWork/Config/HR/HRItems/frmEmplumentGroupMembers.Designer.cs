namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmEmplumentGroupMembers
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.ComboBox();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.txtEmplyeeID = new System.Windows.Forms.ComboBox();
            this.comboNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdSave = new System.Windows.Forms.Button();
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            this.combo_NameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGroupTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGroupMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid_GroupMembersTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_GroupMembersTableAdapter();
            this.lblMsg = new System.Windows.Forms.Label();
            this.CmdCancelUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم المجموعه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "أسم الموظف:";
            // 
            // txtGroupID
            // 
            this.txtGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtGroupID.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.txtGroupID.DisplayMember = "EmpGroupTitleAr";
            this.txtGroupID.FormattingEnabled = true;
            this.txtGroupID.Location = new System.Drawing.Point(314, 32);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(236, 25);
            this.txtGroupID.TabIndex = 2;
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
            // txtEmplyeeID
            // 
            this.txtEmplyeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmplyeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmplyeeID.DataSource = this.comboNameListBindingSource;
            this.txtEmplyeeID.DisplayMember = "EmpNameAR";
            this.txtEmplyeeID.FormattingEnabled = true;
            this.txtEmplyeeID.Location = new System.Drawing.Point(314, 63);
            this.txtEmplyeeID.Name = "txtEmplyeeID";
            this.txtEmplyeeID.Size = new System.Drawing.Size(236, 25);
            this.txtEmplyeeID.TabIndex = 3;
            this.txtEmplyeeID.ValueMember = "EmployeeID";
            // 
            // comboNameListBindingSource
            // 
            this.comboNameListBindingSource.DataMember = "Combo_NameList";
            this.comboNameListBindingSource.DataSource = this.empDataSet;
            // 
            // CmdSave
            // 
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(445, 94);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(105, 32);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // hR_Lup_EmplymentGroupTableAdapter
            // 
            this.hR_Lup_EmplymentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // combo_NameListTableAdapter
            // 
            this.combo_NameListTableAdapter.ClearBeforeFill = true;
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
            this.employeeIDDataGridViewTextBoxColumn,
            this.empNameARDataGridViewTextBoxColumn,
            this.empGroupTitleArDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gridGroupMembersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 233);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "أسم الموظف";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empGroupTitleArDataGridViewTextBoxColumn
            // 
            this.empGroupTitleArDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.HeaderText = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.Name = "empGroupTitleArDataGridViewTextBoxColumn";
            this.empGroupTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            this.empGroupTitleArDataGridViewTextBoxColumn.Visible = false;
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
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 6;
            // 
            // CmdCancelUpdate
            // 
            this.CmdCancelUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCancelUpdate.Location = new System.Drawing.Point(314, 94);
            this.CmdCancelUpdate.Name = "CmdCancelUpdate";
            this.CmdCancelUpdate.Size = new System.Drawing.Size(125, 32);
            this.CmdCancelUpdate.TabIndex = 7;
            this.CmdCancelUpdate.Text = "تراجع عن التعديل";
            this.CmdCancelUpdate.UseVisualStyleBackColor = true;
            this.CmdCancelUpdate.Click += new System.EventHandler(this.CmdCancelUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.comboExternalIDBindingSource;
            this.comboBox1.DisplayMember = "ExternalID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 25);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "EmployeeID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // frmEmplumentGroupMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 381);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CmdCancelUpdate);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtEmplyeeID);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEmplumentGroupMembers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعضاء المجموعات";
            this.Load += new System.EventHandler(this.frmEmplumentGroupMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtGroupID;
        private System.Windows.Forms.ComboBox txtEmplyeeID;
        private System.Windows.Forms.Button CmdSave;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
        private System.Windows.Forms.BindingSource comboNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_NameListTableAdapter combo_NameListTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gridGroupMembersBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_GroupMembersTableAdapter grid_GroupMembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button CmdCancelUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
    }
}