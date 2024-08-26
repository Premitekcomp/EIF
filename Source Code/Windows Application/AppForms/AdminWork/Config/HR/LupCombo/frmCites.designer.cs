namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmCites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCites));
            this.txtCallKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.cityRecordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupCitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.txtNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCountryID = new System.Windows.Forms.ComboBox();
            this.hRLupCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_CountriesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter();
            this.hR_Lup_CitesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CitesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.hR_Lup_Cites1TableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Cites1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCallKey
            // 
            this.txtCallKey.Location = new System.Drawing.Point(520, 120);
            this.txtCallKey.Name = "txtCallKey";
            this.txtCallKey.Size = new System.Drawing.Size(88, 24);
            this.txtCallKey.TabIndex = 45;
            this.txtCallKey.Text = "0";
            this.txtCallKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "اسم المدينة بالغة الانجليزية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "اسم المدينة (عربي)";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(12, 139);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 39;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(154, 139);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 38;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(32, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 42;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityRecordIDDataGridViewTextBoxColumn,
            this.nameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupCitesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 187);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(728, 218);
            this.gvForm.TabIndex = 41;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // cityRecordIDDataGridViewTextBoxColumn
            // 
            this.cityRecordIDDataGridViewTextBoxColumn.DataPropertyName = "CityRecordID";
            this.cityRecordIDDataGridViewTextBoxColumn.HeaderText = "CityRecordID";
            this.cityRecordIDDataGridViewTextBoxColumn.Name = "cityRecordIDDataGridViewTextBoxColumn";
            this.cityRecordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityRecordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameArDataGridViewTextBoxColumn
            // 
            this.nameArDataGridViewTextBoxColumn.DataPropertyName = "NameAr";
            this.nameArDataGridViewTextBoxColumn.HeaderText = "اسم المدينة بالغة العربية";
            this.nameArDataGridViewTextBoxColumn.Name = "nameArDataGridViewTextBoxColumn";
            this.nameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupCitesBindingSource
            // 
            this.hRLupCitesBindingSource.DataMember = "HR_Lup_Cites1";
            this.hRLupCitesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNameEn
            // 
            this.txtNameEn.Location = new System.Drawing.Point(12, 90);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(194, 24);
            this.txtNameEn.TabIndex = 37;
            // 
            // txtNameAr
            // 
            this.txtNameAr.Location = new System.Drawing.Point(414, 90);
            this.txtNameAr.Name = "txtNameAr";
            this.txtNameAr.Size = new System.Drawing.Size(194, 24);
            this.txtNameAr.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "كود الاتصال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "اسم الدولة";
            // 
            // cbCountryID
            // 
            this.cbCountryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCountryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountryID.DataSource = this.hRLupCountriesBindingSource;
            this.cbCountryID.DisplayMember = "NameAr";
            this.cbCountryID.FormattingEnabled = true;
            this.cbCountryID.Location = new System.Drawing.Point(414, 59);
            this.cbCountryID.Name = "cbCountryID";
            this.cbCountryID.Size = new System.Drawing.Size(194, 25);
            this.cbCountryID.TabIndex = 48;
            this.cbCountryID.ValueMember = "CountryID";
            this.cbCountryID.SelectedIndexChanged += new System.EventHandler(this.cbCountryID_SelectedIndexChanged);
            // 
            // hRLupCountriesBindingSource
            // 
            this.hRLupCountriesBindingSource.DataMember = "HR_Lup_Countries";
            this.hRLupCountriesBindingSource.DataSource = this.LupDataSet;
            // 
            // hR_Lup_CountriesTableAdapter
            // 
            this.hR_Lup_CountriesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_CitesTableAdapter
            // 
            this.hR_Lup_CitesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(752, 417);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // hR_Lup_Cites1TableAdapter
            // 
            this.hR_Lup_Cites1TableAdapter.ClearBeforeFill = true;
            // 
            // frmCites
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(752, 417);
            this.Controls.Add(this.cbCountryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCallKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtNameEn);
            this.Controls.Add(this.txtNameAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCites";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أسماء المدن";
            this.Load += new System.EventHandler(this.frmCites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCallKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.TextBox txtNameAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCountryID;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupCountriesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter hR_Lup_CountriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityRecordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hRLupCitesBindingSource;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CitesTableAdapter hR_Lup_CitesTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Cites1TableAdapter hR_Lup_Cites1TableAdapter;
    }
}