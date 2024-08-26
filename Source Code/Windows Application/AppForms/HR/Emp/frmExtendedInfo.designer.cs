namespace TMS.AppForms.HR.Emp
{
    partial class frmExtendedInfo
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
            System.Windows.Forms.Label empNameARLabel;
            System.Windows.Forms.Label nationalIDNoLabel;
            System.Windows.Forms.Label nationalIDIssueDateLabel;
            System.Windows.Forms.Label nationalIDExpireDateLabel;
            System.Windows.Forms.Label passportExpireDateLabel;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label bankAccountNoLabel;
            System.Windows.Forms.Label socialInssuranceNoLabel;
            System.Windows.Forms.Label socialInssuranceOfficeIDLabel;
            System.Windows.Forms.Label firstInssuranceDateLabel;
            System.Windows.Forms.Label inssuranceDateLabel;
            System.Windows.Forms.Label healthInsuranceTypeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtendedInfo));
            this.nationalIDNoTextBox = new System.Windows.Forms.TextBox();
            this.nationalIDIssueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nationalIDExpireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IsHasPassport = new System.Windows.Forms.CheckBox();
            this.passportNoTextBox = new System.Windows.Forms.TextBox();
            this.passportExpireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ISHasPrivateCar = new System.Windows.Forms.CheckBox();
            this.drivingLicenseIDTextBox = new System.Windows.Forms.TextBox();
            this.bankAccountNoTextBox = new System.Windows.Forms.TextBox();
            this.socialInssuranceNoTextBox = new System.Windows.Forms.TextBox();
            this.firstInssuranceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inssuranceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CbEmpID = new System.Windows.Forms.ComboBox();
            this.lupEmpNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new TMS.AppDataSetsHR.EmpDataSet();
            this.txtBankID = new System.Windows.Forms.ComboBox();
            this.hRLupBankListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupDataSet = new TMS.AppDataSetsHR.LupDataSet();
            this.txtInsuranceOfficeID = new System.Windows.Forms.ComboBox();
            this.hRLupSocialInssuranceOfficesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHealthInsuranceTypeID = new System.Windows.Forms.ComboBox();
            this.hRLupHealthInsuranceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_BankListTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_BankListTableAdapter();
            this.hR_Lup_SocialInssuranceOfficesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialInssuranceOfficesTableAdapter();
            this.hR_Lup_HealthInsuranceTypesTableAdapter = new TMS.AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_HealthInsuranceTypesTableAdapter();
            this.lup_EmpNameListTableAdapter = new TMS.AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.passportNolbl = new System.Windows.Forms.Label();
            this.drivingLicenseIDLbl = new System.Windows.Forms.Label();
            this.PictureBG = new System.Windows.Forms.PictureBox();
            empNameARLabel = new System.Windows.Forms.Label();
            nationalIDNoLabel = new System.Windows.Forms.Label();
            nationalIDIssueDateLabel = new System.Windows.Forms.Label();
            nationalIDExpireDateLabel = new System.Windows.Forms.Label();
            passportExpireDateLabel = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            bankAccountNoLabel = new System.Windows.Forms.Label();
            socialInssuranceNoLabel = new System.Windows.Forms.Label();
            socialInssuranceOfficeIDLabel = new System.Windows.Forms.Label();
            firstInssuranceDateLabel = new System.Windows.Forms.Label();
            inssuranceDateLabel = new System.Windows.Forms.Label();
            healthInsuranceTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialInssuranceOfficesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupHealthInsuranceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).BeginInit();
            this.SuspendLayout();
            // 
            // empNameARLabel
            // 
            empNameARLabel.AutoSize = true;
            empNameARLabel.Location = new System.Drawing.Point(785, 33);
            empNameARLabel.Name = "empNameARLabel";
            empNameARLabel.Size = new System.Drawing.Size(88, 17);
            empNameARLabel.TabIndex = 5;
            empNameARLabel.Text = "أسم الموظف:";
            // 
            // nationalIDNoLabel
            // 
            nationalIDNoLabel.AutoSize = true;
            nationalIDNoLabel.Location = new System.Drawing.Point(735, 63);
            nationalIDNoLabel.Name = "nationalIDNoLabel";
            nationalIDNoLabel.Size = new System.Drawing.Size(138, 17);
            nationalIDNoLabel.TabIndex = 7;
            nationalIDNoLabel.Text = "رقم البطاقة الشخصية:";
            // 
            // nationalIDIssueDateLabel
            // 
            nationalIDIssueDateLabel.AutoSize = true;
            nationalIDIssueDateLabel.Location = new System.Drawing.Point(790, 96);
            nationalIDIssueDateLabel.Name = "nationalIDIssueDateLabel";
            nationalIDIssueDateLabel.Size = new System.Drawing.Size(83, 17);
            nationalIDIssueDateLabel.TabIndex = 9;
            nationalIDIssueDateLabel.Text = "تاريخ الإصدار:";
            // 
            // nationalIDExpireDateLabel
            // 
            nationalIDExpireDateLabel.AutoSize = true;
            nationalIDExpireDateLabel.Location = new System.Drawing.Point(791, 126);
            nationalIDExpireDateLabel.Name = "nationalIDExpireDateLabel";
            nationalIDExpireDateLabel.Size = new System.Drawing.Size(82, 17);
            nationalIDExpireDateLabel.TabIndex = 11;
            nationalIDExpireDateLabel.Text = "تاريخ الإنتهاء:";
            // 
            // passportExpireDateLabel
            // 
            passportExpireDateLabel.AutoSize = true;
            passportExpireDateLabel.Location = new System.Drawing.Point(791, 216);
            passportExpireDateLabel.Name = "passportExpireDateLabel";
            passportExpireDateLabel.Size = new System.Drawing.Size(82, 17);
            passportExpireDateLabel.TabIndex = 17;
            passportExpireDateLabel.Text = "تاريخ الأنتهاء:";
            // 
            // bankIDLabel
            // 
            bankIDLabel.AutoSize = true;
            bankIDLabel.Location = new System.Drawing.Point(801, 243);
            bankIDLabel.Name = "bankIDLabel";
            bankIDLabel.Size = new System.Drawing.Size(72, 17);
            bankIDLabel.TabIndex = 23;
            bankIDLabel.Text = "أسم البنك:";
            bankIDLabel.Visible = false;
            // 
            // bankAccountNoLabel
            // 
            bankAccountNoLabel.AutoSize = true;
            bankAccountNoLabel.Location = new System.Drawing.Point(364, 243);
            bankAccountNoLabel.Name = "bankAccountNoLabel";
            bankAccountNoLabel.Size = new System.Drawing.Size(85, 17);
            bankAccountNoLabel.TabIndex = 25;
            bankAccountNoLabel.Text = "رقم الحساب:";
            bankAccountNoLabel.Visible = false;
            // 
            // socialInssuranceNoLabel
            // 
            socialInssuranceNoLabel.AutoSize = true;
            socialInssuranceNoLabel.Location = new System.Drawing.Point(363, 277);
            socialInssuranceNoLabel.Name = "socialInssuranceNoLabel";
            socialInssuranceNoLabel.Size = new System.Drawing.Size(86, 17);
            socialInssuranceNoLabel.TabIndex = 27;
            socialInssuranceNoLabel.Text = "رقم التأمينات:";
            // 
            // socialInssuranceOfficeIDLabel
            // 
            socialInssuranceOfficeIDLabel.AutoSize = true;
            socialInssuranceOfficeIDLabel.Location = new System.Drawing.Point(776, 277);
            socialInssuranceOfficeIDLabel.Name = "socialInssuranceOfficeIDLabel";
            socialInssuranceOfficeIDLabel.Size = new System.Drawing.Size(97, 17);
            socialInssuranceOfficeIDLabel.TabIndex = 29;
            socialInssuranceOfficeIDLabel.Text = "مكتب التأمينات:";
            // 
            // firstInssuranceDateLabel
            // 
            firstInssuranceDateLabel.AutoSize = true;
            firstInssuranceDateLabel.Location = new System.Drawing.Point(759, 306);
            firstInssuranceDateLabel.Name = "firstInssuranceDateLabel";
            firstInssuranceDateLabel.Size = new System.Drawing.Size(114, 17);
            firstInssuranceDateLabel.TabIndex = 31;
            firstInssuranceDateLabel.Text = "تاريخ بداية التأمين:";
            // 
            // inssuranceDateLabel
            // 
            inssuranceDateLabel.AutoSize = true;
            inssuranceDateLabel.Location = new System.Drawing.Point(753, 363);
            inssuranceDateLabel.Name = "inssuranceDateLabel";
            inssuranceDateLabel.Size = new System.Drawing.Size(120, 17);
            inssuranceDateLabel.TabIndex = 33;
            inssuranceDateLabel.Text = "نوع التأمين الصحي:";
            // 
            // healthInsuranceTypeIDLabel
            // 
            healthInsuranceTypeIDLabel.AutoSize = true;
            healthInsuranceTypeIDLabel.Location = new System.Drawing.Point(729, 336);
            healthInsuranceTypeIDLabel.Name = "healthInsuranceTypeIDLabel";
            healthInsuranceTypeIDLabel.Size = new System.Drawing.Size(144, 17);
            healthInsuranceTypeIDLabel.TabIndex = 35;
            healthInsuranceTypeIDLabel.Text = "تاريخ التأمين في العمل:";
            // 
            // nationalIDNoTextBox
            // 
            this.nationalIDNoTextBox.Location = new System.Drawing.Point(512, 60);
            this.nationalIDNoTextBox.Name = "nationalIDNoTextBox";
            this.nationalIDNoTextBox.Size = new System.Drawing.Size(200, 24);
            this.nationalIDNoTextBox.TabIndex = 8;
            this.nationalIDNoTextBox.Text = "0";
            this.nationalIDNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nationalIDNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nationalIDNoTextBox_KeyPress);
            // 
            // nationalIDIssueDateDateTimePicker
            // 
            this.nationalIDIssueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nationalIDIssueDateDateTimePicker.Location = new System.Drawing.Point(557, 90);
            this.nationalIDIssueDateDateTimePicker.Name = "nationalIDIssueDateDateTimePicker";
            this.nationalIDIssueDateDateTimePicker.Size = new System.Drawing.Size(155, 24);
            this.nationalIDIssueDateDateTimePicker.TabIndex = 10;
            this.nationalIDIssueDateDateTimePicker.ValueChanged += new System.EventHandler(this.nationalIDIssueDateDateTimePicker_ValueChanged);
            // 
            // nationalIDExpireDateDateTimePicker
            // 
            this.nationalIDExpireDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nationalIDExpireDateDateTimePicker.Location = new System.Drawing.Point(557, 120);
            this.nationalIDExpireDateDateTimePicker.Name = "nationalIDExpireDateDateTimePicker";
            this.nationalIDExpireDateDateTimePicker.Size = new System.Drawing.Size(155, 24);
            this.nationalIDExpireDateDateTimePicker.TabIndex = 12;
            // 
            // IsHasPassport
            // 
            this.IsHasPassport.Location = new System.Drawing.Point(570, 150);
            this.IsHasPassport.Name = "IsHasPassport";
            this.IsHasPassport.Size = new System.Drawing.Size(142, 24);
            this.IsHasPassport.TabIndex = 14;
            this.IsHasPassport.Text = "يمتلك جواز سفر";
            this.IsHasPassport.UseVisualStyleBackColor = true;
            this.IsHasPassport.CheckedChanged += new System.EventHandler(this.IsHasPassport_CheckedChanged);
            // 
            // passportNoTextBox
            // 
            this.passportNoTextBox.Location = new System.Drawing.Point(521, 180);
            this.passportNoTextBox.Name = "passportNoTextBox";
            this.passportNoTextBox.Size = new System.Drawing.Size(200, 24);
            this.passportNoTextBox.TabIndex = 16;
            this.passportNoTextBox.Text = "0";
            this.passportNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passportNoTextBox.Visible = false;
            // 
            // passportExpireDateDateTimePicker
            // 
            this.passportExpireDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.passportExpireDateDateTimePicker.Location = new System.Drawing.Point(557, 210);
            this.passportExpireDateDateTimePicker.Name = "passportExpireDateDateTimePicker";
            this.passportExpireDateDateTimePicker.Size = new System.Drawing.Size(164, 24);
            this.passportExpireDateDateTimePicker.TabIndex = 18;
            // 
            // ISHasPrivateCar
            // 
            this.ISHasPrivateCar.Location = new System.Drawing.Point(131, 150);
            this.ISHasPrivateCar.Name = "ISHasPrivateCar";
            this.ISHasPrivateCar.Size = new System.Drawing.Size(200, 24);
            this.ISHasPrivateCar.TabIndex = 20;
            this.ISHasPrivateCar.Text = "يمتلك سيارة خاصة";
            this.ISHasPrivateCar.UseVisualStyleBackColor = true;
            this.ISHasPrivateCar.CheckedChanged += new System.EventHandler(this.ISHasPrivateCar_CheckedChanged);
            // 
            // drivingLicenseIDTextBox
            // 
            this.drivingLicenseIDTextBox.Location = new System.Drawing.Point(131, 180);
            this.drivingLicenseIDTextBox.Name = "drivingLicenseIDTextBox";
            this.drivingLicenseIDTextBox.Size = new System.Drawing.Size(200, 24);
            this.drivingLicenseIDTextBox.TabIndex = 22;
            this.drivingLicenseIDTextBox.Text = "0";
            this.drivingLicenseIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drivingLicenseIDTextBox.Visible = false;
            this.drivingLicenseIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drivingLicenseIDTextBox_KeyPress);
            // 
            // bankAccountNoTextBox
            // 
            this.bankAccountNoTextBox.Location = new System.Drawing.Point(131, 236);
            this.bankAccountNoTextBox.Name = "bankAccountNoTextBox";
            this.bankAccountNoTextBox.Size = new System.Drawing.Size(200, 24);
            this.bankAccountNoTextBox.TabIndex = 26;
            this.bankAccountNoTextBox.Text = "0";
            this.bankAccountNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bankAccountNoTextBox.Visible = false;
            this.bankAccountNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankAccountNoTextBox_KeyPress);
            // 
            // socialInssuranceNoTextBox
            // 
            this.socialInssuranceNoTextBox.Location = new System.Drawing.Point(131, 274);
            this.socialInssuranceNoTextBox.Name = "socialInssuranceNoTextBox";
            this.socialInssuranceNoTextBox.Size = new System.Drawing.Size(200, 24);
            this.socialInssuranceNoTextBox.TabIndex = 28;
            this.socialInssuranceNoTextBox.Text = "0";
            this.socialInssuranceNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.socialInssuranceNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.socialInssuranceNoTextBox_KeyPress);
            // 
            // firstInssuranceDateDateTimePicker
            // 
            this.firstInssuranceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstInssuranceDateDateTimePicker.Location = new System.Drawing.Point(568, 300);
            this.firstInssuranceDateDateTimePicker.Name = "firstInssuranceDateDateTimePicker";
            this.firstInssuranceDateDateTimePicker.Size = new System.Drawing.Size(153, 24);
            this.firstInssuranceDateDateTimePicker.TabIndex = 32;
            // 
            // inssuranceDateDateTimePicker
            // 
            this.inssuranceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inssuranceDateDateTimePicker.Location = new System.Drawing.Point(568, 330);
            this.inssuranceDateDateTimePicker.Name = "inssuranceDateDateTimePicker";
            this.inssuranceDateDateTimePicker.Size = new System.Drawing.Size(153, 24);
            this.inssuranceDateDateTimePicker.TabIndex = 34;
            // 
            // CbEmpID
            // 
            this.CbEmpID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbEmpID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbEmpID.DataSource = this.lupEmpNameListBindingSource;
            this.CbEmpID.DisplayMember = "EmpNameAR";
            this.CbEmpID.FormattingEnabled = true;
            this.CbEmpID.Location = new System.Drawing.Point(486, 29);
            this.CbEmpID.Name = "CbEmpID";
            this.CbEmpID.Size = new System.Drawing.Size(226, 25);
            this.CbEmpID.TabIndex = 48;
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
            // txtBankID
            // 
            this.txtBankID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBankID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBankID.DataSource = this.hRLupBankListBindingSource;
            this.txtBankID.DisplayMember = "BankTitle";
            this.txtBankID.FormattingEnabled = true;
            this.txtBankID.Location = new System.Drawing.Point(495, 238);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(226, 25);
            this.txtBankID.TabIndex = 49;
            this.txtBankID.ValueMember = "BankID";
            this.txtBankID.Visible = false;
            // 
            // hRLupBankListBindingSource
            // 
            this.hRLupBankListBindingSource.DataMember = "HR_Lup_BankList";
            this.hRLupBankListBindingSource.DataSource = this.lupDataSet;
            // 
            // lupDataSet
            // 
            this.lupDataSet.DataSetName = "LupDataSet";
            this.lupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInsuranceOfficeID
            // 
            this.txtInsuranceOfficeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInsuranceOfficeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtInsuranceOfficeID.DataSource = this.hRLupSocialInssuranceOfficesBindingSource;
            this.txtInsuranceOfficeID.DisplayMember = "SocialInssuranceOfficeNameAr";
            this.txtInsuranceOfficeID.FormattingEnabled = true;
            this.txtInsuranceOfficeID.Location = new System.Drawing.Point(495, 269);
            this.txtInsuranceOfficeID.Name = "txtInsuranceOfficeID";
            this.txtInsuranceOfficeID.Size = new System.Drawing.Size(226, 25);
            this.txtInsuranceOfficeID.TabIndex = 50;
            this.txtInsuranceOfficeID.ValueMember = "SocialInssuranceOfficeID";
            // 
            // hRLupSocialInssuranceOfficesBindingSource
            // 
            this.hRLupSocialInssuranceOfficesBindingSource.DataMember = "HR_Lup_SocialInssuranceOffices";
            this.hRLupSocialInssuranceOfficesBindingSource.DataSource = this.lupDataSet;
            // 
            // txtHealthInsuranceTypeID
            // 
            this.txtHealthInsuranceTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHealthInsuranceTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtHealthInsuranceTypeID.DataSource = this.hRLupHealthInsuranceTypesBindingSource;
            this.txtHealthInsuranceTypeID.DisplayMember = "HealthInsuranceTypeAr";
            this.txtHealthInsuranceTypeID.FormattingEnabled = true;
            this.txtHealthInsuranceTypeID.Location = new System.Drawing.Point(495, 360);
            this.txtHealthInsuranceTypeID.Name = "txtHealthInsuranceTypeID";
            this.txtHealthInsuranceTypeID.Size = new System.Drawing.Size(226, 25);
            this.txtHealthInsuranceTypeID.TabIndex = 51;
            this.txtHealthInsuranceTypeID.ValueMember = "HealthInsuranceTypeID";
            // 
            // hRLupHealthInsuranceTypesBindingSource
            // 
            this.hRLupHealthInsuranceTypesBindingSource.DataMember = "HR_Lup_HealthInsuranceTypes";
            this.hRLupHealthInsuranceTypesBindingSource.DataSource = this.lupDataSet;
            // 
            // hR_Lup_BankListTableAdapter
            // 
            this.hR_Lup_BankListTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_SocialInssuranceOfficesTableAdapter
            // 
            this.hR_Lup_SocialInssuranceOfficesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Lup_HealthInsuranceTypesTableAdapter
            // 
            this.hR_Lup_HealthInsuranceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // lup_EmpNameListTableAdapter
            // 
            this.lup_EmpNameListTableAdapter.ClearBeforeFill = true;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Location = new System.Drawing.Point(49, 353);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 54;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNew.Location = new System.Drawing.Point(174, 353);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 53;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(49, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 55;
            // 
            // passportNolbl
            // 
            this.passportNolbl.AutoSize = true;
            this.passportNolbl.Location = new System.Drawing.Point(773, 183);
            this.passportNolbl.Name = "passportNolbl";
            this.passportNolbl.Size = new System.Drawing.Size(100, 17);
            this.passportNolbl.TabIndex = 56;
            this.passportNolbl.Text = "رقم جواز السفر:";
            this.passportNolbl.Visible = false;
            // 
            // drivingLicenseIDLbl
            // 
            this.drivingLicenseIDLbl.AutoSize = true;
            this.drivingLicenseIDLbl.Location = new System.Drawing.Point(337, 183);
            this.drivingLicenseIDLbl.Name = "drivingLicenseIDLbl";
            this.drivingLicenseIDLbl.Size = new System.Drawing.Size(112, 17);
            this.drivingLicenseIDLbl.TabIndex = 57;
            this.drivingLicenseIDLbl.Text = "رقم رخصة القياده:";
            this.drivingLicenseIDLbl.Visible = false;
            // 
            // PictureBG
            // 
            this.PictureBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBG.Image = ((System.Drawing.Image)(resources.GetObject("PictureBG.Image")));
            this.PictureBG.Location = new System.Drawing.Point(0, 0);
            this.PictureBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBG.Name = "PictureBG";
            this.PictureBG.Size = new System.Drawing.Size(902, 404);
            this.PictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBG.TabIndex = 70;
            this.PictureBG.TabStop = false;
            // 
            // frmExtendedInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(902, 404);
            this.Controls.Add(this.drivingLicenseIDLbl);
            this.Controls.Add(this.passportNolbl);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtHealthInsuranceTypeID);
            this.Controls.Add(this.txtInsuranceOfficeID);
            this.Controls.Add(this.txtBankID);
            this.Controls.Add(this.CbEmpID);
            this.Controls.Add(empNameARLabel);
            this.Controls.Add(nationalIDNoLabel);
            this.Controls.Add(this.nationalIDNoTextBox);
            this.Controls.Add(nationalIDIssueDateLabel);
            this.Controls.Add(this.nationalIDIssueDateDateTimePicker);
            this.Controls.Add(nationalIDExpireDateLabel);
            this.Controls.Add(this.nationalIDExpireDateDateTimePicker);
            this.Controls.Add(this.IsHasPassport);
            this.Controls.Add(this.passportNoTextBox);
            this.Controls.Add(passportExpireDateLabel);
            this.Controls.Add(this.passportExpireDateDateTimePicker);
            this.Controls.Add(this.ISHasPrivateCar);
            this.Controls.Add(this.drivingLicenseIDTextBox);
            this.Controls.Add(bankIDLabel);
            this.Controls.Add(bankAccountNoLabel);
            this.Controls.Add(this.bankAccountNoTextBox);
            this.Controls.Add(socialInssuranceNoLabel);
            this.Controls.Add(this.socialInssuranceNoTextBox);
            this.Controls.Add(socialInssuranceOfficeIDLabel);
            this.Controls.Add(firstInssuranceDateLabel);
            this.Controls.Add(this.firstInssuranceDateDateTimePicker);
            this.Controls.Add(inssuranceDateLabel);
            this.Controls.Add(this.inssuranceDateDateTimePicker);
            this.Controls.Add(healthInsuranceTypeIDLabel);
            this.Controls.Add(this.PictureBG);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmExtendedInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات إضافيه";
            this.Load += new System.EventHandler(this.frmPapers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lupEmpNameListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupBankListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupSocialInssuranceOfficesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupHealthInsuranceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nationalIDNoTextBox;
        private System.Windows.Forms.DateTimePicker nationalIDIssueDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker nationalIDExpireDateDateTimePicker;
        private System.Windows.Forms.CheckBox IsHasPassport;
        private System.Windows.Forms.TextBox passportNoTextBox;
        private System.Windows.Forms.DateTimePicker passportExpireDateDateTimePicker;
        private System.Windows.Forms.CheckBox ISHasPrivateCar;
        private System.Windows.Forms.TextBox drivingLicenseIDTextBox;
        private System.Windows.Forms.TextBox bankAccountNoTextBox;
        private System.Windows.Forms.TextBox socialInssuranceNoTextBox;
        private System.Windows.Forms.DateTimePicker firstInssuranceDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker inssuranceDateDateTimePicker;
        private System.Windows.Forms.ComboBox CbEmpID;
        private System.Windows.Forms.ComboBox txtBankID;
        private System.Windows.Forms.ComboBox txtInsuranceOfficeID;
        private System.Windows.Forms.ComboBox txtHealthInsuranceTypeID;
        private AppDataSetsHR.LupDataSet lupDataSet;
        private System.Windows.Forms.BindingSource hRLupBankListBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_BankListTableAdapter hR_Lup_BankListTableAdapter;
        private System.Windows.Forms.BindingSource hRLupSocialInssuranceOfficesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_SocialInssuranceOfficesTableAdapter hR_Lup_SocialInssuranceOfficesTableAdapter;
        private System.Windows.Forms.BindingSource hRLupHealthInsuranceTypesBindingSource;
        private AppDataSetsHR.LupDataSetTableAdapters.HR_Lup_HealthInsuranceTypesTableAdapter hR_Lup_HealthInsuranceTypesTableAdapter;
        private AppDataSetsHR.EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource lupEmpNameListBindingSource;
        private AppDataSetsHR.EmpDataSetTableAdapters.Lup_EmpNameListTableAdapter lup_EmpNameListTableAdapter;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label passportNolbl;
        private System.Windows.Forms.Label drivingLicenseIDLbl;
        internal System.Windows.Forms.PictureBox PictureBG;

    }
}