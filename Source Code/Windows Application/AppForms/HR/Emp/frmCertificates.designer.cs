namespace TMS.AppForms.HR.Emp
{
    partial class frmCertificates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificates));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.gridEmpCertificatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCertificateNameAr = new System.Windows.Forms.TextBox();
            this.txtCertificateNameEn = new System.Windows.Forms.TextBox();
            this.dtCertificateDate = new System.Windows.Forms.DateTimePicker();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.grid_Emp_CertificatesTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_CertificatesTableAdapter();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpCertificatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.empNameARDataGridViewTextBoxColumn,
            this.certificateNameArDataGridViewTextBoxColumn,
            this.certificateNameEnDataGridViewTextBoxColumn,
            this.certificateDateDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridEmpCertificatesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(4, 194);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(874, 213);
            this.gvForm.TabIndex = 37;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // gridEmpCertificatesBindingSource
            // 
            this.gridEmpCertificatesBindingSource.DataMember = "Grid_Emp_Certificates";
            this.gridEmpCertificatesBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 36;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(415, 151);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(540, 151);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // CbEmpID
            // 
            this.CbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.CbEmpID.DisplayMember = "EmpNameAR";
            this.CbEmpID.FormattingEnabled = true;
            this.CbEmpID.Location = new System.Drawing.Point(373, 30);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(286, 25);
            this.CbEmpID.TabIndex = 1;
            this.CbEmpID.ValueMember = "EmployeeID";
            this.CbEmpID.SelectedIndexChanged += new System.EventHandler(this.CbEmpID_SelectedIndexChanged);
            // 
            // lupEmpNameListBindingSource
            // 
            this.lupEmpNameListBindingSource.DataMember = "Lup_EmpNameList";
            this.lupEmpNameListBindingSource.DataSource = this.empDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "تاريخ انتهاء فاعليه الشهادة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "تاريخ الحصول علي الشهادة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "اسم الشهادة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "اسم / كود الموظف:";
            // 
            // txtCertificateNameAr
            // 
            this.txtCertificateNameAr.Location = new System.Drawing.Point(319, 61);
            this.txtCertificateNameAr.Name = "txtCertificateNameAr";
            this.txtCertificateNameAr.Size = new System.Drawing.Size(340, 24);
            this.txtCertificateNameAr.TabIndex = 2;
            // 
            // txtCertificateNameEn
            // 
            this.txtCertificateNameEn.Location = new System.Drawing.Point(210, 61);
            this.txtCertificateNameEn.Name = "txtCertificateNameEn";
            this.txtCertificateNameEn.Size = new System.Drawing.Size(103, 24);
            this.txtCertificateNameEn.TabIndex = 3;
            this.txtCertificateNameEn.Visible = false;
            // 
            // dtCertificateDate
            // 
            this.dtCertificateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCertificateDate.Location = new System.Drawing.Point(509, 91);
            this.dtCertificateDate.Name = "dtCertificateDate";
            this.dtCertificateDate.Size = new System.Drawing.Size(150, 24);
            this.dtCertificateDate.TabIndex = 4;
            this.dtCertificateDate.Leave += new System.EventHandler(this.dtCertificateDate_Leave);
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpireDate.Location = new System.Drawing.Point(509, 121);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(150, 24);
            this.dtExpireDate.TabIndex = 5;
            // 
            // grid_Emp_CertificatesTableAdapter
            // 
            this.grid_Emp_CertificatesTableAdapter.ClearBeforeFill = true;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(296, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(885, 409);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpID.DisplayMember = "ExternalID";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(242, 30);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(125, 25);
            this.txtEmpID.TabIndex = 71;
            this.txtEmpID.ValueMember = "EmployeeID";
            this.txtEmpID.SelectedIndexChanged += new System.EventHandler(this.txtEmpID_SelectedIndexChanged);
            // 
            // comboExternalIDBindingSource
            // 
            this.comboExternalIDBindingSource.DataMember = "Combo_ExternalID";
            this.comboExternalIDBindingSource.DataSource = this.empDataSet;
            // 
            // combo_ExternalIDTableAdapter
            // 
            this.combo_ExternalIDTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeCertificateID";
            this.Column1.HeaderText = "EmployeeCertificateID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateNameArDataGridViewTextBoxColumn
            // 
            this.certificateNameArDataGridViewTextBoxColumn.DataPropertyName = "CertificateNameAr";
            this.certificateNameArDataGridViewTextBoxColumn.HeaderText = "الشهاده";
            this.certificateNameArDataGridViewTextBoxColumn.Name = "certificateNameArDataGridViewTextBoxColumn";
            this.certificateNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateNameEnDataGridViewTextBoxColumn
            // 
            this.certificateNameEnDataGridViewTextBoxColumn.DataPropertyName = "CertificateNameEn";
            this.certificateNameEnDataGridViewTextBoxColumn.HeaderText = "الشهادة (انجليزي)";
            this.certificateNameEnDataGridViewTextBoxColumn.Name = "certificateNameEnDataGridViewTextBoxColumn";
            this.certificateNameEnDataGridViewTextBoxColumn.ReadOnly = true;
            this.certificateNameEnDataGridViewTextBoxColumn.Visible = false;
            // 
            // certificateDateDataGridViewTextBoxColumn
            // 
            this.certificateDateDataGridViewTextBoxColumn.DataPropertyName = "CertificateDate";
            this.certificateDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الحصول";
            this.certificateDateDataGridViewTextBoxColumn.Name = "certificateDateDataGridViewTextBoxColumn";
            this.certificateDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "تاريخ انتهاء الفاعليه";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCertificates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 409);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtExpireDate);
            this.Controls.Add(this.dtCertificateDate);
            this.Controls.Add(this.txtCertificateNameEn);
            this.Controls.Add(this.txtCertificateNameAr);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmCertificates";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شهادات العاملين";
            this.Load += new System.EventHandler(this.frmCertificates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpCertificatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCertificateNameAr;
        private System.Windows.Forms.TextBox txtCertificateNameEn;
        private System.Windows.Forms.DateTimePicker dtCertificateDate;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource gridEmpCertificatesBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_CertificatesTableAdapter grid_Emp_CertificatesTableAdapter;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCertificateID;
    }
}