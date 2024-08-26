namespace TMS.AppForms.AdminWork.Config.HR.Rules
{
    partial class frmDeductions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeductions));
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.deductionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupDeductionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtDeductionNameEn = new System.Windows.Forms.TextBox();
            this.txtDeductionNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbIsMonthly = new System.Windows.Forms.CheckBox();
            this.chbInTax = new System.Windows.Forms.CheckBox();
            this.chbInInsurance = new System.Windows.Forms.CheckBox();
            this.hR_Lup_DeductionsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DeductionsTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDeductionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(290, 103);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 27;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(440, 103);
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
            this.lblMbox.Location = new System.Drawing.Point(22, 9);
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
            this.deductionIDDataGridViewTextBoxColumn,
            this.deductionNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupDeductionsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(15, 151);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(692, 218);
            this.gvForm.TabIndex = 30;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // deductionIDDataGridViewTextBoxColumn
            // 
            this.deductionIDDataGridViewTextBoxColumn.DataPropertyName = "DeductionID";
            this.deductionIDDataGridViewTextBoxColumn.HeaderText = "DeductionID";
            this.deductionIDDataGridViewTextBoxColumn.Name = "deductionIDDataGridViewTextBoxColumn";
            this.deductionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // deductionNameArDataGridViewTextBoxColumn
            // 
            this.deductionNameArDataGridViewTextBoxColumn.DataPropertyName = "DeductionNameAr";
            this.deductionNameArDataGridViewTextBoxColumn.HeaderText = "اسم الاستقطاع";
            this.deductionNameArDataGridViewTextBoxColumn.Name = "deductionNameArDataGridViewTextBoxColumn";
            this.deductionNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupDeductionsBindingSource
            // 
            this.hRLupDeductionsBindingSource.DataMember = "HR_Lup_Deductions";
            this.hRLupDeductionsBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDeductionNameEn
            // 
            this.txtDeductionNameEn.Location = new System.Drawing.Point(382, 57);
            this.txtDeductionNameEn.Name = "txtDeductionNameEn";
            this.txtDeductionNameEn.Size = new System.Drawing.Size(194, 24);
            this.txtDeductionNameEn.TabIndex = 25;
            this.txtDeductionNameEn.Visible = false;
            // 
            // txtDeductionNameAr
            // 
            this.txtDeductionNameAr.Location = new System.Drawing.Point(382, 27);
            this.txtDeductionNameAr.Name = "txtDeductionNameAr";
            this.txtDeductionNameAr.Size = new System.Drawing.Size(194, 24);
            this.txtDeductionNameAr.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "الاسم بالغة الانجليزية";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(110, 61);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(119, 24);
            this.txtValue.TabIndex = 32;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "القيمة";
            this.label3.Visible = false;
            // 
            // chbIsMonthly
            // 
            this.chbIsMonthly.AutoSize = true;
            this.chbIsMonthly.Checked = true;
            this.chbIsMonthly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsMonthly.Location = new System.Drawing.Point(290, 30);
            this.chbIsMonthly.Name = "chbIsMonthly";
            this.chbIsMonthly.Size = new System.Drawing.Size(67, 21);
            this.chbIsMonthly.TabIndex = 34;
            this.chbIsMonthly.Text = "شهرى";
            this.chbIsMonthly.UseVisualStyleBackColor = true;
            this.chbIsMonthly.Visible = false;
            // 
            // chbInTax
            // 
            this.chbInTax.AutoSize = true;
            this.chbInTax.Location = new System.Drawing.Point(196, 30);
            this.chbInTax.Name = "chbInTax";
            this.chbInTax.Size = new System.Drawing.Size(61, 21);
            this.chbInTax.TabIndex = 35;
            this.chbInTax.Text = "ضريبة";
            this.chbInTax.UseVisualStyleBackColor = true;
            this.chbInTax.Visible = false;
            // 
            // chbInInsurance
            // 
            this.chbInInsurance.AutoSize = true;
            this.chbInInsurance.Location = new System.Drawing.Point(95, 30);
            this.chbInInsurance.Name = "chbInInsurance";
            this.chbInInsurance.Size = new System.Drawing.Size(67, 21);
            this.chbInInsurance.TabIndex = 36;
            this.chbInInsurance.Text = "تامينات";
            this.chbInInsurance.UseVisualStyleBackColor = true;
            this.chbInInsurance.Visible = false;
            // 
            // hR_Lup_DeductionsTableAdapter
            // 
            this.hR_Lup_DeductionsTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(719, 379);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmDeductions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(719, 379);
            this.Controls.Add(this.chbInInsurance);
            this.Controls.Add(this.chbInTax);
            this.Controls.Add(this.chbIsMonthly);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtDeductionNameEn);
            this.Controls.Add(this.txtDeductionNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDeductions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استقطاعات";
            this.Load += new System.EventHandler(this.frmDeductions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDeductionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtDeductionNameEn;
        private System.Windows.Forms.TextBox txtDeductionNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbIsMonthly;
        private System.Windows.Forms.CheckBox chbInTax;
        private System.Windows.Forms.CheckBox chbInInsurance;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupDeductionsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DeductionsTableAdapter hR_Lup_DeductionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionNameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}