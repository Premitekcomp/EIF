namespace TMS.AppForms.HR.HR_Rul
{
    partial class frmDelay
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelayRuleNameAr = new System.Windows.Forms.TextBox();
            this.txtDelayRuleNameEn = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.CmdRuleDetails = new System.Windows.Forms.Button();
            this.rulDataSet = new TMS.AppDataSetsHR.RulDataSet();
            this.hRRulDelayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Rul_DelayTableAdapter = new TMS.AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter();
            this.delayRuleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayRuleNameArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdCancelUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم اللائحة (عربي):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ملاحظات:";
            // 
            // txtDelayRuleNameAr
            // 
            this.txtDelayRuleNameAr.Location = new System.Drawing.Point(309, 29);
            this.txtDelayRuleNameAr.Name = "txtDelayRuleNameAr";
            this.txtDelayRuleNameAr.Size = new System.Drawing.Size(296, 24);
            this.txtDelayRuleNameAr.TabIndex = 1;
            // 
            // txtDelayRuleNameEn
            // 
            this.txtDelayRuleNameEn.Location = new System.Drawing.Point(242, 29);
            this.txtDelayRuleNameEn.Name = "txtDelayRuleNameEn";
            this.txtDelayRuleNameEn.Size = new System.Drawing.Size(66, 24);
            this.txtDelayRuleNameEn.TabIndex = 2;
            this.txtDelayRuleNameEn.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(204, 59);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(401, 90);
            this.txtNotes.TabIndex = 3;
            // 
            // gvForm
            // 
            this.gvForm.AllowUserToAddRows = false;
            this.gvForm.AllowUserToDeleteRows = false;
            this.gvForm.AutoGenerateColumns = false;
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delayRuleIDDataGridViewTextBoxColumn,
            this.delayRuleNameArDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.gvForm.DataSource = this.hRRulDelayBindingSource;
            this.gvForm.Location = new System.Drawing.Point(12, 197);
            this.gvForm.Name = "gvForm";
            this.gvForm.ReadOnly = true;
            this.gvForm.Size = new System.Drawing.Size(737, 256);
            this.gvForm.TabIndex = 5;
            this.gvForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvForm_CellContentClick);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(242, 155);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(113, 36);
            this.CmdDelete.TabIndex = 6;
            this.CmdDelete.Text = "حذف";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Visible = false;
            this.CmdDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(486, 155);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 4;
            this.btnSaveNew.Text = "حفظ";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 42;
            // 
            // CmdRuleDetails
            // 
            this.CmdRuleDetails.Location = new System.Drawing.Point(124, 155);
            this.CmdRuleDetails.Name = "CmdRuleDetails";
            this.CmdRuleDetails.Size = new System.Drawing.Size(112, 36);
            this.CmdRuleDetails.TabIndex = 7;
            this.CmdRuleDetails.Text = "تفاصيل اللائحة";
            this.CmdRuleDetails.UseVisualStyleBackColor = true;
            this.CmdRuleDetails.Click += new System.EventHandler(this.CmdRuleDetails_Click);
            // 
            // rulDataSet
            // 
            this.rulDataSet.DataSetName = "RulDataSet";
            this.rulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRRulDelayBindingSource
            // 
            this.hRRulDelayBindingSource.DataMember = "HR_Rul_Delay";
            this.hRRulDelayBindingSource.DataSource = this.rulDataSet;
            // 
            // hR_Rul_DelayTableAdapter
            // 
            this.hR_Rul_DelayTableAdapter.ClearBeforeFill = true;
            // 
            // delayRuleIDDataGridViewTextBoxColumn
            // 
            this.delayRuleIDDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.HeaderText = "DelayRuleID";
            this.delayRuleIDDataGridViewTextBoxColumn.Name = "delayRuleIDDataGridViewTextBoxColumn";
            this.delayRuleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // delayRuleNameArDataGridViewTextBoxColumn
            // 
            this.delayRuleNameArDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delayRuleNameArDataGridViewTextBoxColumn.DataPropertyName = "DelayRuleNameAr";
            this.delayRuleNameArDataGridViewTextBoxColumn.HeaderText = "أسم اللائحه";
            this.delayRuleNameArDataGridViewTextBoxColumn.Name = "delayRuleNameArDataGridViewTextBoxColumn";
            this.delayRuleNameArDataGridViewTextBoxColumn.ReadOnly = true;
            this.delayRuleNameArDataGridViewTextBoxColumn.Width = 103;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CmdCancelUpdate
            // 
            this.CmdCancelUpdate.Location = new System.Drawing.Point(361, 155);
            this.CmdCancelUpdate.Name = "CmdCancelUpdate";
            this.CmdCancelUpdate.Size = new System.Drawing.Size(119, 36);
            this.CmdCancelUpdate.TabIndex = 43;
            this.CmdCancelUpdate.Text = "الغاء التعديل";
            this.CmdCancelUpdate.UseVisualStyleBackColor = true;
            this.CmdCancelUpdate.Visible = false;
            this.CmdCancelUpdate.Click += new System.EventHandler(this.CmdCancelUpdate_Click);
            // 
            // frmDelay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 465);
            this.Controls.Add(this.CmdCancelUpdate);
            this.Controls.Add(this.CmdRuleDetails);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDelayRuleNameEn);
            this.Controls.Add(this.txtDelayRuleNameAr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDelay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوائح التأخير";
            this.Load += new System.EventHandler(this.frmDelay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRRulDelayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelayRuleNameAr;
        private System.Windows.Forms.TextBox txtDelayRuleNameEn;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button CmdRuleDetails;
        private AppDataSetsHR.RulDataSet rulDataSet;
        private System.Windows.Forms.BindingSource hRRulDelayBindingSource;
        private AppDataSetsHR.RulDataSetTableAdapters.HR_Rul_DelayTableAdapter hR_Rul_DelayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayRuleNameArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CmdCancelUpdate;
    }
}