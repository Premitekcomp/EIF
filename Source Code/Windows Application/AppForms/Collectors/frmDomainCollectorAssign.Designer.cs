namespace TMS.AppForms.Collectors
{
    partial class frmDomainCollectorAssign
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.txtTeamLeaderID = new System.Windows.Forms.ComboBox();
            this.lupTeamLeadersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdLoadDomain = new System.Windows.Forms.Button();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grvDomainData = new System.Windows.Forms.DataGridView();
            this.colDomainsDataBasicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDTLID = new System.Windows.Forms.ComboBox();
            this.lupDTLListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCollectorID = new System.Windows.Forms.ComboBox();
            this.lupCollectorsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdCollectorAssign = new System.Windows.Forms.Button();
            this.LupTeamLeadersListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.LupTeamLeadersListTableAdapter();
            this.lupDTLListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.LupDTLListTableAdapter();
            this.lupCollectorsListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.LupCollectorsListTableAdapter();
            this.col_DomainsDataBasicTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter();
            this.CmdDTLAssign = new System.Windows.Forms.Button();
            this.CmdTLAssign = new System.Windows.Forms.Button();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTL_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastDue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupTeamLeadersListBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDomainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDTLListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCollectorsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(205, 452);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 94;
            label1.Text = "Team Leader:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(429, 452);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 17);
            label4.TabIndex = 96;
            label4.Text = "D . T . L:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(652, 452);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(66, 17);
            label7.TabIndex = 98;
            label7.Text = "Collector:";
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // txtTeamLeaderID
            // 
            this.txtTeamLeaderID.AutoCompleteCustomSource.AddRange(new string[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.txtTeamLeaderID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTeamLeaderID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTeamLeaderID.DataSource = this.lupTeamLeadersListBindingSource;
            this.txtTeamLeaderID.DisplayMember = "EmpNameAR";
            this.txtTeamLeaderID.FormattingEnabled = true;
            this.txtTeamLeaderID.Location = new System.Drawing.Point(205, 472);
            this.txtTeamLeaderID.Name = "txtTeamLeaderID";
            this.txtTeamLeaderID.Size = new System.Drawing.Size(205, 25);
            this.txtTeamLeaderID.TabIndex = 93;
            this.txtTeamLeaderID.ValueMember = "RecordID";
            // 
            // lupTeamLeadersListBindingSource
            // 
            this.lupTeamLeadersListBindingSource.DataMember = "LupTeamLeadersList";
            this.lupTeamLeadersListBindingSource.DataSource = this.eIFCollector;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CmdLoadDomain);
            this.GroupBox1.Controls.Add(this.lblDomainVersion);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txtAvaliableIDs);
            this.GroupBox1.Controls.Add(this.CmdGetDomainIDs);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtBranchID);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBankBranch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Location = new System.Drawing.Point(3, 1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(196, 532);
            this.GroupBox1.TabIndex = 74;
            this.GroupBox1.TabStop = false;
            // 
            // CmdLoadDomain
            // 
            this.CmdLoadDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLoadDomain.Location = new System.Drawing.Point(6, 318);
            this.CmdLoadDomain.Name = "CmdLoadDomain";
            this.CmdLoadDomain.Size = new System.Drawing.Size(178, 37);
            this.CmdLoadDomain.TabIndex = 55;
            this.CmdLoadDomain.Text = "Load Domain";
            this.CmdLoadDomain.UseVisualStyleBackColor = true;
            this.CmdLoadDomain.Click += new System.EventHandler(this.CmdLoadDomain_Click);
            // 
            // lblDomainVersion
            // 
            this.lblDomainVersion.AutoSize = true;
            this.lblDomainVersion.Location = new System.Drawing.Point(3, 287);
            this.lblDomainVersion.Name = "lblDomainVersion";
            this.lblDomainVersion.Size = new System.Drawing.Size(159, 17);
            this.lblDomainVersion.TabIndex = 54;
            this.lblDomainVersion.Text = "Current Domain Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains";
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(6, 250);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(178, 25);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(6, 178);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(178, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Data";
            this.CmdGetDomainIDs.UseVisualStyleBackColor = true;
            this.CmdGetDomainIDs.Click += new System.EventHandler(this.CmdGetDomainIDs_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMonth.DataSource = this.colLupMonthListBindingSource;
            this.txtMonth.DisplayMember = "MonthTitle";
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Location = new System.Drawing.Point(6, 39);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(178, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(6, 138);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(178, 25);
            this.txtBranchID.TabIndex = 20;
            this.txtBranchID.ValueMember = "BranchID";
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 118);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 17);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Branch:";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBankBranch.DataSource = this.hRLupBankListBindingSource;
            this.txtBankBranch.DisplayMember = "BankTitle";
            this.txtBankBranch.FormattingEnabled = true;
            this.txtBankBranch.Location = new System.Drawing.Point(6, 87);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(178, 25);
            this.txtBankBranch.TabIndex = 1;
            this.txtBankBranch.ValueMember = "BankID";
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month:";
            // 
            // grvDomainData
            // 
            this.grvDomainData.AllowUserToAddRows = false;
            this.grvDomainData.AllowUserToDeleteRows = false;
            this.grvDomainData.AllowUserToOrderColumns = true;
            this.grvDomainData.AutoGenerateColumns = false;
            this.grvDomainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDomainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.domainIDDataGridViewTextBoxColumn,
            this.recordVersionDataGridViewTextBoxColumn,
            this.TL_Name,
            this.DTL_Name,
            this.CollectorName,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.bucketDataGridViewTextBoxColumn,
            this.PastDue1,
            this.Balance1,
            this.cityDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn});
            this.grvDomainData.DataSource = this.colDomainsDataBasicBindingSource;
            this.grvDomainData.Location = new System.Drawing.Point(202, 40);
            this.grvDomainData.Name = "grvDomainData";
            this.grvDomainData.ReadOnly = true;
            this.grvDomainData.Size = new System.Drawing.Size(968, 392);
            this.grvDomainData.TabIndex = 75;
            // 
            // colDomainsDataBasicBindingSource
            // 
            this.colDomainsDataBasicBindingSource.DataMember = "Col_DomainsDataBasic";
            this.colDomainsDataBasicBindingSource.DataSource = this.eIFCollector;
            // 
            // txtDTLID
            // 
            this.txtDTLID.AutoCompleteCustomSource.AddRange(new string[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.txtDTLID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDTLID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDTLID.DataSource = this.lupDTLListBindingSource;
            this.txtDTLID.DisplayMember = "EmpNameAR";
            this.txtDTLID.FormattingEnabled = true;
            this.txtDTLID.Location = new System.Drawing.Point(432, 472);
            this.txtDTLID.Name = "txtDTLID";
            this.txtDTLID.Size = new System.Drawing.Size(205, 25);
            this.txtDTLID.TabIndex = 95;
            this.txtDTLID.ValueMember = "RecordID";
            // 
            // lupDTLListBindingSource
            // 
            this.lupDTLListBindingSource.DataMember = "LupDTLList";
            this.lupDTLListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtCollectorID
            // 
            this.txtCollectorID.AutoCompleteCustomSource.AddRange(new string[] {
            "Call",
            "Visit",
            "Mail",
            "Client Came Office"});
            this.txtCollectorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCollectorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCollectorID.DataSource = this.lupCollectorsListBindingSource;
            this.txtCollectorID.DisplayMember = "EmpNameAR";
            this.txtCollectorID.FormattingEnabled = true;
            this.txtCollectorID.Location = new System.Drawing.Point(655, 472);
            this.txtCollectorID.Name = "txtCollectorID";
            this.txtCollectorID.Size = new System.Drawing.Size(205, 25);
            this.txtCollectorID.TabIndex = 97;
            this.txtCollectorID.ValueMember = "RecordID";
            // 
            // lupCollectorsListBindingSource
            // 
            this.lupCollectorsListBindingSource.DataMember = "LupCollectorsList";
            this.lupCollectorsListBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdCollectorAssign
            // 
            this.CmdCollectorAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCollectorAssign.Location = new System.Drawing.Point(785, 503);
            this.CmdCollectorAssign.Name = "CmdCollectorAssign";
            this.CmdCollectorAssign.Size = new System.Drawing.Size(75, 30);
            this.CmdCollectorAssign.TabIndex = 99;
            this.CmdCollectorAssign.Text = "Assign";
            this.CmdCollectorAssign.UseVisualStyleBackColor = true;
            this.CmdCollectorAssign.Click += new System.EventHandler(this.CmdCollectorAssign_Click);
            // 
            // LupTeamLeadersListTableAdapter
            // 
            this.LupTeamLeadersListTableAdapter.ClearBeforeFill = true;
            // 
            // lupDTLListTableAdapter
            // 
            this.lupDTLListTableAdapter.ClearBeforeFill = true;
            // 
            // lupCollectorsListTableAdapter
            // 
            this.lupCollectorsListTableAdapter.ClearBeforeFill = true;
            // 
            // col_DomainsDataBasicTableAdapter
            // 
            this.col_DomainsDataBasicTableAdapter.ClearBeforeFill = true;
            // 
            // CmdDTLAssign
            // 
            this.CmdDTLAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDTLAssign.Location = new System.Drawing.Point(562, 503);
            this.CmdDTLAssign.Name = "CmdDTLAssign";
            this.CmdDTLAssign.Size = new System.Drawing.Size(75, 30);
            this.CmdDTLAssign.TabIndex = 100;
            this.CmdDTLAssign.Text = "Assign";
            this.CmdDTLAssign.UseVisualStyleBackColor = true;
            this.CmdDTLAssign.Click += new System.EventHandler(this.CmdDTLAssign_Click);
            // 
            // CmdTLAssign
            // 
            this.CmdTLAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdTLAssign.Location = new System.Drawing.Point(335, 503);
            this.CmdTLAssign.Name = "CmdTLAssign";
            this.CmdTLAssign.Size = new System.Drawing.Size(75, 30);
            this.CmdTLAssign.TabIndex = 101;
            this.CmdTLAssign.Text = "Assign";
            this.CmdTLAssign.UseVisualStyleBackColor = true;
            this.CmdTLAssign.Click += new System.EventHandler(this.CmdTLAssign_Click);
            // 
            // recordSerialDataGridViewTextBoxColumn
            // 
            this.recordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.Name = "recordSerialDataGridViewTextBoxColumn";
            this.recordSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn
            // 
            this.domainIDDataGridViewTextBoxColumn.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.Name = "domainIDDataGridViewTextBoxColumn";
            this.domainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // recordVersionDataGridViewTextBoxColumn
            // 
            this.recordVersionDataGridViewTextBoxColumn.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.Name = "recordVersionDataGridViewTextBoxColumn";
            this.recordVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn.Visible = false;
            // 
            // TL_Name
            // 
            this.TL_Name.DataPropertyName = "TL_Name";
            this.TL_Name.HeaderText = "Team Leader";
            this.TL_Name.Name = "TL_Name";
            this.TL_Name.ReadOnly = true;
            // 
            // DTL_Name
            // 
            this.DTL_Name.DataPropertyName = "DTL_Name";
            this.DTL_Name.HeaderText = "D T L";
            this.DTL_Name.Name = "DTL_Name";
            this.DTL_Name.ReadOnly = true;
            // 
            // CollectorName
            // 
            this.CollectorName.DataPropertyName = "CollectorName";
            this.CollectorName.HeaderText = "Collector";
            this.CollectorName.Name = "CollectorName";
            this.CollectorName.ReadOnly = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account No";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "Cutomer ID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            this.cycleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bucketDataGridViewTextBoxColumn
            // 
            this.bucketDataGridViewTextBoxColumn.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn.Name = "bucketDataGridViewTextBoxColumn";
            this.bucketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PastDue1
            // 
            this.PastDue1.DataPropertyName = "PastDue1";
            this.PastDue1.HeaderText = "Past Due";
            this.PastDue1.Name = "PastDue1";
            this.PastDue1.ReadOnly = true;
            // 
            // Balance1
            // 
            this.Balance1.DataPropertyName = "Balance1";
            this.Balance1.HeaderText = "Balance";
            this.Balance1.Name = "Balance1";
            this.Balance1.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDomainCollectorAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 538);
            this.Controls.Add(this.CmdTLAssign);
            this.Controls.Add(this.CmdDTLAssign);
            this.Controls.Add(this.CmdCollectorAssign);
            this.Controls.Add(this.txtCollectorID);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtDTLID);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtTeamLeaderID);
            this.Controls.Add(label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.grvDomainData);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDomainCollectorAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Collector to Accounts";
            this.Load += new System.EventHandler(this.frmDomainCollectorAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupTeamLeadersListBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDomainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDTLListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupCollectorsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDataSets.EIFCollector eIFCollector;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        internal System.Windows.Forms.ComboBox txtTeamLeaderID;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button CmdLoadDomain;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        internal System.Windows.Forms.ComboBox txtBranchID;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvDomainData;
        internal System.Windows.Forms.ComboBox txtDTLID;
        internal System.Windows.Forms.ComboBox txtCollectorID;
        private System.Windows.Forms.Button CmdCollectorAssign;
        private System.Windows.Forms.BindingSource lupCollectorAssignBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.LupTeamLeadersListTableAdapter LupTeamLeadersListTableAdapter;
        private System.Windows.Forms.BindingSource lupDTLListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.LupDTLListTableAdapter lupDTLListTableAdapter;
        private System.Windows.Forms.BindingSource lupCollectorsListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.LupCollectorsListTableAdapter lupCollectorsListTableAdapter;
        private System.Windows.Forms.BindingSource lupTeamLeadersListBindingSource;
        private System.Windows.Forms.BindingSource colDomainsDataBasicBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter col_DomainsDataBasicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn superVisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdDTLAssign;
        private System.Windows.Forms.Button CmdTLAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTL_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastDue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
    }
}