namespace TMS.AppForms.HR.HR_Rul
{
    partial class frmDelayRulesDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelayRuleID = new System.Windows.Forms.ComboBox();
            this.hRRulDelayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulDataSet = new TMS.AppDataSetsHR.RulDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromMinute = new System.Windows.Forms.TextBox();
            this.txtToMinute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.delayRuleDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayRuleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstPenaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRRulDelayRulesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmdCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.hR_Rul_DelayTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter();
            this.hR_Rul_DelayRulesDetailsTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayRulesDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayRulesDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم اللائحة :";
            // 
            // txtDelayRuleID
            // 
            this.txtDelayRuleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDelayRuleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDelayRuleID.DataSource = this.hRRulDelayBindingSource;
            this.txtDelayRuleID.DisplayMember = "DelayRuleNameAr";
            this.txtDelayRuleID.FormattingEnabled = true;
            this.txtDelayRuleID.Location = new System.Drawing.Point(229, 12);
            this.txtDelayRuleID.Name = "txtDelayRuleID";
            this.txtDelayRuleID.Size = new System.Drawing.Size(318, 25);
            this.txtDelayRuleID.TabIndex = 1;
            this.txtDelayRuleID.ValueMember = "DelayRuleID";
            this.txtDelayRuleID.SelectedIndexChanged += new System.EventHandler(this.txtDelayRuleID_SelectedIndexChanged);
            // 
            // hRRulDelayBindingSource
            // 
            this.hRRulDelayBindingSource.DataMember = "HR_Rul_Delay";
            this.hRRulDelayBindingSource.DataSource = this.rulDataSet;
            // 
            // rulDataSet
            // 
            this.rulDataSet.DataSetName = "RulDataSet";
            this.rulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "الفترة بالدقائق :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "من :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "الى :";
            // 
            // txtFromMinute
            // 
            this.txtFromMinute.Location = new System.Drawing.Point(462, 90);
            this.txtFromMinute.Name = "txtFromMinute";
            this.txtFromMinute.Size = new System.Drawing.Size(85, 24);
            this.txtFromMinute.TabIndex = 2;
            this.txtFromMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNonDecimal);
            // 
            // txtToMinute
            // 
            this.txtToMinute.Location = new System.Drawing.Point(375, 90);
            this.txtToMinute.Name = "txtToMinute";
            this.txtToMinute.Size = new System.Drawing.Size(81, 24);
            this.txtToMinute.TabIndex = 3;
            this.txtToMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNonDecimal);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "القيمة :";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(303, 90);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(66, 24);
            this.txtValue.TabIndex = 4;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal);
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delayRuleDetailIDDataGridViewTextBoxColumn,
            this.delayRuleIDDataGridViewTextBoxColumn,
            this.fromMinuteDataGridViewTextBoxColumn,
            this.toMinuteDataGridViewTextBoxColumn,
            this.firstPenaltyDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRRulDelayRulesDetailsBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 162);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(632, 279);
            this.gvForm.TabIndex = 11;
            // 
            // delayRuleDetailIDDataGridViewTextBoxColumn
            // 
            this.delayRuleDetailIDDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleDetailID";
            this.delayRuleDetailIDDataGridViewTextBoxColumn.HeaderText = "DelayRuleDetailID";
            this.delayRuleDetailIDDataGridViewTextBoxColumn.Name = "delayRuleDetailIDDataGridViewTextBoxColumn";
            this.delayRuleDetailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleDetailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // delayRuleIDDataGridViewTextBoxColumn
            // 
            this.delayRuleIDDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.HeaderText = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.Name = "delayRuleIDDataGridViewTextBoxColumn";
            this.delayRuleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fromMinuteDataGridViewTextBoxColumn
            // 
            this.fromMinuteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fromMinuteDataGridViewTextBoxColumn.DataPropertyName = "FromMinute";
            this.fromMinuteDataGridViewTextBoxColumn.HeaderText = "من الدقيقه";
            this.fromMinuteDataGridViewTextBoxColumn.Name = "fromMinuteDataGridViewTextBoxColumn";
            this.fromMinuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromMinuteDataGridViewTextBoxColumn.Width = 96;
            // 
            // toMinuteDataGridViewTextBoxColumn
            // 
            this.toMinuteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.toMinuteDataGridViewTextBoxColumn.DataPropertyName = "ToMinute";
            this.toMinuteDataGridViewTextBoxColumn.HeaderText = "الي الدقيقه";
            this.toMinuteDataGridViewTextBoxColumn.Name = "toMinuteDataGridViewTextBoxColumn";
            this.toMinuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.toMinuteDataGridViewTextBoxColumn.Width = 99;
            // 
            // firstPenaltyDataGridViewTextBoxColumn
            // 
            this.firstPenaltyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstPenaltyDataGridViewTextBoxColumn.DataPropertyName = "FirstPenalty";
            this.firstPenaltyDataGridViewTextBoxColumn.HeaderText = "الخصم";
            this.firstPenaltyDataGridViewTextBoxColumn.Name = "firstPenaltyDataGridViewTextBoxColumn";
            this.firstPenaltyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hRRulDelayRulesDetailsBindingSource
            // 
            this.hRRulDelayRulesDetailsBindingSource.DataMember = "HR_Rul_DelayRulesDetails";
            this.hRRulDelayRulesDetailsBindingSource.DataSource = this.rulDataSet;
            // 
            // CmdCancelUpdate
            // 
            this.CmdCancelUpdate.Location = new System.Drawing.Point(303, 120);
            this.CmdCancelUpdate.Name = "CmdCancelUpdate";
            this.CmdCancelUpdate.Size = new System.Drawing.Size(119, 36);
            this.CmdCancelUpdate.TabIndex = 6;
            this.CmdCancelUpdate.Text = "الغاء التعديل";
            this.CmdCancelUpdate.UseVisualStyleBackColor = true;
            this.CmdCancelUpdate.Click += new System.EventHandler(this.CmdCancelUpdate_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(428, 120);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 45;
            // 
            // hR_Rul_DelayTableAdapter
            // 
            this.hR_Rul_DelayTableAdapter.ClearBeforeFill = true;
            // 
            // hR_Rul_DelayRulesDetailsTableAdapter
            // 
            this.hR_Rul_DelayRulesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmDelayRulesDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 446);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.CmdCancelUpdate);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToMinute);
            this.Controls.Add(this.txtFromMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelayRuleID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDelayRulesDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل لوائح التأخير";
            this.Load += new System.EventHandler(this.frmDelayRulesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayRulesDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtDelayRuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromMinute;
        private System.Windows.Forms.TextBox txtToMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Button CmdCancelUpdate;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.RulDataSet rulDataSet;
        private System.Windows.Forms.BindingSource hRRulDelayBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter hR_Rul_DelayTableAdapter;
        private System.Windows.Forms.BindingSource hRRulDelayRulesDetailsBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayRulesDetailsTableAdapter hR_Rul_DelayRulesDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPenaltyDataGridViewTextBoxColumn;
    }
}