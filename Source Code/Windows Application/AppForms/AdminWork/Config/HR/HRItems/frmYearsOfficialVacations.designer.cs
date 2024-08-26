namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmYearsOfficialVacations
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtYearOfficialVacationNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYearOfficialVacationLength = new System.Windows.Forms.TextBox();
            this.dTPYearOfficialVacationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.hR_Lup_YearsComboBox = new System.Windows.Forms.ComboBox();
            this.hRLupYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.hR_Lup_YearsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsTableAdapter();
            this.hRLupYearsOfficialVacationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_YearsOfficialVacationsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsOfficialVacationsTableAdapter();
            this.yearOfficialVacationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isClosedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsOfficialVacationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(252, 101);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(403, 88);
            this.txtNotes.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "ملاحظات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "السنة";
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearOfficialVacationIDDataGridViewTextBoxColumn,
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.yearNameDataGridViewTextBoxColumn,
            this.isClosedDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.gvForm.DataSource = this.hRLupYearsOfficialVacationsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 195);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(788, 266);
            this.gvForm.TabIndex = 7;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 13);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 68;
            // 
            // txtYearOfficialVacationNameAr
            // 
            this.txtYearOfficialVacationNameAr.Location = new System.Drawing.Point(388, 71);
            this.txtYearOfficialVacationNameAr.Name = "txtYearOfficialVacationNameAr";
            this.txtYearOfficialVacationNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtYearOfficialVacationNameAr.TabIndex = 2;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(12, 153);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(109, 36);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(137, 153);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(109, 36);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "عدد الأيام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "اسم الاجازة (عربي)";
            // 
            // txtYearOfficialVacationLength
            // 
            this.txtYearOfficialVacationLength.Location = new System.Drawing.Point(104, 71);
            this.txtYearOfficialVacationLength.Name = "txtYearOfficialVacationLength";
            this.txtYearOfficialVacationLength.Size = new System.Drawing.Size(100, 24);
            this.txtYearOfficialVacationLength.TabIndex = 3;
            this.txtYearOfficialVacationLength.Text = "1";
            this.txtYearOfficialVacationLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dTPYearOfficialVacationDate
            // 
            this.dTPYearOfficialVacationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPYearOfficialVacationDate.Location = new System.Drawing.Point(500, 41);
            this.dTPYearOfficialVacationDate.Name = "dTPYearOfficialVacationDate";
            this.dTPYearOfficialVacationDate.Size = new System.Drawing.Size(155, 24);
            this.dTPYearOfficialVacationDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "تاريخ بداية الاجازة";
            // 
            // hR_Lup_YearsComboBox
            // 
            this.hR_Lup_YearsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hR_Lup_YearsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hR_Lup_YearsComboBox.DataSource = this.hRLupYearsBindingSource;
            this.hR_Lup_YearsComboBox.DisplayMember = "YearName";
            this.hR_Lup_YearsComboBox.FormattingEnabled = true;
            this.hR_Lup_YearsComboBox.Location = new System.Drawing.Point(500, 10);
            this.hR_Lup_YearsComboBox.Name = "hR_Lup_YearsComboBox";
            this.hR_Lup_YearsComboBox.Size = new System.Drawing.Size(155, 25);
            this.hR_Lup_YearsComboBox.TabIndex = 0;
            this.hR_Lup_YearsComboBox.ValueMember = "YearID1";
            this.hR_Lup_YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.hR_Lup_YearsComboBox_SelectedIndexChanged);
            // 
            // hRLupYearsBindingSource
            // 
            this.hRLupYearsBindingSource.DataMember = "HR_Lup_Years";
            this.hRLupYearsBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Lup_YearsTableAdapter
            // 
            this.hR_Lup_YearsTableAdapter.ClearBeforeFill = true;
            // 
            // hRLupYearsOfficialVacationsBindingSource
            // 
            this.hRLupYearsOfficialVacationsBindingSource.DataMember = "HR_Lup_YearsOfficialVacations";
            this.hRLupYearsOfficialVacationsBindingSource.DataSource = this.lupDataSet;
            // 
            // hR_Lup_YearsOfficialVacationsTableAdapter
            // 
            this.hR_Lup_YearsOfficialVacationsTableAdapter.ClearBeforeFill = true;
            // 
            // yearOfficialVacationIDDataGridViewTextBoxColumn
            // 
            this.yearOfficialVacationIDDataGridViewTextBoxColumn.DataPropertyName = "YearOfficialVacationID";
            this.yearOfficialVacationIDDataGridViewTextBoxColumn.HeaderText = "YearOfficialVacationID";
            this.yearOfficialVacationIDDataGridViewTextBoxColumn.Name = "yearOfficialVacationIDDataGridViewTextBoxColumn";
            this.yearOfficialVacationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearOfficialVacationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearOfficialVacationNameArDataGridViewTextBoxColumn
            // 
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn.DataPropertyName = "YearOfficialVacationNameAr";
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn.Name = "yearOfficialVacationNameArDataGridViewTextBoxColumn";
            this.yearOfficialVacationNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "YearOfficialVacationDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "التاريخ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn4.HeaderText = "عدد الايام";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // yearNameDataGridViewTextBoxColumn
            // 
            this.yearNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yearNameDataGridViewTextBoxColumn.DataPropertyName = "YearName";
            this.yearNameDataGridViewTextBoxColumn.HeaderText = "السنه";
            this.yearNameDataGridViewTextBoxColumn.Name = "yearNameDataGridViewTextBoxColumn";
            this.yearNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearNameDataGridViewTextBoxColumn.Width = 68;
            // 
            // isClosedDataGridViewCheckBoxColumn
            // 
            this.isClosedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isClosedDataGridViewCheckBoxColumn.DataPropertyName = "IsClosed";
            this.isClosedDataGridViewCheckBoxColumn.HeaderText = "مغلق";
            this.isClosedDataGridViewCheckBoxColumn.Name = "isClosedDataGridViewCheckBoxColumn";
            this.isClosedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isClosedDataGridViewCheckBoxColumn.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn3.HeaderText = "ملاحظات";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 84;
            // 
            // frmYearsOfficialVacations
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 471);
            this.Controls.Add(this.hR_Lup_YearsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPYearOfficialVacationDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtYearOfficialVacationNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearOfficialVacationLength);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmYearsOfficialVacations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الاجازات الرسمية";
            this.Load += new System.EventHandler(this.frmYearsOfficialVacations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsOfficialVacationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtYearOfficialVacationNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYearOfficialVacationLength;
        private System.Windows.Forms.DateTimePicker dTPYearOfficialVacationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hR_Lup_YearsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfficialVacationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupYearsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsTableAdapter hR_Lup_YearsTableAdapter;
        private System.Windows.Forms.BindingSource hRLupYearsOfficialVacationsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsOfficialVacationsTableAdapter hR_Lup_YearsOfficialVacationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfficialVacationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfficialVacationNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isClosedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}