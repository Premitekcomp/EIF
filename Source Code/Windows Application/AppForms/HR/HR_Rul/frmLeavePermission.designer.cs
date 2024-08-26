namespace TMS.AppForms.HR.HR_Rul
{
    partial class frmLeavePermission
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.gvForm = new System.Windows.Forms.DataGridView();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtLeavePermissionRuleNameEn = new System.Windows.Forms.TextBox();
            this.txtLeavePermissionRuleNameAr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(18, 14);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 75;
            // 
            // gvForm
            // 
            this.gvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvForm.Location = new System.Drawing.Point(12, 269);
            this.gvForm.Name = "gvForm";
            this.gvForm.Size = new System.Drawing.Size(772, 169);
            this.gvForm.TabIndex = 74;
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(95, 82);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(117, 24);
            this.txtMaxCount.TabIndex = 4;
            this.txtMaxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "اقصي عدد من المرات في الشهر";
            // 
            // txtMaxHour
            // 
            this.txtMaxHour.Location = new System.Drawing.Point(482, 82);
            this.txtMaxHour.Name = "txtMaxHour";
            this.txtMaxHour.Size = new System.Drawing.Size(117, 24);
            this.txtMaxHour.TabIndex = 3;
            this.txtMaxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "عدد الساعات الأقصي للمره الواحده";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(393, 221);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(119, 36);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "حفظ / اغلاق";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(518, 221);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 36);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "حفظ / جديد";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(252, 112);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(385, 103);
            this.txtNotes.TabIndex = 5;
            // 
            // txtLeavePermissionRuleNameEn
            // 
            this.txtLeavePermissionRuleNameEn.Location = new System.Drawing.Point(263, 32);
            this.txtLeavePermissionRuleNameEn.Name = "txtLeavePermissionRuleNameEn";
            this.txtLeavePermissionRuleNameEn.Size = new System.Drawing.Size(82, 24);
            this.txtLeavePermissionRuleNameEn.TabIndex = 2;
            this.txtLeavePermissionRuleNameEn.Visible = false;
            // 
            // txtLeavePermissionRuleNameAr
            // 
            this.txtLeavePermissionRuleNameAr.Location = new System.Drawing.Point(351, 32);
            this.txtLeavePermissionRuleNameAr.Name = "txtLeavePermissionRuleNameAr";
            this.txtLeavePermissionRuleNameAr.Size = new System.Drawing.Size(296, 24);
            this.txtLeavePermissionRuleNameAr.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "ملاحظات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "اسم اللائحة (عربي):";
            // 
            // frmLeavePermission
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 438);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.gvForm);
            this.Controls.Add(this.txtMaxCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtLeavePermissionRuleNameEn);
            this.Controls.Add(this.txtLeavePermissionRuleNameAr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLeavePermission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة الإذونات";
            this.Load += new System.EventHandler(this.frmLeavePermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView gvForm;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtLeavePermissionRuleNameEn;
        private System.Windows.Forms.TextBox txtLeavePermissionRuleNameAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}