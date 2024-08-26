namespace TMS.AppForms.HR.Emp
{
    partial class frmContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacts));
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.RecordSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCurrentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridEmpContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IsCurrent = new System.Windows.Forms.CheckBox();
            this.txtContactTypeID = new System.Windows.Forms.ComboBox();
            this.hRLupContactsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtContactValue = new System.Windows.Forms.TextBox();
            this.hR_Lup_ContactsTypeTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_ContactsTypeTableAdapter();
            this.grid_EmpContactsTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpContactsTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupContactsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(23, 5);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 50;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(519, 153);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(644, 153);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 5;
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
            this.CbEmpID.Location = new System.Drawing.Point(477, 25);
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
            this.label5.Location = new System.Drawing.Point(383, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "البيــــان:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "نوع البيان:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "اسم / كود الموظف:";
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordSerial,
            this.empNameARDataGridViewTextBoxColumn,
            this.contactTypeNameDataGridViewTextBoxColumn,
            this.contactValueDataGridViewTextBoxColumn,
            this.isCurrentDataGridViewCheckBoxColumn});
            this.gvForm.DataSource = this.gridEmpContactsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 195);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(874, 232);
            this.gvForm.TabIndex = 51;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // RecordSerial
            // 
            this.RecordSerial.DataPropertyName = "RecordSerial";
            this.RecordSerial.HeaderText = "RecordSerial";
            this.RecordSerial.Name = "RecordSerial";
            this.RecordSerial.ReadOnly = true;
            this.RecordSerial.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactTypeNameDataGridViewTextBoxColumn
            // 
            this.contactTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ContactTypeName";
            this.contactTypeNameDataGridViewTextBoxColumn.HeaderText = "البند";
            this.contactTypeNameDataGridViewTextBoxColumn.Name = "contactTypeNameDataGridViewTextBoxColumn";
            this.contactTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactTypeNameDataGridViewTextBoxColumn.Width = 58;
            // 
            // contactValueDataGridViewTextBoxColumn
            // 
            this.contactValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactValueDataGridViewTextBoxColumn.DataPropertyName = "ContactValue";
            this.contactValueDataGridViewTextBoxColumn.HeaderText = "البيان";
            this.contactValueDataGridViewTextBoxColumn.Name = "contactValueDataGridViewTextBoxColumn";
            this.contactValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactValueDataGridViewTextBoxColumn.Width = 63;
            // 
            // isCurrentDataGridViewCheckBoxColumn
            // 
            this.isCurrentDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isCurrentDataGridViewCheckBoxColumn.DataPropertyName = "IsCurrent";
            this.isCurrentDataGridViewCheckBoxColumn.HeaderText = "الحالي";
            this.isCurrentDataGridViewCheckBoxColumn.Name = "isCurrentDataGridViewCheckBoxColumn";
            this.isCurrentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCurrentDataGridViewCheckBoxColumn.Width = 53;
            // 
            // gridEmpContactsBindingSource
            // 
            this.gridEmpContactsBindingSource.DataMember = "Grid_EmpContacts";
            this.gridEmpContactsBindingSource.DataSource = this.empDataSet;
            // 
            // IsCurrent
            // 
            this.IsCurrent.AutoSize = true;
            this.IsCurrent.Location = new System.Drawing.Point(697, 87);
            this.IsCurrent.Name = "IsCurrent";
            this.IsCurrent.Size = new System.Drawing.Size(66, 21);
            this.IsCurrent.TabIndex = 4;
            this.IsCurrent.Text = "الحالي";
            this.IsCurrent.UseVisualStyleBackColor = true;
            // 
            // txtContactTypeID
            // 
            this.txtContactTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtContactTypeID.DataSource = this.hRLupContactsTypeBindingSource;
            this.txtContactTypeID.DisplayMember = "ContactTypeName";
            this.txtContactTypeID.FormattingEnabled = true;
            this.txtContactTypeID.Location = new System.Drawing.Point(542, 56);
            this.txtContactTypeID.Name = "txtContactTypeID";
            this.txtContactTypeID.Size = new System.Drawing.Size(221, 25);
            this.txtContactTypeID.TabIndex = 2;
            this.txtContactTypeID.ValueMember = "ContactTypeID";
            // 
            // hRLupContactsTypeBindingSource
            // 
            this.hRLupContactsTypeBindingSource.DataMember = "HR_Lup_ContactsType";
            this.hRLupContactsTypeBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtContactValue
            // 
            this.txtContactValue.Location = new System.Drawing.Point(38, 56);
            this.txtContactValue.Multiline = true;
            this.txtContactValue.Name = "txtContactValue";
            this.txtContactValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContactValue.Size = new System.Drawing.Size(339, 81);
            this.txtContactValue.TabIndex = 3;
            // 
            // hR_Lup_ContactsTypeTableAdapter
            // 
            this.hR_Lup_ContactsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // grid_EmpContactsTableAdapter
            // 
            this.grid_EmpContactsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(394, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(902, 427);
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
            this.txtEmpID.Location = new System.Drawing.Point(346, 25);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(125, 25);
            this.txtEmpID.TabIndex = 72;
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
            // frmContacts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 427);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtContactValue);
            this.Controls.Add(this.txtContactTypeID);
            this.Controls.Add(this.IsCurrent);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmContacts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الأتصال";
            this.Load += new System.EventHandler(this.frmContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupContactsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.CheckBox IsCurrent;
        private System.Windows.Forms.ComboBox txtContactTypeID;
        private System.Windows.Forms.TextBox txtContactValue;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupContactsTypeBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_ContactsTypeTableAdapter hR_Lup_ContactsTypeTableAdapter;
        private System.Windows.Forms.BindingSource gridEmpContactsBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpContactsTableAdapter grid_EmpContactsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCurrentDataGridViewCheckBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
    }
}