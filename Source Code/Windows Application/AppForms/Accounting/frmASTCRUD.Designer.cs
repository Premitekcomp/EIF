namespace TMS.AppForms.Accounting
{
    partial class frmASTCRUD
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtASTSerial = new System.Windows.Forms.TextBox();
            this.txtStatusID = new System.Windows.Forms.ComboBox();
            this.aSTLupAssetsStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting = new TMS.AppDataSets.Accounting();
            this.lblMSG = new System.Windows.Forms.Label();
            this.dtBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtASTName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuyCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtStartDep = new System.Windows.Forms.DateTimePicker();
            this.txtDepCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepPercentage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.dtSellDate = new System.Windows.Forms.DateTimePicker();
            this.lblScrabDate = new System.Windows.Forms.Label();
            this.dtScrapDate = new System.Windows.Forms.DateTimePicker();
            this.txtSellScrabCost = new System.Windows.Forms.TextBox();
            this.lblScrabValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtASTGroupID = new System.Windows.Forms.ComboBox();
            this.aSTGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtASTLocation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.ComboBox();
            this.lupBranchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lupComboFill = new TMS.AppDataSets.LupComboFill();
            this.lup_BranchListTableAdapter = new TMS.AppDataSets.LupComboFillTableAdapters.Lup_BranchListTableAdapter();
            this.aST_Lup_AssetsStateTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AST_Lup_AssetsStateTableAdapter();
            this.aST_GroupsTableAdapter = new TMS.AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter();
            this.lblSerialError = new System.Windows.Forms.Label();
            this.CmdAddGroup = new System.Windows.Forms.Button();
            this.CmdRefreshGroups = new System.Windows.Forms.Button();
            this.CmdSell = new System.Windows.Forms.Button();
            this.CmdScrape = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSaveNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aSTLupAssetsStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdSave.ForeColor = System.Drawing.Color.White;
            this.CmdSave.Location = new System.Drawing.Point(117, 443);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(325, 58);
            this.CmdSave.TabIndex = 16;
            this.CmdSave.Text = "حفظ و خروج";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "كود الاصل:";
            // 
            // txtASTSerial
            // 
            this.txtASTSerial.Location = new System.Drawing.Point(607, 31);
            this.txtASTSerial.Name = "txtASTSerial";
            this.txtASTSerial.Size = new System.Drawing.Size(200, 32);
            this.txtASTSerial.TabIndex = 1;
            this.txtASTSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtASTSerial.Leave += new System.EventHandler(this.txtASTSerial_Leave);
            // 
            // txtStatusID
            // 
            this.txtStatusID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStatusID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStatusID.DataSource = this.aSTLupAssetsStateBindingSource;
            this.txtStatusID.DisplayMember = "AssetStateTitle";
            this.txtStatusID.FormattingEnabled = true;
            this.txtStatusID.Location = new System.Drawing.Point(94, 31);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(170, 32);
            this.txtStatusID.TabIndex = 3;
            this.txtStatusID.ValueMember = "AssetStateID";
            // 
            // aSTLupAssetsStateBindingSource
            // 
            this.aSTLupAssetsStateBindingSource.DataMember = "AST_Lup_AssetsState";
            this.aSTLupAssetsStateBindingSource.DataSource = this.accounting;
            // 
            // accounting
            // 
            this.accounting.DataSetName = "Accounting";
            this.accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Location = new System.Drawing.Point(12, 9);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 24);
            this.lblMSG.TabIndex = 4;
            // 
            // dtBuyDate
            // 
            this.dtBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuyDate.Location = new System.Drawing.Point(683, 107);
            this.dtBuyDate.Name = "dtBuyDate";
            this.dtBuyDate.Size = new System.Drawing.Size(124, 32);
            this.dtBuyDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "وضع الإهلاك:";
            // 
            // txtASTName
            // 
            this.txtASTName.Location = new System.Drawing.Point(399, 69);
            this.txtASTName.Name = "txtASTName";
            this.txtASTName.Size = new System.Drawing.Size(408, 32);
            this.txtASTName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "الاسم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ الشراء:";
            // 
            // txtBuyCost
            // 
            this.txtBuyCost.Location = new System.Drawing.Point(336, 107);
            this.txtBuyCost.Name = "txtBuyCost";
            this.txtBuyCost.Size = new System.Drawing.Size(200, 32);
            this.txtBuyCost.TabIndex = 5;
            this.txtBuyCost.Text = "0";
            this.txtBuyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuyCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "تكلفة الشراء:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاريخ بداية الإهلاك:";
            // 
            // dtStartDep
            // 
            this.dtStartDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDep.Location = new System.Drawing.Point(683, 145);
            this.dtStartDep.Name = "dtStartDep";
            this.dtStartDep.Size = new System.Drawing.Size(124, 32);
            this.dtStartDep.TabIndex = 6;
            // 
            // txtDepCost
            // 
            this.txtDepCost.Location = new System.Drawing.Point(336, 148);
            this.txtDepCost.Name = "txtDepCost";
            this.txtDepCost.Size = new System.Drawing.Size(200, 32);
            this.txtDepCost.TabIndex = 7;
            this.txtDepCost.Text = "0";
            this.txtDepCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "قيمة بداية الإهلاك:";
            // 
            // txtDepPercentage
            // 
            this.txtDepPercentage.Location = new System.Drawing.Point(94, 148);
            this.txtDepPercentage.Name = "txtDepPercentage";
            this.txtDepPercentage.Size = new System.Drawing.Size(80, 32);
            this.txtDepPercentage.TabIndex = 8;
            this.txtDepPercentage.Text = "0";
            this.txtDepPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "نسبة الإهلاك:";
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Location = new System.Drawing.Point(813, 353);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(65, 24);
            this.lblSellDate.TabIndex = 19;
            this.lblSellDate.Text = "تاريخ البيع:";
            this.lblSellDate.Visible = false;
            // 
            // dtSellDate
            // 
            this.dtSellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSellDate.Location = new System.Drawing.Point(683, 347);
            this.dtSellDate.Name = "dtSellDate";
            this.dtSellDate.Size = new System.Drawing.Size(124, 32);
            this.dtSellDate.TabIndex = 13;
            this.dtSellDate.Visible = false;
            // 
            // lblScrabDate
            // 
            this.lblScrabDate.AutoSize = true;
            this.lblScrabDate.Location = new System.Drawing.Point(542, 353);
            this.lblScrabDate.Name = "lblScrabDate";
            this.lblScrabDate.Size = new System.Drawing.Size(79, 24);
            this.lblScrabDate.TabIndex = 21;
            this.lblScrabDate.Text = "تاريخ الإهلاك:";
            this.lblScrabDate.Visible = false;
            // 
            // dtScrapDate
            // 
            this.dtScrapDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtScrapDate.Location = new System.Drawing.Point(412, 347);
            this.dtScrapDate.Name = "dtScrapDate";
            this.dtScrapDate.Size = new System.Drawing.Size(124, 32);
            this.dtScrapDate.TabIndex = 14;
            this.dtScrapDate.Visible = false;
            // 
            // txtSellScrabCost
            // 
            this.txtSellScrabCost.Location = new System.Drawing.Point(94, 347);
            this.txtSellScrabCost.Name = "txtSellScrabCost";
            this.txtSellScrabCost.Size = new System.Drawing.Size(80, 32);
            this.txtSellScrabCost.TabIndex = 15;
            this.txtSellScrabCost.Text = "0";
            this.txtSellScrabCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSellScrabCost.Visible = false;
            this.txtSellScrabCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlidateDecimalInput);
            // 
            // lblScrabValue
            // 
            this.lblScrabValue.AutoSize = true;
            this.lblScrabValue.Location = new System.Drawing.Point(180, 350);
            this.lblScrabValue.Name = "lblScrabValue";
            this.lblScrabValue.Size = new System.Drawing.Size(146, 24);
            this.lblScrabValue.TabIndex = 22;
            this.lblScrabValue.Text = "قيمة الإهلاك / التكهيين:";
            this.lblScrabValue.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(813, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "مجموعة الأصل:";
            // 
            // txtASTGroupID
            // 
            this.txtASTGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtASTGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtASTGroupID.DataSource = this.aSTGroupsBindingSource;
            this.txtASTGroupID.DisplayMember = "ASTGroupTitle";
            this.txtASTGroupID.FormattingEnabled = true;
            this.txtASTGroupID.Location = new System.Drawing.Point(637, 183);
            this.txtASTGroupID.Name = "txtASTGroupID";
            this.txtASTGroupID.Size = new System.Drawing.Size(170, 32);
            this.txtASTGroupID.TabIndex = 9;
            this.txtASTGroupID.ValueMember = "ASTGroupID";
            // 
            // aSTGroupsBindingSource
            // 
            this.aSTGroupsBindingSource.DataMember = "AST_Groups";
            this.aSTGroupsBindingSource.DataSource = this.accounting;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(336, 259);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(471, 82);
            this.txtNote.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(813, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "مكان الأصل:";
            // 
            // txtASTLocation
            // 
            this.txtASTLocation.Location = new System.Drawing.Point(399, 221);
            this.txtASTLocation.Name = "txtASTLocation";
            this.txtASTLocation.Size = new System.Drawing.Size(408, 32);
            this.txtASTLocation.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(813, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "ملاحظات:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "الفرع:";
            // 
            // txtBranchID
            // 
            this.txtBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBranchID.DataSource = this.lupBranchListBindingSource;
            this.txtBranchID.DisplayMember = "BranchTitle";
            this.txtBranchID.FormattingEnabled = true;
            this.txtBranchID.Location = new System.Drawing.Point(94, 221);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(170, 32);
            this.txtBranchID.TabIndex = 11;
            this.txtBranchID.ValueMember = "BranchID";
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
            // lup_BranchListTableAdapter
            // 
            this.lup_BranchListTableAdapter.ClearBeforeFill = true;
            // 
            // aST_Lup_AssetsStateTableAdapter
            // 
            this.aST_Lup_AssetsStateTableAdapter.ClearBeforeFill = true;
            // 
            // aST_GroupsTableAdapter
            // 
            this.aST_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // lblSerialError
            // 
            this.lblSerialError.AutoSize = true;
            this.lblSerialError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSerialError.Location = new System.Drawing.Point(564, 34);
            this.lblSerialError.Name = "lblSerialError";
            this.lblSerialError.Size = new System.Drawing.Size(37, 24);
            this.lblSerialError.TabIndex = 33;
            this.lblSerialError.Text = "مكرر";
            this.lblSerialError.Visible = false;
            // 
            // CmdAddGroup
            // 
            this.CmdAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddGroup.Location = new System.Drawing.Point(594, 183);
            this.CmdAddGroup.Name = "CmdAddGroup";
            this.CmdAddGroup.Size = new System.Drawing.Size(37, 32);
            this.CmdAddGroup.TabIndex = 34;
            this.CmdAddGroup.Text = "+";
            this.CmdAddGroup.UseVisualStyleBackColor = true;
            this.CmdAddGroup.Click += new System.EventHandler(this.CmdAddGroup_Click);
            // 
            // CmdRefreshGroups
            // 
            this.CmdRefreshGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRefreshGroups.Location = new System.Drawing.Point(551, 183);
            this.CmdRefreshGroups.Name = "CmdRefreshGroups";
            this.CmdRefreshGroups.Size = new System.Drawing.Size(37, 32);
            this.CmdRefreshGroups.TabIndex = 35;
            this.CmdRefreshGroups.Text = "()";
            this.CmdRefreshGroups.UseVisualStyleBackColor = true;
            this.CmdRefreshGroups.Click += new System.EventHandler(this.CmdRefreshGroups_Click);
            // 
            // CmdSell
            // 
            this.CmdSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSell.Location = new System.Drawing.Point(683, 385);
            this.CmdSell.Name = "CmdSell";
            this.CmdSell.Size = new System.Drawing.Size(58, 37);
            this.CmdSell.TabIndex = 36;
            this.CmdSell.Text = "بيع";
            this.CmdSell.UseVisualStyleBackColor = true;
            this.CmdSell.Click += new System.EventHandler(this.CmdSell_Click);
            // 
            // CmdScrape
            // 
            this.CmdScrape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdScrape.Location = new System.Drawing.Point(412, 385);
            this.CmdScrape.Name = "CmdScrape";
            this.CmdScrape.Size = new System.Drawing.Size(73, 37);
            this.CmdScrape.TabIndex = 37;
            this.CmdScrape.Text = "تكهيين";
            this.CmdScrape.UseVisualStyleBackColor = true;
            this.CmdScrape.Click += new System.EventHandler(this.CmdScrape_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.ForeColor = System.Drawing.Color.White;
            this.CmdCancel.Location = new System.Drawing.Point(270, 507);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(350, 58);
            this.CmdCancel.TabIndex = 38;
            this.CmdCancel.Text = "تراجع";
            this.CmdCancel.UseVisualStyleBackColor = false;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSaveNew
            // 
            this.CmdSaveNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdSaveNew.ForeColor = System.Drawing.Color.White;
            this.CmdSaveNew.Location = new System.Drawing.Point(448, 443);
            this.CmdSaveNew.Name = "CmdSaveNew";
            this.CmdSaveNew.Size = new System.Drawing.Size(325, 58);
            this.CmdSaveNew.TabIndex = 39;
            this.CmdSaveNew.Text = "حفظ و جديد";
            this.CmdSaveNew.UseVisualStyleBackColor = false;
            this.CmdSaveNew.Click += new System.EventHandler(this.CmdSaveNew_Click);
            // 
            // frmASTCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 570);
            this.Controls.Add(this.CmdSaveNew);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdScrape);
            this.Controls.Add(this.CmdSell);
            this.Controls.Add(this.CmdRefreshGroups);
            this.Controls.Add(this.CmdAddGroup);
            this.Controls.Add(this.lblSerialError);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtASTLocation);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtASTGroupID);
            this.Controls.Add(this.txtSellScrabCost);
            this.Controls.Add(this.lblScrabValue);
            this.Controls.Add(this.lblScrabDate);
            this.Controls.Add(this.dtScrapDate);
            this.Controls.Add(this.lblSellDate);
            this.Controls.Add(this.dtSellDate);
            this.Controls.Add(this.txtDepPercentage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDepCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtStartDep);
            this.Controls.Add(this.txtBuyCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtASTName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtBuyDate);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(this.txtASTSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSave);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmASTCRUD";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه / تعديل الاصول";
            this.Load += new System.EventHandler(this.frmASTCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aSTLupAssetsStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupBranchListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupComboFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtASTSerial;
        private System.Windows.Forms.ComboBox txtStatusID;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.DateTimePicker dtBuyDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtASTName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuyCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtStartDep;
        private System.Windows.Forms.TextBox txtDepCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepPercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.DateTimePicker dtSellDate;
        private System.Windows.Forms.Label lblScrabDate;
        private System.Windows.Forms.DateTimePicker dtScrapDate;
        private System.Windows.Forms.TextBox txtSellScrabCost;
        private System.Windows.Forms.Label lblScrabValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtASTGroupID;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtASTLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtBranchID;
        private AppDataSets.LupComboFill lupComboFill;
        private System.Windows.Forms.BindingSource lupBranchListBindingSource;
        private AppDataSets.LupComboFillTableAdapters.Lup_BranchListTableAdapter lup_BranchListTableAdapter;
        private AppDataSets.Accounting accounting;
        private System.Windows.Forms.BindingSource aSTLupAssetsStateBindingSource;
        private AppDataSets.AccountingTableAdapters.AST_Lup_AssetsStateTableAdapter aST_Lup_AssetsStateTableAdapter;
        private System.Windows.Forms.BindingSource aSTGroupsBindingSource;
        private AppDataSets.AccountingTableAdapters.AST_GroupsTableAdapter aST_GroupsTableAdapter;
        private System.Windows.Forms.Label lblSerialError;
        private System.Windows.Forms.Button CmdAddGroup;
        private System.Windows.Forms.Button CmdRefreshGroups;
        private System.Windows.Forms.Button CmdSell;
        private System.Windows.Forms.Button CmdScrape;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSaveNew;
    }
}