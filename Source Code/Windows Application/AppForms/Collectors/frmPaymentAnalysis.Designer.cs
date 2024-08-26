namespace TMS.AppForms.Collectors
{
    partial class frmPaymentAnalysis
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
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdLoadDomain = new System.Windows.Forms.Button();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grvFullDomain = new System.Windows.Forms.DataGridView();
            this.gridCompareDomainGBBucketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridCompareDomainGBBucketTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.GridCompareDomainGBBucketTableAdapter();
            this.bucketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BktTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bktAchivment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BktRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainGBBucketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CmdLoadDomain);
            this.GroupBox1.Controls.Add(this.lblDomainVersion);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txtAvaliableIDs);
            this.GroupBox1.Controls.Add(this.CmdGetDomainIDs);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtBranchID);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBankBranch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Location = new System.Drawing.Point(1, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(196, 365);
            this.GroupBox1.TabIndex = 78;
            this.GroupBox1.TabStop = false;
            // 
            // CmdLoadDomain
            // 
            this.CmdLoadDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLoadDomain.Location = new System.Drawing.Point(6, 318);
            this.CmdLoadDomain.Name = "CmdLoadDomain";
            this.CmdLoadDomain.Size = new System.Drawing.Size(178, 37);
            this.CmdLoadDomain.TabIndex = 55;
            this.CmdLoadDomain.Text = "Load Domain";
            this.CmdLoadDomain.UseVisualStyleBackColor = true;
            this.CmdLoadDomain.Click += new System.EventHandler(this.CmdLoadDomain_Click);
            // 
            // lblDomainVersion
            // 
            this.lblDomainVersion.AutoSize = true;
            this.lblDomainVersion.Location = new System.Drawing.Point(3, 287);
            this.lblDomainVersion.Name = "lblDomainVersion";
            this.lblDomainVersion.Size = new System.Drawing.Size(159, 17);
            this.lblDomainVersion.TabIndex = 54;
            this.lblDomainVersion.Text = "Current Domain Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains";
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(6, 250);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(178, 25);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(6, 178);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(178, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Data";
            this.CmdGetDomainIDs.UseVisualStyleBackColor = true;
            this.CmdGetDomainIDs.Click += new System.EventHandler(this.CmdGetDomainIDs_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMonth.DataSource = this.colLupMonthListBindingSource;
            this.txtMonth.DisplayMember = "MonthTitle";
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Location = new System.Drawing.Point(6, 39);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(178, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(6, 138);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(178, 25);
            this.txtBranchID.TabIndex = 20;
            this.txtBranchID.ValueMember = "BranchID";
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 118);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 17);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Branch:";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBankBranch.DataSource = this.hRLupBankListBindingSource;
            this.txtBankBranch.DisplayMember = "BankTitle";
            this.txtBankBranch.FormattingEnabled = true;
            this.txtBankBranch.Location = new System.Drawing.Point(6, 87);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(178, 25);
            this.txtBankBranch.TabIndex = 1;
            this.txtBankBranch.ValueMember = "BankID";
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month:";
            // 
            // grvFullDomain
            // 
            this.grvFullDomain.AllowUserToAddRows = false;
            this.grvFullDomain.AllowUserToDeleteRows = false;
            this.grvFullDomain.AllowUserToOrderColumns = true;
            this.grvFullDomain.AutoGenerateColumns = false;
            this.grvFullDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFullDomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bucketDataGridViewTextBoxColumn,
            this.BktTarget,
            this.TotalPayment,
            this.bktAchivment,
            this.BktRemaining});
            this.grvFullDomain.DataSource = this.gridCompareDomainGBBucketBindingSource;
            this.grvFullDomain.Location = new System.Drawing.Point(203, 12);
            this.grvFullDomain.Name = "grvFullDomain";
            this.grvFullDomain.ReadOnly = true;
            this.grvFullDomain.Size = new System.Drawing.Size(671, 355);
            this.grvFullDomain.TabIndex = 79;
            // 
            // gridCompareDomainGBBucketBindingSource
            // 
            this.gridCompareDomainGBBucketBindingSource.DataMember = "GridCompareDomainGBBucket";
            this.gridCompareDomainGBBucketBindingSource.DataSource = this.eIFCollector;
            // 
            // gridCompareDomainGBBucketTableAdapter
            // 
            this.gridCompareDomainGBBucketTableAdapter.ClearBeforeFill = true;
            // 
            // bucketDataGridViewTextBoxColumn
            // 
            this.bucketDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bucketDataGridViewTextBoxColumn.DataPropertyName = "Bucket";
            this.bucketDataGridViewTextBoxColumn.HeaderText = "Bucket";
            this.bucketDataGridViewTextBoxColumn.Name = "bucketDataGridViewTextBoxColumn";
            this.bucketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BktTarget
            // 
            this.BktTarget.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BktTarget.HeaderText = "Target Amount";
            this.BktTarget.Name = "BktTarget";
            this.BktTarget.ReadOnly = true;
            this.BktTarget.Width = 126;
            // 
            // TotalPayment
            // 
            this.TotalPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPayment.DataPropertyName = "TotalPayment";
            this.TotalPayment.HeaderText = "Collected";
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.ReadOnly = true;
            this.TotalPayment.Width = 88;
            // 
            // bktAchivment
            // 
            this.bktAchivment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bktAchivment.HeaderText = "Resolution";
            this.bktAchivment.Name = "bktAchivment";
            this.bktAchivment.ReadOnly = true;
            this.bktAchivment.Width = 96;
            // 
            // BktRemaining
            // 
            this.BktRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BktRemaining.HeaderText = "Remaining";
            this.BktRemaining.Name = "BktRemaining";
            this.BktRemaining.ReadOnly = true;
            this.BktRemaining.Width = 96;
            // 
            // frmPaymentAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 378);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.grvFullDomain);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPaymentAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Analysis";
            this.Load += new System.EventHandler(this.frmPaymentAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFullDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompareDomainGBBucketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppDataSets.EIFCollector eIFCollector;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button CmdLoadDomain;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        internal System.Windows.Forms.ComboBox txtBranchID;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvFullDomain;
        private System.Windows.Forms.BindingSource gridCompareDomainGBBucketBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.GridCompareDomainGBBucketTableAdapter gridCompareDomainGBBucketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BktTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn bktAchivment;
        private System.Windows.Forms.DataGridViewTextBoxColumn BktRemaining;
    }
}