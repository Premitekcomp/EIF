namespace TMS.AppForms.HR.HR_Tra
{
    partial class frmLoadFPSheet
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
            this.CmdBrowse = new System.Windows.Forms.Button();
            this.grvLoadFP = new System.Windows.Forms.DataGridView();
            this.ImportResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFPNo = new System.Windows.Forms.TextBox();
            this.lblFPNo = new System.Windows.Forms.Label();
            this.lblFPDate = new System.Windows.Forms.Label();
            this.txtFPDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFPType = new System.Windows.Forms.Label();
            this.txtFPType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmdImport = new System.Windows.Forms.Button();
            this.CmdRemmber = new System.Windows.Forms.Button();
            this.CmdVerfiy = new System.Windows.Forms.Button();
            this.txtXLSSheetList = new System.Windows.Forms.TextBox();
            this.UploadingBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoadFP)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdBrowse
            // 
            this.CmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBrowse.Location = new System.Drawing.Point(776, 12);
            this.CmdBrowse.Name = "CmdBrowse";
            this.CmdBrowse.Size = new System.Drawing.Size(82, 36);
            this.CmdBrowse.TabIndex = 0;
            this.CmdBrowse.Text = "Browse";
            this.CmdBrowse.UseVisualStyleBackColor = true;
            this.CmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // grvLoadFP
            // 
            this.grvLoadFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLoadFP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImportResult});
            this.grvLoadFP.Location = new System.Drawing.Point(462, 54);
            this.grvLoadFP.Name = "grvLoadFP";
            this.grvLoadFP.Size = new System.Drawing.Size(396, 400);
            this.grvLoadFP.TabIndex = 1;
            // 
            // ImportResult
            // 
            this.ImportResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportResult.HeaderText = "Result";
            this.ImportResult.Name = "ImportResult";
            this.ImportResult.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الموظف في ماكينة البصمه:";
            // 
            // txtFPNo
            // 
            this.txtFPNo.Location = new System.Drawing.Point(195, 64);
            this.txtFPNo.Name = "txtFPNo";
            this.txtFPNo.Size = new System.Drawing.Size(54, 24);
            this.txtFPNo.TabIndex = 4;
            this.txtFPNo.Text = "3";
            this.txtFPNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFPNo
            // 
            this.lblFPNo.AutoSize = true;
            this.lblFPNo.Location = new System.Drawing.Point(12, 67);
            this.lblFPNo.Name = "lblFPNo";
            this.lblFPNo.Size = new System.Drawing.Size(25, 17);
            this.lblFPNo.TabIndex = 5;
            this.lblFPNo.Text = "NA";
            // 
            // lblFPDate
            // 
            this.lblFPDate.AutoSize = true;
            this.lblFPDate.Location = new System.Drawing.Point(12, 97);
            this.lblFPDate.Name = "lblFPDate";
            this.lblFPDate.Size = new System.Drawing.Size(25, 17);
            this.lblFPDate.TabIndex = 8;
            this.lblFPDate.Text = "NA";
            // 
            // txtFPDate
            // 
            this.txtFPDate.Location = new System.Drawing.Point(195, 94);
            this.txtFPDate.Name = "txtFPDate";
            this.txtFPDate.Size = new System.Drawing.Size(54, 24);
            this.txtFPDate.TabIndex = 7;
            this.txtFPDate.Text = "4";
            this.txtFPDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "توقيت البصمه:";
            // 
            // lblFPType
            // 
            this.lblFPType.AutoSize = true;
            this.lblFPType.Location = new System.Drawing.Point(12, 127);
            this.lblFPType.Name = "lblFPType";
            this.lblFPType.Size = new System.Drawing.Size(25, 17);
            this.lblFPType.TabIndex = 11;
            this.lblFPType.Text = "NA";
            // 
            // txtFPType
            // 
            this.txtFPType.Location = new System.Drawing.Point(195, 124);
            this.txtFPType.Name = "txtFPType";
            this.txtFPType.Size = new System.Drawing.Size(54, 24);
            this.txtFPType.TabIndex = 10;
            this.txtFPType.Text = "5";
            this.txtFPType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "نوع الحركة:";
            // 
            // CmdImport
            // 
            this.CmdImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdImport.Location = new System.Drawing.Point(12, 212);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(430, 36);
            this.CmdImport.TabIndex = 12;
            this.CmdImport.Text = "إستيراد شيت البصمه";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // CmdRemmber
            // 
            this.CmdRemmber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdRemmber.Location = new System.Drawing.Point(12, 405);
            this.CmdRemmber.Name = "CmdRemmber";
            this.CmdRemmber.Size = new System.Drawing.Size(430, 36);
            this.CmdRemmber.TabIndex = 13;
            this.CmdRemmber.Text = "تذكر الإعدادات";
            this.CmdRemmber.UseVisualStyleBackColor = true;
            // 
            // CmdVerfiy
            // 
            this.CmdVerfiy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdVerfiy.Location = new System.Drawing.Point(12, 170);
            this.CmdVerfiy.Name = "CmdVerfiy";
            this.CmdVerfiy.Size = new System.Drawing.Size(430, 36);
            this.CmdVerfiy.TabIndex = 14;
            this.CmdVerfiy.Text = "التأكد من البيانات";
            this.CmdVerfiy.UseVisualStyleBackColor = true;
            this.CmdVerfiy.Click += new System.EventHandler(this.CmdVerfiy_Click);
            // 
            // txtXLSSheetList
            // 
            this.txtXLSSheetList.Location = new System.Drawing.Point(462, 24);
            this.txtXLSSheetList.Name = "txtXLSSheetList";
            this.txtXLSSheetList.Size = new System.Drawing.Size(308, 24);
            this.txtXLSSheetList.TabIndex = 15;
            // 
            // UploadingBar
            // 
            this.UploadingBar.Location = new System.Drawing.Point(12, 254);
            this.UploadingBar.Name = "UploadingBar";
            this.UploadingBar.Size = new System.Drawing.Size(430, 24);
            this.UploadingBar.TabIndex = 16;
            // 
            // frmLoadFPSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 453);
            this.Controls.Add(this.UploadingBar);
            this.Controls.Add(this.txtXLSSheetList);
            this.Controls.Add(this.CmdVerfiy);
            this.Controls.Add(this.CmdRemmber);
            this.Controls.Add(this.CmdImport);
            this.Controls.Add(this.lblFPType);
            this.Controls.Add(this.txtFPType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFPDate);
            this.Controls.Add(this.txtFPDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFPNo);
            this.Controls.Add(this.txtFPNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvLoadFP);
            this.Controls.Add(this.CmdBrowse);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLoadFPSheet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحميل شيت البصمه";
            this.Load += new System.EventHandler(this.frmLoadFPSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLoadFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBrowse;
        private System.Windows.Forms.DataGridView grvLoadFP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFPNo;
        private System.Windows.Forms.Label lblFPNo;
        private System.Windows.Forms.Label lblFPDate;
        private System.Windows.Forms.TextBox txtFPDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFPType;
        private System.Windows.Forms.TextBox txtFPType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CmdImport;
        private System.Windows.Forms.Button CmdRemmber;
        private System.Windows.Forms.Button CmdVerfiy;
        private System.Windows.Forms.TextBox txtXLSSheetList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportResult;
        private System.Windows.Forms.ProgressBar UploadingBar;
    }
}