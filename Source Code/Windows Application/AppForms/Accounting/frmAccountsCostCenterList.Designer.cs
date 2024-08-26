namespace TMS.AppForms.Accounting
{
    partial class frmAccountsCostCenterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsCostCenterList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdReLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdAddSub = new System.Windows.Forms.ToolStripButton();
            this.PanelTree = new System.Windows.Forms.Panel();
            this.CostCentersListTreeView = new System.Windows.Forms.TreeView();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.CmdDoAction = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grvLinkedAccounts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AccountListTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtCCenterTitle = new System.Windows.Forms.ComboBox();
            this.aAccountsCostCenterListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_AccountsCostCenterListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsCostCenterListTableAdapter();
            this.aCCentersJoinDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_CCentersJoinDetailsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_CCentersJoinDetailsTableAdapter();
            this.cCJoinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weighetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            this.PanelTree.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLinkedAccounts)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsCostCenterListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCentersJoinDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdReLoad,
            this.toolStripSeparator1,
            this.CmdAddSub});
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
            // PanelTree
            // 
            this.PanelTree.Controls.Add(this.CostCentersListTreeView);
            this.PanelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTree.Location = new System.Drawing.Point(0, 25);
            this.PanelTree.Name = "PanelTree";
            this.PanelTree.Size = new System.Drawing.Size(416, 528);
            this.PanelTree.TabIndex = 1;
            // 
            // CostCentersListTreeView
            // 
            this.CostCentersListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CostCentersListTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostCentersListTreeView.FullRowSelect = true;
            this.CostCentersListTreeView.ItemHeight = 28;
            this.CostCentersListTreeView.Location = new System.Drawing.Point(0, 0);
            this.CostCentersListTreeView.Name = "CostCentersListTreeView";
            this.CostCentersListTreeView.PathSeparator = " / ";
            this.CostCentersListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostCentersListTreeView.Size = new System.Drawing.Size(416, 528);
            this.CostCentersListTreeView.TabIndex = 2;
            this.CostCentersListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SubAccountsListTreeView_MouseDoubleClick);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 392);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvLinkedAccounts);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 355);
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
            this.cCJoinIDDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.weighetDataGridViewTextBoxColumn,
            this.Column2,
            this.Column1});
            this.grvLinkedAccounts.DataSource = this.aCCentersJoinDetailsBindingSource;
            this.grvLinkedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvLinkedAccounts.Location = new System.Drawing.Point(3, 3);
            this.grvLinkedAccounts.Name = "grvLinkedAccounts";
            this.grvLinkedAccounts.RowTemplate.Height = 25;
            this.grvLinkedAccounts.Size = new System.Drawing.Size(415, 349);
            this.grvLinkedAccounts.TabIndex = 0;
            this.grvLinkedAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLinkedAccounts_CellContentClick);
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
            this.panel1.Controls.Add(this.lblAccountPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAccountNumber);
            this.panel1.Controls.Add(this.txtCCenterTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 136);
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
            // txtCCenterTitle
            // 
            this.txtCCenterTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCCenterTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCCenterTitle.DataSource = this.aAccountsCostCenterListBindingSource;
            this.txtCCenterTitle.DisplayMember = "CostCenterName";
            this.txtCCenterTitle.FormattingEnabled = true;
            this.txtCCenterTitle.Location = new System.Drawing.Point(9, 76);
            this.txtCCenterTitle.Name = "txtCCenterTitle";
            this.txtCCenterTitle.Size = new System.Drawing.Size(290, 32);
            this.txtCCenterTitle.TabIndex = 3;
            this.txtCCenterTitle.ValueMember = "CostCenterAccountID";
            // 
            // aAccountsCostCenterListBindingSource
            // 
            this.aAccountsCostCenterListBindingSource.DataMember = "A_AccountsCostCenterList";
            this.aAccountsCostCenterListBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم مركز التكلفه:";
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
            // a_AccountsCostCenterListTableAdapter
            // 
            this.a_AccountsCostCenterListTableAdapter.ClearBeforeFill = true;
            // 
            // aCCentersJoinDetailsBindingSource
            // 
            this.aCCentersJoinDetailsBindingSource.DataMember = "A_CCentersJoinDetails";
            this.aCCentersJoinDetailsBindingSource.DataSource = this.accounting;
            // 
            // a_CCentersJoinDetailsTableAdapter
            // 
            this.a_CCentersJoinDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // cCJoinIDDataGridViewTextBoxColumn
            // 
            this.cCJoinIDDataGridViewTextBoxColumn.DataPropertyName = "CCJoinID";
            this.cCJoinIDDataGridViewTextBoxColumn.HeaderText = "CCJoinID";
            this.cCJoinIDDataGridViewTextBoxColumn.Name = "cCJoinIDDataGridViewTextBoxColumn";
            this.cCJoinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCJoinIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weighetDataGridViewTextBoxColumn
            // 
            this.weighetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weighetDataGridViewTextBoxColumn.DataPropertyName = "Weighet";
            this.weighetDataGridViewTextBoxColumn.HeaderText = "نسبة التحميل";
            this.weighetDataGridViewTextBoxColumn.Name = "weighetDataGridViewTextBoxColumn";
            this.weighetDataGridViewTextBoxColumn.Width = 109;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "تعديل";
            this.Column2.Name = "Column2";
            this.Column2.Text = "حفظ";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 48;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "كسر الربط";
            this.Column1.Name = "Column1";
            this.Column1.Text = "X";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 69;
            // 
            // frmAccountsCostCenterList
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
            this.Name = "frmAccountsCostCenterList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مراكز التكلفة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelTree.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvLinkedAccounts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsCostCenterListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCentersJoinDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PanelTree;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.ComboBox txtCCenterTitle;
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
        private System.Windows.Forms.TreeView CostCentersListTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdDoAction;
        private System.Windows.Forms.DataGridView grvLinkedAccounts;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsCostCenterListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsCostCenterListTableAdapter a_AccountsCostCenterListTableAdapter;
        private System.Windows.Forms.BindingSource aCCentersJoinDetailsBindingSource;
        private AppDataSets.AccountingTableAdapters.A_CCentersJoinDetailsTableAdapter a_CCentersJoinDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCJoinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weighetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}