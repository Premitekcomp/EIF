namespace TMS.AppForms.Accounting
{
    partial class frmAssMasterBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssMasterBook));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvEntryList = new System.Windows.Forms.DataGridView();
            this.jEDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jEMasterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAccountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAssMasterBookReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOverAllCredit = new System.Windows.Forms.Label();
            this.lblOverAllDepit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdFilterBuSub = new System.Windows.Forms.Button();
            this.txtSubAccountList = new System.Windows.Forms.ComboBox();
            this.aSubAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountListTreeView = new System.Windows.Forms.TreeView();
            this.CmdGetAccountFromJournal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.ComboBox();
            this.aAccountsNumberListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAccountName = new System.Windows.Forms.ComboBox();
            this.aAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.CmdFilterByDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.a_AccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter();
            this.a_AccountsNumberListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsNumberListTableAdapter();
            this.a_SubAccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter();
            this.a_AssMasterBookReportsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AssMasterBookReportsTableAdapter();
            this.CmdLookupAccount = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAssMasterBookReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsNumberListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdExport,
            this.toolStripSeparator4,
            this.CmdPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CmdExport
            // 
            this.CmdExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdExport.Image = ((System.Drawing.Image)(resources.GetObject("CmdExport.Image")));
            this.CmdExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(76, 22);
            this.CmdExport.Text = "تصدير اكسيل";
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdPrint
            // 
            this.CmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("CmdPrint.Image")));
            this.CmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(77, 22);
            this.CmdPrint.Text = "طباعه القائمة";
            this.CmdPrint.Click += new System.EventHandler(this.CmdPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvEntryList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 606);
            this.panel1.TabIndex = 1;
            // 
            // grvEntryList
            // 
            this.grvEntryList.AllowUserToAddRows = false;
            this.grvEntryList.AllowUserToDeleteRows = false;
            this.grvEntryList.AutoGenerateColumns = false;
            this.grvEntryList.BackgroundColor = System.Drawing.Color.White;
            this.grvEntryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEntryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jEDetailIDDataGridViewTextBoxColumn,
            this.jEMasterIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.subAccountIDDataGridViewTextBoxColumn,
            this.Column2,
            this.eNoDataGridViewTextBoxColumn,
            this.eDateDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.subAccountFullNameDataGridViewTextBoxColumn,
            this.debitDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.currencyTitleDataGridViewTextBoxColumn,
            this.exchangeRateDataGridViewTextBoxColumn,
            this.localDebitDataGridViewTextBoxColumn,
            this.localCreditDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.accountSumDataGridViewTextBoxColumn,
            this.Column1,
            this.currencyIDDataGridViewTextBoxColumn});
            this.grvEntryList.DataSource = this.aAssMasterBookReportsBindingSource;
            this.grvEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEntryList.Location = new System.Drawing.Point(0, 0);
            this.grvEntryList.Name = "grvEntryList";
            this.grvEntryList.RowTemplate.Height = 25;
            this.grvEntryList.Size = new System.Drawing.Size(718, 606);
            this.grvEntryList.TabIndex = 0;
            this.grvEntryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEntryList_CellContentClick);
            this.grvEntryList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvEntryList_RowHeaderMouseClick);
            // 
            // jEDetailIDDataGridViewTextBoxColumn
            // 
            this.jEDetailIDDataGridViewTextBoxColumn.DataPropertyName = "JEDetailID";
            this.jEDetailIDDataGridViewTextBoxColumn.HeaderText = "JEDetailID";
            this.jEDetailIDDataGridViewTextBoxColumn.Name = "jEDetailIDDataGridViewTextBoxColumn";
            this.jEDetailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jEMasterIDDataGridViewTextBoxColumn
            // 
            this.jEMasterIDDataGridViewTextBoxColumn.DataPropertyName = "JEMasterID";
            this.jEMasterIDDataGridViewTextBoxColumn.HeaderText = "JEMasterID";
            this.jEMasterIDDataGridViewTextBoxColumn.Name = "jEMasterIDDataGridViewTextBoxColumn";
            this.jEMasterIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // subAccountIDDataGridViewTextBoxColumn
            // 
            this.subAccountIDDataGridViewTextBoxColumn.DataPropertyName = "SubAccountID";
            this.subAccountIDDataGridViewTextBoxColumn.HeaderText = "SubAccountID";
            this.subAccountIDDataGridViewTextBoxColumn.Name = "subAccountIDDataGridViewTextBoxColumn";
            this.subAccountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Text = ". . .";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 5;
            // 
            // eNoDataGridViewTextBoxColumn
            // 
            this.eNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eNoDataGridViewTextBoxColumn.DataPropertyName = "ENo";
            this.eNoDataGridViewTextBoxColumn.HeaderText = "رقم القيد";
            this.eNoDataGridViewTextBoxColumn.Name = "eNoDataGridViewTextBoxColumn";
            this.eNoDataGridViewTextBoxColumn.Width = 87;
            // 
            // eDateDataGridViewTextBoxColumn
            // 
            this.eDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eDateDataGridViewTextBoxColumn.DataPropertyName = "EDate";
            this.eDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الحركة";
            this.eDateDataGridViewTextBoxColumn.Name = "eDateDataGridViewTextBoxColumn";
            this.eDateDataGridViewTextBoxColumn.Width = 98;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountFullNameDataGridViewTextBoxColumn.Width = 74;
            // 
            // subAccountFullNameDataGridViewTextBoxColumn
            // 
            this.subAccountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subAccountFullNameDataGridViewTextBoxColumn.DataPropertyName = "SubAccountFullName";
            this.subAccountFullNameDataGridViewTextBoxColumn.HeaderText = "الحساب التحليلي";
            this.subAccountFullNameDataGridViewTextBoxColumn.Name = "subAccountFullNameDataGridViewTextBoxColumn";
            this.subAccountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subAccountFullNameDataGridViewTextBoxColumn.Width = 122;
            // 
            // debitDataGridViewTextBoxColumn
            // 
            this.debitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debitDataGridViewTextBoxColumn.DataPropertyName = "Debit";
            this.debitDataGridViewTextBoxColumn.HeaderText = "مدين ع.ا";
            this.debitDataGridViewTextBoxColumn.Name = "debitDataGridViewTextBoxColumn";
            this.debitDataGridViewTextBoxColumn.Visible = false;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "دائن ع.ا";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencyTitleDataGridViewTextBoxColumn
            // 
            this.currencyTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currencyTitleDataGridViewTextBoxColumn.DataPropertyName = "CurrencyTitle";
            this.currencyTitleDataGridViewTextBoxColumn.HeaderText = "العمله";
            this.currencyTitleDataGridViewTextBoxColumn.Name = "currencyTitleDataGridViewTextBoxColumn";
            this.currencyTitleDataGridViewTextBoxColumn.Visible = false;
            // 
            // exchangeRateDataGridViewTextBoxColumn
            // 
            this.exchangeRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exchangeRateDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRate";
            this.exchangeRateDataGridViewTextBoxColumn.HeaderText = "سعر الصرف";
            this.exchangeRateDataGridViewTextBoxColumn.Name = "exchangeRateDataGridViewTextBoxColumn";
            this.exchangeRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // localDebitDataGridViewTextBoxColumn
            // 
            this.localDebitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.localDebitDataGridViewTextBoxColumn.DataPropertyName = "LocalDebit";
            this.localDebitDataGridViewTextBoxColumn.HeaderText = "مدين ع.م";
            this.localDebitDataGridViewTextBoxColumn.Name = "localDebitDataGridViewTextBoxColumn";
            this.localDebitDataGridViewTextBoxColumn.Width = 84;
            // 
            // localCreditDataGridViewTextBoxColumn
            // 
            this.localCreditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.localCreditDataGridViewTextBoxColumn.DataPropertyName = "LocalCredit";
            this.localCreditDataGridViewTextBoxColumn.HeaderText = "دائن ع.م";
            this.localCreditDataGridViewTextBoxColumn.Name = "localCreditDataGridViewTextBoxColumn";
            this.localCreditDataGridViewTextBoxColumn.Width = 78;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "بيان";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 55;
            // 
            // accountSumDataGridViewTextBoxColumn
            // 
            this.accountSumDataGridViewTextBoxColumn.DataPropertyName = "AccountSum";
            this.accountSumDataGridViewTextBoxColumn.HeaderText = "الرصيد";
            this.accountSumDataGridViewTextBoxColumn.Name = "accountSumDataGridViewTextBoxColumn";
            this.accountSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountSumDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الرصيد";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // currencyIDDataGridViewTextBoxColumn
            // 
            this.currencyIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyID";
            this.currencyIDDataGridViewTextBoxColumn.HeaderText = "CurrencyID";
            this.currencyIDDataGridViewTextBoxColumn.Name = "currencyIDDataGridViewTextBoxColumn";
            this.currencyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aAssMasterBookReportsBindingSource
            // 
            this.aAssMasterBookReportsBindingSource.DataMember = "A_AssMasterBookReports";
            this.aAssMasterBookReportsBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOverAllCredit);
            this.panel2.Controls.Add(this.lblOverAllDepit);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(718, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 606);
            this.panel2.TabIndex = 0;
            // 
            // lblOverAllCredit
            // 
            this.lblOverAllCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllCredit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllCredit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllCredit.Location = new System.Drawing.Point(33, 555);
            this.lblOverAllCredit.Name = "lblOverAllCredit";
            this.lblOverAllCredit.Size = new System.Drawing.Size(196, 37);
            this.lblOverAllCredit.TabIndex = 35;
            this.lblOverAllCredit.Text = "0";
            this.lblOverAllCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverAllDepit
            // 
            this.lblOverAllDepit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllDepit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllDepit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllDepit.Location = new System.Drawing.Point(33, 505);
            this.lblOverAllDepit.Name = "lblOverAllDepit";
            this.lblOverAllDepit.Size = new System.Drawing.Size(196, 37);
            this.lblOverAllDepit.TabIndex = 34;
            this.lblOverAllDepit.Text = "0";
            this.lblOverAllDepit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdLookupAccount);
            this.groupBox2.Controls.Add(this.CmdFilterBuSub);
            this.groupBox2.Controls.Add(this.txtSubAccountList);
            this.groupBox2.Controls.Add(this.AccountListTreeView);
            this.groupBox2.Controls.Add(this.CmdGetAccountFromJournal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.txtAccountName);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.CmdFilterByDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 488);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصفيه بالتاريخ و النوع";
            // 
            // CmdFilterBuSub
            // 
            this.CmdFilterBuSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterBuSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterBuSub.ForeColor = System.Drawing.Color.White;
            this.CmdFilterBuSub.Location = new System.Drawing.Point(8, 444);
            this.CmdFilterBuSub.Name = "CmdFilterBuSub";
            this.CmdFilterBuSub.Size = new System.Drawing.Size(153, 38);
            this.CmdFilterBuSub.TabIndex = 33;
            this.CmdFilterBuSub.Text = "تصفيه بالحساب التحليلي";
            this.CmdFilterBuSub.UseVisualStyleBackColor = false;
            this.CmdFilterBuSub.Click += new System.EventHandler(this.CmdFilterBuSub_Click);
            // 
            // txtSubAccountList
            // 
            this.txtSubAccountList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSubAccountList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSubAccountList.DataSource = this.aSubAccountsListBindingSource;
            this.txtSubAccountList.DisplayMember = "AccountName";
            this.txtSubAccountList.FormattingEnabled = true;
            this.txtSubAccountList.Location = new System.Drawing.Point(8, 222);
            this.txtSubAccountList.Name = "txtSubAccountList";
            this.txtSubAccountList.Size = new System.Drawing.Size(250, 32);
            this.txtSubAccountList.TabIndex = 32;
            this.txtSubAccountList.ValueMember = "AccountID";
            this.txtSubAccountList.Visible = false;
            // 
            // aSubAccountsListBindingSource
            // 
            this.aSubAccountsListBindingSource.DataMember = "A_SubAccountsList";
            this.aSubAccountsListBindingSource.DataSource = this.accounting;
            // 
            // AccountListTreeView
            // 
            this.AccountListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountListTreeView.FullRowSelect = true;
            this.AccountListTreeView.ItemHeight = 28;
            this.AccountListTreeView.Location = new System.Drawing.Point(8, 222);
            this.AccountListTreeView.Name = "AccountListTreeView";
            this.AccountListTreeView.PathSeparator = " / ";
            this.AccountListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountListTreeView.RightToLeftLayout = true;
            this.AccountListTreeView.Size = new System.Drawing.Size(250, 216);
            this.AccountListTreeView.TabIndex = 31;
            this.AccountListTreeView.Visible = false;
            this.AccountListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountListTreeView_MouseDoubleClick);
            // 
            // CmdGetAccountFromJournal
            // 
            this.CmdGetAccountFromJournal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdGetAccountFromJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetAccountFromJournal.Image = ((System.Drawing.Image)(resources.GetObject("CmdGetAccountFromJournal.Image")));
            this.CmdGetAccountFromJournal.Location = new System.Drawing.Point(8, 181);
            this.CmdGetAccountFromJournal.Name = "CmdGetAccountFromJournal";
            this.CmdGetAccountFromJournal.Size = new System.Drawing.Size(40, 35);
            this.CmdGetAccountFromJournal.TabIndex = 30;
            this.CmdGetAccountFromJournal.UseVisualStyleBackColor = true;
            this.CmdGetAccountFromJournal.Click += new System.EventHandler(this.CmdGetAccountFromJournal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "الحساب:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountNumber.DataSource = this.aAccountsNumberListBindingSource;
            this.txtAccountNumber.DisplayMember = "AccountNumber";
            this.txtAccountNumber.FormattingEnabled = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(8, 110);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(93, 32);
            this.txtAccountNumber.TabIndex = 23;
            this.txtAccountNumber.ValueMember = "AccountID";
            this.txtAccountNumber.SelectedIndexChanged += new System.EventHandler(this.txtAccountNumber_SelectedIndexChanged);
            // 
            // aAccountsNumberListBindingSource
            // 
            this.aAccountsNumberListBindingSource.DataMember = "A_AccountsNumberList";
            this.aAccountsNumberListBindingSource.DataSource = this.accounting;
            // 
            // txtAccountName
            // 
            this.txtAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountName.DataSource = this.aAccountsListBindingSource;
            this.txtAccountName.DisplayMember = "AccountName";
            this.txtAccountName.FormattingEnabled = true;
            this.txtAccountName.Location = new System.Drawing.Point(8, 145);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(250, 32);
            this.txtAccountName.TabIndex = 22;
            this.txtAccountName.ValueMember = "AccountID";
            this.txtAccountName.SelectedIndexChanged += new System.EventHandler(this.txtAccountName_SelectedIndexChanged);
            // 
            // aAccountsListBindingSource
            // 
            this.aAccountsListBindingSource.DataMember = "A_AccountsList";
            this.aAccountsListBindingSource.DataSource = this.accounting;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(8, 69);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(171, 32);
            this.dtEnd.TabIndex = 7;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(8, 31);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(171, 32);
            this.dtStart.TabIndex = 6;
            // 
            // CmdFilterByDate
            // 
            this.CmdFilterByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterByDate.ForeColor = System.Drawing.Color.White;
            this.CmdFilterByDate.Location = new System.Drawing.Point(189, 444);
            this.CmdFilterByDate.Name = "CmdFilterByDate";
            this.CmdFilterByDate.Size = new System.Drawing.Size(69, 38);
            this.CmdFilterByDate.TabIndex = 5;
            this.CmdFilterByDate.Text = "تصفيه";
            this.CmdFilterByDate.UseVisualStyleBackColor = false;
            this.CmdFilterByDate.Click += new System.EventHandler(this.CmdFilterByDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "من يوم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "الي يوم:";
            // 
            // a_AccountsListTableAdapter
            // 
            this.a_AccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_AccountsNumberListTableAdapter
            // 
            this.a_AccountsNumberListTableAdapter.ClearBeforeFill = true;
            // 
            // a_SubAccountsListTableAdapter
            // 
            this.a_SubAccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_AssMasterBookReportsTableAdapter
            // 
            this.a_AssMasterBookReportsTableAdapter.ClearBeforeFill = true;
            // 
            // CmdLookupAccount
            // 
            this.CmdLookupAccount.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdLookupAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLookupAccount.Location = new System.Drawing.Point(54, 181);
            this.CmdLookupAccount.Name = "CmdLookupAccount";
            this.CmdLookupAccount.Size = new System.Drawing.Size(40, 35);
            this.CmdLookupAccount.TabIndex = 44;
            this.CmdLookupAccount.Text = "F3";
            this.CmdLookupAccount.UseVisualStyleBackColor = true;
            this.CmdLookupAccount.Click += new System.EventHandler(this.CmdLookupAccount_Click);
            // 
            // frmAssMasterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmAssMasterBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستاذ المساعد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJournalEntryList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAssMasterBookReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsNumberListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button CmdFilterByDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton CmdExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CmdPrint;
        private System.Windows.Forms.DataGridView grvEntryList;
        private System.Windows.Forms.Label lblOverAllCredit;
        private System.Windows.Forms.Label lblOverAllDepit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtAccountNumber;
        private System.Windows.Forms.ComboBox txtAccountName;
        private System.Windows.Forms.TreeView AccountListTreeView;
        private System.Windows.Forms.Button CmdGetAccountFromJournal;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter a_AccountsListTableAdapter;
        private System.Windows.Forms.BindingSource aAccountsNumberListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsNumberListTableAdapter a_AccountsNumberListTableAdapter;
        private System.Windows.Forms.ComboBox txtSubAccountList;
        private System.Windows.Forms.BindingSource aSubAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter a_SubAccountsListTableAdapter;
        private System.Windows.Forms.BindingSource aAssMasterBookReportsBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AssMasterBookReportsTableAdapter a_AssMasterBookReportsTableAdapter;
        private System.Windows.Forms.Button CmdFilterBuSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEMasterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAccountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdLookupAccount;
    }
}