namespace TMS.AppForms.Collectors
{
    partial class frmDomainMatchRecords
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
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdCompareRecords = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.colDomainsDataBasicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_DomainsDataBasicTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter();
            this.lblMinor = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.grvMinor = new System.Windows.Forms.DataGridView();
            this.grvMajor = new System.Windows.Forms.DataGridView();
            this.gridDomainMinorVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridDomainMinorVersionTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridDomainMinorVersionTableAdapter();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDomainMajorVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridDomainMajorVersionTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridDomainMajorVersionTableAdapter();
            this.recordSerialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTLNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainMinorVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainMajorVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(619, 39);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(126, 25);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(327, 20);
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
            this.txtBankBranch.Location = new System.Drawing.Point(146, 39);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(178, 25);
            this.txtBankBranch.TabIndex = 1;
            this.txtBankBranch.ValueMember = "BankID";
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(330, 39);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(130, 25);
            this.txtBranchID.TabIndex = 20;
            this.txtBranchID.ValueMember = "BranchID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdCompareRecords
            // 
            this.CmdCompareRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCompareRecords.Location = new System.Drawing.Point(6, 70);
            this.CmdCompareRecords.Name = "CmdCompareRecords";
            this.CmdCompareRecords.Size = new System.Drawing.Size(867, 37);
            this.CmdCompareRecords.TabIndex = 55;
            this.CmdCompareRecords.Text = "Compare Records";
            this.CmdCompareRecords.UseVisualStyleBackColor = true;
            this.CmdCompareRecords.Click += new System.EventHandler(this.CmdCompareRecords_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains:";
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(466, 27);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(147, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Get Domain List";
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
            this.txtMonth.Size = new System.Drawing.Size(134, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(146, 19);
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
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CmdCompareRecords);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txtAvaliableIDs);
            this.GroupBox1.Controls.Add(this.CmdGetDomainIDs);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtBranchID);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBankBranch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Location = new System.Drawing.Point(5, -2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(879, 114);
            this.GroupBox1.TabIndex = 103;
            this.GroupBox1.TabStop = false;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
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
            // lblMinor
            // 
            this.lblMinor.AutoSize = true;
            this.lblMinor.Location = new System.Drawing.Point(2, 120);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(89, 17);
            this.lblMinor.TabIndex = 104;
            this.lblMinor.Text = "Minor Version";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(468, 120);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(90, 17);
            this.lblMajor.TabIndex = 105;
            this.lblMajor.Text = "Major Version";
            // 
            // grvMinor
            // 
            this.grvMinor.AllowUserToAddRows = false;
            this.grvMinor.AllowUserToDeleteRows = false;
            this.grvMinor.AutoGenerateColumns = false;
            this.grvMinor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMinor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.domainIDDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.bucketDataGridViewTextBoxColumn,
            this.pastDueDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn,
            this.recordVersionDataGridViewTextBoxColumn,
            this.tLNameDataGridViewTextBoxColumn,
            this.dTLNameDataGridViewTextBoxColumn,
            this.collectorNameDataGridViewTextBoxColumn});
            this.grvMinor.DataSource = this.gridDomainMinorVersionBindingSource;
            this.grvMinor.Location = new System.Drawing.Point(5, 140);
            this.grvMinor.Name = "grvMinor";
            this.grvMinor.ReadOnly = true;
            this.grvMinor.Size = new System.Drawing.Size(421, 367);
            this.grvMinor.TabIndex = 106;
            // 
            // grvMajor
            // 
            this.grvMajor.AllowUserToAddRows = false;
            this.grvMajor.AllowUserToDeleteRows = false;
            this.grvMajor.AutoGenerateColumns = false;
            this.grvMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn1,
            this.domainIDDataGridViewTextBoxColumn1,
            this.accountNoDataGridViewTextBoxColumn1,
            this.accountIDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.productDataGridViewTextBoxColumn1,
            this.cycleDataGridViewTextBoxColumn1,
            this.bucketDataGridViewTextBoxColumn1,
            this.pastDueDataGridViewTextBoxColumn1,
            this.balanceDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.officeDataGridViewTextBoxColumn1,
            this.recordVersionDataGridViewTextBoxColumn1,
            this.tLNameDataGridViewTextBoxColumn1,
            this.dTLNameDataGridViewTextBoxColumn1,
            this.collectorNameDataGridViewTextBoxColumn1});
            this.grvMajor.DataSource = this.gridDomainMajorVersionBindingSource;
            this.grvMajor.Location = new System.Drawing.Point(463, 140);
            this.grvMajor.Name = "grvMajor";
            this.grvMajor.ReadOnly = true;
            this.grvMajor.Size = new System.Drawing.Size(421, 367);
            this.grvMajor.TabIndex = 107;
            // 
            // gridDomainMinorVersionBindingSource
            // 
            this.gridDomainMinorVersionBindingSource.DataMember = "GridDomainMinorVersion";
            this.gridDomainMinorVersionBindingSource.DataSource = this.eIFCollector;
            // 
            // gridDomainMinorVersionTableAdapter
            // 
            this.gridDomainMinorVersionTableAdapter.ClearBeforeFill = true;
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
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
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
            // pastDueDataGridViewTextBoxColumn
            // 
            this.pastDueDataGridViewTextBoxColumn.DataPropertyName = "PastDue";
            this.pastDueDataGridViewTextBoxColumn.HeaderText = "PastDue";
            this.pastDueDataGridViewTextBoxColumn.Name = "pastDueDataGridViewTextBoxColumn";
            this.pastDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // recordVersionDataGridViewTextBoxColumn
            // 
            this.recordVersionDataGridViewTextBoxColumn.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn.Name = "recordVersionDataGridViewTextBoxColumn";
            this.recordVersionDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn.Visible = false;
            // 
            // tLNameDataGridViewTextBoxColumn
            // 
            this.tLNameDataGridViewTextBoxColumn.DataPropertyName = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn.HeaderText = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn.Name = "tLNameDataGridViewTextBoxColumn";
            this.tLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tLNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dTLNameDataGridViewTextBoxColumn
            // 
            this.dTLNameDataGridViewTextBoxColumn.DataPropertyName = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn.HeaderText = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn.Name = "dTLNameDataGridViewTextBoxColumn";
            this.dTLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTLNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectorNameDataGridViewTextBoxColumn
            // 
            this.collectorNameDataGridViewTextBoxColumn.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn.HeaderText = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn.Name = "collectorNameDataGridViewTextBoxColumn";
            this.collectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectorNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gridDomainMajorVersionBindingSource
            // 
            this.gridDomainMajorVersionBindingSource.DataMember = "GridDomainMajorVersion";
            this.gridDomainMajorVersionBindingSource.DataSource = this.eIFCollector;
            // 
            // gridDomainMajorVersionTableAdapter
            // 
            this.gridDomainMajorVersionTableAdapter.ClearBeforeFill = true;
            // 
            // recordSerialDataGridViewTextBoxColumn1
            // 
            this.recordSerialDataGridViewTextBoxColumn1.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn1.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn1.Name = "recordSerialDataGridViewTextBoxColumn1";
            this.recordSerialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn1.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn1
            // 
            this.domainIDDataGridViewTextBoxColumn1.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn1.Name = "domainIDDataGridViewTextBoxColumn1";
            this.domainIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // accountNoDataGridViewTextBoxColumn1
            // 
            this.accountNoDataGridViewTextBoxColumn1.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn1.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn1.Name = "accountNoDataGridViewTextBoxColumn1";
            this.accountNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn1
            // 
            this.accountIDDataGridViewTextBoxColumn1.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn1.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn1.Name = "accountIDDataGridViewTextBoxColumn1";
            this.accountIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn1
            // 
            this.productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn1.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            this.productDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cycleDataGridViewTextBoxColumn1
            // 
            this.cycleDataGridViewTextBoxColumn1.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn1.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn1.Name = "cycleDataGridViewTextBoxColumn1";
            this.cycleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bucketDataGridViewTextBoxColumn1
            // 
            this.bucketDataGridViewTextBoxColumn1.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn1.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn1.Name = "bucketDataGridViewTextBoxColumn1";
            this.bucketDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pastDueDataGridViewTextBoxColumn1
            // 
            this.pastDueDataGridViewTextBoxColumn1.DataPropertyName = "PastDue";
            this.pastDueDataGridViewTextBoxColumn1.HeaderText = "PastDue";
            this.pastDueDataGridViewTextBoxColumn1.Name = "pastDueDataGridViewTextBoxColumn1";
            this.pastDueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn1
            // 
            this.balanceDataGridViewTextBoxColumn1.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn1.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn1.Name = "balanceDataGridViewTextBoxColumn1";
            this.balanceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn1
            // 
            this.officeDataGridViewTextBoxColumn1.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn1.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn1.Name = "officeDataGridViewTextBoxColumn1";
            this.officeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recordVersionDataGridViewTextBoxColumn1
            // 
            this.recordVersionDataGridViewTextBoxColumn1.DataPropertyName = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn1.HeaderText = "RecordVersion";
            this.recordVersionDataGridViewTextBoxColumn1.Name = "recordVersionDataGridViewTextBoxColumn1";
            this.recordVersionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recordVersionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tLNameDataGridViewTextBoxColumn1
            // 
            this.tLNameDataGridViewTextBoxColumn1.DataPropertyName = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn1.HeaderText = "TL_Name";
            this.tLNameDataGridViewTextBoxColumn1.Name = "tLNameDataGridViewTextBoxColumn1";
            this.tLNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tLNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dTLNameDataGridViewTextBoxColumn1
            // 
            this.dTLNameDataGridViewTextBoxColumn1.DataPropertyName = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn1.HeaderText = "DTL_Name";
            this.dTLNameDataGridViewTextBoxColumn1.Name = "dTLNameDataGridViewTextBoxColumn1";
            this.dTLNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dTLNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // collectorNameDataGridViewTextBoxColumn1
            // 
            this.collectorNameDataGridViewTextBoxColumn1.DataPropertyName = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn1.HeaderText = "CollectorName";
            this.collectorNameDataGridViewTextBoxColumn1.Name = "collectorNameDataGridViewTextBoxColumn1";
            this.collectorNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.collectorNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmDomainMatchRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 512);
            this.Controls.Add(this.grvMajor);
            this.Controls.Add(this.grvMinor);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblMinor);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDomainMatchRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match Records";
            this.Load += new System.EventHandler(this.frmDomainMatchRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colDomainsDataBasicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainMinorVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDomainMajorVersionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        internal System.Windows.Forms.ComboBox txtBranchID;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        internal System.Windows.Forms.Button CmdCompareRecords;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private System.Windows.Forms.BindingSource colDomainsDataBasicBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_DomainsDataBasicTableAdapter col_DomainsDataBasicTableAdapter;
        internal System.Windows.Forms.Label lblMinor;
        internal System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.DataGridView grvMinor;
        private System.Windows.Forms.DataGridView grvMajor;
        private System.Windows.Forms.BindingSource gridDomainMinorVersionBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridDomainMinorVersionTableAdapter gridDomainMinorVersionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gridDomainMajorVersionBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridDomainMajorVersionTableAdapter gridDomainMajorVersionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTLNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorNameDataGridViewTextBoxColumn1;

        
    }
}