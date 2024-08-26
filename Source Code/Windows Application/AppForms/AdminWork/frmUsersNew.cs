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
using TMS.AppCode.DAL;

namespace TMS.AppForms.AdminWork
{
    public partial class frmUsersNew : Form
    {
        public byte[] Img { get; set; }
        int PassedUserID = 0;
        int LinkedDrID = 0;

        public frmUsersNew(int UserID)
        {
            InitializeComponent();
            PassedUserID = UserID;
        }

        private void frmUsersNew_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.hR_EmpInformationTableAdapter.Fill(this.premission.HR_EmpInformation);
                this.bsk_DoctorsListTableAdapter.Fill(this.lupComboFill.Bsk_DoctorsList);
            }
            catch { }
            txtEmployeeID.SelectedIndex = -1;
            txtUserName.Focus();
        }

        #region UI Response
        private void ProfileImageTemplateLV_Click(object sender, EventArgs e)
        {
            ListView ClickedItem = (ListView)sender;
            UserProfileImage.Image = ProfileimageList.Images[ClickedItem.FocusedItem.Index];

            MemoryStream stream = new MemoryStream();
            UserProfileImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            Img = stream.ToArray();

            ProfileImageTemplateLV.Visible = false;
        }

        private void CmdBrowseTemplate_Click(object sender, EventArgs e)
        {
            ProfileImageTemplateLV.Visible = true;
            ProfileImageTemplateLV.Top = 20;
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
                if (image.Width != 64 || image.Height != 64)
                {
                    Img = null;
                    MessageBox.Show("ابعاد الصورة غير سليمه");
                }
                else
                {
                    UserProfileImage.Image = image;
                }
            }
        }

        private void frmUsersNew_Click(object sender, EventArgs e)
        {
            ProfileImageTemplateLV.Visible = false;
        }

        private void txtEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmployeeID.SelectedIndex != -1)
            {
                lblEmplyeeName.Text = "كود الموظف: " + txtEmployeeID.SelectedValue.ToString();
            }
        }
        #endregion
        
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ResetInputForm()
        {
            txtUserName.Text = "";
            txtPasswordA.Text = "";
            txtPasswordB.Text = "";
            txtDisplayName.Text = "";
            txtEmployeeID.SelectedIndex = -1;
            IsActive.Checked = true;
            UserProfileImage.Image = null;
            IsDoctor.Checked = false;
            txtDrID.SelectedIndex = -1;
            txtDrID.Visible = false;

            txtUserName.Focus();
        }

        #region Validations
        private bool ValidateInputs()
        {
            #region Check Mandatory Fields
            if (txtUserName.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب إدخال أسم الدخول";
                txtUserName.Focus();
                return false;
            }

            if (txtPasswordA.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب إدخال كلمة المرور";
                txtPasswordA.Focus();
                return false;
            }

            if (txtDisplayName.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب إدخال أسم المستخدم";
                txtDisplayName.Focus();
                return false;
            }
            
            if(txtEmployeeID.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب ربط المستخدم بملفات العاملين";
                txtEmployeeID.Focus();
                return false;
            }

            if (UserProfileImage.Image == null)
            {
                lblMSG.Text = "يجب إختيار صورة المستخدم";
                return false;
            }
            #endregion

            #region Check Logical
            if (txtPasswordA.Text != txtPasswordB.Text)
            {
                lblMSG.Text = "كلمتي المرور يجب ان تكونا متطابقتين";
                txtPasswordA.Focus();
                return false;
            }

            #endregion

            #region Check Against Duplication
            // User Name    // EmpID    // Display Name
            if (AppCode.DAL.AdminWork.CheckLogicalInUserProfile(Convert.ToInt32(txtEmployeeID.SelectedValue), txtUserName.Text, txtDisplayName.Text) != 0)
            {
                lblMSG.Text = "لا يمكن تكرار اسم المستخدم او اسم الدخول او انشاء اكثر من حساب لنفس الموظف";
                return false;
            }
            #endregion


            return true;
        }

        #endregion

        private bool DoDAJob()
        {
            // Validation
            if (!ValidateInputs())
            {
                return false;
            }
            if (PassedUserID == 0) // Insert    
            {

                if (AppCode.DAL.AdminWork.NewUser(txtDisplayName.Text, txtUserName.Text, txtPasswordA.Text, IsActive.Checked, Img, Convert.ToInt32(txtEmployeeID.SelectedValue), IsDoctor.Checked, LinkedDrID) > 0)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    return true;
                }
                else
                {
                    lblMSG.Text = "حدث خطأ اثناء الحفظ";
                    return false;
                }
            }
            else // Update
            {
                if (AppCode.DAL.AdminWork.UpdateUser(txtDisplayName.Text, txtUserName.Text, txtPasswordA.Text, IsActive.Checked, Img, Convert.ToInt32(txtEmployeeID.SelectedValue), PassedUserID) == 1)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    return true;
                }
                else
                {
                    lblMSG.Text = "حدث خطأ اثناء الحفظ";
                    return false;
                }
            }
        }
        
        private void CmdSaveNew_Click(object sender, EventArgs e)
        {
            if(DoDAJob() == true)
            {
                ResetInputForm();
            }
        }

        private void CmdSaveClose_Click(object sender, EventArgs e)
        {
            if (DoDAJob() == true)
            {
                this.Hide();
            }
        }

        private void IsDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDoctor.Checked == true)
            {
                txtDrID.Visible = true;
            }
            else
            {
                txtDrID.Visible = false;
                LinkedDrID = 0;
            }
        }

        private void txtDrID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDrID.SelectedIndex != -1)
            {
                LinkedDrID = Convert.ToInt32(txtDrID.SelectedValue);
            }
            else
            {
                LinkedDrID = 0;
            }
        }

        
    }
}
