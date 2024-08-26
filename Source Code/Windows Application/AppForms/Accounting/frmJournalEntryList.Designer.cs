namespace TMS.AppForms.Accounting
{
    partial class frmJournalEntryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalEntryList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdApprove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdDisApprove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdRestore = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DDBulkActionOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.CmdApproveMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdDeApproveMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdCancelMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdRestoreMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.DDQuickFilters = new System.Windows.Forms.ToolStripDropDownButton();
            this.CmdGetAllUnApproved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdGetAllUnBalanced = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdGetAllDeleted = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvEntryList = new System.Windows.Forms.DataGridView();
            this.aJournalBasicViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOverAllCredit = new System.Windows.Forms.Label();
            this.lblOverAllDepit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEntryTypeID = new System.Windows.Forms.ComboBox();
            this.aLupJETypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IsAllType = new System.Windows.Forms.CheckBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.CmdFilterByDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdShowAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdFilterByNumbers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_Lup_JETypesTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_Lup_JETypesTableAdapter();
            this.a_JournalBasicViewTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_JournalBasicViewTableAdapter();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jETypeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryBalanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryApproveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDelStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RCDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LADate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalBasicViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLupJETypesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdApprove,
            this.toolStripSeparator1,
            this.CmdDisApprove,
            this.toolStripSeparator2,
            this.CmdDel,
            this.toolStripSeparator3,
            this.CmdRestore,
            this.toolStripSeparator5,
            this.DDBulkActionOption,
            this.toolStripSeparator7,
            this.DDQuickFilters,
            this.toolStripSeparator6,
            this.CmdExport,
            this.toolStripSeparator4,
            this.CmdPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CmdApprove
            // 
            this.CmdApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdApprove.Image = ((System.Drawing.Image)(resources.GetObject("CmdApprove.Image")));
            this.CmdApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdApprove.Name = "CmdApprove";
            this.CmdApprove.Size = new System.Drawing.Size(67, 22);
            this.CmdApprove.Text = "اعتماد القيد";
            this.CmdApprove.Click += new System.EventHandler(this.CmdApprove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdDisApprove
            // 
            this.CmdDisApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdDisApprove.Image = ((System.Drawing.Image)(resources.GetObject("CmdDisApprove.Image")));
            this.CmdDisApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdDisApprove.Name = "CmdDisApprove";
            this.CmdDisApprove.Size = new System.Drawing.Size(86, 22);
            this.CmdDisApprove.Text = "فك اعتماد القيد";
            this.CmdDisApprove.Click += new System.EventHandler(this.CmdDisApprove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdDel
            // 
            this.CmdDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdDel.Image = ((System.Drawing.Image)(resources.GetObject("CmdDel.Image")));
            this.CmdDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.Size = new System.Drawing.Size(59, 22);
            this.CmdDel.Text = "الغاء القيد";
            this.CmdDel.Click += new System.EventHandler(this.CmdDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdRestore
            // 
            this.CmdRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdRestore.Image = ((System.Drawing.Image)(resources.GetObject("CmdRestore.Image")));
            this.CmdRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRestore.Name = "CmdRestore";
            this.CmdRestore.Size = new System.Drawing.Size(76, 22);
            this.CmdRestore.Text = "استعاده القيد";
            this.CmdRestore.Click += new System.EventHandler(this.CmdRestore_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // DDBulkActionOption
            // 
            this.DDBulkActionOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DDBulkActionOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdApproveMulti,
            this.CmdDeApproveMulti,
            this.toolStripSeparator8,
            this.CmdCancelMulti,
            this.CmdRestoreMulti});
            this.DDBulkActionOption.Image = ((System.Drawing.Image)(resources.GetObject("DDBulkActionOption.Image")));
            this.DDBulkActionOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DDBulkActionOption.Name = "DDBulkActionOption";
            this.DDBulkActionOption.Size = new System.Drawing.Size(92, 22);
            this.DDBulkActionOption.Text = "إجرائات للمحدد";
            // 
            // CmdApproveMulti
            // 
            this.CmdApproveMulti.Name = "CmdApproveMulti";
            this.CmdApproveMulti.Size = new System.Drawing.Size(176, 22);
            this.CmdApproveMulti.Text = "اعتماد كل المحدد";
            this.CmdApproveMulti.Click += new System.EventHandler(this.CmdApproveMulti_Click);
            // 
            // CmdDeApproveMulti
            // 
            this.CmdDeApproveMulti.Name = "CmdDeApproveMulti";
            this.CmdDeApproveMulti.Size = new System.Drawing.Size(176, 22);
            this.CmdDeApproveMulti.Text = "فك اعتماد كل المحدد";
            this.CmdDeApproveMulti.Click += new System.EventHandler(this.CmdDeApproveMulti_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // CmdCancelMulti
            // 
            this.CmdCancelMulti.Name = "CmdCancelMulti";
            this.CmdCancelMulti.Size = new System.Drawing.Size(176, 22);
            this.CmdCancelMulti.Text = "الغاء كل المحدد";
            this.CmdCancelMulti.Click += new System.EventHandler(this.CmdCancelMulti_Click);
            // 
            // CmdRestoreMulti
            // 
            this.CmdRestoreMulti.Name = "CmdRestoreMulti";
            this.CmdRestoreMulti.Size = new System.Drawing.Size(176, 22);
            this.CmdRestoreMulti.Text = "استعاده كل المحدد";
            this.CmdRestoreMulti.Click += new System.EventHandler(this.CmdRestoreMulti_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // DDQuickFilters
            // 
            this.DDQuickFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DDQuickFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdGetAllUnApproved,
            this.toolStripSeparator10,
            this.CmdGetAllUnBalanced,
            this.toolStripSeparator9,
            this.CmdGetAllDeleted});
            this.DDQuickFilters.Image = ((System.Drawing.Image)(resources.GetObject("DDQuickFilters.Image")));
            this.DDQuickFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DDQuickFilters.Name = "DDQuickFilters";
            this.DDQuickFilters.Size = new System.Drawing.Size(122, 22);
            this.DDQuickFilters.Text = "خيارات تصفيه سريعه";
            // 
            // CmdGetAllUnApproved
            // 
            this.CmdGetAllUnApproved.Name = "CmdGetAllUnApproved";
            this.CmdGetAllUnApproved.Size = new System.Drawing.Size(199, 22);
            this.CmdGetAllUnApproved.Text = "عرض القيود غير المعتمده";
            this.CmdGetAllUnApproved.Click += new System.EventHandler(this.CmdGetAllUnApproved_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(196, 6);
            // 
            // CmdGetAllUnBalanced
            // 
            this.CmdGetAllUnBalanced.Name = "CmdGetAllUnBalanced";
            this.CmdGetAllUnBalanced.Size = new System.Drawing.Size(199, 22);
            this.CmdGetAllUnBalanced.Text = "عرض القيود غير المتزنه";
            this.CmdGetAllUnBalanced.Click += new System.EventHandler(this.CmdGetAllUnBalanced_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(196, 6);
            // 
            // CmdGetAllDeleted
            // 
            this.CmdGetAllDeleted.Name = "CmdGetAllDeleted";
            this.CmdGetAllDeleted.Size = new System.Drawing.Size(199, 22);
            this.CmdGetAllDeleted.Text = "عرض القيود الملغاة";
            this.CmdGetAllDeleted.Click += new System.EventHandler(this.CmdGetAllDeleted_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            this.panel1.Size = new System.Drawing.Size(777, 606);
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
            this.eIDDataGridViewTextBoxColumn,
            this.entryTypeIDDataGridViewTextBoxColumn,
            this.Column2,
            this.Column1,
            this.jETypeNameArDataGridViewTextBoxColumn,
            this.eNoDataGridViewTextBoxColumn,
            this.eDateDataGridViewTextBoxColumn,
            this.totalDebitDataGridViewTextBoxColumn,
            this.totalCreditDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.EntryBalanceStatus,
            this.entryApproveStatusDataGridViewTextBoxColumn,
            this.entryDelStatusDataGridViewTextBoxColumn,
            this.CreatedBy,
            this.RCDate,
            this.ModifiedBy,
            this.LADate});
            this.grvEntryList.DataSource = this.aJournalBasicViewBindingSource;
            this.grvEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEntryList.Location = new System.Drawing.Point(0, 0);
            this.grvEntryList.Name = "grvEntryList";
            this.grvEntryList.RowTemplate.Height = 25;
            this.grvEntryList.Size = new System.Drawing.Size(777, 606);
            this.grvEntryList.TabIndex = 0;
            this.grvEntryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEntryList_CellContentClick);
            this.grvEntryList.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvEntryList_ColumnHeaderMouseDoubleClick);
            this.grvEntryList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvEntryList_RowHeaderMouseClick);
            // 
            // aJournalBasicViewBindingSource
            // 
            this.aJournalBasicViewBindingSource.DataMember = "A_JournalBasicView";
            this.aJournalBasicViewBindingSource.DataSource = this.accounting;
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
            this.panel2.Controls.Add(this.CmdShowAll);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(777, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 606);
            this.panel2.TabIndex = 0;
            // 
            // lblOverAllCredit
            // 
            this.lblOverAllCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllCredit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllCredit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllCredit.Location = new System.Drawing.Point(10, 544);
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
            this.lblOverAllDepit.Location = new System.Drawing.Point(10, 494);
            this.lblOverAllDepit.Name = "lblOverAllDepit";
            this.lblOverAllDepit.Size = new System.Drawing.Size(196, 37);
            this.lblOverAllDepit.TabIndex = 34;
            this.lblOverAllDepit.Text = "0";
            this.lblOverAllDepit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEntryTypeID);
            this.groupBox2.Controls.Add(this.IsAllType);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.CmdFilterByDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 219);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصفيه بالتاريخ و النوع";
            // 
            // txtEntryTypeID
            // 
            this.txtEntryTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEntryTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEntryTypeID.DataSource = this.aLupJETypesBindingSource;
            this.txtEntryTypeID.DisplayMember = "JETypeNameAr";
            this.txtEntryTypeID.FormattingEnabled = true;
            this.txtEntryTypeID.Location = new System.Drawing.Point(10, 58);
            this.txtEntryTypeID.Name = "txtEntryTypeID";
            this.txtEntryTypeID.Size = new System.Drawing.Size(179, 32);
            this.txtEntryTypeID.TabIndex = 9;
            this.txtEntryTypeID.ValueMember = "JETypeID";
            // 
            // aLupJETypesBindingSource
            // 
            this.aLupJETypesBindingSource.DataMember = "A_Lup_JETypes";
            this.aLupJETypesBindingSource.DataSource = this.accounting;
            // 
            // IsAllType
            // 
            this.IsAllType.AutoSize = true;
            this.IsAllType.Checked = true;
            this.IsAllType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsAllType.Location = new System.Drawing.Point(108, 31);
            this.IsAllType.Name = "IsAllType";
            this.IsAllType.Size = new System.Drawing.Size(81, 28);
            this.IsAllType.TabIndex = 8;
            this.IsAllType.Text = "كل الأنواع";
            this.IsAllType.UseVisualStyleBackColor = true;
            this.IsAllType.CheckedChanged += new System.EventHandler(this.IsAllType_CheckedChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(10, 134);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(112, 32);
            this.dtEnd.TabIndex = 7;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(10, 96);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(112, 32);
            this.dtStart.TabIndex = 6;
            // 
            // CmdFilterByDate
            // 
            this.CmdFilterByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterByDate.ForeColor = System.Drawing.Color.White;
            this.CmdFilterByDate.Location = new System.Drawing.Point(6, 172);
            this.CmdFilterByDate.Name = "CmdFilterByDate";
            this.CmdFilterByDate.Size = new System.Drawing.Size(184, 38);
            this.CmdFilterByDate.TabIndex = 5;
            this.CmdFilterByDate.Text = "تصفيه";
            this.CmdFilterByDate.UseVisualStyleBackColor = false;
            this.CmdFilterByDate.Click += new System.EventHandler(this.CmdFilterByDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "من يوم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "الي يوم:";
            // 
            // CmdShowAll
            // 
            this.CmdShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShowAll.ForeColor = System.Drawing.Color.White;
            this.CmdShowAll.Location = new System.Drawing.Point(0, 0);
            this.CmdShowAll.Name = "CmdShowAll";
            this.CmdShowAll.Size = new System.Drawing.Size(214, 38);
            this.CmdShowAll.TabIndex = 6;
            this.CmdShowAll.Text = "عرض الكل";
            this.CmdShowAll.UseVisualStyleBackColor = false;
            this.CmdShowAll.Click += new System.EventHandler(this.CmdShowAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdFilterByNumbers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصفيه برقم القيد";
            // 
            // CmdFilterByNumbers
            // 
            this.CmdFilterByNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterByNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterByNumbers.ForeColor = System.Drawing.Color.White;
            this.CmdFilterByNumbers.Location = new System.Drawing.Point(6, 156);
            this.CmdFilterByNumbers.Name = "CmdFilterByNumbers";
            this.CmdFilterByNumbers.Size = new System.Drawing.Size(184, 38);
            this.CmdFilterByNumbers.TabIndex = 5;
            this.CmdFilterByNumbers.Text = "تصفيه";
            this.CmdFilterByNumbers.UseVisualStyleBackColor = false;
            this.CmdFilterByNumbers.Click += new System.EventHandler(this.CmdFilterByNumbers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "من رقم:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(6, 105);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(102, 32);
            this.txtEnd.TabIndex = 3;
            this.txtEnd.Text = "1";
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNonDecimal);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(6, 67);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(102, 32);
            this.txtStart.TabIndex = 2;
            this.txtStart.Text = "1";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNonDecimal);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الي رقم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "إستعراض القيود بناء علي رقم القيد";
            // 
            // a_Lup_JETypesTableAdapter
            // 
            this.a_Lup_JETypesTableAdapter.ClearBeforeFill = true;
            // 
            // a_JournalBasicViewTableAdapter
            // 
            this.a_JournalBasicViewTableAdapter.ClearBeforeFill = true;
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "EID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "EID";
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // entryTypeIDDataGridViewTextBoxColumn
            // 
            this.entryTypeIDDataGridViewTextBoxColumn.DataPropertyName = "EntryTypeID";
            this.entryTypeIDDataGridViewTextBoxColumn.HeaderText = "EntryTypeID";
            this.entryTypeIDDataGridViewTextBoxColumn.Name = "entryTypeIDDataGridViewTextBoxColumn";
            this.entryTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FalseValue = "False";
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.TrueValue = "True";
            this.Column2.Width = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "تفاصيل";
            this.Column1.Name = "Column1";
            this.Column1.Text = ". . .";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 55;
            // 
            // jETypeNameArDataGridViewTextBoxColumn
            // 
            this.jETypeNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jETypeNameArDataGridViewTextBoxColumn.DataPropertyName = "JETypeNameAr";
            this.jETypeNameArDataGridViewTextBoxColumn.HeaderText = "نوع القيد";
            this.jETypeNameArDataGridViewTextBoxColumn.Name = "jETypeNameArDataGridViewTextBoxColumn";
            this.jETypeNameArDataGridViewTextBoxColumn.Width = 83;
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
            this.eDateDataGridViewTextBoxColumn.HeaderText = "تاريخ القيد";
            this.eDateDataGridViewTextBoxColumn.Name = "eDateDataGridViewTextBoxColumn";
            this.eDateDataGridViewTextBoxColumn.Width = 89;
            // 
            // totalDebitDataGridViewTextBoxColumn
            // 
            this.totalDebitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalDebitDataGridViewTextBoxColumn.DataPropertyName = "TotalDebit";
            this.totalDebitDataGridViewTextBoxColumn.HeaderText = "إجمالي المدين";
            this.totalDebitDataGridViewTextBoxColumn.Name = "totalDebitDataGridViewTextBoxColumn";
            this.totalDebitDataGridViewTextBoxColumn.Width = 112;
            // 
            // totalCreditDataGridViewTextBoxColumn
            // 
            this.totalCreditDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalCreditDataGridViewTextBoxColumn.DataPropertyName = "TotalCredit";
            this.totalCreditDataGridViewTextBoxColumn.HeaderText = "إجمالي الدائن";
            this.totalCreditDataGridViewTextBoxColumn.Name = "totalCreditDataGridViewTextBoxColumn";
            this.totalCreditDataGridViewTextBoxColumn.Width = 106;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "بيان";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 55;
            // 
            // EntryBalanceStatus
            // 
            this.EntryBalanceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EntryBalanceStatus.DataPropertyName = "EntryBalanceStatus";
            this.EntryBalanceStatus.HeaderText = "حالة القيد";
            this.EntryBalanceStatus.Name = "EntryBalanceStatus";
            this.EntryBalanceStatus.ReadOnly = true;
            this.EntryBalanceStatus.Width = 87;
            // 
            // entryApproveStatusDataGridViewTextBoxColumn
            // 
            this.entryApproveStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entryApproveStatusDataGridViewTextBoxColumn.DataPropertyName = "EntryApproveStatus";
            this.entryApproveStatusDataGridViewTextBoxColumn.HeaderText = "حالة الاعتماد";
            this.entryApproveStatusDataGridViewTextBoxColumn.Name = "entryApproveStatusDataGridViewTextBoxColumn";
            this.entryApproveStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryApproveStatusDataGridViewTextBoxColumn.Width = 101;
            // 
            // entryDelStatusDataGridViewTextBoxColumn
            // 
            this.entryDelStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entryDelStatusDataGridViewTextBoxColumn.DataPropertyName = "EntryDelStatus";
            this.entryDelStatusDataGridViewTextBoxColumn.HeaderText = "حالة الالغاء";
            this.entryDelStatusDataGridViewTextBoxColumn.Name = "entryDelStatusDataGridViewTextBoxColumn";
            this.entryDelStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryDelStatusDataGridViewTextBoxColumn.Width = 93;
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "منشئ القيد";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 101;
            // 
            // RCDate
            // 
            this.RCDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RCDate.DataPropertyName = "RCDate";
            this.RCDate.HeaderText = "تاريخ الانشاء";
            this.RCDate.Name = "RCDate";
            this.RCDate.Width = 98;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ModifiedBy.DataPropertyName = "ModifiedBy";
            this.ModifiedBy.HeaderText = "تعديل بواسطه";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Width = 113;
            // 
            // LADate
            // 
            this.LADate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LADate.DataPropertyName = "LADate";
            this.LADate.HeaderText = "تاريخ التعديل";
            this.LADate.Name = "LADate";
            this.LADate.Width = 102;
            // 
            // frmJournalEntryList
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
            this.Name = "frmJournalEntryList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعراض قيود اليوميه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJournalEntryList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aJournalBasicViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLupJETypesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtEntryTypeID;
        private System.Windows.Forms.CheckBox IsAllType;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button CmdFilterByDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdFilterByNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aLupJETypesBindingSource;
        private AppDataSets.AccountingTableAdapters.A_Lup_JETypesTableAdapter a_Lup_JETypesTableAdapter;
        private System.Windows.Forms.ToolStripButton CmdApprove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmdDisApprove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CmdDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CmdExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CmdPrint;
        private System.Windows.Forms.DataGridView grvEntryList;
        private System.Windows.Forms.BindingSource aJournalBasicViewBindingSource;
        private AppDataSets.AccountingTableAdapters.A_JournalBasicViewTableAdapter a_JournalBasicViewTableAdapter;
        private System.Windows.Forms.ToolStripButton CmdRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblOverAllCredit;
        private System.Windows.Forms.Label lblOverAllDepit;
        private System.Windows.Forms.ToolStripDropDownButton DDBulkActionOption;
        private System.Windows.Forms.ToolStripMenuItem CmdApproveMulti;
        private System.Windows.Forms.ToolStripMenuItem CmdDeApproveMulti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem CmdCancelMulti;
        private System.Windows.Forms.ToolStripMenuItem CmdRestoreMulti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripDropDownButton DDQuickFilters;
        private System.Windows.Forms.ToolStripMenuItem CmdGetAllUnApproved;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem CmdGetAllUnBalanced;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem CmdGetAllDeleted;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jETypeNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryBalanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryApproveStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDelStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RCDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LADate;
    }
}