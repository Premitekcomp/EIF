namespace TMS.AppForms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUserName = new System.Windows.Forms.ComboBox();
            this.preAccountListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Authentication = new TMS.AppDataSets.Authentication();
            this.lblMSG = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmdDoLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.Pre_UsersTableAdapter = new TMS.AppDataSets.AuthenticationTableAdapters.Pre_UsersTableAdapter();
            this.txtBranch = new System.Windows.Forms.ComboBox();
            this.preBranchesPermissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premission = new TMS.AppDataSets.Premission();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupComboFill = new TMS.AppDataSets.LupComboFill();
            this.label1 = new System.Windows.Forms.Label();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.LupComboFillTableAdapters.Lup_BranchListTableAdapter();
            this.pre_BranchesPermissionsTableAdapter = new TMS.AppDataSets.PremissionTableAdapters.Pre_BranchesPermissionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.preAccountListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authentication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preBranchesPermissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtUserName.DataSource = this.preAccountListBindingSource;
            this.txtUserName.DisplayMember = "Username";
            this.txtUserName.FormattingEnabled = true;
            this.txtUserName.Location = new System.Drawing.Point(192, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 25);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.ValueMember = "UserID";
            this.txtUserName.SelectedIndexChanged += new System.EventHandler(this.txtUserName_SelectedIndexChanged);
            // 
            // preAccountListBindingSource
            // 
            this.preAccountListBindingSource.DataMember = "Pre_Users";
            this.preAccountListBindingSource.DataSource = this.Authentication;
            // 
            // Authentication
            // 
            this.Authentication.DataSetName = "Authentication";
            this.Authentication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(98, 21);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(305, 17);
            this.lblMSG.TabIndex = 23;
            this.lblMSG.Text = "إدخل أسم المستخدم و كلمة السر لتسجيل الدخول";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // CmdDoLogin
            // 
            this.CmdDoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CmdDoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDoLogin.Location = new System.Drawing.Point(277, 146);
            this.CmdDoLogin.Name = "CmdDoLogin";
            this.CmdDoLogin.Size = new System.Drawing.Size(121, 33);
            this.CmdDoLogin.TabIndex = 21;
            this.CmdDoLogin.Text = "تسجيل الدخول";
            this.CmdDoLogin.UseVisualStyleBackColor = true;
            this.CmdDoLogin.Click += new System.EventHandler(this.CmdDoLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(192, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'x';
            this.txtPassword.Size = new System.Drawing.Size(208, 24);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(430, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 17);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "كلـــــمــة المـرور:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(430, 58);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(106, 17);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "أسم المستخدم:";
            // 
            // Pre_UsersTableAdapter
            // 
            this.Pre_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // txtBranch
            // 
            this.txtBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranch.DataSource = this.preBranchesPermissionsBindingSource;
            this.txtBranch.DisplayMember = "BranchTitle";
            this.txtBranch.FormattingEnabled = true;
            this.txtBranch.Location = new System.Drawing.Point(192, 190);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(208, 25);
            this.txtBranch.TabIndex = 24;
            this.txtBranch.ValueMember = "BranchID";
            // 
            // preBranchesPermissionsBindingSource
            // 
            this.preBranchesPermissionsBindingSource.DataMember = "Pre_BranchesPermissions";
            this.preBranchesPermissionsBindingSource.DataSource = this.premission;
            // 
            // premission
            // 
            this.premission.DataSetName = "Premission";
            this.premission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lupBranchListBindingSource
            // 
            this.lupBranchListBindingSource.DataMember = "Lup_BranchList";
            this.lupBranchListBindingSource.DataSource = this.lupComboFill;
            // 
            // lupComboFill
            // 
            this.lupComboFill.DataSetName = "LupComboFill";
            this.lupComboFill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "الفرع / المشروع:";
            // 
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // pre_BranchesPermissionsTableAdapter
            // 
            this.pre_BranchesPermissionsTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.CmdDoLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 241);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CmdDoLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف المستخدم";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preAccountListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Authentication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preBranchesPermissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtUserName;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CmdDoLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private AppDataSets.Authentication Authentication;
        private System.Windows.Forms.BindingSource preAccountListBindingSource;
        private AppDataSets.AuthenticationTableAdapters.Pre_UsersTableAdapter Pre_UsersTableAdapter;
        private System.Windows.Forms.ComboBox txtBranch;
        private System.Windows.Forms.Label label1;
        private AppDataSets.LupComboFill lupComboFill;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        private AppDataSets.LupComboFillTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.Premission premission;
        private System.Windows.Forms.BindingSource preBranchesPermissionsBindingSource;
        private AppDataSets.PremissionTableAdapters.Pre_BranchesPermissionsTableAdapter pre_BranchesPermissionsTableAdapter;
    }
}