namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmSocialStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocialStatus));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.socialStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialStatusNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupSocialStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtSocialStatusNameEn = new System.Windows.Forms.TextBox();
            this.txtSocialStatusNameAr = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Lup_SocialStatusTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialStatusTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialStatusBindingSource)).BeginInit();
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
            this.socialStatusIDDataGridViewTextBoxColumn,
            this.socialStatusNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupSocialStatusBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 167);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(575, 243);
            this.gvForm.TabIndex = 4;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // socialStatusIDDataGridViewTextBoxColumn
            // 
            this.socialStatusIDDataGridViewTextBoxColumn.DataPropertyName = "SocialStatusID";
            this.socialStatusIDDataGridViewTextBoxColumn.HeaderText = "SocialStatusID";
            this.socialStatusIDDataGridViewTextBoxColumn.Name = "socialStatusIDDataGridViewTextBoxColumn";
            this.socialStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.socialStatusIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // socialStatusNameArDataGridViewTextBoxColumn
            // 
            this.socialStatusNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.socialStatusNameArDataGridViewTextBoxColumn.DataPropertyName = "SocialStatusNameAr";
            this.socialStatusNameArDataGridViewTextBoxColumn.HeaderText = "اسم الحالة الاجتماعية (عربي)";
            this.socialStatusNameArDataGridViewTextBoxColumn.Name = "socialStatusNameArDataGridViewTextBoxColumn";
            this.socialStatusNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupSocialStatusBindingSource
            // 
            this.hRLupSocialStatusBindingSource.DataMember = "HR_Lup_SocialStatus";
            this.hRLupSocialStatusBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSocialStatusNameEn
            // 
            this.txtSocialStatusNameEn.Location = new System.Drawing.Point(109, 78);
            this.txtSocialStatusNameEn.Name = "txtSocialStatusNameEn";
            this.txtSocialStatusNameEn.Size = new System.Drawing.Size(267, 24);
            this.txtSocialStatusNameEn.TabIndex = 1;
            // 
            // txtSocialStatusNameAr
            // 
            this.txtSocialStatusNameAr.Location = new System.Drawing.Point(109, 30);
            this.txtSocialStatusNameAr.Name = "txtSocialStatusNameAr";
            this.txtSocialStatusNameAr.Size = new System.Drawing.Size(267, 24);
            this.txtSocialStatusNameAr.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(109, 125);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 3;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(257, 125);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "اسم الحالة الاجتماعية (انجليزي)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "اسم الحالة الاجتماعية (عربي)";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(9, 7);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 70;
            // 
            // hR_Lup_SocialStatusTableAdapter
            // 
            this.hR_Lup_SocialStatusTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(599, 416);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // frmSocialStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtSocialStatusNameEn);
            this.Controls.Add(this.txtSocialStatusNameAr);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmSocialStatus";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الحالة الاجتماعية";
            this.Load += new System.EventHandler(this.frmSocialStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtSocialStatusNameEn;
        private System.Windows.Forms.TextBox txtSocialStatusNameAr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.BindingSource hRLupSocialStatusBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialStatusTableAdapter hR_Lup_SocialStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialStatusNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialStatusNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}