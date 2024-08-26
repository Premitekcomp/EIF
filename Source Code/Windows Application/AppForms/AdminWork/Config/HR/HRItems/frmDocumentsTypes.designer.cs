namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmDocumentsTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentsTypes));
            this.lblMbox = new System.Windows.Forms.Label();
            this.txtDocumentTypeNameEn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.documentTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupDocumentsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtDocumentTypeNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_DocumentsTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DocumentsTypesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDocumentsTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(14, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 34;
            // 
            // txtDocumentTypeNameEn
            // 
            this.txtDocumentTypeNameEn.Location = new System.Drawing.Point(343, 66);
            this.txtDocumentTypeNameEn.Name = "txtDocumentTypeNameEn";
            this.txtDocumentTypeNameEn.Size = new System.Drawing.Size(218, 24);
            this.txtDocumentTypeNameEn.TabIndex = 33;
            this.txtDocumentTypeNameEn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "الاسم بالغة الانجليزية";
            this.label2.Visible = false;
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(283, 96);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 31;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(425, 96);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 30;
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
            this.documentTypeIDDataGridViewTextBoxColumn,
            this.documentTypeNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupDocumentsTypesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(14, 144);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(696, 199);
            this.gvForm.TabIndex = 29;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // documentTypeIDDataGridViewTextBoxColumn
            // 
            this.documentTypeIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeID";
            this.documentTypeIDDataGridViewTextBoxColumn.HeaderText = "DocumentTypeID";
            this.documentTypeIDDataGridViewTextBoxColumn.Name = "documentTypeIDDataGridViewTextBoxColumn";
            this.documentTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentTypeNameArDataGridViewTextBoxColumn
            // 
            this.documentTypeNameArDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeNameAr";
            this.documentTypeNameArDataGridViewTextBoxColumn.HeaderText = "انوع المستندات";
            this.documentTypeNameArDataGridViewTextBoxColumn.Name = "documentTypeNameArDataGridViewTextBoxColumn";
            this.documentTypeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupDocumentsTypesBindingSource
            // 
            this.hRLupDocumentsTypesBindingSource.DataMember = "HR_Lup_DocumentsTypes";
            this.hRLupDocumentsTypesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDocumentTypeNameAr
            // 
            this.txtDocumentTypeNameAr.Location = new System.Drawing.Point(343, 36);
            this.txtDocumentTypeNameAr.Name = "txtDocumentTypeNameAr";
            this.txtDocumentTypeNameAr.Size = new System.Drawing.Size(218, 24);
            this.txtDocumentTypeNameAr.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // hR_Lup_DocumentsTypesTableAdapter
            // 
            this.hR_Lup_DocumentsTypesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(723, 352);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmDocumentsTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 352);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.txtDocumentTypeNameEn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtDocumentTypeNameAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDocumentsTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انوع المستندات";
            this.Load += new System.EventHandler(this.frmDocumentsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDocumentsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.TextBox txtDocumentTypeNameEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtDocumentTypeNameAr;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupDocumentsTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DocumentsTypesTableAdapter hR_Lup_DocumentsTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeNameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}