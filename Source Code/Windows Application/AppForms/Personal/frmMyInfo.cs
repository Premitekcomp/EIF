using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.BLL;

namespace TMS.AppForms.Personal
{
    public partial class frmMyInfo : Form
    {
        byte[] Img { get; set; }

        public frmMyInfo()
        {
            InitializeComponent();
        }

        private void frmMyInfo_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            DataTable UInfdt = new DataTable();
            UInfdt = Pre_Authentication.CurrentUserInfo();

            foreach (DataRow r in UInfdt.Rows)
            {
                txtMyName.Text = r["DisplayName"].ToString();
                txtChatStatus.Text = r["ChatStatus"].ToString();

                // Pass Image to image list in order to display it in List View
                Img = (byte[])r["ProfileImage"];
                MemoryStream ms = new MemoryStream(Img);
                Image image = Image.FromStream(ms);
                PicProfileImage.Image = image;
            }

        }

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "image jpg |*.jpg|image png |*.png|image bmp |*.bmp";

            if (o.ShowDialog() == DialogResult.OK)
            {

                Img = File.ReadAllBytes(o.FileName);
                MemoryStream ms = new MemoryStream(Img);
                Image image = Image.FromStream(ms);
                if (image.Width > 128 || image.Height > 128)
                {
                    Img = null;
                    MessageBox.Show("ابعاد الصورة غير سليمه");
                }
                else
                {
                    PicProfileImage.Image = image;
                }
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            if (AppCode.DAL.AdminWork.UpdateMyInfo(txtMyName.Text, Img, txtChatStatus.Text) == 1)
            {
                this.Hide();

            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء الحفظ");
            }
        }
    }
}
