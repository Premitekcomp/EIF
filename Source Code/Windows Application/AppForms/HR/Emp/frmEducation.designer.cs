namespace TMS.AppForms.HR.Emp
{
    partial class frmEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEducation));
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtQualificationNameID = new System.Windows.Forms.ComboBox();
            this.hRLupQualificationNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.txtUniversityID = new System.Windows.Forms.ComboBox();
            this.hRLupUniversitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtFacultyID = new System.Windows.Forms.ComboBox();
            this.hRLupFacultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet1 = new TMS.AppDataSetsHR.LupDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSectionNameID = new System.Windows.Forms.ComboBox();
            this.hRLupEduSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtQualificationYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hR_Lup_QualificationNamesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter();
            this.hR_Lup_UniversitiesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_UniversitiesTableAdapter();
            this.hR_Lup_EduSectionsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSectionsTableAdapter();
            this.hR_Lup_FacultiesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_FacultiesTableAdapter();
            this.grid_EmpEducationTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpEducationTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.comboExternalIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_ExternalIDTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter();
            this.txtQTypeID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hRLupQualificationsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_QualificationsTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupUniversitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupFacultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEduSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationsTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(25, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 78;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(23, 182);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 9;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(168, 182);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 8;
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
            this.CbEmpID.Location = new System.Drawing.Point(524, 30);
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
            this.qualificationNameArDataGridViewTextBoxColumn,
            this.universityNameArDataGridViewTextBoxColumn,
            this.facultyNameDataGridViewTextBoxColumn,
            this.sectionNameArDataGridViewTextBoxColumn,
            this.qualificationYearDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridEmpEducationBindingSource;
            this.gvForm.Location = new System.Drawing.Point(11, 227);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(891, 234);
            this.gvForm.TabIndex = 79;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RecordID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // empNameARDataGridViewTextBoxColumn
            // 
            this.empNameARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empNameARDataGridViewTextBoxColumn.DataPropertyName = "EmpNameAR";
            this.empNameARDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.empNameARDataGridViewTextBoxColumn.Name = "empNameARDataGridViewTextBoxColumn";
            this.empNameARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationNameArDataGridViewTextBoxColumn
            // 
            this.qualificationNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualificationNameArDataGridViewTextBoxColumn.DataPropertyName = "QualificationNameAr";
            this.qualificationNameArDataGridViewTextBoxColumn.HeaderText = "المؤهل";
            this.qualificationNameArDataGridViewTextBoxColumn.Name = "qualificationNameArDataGridViewTextBoxColumn";
            this.qualificationNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationNameArDataGridViewTextBoxColumn.Width = 74;
            // 
            // universityNameArDataGridViewTextBoxColumn
            // 
            this.universityNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.universityNameArDataGridViewTextBoxColumn.DataPropertyName = "UniversityNameAr";
            this.universityNameArDataGridViewTextBoxColumn.HeaderText = "الجامعة";
            this.universityNameArDataGridViewTextBoxColumn.Name = "universityNameArDataGridViewTextBoxColumn";
            this.universityNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.universityNameArDataGridViewTextBoxColumn.Width = 76;
            // 
            // facultyNameDataGridViewTextBoxColumn
            // 
            this.facultyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.facultyNameDataGridViewTextBoxColumn.DataPropertyName = "FacultyName";
            this.facultyNameDataGridViewTextBoxColumn.HeaderText = "الكلية";
            this.facultyNameDataGridViewTextBoxColumn.Name = "facultyNameDataGridViewTextBoxColumn";
            this.facultyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyNameDataGridViewTextBoxColumn.Width = 65;
            // 
            // sectionNameArDataGridViewTextBoxColumn
            // 
            this.sectionNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sectionNameArDataGridViewTextBoxColumn.DataPropertyName = "SectionNameAr";
            this.sectionNameArDataGridViewTextBoxColumn.HeaderText = "التخصص";
            this.sectionNameArDataGridViewTextBoxColumn.Name = "sectionNameArDataGridViewTextBoxColumn";
            this.sectionNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNameArDataGridViewTextBoxColumn.Width = 82;
            // 
            // qualificationYearDataGridViewTextBoxColumn
            // 
            this.qualificationYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualificationYearDataGridViewTextBoxColumn.DataPropertyName = "QualificationYear";
            this.qualificationYearDataGridViewTextBoxColumn.HeaderText = "سنة التخرج";
            this.qualificationYearDataGridViewTextBoxColumn.Name = "qualificationYearDataGridViewTextBoxColumn";
            this.qualificationYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationYearDataGridViewTextBoxColumn.Width = 101;
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
            // gridEmpEducationBindingSource
            // 
            this.gridEmpEducationBindingSource.DataMember = "Grid_EmpEducation";
            this.gridEmpEducationBindingSource.DataSource = this.empDataSet;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(342, 123);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(468, 95);
            this.txtNotes.TabIndex = 7;
            // 
            // txtQualificationNameID
            // 
            this.txtQualificationNameID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQualificationNameID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtQualificationNameID.DataSource = this.hRLupQualificationNamesBindingSource;
            this.txtQualificationNameID.DisplayMember = "QualificationNameAr";
            this.txtQualificationNameID.FormattingEnabled = true;
            this.txtQualificationNameID.Location = new System.Drawing.Point(589, 92);
            this.txtQualificationNameID.Name = "txtQualificationNameID";
            this.txtQualificationNameID.Size = new System.Drawing.Size(221, 25);
            this.txtQualificationNameID.TabIndex = 2;
            this.txtQualificationNameID.ValueMember = "QualificationNameID";
            // 
            // hRLupQualificationNamesBindingSource
            // 
            this.hRLupQualificationNamesBindingSource.DataMember = "HR_Lup_QualificationNames";
            this.hRLupQualificationNamesBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "ملاحظـــات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "المؤهل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "اسم / كود :";
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // txtUniversityID
            // 
            this.txtUniversityID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUniversityID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtUniversityID.DataSource = this.hRLupUniversitiesBindingSource;
            this.txtUniversityID.DisplayMember = "UniversityNameAr";
            this.txtUniversityID.FormattingEnabled = true;
            this.txtUniversityID.Location = new System.Drawing.Point(12, 56);
            this.txtUniversityID.Name = "txtUniversityID";
            this.txtUniversityID.Size = new System.Drawing.Size(221, 25);
            this.txtUniversityID.TabIndex = 3;
            this.txtUniversityID.ValueMember = "UniversityID";
            // 
            // hRLupUniversitiesBindingSource
            // 
            this.hRLupUniversitiesBindingSource.DataMember = "HR_Lup_Universities";
            this.hRLupUniversitiesBindingSource.DataSource = this.lupDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "الجامعة:";
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFacultyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFacultyID.DataSource = this.hRLupFacultiesBindingSource;
            this.txtFacultyID.DisplayMember = "FacultyName";
            this.txtFacultyID.FormattingEnabled = true;
            this.txtFacultyID.Location = new System.Drawing.Point(13, 84);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(221, 25);
            this.txtFacultyID.TabIndex = 4;
            this.txtFacultyID.ValueMember = "FacultyID";
            // 
            // hRLupFacultiesBindingSource
            // 
            this.hRLupFacultiesBindingSource.DataMember = "HR_Lup_Faculties";
            this.hRLupFacultiesBindingSource.DataSource = this.lupDataSet1;
            // 
            // lupDataSet1
            // 
            this.lupDataSet1.DataSetName = "LupDataSet";
            this.lupDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 85;
            this.label7.Text = "الكلية:";
            // 
            // txtSectionNameID
            // 
            this.txtSectionNameID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSectionNameID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSectionNameID.DataSource = this.hRLupEduSectionsBindingSource;
            this.txtSectionNameID.DisplayMember = "SectionNameAr";
            this.txtSectionNameID.FormattingEnabled = true;
            this.txtSectionNameID.Location = new System.Drawing.Point(13, 112);
            this.txtSectionNameID.Name = "txtSectionNameID";
            this.txtSectionNameID.Size = new System.Drawing.Size(221, 25);
            this.txtSectionNameID.TabIndex = 5;
            this.txtSectionNameID.ValueMember = "SectionNameID";
            // 
            // hRLupEduSectionsBindingSource
            // 
            this.hRLupEduSectionsBindingSource.DataMember = "HR_Lup_EduSections";
            this.hRLupEduSectionsBindingSource.DataSource = this.lupDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 87;
            this.label8.Text = "التخصص:";
            // 
            // txtQualificationYear
            // 
            this.txtQualificationYear.Location = new System.Drawing.Point(133, 143);
            this.txtQualificationYear.Name = "txtQualificationYear";
            this.txtQualificationYear.Size = new System.Drawing.Size(100, 24);
            this.txtQualificationYear.TabIndex = 6;
            this.txtQualificationYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQualificationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQualificationYear_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "سنة التخرج:";
            // 
            // hR_Lup_QualificationNamesTableAdapter
            // 
            this.hR_Lup_QualificationNamesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_UniversitiesTableAdapter
            // 
            this.hR_Lup_UniversitiesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_EduSectionsTableAdapter
            // 
            this.hR_Lup_EduSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_FacultiesTableAdapter
            // 
            this.hR_Lup_FacultiesTableAdapter.ClearBeforeFill = true;
            // 
            // grid_EmpEducationTableAdapter
            // 
            this.grid_EmpEducationTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(23, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 36);
            this.btnDelete.TabIndex = 90;
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
            this.PictureBG.Size = new System.Drawing.Size(912, 463);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 91;
            this.PictureBG.TabStop = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmpID.DataSource = this.comboExternalIDBindingSource;
            this.txtEmpID.DisplayMember = "ExternalID";
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(412, 30);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(106, 25);
            this.txtEmpID.TabIndex = 137;
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
            // txtQTypeID
            // 
            this.txtQTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtQTypeID.DataSource = this.hRLupQualificationsTypesBindingSource;
            this.txtQTypeID.DisplayMember = "QualificationTypeNameAr";
            this.txtQTypeID.FormattingEnabled = true;
            this.txtQTypeID.Location = new System.Drawing.Point(639, 61);
            this.txtQTypeID.Name = "txtQTypeID";
            this.txtQTypeID.Size = new System.Drawing.Size(171, 25);
            this.txtQTypeID.TabIndex = 138;
            this.txtQTypeID.ValueMember = "QualificationTypeID";
            this.txtQTypeID.SelectedIndexChanged += new System.EventHandler(this.txtQTypeID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 139;
            this.label3.Text = "نوع المؤهل:";
            // 
            // hRLupQualificationsTypesBindingSource
            // 
            this.hRLupQualificationsTypesBindingSource.DataMember = "HR_Lup_QualificationsTypes";
            this.hRLupQualificationsTypesBindingSource.DataSource = this.lupDataSet;
            // 
            // hR_Lup_QualificationsTypesTableAdapter
            // 
            this.hR_Lup_QualificationsTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmEducation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQTypeID);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQualificationYear);
            this.Controls.Add(this.txtSectionNameID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFacultyID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUniversityID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtQualificationNameID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEducation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التعليم و المؤهلات العلمية";
            this.Load += new System.EventHandler(this.frmEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupUniversitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupFacultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEduSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboExternalIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationsTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox txtQualificationNameID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.ComboBox txtUniversityID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtFacultyID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtSectionNameID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQualificationYear;
        private System.Windows.Forms.Label label9;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupQualificationNamesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter hR_Lup_QualificationNamesTableAdapter;
        private System.Windows.Forms.BindingSource hRLupUniversitiesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_UniversitiesTableAdapter hR_Lup_UniversitiesTableAdapter;
        private System.Windows.Forms.BindingSource hRLupEduSectionsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSectionsTableAdapter hR_Lup_EduSectionsTableAdapter;
        private AppDataSetsHR.LupDataSet lupDataSet1;
        private System.Windows.Forms.BindingSource hRLupFacultiesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_FacultiesTableAdapter hR_Lup_FacultiesTableAdapter;
        private System.Windows.Forms.BindingSource gridEmpEducationBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Grid_EmpEducationTableAdapter grid_EmpEducationTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.BindingSource comboExternalIDBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Combo_ExternalIDTableAdapter combo_ExternalIDTableAdapter;
        private System.Windows.Forms.ComboBox txtQTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hRLupQualificationsTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter hR_Lup_QualificationsTypesTableAdapter;
    }
}