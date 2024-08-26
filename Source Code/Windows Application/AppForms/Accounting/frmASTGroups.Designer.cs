namespace TMS.AppForms.Accounting
{
    partial class frmASTGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMSG = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtGroupDepreciationPercentage = new System.Windows.Forms.TextBox();
            this.txtASTGroupTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvList = new System.Windows.Forms.DataGridView();
            this.aSTGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSTGroupTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDepreciationPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aSTGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.aST_GroupsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SidePanel
            // 
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.Location = new System.Drawing.Point(576, 25);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(226, 458);
            this.SidePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMSG);
            this.panel1.Controls.Add(this.CmdSave);
            this.panel1.Controls.Add(this.txtGroupDepreciationPercentage);
            this.panel1.Controls.Add(this.txtASTGroupTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 175);
            this.panel1.TabIndex = 2;
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(12, 12);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 24);
            this.lblMSG.TabIndex = 5;
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.ForeColor = System.Drawing.Color.White;
            this.CmdSave.Location = new System.Drawing.Point(280, 122);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(130, 39);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtGroupDepreciationPercentage
            // 
            this.txtGroupDepreciationPercentage.Location = new System.Drawing.Point(301, 72);
            this.txtGroupDepreciationPercentage.Name = "txtGroupDepreciationPercentage";
            this.txtGroupDepreciationPercentage.Size = new System.Drawing.Size(109, 32);
            this.txtGroupDepreciationPercentage.TabIndex = 3;
            this.txtGroupDepreciationPercentage.Text = "0";
            this.txtGroupDepreciationPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupDepreciationPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // txtASTGroupTitle
            // 
            this.txtASTGroupTitle.Location = new System.Drawing.Point(76, 34);
            this.txtASTGroupTitle.Name = "txtASTGroupTitle";
            this.txtASTGroupTitle.Size = new System.Drawing.Size(334, 32);
            this.txtASTGroupTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "نسبة الاهلاك الإفتراضيه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم المجموعة:";
            // 
            // grvList
            // 
            this.grvList.AllowUserToAddRows = false;
            this.grvList.AllowUserToDeleteRows = false;
            this.grvList.AutoGenerateColumns = false;
            this.grvList.BackgroundColor = System.Drawing.Color.White;
            this.grvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aSTGroupIDDataGridViewTextBoxColumn,
            this.aSTGroupTitleDataGridViewTextBoxColumn,
            this.groupDepreciationPercentageDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.grvList.DataSource = this.aSTGroupsBindingSource;
            this.grvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvList.Location = new System.Drawing.Point(0, 200);
            this.grvList.Name = "grvList";
            this.grvList.RowTemplate.Height = 25;
            this.grvList.Size = new System.Drawing.Size(576, 283);
            this.grvList.TabIndex = 3;
            this.grvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvList_CellContentClick);
            // 
            // aSTGroupIDDataGridViewTextBoxColumn
            // 
            this.aSTGroupIDDataGridViewTextBoxColumn.DataPropertyName = "ASTGroupID";
            this.aSTGroupIDDataGridViewTextBoxColumn.HeaderText = "ASTGroupID";
            this.aSTGroupIDDataGridViewTextBoxColumn.Name = "aSTGroupIDDataGridViewTextBoxColumn";
            this.aSTGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSTGroupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aSTGroupTitleDataGridViewTextBoxColumn
            // 
            this.aSTGroupTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aSTGroupTitleDataGridViewTextBoxColumn.DataPropertyName = "ASTGroupTitle";
            this.aSTGroupTitleDataGridViewTextBoxColumn.HeaderText = "أسم المجموعة";
            this.aSTGroupTitleDataGridViewTextBoxColumn.Name = "aSTGroupTitleDataGridViewTextBoxColumn";
            // 
            // groupDepreciationPercentageDataGridViewTextBoxColumn
            // 
            this.groupDepreciationPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.groupDepreciationPercentageDataGridViewTextBoxColumn.DataPropertyName = "GroupDepreciationPercentage";
            this.groupDepreciationPercentageDataGridViewTextBoxColumn.HeaderText = "نسبة الاهلاك الافتراضيه";
            this.groupDepreciationPercentageDataGridViewTextBoxColumn.Name = "groupDepreciationPercentageDataGridViewTextBoxColumn";
            this.groupDepreciationPercentageDataGridViewTextBoxColumn.Width = 163;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "حفظ التعديل";
            this.Column1.Name = "Column1";
            this.Column1.Text = "حفظ";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "حذف";
            this.Column2.Name = "Column2";
            this.Column2.Text = "X";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 42;
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
            // aST_GroupsTableAdapter
            // 
            this.aST_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmASTGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 483);
            this.Controls.Add(this.grvList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmASTGroups";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مجموعات الاصول";
            this.Load += new System.EventHandler(this.frmASTGroups_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupDepreciationPercentage;
        private System.Windows.Forms.TextBox txtASTGroupTitle;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.DataGridView grvList;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aSTGroupsBindingSource;
        private AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter aST_GroupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSTGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSTGroupTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDepreciationPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}