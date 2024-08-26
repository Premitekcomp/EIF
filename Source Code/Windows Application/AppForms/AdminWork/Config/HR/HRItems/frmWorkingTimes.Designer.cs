namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    partial class frmWorkingTimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.CmdSave = new System.Windows.Forms.Button();
            this.grvTimesList = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.traDataSet = new TMS.AppDataSetsHR.TraDataSet();
            this.hRLupWorkingTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_Lup_WorkingTimesTableAdapter = new TMS.AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesTableAdapter();
            this.workingTimeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingTimeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvTimesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "أسم الورديه:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(435, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 24);
            this.txtName.TabIndex = 1;
            // 
            // dtStartTime
            // 
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStartTime.Location = new System.Drawing.Point(585, 61);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(129, 24);
            this.dtStartTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "توقيت البداية:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "توقيت النهاية:";
            // 
            // dtEndTime
            // 
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEndTime.Location = new System.Drawing.Point(585, 91);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(129, 24);
            this.dtEndTime.TabIndex = 4;
            // 
            // CmdSave
            // 
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Location = new System.Drawing.Point(252, 83);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 31);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "حفظ";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // grvTimesList
            // 
            this.grvTimesList.AllowUserToAddRows = false;
            this.grvTimesList.AllowUserToDeleteRows = false;
            this.grvTimesList.AutoGenerateColumns = false;
            this.grvTimesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTimesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workingTimeIDDataGridViewTextBoxColumn,
            this.workingTimeTitleDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.grvTimesList.DataSource = this.hRLupWorkingTimesBindingSource;
            this.grvTimesList.Location = new System.Drawing.Point(31, 134);
            this.grvTimesList.Name = "grvTimesList";
            this.grvTimesList.ReadOnly = true;
            this.grvTimesList.Size = new System.Drawing.Size(782, 250);
            this.grvTimesList.TabIndex = 7;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 8;
            // 
            // traDataSet
            // 
            this.traDataSet.DataSetName = "TraDataSet";
            this.traDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hRLupWorkingTimesBindingSource
            // 
            this.hRLupWorkingTimesBindingSource.DataMember = "HR_Lup_WorkingTimes";
            this.hRLupWorkingTimesBindingSource.DataSource = this.traDataSet;
            // 
            // hR_Lup_WorkingTimesTableAdapter
            // 
            this.hR_Lup_WorkingTimesTableAdapter.ClearBeforeFill = true;
            // 
            // workingTimeIDDataGridViewTextBoxColumn
            // 
            this.workingTimeIDDataGridViewTextBoxColumn.DataPropertyName = "WorkingTimeID";
            this.workingTimeIDDataGridViewTextBoxColumn.HeaderText = "WorkingTimeID";
            this.workingTimeIDDataGridViewTextBoxColumn.Name = "workingTimeIDDataGridViewTextBoxColumn";
            this.workingTimeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingTimeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // workingTimeTitleDataGridViewTextBoxColumn
            // 
            this.workingTimeTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workingTimeTitleDataGridViewTextBoxColumn.DataPropertyName = "WorkingTimeTitle";
            this.workingTimeTitleDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.workingTimeTitleDataGridViewTextBoxColumn.Name = "workingTimeTitleDataGridViewTextBoxColumn";
            this.workingTimeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "من الساعه";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 97;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "الي الساعه";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmWorkingTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 385);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.grvTimesList);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmWorkingTimes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الورديات | فترات العمل";
            this.Load += new System.EventHandler(this.frmWorkingTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTimesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRLupWorkingTimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.DataGridView grvTimesList;
        private System.Windows.Forms.Label lblMsg;
        private AppDataSetsHR.TraDataSet traDataSet;
        private System.Windows.Forms.BindingSource hRLupWorkingTimesBindingSource;
        private AppDataSetsHR.TraDataSetTableAdapters.HR_Lup_WorkingTimesTableAdapter hR_Lup_WorkingTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingTimeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingTimeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}