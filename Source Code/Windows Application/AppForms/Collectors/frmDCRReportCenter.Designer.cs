namespace TMS.AppForms.Collectors
{
    partial class frmDCRReportCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDCRReportCenter));
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TabCenter = new System.Windows.Forms.TabControl();
            this.tabNunWorked = new System.Windows.Forms.TabPage();
            this.grvNunWorked = new System.Windows.Forms.DataGridView();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportsNunWorkedAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollectorAnalysis = new TMS.AppDataSets.EIFCollectorAnalysis();
            this.lvNonWorked = new System.Windows.Forms.ListView();
            this.ColTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TSNunWorked = new System.Windows.Forms.ToolStrip();
            this.CmdNunWorkedGetData = new System.Windows.Forms.ToolStripButton();
            this.tabTrials = new System.Windows.Forms.TabPage();
            this.grvTrials = new System.Windows.Forms.DataGridView();
            this.domainIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connetctionResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trialsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trialsSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportsTrialsRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LVTrials = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TSTab = new System.Windows.Forms.ToolStrip();
            this.CmdtrialsBuild = new System.Windows.Forms.ToolStripButton();
            this.tabProductivity = new System.Windows.Forms.TabPage();
            this.grvProductivity2 = new System.Windows.Forms.DataGridView();
            this.recordVersionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keptSumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keptCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportsProductivityRep2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LVProductivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grvProductivity1 = new System.Windows.Forms.DataGridView();
            this.recordVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keptSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keptCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportsProductivityRep1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsProductivity = new System.Windows.Forms.ToolStrip();
            this.CmdProductivityBuild = new System.Windows.Forms.ToolStripButton();
            this.col_Reports_NunWorkedAccountsTableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_NunWorkedAccountsTableAdapter();
            this.col_Reports_ProductivityRep1TableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_ProductivityRep1TableAdapter();
            this.col_Reports_ProductivityRep2TableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_ProductivityRep2TableAdapter();
            this.col_Reports_TrialsRepTableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_TrialsRepTableAdapter();
            this.tabDCR = new System.Windows.Forms.TabPage();
            this.TSDCR = new System.Windows.Forms.ToolStrip();
            this.CmdDCRBuild = new System.Windows.Forms.ToolStripButton();
            this.LVDCR = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grvDCR = new System.Windows.Forms.DataGridView();
            this.colRepDCRReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_RepDCRReportTableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_RepDCRReportTableAdapter();
            this.domainIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitCountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            this.TabCenter.SuspendLayout();
            this.tabNunWorked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNunWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsNunWorkedAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollectorAnalysis)).BeginInit();
            this.TSNunWorked.SuspendLayout();
            this.tabTrials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsTrialsRepBindingSource)).BeginInit();
            this.TSTab.SuspendLayout();
            this.tabProductivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductivity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsProductivityRep2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductivity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsProductivityRep1BindingSource)).BeginInit();
            this.tsProductivity.SuspendLayout();
            this.tabDCR.SuspendLayout();
            this.TSDCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colRepDCRReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // txtMonth
            // 
            this.txtMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMonth.DataSource = this.colLupMonthListBindingSource;
            this.txtMonth.DisplayMember = "MonthTitle";
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Location = new System.Drawing.Point(58, 17);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 22);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(724, 17);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(78, 22);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // lblDomainVersion
            // 
            this.lblDomainVersion.AutoSize = true;
            this.lblDomainVersion.Location = new System.Drawing.Point(808, 21);
            this.lblDomainVersion.Name = "lblDomainVersion";
            this.lblDomainVersion.Size = new System.Drawing.Size(136, 14);
            this.lblDomainVersion.TabIndex = 54;
            this.lblDomainVersion.Text = "Current Domain Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains";
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(505, 10);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(105, 29);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Data";
            this.CmdGetDomainIDs.UseVisualStyleBackColor = true;
            this.CmdGetDomainIDs.Click += new System.EventHandler(this.CmdGetDomainIDs_Click);
            // 
            // GroupBox1
            // 
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
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1109, 46);
            this.GroupBox1.TabIndex = 82;
            this.GroupBox1.TabStop = false;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(376, 17);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(123, 22);
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
            this.Label5.Location = new System.Drawing.Point(322, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 14);
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
            this.txtBankBranch.Location = new System.Drawing.Point(207, 17);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(109, 22);
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
            this.Label2.Location = new System.Drawing.Point(164, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 14);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month:";
            // 
            // TabCenter
            // 
            this.TabCenter.Controls.Add(this.tabNunWorked);
            this.TabCenter.Controls.Add(this.tabTrials);
            this.TabCenter.Controls.Add(this.tabProductivity);
            this.TabCenter.Controls.Add(this.tabDCR);
            this.TabCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCenter.Location = new System.Drawing.Point(0, 46);
            this.TabCenter.Name = "TabCenter";
            this.TabCenter.SelectedIndex = 0;
            this.TabCenter.Size = new System.Drawing.Size(1109, 514);
            this.TabCenter.TabIndex = 83;
            // 
            // tabNunWorked
            // 
            this.tabNunWorked.Controls.Add(this.grvNunWorked);
            this.tabNunWorked.Controls.Add(this.lvNonWorked);
            this.tabNunWorked.Controls.Add(this.TSNunWorked);
            this.tabNunWorked.Location = new System.Drawing.Point(4, 23);
            this.tabNunWorked.Name = "tabNunWorked";
            this.tabNunWorked.Padding = new System.Windows.Forms.Padding(3);
            this.tabNunWorked.Size = new System.Drawing.Size(1101, 487);
            this.tabNunWorked.TabIndex = 0;
            this.tabNunWorked.Text = "Non Worked";
            this.tabNunWorked.UseVisualStyleBackColor = true;
            // 
            // grvNunWorked
            // 
            this.grvNunWorked.AllowUserToAddRows = false;
            this.grvNunWorked.AllowUserToDeleteRows = false;
            this.grvNunWorked.AutoGenerateColumns = false;
            this.grvNunWorked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNunWorked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainIDDataGridViewTextBoxColumn,
            this.recordVersionDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.callCountDataGridViewTextBoxColumn,
            this.visitCountDataGridViewTextBoxColumn,
            this.Total});
            this.grvNunWorked.DataSource = this.colReportsNunWorkedAccountsBindingSource;
            this.grvNunWorked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvNunWorked.Location = new System.Drawing.Point(3, 28);
            this.grvNunWorked.Name = "grvNunWorked";
            this.grvNunWorked.ReadOnly = true;
            this.grvNunWorked.Size = new System.Drawing.Size(915, 456);
            this.grvNunWorked.TabIndex = 0;
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
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account No";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNoDataGridViewTextBoxColumn.Width = 89;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "Account ID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // callCountDataGridViewTextBoxColumn
            // 
            this.callCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.callCountDataGridViewTextBoxColumn.DataPropertyName = "CallCount";
            this.callCountDataGridViewTextBoxColumn.HeaderText = "Call Count";
            this.callCountDataGridViewTextBoxColumn.Name = "callCountDataGridViewTextBoxColumn";
            this.callCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.callCountDataGridViewTextBoxColumn.Width = 79;
            // 
            // visitCountDataGridViewTextBoxColumn
            // 
            this.visitCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.visitCountDataGridViewTextBoxColumn.DataPropertyName = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn.HeaderText = "Visit Count";
            this.visitCountDataGridViewTextBoxColumn.Name = "visitCountDataGridViewTextBoxColumn";
            this.visitCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitCountDataGridViewTextBoxColumn.Width = 84;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // colReportsNunWorkedAccountsBindingSource
            // 
            this.colReportsNunWorkedAccountsBindingSource.DataMember = "Col_Reports_NunWorkedAccounts";
            this.colReportsNunWorkedAccountsBindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // eIFCollectorAnalysis
            // 
            this.eIFCollectorAnalysis.DataSetName = "EIFCollectorAnalysis";
            this.eIFCollectorAnalysis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lvNonWorked
            // 
            this.lvNonWorked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTitle,
            this.ColValue});
            this.lvNonWorked.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvNonWorked.GridLines = true;
            this.lvNonWorked.Location = new System.Drawing.Point(918, 28);
            this.lvNonWorked.Name = "lvNonWorked";
            this.lvNonWorked.Size = new System.Drawing.Size(180, 456);
            this.lvNonWorked.TabIndex = 1;
            this.lvNonWorked.UseCompatibleStateImageBehavior = false;
            this.lvNonWorked.View = System.Windows.Forms.View.Details;
            // 
            // ColTitle
            // 
            this.ColTitle.Text = "Title";
            this.ColTitle.Width = 100;
            // 
            // ColValue
            // 
            this.ColValue.Text = "Value";
            this.ColValue.Width = 80;
            // 
            // TSNunWorked
            // 
            this.TSNunWorked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdNunWorkedGetData});
            this.TSNunWorked.Location = new System.Drawing.Point(3, 3);
            this.TSNunWorked.Name = "TSNunWorked";
            this.TSNunWorked.Size = new System.Drawing.Size(1095, 25);
            this.TSNunWorked.TabIndex = 2;
            this.TSNunWorked.Text = "toolStrip1";
            // 
            // CmdNunWorkedGetData
            // 
            this.CmdNunWorkedGetData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdNunWorkedGetData.Image = ((System.Drawing.Image)(resources.GetObject("CmdNunWorkedGetData.Image")));
            this.CmdNunWorkedGetData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdNunWorkedGetData.Name = "CmdNunWorkedGetData";
            this.CmdNunWorkedGetData.Size = new System.Drawing.Size(124, 22);
            this.CmdNunWorkedGetData.Text = "Build Report | Refresh";
            this.CmdNunWorkedGetData.Click += new System.EventHandler(this.CmdNunWorkedGetData_Click);
            // 
            // tabTrials
            // 
            this.tabTrials.Controls.Add(this.grvTrials);
            this.tabTrials.Controls.Add(this.LVTrials);
            this.tabTrials.Controls.Add(this.TSTab);
            this.tabTrials.Location = new System.Drawing.Point(4, 23);
            this.tabTrials.Name = "tabTrials";
            this.tabTrials.Size = new System.Drawing.Size(1101, 487);
            this.tabTrials.TabIndex = 2;
            this.tabTrials.Text = "Trials";
            this.tabTrials.UseVisualStyleBackColor = true;
            // 
            // grvTrials
            // 
            this.grvTrials.AllowUserToAddRows = false;
            this.grvTrials.AllowUserToDeleteRows = false;
            this.grvTrials.AutoGenerateColumns = false;
            this.grvTrials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTrials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainIDDataGridViewTextBoxColumn3,
            this.recordVersionDataGridViewTextBoxColumn3,
            this.collectorDataGridViewTextBoxColumn,
            this.collectorNameDataGridViewTextBoxColumn1,
            this.connetctionResultDataGridViewTextBoxColumn,
            this.trialsCountDataGridViewTextBoxColumn,
            this.trialsSumDataGridViewTextBoxColumn});
            this.grvTrials.DataSource = this.colReportsTrialsRepBindingSource;
            this.grvTrials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTrials.Location = new System.Drawing.Point(0, 25);
            this.grvTrials.Name = "grvTrials";
            this.grvTrials.ReadOnly = true;
            this.grvTrials.Size = new System.Drawing.Size(921, 462);
            this.grvTrials.TabIndex = 5;
            // 
            // domainIDDataGridViewTextBoxColumn3
            // 
            this.domainIDDataGridViewTextBoxColumn3.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn3.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn3.Name = "domainIDDataGridViewTextBoxColumn3";
            this.domainIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // recordVersionDataGridViewTextBoxColumn3
            // 
            this.recordVersionDataGridViewTextBoxColumn3.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn3.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn3.Name = "recordVersionDataGridViewTextBoxColumn3";
            this.recordVersionDataGridViewTextBoxColumn3.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn3.Visible = false;
            // 
            // collectorDataGridViewTextBoxColumn
            // 
            this.collectorDataGridViewTextBoxColumn.DataPropertyName = "Collector";
            this.collectorDataGridViewTextBoxColumn.HeaderText = "Collector";
            this.collectorDataGridViewTextBoxColumn.Name = "collectorDataGridViewTextBoxColumn";
            this.collectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectorDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectorNameDataGridViewTextBoxColumn1
            // 
            this.collectorNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collectorNameDataGridViewTextBoxColumn1.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn1.HeaderText = "Collector Name";
            this.collectorNameDataGridViewTextBoxColumn1.Name = "collectorNameDataGridViewTextBoxColumn1";
            this.collectorNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // connetctionResultDataGridViewTextBoxColumn
            // 
            this.connetctionResultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.connetctionResultDataGridViewTextBoxColumn.DataPropertyName = "ConnetctionResult";
            this.connetctionResultDataGridViewTextBoxColumn.HeaderText = "Trial";
            this.connetctionResultDataGridViewTextBoxColumn.Name = "connetctionResultDataGridViewTextBoxColumn";
            this.connetctionResultDataGridViewTextBoxColumn.ReadOnly = true;
            this.connetctionResultDataGridViewTextBoxColumn.Width = 54;
            // 
            // trialsCountDataGridViewTextBoxColumn
            // 
            this.trialsCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trialsCountDataGridViewTextBoxColumn.DataPropertyName = "TrialsCount";
            this.trialsCountDataGridViewTextBoxColumn.HeaderText = "Account Count";
            this.trialsCountDataGridViewTextBoxColumn.Name = "trialsCountDataGridViewTextBoxColumn";
            this.trialsCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.trialsCountDataGridViewTextBoxColumn.Width = 105;
            // 
            // trialsSumDataGridViewTextBoxColumn
            // 
            this.trialsSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trialsSumDataGridViewTextBoxColumn.DataPropertyName = "TrialsSum";
            this.trialsSumDataGridViewTextBoxColumn.HeaderText = "Balance Sum";
            this.trialsSumDataGridViewTextBoxColumn.Name = "trialsSumDataGridViewTextBoxColumn";
            this.trialsSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.trialsSumDataGridViewTextBoxColumn.Width = 93;
            // 
            // colReportsTrialsRepBindingSource
            // 
            this.colReportsTrialsRepBindingSource.DataMember = "Col_Reports_TrialsRep";
            this.colReportsTrialsRepBindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // LVTrials
            // 
            this.LVTrials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LVTrials.Dock = System.Windows.Forms.DockStyle.Right;
            this.LVTrials.GridLines = true;
            this.LVTrials.Location = new System.Drawing.Point(921, 25);
            this.LVTrials.Name = "LVTrials";
            this.LVTrials.Size = new System.Drawing.Size(180, 462);
            this.LVTrials.TabIndex = 4;
            this.LVTrials.UseCompatibleStateImageBehavior = false;
            this.LVTrials.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 80;
            // 
            // TSTab
            // 
            this.TSTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdtrialsBuild});
            this.TSTab.Location = new System.Drawing.Point(0, 0);
            this.TSTab.Name = "TSTab";
            this.TSTab.Size = new System.Drawing.Size(1101, 25);
            this.TSTab.TabIndex = 3;
            this.TSTab.Text = "toolStrip1";
            // 
            // CmdtrialsBuild
            // 
            this.CmdtrialsBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdtrialsBuild.Image = ((System.Drawing.Image)(resources.GetObject("CmdtrialsBuild.Image")));
            this.CmdtrialsBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdtrialsBuild.Name = "CmdtrialsBuild";
            this.CmdtrialsBuild.Size = new System.Drawing.Size(124, 22);
            this.CmdtrialsBuild.Text = "Build Report | Refresh";
            this.CmdtrialsBuild.Click += new System.EventHandler(this.CmdtrialsBuild_Click);
            // 
            // tabProductivity
            // 
            this.tabProductivity.Controls.Add(this.grvProductivity2);
            this.tabProductivity.Controls.Add(this.LVProductivity);
            this.tabProductivity.Controls.Add(this.grvProductivity1);
            this.tabProductivity.Controls.Add(this.tsProductivity);
            this.tabProductivity.Location = new System.Drawing.Point(4, 23);
            this.tabProductivity.Name = "tabProductivity";
            this.tabProductivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductivity.Size = new System.Drawing.Size(1101, 487);
            this.tabProductivity.TabIndex = 1;
            this.tabProductivity.Text = "Productivity";
            this.tabProductivity.UseVisualStyleBackColor = true;
            // 
            // grvProductivity2
            // 
            this.grvProductivity2.AllowUserToAddRows = false;
            this.grvProductivity2.AllowUserToDeleteRows = false;
            this.grvProductivity2.AutoGenerateColumns = false;
            this.grvProductivity2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductivity2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordVersionDataGridViewTextBoxColumn2,
            this.domainIDDataGridViewTextBoxColumn2,
            this.connectionDateDataGridViewTextBoxColumn1,
            this.collectorNameDataGridViewTextBoxColumn,
            this.connectionCountDataGridViewTextBoxColumn1,
            this.keptSumDataGridViewTextBoxColumn1,
            this.keptCountDataGridViewTextBoxColumn1});
            this.grvProductivity2.DataSource = this.colReportsProductivityRep2BindingSource;
            this.grvProductivity2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvProductivity2.Location = new System.Drawing.Point(409, 28);
            this.grvProductivity2.Name = "grvProductivity2";
            this.grvProductivity2.ReadOnly = true;
            this.grvProductivity2.Size = new System.Drawing.Size(509, 456);
            this.grvProductivity2.TabIndex = 5;
            // 
            // recordVersionDataGridViewTextBoxColumn2
            // 
            this.recordVersionDataGridViewTextBoxColumn2.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn2.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn2.Name = "recordVersionDataGridViewTextBoxColumn2";
            this.recordVersionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn2.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn2
            // 
            this.domainIDDataGridViewTextBoxColumn2.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn2.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn2.Name = "domainIDDataGridViewTextBoxColumn2";
            this.domainIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // connectionDateDataGridViewTextBoxColumn1
            // 
            this.connectionDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.connectionDateDataGridViewTextBoxColumn1.DataPropertyName = "ConnectionDate";
            this.connectionDateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.connectionDateDataGridViewTextBoxColumn1.Name = "connectionDateDataGridViewTextBoxColumn1";
            this.connectionDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // collectorNameDataGridViewTextBoxColumn
            // 
            this.collectorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.collectorNameDataGridViewTextBoxColumn.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn.HeaderText = "Collector Name";
            this.collectorNameDataGridViewTextBoxColumn.Name = "collectorNameDataGridViewTextBoxColumn";
            this.collectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectorNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // connectionCountDataGridViewTextBoxColumn1
            // 
            this.connectionCountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.connectionCountDataGridViewTextBoxColumn1.DataPropertyName = "ConnectionCount";
            this.connectionCountDataGridViewTextBoxColumn1.HeaderText = "Count";
            this.connectionCountDataGridViewTextBoxColumn1.Name = "connectionCountDataGridViewTextBoxColumn1";
            this.connectionCountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.connectionCountDataGridViewTextBoxColumn1.Width = 65;
            // 
            // keptSumDataGridViewTextBoxColumn1
            // 
            this.keptSumDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.keptSumDataGridViewTextBoxColumn1.DataPropertyName = "KeptSum";
            this.keptSumDataGridViewTextBoxColumn1.HeaderText = "Kept Sum";
            this.keptSumDataGridViewTextBoxColumn1.Name = "keptSumDataGridViewTextBoxColumn1";
            this.keptSumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.keptSumDataGridViewTextBoxColumn1.Width = 58;
            // 
            // keptCountDataGridViewTextBoxColumn1
            // 
            this.keptCountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.keptCountDataGridViewTextBoxColumn1.DataPropertyName = "KeptCount";
            this.keptCountDataGridViewTextBoxColumn1.HeaderText = "Kept Count";
            this.keptCountDataGridViewTextBoxColumn1.Name = "keptCountDataGridViewTextBoxColumn1";
            this.keptCountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.keptCountDataGridViewTextBoxColumn1.Width = 87;
            // 
            // colReportsProductivityRep2BindingSource
            // 
            this.colReportsProductivityRep2BindingSource.DataMember = "Col_Reports_ProductivityRep2";
            this.colReportsProductivityRep2BindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // LVProductivity
            // 
            this.LVProductivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LVProductivity.Dock = System.Windows.Forms.DockStyle.Right;
            this.LVProductivity.GridLines = true;
            this.LVProductivity.Location = new System.Drawing.Point(918, 28);
            this.LVProductivity.Name = "LVProductivity";
            this.LVProductivity.Size = new System.Drawing.Size(180, 456);
            this.LVProductivity.TabIndex = 6;
            this.LVProductivity.UseCompatibleStateImageBehavior = false;
            this.LVProductivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 80;
            // 
            // grvProductivity1
            // 
            this.grvProductivity1.AllowUserToAddRows = false;
            this.grvProductivity1.AllowUserToDeleteRows = false;
            this.grvProductivity1.AutoGenerateColumns = false;
            this.grvProductivity1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductivity1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordVersionDataGridViewTextBoxColumn1,
            this.domainIDDataGridViewTextBoxColumn1,
            this.connectionDateDataGridViewTextBoxColumn,
            this.connectionCountDataGridViewTextBoxColumn,
            this.keptSumDataGridViewTextBoxColumn,
            this.keptCountDataGridViewTextBoxColumn});
            this.grvProductivity1.DataSource = this.colReportsProductivityRep1BindingSource;
            this.grvProductivity1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grvProductivity1.Location = new System.Drawing.Point(3, 28);
            this.grvProductivity1.Name = "grvProductivity1";
            this.grvProductivity1.ReadOnly = true;
            this.grvProductivity1.Size = new System.Drawing.Size(406, 456);
            this.grvProductivity1.TabIndex = 4;
            // 
            // recordVersionDataGridViewTextBoxColumn1
            // 
            this.recordVersionDataGridViewTextBoxColumn1.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn1.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn1.Name = "recordVersionDataGridViewTextBoxColumn1";
            this.recordVersionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn1
            // 
            this.domainIDDataGridViewTextBoxColumn1.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.Name = "domainIDDataGridViewTextBoxColumn1";
            this.domainIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // connectionDateDataGridViewTextBoxColumn
            // 
            this.connectionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.connectionDateDataGridViewTextBoxColumn.DataPropertyName = "ConnectionDate";
            this.connectionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.connectionDateDataGridViewTextBoxColumn.Name = "connectionDateDataGridViewTextBoxColumn";
            this.connectionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionCountDataGridViewTextBoxColumn
            // 
            this.connectionCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.connectionCountDataGridViewTextBoxColumn.DataPropertyName = "ConnectionCount";
            this.connectionCountDataGridViewTextBoxColumn.HeaderText = "Count";
            this.connectionCountDataGridViewTextBoxColumn.Name = "connectionCountDataGridViewTextBoxColumn";
            this.connectionCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectionCountDataGridViewTextBoxColumn.Width = 65;
            // 
            // keptSumDataGridViewTextBoxColumn
            // 
            this.keptSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.keptSumDataGridViewTextBoxColumn.DataPropertyName = "KeptSum";
            this.keptSumDataGridViewTextBoxColumn.HeaderText = "Kept Sum";
            this.keptSumDataGridViewTextBoxColumn.Name = "keptSumDataGridViewTextBoxColumn";
            this.keptSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.keptSumDataGridViewTextBoxColumn.Width = 86;
            // 
            // keptCountDataGridViewTextBoxColumn
            // 
            this.keptCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.keptCountDataGridViewTextBoxColumn.DataPropertyName = "KeptCount";
            this.keptCountDataGridViewTextBoxColumn.HeaderText = "Kept Count";
            this.keptCountDataGridViewTextBoxColumn.Name = "keptCountDataGridViewTextBoxColumn";
            this.keptCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.keptCountDataGridViewTextBoxColumn.Width = 95;
            // 
            // colReportsProductivityRep1BindingSource
            // 
            this.colReportsProductivityRep1BindingSource.DataMember = "Col_Reports_ProductivityRep1";
            this.colReportsProductivityRep1BindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // tsProductivity
            // 
            this.tsProductivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdProductivityBuild});
            this.tsProductivity.Location = new System.Drawing.Point(3, 3);
            this.tsProductivity.Name = "tsProductivity";
            this.tsProductivity.Size = new System.Drawing.Size(1095, 25);
            this.tsProductivity.TabIndex = 3;
            this.tsProductivity.Text = "toolStrip1";
            // 
            // CmdProductivityBuild
            // 
            this.CmdProductivityBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdProductivityBuild.Image = ((System.Drawing.Image)(resources.GetObject("CmdProductivityBuild.Image")));
            this.CmdProductivityBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdProductivityBuild.Name = "CmdProductivityBuild";
            this.CmdProductivityBuild.Size = new System.Drawing.Size(124, 22);
            this.CmdProductivityBuild.Text = "Build Report | Refresh";
            this.CmdProductivityBuild.Click += new System.EventHandler(this.CmdProductivityBuild_Click);
            // 
            // col_Reports_NunWorkedAccountsTableAdapter
            // 
            this.col_Reports_NunWorkedAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // col_Reports_ProductivityRep1TableAdapter
            // 
            this.col_Reports_ProductivityRep1TableAdapter.ClearBeforeFill = true;
            // 
            // col_Reports_ProductivityRep2TableAdapter
            // 
            this.col_Reports_ProductivityRep2TableAdapter.ClearBeforeFill = true;
            // 
            // col_Reports_TrialsRepTableAdapter
            // 
            this.col_Reports_TrialsRepTableAdapter.ClearBeforeFill = true;
            // 
            // tabDCR
            // 
            this.tabDCR.Controls.Add(this.grvDCR);
            this.tabDCR.Controls.Add(this.LVDCR);
            this.tabDCR.Controls.Add(this.TSDCR);
            this.tabDCR.Location = new System.Drawing.Point(4, 23);
            this.tabDCR.Name = "tabDCR";
            this.tabDCR.Size = new System.Drawing.Size(1101, 487);
            this.tabDCR.TabIndex = 3;
            this.tabDCR.Text = "DCR Report";
            this.tabDCR.UseVisualStyleBackColor = true;
            // 
            // TSDCR
            // 
            this.TSDCR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdDCRBuild});
            this.TSDCR.Location = new System.Drawing.Point(0, 0);
            this.TSDCR.Name = "TSDCR";
            this.TSDCR.Size = new System.Drawing.Size(1101, 25);
            this.TSDCR.TabIndex = 3;
            this.TSDCR.Text = "toolStrip1";
            // 
            // CmdDCRBuild
            // 
            this.CmdDCRBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdDCRBuild.Image = ((System.Drawing.Image)(resources.GetObject("CmdDCRBuild.Image")));
            this.CmdDCRBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdDCRBuild.Name = "CmdDCRBuild";
            this.CmdDCRBuild.Size = new System.Drawing.Size(124, 22);
            this.CmdDCRBuild.Text = "Build Report | Refresh";
            this.CmdDCRBuild.Click += new System.EventHandler(this.CmdDCRBuild_Click);
            // 
            // LVDCR
            // 
            this.LVDCR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.LVDCR.Dock = System.Windows.Forms.DockStyle.Right;
            this.LVDCR.GridLines = true;
            this.LVDCR.Location = new System.Drawing.Point(921, 25);
            this.LVDCR.Name = "LVDCR";
            this.LVDCR.Size = new System.Drawing.Size(180, 462);
            this.LVDCR.TabIndex = 4;
            this.LVDCR.UseCompatibleStateImageBehavior = false;
            this.LVDCR.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 80;
            // 
            // grvDCR
            // 
            this.grvDCR.AllowUserToAddRows = false;
            this.grvDCR.AllowUserToDeleteRows = false;
            this.grvDCR.AutoGenerateColumns = false;
            this.grvDCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainIDDataGridViewTextBoxColumn4,
            this.recordVersionDataGridViewTextBoxColumn4,
            this.collectorDataGridViewTextBoxColumn1,
            this.collectorNameDataGridViewTextBoxColumn2,
            this.accountCountDataGridViewTextBoxColumn,
            this.balanceSumDataGridViewTextBoxColumn,
            this.callCountDataGridViewTextBoxColumn1,
            this.visitCountDataGridViewTextBoxColumn1,
            this.paymentSumDataGridViewTextBoxColumn});
            this.grvDCR.DataSource = this.colRepDCRReportBindingSource;
            this.grvDCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDCR.Location = new System.Drawing.Point(0, 25);
            this.grvDCR.Name = "grvDCR";
            this.grvDCR.ReadOnly = true;
            this.grvDCR.Size = new System.Drawing.Size(921, 462);
            this.grvDCR.TabIndex = 5;
            // 
            // colRepDCRReportBindingSource
            // 
            this.colRepDCRReportBindingSource.DataMember = "Col_RepDCRReport";
            this.colRepDCRReportBindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // col_RepDCRReportTableAdapter
            // 
            this.col_RepDCRReportTableAdapter.ClearBeforeFill = true;
            // 
            // domainIDDataGridViewTextBoxColumn4
            // 
            this.domainIDDataGridViewTextBoxColumn4.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn4.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn4.Name = "domainIDDataGridViewTextBoxColumn4";
            this.domainIDDataGridViewTextBoxColumn4.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn4.Visible = false;
            // 
            // recordVersionDataGridViewTextBoxColumn4
            // 
            this.recordVersionDataGridViewTextBoxColumn4.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn4.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn4.Name = "recordVersionDataGridViewTextBoxColumn4";
            this.recordVersionDataGridViewTextBoxColumn4.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn4.Visible = false;
            // 
            // collectorDataGridViewTextBoxColumn1
            // 
            this.collectorDataGridViewTextBoxColumn1.DataPropertyName = "Collector";
            this.collectorDataGridViewTextBoxColumn1.HeaderText = "Collector";
            this.collectorDataGridViewTextBoxColumn1.Name = "collectorDataGridViewTextBoxColumn1";
            this.collectorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.collectorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // collectorNameDataGridViewTextBoxColumn2
            // 
            this.collectorNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collectorNameDataGridViewTextBoxColumn2.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn2.HeaderText = "Collector Name";
            this.collectorNameDataGridViewTextBoxColumn2.Name = "collectorNameDataGridViewTextBoxColumn2";
            this.collectorNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // accountCountDataGridViewTextBoxColumn
            // 
            this.accountCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountCountDataGridViewTextBoxColumn.DataPropertyName = "AccountCount";
            this.accountCountDataGridViewTextBoxColumn.HeaderText = "Account Count";
            this.accountCountDataGridViewTextBoxColumn.Name = "accountCountDataGridViewTextBoxColumn";
            this.accountCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountCountDataGridViewTextBoxColumn.Width = 105;
            // 
            // balanceSumDataGridViewTextBoxColumn
            // 
            this.balanceSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balanceSumDataGridViewTextBoxColumn.DataPropertyName = "BalanceSum";
            this.balanceSumDataGridViewTextBoxColumn.HeaderText = "Balance Sum";
            this.balanceSumDataGridViewTextBoxColumn.Name = "balanceSumDataGridViewTextBoxColumn";
            this.balanceSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceSumDataGridViewTextBoxColumn.Width = 93;
            // 
            // callCountDataGridViewTextBoxColumn1
            // 
            this.callCountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.callCountDataGridViewTextBoxColumn1.DataPropertyName = "CallCount";
            this.callCountDataGridViewTextBoxColumn1.HeaderText = "Call Count";
            this.callCountDataGridViewTextBoxColumn1.Name = "callCountDataGridViewTextBoxColumn1";
            this.callCountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.callCountDataGridViewTextBoxColumn1.Width = 79;
            // 
            // visitCountDataGridViewTextBoxColumn1
            // 
            this.visitCountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.visitCountDataGridViewTextBoxColumn1.DataPropertyName = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn1.HeaderText = "Visit Count";
            this.visitCountDataGridViewTextBoxColumn1.Name = "visitCountDataGridViewTextBoxColumn1";
            this.visitCountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.visitCountDataGridViewTextBoxColumn1.Width = 84;
            // 
            // paymentSumDataGridViewTextBoxColumn
            // 
            this.paymentSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentSumDataGridViewTextBoxColumn.DataPropertyName = "PaymentSum";
            this.paymentSumDataGridViewTextBoxColumn.HeaderText = "Payment Sum";
            this.paymentSumDataGridViewTextBoxColumn.Name = "paymentSumDataGridViewTextBoxColumn";
            this.paymentSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentSumDataGridViewTextBoxColumn.Width = 99;
            // 
            // frmDCRReportCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 560);
            this.Controls.Add(this.TabCenter);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "frmDCRReportCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCR Reports Center";
            this.Load += new System.EventHandler(this.frmDCRReportCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            this.TabCenter.ResumeLayout(false);
            this.tabNunWorked.ResumeLayout(false);
            this.tabNunWorked.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNunWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsNunWorkedAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollectorAnalysis)).EndInit();
            this.TSNunWorked.ResumeLayout(false);
            this.TSNunWorked.PerformLayout();
            this.tabTrials.ResumeLayout(false);
            this.tabTrials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsTrialsRepBindingSource)).EndInit();
            this.TSTab.ResumeLayout(false);
            this.TSTab.PerformLayout();
            this.tabProductivity.ResumeLayout(false);
            this.tabProductivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductivity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsProductivityRep2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductivity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colReportsProductivityRep1BindingSource)).EndInit();
            this.tsProductivity.ResumeLayout(false);
            this.tsProductivity.PerformLayout();
            this.tabDCR.ResumeLayout(false);
            this.tabDCR.PerformLayout();
            this.TSDCR.ResumeLayout(false);
            this.TSDCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colRepDCRReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppDataSets.EIFCollector eIFCollector;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        internal System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox txtBranchID;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl TabCenter;
        private System.Windows.Forms.TabPage tabNunWorked;
        private System.Windows.Forms.TabPage tabProductivity;
        private System.Windows.Forms.DataGridView grvNunWorked;
        private System.Windows.Forms.ListView lvNonWorked;
        private System.Windows.Forms.ToolStrip TSNunWorked;
        private System.Windows.Forms.ToolStripButton CmdNunWorkedGetData;
        private AppDataSets.EIFCollectorAnalysis eIFCollectorAnalysis;
        private System.Windows.Forms.BindingSource colReportsNunWorkedAccountsBindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_NunWorkedAccountsTableAdapter col_Reports_NunWorkedAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ColumnHeader ColTitle;
        private System.Windows.Forms.ColumnHeader ColValue;
        private System.Windows.Forms.ToolStrip tsProductivity;
        private System.Windows.Forms.ToolStripButton CmdProductivityBuild;
        private System.Windows.Forms.DataGridView grvProductivity2;
        private System.Windows.Forms.ListView LVProductivity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView grvProductivity1;
        private System.Windows.Forms.BindingSource colReportsProductivityRep1BindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_ProductivityRep1TableAdapter col_Reports_ProductivityRep1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keptSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keptCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colReportsProductivityRep2BindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_ProductivityRep2TableAdapter col_Reports_ProductivityRep2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keptSumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keptCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabTrials;
        private System.Windows.Forms.DataGridView grvTrials;
        private System.Windows.Forms.ListView LVTrials;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip TSTab;
        private System.Windows.Forms.ToolStripButton CmdtrialsBuild;
        private System.Windows.Forms.BindingSource colReportsTrialsRepBindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Reports_TrialsRepTableAdapter col_Reports_TrialsRepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn connetctionResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trialsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trialsSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabDCR;
        private System.Windows.Forms.ToolStrip TSDCR;
        private System.Windows.Forms.ToolStripButton CmdDCRBuild;
        private System.Windows.Forms.ListView LVDCR;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DataGridView grvDCR;
        private System.Windows.Forms.BindingSource colRepDCRReportBindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_RepDCRReportTableAdapter col_RepDCRReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitCountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentSumDataGridViewTextBoxColumn;
    }
}