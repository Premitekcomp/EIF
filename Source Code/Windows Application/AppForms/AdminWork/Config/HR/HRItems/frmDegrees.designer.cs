namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmDegrees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDegrees));
            this.cbEmpGroupID = new System.Windows.Forms.ComboBox();
            this.hRLupEmplymentGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.degreeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupDegreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDegreeNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegreeNameEn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hR_Lup_DegreesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DegreesTableAdapter();
            this.hR_Lup_EmplymentGroupTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDegreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpGroupID
            // 
            this.cbEmpGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmpGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpGroupID.DataSource = this.hRLupEmplymentGroupBindingSource;
            this.cbEmpGroupID.DisplayMember = "EmpGroupTitleAr";
            this.cbEmpGroupID.FormattingEnabled = true;
            this.cbEmpGroupID.Location = new System.Drawing.Point(357, 36);
            this.cbEmpGroupID.Name = "cbEmpGroupID";
            this.cbEmpGroupID.Size = new System.Drawing.Size(194, 25);
            this.cbEmpGroupID.TabIndex = 22;
            this.cbEmpGroupID.ValueMember = "EmpGroupID";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "مجموعة الدرجة";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(273, 111);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 27;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(415, 111);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 26;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(22, 13);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 31;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeIDDataGridViewTextBoxColumn,
            this.degreeNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupDegreesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 159);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(674, 218);
            this.gvForm.TabIndex = 30;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // degreeIDDataGridViewTextBoxColumn
            // 
            this.degreeIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn.HeaderText = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn.Name = "degreeIDDataGridViewTextBoxColumn";
            this.degreeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // degreeNameArDataGridViewTextBoxColumn
            // 
            this.degreeNameArDataGridViewTextBoxColumn.DataPropertyName = "DegreeNameAr";
            this.degreeNameArDataGridViewTextBoxColumn.HeaderText = "اسم الدرجة العلمية";
            this.degreeNameArDataGridViewTextBoxColumn.Name = "degreeNameArDataGridViewTextBoxColumn";
            this.degreeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupDegreesBindingSource
            // 
            this.hRLupDegreesBindingSource.DataMember = "HR_Lup_Degrees";
            this.hRLupDegreesBindingSource.DataSource = this.lupDataSet;
            // 
            // txtDegreeNameAr
            // 
            this.txtDegreeNameAr.Location = new System.Drawing.Point(357, 67);
            this.txtDegreeNameAr.Name = "txtDegreeNameAr";
            this.txtDegreeNameAr.Size = new System.Drawing.Size(194, 24);
            this.txtDegreeNameAr.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // txtDegreeNameEn
            // 
            this.txtDegreeNameEn.Location = new System.Drawing.Point(9, 67);
            this.txtDegreeNameEn.Name = "txtDegreeNameEn";
            this.txtDegreeNameEn.Size = new System.Drawing.Size(194, 24);
            this.txtDegreeNameEn.TabIndex = 25;
            this.txtDegreeNameEn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "الاسم بالغة الانجليزية";
            this.label2.Visible = false;
            // 
            // hR_Lup_DegreesTableAdapter
            // 
            this.hR_Lup_DegreesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_EmplymentGroupTableAdapter
            // 
            this.hR_Lup_EmplymentGroupTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(698, 384);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmDegrees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(698, 384);
            this.Controls.Add(this.cbEmpGroupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtDegreeNameEn);
            this.Controls.Add(this.txtDegreeNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDegrees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدرجات الوظيفية و العلمية";
            this.Load += new System.EventHandler(this.frmDegrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEmplymentGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDegreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtDegreeNameAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDegreeNameEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hRLupDegreesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DegreesTableAdapter hR_Lup_DegreesTableAdapter;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupEmplymentGroupBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EmplymentGroupTableAdapter hR_Lup_EmplymentGroupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;

    }
}