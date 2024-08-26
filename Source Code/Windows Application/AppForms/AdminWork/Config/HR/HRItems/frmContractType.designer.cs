namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmContractType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractType));
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.hRLupContractTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtContractNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContractNameEn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMbox = new System.Windows.Forms.Label();
            this.hR_Lup_ContractTypeTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_ContractTypeTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.stateNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupContractTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(263, 98);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 23;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(405, 98);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 22;
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
            this.stateNameArDataGridViewTextBoxColumn,
            this.stateIDDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupContractTypeBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 146);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(696, 199);
            this.gvForm.TabIndex = 21;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // hRLupContractTypeBindingSource
            // 
            this.hRLupContractTypeBindingSource.DataMember = "HR_Lup_ContractType";
            this.hRLupContractTypeBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtContractNameAr
            // 
            this.txtContractNameAr.Location = new System.Drawing.Point(323, 29);
            this.txtContractNameAr.Name = "txtContractNameAr";
            this.txtContractNameAr.Size = new System.Drawing.Size(218, 24);
            this.txtContractNameAr.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // txtContractNameEn
            // 
            this.txtContractNameEn.Location = new System.Drawing.Point(323, 59);
            this.txtContractNameEn.Name = "txtContractNameEn";
            this.txtContractNameEn.Size = new System.Drawing.Size(218, 24);
            this.txtContractNameEn.TabIndex = 25;
            this.txtContractNameEn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "الاسم بالغة الانجليزية";
            this.label2.Visible = false;
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(25, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 26;
            // 
            // hR_Lup_ContractTypeTableAdapter
            // 
            this.hR_Lup_ContractTypeTableAdapter.ClearBeforeFill = true;
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
            // stateNameArDataGridViewTextBoxColumn
            // 
            this.stateNameArDataGridViewTextBoxColumn.DataPropertyName = "StateNameAr";
            this.stateNameArDataGridViewTextBoxColumn.HeaderText = "نوع التعاقد";
            this.stateNameArDataGridViewTextBoxColumn.Name = "stateNameArDataGridViewTextBoxColumn";
            this.stateNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateIDDataGridViewTextBoxColumn
            // 
            this.stateIDDataGridViewTextBoxColumn.DataPropertyName = "StateID";
            this.stateIDDataGridViewTextBoxColumn.HeaderText = "StateID";
            this.stateIDDataGridViewTextBoxColumn.Name = "stateIDDataGridViewTextBoxColumn";
            this.stateIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmContractType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 352);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.txtContractNameEn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtContractNameAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmContractType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انواع العقود";
            this.Load += new System.EventHandler(this.frmContractType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupContractTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtContractNameAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContractNameEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMbox;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupContractTypeBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_ContractTypeTableAdapter hR_Lup_ContractTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contarctTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIDDataGridViewTextBoxColumn;
    }
}