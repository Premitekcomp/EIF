namespace TMS.AppForms.Collectors
{
    partial class frmDomainsCompareVersion
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
            this.colLupTeamMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.gridDomainFullDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.gridDomainFullDataTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridDomainFullDataTableAdapter();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.col_Lup_TeamMembersTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter();
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
            this.grvFullDomain = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPastDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCompareDomainGBBucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recordVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPastDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBalanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCompareDomainSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridCompareDomainGBBucketTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridCompareDomainGBBucketTableAdapter();
            this.gridCompareDomainSummaryTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridCompareDomainSummaryTableAdapter();
            this.colDomainsDataBasicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_DomainsDataBasicTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter();
            this.colDomainsDataBasicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDue1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainFullDataBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainGBBucketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // colLupTeamMembersBindingSource
            // 
            this.colLupTeamMembersBindingSource.DataMember = "Col_Lup_TeamMembers";
            this.colLupTeamMembersBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridDomainFullDataBindingSource
            // 
            this.gridDomainFullDataBindingSource.DataMember = "GridDomainFullData";
            this.gridDomainFullDataBindingSource.DataSource = this.eIFCollector;
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
            // gridDomainFullDataTableAdapter
            // 
            this.gridDomainFullDataTableAdapter.ClearBeforeFill = true;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_TeamMembersTableAdapter
            // 
            this.col_Lup_TeamMembersTableAdapter.ClearBeforeFill = true;
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
            this.GroupBox1.Location = new System.Drawing.Point(4, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(196, 433);
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
            // grvFullDomain
            // 
            this.grvFullDomain.AllowUserToAddRows = false;
            this.grvFullDomain.AllowUserToDeleteRows = false;
            this.grvFullDomain.AllowUserToOrderColumns = true;
            this.grvFullDomain.AutoGenerateColumns = false;
            this.grvFullDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFullDomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.domainIDDataGridViewTextBoxColumn,
            this.recordVersionDataGridViewTextBoxColumn2,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.bucketDataGridViewTextBoxColumn1,
            this.pastDue1DataGridViewTextBoxColumn,
            this.balance1DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn});
            this.grvFullDomain.DataSource = this.colDomainsDataBasicBindingSource1;
            this.grvFullDomain.Location = new System.Drawing.Point(206, 3);
            this.grvFullDomain.Name = "grvFullDomain";
            this.grvFullDomain.ReadOnly = true;
            this.grvFullDomain.Size = new System.Drawing.Size(923, 355);
            this.grvFullDomain.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordVersionDataGridViewTextBoxColumn,
            this.accountCountDataGridViewTextBoxColumn,
            this.bucketDataGridViewTextBoxColumn,
            this.totalPastDueDataGridViewTextBoxColumn,
            this.totalBalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gridCompareDomainGBBucketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 172);
            this.dataGridView1.TabIndex = 76;
            // 
            // recordVersionDataGridViewTextBoxColumn
            // 
            this.recordVersionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recordVersionDataGridViewTextBoxColumn.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.recordVersionDataGridViewTextBoxColumn.Name = "recordVersionDataGridViewTextBoxColumn";
            this.recordVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn.Width = 77;
            // 
            // accountCountDataGridViewTextBoxColumn
            // 
            this.accountCountDataGridViewTextBoxColumn.DataPropertyName = "AccountCount";
            this.accountCountDataGridViewTextBoxColumn.HeaderText = "Account Count";
            this.accountCountDataGridViewTextBoxColumn.Name = "accountCountDataGridViewTextBoxColumn";
            this.accountCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bucketDataGridViewTextBoxColumn
            // 
            this.bucketDataGridViewTextBoxColumn.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn.Name = "bucketDataGridViewTextBoxColumn";
            this.bucketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPastDueDataGridViewTextBoxColumn
            // 
            this.totalPastDueDataGridViewTextBoxColumn.DataPropertyName = "TotalPastDue";
            this.totalPastDueDataGridViewTextBoxColumn.HeaderText = "Total Past Due";
            this.totalPastDueDataGridViewTextBoxColumn.Name = "totalPastDueDataGridViewTextBoxColumn";
            this.totalPastDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBalanceDataGridViewTextBoxColumn
            // 
            this.totalBalanceDataGridViewTextBoxColumn.DataPropertyName = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn.HeaderText = "Total Balance";
            this.totalBalanceDataGridViewTextBoxColumn.Name = "totalBalanceDataGridViewTextBoxColumn";
            this.totalBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridCompareDomainGBBucketBindingSource
            // 
            this.gridCompareDomainGBBucketBindingSource.DataMember = "GridCompareDomainGBBucket";
            this.gridCompareDomainGBBucketBindingSource.DataSource = this.eIFCollector;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordVersionDataGridViewTextBoxColumn1,
            this.accountCountDataGridViewTextBoxColumn1,
            this.totalPastDueDataGridViewTextBoxColumn1,
            this.totalBalanceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.gridCompareDomainSummaryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(738, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(391, 172);
            this.dataGridView2.TabIndex = 77;
            // 
            // recordVersionDataGridViewTextBoxColumn1
            // 
            this.recordVersionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recordVersionDataGridViewTextBoxColumn1.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn1.HeaderText = "Version";
            this.recordVersionDataGridViewTextBoxColumn1.Name = "recordVersionDataGridViewTextBoxColumn1";
            this.recordVersionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn1.Width = 77;
            // 
            // accountCountDataGridViewTextBoxColumn1
            // 
            this.accountCountDataGridViewTextBoxColumn1.DataPropertyName = "AccountCount";
            this.accountCountDataGridViewTextBoxColumn1.HeaderText = "Account Count";
            this.accountCountDataGridViewTextBoxColumn1.Name = "accountCountDataGridViewTextBoxColumn1";
            this.accountCountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalPastDueDataGridViewTextBoxColumn1
            // 
            this.totalPastDueDataGridViewTextBoxColumn1.DataPropertyName = "TotalPastDue";
            this.totalPastDueDataGridViewTextBoxColumn1.HeaderText = "Total PastDue";
            this.totalPastDueDataGridViewTextBoxColumn1.Name = "totalPastDueDataGridViewTextBoxColumn1";
            this.totalPastDueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalBalanceDataGridViewTextBoxColumn1
            // 
            this.totalBalanceDataGridViewTextBoxColumn1.DataPropertyName = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn1.HeaderText = "Total Balance";
            this.totalBalanceDataGridViewTextBoxColumn1.Name = "totalBalanceDataGridViewTextBoxColumn1";
            this.totalBalanceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gridCompareDomainSummaryBindingSource
            // 
            this.gridCompareDomainSummaryBindingSource.DataMember = "GridCompareDomainSummary";
            this.gridCompareDomainSummaryBindingSource.DataSource = this.eIFCollector;
            // 
            // gridCompareDomainGBBucketTableAdapter
            // 
            this.gridCompareDomainGBBucketTableAdapter.ClearBeforeFill = true;
            // 
            // gridCompareDomainSummaryTableAdapter
            // 
            this.gridCompareDomainSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // colDomainsDataBasicBindingSource
            // 
            this.colDomainsDataBasicBindingSource.DataMember = "Col_DomainsDataBasic";
            this.colDomainsDataBasicBindingSource.DataSource = this.eIFCollector;
            // 
            // col_DomainsDataBasicTableAdapter
            // 
            this.col_DomainsDataBasicTableAdapter.ClearBeforeFill = true;
            // 
            // colDomainsDataBasicBindingSource1
            // 
            this.colDomainsDataBasicBindingSource1.DataMember = "Col_DomainsDataBasic";
            this.colDomainsDataBasicBindingSource1.DataSource = this.eIFCollector;
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
            // recordVersionDataGridViewTextBoxColumn2
            // 
            this.recordVersionDataGridViewTextBoxColumn2.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn2.HeaderText = "Version";
            this.recordVersionDataGridViewTextBoxColumn2.Name = "recordVersionDataGridViewTextBoxColumn2";
            this.recordVersionDataGridViewTextBoxColumn2.ReadOnly = true;
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
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "Account ID";
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
            // bucketDataGridViewTextBoxColumn1
            // 
            this.bucketDataGridViewTextBoxColumn1.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn1.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn1.Name = "bucketDataGridViewTextBoxColumn1";
            this.bucketDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pastDue1DataGridViewTextBoxColumn
            // 
            this.pastDue1DataGridViewTextBoxColumn.DataPropertyName = "PastDue1";
            this.pastDue1DataGridViewTextBoxColumn.HeaderText = "PastDue";
            this.pastDue1DataGridViewTextBoxColumn.Name = "pastDue1DataGridViewTextBoxColumn";
            this.pastDue1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balance1DataGridViewTextBoxColumn
            // 
            this.balance1DataGridViewTextBoxColumn.DataPropertyName = "Balance1";
            this.balance1DataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balance1DataGridViewTextBoxColumn.Name = "balance1DataGridViewTextBoxColumn";
            this.balance1DataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmDomainsCompareVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 537);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.grvFullDomain);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDomainsCompareVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Versions";
            this.Load += new System.EventHandler(this.frmDomainsCompareVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colLupTeamMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainFullDataBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainGBBucketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource colLupTeamMembersBindingSource;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource gridDomainFullDataBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.GridDomainFullDataTableAdapter gridDomainFullDataTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_TeamMembersTableAdapter col_Lup_TeamMembersTableAdapter;
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
        private System.Windows.Forms.DataGridView grvFullDomain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gridCompareDomainGBBucketBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridCompareDomainGBBucketTableAdapter gridCompareDomainGBBucketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPastDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gridCompareDomainSummaryBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridCompareDomainSummaryTableAdapter gridCompareDomainSummaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPastDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBalanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource colDomainsDataBasicBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter col_DomainsDataBasicTableAdapter;
        private System.Windows.Forms.BindingSource colDomainsDataBasicBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastDue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
    }
}