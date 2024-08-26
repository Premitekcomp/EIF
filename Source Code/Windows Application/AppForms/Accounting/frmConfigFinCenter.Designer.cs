namespace TMS.AppForms.Accounting
{
    partial class frmConfigFinCenter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvList = new System.Windows.Forms.DataGridView();
            this.aConfigFinancialCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.txtAccountID = new System.Windows.Forms.ComboBox();
            this.aAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAccountType = new System.Windows.Forms.ComboBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.a_AccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter();
            this.a_Config_FinancialCenterTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_Config_FinancialCenterTableAdapter();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topLevelAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aConfigFinancialCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "الحساب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "طرف قائمة الدخل:";
            // 
            // grvList
            // 
            this.grvList.AllowUserToAddRows = false;
            this.grvList.AllowUserToDeleteRows = false;
            this.grvList.AutoGenerateColumns = false;
            this.grvList.BackgroundColor = System.Drawing.Color.White;
            this.grvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.itemGroupDataGridViewTextBoxColumn,
            this.topLevelAccountIDDataGridViewTextBoxColumn,
            this.Column1});
            this.grvList.DataSource = this.aConfigFinancialCenterBindingSource;
            this.grvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grvList.Location = new System.Drawing.Point(0, 0);
            this.grvList.Name = "grvList";
            this.grvList.ReadOnly = true;
            this.grvList.RowTemplate.Height = 28;
            this.grvList.Size = new System.Drawing.Size(579, 529);
            this.grvList.TabIndex = 3;
            this.grvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvList_CellContentClick);
            // 
            // aConfigFinancialCenterBindingSource
            // 
            this.aConfigFinancialCenterBindingSource.DataMember = "A_Config_FinancialCenter";
            this.aConfigFinancialCenterBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAccountID
            // 
            this.txtAccountID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountID.DataSource = this.aAccountsListBindingSource;
            this.txtAccountID.DisplayMember = "AccountName";
            this.txtAccountID.FormattingEnabled = true;
            this.txtAccountID.Location = new System.Drawing.Point(608, 35);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(218, 38);
            this.txtAccountID.TabIndex = 4;
            this.txtAccountID.ValueMember = "AccountID";
            // 
            // aAccountsListBindingSource
            // 
            this.aAccountsListBindingSource.DataMember = "A_AccountsList";
            this.aAccountsListBindingSource.DataSource = this.accounting;
            // 
            // txtAccountType
            // 
            this.txtAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountType.FormattingEnabled = true;
            this.txtAccountType.Items.AddRange(new object[] {
            "اجمالي الاستثمار",
            "اجمالي مصادر التمويل"});
            this.txtAccountType.Location = new System.Drawing.Point(608, 79);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(218, 38);
            this.txtAccountType.TabIndex = 5;
            // 
            // CmdSave
            // 
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(725, 143);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(101, 49);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "إضافه";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // a_AccountsListTableAdapter
            // 
            this.a_AccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // a_Config_FinancialCenterTableAdapter
            // 
            this.a_Config_FinancialCenterTableAdapter.ClearBeforeFill = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemGroupDataGridViewTextBoxColumn
            // 
            this.itemGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemGroupDataGridViewTextBoxColumn.DataPropertyName = "ItemGroup";
            this.itemGroupDataGridViewTextBoxColumn.HeaderText = "";
            this.itemGroupDataGridViewTextBoxColumn.Name = "itemGroupDataGridViewTextBoxColumn";
            this.itemGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemGroupDataGridViewTextBoxColumn.Width = 19;
            // 
            // topLevelAccountIDDataGridViewTextBoxColumn
            // 
            this.topLevelAccountIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.topLevelAccountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.topLevelAccountIDDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.topLevelAccountIDDataGridViewTextBoxColumn.Name = "topLevelAccountIDDataGridViewTextBoxColumn";
            this.topLevelAccountIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "حذف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "حذف";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 52;
            // 
            // frmConfigFinCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 529);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.grvList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmConfigFinCenter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعداد قائمة المركز المالي";
            this.Load += new System.EventHandler(this.frmConfigFinCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aConfigFinancialCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvList;
        private System.Windows.Forms.ComboBox txtAccountID;
        private System.Windows.Forms.ComboBox txtAccountType;
        private System.Windows.Forms.Button CmdSave;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter a_AccountsListTableAdapter;
        private System.Windows.Forms.BindingSource aConfigFinancialCenterBindingSource;
        private AppDataSets.AccountingTableAdapters.A_Config_FinancialCenterTableAdapter a_Config_FinancialCenterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topLevelAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}