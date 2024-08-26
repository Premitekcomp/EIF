namespace TMS.AppForms.Collectors
{
    partial class frmCreateTeam
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeamID = new System.Windows.Forms.ComboBox();
            this.colLupTeamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.CmdRefreshTeams = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.ComboBox();
            this.hREmpBasicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRoleID = new System.Windows.Forms.ComboBox();
            this.collupTeamRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.grvTeamList = new System.Windows.Forms.DataGridView();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colGridTeamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdSaveTeams = new System.Windows.Forms.Button();
            this.grvMembers = new System.Windows.Forms.DataGridView();
            this.colLupTeamMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtMemberSince = new System.Windows.Forms.DateTimePicker();
            this.col_Lup_TeamListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamListTableAdapter();
            this.col_lup_TeamRoleTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_lup_TeamRoleTableAdapter();
            this.hR_Emp_BasicInfoTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Emp_BasicInfoTableAdapter();
            this.col_Grid_TeamListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Grid_TeamListTableAdapter();
            this.col_Lup_TeamMembersTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter();
            this.CmdAddtoTeam = new System.Windows.Forms.Button();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teamIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberSinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hREmpBasicInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collupTeamRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTeamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGridTeamListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team Member:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Member Role:";
            // 
            // txtTeamID
            // 
            this.txtTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTeamID.DataSource = this.colLupTeamListBindingSource;
            this.txtTeamID.DisplayMember = "TeamName";
            this.txtTeamID.FormattingEnabled = true;
            this.txtTeamID.Location = new System.Drawing.Point(500, 16);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(155, 25);
            this.txtTeamID.TabIndex = 4;
            this.txtTeamID.ValueMember = "TeamID";
            this.txtTeamID.SelectedIndexChanged += new System.EventHandler(this.txtTeamID_SelectedIndexChanged);
            // 
            // colLupTeamListBindingSource
            // 
            this.colLupTeamListBindingSource.DataMember = "Col_Lup_TeamList";
            this.colLupTeamListBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdRefreshTeams
            // 
            this.CmdRefreshTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRefreshTeams.Location = new System.Drawing.Point(661, 13);
            this.CmdRefreshTeams.Name = "CmdRefreshTeams";
            this.CmdRefreshTeams.Size = new System.Drawing.Size(38, 28);
            this.CmdRefreshTeams.TabIndex = 5;
            this.CmdRefreshTeams.Text = ". . .";
            this.CmdRefreshTeams.UseVisualStyleBackColor = true;
            this.CmdRefreshTeams.Click += new System.EventHandler(this.CmdRefreshTeams_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMemberID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMemberID.DataSource = this.hREmpBasicInfoBindingSource;
            this.txtMemberID.DisplayMember = "EmpNameAR";
            this.txtMemberID.FormattingEnabled = true;
            this.txtMemberID.Location = new System.Drawing.Point(500, 47);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(155, 25);
            this.txtMemberID.TabIndex = 6;
            this.txtMemberID.ValueMember = "EmployeeID";
            // 
            // hREmpBasicInfoBindingSource
            // 
            this.hREmpBasicInfoBindingSource.DataMember = "HR_Emp_BasicInfo";
            this.hREmpBasicInfoBindingSource.DataSource = this.eIFCollector;
            // 
            // txtRoleID
            // 
            this.txtRoleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRoleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtRoleID.DataSource = this.collupTeamRoleBindingSource;
            this.txtRoleID.DisplayMember = "RoleTitle";
            this.txtRoleID.FormattingEnabled = true;
            this.txtRoleID.Location = new System.Drawing.Point(500, 78);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(155, 25);
            this.txtRoleID.TabIndex = 7;
            this.txtRoleID.ValueMember = "RoleID";
            // 
            // collupTeamRoleBindingSource
            // 
            this.collupTeamRoleBindingSource.DataMember = "Col_lup_TeamRole";
            this.collupTeamRoleBindingSource.DataSource = this.eIFCollector;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(116, 15);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(236, 23);
            this.txtTeamName.TabIndex = 8;
            // 
            // grvTeamList
            // 
            this.grvTeamList.AllowUserToAddRows = false;
            this.grvTeamList.AllowUserToDeleteRows = false;
            this.grvTeamList.AutoGenerateColumns = false;
            this.grvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIDDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.Column1});
            this.grvTeamList.DataSource = this.colGridTeamListBindingSource;
            this.grvTeamList.Location = new System.Drawing.Point(24, 80);
            this.grvTeamList.Name = "grvTeamList";
            this.grvTeamList.Size = new System.Drawing.Size(328, 297);
            this.grvTeamList.TabIndex = 9;
            this.grvTeamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTeamList_CellContentClick);
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Save";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 38;
            // 
            // colGridTeamListBindingSource
            // 
            this.colGridTeamListBindingSource.DataMember = "Col_Grid_TeamList";
            this.colGridTeamListBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdSaveTeams
            // 
            this.CmdSaveTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveTeams.Location = new System.Drawing.Point(284, 44);
            this.CmdSaveTeams.Name = "CmdSaveTeams";
            this.CmdSaveTeams.Size = new System.Drawing.Size(68, 28);
            this.CmdSaveTeams.TabIndex = 10;
            this.CmdSaveTeams.Text = "Save";
            this.CmdSaveTeams.UseVisualStyleBackColor = true;
            this.CmdSaveTeams.Click += new System.EventHandler(this.CmdSaveTeams_Click);
            // 
            // grvMembers
            // 
            this.grvMembers.AllowUserToAddRows = false;
            this.grvMembers.AllowUserToDeleteRows = false;
            this.grvMembers.AutoGenerateColumns = false;
            this.grvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.Column2,
            this.teamIDDataGridViewTextBoxColumn1,
            this.memberIDDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn1,
            this.empNameARDataGridViewTextBoxColumn,
            this.roleTitleDataGridViewTextBoxColumn,
            this.memberSinceDataGridViewTextBoxColumn,
            this.leftInDataGridViewTextBoxColumn});
            this.grvMembers.DataSource = this.colLupTeamMembersBindingSource;
            this.grvMembers.Location = new System.Drawing.Point(401, 109);
            this.grvMembers.Name = "grvMembers";
            this.grvMembers.ReadOnly = true;
            this.grvMembers.Size = new System.Drawing.Size(520, 268);
            this.grvMembers.TabIndex = 11;
            this.grvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvMembers_CellContentClick);
            // 
            // colLupTeamMembersBindingSource
            // 
            this.colLupTeamMembersBindingSource.DataMember = "Col_Lup_TeamMembers";
            this.colLupTeamMembersBindingSource.DataSource = this.eIFCollector;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Since:";
            // 
            // dtMemberSince
            // 
            this.dtMemberSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMemberSince.Location = new System.Drawing.Point(748, 45);
            this.dtMemberSince.Name = "dtMemberSince";
            this.dtMemberSince.Size = new System.Drawing.Size(120, 23);
            this.dtMemberSince.TabIndex = 13;
            // 
            // col_Lup_TeamListTableAdapter
            // 
            this.col_Lup_TeamListTableAdapter.ClearBeforeFill = true;
            // 
            // col_lup_TeamRoleTableAdapter
            // 
            this.col_lup_TeamRoleTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Emp_BasicInfoTableAdapter
            // 
            this.hR_Emp_BasicInfoTableAdapter.ClearBeforeFill = true;
            // 
            // col_Grid_TeamListTableAdapter
            // 
            this.col_Grid_TeamListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_TeamMembersTableAdapter
            // 
            this.col_Lup_TeamMembersTableAdapter.ClearBeforeFill = true;
            // 
            // CmdAddtoTeam
            // 
            this.CmdAddtoTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddtoTeam.Location = new System.Drawing.Point(800, 74);
            this.CmdAddtoTeam.Name = "CmdAddtoTeam";
            this.CmdAddtoTeam.Size = new System.Drawing.Size(68, 28);
            this.CmdAddtoTeam.TabIndex = 14;
            this.CmdAddtoTeam.Text = "Add";
            this.CmdAddtoTeam.UseVisualStyleBackColor = true;
            this.CmdAddtoTeam.Click += new System.EventHandler(this.CmdAddtoTeam_Click);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Del";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "X";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 35;
            // 
            // teamIDDataGridViewTextBoxColumn1
            // 
            this.teamIDDataGridViewTextBoxColumn1.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn1.HeaderText = "TeamID";
            this.teamIDDataGridViewTextBoxColumn1.Name = "teamIDDataGridViewTextBoxColumn1";
            this.teamIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamNameDataGridViewTextBoxColumn1
            // 
            this.teamNameDataGridViewTextBoxColumn1.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn1.HeaderText = "Team Name";
            this.teamNameDataGridViewTextBoxColumn1.Name = "teamNameDataGridViewTextBoxColumn1";
            this.teamNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.teamNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "Member Name";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleTitleDataGridViewTextBoxColumn
            // 
            this.roleTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roleTitleDataGridViewTextBoxColumn.DataPropertyName = "RoleTitle";
            this.roleTitleDataGridViewTextBoxColumn.HeaderText = "Role Title";
            this.roleTitleDataGridViewTextBoxColumn.Name = "roleTitleDataGridViewTextBoxColumn";
            this.roleTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleTitleDataGridViewTextBoxColumn.Width = 93;
            // 
            // memberSinceDataGridViewTextBoxColumn
            // 
            this.memberSinceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.memberSinceDataGridViewTextBoxColumn.DataPropertyName = "MemberSince";
            this.memberSinceDataGridViewTextBoxColumn.HeaderText = "Member Since";
            this.memberSinceDataGridViewTextBoxColumn.Name = "memberSinceDataGridViewTextBoxColumn";
            this.memberSinceDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberSinceDataGridViewTextBoxColumn.Width = 123;
            // 
            // leftInDataGridViewTextBoxColumn
            // 
            this.leftInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leftInDataGridViewTextBoxColumn.DataPropertyName = "LeftIn";
            this.leftInDataGridViewTextBoxColumn.HeaderText = "Left In";
            this.leftInDataGridViewTextBoxColumn.Name = "leftInDataGridViewTextBoxColumn";
            this.leftInDataGridViewTextBoxColumn.ReadOnly = true;
            this.leftInDataGridViewTextBoxColumn.Width = 72;
            // 
            // frmCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 389);
            this.Controls.Add(this.CmdAddtoTeam);
            this.Controls.Add(this.dtMemberSince);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvMembers);
            this.Controls.Add(this.CmdSaveTeams);
            this.Controls.Add(this.grvTeamList);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.CmdRefreshTeams);
            this.Controls.Add(this.txtTeamID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCreateTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.frmCreateTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hREmpBasicInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collupTeamRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTeamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGridTeamListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtTeamID;
        private System.Windows.Forms.Button CmdRefreshTeams;
        private System.Windows.Forms.ComboBox txtMemberID;
        private System.Windows.Forms.ComboBox txtRoleID;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.DataGridView grvTeamList;
        private System.Windows.Forms.Button CmdSaveTeams;
        private System.Windows.Forms.DataGridView grvMembers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtMemberSince;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource colLupTeamListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamListTableAdapter col_Lup_TeamListTableAdapter;
        private System.Windows.Forms.BindingSource collupTeamRoleBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_lup_TeamRoleTableAdapter col_lup_TeamRoleTableAdapter;
        private System.Windows.Forms.BindingSource hREmpBasicInfoBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.HR_Emp_BasicInfoTableAdapter hR_Emp_BasicInfoTableAdapter;
        private System.Windows.Forms.BindingSource colGridTeamListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Grid_TeamListTableAdapter col_Grid_TeamListTableAdapter;
        private System.Windows.Forms.BindingSource colLupTeamMembersBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter col_Lup_TeamMembersTableAdapter;
        private System.Windows.Forms.Button CmdAddtoTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberSinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInDataGridViewTextBoxColumn;
    }
}