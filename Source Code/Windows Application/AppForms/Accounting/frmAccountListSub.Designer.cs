namespace TMS.AppForms.Accounting
{
    partial class frmAccountListSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountListSub));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdReLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdAddSub = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdAddTopLevelAccount = new System.Windows.Forms.ToolStripButton();
            this.PanelTree = new System.Windows.Forms.Panel();
            this.SubAccountsListTreeView = new System.Windows.Forms.TreeView();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.CmdDoAction = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grvLinkedAccounts = new System.Windows.Forms.DataGridView();
            this.joinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aSubAccountsJoinDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AccountListTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.ComboBox();
            this.aSubAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_SubAccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter();
            this.a_SubAccountsJoinDetailsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_SubAccountsJoinDetailsTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCridtLocalCurrency = new System.Windows.Forms.TextBox();
            this.txtDebitLocalCurrency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.PanelTree.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLinkedAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsJoinDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdReLoad,
            this.toolStripSeparator1,
            this.CmdAddSub,
            this.toolStripSeparator2,
            this.CmdAddTopLevelAccount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CmdReLoad
            // 
            this.CmdReLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdReLoad.Image = ((System.Drawing.Image)(resources.GetObject("CmdReLoad.Image")));
            this.CmdReLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdReLoad.Name = "CmdReLoad";
            this.CmdReLoad.Size = new System.Drawing.Size(43, 22);
            this.CmdReLoad.Text = "تحديث";
            this.CmdReLoad.Click += new System.EventHandler(this.CmdReLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdAddSub
            // 
            this.CmdAddSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdAddSub.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddSub.Image")));
            this.CmdAddSub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddSub.Name = "CmdAddSub";
            this.CmdAddSub.Size = new System.Drawing.Size(105, 22);
            this.CmdAddSub.Text = "اضافه حساب فرعي";
            this.CmdAddSub.Click += new System.EventHandler(this.CmdAddSub_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdAddTopLevelAccount
            // 
            this.CmdAddTopLevelAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdAddTopLevelAccount.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddTopLevelAccount.Image")));
            this.CmdAddTopLevelAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddTopLevelAccount.Name = "CmdAddTopLevelAccount";
            this.CmdAddTopLevelAccount.Size = new System.Drawing.Size(107, 22);
            this.CmdAddTopLevelAccount.Text = "اضافه حساب رئيسي";
            this.CmdAddTopLevelAccount.Click += new System.EventHandler(this.CmdAddTopLevelAccount_Click);
            // 
            // PanelTree
            // 
            this.PanelTree.Controls.Add(this.SubAccountsListTreeView);
            this.PanelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTree.Location = new System.Drawing.Point(0, 25);
            this.PanelTree.Name = "PanelTree";
            this.PanelTree.Size = new System.Drawing.Size(416, 528);
            this.PanelTree.TabIndex = 1;
            // 
            // SubAccountsListTreeView
            // 
            this.SubAccountsListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubAccountsListTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubAccountsListTreeView.FullRowSelect = true;
            this.SubAccountsListTreeView.ItemHeight = 28;
            this.SubAccountsListTreeView.Location = new System.Drawing.Point(0, 0);
            this.SubAccountsListTreeView.Name = "SubAccountsListTreeView";
            this.SubAccountsListTreeView.PathSeparator = " / ";
            this.SubAccountsListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SubAccountsListTreeView.Size = new System.Drawing.Size(416, 528);
            this.SubAccountsListTreeView.TabIndex = 2;
            this.SubAccountsListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SubAccountsListTreeView_MouseDoubleClick);
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.CmdDoAction);
            this.PanelForm.Controls.Add(this.tabControl1);
            this.PanelForm.Controls.Add(this.panel1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelForm.Location = new System.Drawing.Point(533, 25);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(429, 528);
            this.PanelForm.TabIndex = 0;
            // 
            // CmdDoAction
            // 
            this.CmdDoAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdDoAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CmdDoAction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdDoAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDoAction.ForeColor = System.Drawing.Color.White;
            this.CmdDoAction.Location = new System.Drawing.Point(0, 487);
            this.CmdDoAction.Name = "CmdDoAction";
            this.CmdDoAction.Size = new System.Drawing.Size(429, 41);
            this.CmdDoAction.TabIndex = 10;
            this.CmdDoAction.Text = "حفظ";
            this.CmdDoAction.UseVisualStyleBackColor = false;
            this.CmdDoAction.Click += new System.EventHandler(this.CmdDoAction_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 351);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvLinkedAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الحسابات المرتبطه";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grvLinkedAccounts
            // 
            this.grvLinkedAccounts.AllowUserToAddRows = false;
            this.grvLinkedAccounts.AllowUserToDeleteRows = false;
            this.grvLinkedAccounts.AutoGenerateColumns = false;
            this.grvLinkedAccounts.BackgroundColor = System.Drawing.Color.White;
            this.grvLinkedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLinkedAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.joinIDDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.Column1});
            this.grvLinkedAccounts.DataSource = this.aSubAccountsJoinDetailsBindingSource;
            this.grvLinkedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvLinkedAccounts.Location = new System.Drawing.Point(3, 3);
            this.grvLinkedAccounts.Name = "grvLinkedAccounts";
            this.grvLinkedAccounts.ReadOnly = true;
            this.grvLinkedAccounts.RowTemplate.Height = 25;
            this.grvLinkedAccounts.Size = new System.Drawing.Size(415, 308);
            this.grvLinkedAccounts.TabIndex = 0;
            this.grvLinkedAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLinkedAccounts_CellContentClick);
            // 
            // joinIDDataGridViewTextBoxColumn
            // 
            this.joinIDDataGridViewTextBoxColumn.DataPropertyName = "JoinID";
            this.joinIDDataGridViewTextBoxColumn.HeaderText = "JoinID";
            this.joinIDDataGridViewTextBoxColumn.Name = "joinIDDataGridViewTextBoxColumn";
            this.joinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.joinIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "كسر الربط";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "X";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 69;
            // 
            // aSubAccountsJoinDetailsBindingSource
            // 
            this.aSubAccountsJoinDetailsBindingSource.DataMember = "A_SubAccountsJoinDetails";
            this.aSubAccountsJoinDetailsBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AccountListTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اختيار";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AccountListTreeView
            // 
            this.AccountListTreeView.CheckBoxes = true;
            this.AccountListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountListTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountListTreeView.FullRowSelect = true;
            this.AccountListTreeView.ItemHeight = 28;
            this.AccountListTreeView.Location = new System.Drawing.Point(3, 3);
            this.AccountListTreeView.Name = "AccountListTreeView";
            this.AccountListTreeView.PathSeparator = " / ";
            this.AccountListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountListTreeView.RightToLeftLayout = true;
            this.AccountListTreeView.Size = new System.Drawing.Size(415, 349);
            this.AccountListTreeView.TabIndex = 1;
            this.AccountListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountListTreeView_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCridtLocalCurrency);
            this.panel1.Controls.Add(this.txtDebitLocalCurrency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAccountPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Controls.Add(this.txtAccountTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 177);
            this.panel1.TabIndex = 9;
            // 
            // lblAccountPath
            // 
            this.lblAccountPath.AutoSize = true;
            this.lblAccountPath.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountPath.Location = new System.Drawing.Point(9, 15);
            this.lblAccountPath.Name = "lblAccountPath";
            this.lblAccountPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountPath.Size = new System.Drawing.Size(27, 24);
            this.lblAccountPath.TabIndex = 7;
            this.lblAccountPath.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "شجرة الحساب:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Green;
            this.lblAccountNumber.Location = new System.Drawing.Point(204, 44);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(27, 24);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "NA";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountTitle.DataSource = this.aSubAccountsListBindingSource;
            this.txtAccountTitle.DisplayMember = "AccountName";
            this.txtAccountTitle.FormattingEnabled = true;
            this.txtAccountTitle.Location = new System.Drawing.Point(9, 76);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(290, 32);
            this.txtAccountTitle.TabIndex = 3;
            this.txtAccountTitle.ValueMember = "AccountID";
            // 
            // aSubAccountsListBindingSource
            // 
            this.aSubAccountsListBindingSource.DataMember = "A_SubAccountsList";
            this.aSubAccountsListBindingSource.DataSource = this.accounting;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "مسمي الحساب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم / كود الحساب:";
            // 
            // a_SubAccountsListTableAdapter
            // 
            this.a_SubAccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_SubAccountsJoinDetailsTableAdapter
            // 
            this.a_SubAccountsJoinDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(59, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "دائن";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(182, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "مدين";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCridtLocalCurrency
            // 
            this.txtCridtLocalCurrency.Location = new System.Drawing.Point(59, 140);
            this.txtCridtLocalCurrency.Name = "txtCridtLocalCurrency";
            this.txtCridtLocalCurrency.Size = new System.Drawing.Size(117, 32);
            this.txtCridtLocalCurrency.TabIndex = 34;
            this.txtCridtLocalCurrency.Text = "0";
            this.txtCridtLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDebitLocalCurrency
            // 
            this.txtDebitLocalCurrency.Location = new System.Drawing.Point(182, 139);
            this.txtDebitLocalCurrency.Name = "txtDebitLocalCurrency";
            this.txtDebitLocalCurrency.Size = new System.Drawing.Size(117, 32);
            this.txtDebitLocalCurrency.TabIndex = 33;
            this.txtDebitLocalCurrency.Text = "0";
            this.txtDebitLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "الرصيد الافتتاحي:";
            // 
            // frmAccountListSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 553);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelTree);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmAccountListSub";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات التحليليه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelTree.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvLinkedAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsJoinDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSubAccountsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PanelTree;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.ComboBox txtAccountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton CmdReLoad;
        private System.Windows.Forms.Label lblAccountPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmdAddSub;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView AccountListTreeView;
        private System.Windows.Forms.TreeView SubAccountsListTreeView;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aSubAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_SubAccountsListTableAdapter a_SubAccountsListTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdDoAction;
        private System.Windows.Forms.DataGridView grvLinkedAccounts;
        private System.Windows.Forms.BindingSource aSubAccountsJoinDetailsBindingSource;
        private AppDataSets.AccountingTableAdapters.A_SubAccountsJoinDetailsTableAdapter a_SubAccountsJoinDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CmdAddTopLevelAccount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCridtLocalCurrency;
        private System.Windows.Forms.TextBox txtDebitLocalCurrency;
        private System.Windows.Forms.Label label4;
    }
}