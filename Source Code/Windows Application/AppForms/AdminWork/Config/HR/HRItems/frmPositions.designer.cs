namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmPositions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPositions));
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.positionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTitleARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupPositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet1 = new TMS.AppDataSetsHR.LupDataSet();
            this.hRLupMilitaryServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtPositionTItleEN = new System.Windows.Forms.TextBox();
            this.txtPositionTitleAR = new System.Windows.Forms.TextBox();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_GenderTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter();
            this.hR_Lup_MilitaryServiceTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter();
            this.hR_Lup_PositionsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_PositionsTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupPositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMilitaryServiceBindingSource)).BeginInit();
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
            this.positionIDDataGridViewTextBoxColumn,
            this.positionTitleARDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupPositionsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 40);
            this.gvForm.MultiSelect = false;
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(520, 243);
            this.gvForm.TabIndex = 4;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // positionIDDataGridViewTextBoxColumn
            // 
            this.positionIDDataGridViewTextBoxColumn.DataPropertyName = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.HeaderText = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.Name = "positionIDDataGridViewTextBoxColumn";
            this.positionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // positionTitleARDataGridViewTextBoxColumn
            // 
            this.positionTitleARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionTitleARDataGridViewTextBoxColumn.DataPropertyName = "PositionTitleAR";
            this.positionTitleARDataGridViewTextBoxColumn.HeaderText = "اسم الوظيفة (عربي)";
            this.positionTitleARDataGridViewTextBoxColumn.Name = "positionTitleARDataGridViewTextBoxColumn";
            this.positionTitleARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupPositionsBindingSource
            // 
            this.hRLupPositionsBindingSource.DataMember = "HR_Lup_Positions";
            this.hRLupPositionsBindingSource.DataSource = this.LupDataSet1;
            // 
            // LupDataSet1
            // 
            this.LupDataSet1.DataSetName = "LupDataSet";
            this.LupDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRLupMilitaryServiceBindingSource
            // 
            this.hRLupMilitaryServiceBindingSource.DataMember = "HR_Lup_MilitaryService";
            this.hRLupMilitaryServiceBindingSource.DataSource = this.LupDataSet;
            // 
            // LupDataSet
            // 
            this.LupDataSet.DataSetName = "LupDataSet";
            this.LupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(45, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 62;
            // 
            // txtPositionTItleEN
            // 
            this.txtPositionTItleEN.Location = new System.Drawing.Point(562, 130);
            this.txtPositionTItleEN.Name = "txtPositionTItleEN";
            this.txtPositionTItleEN.Size = new System.Drawing.Size(267, 24);
            this.txtPositionTItleEN.TabIndex = 1;
            this.txtPositionTItleEN.Visible = false;
            // 
            // txtPositionTitleAR
            // 
            this.txtPositionTitleAR.Location = new System.Drawing.Point(562, 67);
            this.txtPositionTitleAR.Name = "txtPositionTitleAR";
            this.txtPositionTitleAR.Size = new System.Drawing.Size(267, 24);
            this.txtPositionTitleAR.TabIndex = 0;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(562, 169);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 3;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(710, 169);
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
            this.label2.Location = new System.Drawing.Point(692, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "اسم الوظيفة (انجليزي)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "اسم الوظيفة (عربي)";
            // 
            // hR_Lup_GenderTableAdapter
            // 
            this.hR_Lup_GenderTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_MilitaryServiceTableAdapter
            // 
            this.hR_Lup_MilitaryServiceTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_PositionsTableAdapter
            // 
            this.hR_Lup_PositionsTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(844, 293);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 72;
            this.PictureBG.TabStop = false;
            // 
            // frmPositions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 293);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtPositionTItleEN);
            this.Controls.Add(this.txtPositionTitleAR);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPositions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال / تعديل الوظيفة";
            this.Load += new System.EventHandler(this.frmPositions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupPositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupMilitaryServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.BindingSource hRLupMilitaryServiceBindingSource;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtPositionTItleEN;
        private System.Windows.Forms.TextBox txtPositionTitleAR;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_GenderTableAdapter hR_Lup_GenderTableAdapter;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_MilitaryServiceTableAdapter hR_Lup_MilitaryServiceTableAdapter;
        private AppDataSetsHR.LupDataSet LupDataSet1;
        private System.Windows.Forms.BindingSource hRLupPositionsBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_PositionsTableAdapter hR_Lup_PositionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTitleARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTItleENDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
    }
}