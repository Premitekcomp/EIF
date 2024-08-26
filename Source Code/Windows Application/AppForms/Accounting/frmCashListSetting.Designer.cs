namespace TMS.AppForms.Accounting
{
    partial class frmCashListSetting
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("صافي الايرادات");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("تكلفة الايرادات");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("مجمل الربح");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("الايرادات الاخري");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("المصروفات");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("الاهلاكات");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("صافي الربح");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("الضرائب");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("صافي الربح اوالخساره");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("عناصر قائمة الدخل", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvEquationList = new System.Windows.Forms.DataGridView();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.aAccountsNumberListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_AccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter();
            this.a_AccountsNumberListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsNumberListTableAdapter();
            this.aConfigCashViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_Config_CashViewTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_Config_CashViewTableAdapter();
            this.nodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termSignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEquationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsNumberListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aConfigCashViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(673, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 639);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "1";
            treeNode11.Text = "صافي الايرادات";
            treeNode12.Name = "2";
            treeNode12.Text = "تكلفة الايرادات";
            treeNode13.ForeColor = System.Drawing.Color.Blue;
            treeNode13.Name = "3";
            treeNode13.Text = "مجمل الربح";
            treeNode14.Name = "4";
            treeNode14.Text = "الايرادات الاخري";
            treeNode15.Name = "5";
            treeNode15.Text = "المصروفات";
            treeNode16.Name = "6";
            treeNode16.Text = "الاهلاكات";
            treeNode17.ForeColor = System.Drawing.Color.Blue;
            treeNode17.Name = "7";
            treeNode17.Text = "صافي الربح";
            treeNode18.Name = "8";
            treeNode18.Text = "الضرائب";
            treeNode19.ForeColor = System.Drawing.Color.Blue;
            treeNode19.Name = "9";
            treeNode19.Text = "صافي الربح اوالخساره";
            treeNode20.ForeColor = System.Drawing.Color.Green;
            treeNode20.Name = "Node0";
            treeNode20.Text = "عناصر قائمة الدخل";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView1.PathSeparator = "/";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(251, 639);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvEquationList);
            this.panel2.Controls.Add(this.CmdAdd);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 639);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // grvEquationList
            // 
            this.grvEquationList.AllowUserToAddRows = false;
            this.grvEquationList.AllowUserToDeleteRows = false;
            this.grvEquationList.AutoGenerateColumns = false;
            this.grvEquationList.BackgroundColor = System.Drawing.Color.White;
            this.grvEquationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEquationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeIDDataGridViewTextBoxColumn,
            this.nodeTitleDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.termSignDataGridViewTextBoxColumn,
            this.Column1});
            this.grvEquationList.DataSource = this.aConfigCashViewBindingSource;
            this.grvEquationList.Location = new System.Drawing.Point(12, 158);
            this.grvEquationList.Name = "grvEquationList";
            this.grvEquationList.RowTemplate.Height = 25;
            this.grvEquationList.Size = new System.Drawing.Size(638, 469);
            this.grvEquationList.TabIndex = 8;
            // 
            // CmdAdd
            // 
            this.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAdd.Location = new System.Drawing.Point(12, 120);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(100, 32);
            this.CmdAdd.TabIndex = 7;
            this.CmdAdd.Text = "اضافه للمعادله";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "موجب",
            "سالب"});
            this.comboBox3.Location = new System.Drawing.Point(134, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(166, 32);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataSource = this.aAccountsNumberListBindingSource;
            this.comboBox2.DisplayMember = "AccountNumber";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(535, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 32);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "AccountID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // aAccountsNumberListBindingSource
            // 
            this.aAccountsNumberListBindingSource.DataMember = "A_AccountsNumberList";
            this.aAccountsNumberListBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.aAccountsListBindingSource;
            this.comboBox1.DisplayMember = "AccountName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "AccountID";
            // 
            // aAccountsListBindingSource
            // 
            this.aAccountsListBindingSource.DataMember = "A_AccountsList";
            this.aAccountsListBindingSource.DataSource = this.accounting;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "تأثيره في المعادله";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "الحســــاب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(282, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنصر قائمة الدخل الفعال:";
            // 
            // a_AccountsListTableAdapter
            // 
            this.a_AccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_AccountsNumberListTableAdapter
            // 
            this.a_AccountsNumberListTableAdapter.ClearBeforeFill = true;
            // 
            // aConfigCashViewBindingSource
            // 
            this.aConfigCashViewBindingSource.DataMember = "A_Config_CashView";
            this.aConfigCashViewBindingSource.DataSource = this.accounting;
            // 
            // a_Config_CashViewTableAdapter
            // 
            this.a_Config_CashViewTableAdapter.ClearBeforeFill = true;
            // 
            // nodeIDDataGridViewTextBoxColumn
            // 
            this.nodeIDDataGridViewTextBoxColumn.DataPropertyName = "NodeID";
            this.nodeIDDataGridViewTextBoxColumn.HeaderText = "NodeID";
            this.nodeIDDataGridViewTextBoxColumn.Name = "nodeIDDataGridViewTextBoxColumn";
            this.nodeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nodeTitleDataGridViewTextBoxColumn
            // 
            this.nodeTitleDataGridViewTextBoxColumn.DataPropertyName = "NodeTitle";
            this.nodeTitleDataGridViewTextBoxColumn.HeaderText = "NodeTitle";
            this.nodeTitleDataGridViewTextBoxColumn.Name = "nodeTitleDataGridViewTextBoxColumn";
            this.nodeTitleDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "أسم الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termSignDataGridViewTextBoxColumn
            // 
            this.termSignDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.termSignDataGridViewTextBoxColumn.DataPropertyName = "TermSign";
            this.termSignDataGridViewTextBoxColumn.HeaderText = "تأثيره";
            this.termSignDataGridViewTextBoxColumn.Name = "termSignDataGridViewTextBoxColumn";
            this.termSignDataGridViewTextBoxColumn.ReadOnly = true;
            this.termSignDataGridViewTextBoxColumn.Width = 63;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "حذف";
            this.Column1.Name = "Column1";
            this.Column1.Text = "x";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 42;
            // 
            // frmCashListSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmCashListSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادت قائمة الدخل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCashListSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEquationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsNumberListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aConfigCashViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter a_AccountsListTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource aAccountsNumberListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsNumberListTableAdapter a_AccountsNumberListTableAdapter;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.DataGridView grvEquationList;
        private System.Windows.Forms.BindingSource aConfigCashViewBindingSource;
        private AppDataSets.AccountingTableAdapters.A_Config_CashViewTableAdapter a_Config_CashViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termSignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}