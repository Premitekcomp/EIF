namespace TMS.AppForms.Collectors
{
    partial class frmOfficeMonthlyTarget
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
            this.grvTargetBasic = new System.Windows.Forms.DataGridView();
            this.grvTargetDetails = new System.Windows.Forms.DataGridView();
            this.txtAvaliableIDs = new System.Windows.Forms.ComboBox();
            this.colLupDomainSerialFilterdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdSaveOverallTarget = new System.Windows.Forms.Button();
            this.lblDomainVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdGetDomainIDs = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.col_Lup_DomainSerialFilterdTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.eIFCollectorAnalysis = new TMS.AppDataSets.EIFCollectorAnalysis();
            this.colBskMonthlyTargetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Bsk_MonthlyTargetTableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Bsk_MonthlyTargetTableAdapter();
            this.targetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOverallTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdSaveBucketTarget = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBucket = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBucketTarget = new System.Windows.Forms.TextBox();
            this.colBskMonthlyTargetDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col_Bsk_MonthlyTargetDetailsTableAdapter = new TMS.AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Bsk_MonthlyTargetDetailsTableAdapter();
            this.recordSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucketTargetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvTargetBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTargetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollectorAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBskMonthlyTargetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBskMonthlyTargetDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTargetBasic
            // 
            this.grvTargetBasic.AllowUserToAddRows = false;
            this.grvTargetBasic.AllowUserToDeleteRows = false;
            this.grvTargetBasic.AutoGenerateColumns = false;
            this.grvTargetBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTargetBasic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetIDDataGridViewTextBoxColumn,
            this.domainIDDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn});
            this.grvTargetBasic.DataSource = this.colBskMonthlyTargetBindingSource;
            this.grvTargetBasic.Location = new System.Drawing.Point(417, 18);
            this.grvTargetBasic.Name = "grvTargetBasic";
            this.grvTargetBasic.ReadOnly = true;
            this.grvTargetBasic.Size = new System.Drawing.Size(370, 82);
            this.grvTargetBasic.TabIndex = 3;
            // 
            // grvTargetDetails
            // 
            this.grvTargetDetails.AllowUserToAddRows = false;
            this.grvTargetDetails.AllowUserToDeleteRows = false;
            this.grvTargetDetails.AutoGenerateColumns = false;
            this.grvTargetDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTargetDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordSerialDataGridViewTextBoxColumn,
            this.targetIDDataGridViewTextBoxColumn1,
            this.bucketValueDataGridViewTextBoxColumn,
            this.bucketTargetDataGridViewTextBoxColumn});
            this.grvTargetDetails.DataSource = this.colBskMonthlyTargetDetailsBindingSource;
            this.grvTargetDetails.Location = new System.Drawing.Point(417, 106);
            this.grvTargetDetails.Name = "grvTargetDetails";
            this.grvTargetDetails.ReadOnly = true;
            this.grvTargetDetails.Size = new System.Drawing.Size(370, 254);
            this.grvTargetDetails.TabIndex = 8;
            // 
            // txtAvaliableIDs
            // 
            this.txtAvaliableIDs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAvaliableIDs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtAvaliableIDs.DataSource = this.colLupDomainSerialFilterdBindingSource;
            this.txtAvaliableIDs.DisplayMember = "DomainSerial";
            this.txtAvaliableIDs.FormattingEnabled = true;
            this.txtAvaliableIDs.Location = new System.Drawing.Point(6, 171);
            this.txtAvaliableIDs.Name = "txtAvaliableIDs";
            this.txtAvaliableIDs.Size = new System.Drawing.Size(166, 25);
            this.txtAvaliableIDs.TabIndex = 52;
            this.txtAvaliableIDs.ValueMember = "CurrentVersion";
            this.txtAvaliableIDs.SelectedIndexChanged += new System.EventHandler(this.txtAvaliableIDs_SelectedIndexChanged);
            // 
            // colLupDomainSerialFilterdBindingSource
            // 
            this.colLupDomainSerialFilterdBindingSource.DataMember = "Col_Lup_DomainSerialFilterd";
            this.colLupDomainSerialFilterdBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 17);
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
            this.txtBankBranch.Location = new System.Drawing.Point(63, 47);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(109, 25);
            this.txtBankBranch.TabIndex = 1;
            this.txtBankBranch.ValueMember = "BankID";
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.eIFCollector;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(63, 78);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(109, 25);
            this.txtBranchID.TabIndex = 20;
            this.txtBranchID.ValueMember = "BranchID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // CmdSaveOverallTarget
            // 
            this.CmdSaveOverallTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveOverallTarget.Location = new System.Drawing.Point(215, 73);
            this.CmdSaveOverallTarget.Name = "CmdSaveOverallTarget";
            this.CmdSaveOverallTarget.Size = new System.Drawing.Size(161, 37);
            this.CmdSaveOverallTarget.TabIndex = 55;
            this.CmdSaveOverallTarget.Text = "Save Overall Target";
            this.CmdSaveOverallTarget.UseVisualStyleBackColor = true;
            this.CmdSaveOverallTarget.Click += new System.EventHandler(this.CmdSaveOverallTarget_Click);
            // 
            // lblDomainVersion
            // 
            this.lblDomainVersion.AutoSize = true;
            this.lblDomainVersion.Location = new System.Drawing.Point(6, 199);
            this.lblDomainVersion.Name = "lblDomainVersion";
            this.lblDomainVersion.Size = new System.Drawing.Size(163, 17);
            this.lblDomainVersion.TabIndex = 54;
            this.lblDomainVersion.Text = "Current Domain Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Avaliable Domains";
            // 
            // CmdGetDomainIDs
            // 
            this.CmdGetDomainIDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGetDomainIDs.Location = new System.Drawing.Point(6, 108);
            this.CmdGetDomainIDs.Name = "CmdGetDomainIDs";
            this.CmdGetDomainIDs.Size = new System.Drawing.Size(166, 37);
            this.CmdGetDomainIDs.TabIndex = 51;
            this.CmdGetDomainIDs.Text = "Import Domain List";
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
            this.txtMonth.Location = new System.Drawing.Point(63, 16);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(109, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month:";
            // 
            // GroupBox1
            // 
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
            this.GroupBox1.Location = new System.Drawing.Point(5, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(180, 224);
            this.GroupBox1.TabIndex = 103;
            this.GroupBox1.TabStop = false;
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainSerialFilterdTableAdapter
            // 
            this.col_Lup_DomainSerialFilterdTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // eIFCollectorAnalysis
            // 
            this.eIFCollectorAnalysis.DataSetName = "EIFCollectorAnalysis";
            this.eIFCollectorAnalysis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colBskMonthlyTargetBindingSource
            // 
            this.colBskMonthlyTargetBindingSource.DataMember = "Col_Bsk_MonthlyTarget";
            this.colBskMonthlyTargetBindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // col_Bsk_MonthlyTargetTableAdapter
            // 
            this.col_Bsk_MonthlyTargetTableAdapter.ClearBeforeFill = true;
            // 
            // targetIDDataGridViewTextBoxColumn
            // 
            this.targetIDDataGridViewTextBoxColumn.DataPropertyName = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.HeaderText = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.Name = "targetIDDataGridViewTextBoxColumn";
            this.targetIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.targetIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainIDDataGridViewTextBoxColumn
            // 
            this.domainIDDataGridViewTextBoxColumn.DataPropertyName = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.HeaderText = "DomainID";
            this.domainIDDataGridViewTextBoxColumn.Name = "domainIDDataGridViewTextBoxColumn";
            this.domainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.domainIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "Overall Target";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtOverallTarget
            // 
            this.txtOverallTarget.Location = new System.Drawing.Point(215, 41);
            this.txtOverallTarget.Name = "txtOverallTarget";
            this.txtOverallTarget.Size = new System.Drawing.Size(161, 23);
            this.txtOverallTarget.TabIndex = 104;
            this.txtOverallTarget.Text = "0";
            this.txtOverallTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Overall Target";
            // 
            // CmdSaveBucketTarget
            // 
            this.CmdSaveBucketTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveBucketTarget.Location = new System.Drawing.Point(215, 229);
            this.CmdSaveBucketTarget.Name = "CmdSaveBucketTarget";
            this.CmdSaveBucketTarget.Size = new System.Drawing.Size(166, 37);
            this.CmdSaveBucketTarget.TabIndex = 106;
            this.CmdSaveBucketTarget.Text = "Save Bucket Target";
            this.CmdSaveBucketTarget.UseVisualStyleBackColor = true;
            this.CmdSaveBucketTarget.Click += new System.EventHandler(this.CmdSaveBucketTarget_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Bucket";
            // 
            // txtBucket
            // 
            this.txtBucket.Location = new System.Drawing.Point(269, 171);
            this.txtBucket.Name = "txtBucket";
            this.txtBucket.Size = new System.Drawing.Size(107, 23);
            this.txtBucket.TabIndex = 107;
            this.txtBucket.Text = "0";
            this.txtBucket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "Target";
            // 
            // txtBucketTarget
            // 
            this.txtBucketTarget.Location = new System.Drawing.Point(269, 200);
            this.txtBucketTarget.Name = "txtBucketTarget";
            this.txtBucketTarget.Size = new System.Drawing.Size(107, 23);
            this.txtBucketTarget.TabIndex = 109;
            this.txtBucketTarget.Text = "0";
            this.txtBucketTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colBskMonthlyTargetDetailsBindingSource
            // 
            this.colBskMonthlyTargetDetailsBindingSource.DataMember = "Col_Bsk_MonthlyTargetDetails";
            this.colBskMonthlyTargetDetailsBindingSource.DataSource = this.eIFCollectorAnalysis;
            // 
            // col_Bsk_MonthlyTargetDetailsTableAdapter
            // 
            this.col_Bsk_MonthlyTargetDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // recordSerialDataGridViewTextBoxColumn
            // 
            this.recordSerialDataGridViewTextBoxColumn.DataPropertyName = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.HeaderText = "RecordSerial";
            this.recordSerialDataGridViewTextBoxColumn.Name = "recordSerialDataGridViewTextBoxColumn";
            this.recordSerialDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // targetIDDataGridViewTextBoxColumn1
            // 
            this.targetIDDataGridViewTextBoxColumn1.DataPropertyName = "TargetID";
            this.targetIDDataGridViewTextBoxColumn1.HeaderText = "TargetID";
            this.targetIDDataGridViewTextBoxColumn1.Name = "targetIDDataGridViewTextBoxColumn1";
            this.targetIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.targetIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bucketValueDataGridViewTextBoxColumn
            // 
            this.bucketValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bucketValueDataGridViewTextBoxColumn.DataPropertyName = "BucketValue";
            this.bucketValueDataGridViewTextBoxColumn.HeaderText = "Bucket";
            this.bucketValueDataGridViewTextBoxColumn.Name = "bucketValueDataGridViewTextBoxColumn";
            this.bucketValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.bucketValueDataGridViewTextBoxColumn.Width = 76;
            // 
            // bucketTargetDataGridViewTextBoxColumn
            // 
            this.bucketTargetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bucketTargetDataGridViewTextBoxColumn.DataPropertyName = "BucketTarget";
            this.bucketTargetDataGridViewTextBoxColumn.HeaderText = "Bucket Target";
            this.bucketTargetDataGridViewTextBoxColumn.Name = "bucketTargetDataGridViewTextBoxColumn";
            this.bucketTargetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmOfficeMonthlyTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 371);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBucketTarget);
            this.Controls.Add(this.CmdSaveBucketTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBucket);
            this.Controls.Add(this.CmdSaveOverallTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOverallTarget);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.grvTargetDetails);
            this.Controls.Add(this.grvTargetBasic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmOfficeMonthlyTarget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Target";
            this.Load += new System.EventHandler(this.frmOfficeMonthlyTarget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTargetBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTargetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainSerialFilterdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollectorAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBskMonthlyTargetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBskMonthlyTargetDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvTargetBasic;
        private System.Windows.Forms.DataGridView grvTargetDetails;
        internal System.Windows.Forms.ComboBox txtAvaliableIDs;
        private System.Windows.Forms.BindingSource colLupDomainSerialFilterdBindingSource;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        internal System.Windows.Forms.ComboBox txtBranchID;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        internal System.Windows.Forms.Button CmdSaveOverallTarget;
        internal System.Windows.Forms.Label lblDomainVersion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button CmdGetDomainIDs;
        internal System.Windows.Forms.ComboBox txtMonth;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainSerialFilterdTableAdapter col_Lup_DomainSerialFilterdTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private AppDataSets.EIFCollectorAnalysis eIFCollectorAnalysis;
        private System.Windows.Forms.BindingSource colBskMonthlyTargetBindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Bsk_MonthlyTargetTableAdapter col_Bsk_MonthlyTargetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtOverallTarget;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button CmdSaveBucketTarget;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBucket;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBucketTarget;
        private System.Windows.Forms.BindingSource colBskMonthlyTargetDetailsBindingSource;
        private AppDataSets.EIFCollectorAnalysisTableAdapters.Col_Bsk_MonthlyTargetDetailsTableAdapter col_Bsk_MonthlyTargetDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucketTargetDataGridViewTextBoxColumn;
    }
}