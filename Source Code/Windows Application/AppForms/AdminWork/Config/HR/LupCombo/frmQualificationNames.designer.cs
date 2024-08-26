namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmQualificationNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualificationNames));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.qualificationNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupQualificationNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtQualificationNameEN = new System.Windows.Forms.TextBox();
            this.txtQualificationNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Lup_QualificationsTypesComboBox = new System.Windows.Forms.ComboBox();
            this.hR_Lup_QualificationsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.hR_Lup_QualificationsTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter();
            this.tableAdapterManager = new TMS.AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager();
            this.hR_Lup_QualificationNamesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_QualificationsTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qualificationNameIDDataGridViewTextBoxColumn,
            this.qualificationNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupQualificationNamesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 178);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(702, 279);
            this.gvForm.TabIndex = 5;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // qualificationNameIDDataGridViewTextBoxColumn
            // 
            this.qualificationNameIDDataGridViewTextBoxColumn.DataPropertyName = "QualificationNameID";
            this.qualificationNameIDDataGridViewTextBoxColumn.HeaderText = "QualificationNameID";
            this.qualificationNameIDDataGridViewTextBoxColumn.Name = "qualificationNameIDDataGridViewTextBoxColumn";
            this.qualificationNameIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationNameIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qualificationNameArDataGridViewTextBoxColumn
            // 
            this.qualificationNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualificationNameArDataGridViewTextBoxColumn.DataPropertyName = "QualificationNameAr";
            this.qualificationNameArDataGridViewTextBoxColumn.HeaderText = "اسم المؤهل (عربي)";
            this.qualificationNameArDataGridViewTextBoxColumn.Name = "qualificationNameArDataGridViewTextBoxColumn";
            this.qualificationNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupQualificationNamesBindingSource
            // 
            this.hRLupQualificationNamesBindingSource.DataMember = "HR_Lup_QualificationNames";
            this.hRLupQualificationNamesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQualificationNameEN
            // 
            this.txtQualificationNameEN.Location = new System.Drawing.Point(286, 99);
            this.txtQualificationNameEN.Name = "txtQualificationNameEN";
            this.txtQualificationNameEN.Size = new System.Drawing.Size(267, 24);
            this.txtQualificationNameEN.TabIndex = 2;
            // 
            // txtQualificationNameAr
            // 
            this.txtQualificationNameAr.Location = new System.Drawing.Point(286, 69);
            this.txtQualificationNameAr.Name = "txtQualificationNameAr";
            this.txtQualificationNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtQualificationNameAr.TabIndex = 1;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(286, 136);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 4;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(434, 136);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "اسم المؤهل (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "اسم المؤهل (عربي)";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(50, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // hR_Lup_QualificationsTypesComboBox
            // 
            this.hR_Lup_QualificationsTypesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hR_Lup_QualificationsTypesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hR_Lup_QualificationsTypesComboBox.DataSource = this.hR_Lup_QualificationsTypesBindingSource;
            this.hR_Lup_QualificationsTypesComboBox.DisplayMember = "QualificationTypeNameAr";
            this.hR_Lup_QualificationsTypesComboBox.FormattingEnabled = true;
            this.hR_Lup_QualificationsTypesComboBox.Location = new System.Drawing.Point(286, 38);
            this.hR_Lup_QualificationsTypesComboBox.Name = "hR_Lup_QualificationsTypesComboBox";
            this.hR_Lup_QualificationsTypesComboBox.Size = new System.Drawing.Size(267, 25);
            this.hR_Lup_QualificationsTypesComboBox.TabIndex = 0;
            this.hR_Lup_QualificationsTypesComboBox.ValueMember = "QualificationTypeID";
            this.hR_Lup_QualificationsTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.hR_Lup_QualificationsTypesComboBox_SelectedIndexChanged);
            // 
            // hR_Lup_QualificationsTypesBindingSource
            // 
            this.hR_Lup_QualificationsTypesBindingSource.DataMember = "HR_Lup_QualificationsTypes";
            this.hR_Lup_QualificationsTypesBindingSource.DataSource = this.LupDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "نوع المؤهل";
            // 
            // hR_Lup_QualificationsTypesTableAdapter
            // 
            this.hR_Lup_QualificationsTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TMS.AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hR_Lup_QualificationNamesTableAdapter
            // 
            this.hR_Lup_QualificationNamesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(728, 462);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmQualificationNames
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(728, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hR_Lup_QualificationsTypesComboBox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtQualificationNameEN);
            this.Controls.Add(this.txtQualificationNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQualificationNames";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل اسم المؤهل";
            this.Load += new System.EventHandler(this.frmQualificationNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_Lup_QualificationsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtQualificationNameEN;
        private System.Windows.Forms.TextBox txtQualificationNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hR_Lup_QualificationsTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationsTypesTableAdapter hR_Lup_QualificationsTypesTableAdapter;
        private AppDataSetsHR.LupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hR_Lup_QualificationsTypesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hRLupQualificationNamesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter hR_Lup_QualificationNamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}