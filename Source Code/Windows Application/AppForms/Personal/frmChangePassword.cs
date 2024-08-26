using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode;
using TMS.AppCode.BLL;

namespace TMS.AppForms.Personal
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtNewPassword1.Text != txtNewPassword2.Text)
            {
                lblMSG.Text = "كلمة المرور الجديدة غير متطابقه";
                txtNewPassword2.Focus();
                return;
            }

            if (Pre_Authentication.AuthnticateUser(GlobalParamters.ActiveUserID, txtOldPassword.Text) != 1)
            {
                lblMSG.Text = "كلمة المرور غير صحيحه";
                txtOldPassword.Focus();
                return;
            }
            #endregion

            if (Pre_Authentication.UpdateUserPW(GlobalParamters.ActiveUserID, txtNewPassword1.Text) != 1)
            {
                lblMSG.Text = "خطأ اثناء عمليه التحديث";
                txtNewPassword1.Focus();
                return;
            }
            else
            {
                MessageBox.Show("تمت عمليه التحديث بنجاح");
                this.Hide();
            }

        }
    }
}
