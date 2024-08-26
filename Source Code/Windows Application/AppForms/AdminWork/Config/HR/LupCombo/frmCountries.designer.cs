namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmCountries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountries));
            this.lblMbox = new System.Windows.Forms.Label();
            this.txtNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalityTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCallKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hR_Lup_CountriesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(34, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 34;
            // 
            // txtNameAr
            // 
            this.txtNameAr.Location = new System.Drawing.Point(412, 59);
            this.txtNameAr.Name = "txtNameAr";
            this.txtNameAr.Size = new System.Drawing.Size(218, 24);
            this.txtNameAr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "الأسم انجليزي";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(352, 151);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 7;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(494, 151);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 42);
            this.btnAddNew.TabIndex = 6;
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
            this.countryIDDataGridViewTextBoxColumn,
            this.nameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupCountriesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(13, 199);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(722, 199);
            this.gvForm.TabIndex = 29;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameArDataGridViewTextBoxColumn
            // 
            this.nameArDataGridViewTextBoxColumn.DataPropertyName = "NameAr";
            this.nameArDataGridViewTextBoxColumn.HeaderText = "اسم الدولة";
            this.nameArDataGridViewTextBoxColumn.Name = "nameArDataGridViewTextBoxColumn";
            this.nameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupCountriesBindingSource
            // 
            this.hRLupCountriesBindingSource.DataMember = "HR_Lup_Countries";
            this.hRLupCountriesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(545, 29);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(85, 24);
            this.txtInitial.TabIndex = 1;
            this.txtInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "حروف أولية";
            // 
            // txtNationalityTitle
            // 
            this.txtNationalityTitle.Location = new System.Drawing.Point(412, 91);
            this.txtNationalityTitle.Name = "txtNationalityTitle";
            this.txtNationalityTitle.Size = new System.Drawing.Size(218, 24);
            this.txtNationalityTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "الجنيسة";
            // 
            // txtNameEn
            // 
            this.txtNameEn.Location = new System.Drawing.Point(43, 59);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(218, 24);
            this.txtNameEn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "الأسم عربي";
            // 
            // txtCallKey
            // 
            this.txtCallKey.Location = new System.Drawing.Point(531, 121);
            this.txtCallKey.Name = "txtCallKey";
            this.txtCallKey.Size = new System.Drawing.Size(99, 24);
            this.txtCallKey.TabIndex = 5;
            this.txtCallKey.Text = "0";
            this.txtCallKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "مفتاح الاتصال ";
            // 
            // hR_Lup_CountriesTableAdapter
            // 
            this.hR_Lup_CountriesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(746, 403);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmCountries
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(746, 403);
            this.Controls.Add(this.txtCallKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNationalityTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.txtNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCountries";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أسماء الدول";
            this.Load += new System.EventHandler(this.frmCountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.TextBox txtNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationalityTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCallKey;
        private System.Windows.Forms.Label label5;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupCountriesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_CountriesTableAdapter hR_Lup_CountriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}