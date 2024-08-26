namespace TMS.AppForms.Accounting
{
    partial class frmSimpleJournalEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleJournalEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblEntryNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntryType = new System.Windows.Forms.ComboBox();
            this.aLupJETypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.txtDebitForginCurreny = new System.Windows.Forms.TextBox();
            this.txtDebitLocalCurrency = new System.Windows.Forms.TextBox();
            this.txtCridtLocalCurrency = new System.Windows.Forms.TextBox();
            this.txtCridtForginCurrency = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.ComboBox();
            this.lupcurrencyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupComboFill = new TMS.AppDataSets.LupComboFill();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntryNote = new System.Windows.Forms.TextBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.ComboBox();
            this.accountNameForJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.CmdGetAccountFromJournal = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.ComboBox();
            this.accountNumberForJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdAdd = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AccountListTreeView = new System.Windows.Forms.TreeView();
            this.txtSubAccountList = new System.Windows.Forms.ComboBox();
            this.aSubAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lup_currencyTypesTableAdapter = new TMS.AppDataSets.LupComboFillTableAdapters.Lup_currencyTypesTableAdapter();
            this.lblOverAllDepit = new System.Windows.Forms.Label();
            this.lblOverAllCredit = new System.Windows.Forms.Label();
            this.CmdCloseEntry = new System.Windows.Forms.Button();
            this.lblMSG = new System.Windows.Forms.Label();
            this.lblUnBalancedEntry = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grvEntryDetails = new System.Windows.Forms.DataGridView();
            this.jEDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jEMasterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCenterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAccountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCenterFullAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aJournalDetailsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jEDetailIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jEMasterIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightAsTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCostCenterValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_SubAccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter();
            this.accountNumberForJournalTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AccountNumberForJournalTableAdapter();
            this.accountNameForJournalTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AccountNameForJournalTableAdapter();
            this.a_Lup_JETypesTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_Lup_JETypesTableAdapter();
            this.a_JournalDetailsViewTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_JournalDetailsViewTableAdapter();
            this.a_CostCenterValuesTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_CostCenterValuesTableAdapter();
            this.CmdPrint = new System.Windows.Forms.Button();
            this.aJournalBasicViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_JournalBasicViewTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_JournalBasicViewTableAdapter();
            this.txtSubNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.CmdShowEntry = new System.Windows.Forms.Button();
            this.CmdLookupAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aLupJETypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupcurrencyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNameForJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberForJournalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalDetailsViewBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCostCenterValuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalBasicViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1079, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم القيد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1077, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ القيد:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "البيان:";
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntryDate.Location = new System.Drawing.Point(946, 51);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(113, 32);
            this.dtEntryDate.TabIndex = 3;
            // 
            // lblEntryNo
            // 
            this.lblEntryNo.AutoSize = true;
            this.lblEntryNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEntryNo.Location = new System.Drawing.Point(989, 21);
            this.lblEntryNo.Name = "lblEntryNo";
            this.lblEntryNo.Size = new System.Drawing.Size(27, 24);
            this.lblEntryNo.TabIndex = 4;
            this.lblEntryNo.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1083, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "توع القيد:";
            // 
            // txtEntryType
            // 
            this.txtEntryType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEntryType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEntryType.DataSource = this.aLupJETypesBindingSource;
            this.txtEntryType.DisplayMember = "JETypeNameAr";
            this.txtEntryType.FormattingEnabled = true;
            this.txtEntryType.Location = new System.Drawing.Point(856, 89);
            this.txtEntryType.Name = "txtEntryType";
            this.txtEntryType.Size = new System.Drawing.Size(203, 32);
            this.txtEntryType.TabIndex = 4;
            this.txtEntryType.ValueMember = "JETypeID";
            // 
            // aLupJETypesBindingSource
            // 
            this.aLupJETypesBindingSource.DataMember = "A_Lup_JETypes";
            this.aLupJETypesBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDebitForginCurreny
            // 
            this.txtDebitForginCurreny.Location = new System.Drawing.Point(387, 188);
            this.txtDebitForginCurreny.Name = "txtDebitForginCurreny";
            this.txtDebitForginCurreny.Size = new System.Drawing.Size(84, 32);
            this.txtDebitForginCurreny.TabIndex = 9;
            this.txtDebitForginCurreny.Text = "0";
            this.txtDebitForginCurreny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDebitForginCurreny.Visible = false;
            this.txtDebitForginCurreny.TextChanged += new System.EventHandler(this.txtDebitForginCurreny_TextChanged);
            this.txtDebitForginCurreny.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtDebitLocalCurrency
            // 
            this.txtDebitLocalCurrency.Location = new System.Drawing.Point(207, 188);
            this.txtDebitLocalCurrency.Name = "txtDebitLocalCurrency";
            this.txtDebitLocalCurrency.Size = new System.Drawing.Size(84, 32);
            this.txtDebitLocalCurrency.TabIndex = 9;
            this.txtDebitLocalCurrency.Text = "0";
            this.txtDebitLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDebitLocalCurrency.TextChanged += new System.EventHandler(this.txtDebitLocalCurrency_TextChanged);
            this.txtDebitLocalCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtCridtLocalCurrency
            // 
            this.txtCridtLocalCurrency.Location = new System.Drawing.Point(117, 188);
            this.txtCridtLocalCurrency.Name = "txtCridtLocalCurrency";
            this.txtCridtLocalCurrency.Size = new System.Drawing.Size(84, 32);
            this.txtCridtLocalCurrency.TabIndex = 10;
            this.txtCridtLocalCurrency.Text = "0";
            this.txtCridtLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCridtLocalCurrency.TextChanged += new System.EventHandler(this.txtCridtLocalCurrency_TextChanged);
            this.txtCridtLocalCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtCridtForginCurrency
            // 
            this.txtCridtForginCurrency.Location = new System.Drawing.Point(297, 188);
            this.txtCridtForginCurrency.Name = "txtCridtForginCurrency";
            this.txtCridtForginCurrency.Size = new System.Drawing.Size(84, 32);
            this.txtCridtForginCurrency.TabIndex = 11;
            this.txtCridtForginCurrency.Text = "0";
            this.txtCridtForginCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCridtForginCurrency.Visible = false;
            this.txtCridtForginCurrency.TextChanged += new System.EventHandler(this.txtCridtForginCurrency_TextChanged);
            this.txtCridtForginCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtCurrency
            // 
            this.txtCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCurrency.DataSource = this.lupcurrencyTypesBindingSource;
            this.txtCurrency.DisplayMember = "Title";
            this.txtCurrency.FormattingEnabled = true;
            this.txtCurrency.Location = new System.Drawing.Point(533, 188);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(108, 32);
            this.txtCurrency.TabIndex = 14;
            this.txtCurrency.ValueMember = "currncyTypeID";
            this.txtCurrency.SelectedIndexChanged += new System.EventHandler(this.txtCurrency_SelectedIndexChanged);
            // 
            // lupcurrencyTypesBindingSource
            // 
            this.lupcurrencyTypesBindingSource.DataMember = "Lup_currencyTypes";
            this.lupcurrencyTypesBindingSource.DataSource = this.lupComboFill;
            // 
            // lupComboFill
            // 
            this.lupComboFill.DataSetName = "LupComboFill";
            this.lupComboFill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "العملة:";
            // 
            // txtEntryNote
            // 
            this.txtEntryNote.Location = new System.Drawing.Point(502, 51);
            this.txtEntryNote.Multiline = true;
            this.txtEntryNote.Name = "txtEntryNote";
            this.txtEntryNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntryNote.Size = new System.Drawing.Size(285, 70);
            this.txtEntryNote.TabIndex = 5;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(477, 188);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(50, 32);
            this.txtExchangeRate.TabIndex = 16;
            this.txtExchangeRate.Text = "0";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExchangeRate.Visible = false;
            this.txtExchangeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtAccountName
            // 
            this.txtAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountName.DataSource = this.accountNameForJournalBindingSource;
            this.txtAccountName.DisplayMember = "AccountName";
            this.txtAccountName.FormattingEnabled = true;
            this.txtAccountName.Location = new System.Drawing.Point(837, 188);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(203, 32);
            this.txtAccountName.TabIndex = 7;
            this.txtAccountName.ValueMember = "AccountID";
            this.txtAccountName.SelectedIndexChanged += new System.EventHandler(this.txtAccountName_SelectedIndexChanged);
            // 
            // accountNameForJournalBindingSource
            // 
            this.accountNameForJournalBindingSource.DataMember = "AccountNameForJournal";
            this.accountNameForJournalBindingSource.DataSource = this.accounting;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1092, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "الحساب:";
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(477, 136);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(49, 49);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "س العملة:";
            this.lbl1.Visible = false;
            // 
            // CmdGetAccountFromJournal
            // 
            this.CmdGetAccountFromJournal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdGetAccountFromJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetAccountFromJournal.Image = ((System.Drawing.Image)(resources.GetObject("CmdGetAccountFromJournal.Image")));
            this.CmdGetAccountFromJournal.Location = new System.Drawing.Point(837, 148);
            this.CmdGetAccountFromJournal.Name = "CmdGetAccountFromJournal";
            this.CmdGetAccountFromJournal.Size = new System.Drawing.Size(40, 35);
            this.CmdGetAccountFromJournal.TabIndex = 20;
            this.CmdGetAccountFromJournal.UseVisualStyleBackColor = true;
            this.CmdGetAccountFromJournal.Click += new System.EventHandler(this.CmdGetAccountFromJournal_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountNumber.DataSource = this.accountNumberForJournalBindingSource;
            this.txtAccountNumber.DisplayMember = "AccountNumber";
            this.txtAccountNumber.FormattingEnabled = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(1047, 188);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(93, 32);
            this.txtAccountNumber.TabIndex = 6;
            this.txtAccountNumber.ValueMember = "AccountID";
            this.txtAccountNumber.SelectedIndexChanged += new System.EventHandler(this.txtAccountNumber_SelectedIndexChanged);
            // 
            // accountNumberForJournalBindingSource
            // 
            this.accountNumberForJournalBindingSource.DataMember = "AccountNumberForJournal";
            this.accountNumberForJournalBindingSource.DataSource = this.accounting;
            // 
            // CmdAdd
            // 
            this.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAdd.Location = new System.Drawing.Point(25, 183);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 37);
            this.CmdAdd.TabIndex = 12;
            this.CmdAdd.Text = "اضافه";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(387, 161);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 24);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "مدين";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(297, 161);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(84, 24);
            this.lbl3.TabIndex = 24;
            this.lbl3.Text = "دائن";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl4.Location = new System.Drawing.Point(297, 136);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(174, 24);
            this.lbl4.TabIndex = 25;
            this.lbl4.Text = "العملة الاجنبية";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Visible = false;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(117, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "العملة المحلية";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(117, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "دائن";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(207, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "مدين";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountListTreeView
            // 
            this.AccountListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountListTreeView.FullRowSelect = true;
            this.AccountListTreeView.ItemHeight = 28;
            this.AccountListTreeView.Location = new System.Drawing.Point(837, 229);
            this.AccountListTreeView.Name = "AccountListTreeView";
            this.AccountListTreeView.PathSeparator = " / ";
            this.AccountListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountListTreeView.RightToLeftLayout = true;
            this.AccountListTreeView.Size = new System.Drawing.Size(303, 339);
            this.AccountListTreeView.TabIndex = 29;
            this.AccountListTreeView.Visible = false;
            this.AccountListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountListTreeView_MouseDoubleClick);
            // 
            // txtSubAccountList
            // 
            this.txtSubAccountList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSubAccountList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSubAccountList.DataSource = this.aSubAccountsListBindingSource;
            this.txtSubAccountList.DisplayMember = "AccountName";
            this.txtSubAccountList.FormattingEnabled = true;
            this.txtSubAccountList.Location = new System.Drawing.Point(647, 188);
            this.txtSubAccountList.Name = "txtSubAccountList";
            this.txtSubAccountList.Size = new System.Drawing.Size(184, 32);
            this.txtSubAccountList.TabIndex = 8;
            this.txtSubAccountList.ValueMember = "AccountID";
            this.txtSubAccountList.Visible = false;
            // 
            // aSubAccountsListBindingSource
            // 
            this.aSubAccountsListBindingSource.DataMember = "A_SubAccountsList";
            this.aSubAccountsListBindingSource.DataSource = this.accounting;
            // 
            // lup_currencyTypesTableAdapter
            // 
            this.lup_currencyTypesTableAdapter.ClearBeforeFill = true;
            // 
            // lblOverAllDepit
            // 
            this.lblOverAllDepit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllDepit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllDepit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllDepit.Location = new System.Drawing.Point(205, 572);
            this.lblOverAllDepit.Name = "lblOverAllDepit";
            this.lblOverAllDepit.Size = new System.Drawing.Size(170, 37);
            this.lblOverAllDepit.TabIndex = 32;
            this.lblOverAllDepit.Text = "0";
            this.lblOverAllDepit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverAllCredit
            // 
            this.lblOverAllCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllCredit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllCredit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllCredit.Location = new System.Drawing.Point(25, 572);
            this.lblOverAllCredit.Name = "lblOverAllCredit";
            this.lblOverAllCredit.Size = new System.Drawing.Size(170, 37);
            this.lblOverAllCredit.TabIndex = 33;
            this.lblOverAllCredit.Text = "0";
            this.lblOverAllCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmdCloseEntry
            // 
            this.CmdCloseEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCloseEntry.Location = new System.Drawing.Point(707, 573);
            this.CmdCloseEntry.Name = "CmdCloseEntry";
            this.CmdCloseEntry.Size = new System.Drawing.Size(433, 37);
            this.CmdCloseEntry.TabIndex = 34;
            this.CmdCloseEntry.Text = "حفظ و انهاء القيد";
            this.CmdCloseEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCloseEntry.UseVisualStyleBackColor = true;
            this.CmdCloseEntry.Click += new System.EventHandler(this.CmdCloseEntry_Click);
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMSG.Location = new System.Drawing.Point(25, 21);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 24);
            this.lblMSG.TabIndex = 35;
            // 
            // lblUnBalancedEntry
            // 
            this.lblUnBalancedEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnBalancedEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnBalancedEntry.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnBalancedEntry.ForeColor = System.Drawing.Color.Red;
            this.lblUnBalancedEntry.Location = new System.Drawing.Point(293, 51);
            this.lblUnBalancedEntry.Name = "lblUnBalancedEntry";
            this.lblUnBalancedEntry.Size = new System.Drawing.Size(174, 45);
            this.lblUnBalancedEntry.TabIndex = 36;
            this.lblUnBalancedEntry.Text = "القيد غير متزن";
            this.lblUnBalancedEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnBalancedEntry.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 299);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvEntryDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "القيود";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grvEntryDetails
            // 
            this.grvEntryDetails.AllowUserToAddRows = false;
            this.grvEntryDetails.AllowUserToDeleteRows = false;
            this.grvEntryDetails.AutoGenerateColumns = false;
            this.grvEntryDetails.BackgroundColor = System.Drawing.Color.White;
            this.grvEntryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEntryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jEDetailIDDataGridViewTextBoxColumn,
            this.jEMasterIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.subAccountIDDataGridViewTextBoxColumn,
            this.costCenterIDDataGridViewTextBoxColumn,
            this.currencyIDDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.subAccountFullNameDataGridViewTextBoxColumn,
            this.costCenterFullAccountNameDataGridViewTextBoxColumn,
            this.currencyTitleDataGridViewTextBoxColumn,
            this.debitDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.exchangeRateDataGridViewTextBoxColumn,
            this.localDebitDataGridViewTextBoxColumn,
            this.localCreditDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.grvEntryDetails.DataSource = this.aJournalDetailsViewBindingSource;
            this.grvEntryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEntryDetails.Location = new System.Drawing.Point(3, 3);
            this.grvEntryDetails.Name = "grvEntryDetails";
            this.grvEntryDetails.RowTemplate.Height = 25;
            this.grvEntryDetails.Size = new System.Drawing.Size(1101, 256);
            this.grvEntryDetails.TabIndex = 32;
            this.grvEntryDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEntryDetails_CellContentClick);
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
            // costCenterIDDataGridViewTextBoxColumn
            // 
            this.costCenterIDDataGridViewTextBoxColumn.DataPropertyName = "CostCenterID";
            this.costCenterIDDataGridViewTextBoxColumn.HeaderText = "CostCenterID";
            this.costCenterIDDataGridViewTextBoxColumn.Name = "costCenterIDDataGridViewTextBoxColumn";
            this.costCenterIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencyIDDataGridViewTextBoxColumn
            // 
            this.currencyIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyID";
            this.currencyIDDataGridViewTextBoxColumn.HeaderText = "CurrencyID";
            this.currencyIDDataGridViewTextBoxColumn.Name = "currencyIDDataGridViewTextBoxColumn";
            this.currencyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // costCenterFullAccountNameDataGridViewTextBoxColumn
            // 
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.DataPropertyName = "CostCenterFullAccountName";
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.HeaderText = "مركز التكلفه";
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.Name = "costCenterFullAccountNameDataGridViewTextBoxColumn";
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costCenterFullAccountNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencyTitleDataGridViewTextBoxColumn
            // 
            this.currencyTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currencyTitleDataGridViewTextBoxColumn.DataPropertyName = "CurrencyTitle";
            this.currencyTitleDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyTitleDataGridViewTextBoxColumn.Name = "currencyTitleDataGridViewTextBoxColumn";
            this.currencyTitleDataGridViewTextBoxColumn.Width = 71;
            // 
            // debitDataGridViewTextBoxColumn
            // 
            this.debitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debitDataGridViewTextBoxColumn.DataPropertyName = "Debit";
            this.debitDataGridViewTextBoxColumn.HeaderText = "مدين ع.ا";
            this.debitDataGridViewTextBoxColumn.Name = "debitDataGridViewTextBoxColumn";
            this.debitDataGridViewTextBoxColumn.Width = 79;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "دائن ع.ا";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Width = 73;
            // 
            // exchangeRateDataGridViewTextBoxColumn
            // 
            this.exchangeRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exchangeRateDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRate";
            this.exchangeRateDataGridViewTextBoxColumn.HeaderText = "سعر التحويل";
            this.exchangeRateDataGridViewTextBoxColumn.Name = "exchangeRateDataGridViewTextBoxColumn";
            this.exchangeRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangeRateDataGridViewTextBoxColumn.Width = 102;
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
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 81;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "تعديل";
            this.Column1.Name = "Column1";
            this.Column1.Text = "حفظ";
            this.Column1.ToolTipText = "حفظ";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 48;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "حذف";
            this.Column2.Name = "Column2";
            this.Column2.Text = "x";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 42;
            // 
            // aJournalDetailsViewBindingSource
            // 
            this.aJournalDetailsViewBindingSource.DataMember = "A_JournalDetailsView";
            this.aJournalDetailsViewBindingSource.DataSource = this.accounting;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مراكز التكلفة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jEDetailIDDataGridViewTextBoxColumn1,
            this.jEMasterIDDataGridViewTextBoxColumn1,
            this.entryValueDataGridViewTextBoxColumn,
            this.cCFullNameDataGridViewTextBoxColumn,
            this.weightAsTextDataGridViewTextBoxColumn,
            this.cCValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCostCenterValuesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // jEDetailIDDataGridViewTextBoxColumn1
            // 
            this.jEDetailIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jEDetailIDDataGridViewTextBoxColumn1.DataPropertyName = "JEDetailID";
            this.jEDetailIDDataGridViewTextBoxColumn1.HeaderText = "JEDetailID";
            this.jEDetailIDDataGridViewTextBoxColumn1.Name = "jEDetailIDDataGridViewTextBoxColumn1";
            this.jEDetailIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // jEMasterIDDataGridViewTextBoxColumn1
            // 
            this.jEMasterIDDataGridViewTextBoxColumn1.DataPropertyName = "JEMasterID";
            this.jEMasterIDDataGridViewTextBoxColumn1.HeaderText = "JEMasterID";
            this.jEMasterIDDataGridViewTextBoxColumn1.Name = "jEMasterIDDataGridViewTextBoxColumn1";
            this.jEMasterIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // entryValueDataGridViewTextBoxColumn
            // 
            this.entryValueDataGridViewTextBoxColumn.DataPropertyName = "EntryValue";
            this.entryValueDataGridViewTextBoxColumn.HeaderText = "EntryValue";
            this.entryValueDataGridViewTextBoxColumn.Name = "entryValueDataGridViewTextBoxColumn";
            this.entryValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryValueDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCFullNameDataGridViewTextBoxColumn
            // 
            this.cCFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCFullNameDataGridViewTextBoxColumn.DataPropertyName = "CCFullName";
            this.cCFullNameDataGridViewTextBoxColumn.HeaderText = "مركز التكلفه";
            this.cCFullNameDataGridViewTextBoxColumn.Name = "cCFullNameDataGridViewTextBoxColumn";
            this.cCFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightAsTextDataGridViewTextBoxColumn
            // 
            this.weightAsTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weightAsTextDataGridViewTextBoxColumn.DataPropertyName = "WeightAsText";
            this.weightAsTextDataGridViewTextBoxColumn.HeaderText = "نسبة مركز التكلفه";
            this.weightAsTextDataGridViewTextBoxColumn.Name = "weightAsTextDataGridViewTextBoxColumn";
            this.weightAsTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightAsTextDataGridViewTextBoxColumn.Width = 136;
            // 
            // cCValueDataGridViewTextBoxColumn
            // 
            this.cCValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCValueDataGridViewTextBoxColumn.DataPropertyName = "CCValue";
            this.cCValueDataGridViewTextBoxColumn.HeaderText = "القيمة";
            this.cCValueDataGridViewTextBoxColumn.Name = "cCValueDataGridViewTextBoxColumn";
            this.cCValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCValueDataGridViewTextBoxColumn.Width = 72;
            // 
            // aCostCenterValuesBindingSource
            // 
            this.aCostCenterValuesBindingSource.DataMember = "A_CostCenterValues";
            this.aCostCenterValuesBindingSource.DataSource = this.accounting;
            // 
            // a_SubAccountsListTableAdapter
            // 
            this.a_SubAccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // accountNumberForJournalTableAdapter
            // 
            this.accountNumberForJournalTableAdapter.ClearBeforeFill = true;
            // 
            // accountNameForJournalTableAdapter
            // 
            this.accountNameForJournalTableAdapter.ClearBeforeFill = true;
            // 
            // a_Lup_JETypesTableAdapter
            // 
            this.a_Lup_JETypesTableAdapter.ClearBeforeFill = true;
            // 
            // a_JournalDetailsViewTableAdapter
            // 
            this.a_JournalDetailsViewTableAdapter.ClearBeforeFill = true;
            // 
            // a_CostCenterValuesTableAdapter
            // 
            this.a_CostCenterValuesTableAdapter.ClearBeforeFill = true;
            // 
            // CmdPrint
            // 
            this.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdPrint.Location = new System.Drawing.Point(496, 572);
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(205, 37);
            this.CmdPrint.TabIndex = 38;
            this.CmdPrint.Text = "طباعة القيد";
            this.CmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdPrint.UseVisualStyleBackColor = true;
            this.CmdPrint.Click += new System.EventHandler(this.CmdPrint_Click);
            // 
            // aJournalBasicViewBindingSource
            // 
            this.aJournalBasicViewBindingSource.DataMember = "A_JournalBasicView";
            this.aJournalBasicViewBindingSource.DataSource = this.accounting;
            // 
            // a_JournalBasicViewTableAdapter
            // 
            this.a_JournalBasicViewTableAdapter.ClearBeforeFill = true;
            // 
            // txtSubNote
            // 
            this.txtSubNote.Location = new System.Drawing.Point(117, 226);
            this.txtSubNote.Name = "txtSubNote";
            this.txtSubNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubNote.Size = new System.Drawing.Size(670, 32);
            this.txtSubNote.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "ملاحظات:";
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.Location = new System.Drawing.Point(117, 54);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.Size = new System.Drawing.Size(84, 32);
            this.txtEntryNo.TabIndex = 41;
            this.txtEntryNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmdShowEntry
            // 
            this.CmdShowEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShowEntry.Location = new System.Drawing.Point(25, 54);
            this.CmdShowEntry.Name = "CmdShowEntry";
            this.CmdShowEntry.Size = new System.Drawing.Size(75, 37);
            this.CmdShowEntry.TabIndex = 42;
            this.CmdShowEntry.Text = "عرض";
            this.CmdShowEntry.UseVisualStyleBackColor = true;
            this.CmdShowEntry.Click += new System.EventHandler(this.CmdShowEntry_Click);
            // 
            // CmdLookupAccount
            // 
            this.CmdLookupAccount.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdLookupAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLookupAccount.Location = new System.Drawing.Point(883, 147);
            this.CmdLookupAccount.Name = "CmdLookupAccount";
            this.CmdLookupAccount.Size = new System.Drawing.Size(40, 35);
            this.CmdLookupAccount.TabIndex = 43;
            this.CmdLookupAccount.Text = "F3";
            this.CmdLookupAccount.UseVisualStyleBackColor = true;
            this.CmdLookupAccount.Click += new System.EventHandler(this.CmdLookupAccount_Click);
            // 
            // frmSimpleJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 624);
            this.Controls.Add(this.CmdLookupAccount);
            this.Controls.Add(this.CmdShowEntry);
            this.Controls.Add(this.txtEntryNo);
            this.Controls.Add(this.txtSubNote);
            this.Controls.Add(this.CmdPrint);
            this.Controls.Add(this.lblUnBalancedEntry);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.CmdCloseEntry);
            this.Controls.Add(this.lblOverAllCredit);
            this.Controls.Add(this.lblOverAllDepit);
            this.Controls.Add(this.txtSubAccountList);
            this.Controls.Add(this.AccountListTreeView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.CmdGetAccountFromJournal);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.txtEntryNote);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCridtLocalCurrency);
            this.Controls.Add(this.txtCridtForginCurrency);
            this.Controls.Add(this.txtDebitLocalCurrency);
            this.Controls.Add(this.txtDebitForginCurreny);
            this.Controls.Add(this.txtEntryType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEntryNo);
            this.Controls.Add(this.dtEntryDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmSimpleJournalEntry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قيد اليوميه";
            this.Load += new System.EventHandler(this.frmSimpleJournalEntry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSimpleJournalEntry_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.aLupJETypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupcurrencyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNameForJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberForJournalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalDetailsViewBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCostCenterValuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalBasicViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEntryDate;
        private System.Windows.Forms.Label lblEntryNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtEntryType;
        private System.Windows.Forms.TextBox txtDebitForginCurreny;
        private System.Windows.Forms.TextBox txtDebitLocalCurrency;
        private System.Windows.Forms.TextBox txtCridtLocalCurrency;
        private System.Windows.Forms.TextBox txtCridtForginCurrency;
        private System.Windows.Forms.ComboBox txtCurrency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntryNote;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.ComboBox txtAccountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button CmdGetAccountFromJournal;
        private System.Windows.Forms.ComboBox txtAccountNumber;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TreeView AccountListTreeView;
        private System.Windows.Forms.ComboBox txtSubAccountList;
        private AppDataSets.LupComboFill lupComboFill;
        private System.Windows.Forms.BindingSource lupcurrencyTypesBindingSource;
        private AppDataSets.LupComboFillTableAdapters.Lup_currencyTypesTableAdapter lup_currencyTypesTableAdapter;
        private System.Windows.Forms.BindingSource aSubAccountsListBindingSource;
        private AppDataSets.Accounting accounting;
        private AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter a_SubAccountsListTableAdapter;
        private System.Windows.Forms.BindingSource accountNumberForJournalBindingSource;
        private AppDataSets.AccountingTableAdapters.AccountNumberForJournalTableAdapter accountNumberForJournalTableAdapter;
        private System.Windows.Forms.BindingSource accountNameForJournalBindingSource;
        private AppDataSets.AccountingTableAdapters.AccountNameForJournalTableAdapter accountNameForJournalTableAdapter;
        private System.Windows.Forms.BindingSource aLupJETypesBindingSource;
        private AppDataSets.AccountingTableAdapters.A_Lup_JETypesTableAdapter a_Lup_JETypesTableAdapter;
        private System.Windows.Forms.BindingSource aJournalDetailsViewBindingSource;
        private AppDataSets.AccountingTableAdapters.A_JournalDetailsViewTableAdapter a_JournalDetailsViewTableAdapter;
        private System.Windows.Forms.Label lblOverAllDepit;
        private System.Windows.Forms.Label lblOverAllCredit;
        private System.Windows.Forms.Button CmdCloseEntry;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Label lblUnBalancedEntry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grvEntryDetails;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aCostCenterValuesBindingSource;
        private AppDataSets.AccountingTableAdapters.A_CostCenterValuesTableAdapter a_CostCenterValuesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEDetailIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEMasterIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightAsTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEMasterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCenterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAccountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCenterFullAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button CmdPrint;
        private System.Windows.Forms.BindingSource aJournalBasicViewBindingSource;
        private AppDataSets.AccountingTableAdapters.A_JournalBasicViewTableAdapter a_JournalBasicViewTableAdapter;
        private System.Windows.Forms.TextBox txtSubNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.Button CmdShowEntry;
        private System.Windows.Forms.Button CmdLookupAccount;
    }
}