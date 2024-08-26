namespace TMS.AppForms.HR.Emp
{
    partial class frmDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocuments));
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDocumentTypeID = new System.Windows.Forms.ComboBox();
            this.hRLupDocumentsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.IsDeliverd = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypeNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverdDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliverdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileAttachedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpDocumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.dtDeliverdDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtValidTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.hR_Lup_DocumentsTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DocumentsTypesTableAdapter();
            this.grid_Emp_DocumentsTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_DocumentsTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CmdBrowse = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.CmdDownloadAttachment = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDocumentsTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpDocumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(412, 147);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(369, 81);
            this.txtNotes.TabIndex = 6;
            // 
            // txtDocumentTypeID
            // 
            this.txtDocumentTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDocumentTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDocumentTypeID.DataSource = this.hRLupDocumentsTypesBindingSource;
            this.txtDocumentTypeID.DisplayMember = "DocumentTypeNameAr";
            this.txtDocumentTypeID.FormattingEnabled = true;
            this.txtDocumentTypeID.Location = new System.Drawing.Point(560, 54);
            this.txtDocumentTypeID.Name = "txtDocumentTypeID";
            this.txtDocumentTypeID.Size = new System.Drawing.Size(221, 25);
            this.txtDocumentTypeID.TabIndex = 2;
            this.txtDocumentTypeID.ValueMember = "DocumentTypeID";
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
            // IsDeliverd
            // 
            this.IsDeliverd.AutoSize = true;
            this.IsDeliverd.Checked = true;
            this.IsDeliverd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsDeliverd.Location = new System.Drawing.Point(690, 85);
            this.IsDeliverd.Name = "IsDeliverd";
            this.IsDeliverd.Size = new System.Drawing.Size(91, 21);
            this.IsDeliverd.TabIndex = 3;
            this.IsDeliverd.Text = "تم تسليمه";
            this.IsDeliverd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "ملاحظـــات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "نوع المستند:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "اسم / كود الموظف:";
            // 
            // lupEmpNameListBindingSource
            // 
            this.lupEmpNameListBindingSource.DataMember = "Lup_EmpNameList";
            this.lupEmpNameListBindingSource.DataSource = this.empDataSet;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(29, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 61;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(137, 192);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 8;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(258, 192);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 7;
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
            this.CbEmpID.Location = new System.Drawing.Point(495, 23);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(286, 25);
            this.CbEmpID.TabIndex = 1;
            this.CbEmpID.ValueMember = "EmployeeID";
            this.CbEmpID.SelectedIndexChanged += new System.EventHandler(this.CbEmpID_SelectedIndexChanged);
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
            this.documentTypeNameArDataGridViewTextBoxColumn,
            this.deliverdDataGridViewCheckBoxColumn,
            this.deliverdDateDataGridViewTextBoxColumn,
            this.validToDataGridViewTextBoxColumn,
            this.FileAttachedStatus,
            this.notesDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridEmpDocumentsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(15, 234);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(891, 205);
            this.gvForm.TabIndex = 62;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            this.gvForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeDocumentID";
            this.Column1.HeaderText = "EmployeeDocumentID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentTypeNameArDataGridViewTextBoxColumn
            // 
            this.documentTypeNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.documentTypeNameArDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeNameAr";
            this.documentTypeNameArDataGridViewTextBoxColumn.HeaderText = "المستند";
            this.documentTypeNameArDataGridViewTextBoxColumn.Name = "documentTypeNameArDataGridViewTextBoxColumn";
            this.documentTypeNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentTypeNameArDataGridViewTextBoxColumn.Width = 82;
            // 
            // deliverdDataGridViewCheckBoxColumn
            // 
            this.deliverdDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliverdDataGridViewCheckBoxColumn.DataPropertyName = "Deliverd";
            this.deliverdDataGridViewCheckBoxColumn.HeaderText = "تم التسليم";
            this.deliverdDataGridViewCheckBoxColumn.Name = "deliverdDataGridViewCheckBoxColumn";
            this.deliverdDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deliverdDataGridViewCheckBoxColumn.Width = 79;
            // 
            // deliverdDateDataGridViewTextBoxColumn
            // 
            this.deliverdDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliverdDateDataGridViewTextBoxColumn.DataPropertyName = "DeliverdDate";
            this.deliverdDateDataGridViewTextBoxColumn.HeaderText = "تاريخ التسليم";
            this.deliverdDateDataGridViewTextBoxColumn.Name = "deliverdDateDataGridViewTextBoxColumn";
            this.deliverdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverdDateDataGridViewTextBoxColumn.Width = 111;
            // 
            // validToDataGridViewTextBoxColumn
            // 
            this.validToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.validToDataGridViewTextBoxColumn.DataPropertyName = "ValidTo";
            this.validToDataGridViewTextBoxColumn.HeaderText = "صالح حتي";
            this.validToDataGridViewTextBoxColumn.Name = "validToDataGridViewTextBoxColumn";
            this.validToDataGridViewTextBoxColumn.ReadOnly = true;
            this.validToDataGridViewTextBoxColumn.Width = 94;
            // 
            // FileAttachedStatus
            // 
            this.FileAttachedStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileAttachedStatus.DataPropertyName = "FileAttachedStatus";
            this.FileAttachedStatus.HeaderText = "المرفقات";
            this.FileAttachedStatus.Name = "FileAttachedStatus";
            this.FileAttachedStatus.ReadOnly = true;
            this.FileAttachedStatus.Width = 83;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 84;
            // 
            // gridEmpDocumentsBindingSource
            // 
            this.gridEmpDocumentsBindingSource.DataMember = "Grid_Emp_Documents";
            this.gridEmpDocumentsBindingSource.DataSource = this.empDataSet;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // dtDeliverdDate
            // 
            this.dtDeliverdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliverdDate.Location = new System.Drawing.Point(419, 82);
            this.dtDeliverdDate.Name = "dtDeliverdDate";
            this.dtDeliverdDate.Size = new System.Drawing.Size(118, 24);
            this.dtDeliverdDate.TabIndex = 4;
            this.dtDeliverdDate.Leave += new System.EventHandler(this.dtDeliverdDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "تاريخ التسليم:";
            // 
            // dtValidTo
            // 
            this.dtValidTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtValidTo.Location = new System.Drawing.Point(663, 112);
            this.dtValidTo.Name = "dtValidTo";
            this.dtValidTo.Size = new System.Drawing.Size(118, 24);
            this.dtValidTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "صالح حتي:";
            // 
            // hR_Lup_DocumentsTypesTableAdapter
            // 
            this.hR_Lup_DocumentsTypesTableAdapter.ClearBeforeFill = true;
            // 
            // grid_Emp_DocumentsTableAdapter
            // 
            this.grid_Emp_DocumentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(15, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CmdBrowse
            // 
            this.CmdBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("CmdBrowse.Image")));
            this.CmdBrowse.Location = new System.Drawing.Point(333, 23);
            this.CmdBrowse.Name = "CmdBrowse";
            this.CmdBrowse.Size = new System.Drawing.Size(44, 41);
            this.CmdBrowse.TabIndex = 133;
            this.CmdBrowse.UseVisualStyleBackColor = true;
            this.CmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(29, 57);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 17);
            this.lblFileName.TabIndex = 134;
            // 
            // CmdDownloadAttachment
            // 
            this.CmdDownloadAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDownloadAttachment.Location = new System.Drawing.Point(258, 147);
            this.CmdDownloadAttachment.Name = "CmdDownloadAttachment";
            this.CmdDownloadAttachment.Size = new System.Drawing.Size(119, 36);
            this.CmdDownloadAttachment.TabIndex = 135;
            this.CmdDownloadAttachment.Text = "تحميل المرفقات";
            this.CmdDownloadAttachment.UseVisualStyleBackColor = true;
            this.CmdDownloadAttachment.Visible = false;
            this.CmdDownloadAttachment.Click += new System.EventHandler(this.CmdDownloadAttachment_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpID.DisplayMember = "ExternalID";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(383, 23);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(106, 25);
            this.txtEmpID.TabIndex = 136;
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
            // frmDocuments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 442);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.CmdDownloadAttachment);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.CmdBrowse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtValidTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDeliverdDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDocumentTypeID);
            this.Controls.Add(this.IsDeliverd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.gvForm);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستندات";
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDocumentsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpDocumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox txtDocumentTypeID;
        private System.Windows.Forms.CheckBox IsDeliverd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.DataGridView gvForm;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.DateTimePicker dtDeliverdDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtValidTo;
        private System.Windows.Forms.Label label4;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupDocumentsTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DocumentsTypesTableAdapter hR_Lup_DocumentsTypesTableAdapter;
        private System.Windows.Forms.BindingSource gridEmpDocumentsBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_Emp_DocumentsTableAdapter grid_Emp_DocumentsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button CmdBrowse;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliverdDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileAttachedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdDownloadAttachment;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
    }
}