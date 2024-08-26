namespace TMS.AppForms.Accounting
{
    partial class frmLookUpAccount
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
            this.txtByAccountName = new System.Windows.Forms.TextBox();
            this.grvAccountList = new System.Windows.Forms.DataGridView();
            this.accounting = new TMS.AppDataSets.Accounting();
            this.aLookupAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_LookupAccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_LookupAccountsListTableAdapter();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdCanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvAccountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLookupAccountsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtByAccountName
            // 
            this.txtByAccountName.Location = new System.Drawing.Point(21, 12);
            this.txtByAccountName.Name = "txtByAccountName";
            this.txtByAccountName.Size = new System.Drawing.Size(852, 37);
            this.txtByAccountName.TabIndex = 1;
            this.txtByAccountName.TextChanged += new System.EventHandler(this.txtByAccountName_TextChanged);
            this.txtByAccountName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtByAccountName_KeyDown);
            // 
            // grvAccountList
            // 
            this.grvAccountList.AllowUserToAddRows = false;
            this.grvAccountList.AllowUserToDeleteRows = false;
            this.grvAccountList.AutoGenerateColumns = false;
            this.grvAccountList.BackgroundColor = System.Drawing.Color.White;
            this.grvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIDDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn});
            this.grvAccountList.DataSource = this.aLookupAccountsListBindingSource;
            this.grvAccountList.Location = new System.Drawing.Point(21, 55);
            this.grvAccountList.Name = "grvAccountList";
            this.grvAccountList.ReadOnly = true;
            this.grvAccountList.RowTemplate.Height = 28;
            this.grvAccountList.Size = new System.Drawing.Size(852, 390);
            this.grvAccountList.TabIndex = 4;
            this.grvAccountList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvAccountList_CellContentClick);
            this.grvAccountList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvAccountList_KeyDown);
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLookupAccountsListBindingSource
            // 
            this.aLookupAccountsListBindingSource.DataMember = "A_LookupAccountsList";
            this.aLookupAccountsListBindingSource.DataSource = this.accounting;
            // 
            // a_LookupAccountsListTableAdapter
            // 
            this.a_LookupAccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "رقم الحساب";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNumberDataGridViewTextBoxColumn.Width = 121;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CmdCanel
            // 
            this.CmdCanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCanel.Location = new System.Drawing.Point(60, 403);
            this.CmdCanel.Name = "CmdCanel";
            this.CmdCanel.Size = new System.Drawing.Size(743, 42);
            this.CmdCanel.TabIndex = 5;
            this.CmdCanel.Text = "الغاء";
            this.CmdCanel.UseVisualStyleBackColor = false;
            this.CmdCanel.Visible = false;
            this.CmdCanel.Click += new System.EventHandler(this.CmdCanel_Click);
            // 
            // frmLookUpAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCanel;
            this.ClientSize = new System.Drawing.Size(900, 457);
            this.Controls.Add(this.CmdCanel);
            this.Controls.Add(this.grvAccountList);
            this.Controls.Add(this.txtByAccountName);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLookUpAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن حساب";
            this.Load += new System.EventHandler(this.frmLookUpAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAccountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLookupAccountsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtByAccountName;
        private System.Windows.Forms.DataGridView grvAccountList;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aLookupAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_LookupAccountsListTableAdapter a_LookupAccountsListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdCanel;
    }
}