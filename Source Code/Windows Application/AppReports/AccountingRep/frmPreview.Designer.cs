namespace TMS.AppReports.AccountingRep
{
    partial class frmPreview
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
            this.CRPreview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPreview
            // 
            this.CRPreview.ActiveViewIndex = -1;
            this.CRPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPreview.Location = new System.Drawing.Point(0, 0);
            this.CRPreview.Name = "CRPreview";
            this.CRPreview.Size = new System.Drawing.Size(738, 523);
            this.CRPreview.TabIndex = 0;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 523);
            this.Controls.Add(this.CRPreview);
            this.Name = "frmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معاينه قبل الطباعه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPreview;

    }
}