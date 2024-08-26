namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmYearsMonths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearsMonths));
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_MonthIndexComboBox = new System.Windows.Forms.ComboBox();
            this.hR_Lup_MonthIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.hR_Lup_YearsComboBox = new System.Windows.Forms.ComboBox();
            this.hR_Lup_YearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClosed = new System.Windows.Forms.CheckBox();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.yearMonthIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthTitleARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hRLupYearsMonthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.hR_Lup_MonthIndexTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MonthIndexTableAdapter();
            this.tableAdapterManager = new TMS.AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager();
            this.hR_Lup_YearsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsTableAdapter();
            this.hRLupMonthIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_YearsMonthsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsMonthsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_MonthIndexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_YearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsMonthsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMonthIndexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشهر";
            // 
            // hR_Lup_MonthIndexComboBox
            // 
            this.hR_Lup_MonthIndexComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hR_Lup_MonthIndexComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hR_Lup_MonthIndexComboBox.DataSource = this.hR_Lup_MonthIndexBindingSource;
            this.hR_Lup_MonthIndexComboBox.DisplayMember = "MonthTitleAR";
            this.hR_Lup_MonthIndexComboBox.FormattingEnabled = true;
            this.hR_Lup_MonthIndexComboBox.Location = new System.Drawing.Point(467, 43);
            this.hR_Lup_MonthIndexComboBox.Name = "hR_Lup_MonthIndexComboBox";
            this.hR_Lup_MonthIndexComboBox.Size = new System.Drawing.Size(137, 25);
            this.hR_Lup_MonthIndexComboBox.TabIndex = 2;
            this.hR_Lup_MonthIndexComboBox.ValueMember = "MonthID";
            // 
            // hR_Lup_MonthIndexBindingSource
            // 
            this.hR_Lup_MonthIndexBindingSource.DataMember = "HR_Lup_MonthIndex";
            this.hR_Lup_MonthIndexBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hR_Lup_YearsComboBox
            // 
            this.hR_Lup_YearsComboBox.DataSource = this.hR_Lup_YearsBindingSource;
            this.hR_Lup_YearsComboBox.DisplayMember = "YearName";
            this.hR_Lup_YearsComboBox.FormattingEnabled = true;
            this.hR_Lup_YearsComboBox.Location = new System.Drawing.Point(466, 12);
            this.hR_Lup_YearsComboBox.Name = "hR_Lup_YearsComboBox";
            this.hR_Lup_YearsComboBox.Size = new System.Drawing.Size(137, 25);
            this.hR_Lup_YearsComboBox.TabIndex = 2;
            this.hR_Lup_YearsComboBox.ValueMember = "YearID";
            this.hR_Lup_YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.hR_Lup_YearsComboBox_SelectedIndexChanged);
            // 
            // hR_Lup_YearsBindingSource
            // 
            this.hR_Lup_YearsBindingSource.DataMember = "HR_Lup_Years";
            this.hR_Lup_YearsBindingSource.DataSource = this.LupDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "السنة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "الى";
            // 
            // cboClosed
            // 
            this.cboClosed.AutoSize = true;
            this.cboClosed.Location = new System.Drawing.Point(545, 104);
            this.cboClosed.Name = "cboClosed";
            this.cboClosed.Size = new System.Drawing.Size(58, 21);
            this.cboClosed.TabIndex = 6;
            this.cboClosed.Text = "مغلق";
            this.cboClosed.UseVisualStyleBackColor = true;
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFromDate.Location = new System.Drawing.Point(467, 74);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(136, 24);
            this.dTPFromDate.TabIndex = 7;
            // 
            // dTPToDate
            // 
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPToDate.Location = new System.Drawing.Point(255, 74);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(136, 24);
            this.dTPToDate.TabIndex = 8;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 71;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearMonthIDDataGridViewTextBoxColumn,
            this.yearNameDataGridViewTextBoxColumn,
            this.monthTitleARDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.closedDataGridViewCheckBoxColumn});
            this.gvForm.DataSource = this.hRLupYearsMonthsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 156);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(689, 253);
            this.gvForm.TabIndex = 72;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // yearMonthIDDataGridViewTextBoxColumn
            // 
            this.yearMonthIDDataGridViewTextBoxColumn.DataPropertyName = "YearMonthID";
            this.yearMonthIDDataGridViewTextBoxColumn.HeaderText = "YearMonthID";
            this.yearMonthIDDataGridViewTextBoxColumn.Name = "yearMonthIDDataGridViewTextBoxColumn";
            this.yearMonthIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearMonthIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearNameDataGridViewTextBoxColumn
            // 
            this.yearNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearNameDataGridViewTextBoxColumn.DataPropertyName = "YearName";
            this.yearNameDataGridViewTextBoxColumn.HeaderText = "السنة";
            this.yearNameDataGridViewTextBoxColumn.Name = "yearNameDataGridViewTextBoxColumn";
            this.yearNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthTitleARDataGridViewTextBoxColumn
            // 
            this.monthTitleARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monthTitleARDataGridViewTextBoxColumn.DataPropertyName = "MonthTitleAR";
            this.monthTitleARDataGridViewTextBoxColumn.HeaderText = "الشهر";
            this.monthTitleARDataGridViewTextBoxColumn.Name = "monthTitleARDataGridViewTextBoxColumn";
            this.monthTitleARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "التاريخ (من)";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "التاريخ (الى)";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closedDataGridViewCheckBoxColumn
            // 
            this.closedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.closedDataGridViewCheckBoxColumn.DataPropertyName = "Closed";
            this.closedDataGridViewCheckBoxColumn.HeaderText = "مغلق";
            this.closedDataGridViewCheckBoxColumn.Name = "closedDataGridViewCheckBoxColumn";
            this.closedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // hRLupYearsMonthsBindingSource
            // 
            this.hRLupYearsMonthsBindingSource.DataMember = "HR_Lup_YearsMonths";
            this.hRLupYearsMonthsBindingSource.DataSource = this.LupDataSet;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(12, 114);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 74;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(160, 114);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 73;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // hR_Lup_MonthIndexTableAdapter
            // 
            this.hR_Lup_MonthIndexTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TMS.AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hR_Lup_YearsTableAdapter
            // 
            this.hR_Lup_YearsTableAdapter.ClearBeforeFill = true;
            // 
            // hRLupMonthIndexBindingSource
            // 
            this.hRLupMonthIndexBindingSource.DataMember = "HR_Lup_MonthIndex";
            this.hRLupMonthIndexBindingSource.DataSource = this.LupDataSet;
            // 
            // hR_Lup_YearsMonthsTableAdapter
            // 
            this.hR_Lup_YearsMonthsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "التاريخ";
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(713, 421);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 76;
            this.PictureBG.TabStop = false;
            // 
            // frmYearsMonths
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.dTPToDate);
            this.Controls.Add(this.dTPFromDate);
            this.Controls.Add(this.cboClosed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hR_Lup_YearsComboBox);
            this.Controls.Add(this.hR_Lup_MonthIndexComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmYearsMonths";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشهور المحاسبيه";
            this.Load += new System.EventHandler(this.frmYearsMonths_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_MonthIndexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_YearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupYearsMonthsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMonthIndexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hR_Lup_MonthIndexBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MonthIndexTableAdapter hR_Lup_MonthIndexTableAdapter;
        private AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hR_Lup_MonthIndexComboBox;
        private System.Windows.Forms.BindingSource hR_Lup_YearsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsTableAdapter hR_Lup_YearsTableAdapter;
        private System.Windows.Forms.ComboBox hR_Lup_YearsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cboClosed;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hRLupMonthIndexBindingSource;
        private System.Windows.Forms.BindingSource hRLupYearsMonthsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_YearsMonthsTableAdapter hR_Lup_YearsMonthsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearMonthIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthTitleARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}