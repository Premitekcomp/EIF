namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    partial class frmEduSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEduSections));
            this.cbQualificationNameID = new System.Windows.Forms.ComboBox();
            this.hRLupQualificationNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblMbox = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.sectionNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRLupEduSectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSectionNameEn = new System.Windows.Forms.TextBox();
            this.txtSectionNameAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hR_Lup_QualificationNamesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter();
            this.hR_Lup_EduSectionsTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSectionsTableAdapter();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            this.hR_Lup_EduSections1TableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSections1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEduSectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // cbQualificationNameID
            // 
            this.cbQualificationNameID.DataSource = this.hRLupQualificationNamesBindingSource;
            this.cbQualificationNameID.DisplayMember = "QualificationNameAr";
            this.cbQualificationNameID.FormattingEnabled = true;
            this.cbQualificationNameID.Location = new System.Drawing.Point(335, 38);
            this.cbQualificationNameID.Name = "cbQualificationNameID";
            this.cbQualificationNameID.Size = new System.Drawing.Size(194, 25);
            this.cbQualificationNameID.TabIndex = 22;
            this.cbQualificationNameID.ValueMember = "QualificationNameID";
            this.cbQualificationNameID.SelectedIndexChanged += new System.EventHandler(this.cbcountry_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "اسم الشهادة";
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(282, 129);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(120, 42);
            this.btnAddClose.TabIndex = 27;
            this.btnAddClose.Text = "حفظ / اغلاق";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(409, 129);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 42);
            this.btnAddNew.TabIndex = 26;
            this.btnAddNew.Text = "حفظ / جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblMbox
            // 
            this.lblMbox.AutoSize = true;
            this.lblMbox.Location = new System.Drawing.Point(42, 9);
            this.lblMbox.Name = "lblMbox";
            this.lblMbox.Size = new System.Drawing.Size(0, 17);
            this.lblMbox.TabIndex = 31;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectionNameIDDataGridViewTextBoxColumn,
            this.sectionNameArDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRLupEduSectionsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 177);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(669, 218);
            this.gvForm.TabIndex = 30;
            this.gvForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellClick);
            // 
            // sectionNameIDDataGridViewTextBoxColumn
            // 
            this.sectionNameIDDataGridViewTextBoxColumn.DataPropertyName = "SectionNameID";
            this.sectionNameIDDataGridViewTextBoxColumn.HeaderText = "SectionNameID";
            this.sectionNameIDDataGridViewTextBoxColumn.Name = "sectionNameIDDataGridViewTextBoxColumn";
            this.sectionNameIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNameIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionNameArDataGridViewTextBoxColumn
            // 
            this.sectionNameArDataGridViewTextBoxColumn.DataPropertyName = "SectionNameAr";
            this.sectionNameArDataGridViewTextBoxColumn.HeaderText = "اسم القسم بالغة العربية";
            this.sectionNameArDataGridViewTextBoxColumn.Name = "sectionNameArDataGridViewTextBoxColumn";
            this.sectionNameArDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRLupEduSectionsBindingSource
            // 
            this.hRLupEduSectionsBindingSource.DataMember = "HR_Lup_EduSections1";
            this.hRLupEduSectionsBindingSource.DataSource = this.lupDataSet;
            // 
            // txtSectionNameEn
            // 
            this.txtSectionNameEn.Location = new System.Drawing.Point(282, 99);
            this.txtSectionNameEn.Name = "txtSectionNameEn";
            this.txtSectionNameEn.Size = new System.Drawing.Size(247, 24);
            this.txtSectionNameEn.TabIndex = 25;
            // 
            // txtSectionNameAr
            // 
            this.txtSectionNameAr.Location = new System.Drawing.Point(282, 69);
            this.txtSectionNameAr.Name = "txtSectionNameAr";
            this.txtSectionNameAr.Size = new System.Drawing.Size(247, 24);
            this.txtSectionNameAr.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "الاسم بالغة الانجليزية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "الاسم بالغة العربية";
            // 
            // hR_Lup_QualificationNamesTableAdapter
            // 
            this.hR_Lup_QualificationNamesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_EduSectionsTableAdapter
            // 
            this.hR_Lup_EduSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(696, 405);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 73;
            this.PictureBG.TabStop = false;
            // 
            // hR_Lup_EduSections1TableAdapter
            // 
            this.hR_Lup_EduSections1TableAdapter.ClearBeforeFill = true;
            // 
            // frmEduSections
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(696, 405);
            this.Controls.Add(this.cbQualificationNameID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblMbox);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtSectionNameEn);
            this.Controls.Add(this.txtSectionNameAr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEduSections";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التخصصات";
            this.Load += new System.EventHandler(this.frmEduSections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRLupQualificationNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupEduSectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQualificationNameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblMbox;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtSectionNameEn;
        private System.Windows.Forms.TextBox txtSectionNameAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupQualificationNamesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_QualificationNamesTableAdapter hR_Lup_QualificationNamesTableAdapter;
        private System.Windows.Forms.BindingSource hRLupEduSectionsBindingSource;
        private AppDataSetsHR.LupDataSet LupDataSet;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSectionsTableAdapter hR_Lup_EduSectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameEnDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBG;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_EduSections1TableAdapter hR_Lup_EduSections1TableAdapter;
    }
}