namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.areaRecordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.txtNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcountry = new System.Windows.Forms.ComboBox();
            this.hRLupCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.hRLupCitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.hR_Lup_CountriesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter();
            this.hR_Lup_CitesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CitesTableAdapter();
            this.hR_Lup_AreasTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AreasTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.hR_Lup_Areas1TableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Areas1TableAdapter();
            this.hR_Lup_Cites1TableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Cites1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAreasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(327, 100);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(100, 42);
            this.btnAddClose.TabIndex = 5;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(433, 100);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 42);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(25, 10);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 16;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaRecordIDDataGridViewTextBoxColumn,
            this.nameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupAreasBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 148);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(625, 218);
            this.gvForm.TabIndex = 15;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // areaRecordIDDataGridViewTextBoxColumn
            // 
            this.areaRecordIDDataGridViewTextBoxColumn.DataPropertyName = "AreaRecordID";
            this.areaRecordIDDataGridViewTextBoxColumn.HeaderText = "AreaRecordID";
            this.areaRecordIDDataGridViewTextBoxColumn.Name = "areaRecordIDDataGridViewTextBoxColumn";
            this.areaRecordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaRecordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameArDataGridViewTextBoxColumn
            // 
            this.nameArDataGridViewTextBoxColumn.DataPropertyName = "NameAr";
            this.nameArDataGridViewTextBoxColumn.HeaderText = "اسم المنطقة";
            this.nameArDataGridViewTextBoxColumn.Name = "nameArDataGridViewTextBoxColumn";
            this.nameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupAreasBindingSource
            // 
            this.hRLupAreasBindingSource.DataMember = "HR_Lup_Areas1";
            this.hRLupAreasBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNameEn
            // 
            this.txtNameEn.Location = new System.Drawing.Point(7, 70);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(194, 24);
            this.txtNameEn.TabIndex = 3;
            // 
            // txtNameAr
            // 
            this.txtNameAr.Location = new System.Drawing.Point(339, 70);
            this.txtNameAr.Name = "txtNameAr";
            this.txtNameAr.Size = new System.Drawing.Size(194, 24);
            this.txtNameAr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "الاسم (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "الاسم (عربي)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "الدولة";
            // 
            // cbcountry
            // 
            this.cbcountry.DataSource = this.hRLupCountriesBindingSource;
            this.cbcountry.DisplayMember = "NameAr";
            this.cbcountry.FormattingEnabled = true;
            this.cbcountry.Location = new System.Drawing.Point(339, 39);
            this.cbcountry.Name = "cbcountry";
            this.cbcountry.Size = new System.Drawing.Size(194, 25);
            this.cbcountry.TabIndex = 0;
            this.cbcountry.ValueMember = "CountryID";
            this.cbcountry.SelectedIndexChanged += new System.EventHandler(this.cbcountry_SelectedIndexChanged);
            // 
            // hRLupCountriesBindingSource
            // 
            this.hRLupCountriesBindingSource.DataMember = "HR_Lup_Countries";
            this.hRLupCountriesBindingSource.DataSource = this.LupDataSet;
            // 
            // cbCity
            // 
            this.cbCity.DataSource = this.hRLupCitesBindingSource;
            this.cbCity.DisplayMember = "NameAr";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(7, 39);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(194, 25);
            this.cbCity.TabIndex = 1;
            this.cbCity.ValueMember = "CityRecordID";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // hRLupCitesBindingSource
            // 
            this.hRLupCitesBindingSource.DataMember = "HR_Lup_Cites1";
            this.hRLupCitesBindingSource.DataSource = this.LupDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "المدينة";
            // 
            // hR_Lup_CountriesTableAdapter
            // 
            this.hR_Lup_CountriesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_CitesTableAdapter
            // 
            this.hR_Lup_CitesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_AreasTableAdapter
            // 
            this.hR_Lup_AreasTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(652, 377);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // hR_Lup_Areas1TableAdapter
            // 
            this.hR_Lup_Areas1TableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_Cites1TableAdapter
            // 
            this.hR_Lup_Cites1TableAdapter.ClearBeforeFill = true;
            // 
            // frmAreas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(652, 377);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbcountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtNameEn);
            this.Controls.Add(this.txtNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAreas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اسماء المناطق";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAreasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.TextBox txtNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label4;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupCountriesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter hR_Lup_CountriesTableAdapter;
        private System.Windows.Forms.BindingSource hRLupCitesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CitesTableAdapter hR_Lup_CitesTableAdapter;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupAreasBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AreasTableAdapter hR_Lup_AreasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaRecordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Areas1TableAdapter hR_Lup_Areas1TableAdapter;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_Cites1TableAdapter hR_Lup_Cites1TableAdapter;
    }
}