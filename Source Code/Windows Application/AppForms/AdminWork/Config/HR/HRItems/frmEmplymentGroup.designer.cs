namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmEmplymentGroup
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
            this.lblMbox = new System.Windows.Forms.Label();
            this.txtEmpGroupTitleEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.empGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGroupTitleArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtEmpGroupTitleAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            this.CmdGroupMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(37, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 34;
            // 
            // txtEmpGroupTitleEN
            // 
            this.txtEmpGroupTitleEN.Location = new System.Drawing.Point(332, 60);
            this.txtEmpGroupTitleEN.Name = "txtEmpGroupTitleEN";
            this.txtEmpGroupTitleEN.Size = new System.Drawing.Size(218, 24);
            this.txtEmpGroupTitleEN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "الاسم بالغة الانجليزية";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(272, 96);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 4;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(414, 96);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empGroupIDDataGridViewTextBoxColumn,
            this.empGroupTitleArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 144);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(696, 199);
            this.gvForm.TabIndex = 29;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // empGroupIDDataGridViewTextBoxColumn
            // 
            this.empGroupIDDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupID";
            this.empGroupIDDataGridViewTextBoxColumn.HeaderText = "EmpGroupID";
            this.empGroupIDDataGridViewTextBoxColumn.Name = "empGroupIDDataGridViewTextBoxColumn";
            this.empGroupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empGroupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empGroupTitleArDataGridViewTextBoxColumn
            // 
            this.empGroupTitleArDataGridViewTextBoxColumn.DataPropertyName = "EmpGroupTitleAr";
            this.empGroupTitleArDataGridViewTextBoxColumn.HeaderText = "اسم المجموعة بالغة العربية";
            this.empGroupTitleArDataGridViewTextBoxColumn.Name = "empGroupTitleArDataGridViewTextBoxColumn";
            this.empGroupTitleArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupEmplymentGroupBindingSource
            // 
            this.hRLupEmplymentGroupBindingSource.DataMember = "HR_Lup_EmplymentGroup";
            this.hRLupEmplymentGroupBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmpGroupTitleAr
            // 
            this.txtEmpGroupTitleAr.Location = new System.Drawing.Point(332, 30);
            this.txtEmpGroupTitleAr.Name = "txtEmpGroupTitleAr";
            this.txtEmpGroupTitleAr.Size = new System.Drawing.Size(218, 24);
            this.txtEmpGroupTitleAr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // hR_Lup_EmplymentGroupTableAdapter
            // 
            this.hR_Lup_EmplymentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // CmdGroupMembers
            // 
            this.CmdGroupMembers.Location = new System.Drawing.Point(130, 96);
            this.CmdGroupMembers.Name = "CmdGroupMembers";
            this.CmdGroupMembers.Size = new System.Drawing.Size(136, 42);
            this.CmdGroupMembers.TabIndex = 74;
            this.CmdGroupMembers.Text = "اعضاء المجموعه";
            this.CmdGroupMembers.UseVisualStyleBackColor = true;
            this.CmdGroupMembers.Click += new System.EventHandler(this.CmdGroupMembers_Click);
            // 
            // frmEmplymentGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 351);
            this.Controls.Add(this.CmdGroupMembers);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.txtEmpGroupTitleEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtEmpGroupTitleAr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEmplymentGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الموظفين";
            this.Load += new System.EventHandler(this.frmEmplymentGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.TextBox txtEmpGroupTitleEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtEmpGroupTitleAr;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGroupTitleArDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdGroupMembers;

    }
}