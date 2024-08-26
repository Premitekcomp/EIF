namespace TMS.AppForms.Collectors
{
    partial class frmDomainsOperationImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.colLupMonthListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eIFCollector = new TMS.AppDataSets.EIFCollector();
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.txtDomainSchema = new System.Windows.Forms.ComboBox();
            this.colLupSchemaListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDomainType = new System.Windows.Forms.ComboBox();
            this.colLupDomainsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.txtBankBranch = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.col_Lup_MonthListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter();
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter();
            this.col_Lup_SchemaListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_SchemaListTableAdapter();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.CBSelectSheet = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.CmdBrowseXLS = new System.Windows.Forms.Button();
            this.DGVDomainData = new System.Windows.Forms.DataGridView();
            this.CmdImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter();
            this.col_Lup_DomainsTypeTableAdapter = new TMS.AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainsTypeTableAdapter();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupSchemaListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDomainData)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtBranchID);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtDomainSchema);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtDomainType);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtBankBranch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(128, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(785, 97);
            this.GroupBox1.TabIndex = 39;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Start";
            // 
            // txtMonth
            // 
            this.txtMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMonth.DataSource = this.colLupMonthListBindingSource;
            this.txtMonth.DisplayMember = "MonthTitle";
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Location = new System.Drawing.Point(64, 17);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(123, 25);
            this.txtMonth.TabIndex = 21;
            this.txtMonth.ValueMember = "MonthID";
            // 
            // colLupMonthListBindingSource
            // 
            this.colLupMonthListBindingSource.DataMember = "Col_Lup_MonthList";
            this.colLupMonthListBindingSource.DataSource = this.eIFCollector;
            // 
            // eIFCollector
            // 
            this.eIFCollector.DataSetName = "EIFCollector";
            this.eIFCollector.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(526, 17);
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
            this.Label5.Location = new System.Drawing.Point(464, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 17);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Branch:";
            // 
            // txtDomainSchema
            // 
            this.txtDomainSchema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDomainSchema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDomainSchema.DataSource = this.colLupSchemaListBindingSource;
            this.txtDomainSchema.DisplayMember = "SchemaTitle";
            this.txtDomainSchema.FormattingEnabled = true;
            this.txtDomainSchema.Location = new System.Drawing.Point(452, 55);
            this.txtDomainSchema.Name = "txtDomainSchema";
            this.txtDomainSchema.Size = new System.Drawing.Size(252, 25);
            this.txtDomainSchema.TabIndex = 18;
            this.txtDomainSchema.ValueMember = "SchemaID";
            // 
            // colLupSchemaListBindingSource
            // 
            this.colLupSchemaListBindingSource.DataMember = "Col_Lup_SchemaList";
            this.colLupSchemaListBindingSource.DataSource = this.eIFCollector;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(337, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(113, 17);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Domain Schema:";
            // 
            // txtDomainType
            // 
            this.txtDomainType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDomainType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDomainType.DataSource = this.colLupDomainsTypeBindingSource;
            this.txtDomainType.DisplayMember = "DomainTypeTitle";
            this.txtDomainType.FormattingEnabled = true;
            this.txtDomainType.Location = new System.Drawing.Point(121, 55);
            this.txtDomainType.Name = "txtDomainType";
            this.txtDomainType.Size = new System.Drawing.Size(131, 25);
            this.txtDomainType.TabIndex = 16;
            this.txtDomainType.ValueMember = "DomainTypeID";
            // 
            // colLupDomainsTypeBindingSource
            // 
            this.colLupDomainsTypeBindingSource.DataMember = "Col_Lup_DomainsType";
            this.colLupDomainsTypeBindingSource.DataSource = this.eIFCollector;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 17);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Domain Type:";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBankBranch.DataSource = this.hRLupBankListBindingSource;
            this.txtBankBranch.DisplayMember = "BankTitle";
            this.txtBankBranch.FormattingEnabled = true;
            this.txtBankBranch.Location = new System.Drawing.Point(270, 17);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(139, 25);
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
            this.Label2.Location = new System.Drawing.Point(221, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bank:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 17);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Month:";
            // 
            // col_Lup_MonthListTableAdapter
            // 
            this.col_Lup_MonthListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_SchemaListTableAdapter
            // 
            this.col_Lup_SchemaListTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.CmdImport);
            this.GroupBox2.Controls.Add(this.CBSelectSheet);
            this.GroupBox2.Controls.Add(this.lblSelect);
            this.GroupBox2.Controls.Add(this.CmdBrowseXLS);
            this.GroupBox2.Controls.Add(this.DGVDomainData);
            this.GroupBox2.Location = new System.Drawing.Point(12, 115);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1037, 427);
            this.GroupBox2.TabIndex = 43;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Import File";
            // 
            // CBSelectSheet
            // 
            this.CBSelectSheet.FormattingEnabled = true;
            this.CBSelectSheet.Location = new System.Drawing.Point(116, 21);
            this.CBSelectSheet.Name = "CBSelectSheet";
            this.CBSelectSheet.Size = new System.Drawing.Size(159, 25);
            this.CBSelectSheet.TabIndex = 6;
            this.CBSelectSheet.Visible = false;
            this.CBSelectSheet.SelectedIndexChanged += new System.EventHandler(this.CBSelectSheet_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(8, 24);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(88, 17);
            this.lblSelect.TabIndex = 17;
            this.lblSelect.Text = "Select Sheet:";
            this.lblSelect.Visible = false;
            // 
            // CmdBrowseXLS
            // 
            this.CmdBrowseXLS.ForeColor = System.Drawing.Color.Black;
            this.CmdBrowseXLS.Location = new System.Drawing.Point(683, 16);
            this.CmdBrowseXLS.Name = "CmdBrowseXLS";
            this.CmdBrowseXLS.Size = new System.Drawing.Size(80, 35);
            this.CmdBrowseXLS.TabIndex = 5;
            this.CmdBrowseXLS.Text = "Browse";
            this.CmdBrowseXLS.UseVisualStyleBackColor = true;
            this.CmdBrowseXLS.Click += new System.EventHandler(this.CmdBrowseXLS_Click);
            // 
            // DGVDomainData
            // 
            this.DGVDomainData.AllowUserToAddRows = false;
            this.DGVDomainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDomainData.Location = new System.Drawing.Point(12, 57);
            this.DGVDomainData.Name = "DGVDomainData";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.DGVDomainData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDomainData.Size = new System.Drawing.Size(1019, 364);
            this.DGVDomainData.TabIndex = 0;
            // 
            // CmdImport
            // 
            this.CmdImport.Location = new System.Drawing.Point(935, 15);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(96, 37);
            this.CmdImport.TabIndex = 47;
            this.CmdImport.Text = "Import Data";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // col_Lup_DomainsTypeTableAdapter
            // 
            this.col_Lup_DomainsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmDomainsOperationImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 554);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDomainsOperationImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Domain";
            this.Load += new System.EventHandler(this.frmDomainsOperationImport_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colLupMonthListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIFCollector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupSchemaListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colLupDomainsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDomainData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox txtMonth;
        internal System.Windows.Forms.ComboBox txtDomainSchema;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox txtDomainType;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox txtBankBranch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox txtBranchID;
        internal System.Windows.Forms.Label Label5;
        private AppDataSets.EIFCollector eIFCollector;
        private System.Windows.Forms.BindingSource colLupMonthListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_MonthListTableAdapter col_Lup_MonthListTableAdapter;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private System.Windows.Forms.BindingSource colLupSchemaListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_SchemaListTableAdapter col_Lup_SchemaListTableAdapter;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox CBSelectSheet;
        internal System.Windows.Forms.Label lblSelect;
        internal System.Windows.Forms.Button CmdBrowseXLS;
        internal System.Windows.Forms.DataGridView DGVDomainData;
        internal System.Windows.Forms.Button CmdImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private System.Windows.Forms.BindingSource colLupDomainsTypeBindingSource;
        private AppDataSets.EIFCollectorTableAdapters.Col_Lup_DomainsTypeTableAdapter col_Lup_DomainsTypeTableAdapter;
    }
}