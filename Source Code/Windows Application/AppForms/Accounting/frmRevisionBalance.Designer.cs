namespace TMS.AppForms.Accounting
{
    partial class frmRevisionBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisionBalance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvEntryList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreditBalanceSum = new System.Windows.Forms.Label();
            this.lblDeptBalanceSum = new System.Windows.Forms.Label();
            this.lblOverAllCredit = new System.Windows.Forms.Label();
            this.lblOverAllDepit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtEndRange = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.CmdFilterTopLevel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrevCreditSum = new System.Windows.Forms.Label();
            this.lblPrevDebitSum = new System.Windows.Forms.Label();
            this.aRevisionBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.a_RevisionBalanceTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.A_RevisionBalanceTableAdapter();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitPrevSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditPrevSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depitTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRevisionBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvEntryList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 606);
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
            this.accountIDDataGridViewTextBoxColumn,
            this.accountTypeIDDataGridViewTextBoxColumn,
            this.accountFullNameDataGridViewTextBoxColumn,
            this.DebitPrevSum,
            this.CreditPrevSum,
            this.depitTotalDataGridViewTextBoxColumn,
            this.creditTotalDataGridViewTextBoxColumn,
            this.sumTotalDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.grvEntryList.DataSource = this.aRevisionBalanceBindingSource;
            this.grvEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEntryList.Location = new System.Drawing.Point(0, 0);
            this.grvEntryList.Name = "grvEntryList";
            this.grvEntryList.RowTemplate.Height = 25;
            this.grvEntryList.Size = new System.Drawing.Size(784, 542);
            this.grvEntryList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPrevCreditSum);
            this.panel3.Controls.Add(this.lblPrevDebitSum);
            this.panel3.Controls.Add(this.lblCreditBalanceSum);
            this.panel3.Controls.Add(this.lblDeptBalanceSum);
            this.panel3.Controls.Add(this.lblOverAllCredit);
            this.panel3.Controls.Add(this.lblOverAllDepit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 542);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 64);
            this.panel3.TabIndex = 1;
            // 
            // lblCreditBalanceSum
            // 
            this.lblCreditBalanceSum.BackColor = System.Drawing.Color.SkyBlue;
            this.lblCreditBalanceSum.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditBalanceSum.ForeColor = System.Drawing.Color.White;
            this.lblCreditBalanceSum.Location = new System.Drawing.Point(12, 9);
            this.lblCreditBalanceSum.Name = "lblCreditBalanceSum";
            this.lblCreditBalanceSum.Size = new System.Drawing.Size(120, 37);
            this.lblCreditBalanceSum.TabIndex = 38;
            this.lblCreditBalanceSum.Text = "0";
            this.lblCreditBalanceSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeptBalanceSum
            // 
            this.lblDeptBalanceSum.BackColor = System.Drawing.Color.SkyBlue;
            this.lblDeptBalanceSum.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptBalanceSum.ForeColor = System.Drawing.Color.White;
            this.lblDeptBalanceSum.Location = new System.Drawing.Point(138, 9);
            this.lblDeptBalanceSum.Name = "lblDeptBalanceSum";
            this.lblDeptBalanceSum.Size = new System.Drawing.Size(120, 37);
            this.lblDeptBalanceSum.TabIndex = 37;
            this.lblDeptBalanceSum.Text = "0";
            this.lblDeptBalanceSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverAllCredit
            // 
            this.lblOverAllCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllCredit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllCredit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllCredit.Location = new System.Drawing.Point(276, 9);
            this.lblOverAllCredit.Name = "lblOverAllCredit";
            this.lblOverAllCredit.Size = new System.Drawing.Size(120, 37);
            this.lblOverAllCredit.TabIndex = 36;
            this.lblOverAllCredit.Text = "0";
            this.lblOverAllCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverAllDepit
            // 
            this.lblOverAllDepit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllDepit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllDepit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllDepit.Location = new System.Drawing.Point(402, 9);
            this.lblOverAllDepit.Name = "lblOverAllDepit";
            this.lblOverAllDepit.Size = new System.Drawing.Size(120, 37);
            this.lblOverAllDepit.TabIndex = 35;
            this.lblOverAllDepit.Text = "0";
            this.lblOverAllDepit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(784, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 606);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtEndRange);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.CmdFilterTopLevel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 488);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "أختر اليوم";
            // 
            // dtEndRange
            // 
            this.dtEndRange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndRange.Location = new System.Drawing.Point(8, 69);
            this.dtEndRange.Name = "dtEndRange";
            this.dtEndRange.Size = new System.Drawing.Size(121, 32);
            this.dtEndRange.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "الي يوم:";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(8, 31);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(121, 32);
            this.dtStart.TabIndex = 6;
            // 
            // CmdFilterTopLevel
            // 
            this.CmdFilterTopLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterTopLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterTopLevel.ForeColor = System.Drawing.Color.White;
            this.CmdFilterTopLevel.Location = new System.Drawing.Point(8, 107);
            this.CmdFilterTopLevel.Name = "CmdFilterTopLevel";
            this.CmdFilterTopLevel.Size = new System.Drawing.Size(178, 38);
            this.CmdFilterTopLevel.TabIndex = 5;
            this.CmdFilterTopLevel.Text = "عرض";
            this.CmdFilterTopLevel.UseVisualStyleBackColor = false;
            this.CmdFilterTopLevel.Click += new System.EventHandler(this.CmdFilterTopLevel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "من يوم:";
            // 
            // lblPrevCreditSum
            // 
            this.lblPrevCreditSum.BackColor = System.Drawing.Color.SkyBlue;
            this.lblPrevCreditSum.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevCreditSum.ForeColor = System.Drawing.Color.White;
            this.lblPrevCreditSum.Location = new System.Drawing.Point(533, 9);
            this.lblPrevCreditSum.Name = "lblPrevCreditSum";
            this.lblPrevCreditSum.Size = new System.Drawing.Size(120, 37);
            this.lblPrevCreditSum.TabIndex = 40;
            this.lblPrevCreditSum.Text = "0";
            this.lblPrevCreditSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrevDebitSum
            // 
            this.lblPrevDebitSum.BackColor = System.Drawing.Color.SkyBlue;
            this.lblPrevDebitSum.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevDebitSum.ForeColor = System.Drawing.Color.White;
            this.lblPrevDebitSum.Location = new System.Drawing.Point(659, 9);
            this.lblPrevDebitSum.Name = "lblPrevDebitSum";
            this.lblPrevDebitSum.Size = new System.Drawing.Size(120, 37);
            this.lblPrevDebitSum.TabIndex = 39;
            this.lblPrevDebitSum.Text = "0";
            this.lblPrevDebitSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aRevisionBalanceBindingSource
            // 
            this.aRevisionBalanceBindingSource.DataMember = "A_RevisionBalance";
            this.aRevisionBalanceBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a_RevisionBalanceTableAdapter
            // 
            this.a_RevisionBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            this.accountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountTypeIDDataGridViewTextBoxColumn
            // 
            this.accountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeID";
            this.accountTypeIDDataGridViewTextBoxColumn.HeaderText = "AccountTypeID";
            this.accountTypeIDDataGridViewTextBoxColumn.Name = "accountTypeIDDataGridViewTextBoxColumn";
            this.accountTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountFullNameDataGridViewTextBoxColumn
            // 
            this.accountFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountFullNameDataGridViewTextBoxColumn.DataPropertyName = "AccountFullName";
            this.accountFullNameDataGridViewTextBoxColumn.HeaderText = "اسم الحساب";
            this.accountFullNameDataGridViewTextBoxColumn.Name = "accountFullNameDataGridViewTextBoxColumn";
            this.accountFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DebitPrevSum
            // 
            this.DebitPrevSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DebitPrevSum.DataPropertyName = "DebitPrevSum";
            dataGridViewCellStyle1.NullValue = "0";
            this.DebitPrevSum.DefaultCellStyle = dataGridViewCellStyle1;
            this.DebitPrevSum.HeaderText = "رصيد مدين قبل";
            this.DebitPrevSum.Name = "DebitPrevSum";
            this.DebitPrevSum.ReadOnly = true;
            this.DebitPrevSum.Width = 118;
            // 
            // CreditPrevSum
            // 
            this.CreditPrevSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreditPrevSum.DataPropertyName = "CreditPrevSum";
            dataGridViewCellStyle2.NullValue = "0";
            this.CreditPrevSum.DefaultCellStyle = dataGridViewCellStyle2;
            this.CreditPrevSum.HeaderText = "رصيد دائن قبل";
            this.CreditPrevSum.Name = "CreditPrevSum";
            this.CreditPrevSum.ReadOnly = true;
            this.CreditPrevSum.Width = 112;
            // 
            // depitTotalDataGridViewTextBoxColumn
            // 
            this.depitTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.depitTotalDataGridViewTextBoxColumn.DataPropertyName = "DepitTotal";
            this.depitTotalDataGridViewTextBoxColumn.HeaderText = "مجموع مدين";
            this.depitTotalDataGridViewTextBoxColumn.Name = "depitTotalDataGridViewTextBoxColumn";
            this.depitTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.depitTotalDataGridViewTextBoxColumn.Width = 105;
            // 
            // creditTotalDataGridViewTextBoxColumn
            // 
            this.creditTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditTotalDataGridViewTextBoxColumn.DataPropertyName = "CreditTotal";
            this.creditTotalDataGridViewTextBoxColumn.HeaderText = "مجموع دائن";
            this.creditTotalDataGridViewTextBoxColumn.Name = "creditTotalDataGridViewTextBoxColumn";
            this.creditTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditTotalDataGridViewTextBoxColumn.Width = 99;
            // 
            // sumTotalDataGridViewTextBoxColumn
            // 
            this.sumTotalDataGridViewTextBoxColumn.DataPropertyName = "SumTotal";
            dataGridViewCellStyle3.NullValue = "0";
            this.sumTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sumTotalDataGridViewTextBoxColumn.HeaderText = "رصيد";
            this.sumTotalDataGridViewTextBoxColumn.Name = "sumTotalDataGridViewTextBoxColumn";
            this.sumTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumTotalDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "رصيد مدين";
            this.Column1.Name = "Column1";
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "رصيد دائن";
            this.Column2.Name = "Column2";
            this.Column2.Width = 87;
            // 
            // frmRevisionBalance
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
            this.Name = "frmRevisionBalance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ميزان المراجعة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJournalEntryList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRevisionBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button CmdFilterTopLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton CmdExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CmdPrint;
        private System.Windows.Forms.DataGridView grvEntryList;
        private System.Windows.Forms.BindingSource aRevisionBalanceBindingSource;
        private AppDataSets.Accounting accounting;
        private AppDataSets.AccountingTableAdapters.A_RevisionBalanceTableAdapter a_RevisionBalanceTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCreditBalanceSum;
        private System.Windows.Forms.Label lblDeptBalanceSum;
        private System.Windows.Forms.Label lblOverAllCredit;
        private System.Windows.Forms.Label lblOverAllDepit;
        private System.Windows.Forms.DateTimePicker dtEndRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrevCreditSum;
        private System.Windows.Forms.Label lblPrevDebitSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitPrevSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditPrevSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn depitTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}