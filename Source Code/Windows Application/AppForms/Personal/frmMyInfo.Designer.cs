namespace TMS.AppForms.Personal
{
    partial class frmMyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyInfo));
            this.MyImageIL = new System.Windows.Forms.ImageList(this.components);
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.PicProfileImage = new System.Windows.Forms.PictureBox();
            this.CmdBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChatStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MyImageIL
            // 
            this.MyImageIL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.MyImageIL.ImageSize = new System.Drawing.Size(16, 16);
            this.MyImageIL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtMyName
            // 
            this.txtMyName.Location = new System.Drawing.Point(206, 42);
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.Size = new System.Drawing.Size(293, 37);
            this.txtMyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم:";
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdUpdate.Location = new System.Drawing.Point(355, 191);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(144, 48);
            this.CmdUpdate.TabIndex = 2;
            this.CmdUpdate.Text = "تحديث";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // PicProfileImage
            // 
            this.PicProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicProfileImage.Location = new System.Drawing.Point(12, 42);
            this.PicProfileImage.Name = "PicProfileImage";
            this.PicProfileImage.Size = new System.Drawing.Size(128, 128);
            this.PicProfileImage.TabIndex = 3;
            this.PicProfileImage.TabStop = false;
            // 
            // CmdBrowse
            // 
            this.CmdBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CmdBrowse.FlatAppearance.BorderSize = 0;
            this.CmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("CmdBrowse.Image")));
            this.CmdBrowse.Location = new System.Drawing.Point(102, 176);
            this.CmdBrowse.Name = "CmdBrowse";
            this.CmdBrowse.Size = new System.Drawing.Size(38, 34);
            this.CmdBrowse.TabIndex = 135;
            this.CmdBrowse.UseVisualStyleBackColor = true;
            this.CmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(114, 30);
            this.label6.TabIndex = 136;
            this.label6.Text = "128 x 128 Max";
            // 
            // txtChatStatus
            // 
            this.txtChatStatus.Location = new System.Drawing.Point(161, 85);
            this.txtChatStatus.Name = "txtChatStatus";
            this.txtChatStatus.Size = new System.Drawing.Size(338, 37);
            this.txtChatStatus.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 138;
            this.label2.Text = "الحالة:";
            // 
            // frmMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChatStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdBrowse);
            this.Controls.Add(this.PicProfileImage);
            this.Controls.Add(this.CmdUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMyName);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMyInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الملف الشخصي";
            this.Load += new System.EventHandler(this.frmMyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList MyImageIL;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.PictureBox PicProfileImage;
        private System.Windows.Forms.Button CmdBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChatStatus;
        private System.Windows.Forms.Label label2;
    }
}