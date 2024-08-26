namespace TMS.AppForms.Accounting
{
    partial class frmAutomaticRecordsSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormListTV = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFormListID = new System.Windows.Forms.ComboBox();
            this.automationFormListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingSub = new TMS.AppDataSets.AccountingSub();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grvList = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subAccountTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aAutoEnginCoreViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActionID = new System.Windows.Forms.ComboBox();
            this.aAutoConfigFormActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RWithNoSub = new System.Windows.Forms.RadioButton();
            this.RSubFromTree = new System.Windows.Forms.RadioButton();
            this.txtSubAccountList = new System.Windows.Forms.ComboBox();
            this.aSubAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.txtFieldIDforSubAccount = new System.Windows.Forms.ComboBox();
            this.aAutoConfigFormFields1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RSubFromForm = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RMasterFromTree = new System.Windows.Forms.RadioButton();
            this.txtAccountList = new System.Windows.Forms.ComboBox();
            this.aAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFieldIDforMasterAccount = new System.Windows.Forms.ComboBox();
            this.aAutoConfigFormFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RMasterFromForm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RDepit = new System.Windows.Forms.RadioButton();
            this.RCredit = new System.Windows.Forms.RadioButton();
            this.lblFormName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.automationFormListTableAdapter = new TMS.AppDataSets.AccountingSubTableAdapters.AutomationFormListTableAdapter();
            this.a_Auto_Config_FormFieldsTableAdapter = new TMS.AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormFieldsTableAdapter();
            this.a_Auto_Config_FormFields1TableAdapter = new TMS.AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormFields1TableAdapter();
            this.a_AccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter();
            this.a_SubAccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter();
            this.a_Auto_EnginCoreViewTableAdapter = new TMS.AppDataSets.AccountingSubTableAdapters.A_Auto_EnginCoreViewTableAdapter();
            this.a_Auto_Config_FormActionsTableAdapter = new TMS.AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormActionsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automationFormListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingSub)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoEnginCoreViewBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormActionsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormFields1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormFieldsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormListTV);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(922, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 565);
            this.panel1.TabIndex = 0;
            // 
            // FormListTV
            // 
            this.FormListTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormListTV.Location = new System.Drawing.Point(0, 77);
            this.FormListTV.Name = "FormListTV";
            this.FormListTV.PathSeparator = "/";
            this.FormListTV.RightToLeftLayout = true;
            this.FormListTV.Size = new System.Drawing.Size(227, 488);
            this.FormListTV.TabIndex = 2;
            this.FormListTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormListTV_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFormListID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أختار النموذج";
            // 
            // txtFormListID
            // 
            this.txtFormListID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFormListID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFormListID.DataSource = this.automationFormListBindingSource;
            this.txtFormListID.DisplayMember = "FormTitle";
            this.txtFormListID.FormattingEnabled = true;
            this.txtFormListID.Location = new System.Drawing.Point(8, 32);
            this.txtFormListID.Name = "txtFormListID";
            this.txtFormListID.Size = new System.Drawing.Size(206, 32);
            this.txtFormListID.TabIndex = 0;
            this.txtFormListID.ValueMember = "FormID";
            // 
            // automationFormListBindingSource
            // 
            this.automationFormListBindingSource.DataMember = "AutomationFormList";
            this.automationFormListBindingSource.DataSource = this.accountingSub;
            // 
            // accountingSub
            // 
            this.accountingSub.DataSetName = "AccountingSub";
            this.accountingSub.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 565);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 313);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 252);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvList);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "معاينه القيد";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grvList
            // 
            this.grvList.AllowUserToAddRows = false;
            this.grvList.AllowUserToDeleteRows = false;
            this.grvList.AutoGenerateColumns = false;
            this.grvList.BackgroundColor = System.Drawing.Color.White;
            this.grvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.formIDDataGridViewTextBoxColumn,
            this.directionTitleDataGridViewTextBoxColumn,
            this.accountTitleDataGridViewTextBoxColumn,
            this.subAccountTitleDataGridViewTextBoxColumn,
            this.Column1});
            this.grvList.DataSource = this.aAutoEnginCoreViewBindingSource;
            this.grvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvList.Location = new System.Drawing.Point(3, 3);
            this.grvList.Name = "grvList";
            this.grvList.RowTemplate.Height = 25;
            this.grvList.Size = new System.Drawing.Size(908, 209);
            this.grvList.TabIndex = 0;
            this.grvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvList_CellContentClick);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // formIDDataGridViewTextBoxColumn
            // 
            this.formIDDataGridViewTextBoxColumn.DataPropertyName = "FormID";
            this.formIDDataGridViewTextBoxColumn.HeaderText = "FormID";
            this.formIDDataGridViewTextBoxColumn.Name = "formIDDataGridViewTextBoxColumn";
            this.formIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // directionTitleDataGridViewTextBoxColumn
            // 
            this.directionTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.directionTitleDataGridViewTextBoxColumn.DataPropertyName = "DirectionTitle";
            this.directionTitleDataGridViewTextBoxColumn.HeaderText = "";
            this.directionTitleDataGridViewTextBoxColumn.Name = "directionTitleDataGridViewTextBoxColumn";
            this.directionTitleDataGridViewTextBoxColumn.Width = 19;
            // 
            // accountTitleDataGridViewTextBoxColumn
            // 
            this.accountTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountTitleDataGridViewTextBoxColumn.DataPropertyName = "AccountTitle";
            this.accountTitleDataGridViewTextBoxColumn.HeaderText = "الحساب الرئيسي";
            this.accountTitleDataGridViewTextBoxColumn.Name = "accountTitleDataGridViewTextBoxColumn";
            this.accountTitleDataGridViewTextBoxColumn.Width = 121;
            // 
            // subAccountTitleDataGridViewTextBoxColumn
            // 
            this.subAccountTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subAccountTitleDataGridViewTextBoxColumn.DataPropertyName = "SubAccountTitle";
            this.subAccountTitleDataGridViewTextBoxColumn.HeaderText = "الحساب التحليلي";
            this.subAccountTitleDataGridViewTextBoxColumn.Name = "subAccountTitleDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "حذف";
            this.Column1.Name = "Column1";
            this.Column1.Text = "حذف";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 42;
            // 
            // aAutoEnginCoreViewBindingSource
            // 
            this.aAutoEnginCoreViewBindingSource.DataMember = "A_Auto_EnginCoreView";
            this.aAutoEnginCoreViewBindingSource.DataSource = this.accountingSub;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtActionID);
            this.panel3.Controls.Add(this.CmdAdd);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.lblFormName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 313);
            this.panel3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "الاجراء:";
            // 
            // txtActionID
            // 
            this.txtActionID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtActionID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtActionID.DataSource = this.aAutoConfigFormActionsBindingSource;
            this.txtActionID.DisplayMember = "ActionName";
            this.txtActionID.FormattingEnabled = true;
            this.txtActionID.Location = new System.Drawing.Point(177, 21);
            this.txtActionID.Name = "txtActionID";
            this.txtActionID.Size = new System.Drawing.Size(140, 32);
            this.txtActionID.TabIndex = 19;
            this.txtActionID.ValueMember = "ActionID";
            this.txtActionID.SelectedIndexChanged += new System.EventHandler(this.txtActionID_SelectedIndexChanged);
            // 
            // aAutoConfigFormActionsBindingSource
            // 
            this.aAutoConfigFormActionsBindingSource.DataMember = "A_Auto_Config_FormActions";
            this.aAutoConfigFormActionsBindingSource.DataSource = this.accountingSub;
            // 
            // CmdAdd
            // 
            this.CmdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAdd.ForeColor = System.Drawing.Color.White;
            this.CmdAdd.Location = new System.Drawing.Point(18, 251);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(149, 49);
            this.CmdAdd.TabIndex = 18;
            this.CmdAdd.Text = "اضافه";
            this.CmdAdd.UseVisualStyleBackColor = false;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RWithNoSub);
            this.groupBox4.Controls.Add(this.RSubFromTree);
            this.groupBox4.Controls.Add(this.txtSubAccountList);
            this.groupBox4.Controls.Add(this.txtFieldIDforSubAccount);
            this.groupBox4.Controls.Add(this.RSubFromForm);
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 78);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تفاصيل الحساب التحليلي";
            // 
            // RWithNoSub
            // 
            this.RWithNoSub.AutoSize = true;
            this.RWithNoSub.Location = new System.Drawing.Point(659, 29);
            this.RWithNoSub.Name = "RWithNoSub";
            this.RWithNoSub.Size = new System.Drawing.Size(54, 28);
            this.RWithNoSub.TabIndex = 10;
            this.RWithNoSub.TabStop = true;
            this.RWithNoSub.Text = "بدون";
            this.RWithNoSub.UseVisualStyleBackColor = true;
            this.RWithNoSub.CheckedChanged += new System.EventHandler(this.RWithNoSub_CheckedChanged);
            // 
            // RSubFromTree
            // 
            this.RSubFromTree.AutoSize = true;
            this.RSubFromTree.Location = new System.Drawing.Point(533, 30);
            this.RSubFromTree.Name = "RSubFromTree";
            this.RSubFromTree.Size = new System.Drawing.Size(80, 28);
            this.RSubFromTree.TabIndex = 6;
            this.RSubFromTree.TabStop = true;
            this.RSubFromTree.Text = "من الدليل";
            this.RSubFromTree.UseVisualStyleBackColor = true;
            this.RSubFromTree.CheckedChanged += new System.EventHandler(this.RSubFromTree_CheckedChanged);
            // 
            // txtSubAccountList
            // 
            this.txtSubAccountList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSubAccountList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSubAccountList.DataSource = this.aSubAccountsListBindingSource;
            this.txtSubAccountList.DisplayMember = "AccountName";
            this.txtSubAccountList.FormattingEnabled = true;
            this.txtSubAccountList.Location = new System.Drawing.Point(323, 30);
            this.txtSubAccountList.Name = "txtSubAccountList";
            this.txtSubAccountList.Size = new System.Drawing.Size(193, 32);
            this.txtSubAccountList.TabIndex = 8;
            this.txtSubAccountList.ValueMember = "AccountID";
            this.txtSubAccountList.Visible = false;
            // 
            // aSubAccountsListBindingSource
            // 
            this.aSubAccountsListBindingSource.DataMember = "A_SubAccountsList";
            this.aSubAccountsListBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFieldIDforSubAccount
            // 
            this.txtFieldIDforSubAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFieldIDforSubAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFieldIDforSubAccount.DataSource = this.aAutoConfigFormFields1BindingSource;
            this.txtFieldIDforSubAccount.DisplayMember = "FieldTitle";
            this.txtFieldIDforSubAccount.FormattingEnabled = true;
            this.txtFieldIDforSubAccount.Location = new System.Drawing.Point(6, 29);
            this.txtFieldIDforSubAccount.Name = "txtFieldIDforSubAccount";
            this.txtFieldIDforSubAccount.Size = new System.Drawing.Size(193, 32);
            this.txtFieldIDforSubAccount.TabIndex = 9;
            this.txtFieldIDforSubAccount.ValueMember = "FieldID";
            // 
            // aAutoConfigFormFields1BindingSource
            // 
            this.aAutoConfigFormFields1BindingSource.DataMember = "A_Auto_Config_FormFields1";
            this.aAutoConfigFormFields1BindingSource.DataSource = this.accountingSub;
            // 
            // RSubFromForm
            // 
            this.RSubFromForm.AutoSize = true;
            this.RSubFromForm.Checked = true;
            this.RSubFromForm.Location = new System.Drawing.Point(205, 30);
            this.RSubFromForm.Name = "RSubFromForm";
            this.RSubFromForm.Size = new System.Drawing.Size(89, 28);
            this.RSubFromForm.TabIndex = 7;
            this.RSubFromForm.TabStop = true;
            this.RSubFromForm.Text = "من النموذج";
            this.RSubFromForm.UseVisualStyleBackColor = true;
            this.RSubFromForm.CheckedChanged += new System.EventHandler(this.RSubFromForm_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RMasterFromTree);
            this.groupBox3.Controls.Add(this.txtAccountList);
            this.groupBox3.Controls.Add(this.txtFieldIDforMasterAccount);
            this.groupBox3.Controls.Add(this.RMasterFromForm);
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 78);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفاصيل الحساب الرئيسي";
            // 
            // RMasterFromTree
            // 
            this.RMasterFromTree.AutoSize = true;
            this.RMasterFromTree.Checked = true;
            this.RMasterFromTree.Location = new System.Drawing.Point(533, 34);
            this.RMasterFromTree.Name = "RMasterFromTree";
            this.RMasterFromTree.Size = new System.Drawing.Size(80, 28);
            this.RMasterFromTree.TabIndex = 6;
            this.RMasterFromTree.TabStop = true;
            this.RMasterFromTree.Text = "من الدليل";
            this.RMasterFromTree.UseVisualStyleBackColor = true;
            this.RMasterFromTree.CheckedChanged += new System.EventHandler(this.RMasterFromTree_CheckedChanged);
            // 
            // txtAccountList
            // 
            this.txtAccountList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountList.DataSource = this.aAccountsListBindingSource;
            this.txtAccountList.DisplayMember = "AccountName";
            this.txtAccountList.FormattingEnabled = true;
            this.txtAccountList.Location = new System.Drawing.Point(323, 30);
            this.txtAccountList.Name = "txtAccountList";
            this.txtAccountList.Size = new System.Drawing.Size(193, 32);
            this.txtAccountList.TabIndex = 8;
            this.txtAccountList.ValueMember = "AccountID";
            this.txtAccountList.SelectedIndexChanged += new System.EventHandler(this.txtAccountList_SelectedIndexChanged);
            // 
            // aAccountsListBindingSource
            // 
            this.aAccountsListBindingSource.DataMember = "A_AccountsList";
            this.aAccountsListBindingSource.DataSource = this.accounting;
            // 
            // txtFieldIDforMasterAccount
            // 
            this.txtFieldIDforMasterAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFieldIDforMasterAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFieldIDforMasterAccount.DataSource = this.aAutoConfigFormFieldsBindingSource;
            this.txtFieldIDforMasterAccount.DisplayMember = "FieldTitle";
            this.txtFieldIDforMasterAccount.FormattingEnabled = true;
            this.txtFieldIDforMasterAccount.Location = new System.Drawing.Point(6, 29);
            this.txtFieldIDforMasterAccount.Name = "txtFieldIDforMasterAccount";
            this.txtFieldIDforMasterAccount.Size = new System.Drawing.Size(193, 32);
            this.txtFieldIDforMasterAccount.TabIndex = 9;
            this.txtFieldIDforMasterAccount.ValueMember = "FieldID";
            this.txtFieldIDforMasterAccount.Visible = false;
            // 
            // aAutoConfigFormFieldsBindingSource
            // 
            this.aAutoConfigFormFieldsBindingSource.DataMember = "A_Auto_Config_FormFields";
            this.aAutoConfigFormFieldsBindingSource.DataSource = this.accountingSub;
            // 
            // RMasterFromForm
            // 
            this.RMasterFromForm.AutoSize = true;
            this.RMasterFromForm.Location = new System.Drawing.Point(205, 30);
            this.RMasterFromForm.Name = "RMasterFromForm";
            this.RMasterFromForm.Size = new System.Drawing.Size(89, 28);
            this.RMasterFromForm.TabIndex = 7;
            this.RMasterFromForm.TabStop = true;
            this.RMasterFromForm.Text = "من النموذج";
            this.RMasterFromForm.UseVisualStyleBackColor = true;
            this.RMasterFromForm.CheckedChanged += new System.EventHandler(this.RMasterFromForm_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RDepit);
            this.groupBox2.Controls.Add(this.RCredit);
            this.groupBox2.Location = new System.Drawing.Point(695, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 58);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طرف القيد";
            // 
            // RDepit
            // 
            this.RDepit.AutoSize = true;
            this.RDepit.Checked = true;
            this.RDepit.Location = new System.Drawing.Point(72, 21);
            this.RDepit.Name = "RDepit";
            this.RDepit.Size = new System.Drawing.Size(56, 28);
            this.RDepit.TabIndex = 3;
            this.RDepit.TabStop = true;
            this.RDepit.Text = "مدين";
            this.RDepit.UseVisualStyleBackColor = true;
            // 
            // RCredit
            // 
            this.RCredit.AutoSize = true;
            this.RCredit.Location = new System.Drawing.Point(6, 21);
            this.RCredit.Name = "RCredit";
            this.RCredit.Size = new System.Drawing.Size(50, 28);
            this.RCredit.TabIndex = 4;
            this.RCredit.TabStop = true;
            this.RCredit.Text = "دائن";
            this.RCredit.UseVisualStyleBackColor = true;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFormName.Location = new System.Drawing.Point(545, 24);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(27, 24);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "النموذج الفعال:";
            // 
            // automationFormListTableAdapter
            // 
            this.automationFormListTableAdapter.ClearBeforeFill = true;
            // 
            // a_Auto_Config_FormFieldsTableAdapter
            // 
            this.a_Auto_Config_FormFieldsTableAdapter.ClearBeforeFill = true;
            // 
            // a_Auto_Config_FormFields1TableAdapter
            // 
            this.a_Auto_Config_FormFields1TableAdapter.ClearBeforeFill = true;
            // 
            // a_AccountsListTableAdapter
            // 
            this.a_AccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_SubAccountsListTableAdapter
            // 
            this.a_SubAccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_Auto_EnginCoreViewTableAdapter
            // 
            this.a_Auto_EnginCoreViewTableAdapter.ClearBeforeFill = true;
            // 
            // a_Auto_Config_FormActionsTableAdapter
            // 
            this.a_Auto_Config_FormActionsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAutomaticRecordsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmAutomaticRecordsSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادت القيود الاليه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAutomaticRecordsSetting_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.automationFormListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingSub)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoEnginCoreViewBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormActionsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormFields1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAutoConfigFormFieldsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtFormListID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtFieldIDforMasterAccount;
        private System.Windows.Forms.ComboBox txtAccountList;
        private System.Windows.Forms.RadioButton RMasterFromForm;
        private System.Windows.Forms.RadioButton RMasterFromTree;
        private System.Windows.Forms.RadioButton RCredit;
        private System.Windows.Forms.RadioButton RDepit;
        private AppDataSets.AccountingSub accountingSub;
        private System.Windows.Forms.BindingSource automationFormListBindingSource;
        private AppDataSets.AccountingSubTableAdapters.AutomationFormListTableAdapter automationFormListTableAdapter;
        private System.Windows.Forms.TreeView FormListTV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RSubFromTree;
        private System.Windows.Forms.ComboBox txtSubAccountList;
        private System.Windows.Forms.ComboBox txtFieldIDforSubAccount;
        private System.Windows.Forms.RadioButton RSubFromForm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource aAutoConfigFormFieldsBindingSource;
        private AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormFieldsTableAdapter a_Auto_Config_FormFieldsTableAdapter;
        private System.Windows.Forms.BindingSource aAutoConfigFormFields1BindingSource;
        private AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormFields1TableAdapter a_Auto_Config_FormFields1TableAdapter;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter a_AccountsListTableAdapter;
        private System.Windows.Forms.BindingSource aSubAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter a_SubAccountsListTableAdapter;
        private System.Windows.Forms.RadioButton RWithNoSub;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grvList;
        private System.Windows.Forms.BindingSource aAutoEnginCoreViewBindingSource;
        private AppDataSets.AccountingSubTableAdapters.A_Auto_EnginCoreViewTableAdapter a_Auto_EnginCoreViewTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtActionID;
        private System.Windows.Forms.BindingSource aAutoConfigFormActionsBindingSource;
        private AppDataSets.AccountingSubTableAdapters.A_Auto_Config_FormActionsTableAdapter a_Auto_Config_FormActionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subAccountTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}