namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmVacationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacationTypes));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.vacationtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupVacationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtVacationNameEn = new System.Windows.Forms.TextBox();
            this.txtVacationNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Lup_VacationTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_VacationTypesTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupVacationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).BeginInit();
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
            this.vacationtypeIDDataGridViewTextBoxColumn,
            this.vacationNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupVacationTypesBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 141);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(520, 243);
            this.gvForm.TabIndex = 67;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // vacationtypeIDDataGridViewTextBoxColumn
            // 
            this.vacationtypeIDDataGridViewTextBoxColumn.DataPropertyName = "VacationtypeID";
            this.vacationtypeIDDataGridViewTextBoxColumn.HeaderText = "VacationtypeID";
            this.vacationtypeIDDataGridViewTextBoxColumn.Name = "vacationtypeIDDataGridViewTextBoxColumn";
            this.vacationtypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacationtypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vacationNameArDataGridViewTextBoxColumn
            // 
            this.vacationNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacationNameArDataGridViewTextBoxColumn.DataPropertyName = "VacationNameAr";
            this.vacationNameArDataGridViewTextBoxColumn.HeaderText = "نوع الاجازة (عربي)";
            this.vacationNameArDataGridViewTextBoxColumn.Name = "vacationNameArDataGridViewTextBoxColumn";
            this.vacationNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupVacationTypesBindingSource
            // 
            this.hRLupVacationTypesBindingSource.DataMember = "HR_Lup_VacationTypes";
            this.hRLupVacationTypesBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVacationNameEn
            // 
            this.txtVacationNameEn.Location = new System.Drawing.Point(109, 69);
            this.txtVacationNameEn.Name = "txtVacationNameEn";
            this.txtVacationNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtVacationNameEn.TabIndex = 64;
            this.txtVacationNameEn.Visible = false;
            // 
            // txtVacationNameAr
            // 
            this.txtVacationNameAr.Location = new System.Drawing.Point(109, 39);
            this.txtVacationNameAr.Name = "txtVacationNameAr";
            this.txtVacationNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtVacationNameAr.TabIndex = 63;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(109, 99);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 66;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(257, 99);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 65;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "نوع الاجازة (انجليزي)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "نوع الاجازة (عربي)";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(9, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // hR_Lup_VacationTypesTableAdapter
            // 
            this.hR_Lup_VacationTypesTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(559, 392);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmVacationTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 392);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtVacationNameEn);
            this.Controls.Add(this.txtVacationNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVacationTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل انواع الاجازات";
            this.Load += new System.EventHandler(this.frmVacationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupVacationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtVacationNameEn;
        private System.Windows.Forms.TextBox txtVacationNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupVacationTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_VacationTypesTableAdapter hR_Lup_VacationTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacationNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}