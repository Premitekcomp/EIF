namespace TMS.AppForms.HR.HR_Tra
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.cbAllowanceID = new System.Windows.Forms.ComboBox();
            this.hRLupAllowancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.dtTra_Date = new System.Windows.Forms.DateTimePicker();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.chbIsPercent = new System.Windows.Forms.CheckBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPercentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTraAllowancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.grid_Tra_AllowancesTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_AllowancesTableAdapter();
            this.hR_Lup_AllowancesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AllowancesTableAdapter();
            this.lblMbox = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.txtDupplicationTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAllowancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraAllowancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "الموظف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "التاريخ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "طبيعة البدل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "القيمة:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ملاحظـــات:";
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
            // cbAllowanceID
            // 
            this.cbAllowanceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAllowanceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAllowanceID.DataSource = this.hRLupAllowancesBindingSource;
            this.cbAllowanceID.DisplayMember = "AllowanceNameAr";
            this.cbAllowanceID.FormattingEnabled = true;
            this.cbAllowanceID.Location = new System.Drawing.Point(98, 69);
            this.cbAllowanceID.Name = "cbAllowanceID";
            this.cbAllowanceID.Size = new System.Drawing.Size(198, 25);
            this.cbAllowanceID.TabIndex = 2;
            this.cbAllowanceID.ValueMember = "AllowanceID";
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
            // dtTra_Date
            // 
            this.dtTra_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra_Date.Location = new System.Drawing.Point(638, 69);
            this.dtTra_Date.Name = "dtTra_Date";
            this.dtTra_Date.Size = new System.Drawing.Size(125, 25);
            this.dtTra_Date.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(223, 128);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(73, 25);
            this.txtValue.TabIndex = 4;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbIsPercent
            // 
            this.chbIsPercent.AutoSize = true;
            this.chbIsPercent.Location = new System.Drawing.Point(41, 100);
            this.chbIsPercent.Name = "chbIsPercent";
            this.chbIsPercent.Size = new System.Drawing.Size(255, 22);
            this.chbIsPercent.TabIndex = 3;
            this.chbIsPercent.Text = "يحتسب كنسبة من الراتب الأساسي";
            this.chbIsPercent.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(415, 100);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(348, 61);
            this.txtNotes.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(651, 176);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Location = new System.Drawing.Point(533, 176);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(112, 37);
            this.btnCansel.TabIndex = 7;
            this.btnCansel.Text = "الغاء الامر";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
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
            this.allowanceNameArDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.isPercentDataGridViewCheckBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.gridTraAllowancesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 223);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(859, 236);
            this.gvForm.TabIndex = 8;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeAllowanceID";
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
            // allowanceNameArDataGridViewTextBoxColumn
            // 
            this.allowanceNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.allowanceNameArDataGridViewTextBoxColumn.DataPropertyName = "AllowanceNameAr";
            this.allowanceNameArDataGridViewTextBoxColumn.HeaderText = "البند";
            this.allowanceNameArDataGridViewTextBoxColumn.Name = "allowanceNameArDataGridViewTextBoxColumn";
            this.allowanceNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.allowanceNameArDataGridViewTextBoxColumn.Width = 59;
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
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridTraAllowancesBindingSource
            // 
            this.gridTraAllowancesBindingSource.DataMember = "Grid_Tra_Allowances";
            this.gridTraAllowancesBindingSource.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // grid_Tra_AllowancesTableAdapter
            // 
            this.grid_Tra_AllowancesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_AllowancesTableAdapter
            // 
            this.hR_Lup_AllowancesTableAdapter.ClearBeforeFill = true;
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(176, 13);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 18);
            this.lblMbox.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(415, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 10;
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
            this.PictureBG.Size = new System.Drawing.Size(883, 471);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // txtDupplicationTime
            // 
            this.txtDupplicationTime.Location = new System.Drawing.Point(223, 159);
            this.txtDupplicationTime.Name = "txtDupplicationTime";
            this.txtDupplicationTime.Size = new System.Drawing.Size(73, 25);
            this.txtDupplicationTime.TabIndex = 71;
            this.txtDupplicationTime.Text = "0";
            this.txtDupplicationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDupplicationTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNonDecimal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "تكرار:";
            // 
            // frmAllowances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
            this.Controls.Add(this.txtDupplicationTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.chbIsPercent);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.dtTra_Date);
            this.Controls.Add(this.cbAllowanceID);
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
            this.Name = "frmAllowances";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البدلات";
            this.Load += new System.EventHandler(this.frmAllowances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupAllowancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraAllowancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.ComboBox cbAllowanceID;
        private System.Windows.Forms.DateTimePicker dtTra_Date;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox chbIsPercent;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.DataGridView gvForm;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource gridTraAllowancesBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_AllowancesTableAdapter grid_Tra_AllowancesTableAdapter;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupAllowancesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_AllowancesTableAdapter hR_Lup_AllowancesTableAdapter;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPercentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDupplicationTime;
        private System.Windows.Forms.Label label1;
    }
}