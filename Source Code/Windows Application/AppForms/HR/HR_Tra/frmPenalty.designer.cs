namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmPenalty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPenalty));
            this.chbByAmount = new System.Windows.Forms.CheckBox();
            this.grForm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTraPenaltyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.gridTraPenaltyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.chbByDay = new System.Windows.Forms.CheckBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dtTra_Date = new System.Windows.Forms.DateTimePicker();
            this.cbPenaltyNameID = new System.Windows.Forms.ComboBox();
            this.hRLupPenaltiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_Tra_PenaltyTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_PenaltyTableAdapter();
            this.hR_Lup_PenaltiesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_PenaltiesTableAdapter();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraPenaltyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraPenaltyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupPenaltiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // chbByAmount
            // 
            this.chbByAmount.AutoSize = true;
            this.chbByAmount.Location = new System.Drawing.Point(37, 99);
            this.chbByAmount.Name = "chbByAmount";
            this.chbByAmount.Size = new System.Drawing.Size(116, 22);
            this.chbByAmount.TabIndex = 4;
            this.chbByAmount.Text = "يحسب بالمبلغ";
            this.chbByAmount.UseVisualStyleBackColor = true;
            // 
            // grForm
            // 
            this.grForm.AllowUserToAddRows = false;
            this.grForm.AllowUserToDeleteRows = false;
            this.grForm.AutoGenerateColumns = false;
            this.grForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.empIDDataGridViewTextBoxColumn,
            this.traDateDataGridViewTextBoxColumn,
            this.penaltyNameArDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.byDayDataGridViewTextBoxColumn,
            this.byAmountDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.grForm.DataSource = this.gridTraPenaltyBindingSource1;
            this.grForm.Location = new System.Drawing.Point(12, 223);
            this.grForm.Name = "grForm";
            this.grForm.ReadOnly = true;
            this.grForm.Size = new System.Drawing.Size(859, 236);
            this.grForm.TabIndex = 9;
            this.grForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grForm_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeePenaltyID";
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
            this.traDateDataGridViewTextBoxColumn.DataPropertyName = "TraDate";
            this.traDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.traDateDataGridViewTextBoxColumn.Name = "traDateDataGridViewTextBoxColumn";
            this.traDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.traDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // penaltyNameArDataGridViewTextBoxColumn
            // 
            this.penaltyNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.penaltyNameArDataGridViewTextBoxColumn.DataPropertyName = "PenaltyNameAr";
            this.penaltyNameArDataGridViewTextBoxColumn.HeaderText = "البند";
            this.penaltyNameArDataGridViewTextBoxColumn.Name = "penaltyNameArDataGridViewTextBoxColumn";
            this.penaltyNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.penaltyNameArDataGridViewTextBoxColumn.Width = 59;
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
            // byDayDataGridViewTextBoxColumn
            // 
            this.byDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.byDayDataGridViewTextBoxColumn.DataPropertyName = "ByDay";
            this.byDayDataGridViewTextBoxColumn.HeaderText = "باليوم";
            this.byDayDataGridViewTextBoxColumn.Name = "byDayDataGridViewTextBoxColumn";
            this.byDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.byDayDataGridViewTextBoxColumn.Width = 66;
            // 
            // byAmountDataGridViewTextBoxColumn
            // 
            this.byAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.byAmountDataGridViewTextBoxColumn.DataPropertyName = "ByAmount";
            this.byAmountDataGridViewTextBoxColumn.HeaderText = "بالقيمة";
            this.byAmountDataGridViewTextBoxColumn.Name = "byAmountDataGridViewTextBoxColumn";
            this.byAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.byAmountDataGridViewTextBoxColumn.Width = 76;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridTraPenaltyBindingSource1
            // 
            this.gridTraPenaltyBindingSource1.DataMember = "Grid_Tra_Penalty";
            this.gridTraPenaltyBindingSource1.DataSource = this.traDataSet;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridTraPenaltyBindingSource
            // 
            this.gridTraPenaltyBindingSource.DataMember = "Grid_Tra_Penalty";
            this.gridTraPenaltyBindingSource.DataSource = this.traDataSet;
            // 
            // btnCansel
            // 
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Location = new System.Drawing.Point(520, 167);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(112, 37);
            this.btnCansel.TabIndex = 8;
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
            this.btnadd.TabIndex = 7;
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
            this.txtNotes.TabIndex = 6;
            // 
            // chbByDay
            // 
            this.chbByDay.AutoSize = true;
            this.chbByDay.Location = new System.Drawing.Point(159, 99);
            this.chbByDay.Name = "chbByDay";
            this.chbByDay.Size = new System.Drawing.Size(137, 22);
            this.chbByDay.TabIndex = 3;
            this.chbByDay.Text = "يحسب بعدد الايام";
            this.chbByDay.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(175, 128);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 25);
            this.txtValue.TabIndex = 5;
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
            // cbPenaltyNameID
            // 
            this.cbPenaltyNameID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPenaltyNameID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPenaltyNameID.DataSource = this.hRLupPenaltiesBindingSource;
            this.cbPenaltyNameID.DisplayMember = "PenaltyNameAr";
            this.cbPenaltyNameID.FormattingEnabled = true;
            this.cbPenaltyNameID.Location = new System.Drawing.Point(98, 69);
            this.cbPenaltyNameID.Name = "cbPenaltyNameID";
            this.cbPenaltyNameID.Size = new System.Drawing.Size(198, 25);
            this.cbPenaltyNameID.TabIndex = 2;
            this.cbPenaltyNameID.ValueMember = "PenaltyNameID";
            // 
            // hRLupPenaltiesBindingSource
            // 
            this.hRLupPenaltiesBindingSource.DataMember = "HR_Lup_Penalties";
            this.hRLupPenaltiesBindingSource.DataSource = this.lupDataSet;
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
            this.label6.TabIndex = 35;
            this.label6.Text = "ملاحظـــات:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "القيمة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "طبيعة الخصم:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "التاريخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "الموظف:";
            // 
            // grid_Tra_PenaltyTableAdapter
            // 
            this.grid_Tra_PenaltyTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_PenaltiesTableAdapter
            // 
            this.hR_Lup_PenaltiesTableAdapter.ClearBeforeFill = true;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(386, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "حذف ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(46, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 18);
            this.lblMbox.TabIndex = 41;
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
            // frmPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 479);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chbByAmount);
            this.Controls.Add(this.grForm);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.chbByDay);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.dtTra_Date);
            this.Controls.Add(this.cbPenaltyNameID);
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
            this.Name = "frmPenalty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الخصومات";
            this.Load += new System.EventHandler(this.frmPenalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraPenaltyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraPenaltyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupPenaltiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbByAmount;
        private System.Windows.Forms.DataGridView grForm;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chbByDay;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DateTimePicker dtTra_Date;
        private System.Windows.Forms.ComboBox cbPenaltyNameID;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource gridTraPenaltyBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.Grid_Tra_PenaltyTableAdapter grid_Tra_PenaltyTableAdapter;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupPenaltiesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_PenaltiesTableAdapter hR_Lup_PenaltiesTableAdapter;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.BindingSource gridTraPenaltyBindingSource1;
        internal System.Windows.Forms.PictureBox PictureBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}