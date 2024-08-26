namespace TMS.AppForms.AdminWork
{
    partial class frmUsersNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersNew));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 9);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserProfileImage = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPasswordA = new System.Windows.Forms.TextBox();
            this.txtPasswordB = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.ComboBox();
            this.hREmpInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premission = new TMS.AppDataSets.Premission();
            this.IsActive = new System.Windows.Forms.CheckBox();
            this.CmdSaveNew = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSaveClose = new System.Windows.Forms.Button();
            this.CmdBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfileimageList = new System.Windows.Forms.ImageList(this.components);
            this.CmdBrowseTemplate = new System.Windows.Forms.Button();
            this.ProfileImageTemplateLV = new System.Windows.Forms.ListView();
            this.lblEmplyeeName = new System.Windows.Forms.Label();
            this.hR_EmpInformationTableAdapter = new TMS.AppDataSets.PremissionTableAdapters.HR_EmpInformationTableAdapter();
            this.txtDrID = new System.Windows.Forms.ComboBox();
            this.bskDoctorsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupComboFill = new TMS.AppDataSets.LupComboFill();
            this.IsDoctor = new System.Windows.Forms.CheckBox();
            this.bsk_DoctorsListTableAdapter = new TMS.AppDataSets.LupComboFillTableAdapters.Bsk_DoctorsListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hREmpInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskDoctorsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم الدخول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة المرور:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "إعاده كلمة المرور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم المستخدم:";
            // 
            // UserProfileImage
            // 
            this.UserProfileImage.Location = new System.Drawing.Point(30, 35);
            this.UserProfileImage.Name = "UserProfileImage";
            this.UserProfileImage.Size = new System.Drawing.Size(64, 64);
            this.UserProfileImage.TabIndex = 4;
            this.UserProfileImage.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(223, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 24);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPasswordA
            // 
            this.txtPasswordA.Location = new System.Drawing.Point(268, 65);
            this.txtPasswordA.Name = "txtPasswordA";
            this.txtPasswordA.PasswordChar = 'x';
            this.txtPasswordA.Size = new System.Drawing.Size(158, 24);
            this.txtPasswordA.TabIndex = 6;
            this.txtPasswordA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasswordB
            // 
            this.txtPasswordB.Location = new System.Drawing.Point(268, 93);
            this.txtPasswordB.Name = "txtPasswordB";
            this.txtPasswordB.PasswordChar = 'x';
            this.txtPasswordB.Size = new System.Drawing.Size(158, 24);
            this.txtPasswordB.TabIndex = 7;
            this.txtPasswordB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(143, 123);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(283, 24);
            this.txtDisplayName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "كود الموظف:";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(30, 9);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 17);
            this.lblMSG.TabIndex = 10;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEmployeeID.DataSource = this.hREmpInformationBindingSource;
            this.txtEmployeeID.DisplayMember = "EmpNameAR";
            this.txtEmployeeID.FormattingEnabled = true;
            this.txtEmployeeID.Location = new System.Drawing.Point(232, 153);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(194, 25);
            this.txtEmployeeID.TabIndex = 11;
            this.txtEmployeeID.ValueMember = "EmployeeID";
            this.txtEmployeeID.SelectedIndexChanged += new System.EventHandler(this.txtEmployeeID_SelectedIndexChanged);
            // 
            // hREmpInformationBindingSource
            // 
            this.hREmpInformationBindingSource.DataMember = "HR_EmpInformation";
            this.hREmpInformationBindingSource.DataSource = this.premission;
            // 
            // premission
            // 
            this.premission.DataSetName = "Premission";
            this.premission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.Checked = true;
            this.IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActive.Location = new System.Drawing.Point(143, 37);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(56, 21);
            this.IsActive.TabIndex = 12;
            this.IsActive.Text = "نشط";
            this.IsActive.UseVisualStyleBackColor = true;
            // 
            // CmdSaveNew
            // 
            this.CmdSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveNew.Location = new System.Drawing.Point(332, 223);
            this.CmdSaveNew.Name = "CmdSaveNew";
            this.CmdSaveNew.Size = new System.Drawing.Size(94, 34);
            this.CmdSaveNew.TabIndex = 13;
            this.CmdSaveNew.Text = "حفظ و جديد";
            this.CmdSaveNew.UseVisualStyleBackColor = true;
            this.CmdSaveNew.Click += new System.EventHandler(this.CmdSaveNew_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCancel.Location = new System.Drawing.Point(30, 223);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(94, 34);
            this.CmdCancel.TabIndex = 14;
            this.CmdCancel.Text = "إلغاء";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSaveClose
            // 
            this.CmdSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveClose.Location = new System.Drawing.Point(232, 223);
            this.CmdSaveClose.Name = "CmdSaveClose";
            this.CmdSaveClose.Size = new System.Drawing.Size(94, 34);
            this.CmdSaveClose.TabIndex = 15;
            this.CmdSaveClose.Text = "حفظ و خروج";
            this.CmdSaveClose.UseVisualStyleBackColor = true;
            this.CmdSaveClose.Click += new System.EventHandler(this.CmdSaveClose_Click);
            // 
            // CmdBrowse
            // 
            this.CmdBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CmdBrowse.FlatAppearance.BorderSize = 0;
            this.CmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("CmdBrowse.Image")));
            this.CmdBrowse.Location = new System.Drawing.Point(-10, 69);
            this.CmdBrowse.Name = "CmdBrowse";
            this.CmdBrowse.Size = new System.Drawing.Size(34, 34);
            this.CmdBrowse.TabIndex = 16;
            this.CmdBrowse.UseVisualStyleBackColor = true;
            this.CmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 102);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "64 x 64";
            // 
            // ProfileimageList
            // 
            this.ProfileimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ProfileimageList.ImageStream")));
            this.ProfileimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ProfileimageList.Images.SetKeyName(0, "Dr1.png");
            this.ProfileimageList.Images.SetKeyName(1, "Dr2.png");
            this.ProfileimageList.Images.SetKeyName(2, "Nurse.png");
            this.ProfileimageList.Images.SetKeyName(3, "Man1.png");
            this.ProfileimageList.Images.SetKeyName(4, "Man2.png");
            this.ProfileimageList.Images.SetKeyName(5, "boy1.png");
            this.ProfileimageList.Images.SetKeyName(6, "Woman1.png");
            this.ProfileimageList.Images.SetKeyName(7, "Woman2.png");
            this.ProfileimageList.Images.SetKeyName(8, "Girl1.png");
            this.ProfileimageList.Images.SetKeyName(9, "Gril2.png");
            // 
            // CmdBrowseTemplate
            // 
            this.CmdBrowseTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CmdBrowseTemplate.FlatAppearance.BorderSize = 0;
            this.CmdBrowseTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBrowseTemplate.Image = ((System.Drawing.Image)(resources.GetObject("CmdBrowseTemplate.Image")));
            this.CmdBrowseTemplate.Location = new System.Drawing.Point(2, 29);
            this.CmdBrowseTemplate.Name = "CmdBrowseTemplate";
            this.CmdBrowseTemplate.Size = new System.Drawing.Size(25, 34);
            this.CmdBrowseTemplate.TabIndex = 48;
            this.CmdBrowseTemplate.UseVisualStyleBackColor = true;
            this.CmdBrowseTemplate.Click += new System.EventHandler(this.CmdBrowseTemplate_Click);
            // 
            // ProfileImageTemplateLV
            // 
            this.ProfileImageTemplateLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.ProfileImageTemplateLV.LargeImageList = this.ProfileimageList;
            this.ProfileImageTemplateLV.Location = new System.Drawing.Point(12, 287);
            this.ProfileImageTemplateLV.Name = "ProfileImageTemplateLV";
            this.ProfileImageTemplateLV.Size = new System.Drawing.Size(552, 218);
            this.ProfileImageTemplateLV.SmallImageList = this.ProfileimageList;
            this.ProfileImageTemplateLV.TabIndex = 49;
            this.ProfileImageTemplateLV.UseCompatibleStateImageBehavior = false;
            this.ProfileImageTemplateLV.Visible = false;
            this.ProfileImageTemplateLV.Click += new System.EventHandler(this.ProfileImageTemplateLV_Click);
            // 
            // lblEmplyeeName
            // 
            this.lblEmplyeeName.AutoSize = true;
            this.lblEmplyeeName.Location = new System.Drawing.Point(129, 156);
            this.lblEmplyeeName.Name = "lblEmplyeeName";
            this.lblEmplyeeName.Size = new System.Drawing.Size(0, 17);
            this.lblEmplyeeName.TabIndex = 50;
            // 
            // hR_EmpInformationTableAdapter
            // 
            this.hR_EmpInformationTableAdapter.ClearBeforeFill = true;
            // 
            // txtDrID
            // 
            this.txtDrID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDrID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDrID.DataSource = this.bskDoctorsListBindingSource;
            this.txtDrID.DisplayMember = "DrName";
            this.txtDrID.FormattingEnabled = true;
            this.txtDrID.Location = new System.Drawing.Point(143, 184);
            this.txtDrID.Name = "txtDrID";
            this.txtDrID.Size = new System.Drawing.Size(218, 25);
            this.txtDrID.TabIndex = 51;
            this.txtDrID.ValueMember = "DrID";
            this.txtDrID.Visible = false;
            this.txtDrID.SelectedIndexChanged += new System.EventHandler(this.txtDrID_SelectedIndexChanged);
            // 
            // bskDoctorsListBindingSource
            // 
            this.bskDoctorsListBindingSource.DataMember = "Bsk_DoctorsList";
            this.bskDoctorsListBindingSource.DataSource = this.lupComboFill;
            // 
            // lupComboFill
            // 
            this.lupComboFill.DataSetName = "LupComboFill";
            this.lupComboFill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IsDoctor
            // 
            this.IsDoctor.AutoSize = true;
            this.IsDoctor.Location = new System.Drawing.Point(367, 186);
            this.IsDoctor.Name = "IsDoctor";
            this.IsDoctor.Size = new System.Drawing.Size(59, 21);
            this.IsDoctor.TabIndex = 52;
            this.IsDoctor.Text = "طبيب";
            this.IsDoctor.UseVisualStyleBackColor = true;
            this.IsDoctor.CheckedChanged += new System.EventHandler(this.IsDoctor_CheckedChanged);
            // 
            // bsk_DoctorsListTableAdapter
            // 
            this.bsk_DoctorsListTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsersNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 284);
            this.Controls.Add(this.IsDoctor);
            this.Controls.Add(this.txtDrID);
            this.Controls.Add(this.ProfileImageTemplateLV);
            this.Controls.Add(this.CmdBrowseTemplate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdBrowse);
            this.Controls.Add(this.CmdSaveClose);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSaveNew);
            this.Controls.Add(this.IsActive);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.txtPasswordB);
            this.Controls.Add(this.txtPasswordA);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.UserProfileImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmplyeeName);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUsersNew";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء مستخدم جديد";
            this.Load += new System.EventHandler(this.frmUsersNew_Load);
            this.Click += new System.EventHandler(this.frmUsersNew_Click);
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hREmpInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bskDoctorsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox UserProfileImage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPasswordA;
        private System.Windows.Forms.TextBox txtPasswordB;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.ComboBox txtEmployeeID;
        private System.Windows.Forms.CheckBox IsActive;
        private System.Windows.Forms.Button CmdSaveNew;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSaveClose;
        private System.Windows.Forms.Button CmdBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ProfileimageList;
        private System.Windows.Forms.Button CmdBrowseTemplate;
        private System.Windows.Forms.ListView ProfileImageTemplateLV;
        private System.Windows.Forms.Label lblEmplyeeName;
        private AppDataSets.Premission premission;
        private System.Windows.Forms.BindingSource hREmpInformationBindingSource;
        private AppDataSets.PremissionTableAdapters.HR_EmpInformationTableAdapter hR_EmpInformationTableAdapter;
        private System.Windows.Forms.ComboBox txtDrID;
        private System.Windows.Forms.CheckBox IsDoctor;
        private AppDataSets.LupComboFill lupComboFill;
        private System.Windows.Forms.BindingSource bskDoctorsListBindingSource;
        private AppDataSets.LupComboFillTableAdapters.Bsk_DoctorsListTableAdapter bsk_DoctorsListTableAdapter;
    }
}