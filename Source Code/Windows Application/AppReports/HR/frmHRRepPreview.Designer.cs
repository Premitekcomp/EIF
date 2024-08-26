namespace TMS.AppReports.HR
{
    partial class frmHRRepPreview
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
            this.CRViewerMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CRViewerMain.Name = "CRViewerMain";
            this.CRViewerMain.ShowCopyButton = false;
            this.CRViewerMain.ShowParameterPanelButton = false;
            this.CRViewerMain.Size = new System.Drawing.Size(379, 341);
            this.CRViewerMain.TabIndex = 3;
            this.CRViewerMain.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmHRRepPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.CRViewerMain);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHRRepPreview";
            this.Text = "معاينه التقرير";
            this.Load += new System.EventHandler(this.frmHRRepPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewerMain;
    }
}