namespace TMS.AppForms.Collectors
{
    partial class frmDailyVisitShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyVisitShow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridDailyVisitFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.gridDailyVisitFullTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridDailyVisitFullTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdXLSExport = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdLoadFullSheet = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.CmdLoadDomain = new System.Windows.Forms.Button();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector1 = new TMS.AppDataSets.EIFCollector();
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
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointToRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connetctionResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTPTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTPDateFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTPAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keptBrokenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Broken = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keptAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trialDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bucket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPhoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddressTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDailyVisitFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.pointToRecordDataGridViewTextBoxColumn,
            this.collectorDataGridViewTextBoxColumn,
            this.Column1,
            this.empNameARDataGridViewTextBoxColumn,
            this.roleTitleDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.connectionDateDataGridViewTextBoxColumn,
            this.connectionTypeDataGridViewTextBoxColumn,
            this.connetctionResultDataGridViewTextBoxColumn,
            this.pTPTypeDataGridViewTextBoxColumn,
            this.PTPDateFlag,
            this.pTPAmountDataGridViewTextBoxColumn,
            this.keptBrokenDataGridViewCheckBoxColumn,
            this.Broken,
            this.keptAmountDataGridViewTextBoxColumn,
            this.trialDetailsDataGridViewTextBoxColumn,
            this.actionDateDataGridViewTextBoxColumn,
            this.AccountNo,
            this.AccountID,
            this.CustomerName,
            this.Product,
            this.Cycle,
            this.Bucket,
            this.PastDue,
            this.Balance,
            this.City,
            this.Office,
            this.CardNo,
            this.NationalityTitle,
            this.PassportNo,
            this.CreditLimit,
            this.MobileNumber,
            this.AddressT,
            this.WorkPhoneTitle,
            this.CompanyNameTitle,
            this.CompanyAddressTitle});
            this.dataGridView1.DataSource = this.gridDailyVisitFullBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(196, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 459);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gridDailyVisitFullBindingSource
            // 
            this.gridDailyVisitFullBindingSource.DataMember = "GridDailyVisitFull";
            this.gridDailyVisitFullBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridDailyVisitFullTableAdapter
            // 
            this.gridDailyVisitFullTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdXLSExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1042, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CmdXLSExport
            // 
            this.CmdXLSExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdXLSExport.Image = ((System.Drawing.Image)(resources.GetObject("CmdXLSExport.Image")));
            this.CmdXLSExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdXLSExport.Name = "CmdXLSExport";
            this.CmdXLSExport.Size = new System.Drawing.Size(66, 22);
            this.CmdXLSExport.Text = "XLS Export";
            this.CmdXLSExport.Click += new System.EventHandler(this.CmdXLSExport_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CmdLoadFullSheet);
            this.GroupBox1.Controls.Add(this.dtEndDate);
            this.GroupBox1.Controls.Add(this.dtStartDate);
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
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox1.Location = new System.Drawing.Point(0, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(196, 459);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            // 
            // CmdLoadFullSheet
            // 
            this.CmdLoadFullSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLoadFullSheet.Location = new System.Drawing.Point(6, 419);
            this.CmdLoadFullSheet.Name = "CmdLoadFullSheet";
            this.CmdLoadFullSheet.Size = new System.Drawing.Size(178, 37);
            this.CmdLoadFullSheet.TabIndex = 58;
            this.CmdLoadFullSheet.Text = "Load DCR / Full Sheet";
            this.CmdLoadFullSheet.UseVisualStyleBackColor = true;
            this.CmdLoadFullSheet.Visible = false;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(6, 346);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(113, 24);
            this.dtEndDate.TabIndex = 57;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(6, 316);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(113, 24);
            this.dtStartDate.TabIndex = 56;
            // 
            // CmdLoadDomain
            // 
            this.CmdLoadDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLoadDomain.Location = new System.Drawing.Point(6, 376);
            this.CmdLoadDomain.Name = "CmdLoadDomain";
            this.CmdLoadDomain.Size = new System.Drawing.Size(178, 37);
            this.CmdLoadDomain.TabIndex = 55;
            this.CmdLoadDomain.Text = "Load Domain DCR";
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
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector1;
            // 
            // eIFCollector1
            // 
            this.eIFCollector1.DataSetName = "EIFCollector";
            this.eIFCollector1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(6, 178);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(178, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Domain List";
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
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector1;
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
            this.lupBranchListBindingSource.DataSource = this.eIFCollector1;
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
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector1;
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
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTitle,
            this.ColValue});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(842, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 459);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColTitle
            // 
            this.ColTitle.Text = "";
            this.ColTitle.Width = 100;
            // 
            // ColValue
            // 
            this.ColValue.Text = "";
            this.ColValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColValue.Width = 100;
            // 
            // recordSerialDataGridViewTextBoxColumn
            // 
            this.recordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.Name = "recordSerialDataGridViewTextBoxColumn";
            this.recordSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // pointToRecordDataGridViewTextBoxColumn
            // 
            this.pointToRecordDataGridViewTextBoxColumn.DataPropertyName = "PointToRecord";
            this.pointToRecordDataGridViewTextBoxColumn.HeaderText = "PointToRecord";
            this.pointToRecordDataGridViewTextBoxColumn.Name = "pointToRecordDataGridViewTextBoxColumn";
            this.pointToRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointToRecordDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectorDataGridViewTextBoxColumn
            // 
            this.collectorDataGridViewTextBoxColumn.DataPropertyName = "Collector";
            this.collectorDataGridViewTextBoxColumn.HeaderText = "Collector";
            this.collectorDataGridViewTextBoxColumn.Name = "collectorDataGridViewTextBoxColumn";
            this.collectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectorDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Del";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "X";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 33;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "Action Taker";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleTitleDataGridViewTextBoxColumn
            // 
            this.roleTitleDataGridViewTextBoxColumn.DataPropertyName = "RoleTitle";
            this.roleTitleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleTitleDataGridViewTextBoxColumn.Name = "roleTitleDataGridViewTextBoxColumn";
            this.roleTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            this.teamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionDateDataGridViewTextBoxColumn
            // 
            this.connectionDateDataGridViewTextBoxColumn.DataPropertyName = "ConnectionDate";
            this.connectionDateDataGridViewTextBoxColumn.HeaderText = "Connection Date";
            this.connectionDateDataGridViewTextBoxColumn.Name = "connectionDateDataGridViewTextBoxColumn";
            this.connectionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionTypeDataGridViewTextBoxColumn
            // 
            this.connectionTypeDataGridViewTextBoxColumn.DataPropertyName = "ConnectionType";
            this.connectionTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.connectionTypeDataGridViewTextBoxColumn.Name = "connectionTypeDataGridViewTextBoxColumn";
            this.connectionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connetctionResultDataGridViewTextBoxColumn
            // 
            this.connetctionResultDataGridViewTextBoxColumn.DataPropertyName = "ConnetctionResult";
            this.connetctionResultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.connetctionResultDataGridViewTextBoxColumn.Name = "connetctionResultDataGridViewTextBoxColumn";
            this.connetctionResultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pTPTypeDataGridViewTextBoxColumn
            // 
            this.pTPTypeDataGridViewTextBoxColumn.DataPropertyName = "PTPType";
            this.pTPTypeDataGridViewTextBoxColumn.HeaderText = "PTP Type";
            this.pTPTypeDataGridViewTextBoxColumn.Name = "pTPTypeDataGridViewTextBoxColumn";
            this.pTPTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PTPDateFlag
            // 
            this.PTPDateFlag.DataPropertyName = "PTPDateFlag";
            this.PTPDateFlag.HeaderText = "PTP Date";
            this.PTPDateFlag.Name = "PTPDateFlag";
            this.PTPDateFlag.ReadOnly = true;
            // 
            // pTPAmountDataGridViewTextBoxColumn
            // 
            this.pTPAmountDataGridViewTextBoxColumn.DataPropertyName = "PTPAmount";
            this.pTPAmountDataGridViewTextBoxColumn.HeaderText = "PTP Amount";
            this.pTPAmountDataGridViewTextBoxColumn.Name = "pTPAmountDataGridViewTextBoxColumn";
            this.pTPAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keptBrokenDataGridViewCheckBoxColumn
            // 
            this.keptBrokenDataGridViewCheckBoxColumn.DataPropertyName = "KeptBroken";
            this.keptBrokenDataGridViewCheckBoxColumn.HeaderText = "Kept";
            this.keptBrokenDataGridViewCheckBoxColumn.Name = "keptBrokenDataGridViewCheckBoxColumn";
            this.keptBrokenDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Broken
            // 
            this.Broken.DataPropertyName = "Broken";
            this.Broken.HeaderText = "Broken";
            this.Broken.Name = "Broken";
            this.Broken.ReadOnly = true;
            // 
            // keptAmountDataGridViewTextBoxColumn
            // 
            this.keptAmountDataGridViewTextBoxColumn.DataPropertyName = "KeptAmount";
            this.keptAmountDataGridViewTextBoxColumn.HeaderText = "Kept Amount";
            this.keptAmountDataGridViewTextBoxColumn.Name = "keptAmountDataGridViewTextBoxColumn";
            this.keptAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trialDetailsDataGridViewTextBoxColumn
            // 
            this.trialDetailsDataGridViewTextBoxColumn.DataPropertyName = "TrialDetails";
            this.trialDetailsDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.trialDetailsDataGridViewTextBoxColumn.Name = "trialDetailsDataGridViewTextBoxColumn";
            this.trialDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionDateDataGridViewTextBoxColumn
            // 
            this.actionDateDataGridViewTextBoxColumn.DataPropertyName = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.HeaderText = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.Name = "actionDateDataGridViewTextBoxColumn";
            this.actionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // AccountNo
            // 
            this.AccountNo.DataPropertyName = "AccountNo";
            this.AccountNo.HeaderText = "AccountNo";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            // 
            // AccountID
            // 
            this.AccountID.DataPropertyName = "AccountID";
            this.AccountID.HeaderText = "AccountID";
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            // 
            // Bucket
            // 
            this.Bucket.DataPropertyName = "Bucket";
            this.Bucket.HeaderText = "Bucket";
            this.Bucket.Name = "Bucket";
            this.Bucket.ReadOnly = true;
            // 
            // PastDue
            // 
            this.PastDue.DataPropertyName = "PastDue";
            this.PastDue.HeaderText = "PastDue";
            this.PastDue.Name = "PastDue";
            this.PastDue.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Office
            // 
            this.Office.DataPropertyName = "Office";
            this.Office.HeaderText = "Office";
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "Card No";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            // 
            // NationalityTitle
            // 
            this.NationalityTitle.DataPropertyName = "NationalityTitle";
            this.NationalityTitle.HeaderText = "Nationality";
            this.NationalityTitle.Name = "NationalityTitle";
            this.NationalityTitle.ReadOnly = true;
            // 
            // PassportNo
            // 
            this.PassportNo.DataPropertyName = "PassportNo";
            this.PassportNo.HeaderText = "Passport No";
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.ReadOnly = true;
            // 
            // CreditLimit
            // 
            this.CreditLimit.DataPropertyName = "CreditLimit";
            this.CreditLimit.HeaderText = "Credit Limit";
            this.CreditLimit.Name = "CreditLimit";
            this.CreditLimit.ReadOnly = true;
            // 
            // MobileNumber
            // 
            this.MobileNumber.DataPropertyName = "MobileNumber";
            this.MobileNumber.HeaderText = "Mobile Number";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            // 
            // AddressT
            // 
            this.AddressT.DataPropertyName = "AddressT";
            this.AddressT.HeaderText = "Address";
            this.AddressT.Name = "AddressT";
            this.AddressT.ReadOnly = true;
            // 
            // WorkPhoneTitle
            // 
            this.WorkPhoneTitle.DataPropertyName = "WorkPhoneTitle";
            this.WorkPhoneTitle.HeaderText = "Work Phone";
            this.WorkPhoneTitle.Name = "WorkPhoneTitle";
            this.WorkPhoneTitle.ReadOnly = true;
            // 
            // CompanyNameTitle
            // 
            this.CompanyNameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyNameTitle.DataPropertyName = "CompanyNameTitle";
            this.CompanyNameTitle.HeaderText = "Company Name";
            this.CompanyNameTitle.Name = "CompanyNameTitle";
            this.CompanyNameTitle.ReadOnly = true;
            this.CompanyNameTitle.Width = 121;
            // 
            // CompanyAddressTitle
            // 
            this.CompanyAddressTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompanyAddressTitle.DataPropertyName = "CompanyAddressTitle";
            this.CompanyAddressTitle.HeaderText = "Company Address";
            this.CompanyAddressTitle.Name = "CompanyAddressTitle";
            this.CompanyAddressTitle.ReadOnly = true;
            this.CompanyAddressTitle.Width = 132;
            // 
            // frmDailyVisitShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDailyVisitShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDailyVisitShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDailyVisitFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource gridDailyVisitFullBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridDailyVisitFullTableAdapter gridDailyVisitFullTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button CmdLoadDomain;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        internal System.Windows.Forms.ComboBox txtBranchID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        private AppDataSets.EIFCollector eIFCollector1;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColTitle;
        private System.Windows.Forms.ColumnHeader ColValue;
        private System.Windows.Forms.ToolStripButton CmdXLSExport;
        internal System.Windows.Forms.Button CmdLoadFullSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointToRecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connetctionResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTPTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTPDateFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTPAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keptBrokenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Broken;
        private System.Windows.Forms.DataGridViewTextBoxColumn keptAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trialDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bucket;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPhoneTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddressTitle;
    }
}