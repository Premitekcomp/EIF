namespace TMS.AppForms.Accounting
{
    partial class frmMasterBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterBook));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CmdExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvEntryList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOverAllCredit = new System.Windows.Forms.Label();
            this.lblOverAllDepit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.CmdFilterTopLevel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdFilterAnalyticLevel = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdExport,
            this.toolStripSeparator4,
            this.CmdPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CmdExport
            // 
            this.CmdExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdExport.Image = ((System.Drawing.Image)(resources.GetObject("CmdExport.Image")));
            this.CmdExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(76, 22);
            this.CmdExport.Text = "تصدير اكسيل";
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // CmdPrint
            // 
            this.CmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("CmdPrint.Image")));
            this.CmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(77, 22);
            this.CmdPrint.Text = "طباعه القائمة";
            this.CmdPrint.Click += new System.EventHandler(this.CmdPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvEntryList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 606);
            this.panel1.TabIndex = 1;
            // 
            // grvEntryList
            // 
            this.grvEntryList.AllowUserToAddRows = false;
            this.grvEntryList.AllowUserToDeleteRows = false;
            this.grvEntryList.BackgroundColor = System.Drawing.Color.White;
            this.grvEntryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEntryList.Location = new System.Drawing.Point(0, 0);
            this.grvEntryList.Name = "grvEntryList";
            this.grvEntryList.RowTemplate.Height = 25;
            this.grvEntryList.Size = new System.Drawing.Size(718, 606);
            this.grvEntryList.TabIndex = 0;
            this.grvEntryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEntryList_CellContentClick);
            this.grvEntryList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvEntryList_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOverAllCredit);
            this.panel2.Controls.Add(this.lblOverAllDepit);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(718, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 606);
            this.panel2.TabIndex = 0;
            // 
            // lblOverAllCredit
            // 
            this.lblOverAllCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllCredit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllCredit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllCredit.Location = new System.Drawing.Point(33, 555);
            this.lblOverAllCredit.Name = "lblOverAllCredit";
            this.lblOverAllCredit.Size = new System.Drawing.Size(196, 37);
            this.lblOverAllCredit.TabIndex = 35;
            this.lblOverAllCredit.Text = "0";
            this.lblOverAllCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverAllDepit
            // 
            this.lblOverAllDepit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOverAllDepit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverAllDepit.ForeColor = System.Drawing.Color.White;
            this.lblOverAllDepit.Location = new System.Drawing.Point(33, 505);
            this.lblOverAllDepit.Name = "lblOverAllDepit";
            this.lblOverAllDepit.Size = new System.Drawing.Size(196, 37);
            this.lblOverAllDepit.TabIndex = 34;
            this.lblOverAllDepit.Text = "0";
            this.lblOverAllDepit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdFilterAnalyticLevel);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.CmdFilterTopLevel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 488);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصفيه بالتاريخ و النوع";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(8, 69);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(171, 32);
            this.dtEnd.TabIndex = 7;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(8, 31);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(171, 32);
            this.dtStart.TabIndex = 6;
            // 
            // CmdFilterTopLevel
            // 
            this.CmdFilterTopLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterTopLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterTopLevel.ForeColor = System.Drawing.Color.White;
            this.CmdFilterTopLevel.Location = new System.Drawing.Point(8, 125);
            this.CmdFilterTopLevel.Name = "CmdFilterTopLevel";
            this.CmdFilterTopLevel.Size = new System.Drawing.Size(245, 38);
            this.CmdFilterTopLevel.TabIndex = 5;
            this.CmdFilterTopLevel.Text = "الاستاذ العام - حسابات رئيسيه";
            this.CmdFilterTopLevel.UseVisualStyleBackColor = false;
            this.CmdFilterTopLevel.Click += new System.EventHandler(this.CmdFilterByDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "من يوم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "الي يوم:";
            // 
            // CmdFilterAnalyticLevel
            // 
            this.CmdFilterAnalyticLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CmdFilterAnalyticLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdFilterAnalyticLevel.ForeColor = System.Drawing.Color.White;
            this.CmdFilterAnalyticLevel.Location = new System.Drawing.Point(10, 169);
            this.CmdFilterAnalyticLevel.Name = "CmdFilterAnalyticLevel";
            this.CmdFilterAnalyticLevel.Size = new System.Drawing.Size(245, 38);
            this.CmdFilterAnalyticLevel.TabIndex = 8;
            this.CmdFilterAnalyticLevel.Text = "الاستاذ العام - حسابات تحليليه";
            this.CmdFilterAnalyticLevel.UseVisualStyleBackColor = false;
            this.CmdFilterAnalyticLevel.Click += new System.EventHandler(this.CmdFilterAnalyticLevel_Click);
            // 
            // frmMasterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmMasterBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستاذ العام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJournalEntryList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEntryList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button CmdFilterTopLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton CmdExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CmdPrint;
        private System.Windows.Forms.DataGridView grvEntryList;
        private System.Windows.Forms.Label lblOverAllCredit;
        private System.Windows.Forms.Label lblOverAllDepit;
        private System.Windows.Forms.Button CmdFilterAnalyticLevel;
    }
}