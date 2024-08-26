namespace TMS.AppReports
{
    partial class frmPrintingPreview
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
            this.CRViewerMain = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRViewerMain
            // 
            this.CRViewerMain.ActiveViewIndex = -1;
            this.CRViewerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewerMain.Location = new System.Drawing.Point(0, 0);
            this.CRViewerMain.Name = "CRViewerMain";
            this.CRViewerMain.Size = new System.Drawing.Size(616, 412);
            this.CRViewerMain.TabIndex = 0;
            // 
            // frmPrintingPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 412);
            this.Controls.Add(this.CRViewerMain);
            this.Name = "frmPrintingPreview";
            this.Text = "معاينه الطباعه";
            this.Load += new System.EventHandler(this.frmPrintingPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewerMain;

    }
}