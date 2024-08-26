namespace TMS.AppForms.AdminWork.Config.HR.Rules
{
    partial class frmBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBonus));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.bonusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupBonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtBonusNameEn = new System.Windows.Forms.TextBox();
            this.txtBonusNameAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.chbByDay = new System.Windows.Forms.CheckBox();
            this.chbByAmount = new System.Windows.Forms.CheckBox();
            this.hR_Lup_BonusTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_BonusTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "المسمي (بالانجليزي)";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "المسمي (باللغه العربيه)";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(251, 116);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(136, 42);
            this.btnAddClose.TabIndex = 27;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(393, 116);
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
            this.lblMbox.Location = new System.Drawing.Point(37, 10);
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
            this.bonusIDDataGridViewTextBoxColumn,
            this.bonusNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupBonusBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 164);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(688, 218);
            this.gvForm.TabIndex = 30;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // bonusIDDataGridViewTextBoxColumn
            // 
            this.bonusIDDataGridViewTextBoxColumn.DataPropertyName = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.HeaderText = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.Name = "bonusIDDataGridViewTextBoxColumn";
            this.bonusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bonusNameArDataGridViewTextBoxColumn
            // 
            this.bonusNameArDataGridViewTextBoxColumn.DataPropertyName = "BonusNameAr";
            this.bonusNameArDataGridViewTextBoxColumn.HeaderText = "الاسم (عربي)";
            this.bonusNameArDataGridViewTextBoxColumn.Name = "bonusNameArDataGridViewTextBoxColumn";
            this.bonusNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupBonusBindingSource
            // 
            this.hRLupBonusBindingSource.DataMember = "HR_Lup_Bonus";
            this.hRLupBonusBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBonusNameEn
            // 
            this.txtBonusNameEn.Location = new System.Drawing.Point(335, 80);
            this.txtBonusNameEn.Name = "txtBonusNameEn";
            this.txtBonusNameEn.Size = new System.Drawing.Size(194, 24);
            this.txtBonusNameEn.TabIndex = 25;
            this.txtBonusNameEn.Visible = false;
            // 
            // txtBonusNameAr
            // 
            this.txtBonusNameAr.Location = new System.Drawing.Point(335, 44);
            this.txtBonusNameAr.Name = "txtBonusNameAr";
            this.txtBonusNameAr.Size = new System.Drawing.Size(194, 24);
            this.txtBonusNameAr.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "القيمة";
            this.label1.Visible = false;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(108, 44);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(145, 24);
            this.txtValue.TabIndex = 34;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.Visible = false;
            // 
            // chbByDay
            // 
            this.chbByDay.AutoSize = true;
            this.chbByDay.Location = new System.Drawing.Point(189, 82);
            this.chbByDay.Name = "chbByDay";
            this.chbByDay.Size = new System.Drawing.Size(123, 21);
            this.chbByDay.TabIndex = 35;
            this.chbByDay.Text = "حسب عدد الايام";
            this.chbByDay.UseVisualStyleBackColor = true;
            this.chbByDay.Visible = false;
            // 
            // chbByAmount
            // 
            this.chbByAmount.AutoSize = true;
            this.chbByAmount.Location = new System.Drawing.Point(53, 82);
            this.chbByAmount.Name = "chbByAmount";
            this.chbByAmount.Size = new System.Drawing.Size(104, 21);
            this.chbByAmount.TabIndex = 36;
            this.chbByAmount.Text = "حسب القيمة";
            this.chbByAmount.UseVisualStyleBackColor = true;
            this.chbByAmount.Visible = false;
            // 
            // hR_Lup_BonusTableAdapter
            // 
            this.hR_Lup_BonusTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(712, 394);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // frmBonus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.chbByAmount);
            this.Controls.Add(this.chbByDay);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtBonusNameEn);
            this.Controls.Add(this.txtBonusNameAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBonus";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المكافات";
            this.Load += new System.EventHandler(this.frmBonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtBonusNameEn;
        private System.Windows.Forms.TextBox txtBonusNameAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox chbByDay;
        private System.Windows.Forms.CheckBox chbByAmount;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupBonusBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_BonusTableAdapter hR_Lup_BonusTableAdapter;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusNameArDataGridViewTextBoxColumn;
    }
}