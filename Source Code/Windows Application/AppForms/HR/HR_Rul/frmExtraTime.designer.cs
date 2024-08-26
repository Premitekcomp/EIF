namespace TMS.AppForms.HR.HR_Rul
{
    partial class frmExtraTime
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtExtraTimeRuleNameEn = new System.Windows.Forms.TextBox();
            this.txtExtraTimeRuleNameAr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVacationExtraHour = new System.Windows.Forms.TextBox();
            this.txtWorkExtraHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(404, 212);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(529, 212);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(270, 130);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(378, 76);
            this.txtNotes.TabIndex = 5;
            // 
            // txtExtraTimeRuleNameEn
            // 
            this.txtExtraTimeRuleNameEn.Location = new System.Drawing.Point(290, 40);
            this.txtExtraTimeRuleNameEn.Name = "txtExtraTimeRuleNameEn";
            this.txtExtraTimeRuleNameEn.Size = new System.Drawing.Size(56, 24);
            this.txtExtraTimeRuleNameEn.TabIndex = 2;
            this.txtExtraTimeRuleNameEn.Visible = false;
            // 
            // txtExtraTimeRuleNameAr
            // 
            this.txtExtraTimeRuleNameAr.Location = new System.Drawing.Point(352, 40);
            this.txtExtraTimeRuleNameAr.Name = "txtExtraTimeRuleNameAr";
            this.txtExtraTimeRuleNameAr.Size = new System.Drawing.Size(296, 24);
            this.txtExtraTimeRuleNameAr.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "ملاحظات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "اسم اللائحة (عربي):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "قيمة ساعه الإضافي بعد ساعات العمل الرسميه";
            // 
            // txtVacationExtraHour
            // 
            this.txtVacationExtraHour.Location = new System.Drawing.Point(448, 100);
            this.txtVacationExtraHour.Name = "txtVacationExtraHour";
            this.txtVacationExtraHour.Size = new System.Drawing.Size(117, 24);
            this.txtVacationExtraHour.TabIndex = 3;
            this.txtVacationExtraHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWorkExtraHour
            // 
            this.txtWorkExtraHour.Location = new System.Drawing.Point(107, 100);
            this.txtWorkExtraHour.Name = "txtWorkExtraHour";
            this.txtWorkExtraHour.Size = new System.Drawing.Size(117, 24);
            this.txtWorkExtraHour.TabIndex = 4;
            this.txtWorkExtraHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "قيمة ساعة الإضافي في ايام الإجازات";
            // 
            // gvForm
            // 
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Location = new System.Drawing.Point(12, 257);
            this.gvForm.Name = "gvForm";
            this.gvForm.Size = new System.Drawing.Size(780, 169);
            this.gvForm.TabIndex = 57;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(20, 14);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 58;
            // 
            // frmExtraTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 438);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtWorkExtraHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVacationExtraHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtExtraTimeRuleNameEn);
            this.Controls.Add(this.txtExtraTimeRuleNameAr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmExtraTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوائح إحتساب الإضافي";
            this.Load += new System.EventHandler(this.frmExtraTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtExtraTimeRuleNameEn;
        private System.Windows.Forms.TextBox txtExtraTimeRuleNameAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVacationExtraHour;
        private System.Windows.Forms.TextBox txtWorkExtraHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.Label lblMsg;
    }
}