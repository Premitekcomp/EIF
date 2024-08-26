namespace TMS.AppForms.Accounting
{
    partial class frmASTBasicInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CmdShowAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtASTGroup = new System.Windows.Forms.ComboBox();
            this.aSTGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameLike = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assetSerialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDepreciationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDepsCurrentValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depreciationPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetStateTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSTLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSTGroupTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSTBasicInfoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aST_BasicInfoViewTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AST_BasicInfoViewTableAdapter();
            this.aST_GroupsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTBasicInfoViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CmdAddNew);
            this.panel1.Controls.Add(this.CmdShowAll);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(772, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 577);
            this.panel1.TabIndex = 0;
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddNew.ForeColor = System.Drawing.Color.White;
            this.CmdAddNew.Location = new System.Drawing.Point(0, 0);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(208, 43);
            this.CmdAddNew.TabIndex = 2;
            this.CmdAddNew.Text = "إضافه جديد";
            this.CmdAddNew.UseVisualStyleBackColor = false;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CmdShowAll
            // 
            this.CmdShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdShowAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CmdShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShowAll.ForeColor = System.Drawing.Color.White;
            this.CmdShowAll.Location = new System.Drawing.Point(0, 534);
            this.CmdShowAll.Name = "CmdShowAll";
            this.CmdShowAll.Size = new System.Drawing.Size(208, 43);
            this.CmdShowAll.TabIndex = 1;
            this.CmdShowAll.Text = "عرض الكل";
            this.CmdShowAll.UseVisualStyleBackColor = false;
            this.CmdShowAll.Click += new System.EventHandler(this.CmdShowAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtASTGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNameLike);
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التصفيه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "بمكان الاصل:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(6, 123);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(178, 32);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "بالمجموعة:";
            // 
            // txtASTGroup
            // 
            this.txtASTGroup.DataSource = this.aSTGroupsBindingSource;
            this.txtASTGroup.DisplayMember = "ASTGroupTitle";
            this.txtASTGroup.FormattingEnabled = true;
            this.txtASTGroup.Location = new System.Drawing.Point(6, 206);
            this.txtASTGroup.Name = "txtASTGroup";
            this.txtASTGroup.Size = new System.Drawing.Size(178, 32);
            this.txtASTGroup.TabIndex = 2;
            this.txtASTGroup.ValueMember = "ASTGroupID";
            this.txtASTGroup.SelectedIndexChanged += new System.EventHandler(this.txtASTGroup_SelectedIndexChanged);
            // 
            // aSTGroupsBindingSource
            // 
            this.aSTGroupsBindingSource.DataMember = "AST_Groups";
            this.aSTGroupsBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "بالاسم:";
            // 
            // txtNameLike
            // 
            this.txtNameLike.Location = new System.Drawing.Point(6, 55);
            this.txtNameLike.Name = "txtNameLike";
            this.txtNameLike.Size = new System.Drawing.Size(178, 32);
            this.txtNameLike.TabIndex = 0;
            this.txtNameLike.TextChanged += new System.EventHandler(this.txtNameLike_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 577);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetIDDataGridViewTextBoxColumn,
            this.assetStateIDDataGridViewTextBoxColumn,
            this.Column1,
            this.assetSerialNumberDataGridViewTextBoxColumn,
            this.assetTitleDataGridViewTextBoxColumn,
            this.buyDateDataGridViewTextBoxColumn,
            this.capitalCostDataGridViewTextBoxColumn,
            this.startDepreciationDateDataGridViewTextBoxColumn,
            this.startDepsCurrentValueDataGridViewTextBoxColumn,
            this.depreciationPercentageDataGridViewTextBoxColumn,
            this.assetStateTitleDataGridViewTextBoxColumn,
            this.aSTLocationDataGridViewTextBoxColumn,
            this.aSTGroupTitleDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.salesDateDataGridViewTextBoxColumn,
            this.scrapDateDataGridViewTextBoxColumn,
            this.scrapValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aSTBasicInfoViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(772, 577);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // assetIDDataGridViewTextBoxColumn
            // 
            this.assetIDDataGridViewTextBoxColumn.DataPropertyName = "AssetID";
            this.assetIDDataGridViewTextBoxColumn.HeaderText = "AssetID";
            this.assetIDDataGridViewTextBoxColumn.Name = "assetIDDataGridViewTextBoxColumn";
            this.assetIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // assetStateIDDataGridViewTextBoxColumn
            // 
            this.assetStateIDDataGridViewTextBoxColumn.DataPropertyName = "AssetStateID";
            this.assetStateIDDataGridViewTextBoxColumn.HeaderText = "AssetStateID";
            this.assetStateIDDataGridViewTextBoxColumn.Name = "assetStateIDDataGridViewTextBoxColumn";
            this.assetStateIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "تعديل";
            this.Column1.Name = "Column1";
            this.Column1.Text = ". . .";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 48;
            // 
            // assetSerialNumberDataGridViewTextBoxColumn
            // 
            this.assetSerialNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.assetSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "AssetSerialNumber";
            this.assetSerialNumberDataGridViewTextBoxColumn.HeaderText = "كود الاصل";
            this.assetSerialNumberDataGridViewTextBoxColumn.Name = "assetSerialNumberDataGridViewTextBoxColumn";
            this.assetSerialNumberDataGridViewTextBoxColumn.Width = 89;
            // 
            // assetTitleDataGridViewTextBoxColumn
            // 
            this.assetTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.assetTitleDataGridViewTextBoxColumn.DataPropertyName = "AssetTitle";
            this.assetTitleDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.assetTitleDataGridViewTextBoxColumn.Name = "assetTitleDataGridViewTextBoxColumn";
            this.assetTitleDataGridViewTextBoxColumn.Width = 66;
            // 
            // buyDateDataGridViewTextBoxColumn
            // 
            this.buyDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.buyDateDataGridViewTextBoxColumn.DataPropertyName = "BuyDate";
            this.buyDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الشراء";
            this.buyDateDataGridViewTextBoxColumn.Name = "buyDateDataGridViewTextBoxColumn";
            this.buyDateDataGridViewTextBoxColumn.Width = 95;
            // 
            // capitalCostDataGridViewTextBoxColumn
            // 
            this.capitalCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.capitalCostDataGridViewTextBoxColumn.DataPropertyName = "CapitalCost";
            this.capitalCostDataGridViewTextBoxColumn.HeaderText = "تكلفة الشراء";
            this.capitalCostDataGridViewTextBoxColumn.Name = "capitalCostDataGridViewTextBoxColumn";
            this.capitalCostDataGridViewTextBoxColumn.Width = 104;
            // 
            // startDepreciationDateDataGridViewTextBoxColumn
            // 
            this.startDepreciationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startDepreciationDateDataGridViewTextBoxColumn.DataPropertyName = "StartDepreciationDate";
            this.startDepreciationDateDataGridViewTextBoxColumn.HeaderText = "تاريخ بدايه الاهلاك";
            this.startDepreciationDateDataGridViewTextBoxColumn.Name = "startDepreciationDateDataGridViewTextBoxColumn";
            this.startDepreciationDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // startDepsCurrentValueDataGridViewTextBoxColumn
            // 
            this.startDepsCurrentValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startDepsCurrentValueDataGridViewTextBoxColumn.DataPropertyName = "StartDepsCurrentValue";
            this.startDepsCurrentValueDataGridViewTextBoxColumn.HeaderText = "القيمة في بداية الاهلاك";
            this.startDepsCurrentValueDataGridViewTextBoxColumn.Name = "startDepsCurrentValueDataGridViewTextBoxColumn";
            this.startDepsCurrentValueDataGridViewTextBoxColumn.Width = 166;
            // 
            // depreciationPercentageDataGridViewTextBoxColumn
            // 
            this.depreciationPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.depreciationPercentageDataGridViewTextBoxColumn.DataPropertyName = "DepreciationPercentage";
            this.depreciationPercentageDataGridViewTextBoxColumn.HeaderText = "نسبة الاهلاك";
            this.depreciationPercentageDataGridViewTextBoxColumn.Name = "depreciationPercentageDataGridViewTextBoxColumn";
            this.depreciationPercentageDataGridViewTextBoxColumn.Width = 105;
            // 
            // assetStateTitleDataGridViewTextBoxColumn
            // 
            this.assetStateTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.assetStateTitleDataGridViewTextBoxColumn.DataPropertyName = "AssetStateTitle";
            this.assetStateTitleDataGridViewTextBoxColumn.HeaderText = "حالة الاصل";
            this.assetStateTitleDataGridViewTextBoxColumn.Name = "assetStateTitleDataGridViewTextBoxColumn";
            this.assetStateTitleDataGridViewTextBoxColumn.Width = 90;
            // 
            // aSTLocationDataGridViewTextBoxColumn
            // 
            this.aSTLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aSTLocationDataGridViewTextBoxColumn.DataPropertyName = "ASTLocation";
            this.aSTLocationDataGridViewTextBoxColumn.HeaderText = "مكان الاصل";
            this.aSTLocationDataGridViewTextBoxColumn.Name = "aSTLocationDataGridViewTextBoxColumn";
            this.aSTLocationDataGridViewTextBoxColumn.Width = 96;
            // 
            // aSTGroupTitleDataGridViewTextBoxColumn
            // 
            this.aSTGroupTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aSTGroupTitleDataGridViewTextBoxColumn.DataPropertyName = "ASTGroupTitle";
            this.aSTGroupTitleDataGridViewTextBoxColumn.HeaderText = "المجموعة";
            this.aSTGroupTitleDataGridViewTextBoxColumn.Name = "aSTGroupTitleDataGridViewTextBoxColumn";
            this.aSTGroupTitleDataGridViewTextBoxColumn.Width = 90;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 81;
            // 
            // salesDateDataGridViewTextBoxColumn
            // 
            this.salesDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salesDateDataGridViewTextBoxColumn.DataPropertyName = "SalesDate";
            this.salesDateDataGridViewTextBoxColumn.HeaderText = "تاريخ البيع";
            this.salesDateDataGridViewTextBoxColumn.Name = "salesDateDataGridViewTextBoxColumn";
            this.salesDateDataGridViewTextBoxColumn.Width = 87;
            // 
            // scrapDateDataGridViewTextBoxColumn
            // 
            this.scrapDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scrapDateDataGridViewTextBoxColumn.DataPropertyName = "ScrapDate";
            this.scrapDateDataGridViewTextBoxColumn.HeaderText = "تاريخ التكهين";
            this.scrapDateDataGridViewTextBoxColumn.Name = "scrapDateDataGridViewTextBoxColumn";
            this.scrapDateDataGridViewTextBoxColumn.Width = 107;
            // 
            // scrapValueDataGridViewTextBoxColumn
            // 
            this.scrapValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scrapValueDataGridViewTextBoxColumn.DataPropertyName = "ScrapValue";
            this.scrapValueDataGridViewTextBoxColumn.HeaderText = "قيمة التكهين او البيع";
            this.scrapValueDataGridViewTextBoxColumn.Name = "scrapValueDataGridViewTextBoxColumn";
            this.scrapValueDataGridViewTextBoxColumn.Width = 154;
            // 
            // aSTBasicInfoViewBindingSource
            // 
            this.aSTBasicInfoViewBindingSource.DataMember = "AST_BasicInfoView";
            this.aSTBasicInfoViewBindingSource.DataSource = this.accounting;
            // 
            // aST_BasicInfoViewTableAdapter
            // 
            this.aST_BasicInfoViewTableAdapter.ClearBeforeFill = true;
            // 
            // aST_GroupsTableAdapter
            // 
            this.aST_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmASTBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmASTBasicInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل الاصول";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmASTBasicInfo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTBasicInfoViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aSTBasicInfoViewBindingSource;
        private AppDataSets.AccountingTableAdapters.AST_BasicInfoViewTableAdapter aST_BasicInfoViewTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameLike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtASTGroup;
        private System.Windows.Forms.BindingSource aSTGroupsBindingSource;
        private AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter aST_GroupsTableAdapter;
        private System.Windows.Forms.Button CmdShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetStateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetSerialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDepreciationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDepsCurrentValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depreciationPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetStateTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSTLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSTGroupTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
    }
}