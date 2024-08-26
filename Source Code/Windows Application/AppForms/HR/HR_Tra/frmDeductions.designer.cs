namespace TMS.AppForms.HR.HR_Tra
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
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPercentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTraDeductionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.chbIsPercent = new System.Windows.Forms.CheckBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dtTra_Date = new System.Windows.Forms.DateTimePicker();
            this.cbDeductionID = new System.Windows.Forms.ComboBox();
            this.hRLupDeductionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.hR_Lup_DeductionsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DeductionsTableAdapter();
            this.grid_Tra_DeductionsTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_DeductionsTableAdapter();
            this.lblMbox = new System.Windows.Forms.Label();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtDupplicationTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraDeductionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDeductionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
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
            this.empIDDataGridViewTextBoxColumn,
            this.traDateDataGridViewTextBoxColumn,
            this.deductionNameArDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.isPercentDataGridViewCheckBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridTraDeductionsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 223);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(859, 236);
            this.gvForm.TabIndex = 8;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeDeductionID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // traDateDataGridViewTextBoxColumn
            // 
            this.traDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.traDateDataGridViewTextBoxColumn.DataPropertyName = "Tra_Date";
            this.traDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.traDateDataGridViewTextBoxColumn.Name = "traDateDataGridViewTextBoxColumn";
            this.traDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.traDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // deductionNameArDataGridViewTextBoxColumn
            // 
            this.deductionNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deductionNameArDataGridViewTextBoxColumn.DataPropertyName = "DeductionNameAr";
            this.deductionNameArDataGridViewTextBoxColumn.HeaderText = "البند";
            this.deductionNameArDataGridViewTextBoxColumn.Name = "deductionNameArDataGridViewTextBoxColumn";
            this.deductionNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionNameArDataGridViewTextBoxColumn.Width = 59;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "القيمة";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Width = 72;
            // 
            // isPercentDataGridViewCheckBoxColumn
            // 
            this.isPercentDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isPercentDataGridViewCheckBoxColumn.DataPropertyName = "IsPercent";
            this.isPercentDataGridViewCheckBoxColumn.HeaderText = "نسبة من الاساسي";
            this.isPercentDataGridViewCheckBoxColumn.Name = "isPercentDataGridViewCheckBoxColumn";
            this.isPercentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isPercentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 89;
            // 
            // gridTraDeductionsBindingSource
            // 
            this.gridTraDeductionsBindingSource.DataMember = "Grid_Tra_Deductions";
            this.gridTraDeductionsBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCansel
            // 
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Location = new System.Drawing.Point(520, 167);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(112, 37);
            this.btnCansel.TabIndex = 7;
            this.btnCansel.Text = "الغاء الامر";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(651, 167);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(451, 100);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(312, 61);
            this.txtNotes.TabIndex = 5;
            // 
            // chbIsPercent
            // 
            this.chbIsPercent.AutoSize = true;
            this.chbIsPercent.Location = new System.Drawing.Point(7, 103);
            this.chbIsPercent.Name = "chbIsPercent";
            this.chbIsPercent.Size = new System.Drawing.Size(255, 22);
            this.chbIsPercent.TabIndex = 3;
            this.chbIsPercent.Text = "يحتسب كنسبة من الراتب الأساسي";
            this.chbIsPercent.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(141, 128);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 25);
            this.txtValue.TabIndex = 4;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtTra_Date
            // 
            this.dtTra_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra_Date.Location = new System.Drawing.Point(638, 69);
            this.dtTra_Date.Name = "dtTra_Date";
            this.dtTra_Date.Size = new System.Drawing.Size(125, 25);
            this.dtTra_Date.TabIndex = 1;
            // 
            // cbDeductionID
            // 
            this.cbDeductionID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDeductionID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDeductionID.DataSource = this.hRLupDeductionsBindingSource;
            this.cbDeductionID.DisplayMember = "DeductionNameAr";
            this.cbDeductionID.FormattingEnabled = true;
            this.cbDeductionID.Location = new System.Drawing.Point(64, 72);
            this.cbDeductionID.Name = "cbDeductionID";
            this.cbDeductionID.Size = new System.Drawing.Size(198, 25);
            this.cbDeductionID.TabIndex = 2;
            this.cbDeductionID.ValueMember = "DeductionID";
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
            // CbEmpID
            // 
            this.CbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.CbEmpID.DisplayMember = "EmpNameAR";
            this.CbEmpID.FormattingEnabled = true;
            this.CbEmpID.Location = new System.Drawing.Point(552, 38);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(211, 25);
            this.CbEmpID.TabIndex = 0;
            this.CbEmpID.ValueMember = "EmployeeID";
            this.CbEmpID.SelectedIndexChanged += new System.EventHandler(this.CbEmpID_SelectedIndexChanged);
            // 
            // lupEmpNameListBindingSource
            // 
            this.lupEmpNameListBindingSource.DataMember = "Lup_EmpNameList";
            this.lupEmpNameListBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "ملاحظـــات:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "القيمة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "طبيعة الاستقطاع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "التاريخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "الموظف:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(384, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_DeductionsTableAdapter
            // 
            this.hR_Lup_DeductionsTableAdapter.ClearBeforeFill = true;
            // 
            // grid_Tra_DeductionsTableAdapter
            // 
            this.grid_Tra_DeductionsTableAdapter.ClearBeforeFill = true;
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(64, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 18);
            this.lblMbox.TabIndex = 21;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(891, 479);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // txtDupplicationTime
            // 
            this.txtDupplicationTime.Location = new System.Drawing.Point(189, 159);
            this.txtDupplicationTime.Name = "txtDupplicationTime";
            this.txtDupplicationTime.Size = new System.Drawing.Size(73, 25);
            this.txtDupplicationTime.TabIndex = 73;
            this.txtDupplicationTime.Text = "0";
            this.txtDupplicationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "تكرار:";
            // 
            // frmDeductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 479);
            this.Controls.Add(this.txtDupplicationTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.chbIsPercent);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.dtTra_Date);
            this.Controls.Add(this.cbDeductionID);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDeductions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستقطاعات";
            this.Load += new System.EventHandler(this.frmDeductions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraDeductionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupDeductionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chbIsPercent;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DateTimePicker dtTra_Date;
        private System.Windows.Forms.ComboBox cbDeductionID;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupDeductionsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_DeductionsTableAdapter hR_Lup_DeductionsTableAdapter;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource gridTraDeductionsBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_DeductionsTableAdapter grid_Tra_DeductionsTableAdapter;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPercentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.TextBox txtDupplicationTime;
        private System.Windows.Forms.Label label1;

    }
}