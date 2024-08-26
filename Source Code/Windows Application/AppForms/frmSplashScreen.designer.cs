namespace TMS.AppForms
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.SkipTimer = new System.Windows.Forms.Timer(this.components);
            this.PBEIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBEIF)).BeginInit();
            this.SuspendLayout();
            // 
            // SkipTimer
            // 
            this.SkipTimer.Interval = 2000;
            this.SkipTimer.Tick += new System.EventHandler(this.SkipTimer_Tick);
            // 
            // PBEIF
            // 
            this.PBEIF.Image = ((System.Drawing.Image)(resources.GetObject("PBEIF.Image")));
            this.PBEIF.Location = new System.Drawing.Point(-2, -46);
            this.PBEIF.Name = "PBEIF";
            this.PBEIF.Size = new System.Drawing.Size(550, 342);
            this.PBEIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBEIF.TabIndex = 4;
            this.PBEIF.TabStop = false;
            this.PBEIF.Visible = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 293);
            this.Controls.Add(this.PBEIF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBEIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SkipTimer;
        private System.Windows.Forms.PictureBox PBEIF;
    }
}