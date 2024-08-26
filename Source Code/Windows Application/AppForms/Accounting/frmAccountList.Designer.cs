namespace TMS.AppForms.Accounting
{
    partial class frmAccountList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdReLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdAddSub = new System.Windows.Forms.ToolStripButton();
            this.PanelTree = new System.Windows.Forms.Panel();
            this.AccountListTreeView = new System.Windows.Forms.TreeView();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCridtLocalCurrency = new System.Windows.Forms.TextBox();
            this.txtDebitLocalCurrency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdDoAction = new System.Windows.Forms.Button();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.ComboBox();
            this.aAccountsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a_AccountsListTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdDelAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.PanelTree.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdReLoad,
            this.toolStripSeparator1,
            this.CmdAddSub,
            this.toolStripSeparator2,
            this.CmdDelAccount});
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
            this.PanelTree.Controls.Add(this.AccountListTreeView);
            this.PanelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTree.Location = new System.Drawing.Point(0, 25);
            this.PanelTree.Name = "PanelTree";
            this.PanelTree.Size = new System.Drawing.Size(526, 528);
            this.PanelTree.TabIndex = 1;
            // 
            // AccountListTreeView
            // 
            this.AccountListTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountListTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountListTreeView.FullRowSelect = true;
            this.AccountListTreeView.ItemHeight = 28;
            this.AccountListTreeView.Location = new System.Drawing.Point(0, 0);
            this.AccountListTreeView.Name = "AccountListTreeView";
            this.AccountListTreeView.PathSeparator = " / ";
            this.AccountListTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountListTreeView.Size = new System.Drawing.Size(526, 528);
            this.AccountListTreeView.TabIndex = 0;
            this.AccountListTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountListTreeView_MouseDoubleClick);
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.label12);
            this.PanelForm.Controls.Add(this.label13);
            this.PanelForm.Controls.Add(this.txtCridtLocalCurrency);
            this.PanelForm.Controls.Add(this.txtDebitLocalCurrency);
            this.PanelForm.Controls.Add(this.label4);
            this.PanelForm.Controls.Add(this.lblAccountPath);
            this.PanelForm.Controls.Add(this.label3);
            this.PanelForm.Controls.Add(this.CmdDoAction);
            this.PanelForm.Controls.Add(this.lblAccountNumber);
            this.PanelForm.Controls.Add(this.txtAccountTitle);
            this.PanelForm.Controls.Add(this.label2);
            this.PanelForm.Controls.Add(this.label1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelForm.Location = new System.Drawing.Point(532, 25);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(430, 528);
            this.PanelForm.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(63, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "دائن";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(186, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "مدين";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCridtLocalCurrency
            // 
            this.txtCridtLocalCurrency.Location = new System.Drawing.Point(63, 174);
            this.txtCridtLocalCurrency.Name = "txtCridtLocalCurrency";
            this.txtCridtLocalCurrency.Size = new System.Drawing.Size(117, 32);
            this.txtCridtLocalCurrency.TabIndex = 29;
            this.txtCridtLocalCurrency.Text = "0";
            this.txtCridtLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCridtLocalCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtDebitLocalCurrency
            // 
            this.txtDebitLocalCurrency.Location = new System.Drawing.Point(186, 173);
            this.txtDebitLocalCurrency.Name = "txtDebitLocalCurrency";
            this.txtDebitLocalCurrency.Size = new System.Drawing.Size(117, 32);
            this.txtDebitLocalCurrency.TabIndex = 28;
            this.txtDebitLocalCurrency.Text = "0";
            this.txtDebitLocalCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDebitLocalCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "الرصيد الافتتاحي:";
            // 
            // lblAccountPath
            // 
            this.lblAccountPath.AutoSize = true;
            this.lblAccountPath.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountPath.Location = new System.Drawing.Point(13, 40);
            this.lblAccountPath.Name = "lblAccountPath";
            this.lblAccountPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountPath.Size = new System.Drawing.Size(27, 24);
            this.lblAccountPath.TabIndex = 7;
            this.lblAccountPath.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "شجرة الحساب:";
            // 
            // CmdDoAction
            // 
            this.CmdDoAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdDoAction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdDoAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDoAction.ForeColor = System.Drawing.Color.White;
            this.CmdDoAction.Location = new System.Drawing.Point(63, 226);
            this.CmdDoAction.Name = "CmdDoAction";
            this.CmdDoAction.Size = new System.Drawing.Size(240, 41);
            this.CmdDoAction.TabIndex = 5;
            this.CmdDoAction.Text = "حفظ";
            this.CmdDoAction.UseVisualStyleBackColor = false;
            this.CmdDoAction.Click += new System.EventHandler(this.CmdDoAction_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Green;
            this.lblAccountNumber.Location = new System.Drawing.Point(208, 66);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(27, 24);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "NA";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAccountTitle.DataSource = this.aAccountsListBindingSource;
            this.txtAccountTitle.DisplayMember = "AccountName";
            this.txtAccountTitle.FormattingEnabled = true;
            this.txtAccountTitle.Location = new System.Drawing.Point(13, 98);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(290, 32);
            this.txtAccountTitle.TabIndex = 3;
            this.txtAccountTitle.ValueMember = "AccountID";
            // 
            // aAccountsListBindingSource
            // 
            this.aAccountsListBindingSource.DataMember = "A_AccountsList";
            this.aAccountsListBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "مسمي الحساب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم / كود الحساب:";
            // 
            // a_AccountsListTableAdapter
            // 
            this.a_AccountsListTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdDelAccount
            // 
            this.CmdDelAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdDelAccount.Image = ((System.Drawing.Image)(resources.GetObject("CmdDelAccount.Image")));
            this.CmdDelAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdDelAccount.Name = "CmdDelAccount";
            this.CmdDelAccount.Size = new System.Drawing.Size(70, 22);
            this.CmdDelAccount.Text = "حذف الحالي";
            this.CmdDelAccount.Click += new System.EventHandler(this.CmdDelAccount_Click);
            // 
            // frmAccountList
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
            this.Name = "frmAccountList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دليل الحسابات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelTree.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aAccountsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PanelTree;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.TreeView AccountListTreeView;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.ComboBox txtAccountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdDoAction;
        private System.Windows.Forms.ToolStripButton CmdReLoad;
        private System.Windows.Forms.Label lblAccountPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmdAddSub;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aAccountsListBindingSource;
        private AppDataSets.AccountingTableAdapters.A_AccountsListTableAdapter a_AccountsListTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCridtLocalCurrency;
        private System.Windows.Forms.TextBox txtDebitLocalCurrency;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CmdDelAccount;
    }
}