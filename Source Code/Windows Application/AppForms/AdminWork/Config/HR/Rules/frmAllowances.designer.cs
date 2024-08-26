namespace TMS.AppForms.AdminWork.Config.HR.Rules
{
    partial class frmAllowances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllowances));
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.allowanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupAllowancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtAllowanceNameEn = new System.Windows.Forms.TextBox();
            this.txtAllowanceNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbIsMonthly = new System.Windows.Forms.CheckBox();
            this.chbInTax = new System.Windows.Forms.CheckBox();
            this.chbInPenalty = new System.Windows.Forms.CheckBox();
            this.chbInInsurance = new System.Windows.Forms.CheckBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hR_Lup_AllowancesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AllowancesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAllowancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(323, 108);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(117, 42);
            this.btnAddClose.TabIndex = 18;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(446, 108);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(117, 42);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(40, 9);
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
            this.allowanceIDDataGridViewTextBoxColumn,
            this.allowanceNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupAllowancesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 167);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(720, 199);
            this.gvForm.TabIndex = 15;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // allowanceIDDataGridViewTextBoxColumn
            // 
            this.allowanceIDDataGridViewTextBoxColumn.DataPropertyName = "AllowanceID";
            this.allowanceIDDataGridViewTextBoxColumn.HeaderText = "رقم التسلسل";
            this.allowanceIDDataGridViewTextBoxColumn.Name = "allowanceIDDataGridViewTextBoxColumn";
            this.allowanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.allowanceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // allowanceNameArDataGridViewTextBoxColumn
            // 
            this.allowanceNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allowanceNameArDataGridViewTextBoxColumn.DataPropertyName = "AllowanceNameAr";
            this.allowanceNameArDataGridViewTextBoxColumn.HeaderText = "اسم البدل";
            this.allowanceNameArDataGridViewTextBoxColumn.Name = "allowanceNameArDataGridViewTextBoxColumn";
            this.allowanceNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupAllowancesBindingSource
            // 
            this.hRLupAllowancesBindingSource.DataMember = "HR_Lup_Allowances";
            this.hRLupAllowancesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAllowanceNameEn
            // 
            this.txtAllowanceNameEn.Location = new System.Drawing.Point(345, 72);
            this.txtAllowanceNameEn.Name = "txtAllowanceNameEn";
            this.txtAllowanceNameEn.Size = new System.Drawing.Size(218, 24);
            this.txtAllowanceNameEn.TabIndex = 14;
            this.txtAllowanceNameEn.Visible = false;
            // 
            // txtAllowanceNameAr
            // 
            this.txtAllowanceNameAr.Location = new System.Drawing.Point(345, 42);
            this.txtAllowanceNameAr.Name = "txtAllowanceNameAr";
            this.txtAllowanceNameAr.Size = new System.Drawing.Size(218, 24);
            this.txtAllowanceNameAr.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "اسم البدل بالغة الانجليزية";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم البدل بالغة العربية";
            // 
            // chbIsMonthly
            // 
            this.chbIsMonthly.AutoSize = true;
            this.chbIsMonthly.Checked = true;
            this.chbIsMonthly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsMonthly.Location = new System.Drawing.Point(237, 41);
            this.chbIsMonthly.Name = "chbIsMonthly";
            this.chbIsMonthly.Size = new System.Drawing.Size(63, 21);
            this.chbIsMonthly.TabIndex = 19;
            this.chbIsMonthly.Text = "شهريا";
            this.chbIsMonthly.UseVisualStyleBackColor = true;
            this.chbIsMonthly.Visible = false;
            // 
            // chbInTax
            // 
            this.chbInTax.AutoSize = true;
            this.chbInTax.Location = new System.Drawing.Point(170, 41);
            this.chbInTax.Name = "chbInTax";
            this.chbInTax.Size = new System.Drawing.Size(61, 21);
            this.chbInTax.TabIndex = 20;
            this.chbInTax.Text = "ضريبة";
            this.chbInTax.UseVisualStyleBackColor = true;
            this.chbInTax.Visible = false;
            // 
            // chbInPenalty
            // 
            this.chbInPenalty.AutoSize = true;
            this.chbInPenalty.Location = new System.Drawing.Point(104, 41);
            this.chbInPenalty.Name = "chbInPenalty";
            this.chbInPenalty.Size = new System.Drawing.Size(60, 21);
            this.chbInPenalty.TabIndex = 22;
            this.chbInPenalty.Text = "عقوبة";
            this.chbInPenalty.UseVisualStyleBackColor = true;
            this.chbInPenalty.Visible = false;
            // 
            // chbInInsurance
            // 
            this.chbInInsurance.AutoSize = true;
            this.chbInInsurance.Location = new System.Drawing.Point(40, 41);
            this.chbInInsurance.Name = "chbInInsurance";
            this.chbInInsurance.Size = new System.Drawing.Size(58, 21);
            this.chbInInsurance.TabIndex = 21;
            this.chbInInsurance.Text = "تأمين";
            this.chbInInsurance.UseVisualStyleBackColor = true;
            this.chbInInsurance.Visible = false;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(40, 78);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(130, 24);
            this.txtValue.TabIndex = 24;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.Visible = false;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "قيمة البدل";
            this.label3.Visible = false;
            // 
            // hR_Lup_AllowancesTableAdapter
            // 
            this.hR_Lup_AllowancesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(744, 380);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // frmAllowances
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(744, 380);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbInPenalty);
            this.Controls.Add(this.chbInInsurance);
            this.Controls.Add(this.chbInTax);
            this.Controls.Add(this.chbIsMonthly);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtAllowanceNameEn);
            this.Controls.Add(this.txtAllowanceNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAllowances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انواع البدلات";
            this.Load += new System.EventHandler(this.frmAllowances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAllowancesBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtAllowanceNameEn;
        private System.Windows.Forms.TextBox txtAllowanceNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbIsMonthly;
        private System.Windows.Forms.CheckBox chbInTax;
        private System.Windows.Forms.CheckBox chbInPenalty;
        private System.Windows.Forms.CheckBox chbInInsurance;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupAllowancesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AllowancesTableAdapter hR_Lup_AllowancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceNameArDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}