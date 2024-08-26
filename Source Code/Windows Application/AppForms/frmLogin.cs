using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode;
using TMS.AppCode.BLL;

namespace TMS.AppForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            try
            {
                this.Pre_UsersTableAdapter.Connection = GlobalParamters.DBConnection;
                this.Pre_UsersTableAdapter.FillLoginList(this.Authentication.Pre_Users);
                txtUserName.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Connection with Database Faild, Kindly Check Your Network and Server Health Status");
            }

            MakeCommonGUITaska(this);
        }

        private void MakeCommonGUITaska(Form PassedFormName)
        {
            try
            {
                GlobalEvents.GLobalGUIEventsV2(PassedFormName);

                foreach (TextBox TBox in this.Controls.OfType<TextBox>().ToArray())
                {
                    TBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
                foreach (ComboBox CBox in this.Controls.OfType<ComboBox>().ToArray())
                {
                    CBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        private void ControlKeyDown(System.Object Sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                BuildGUIEffects.FormNavigation(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }

        }

        private void CmdDoLogin_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtUserName.SelectedIndex == -1 || txtPassword.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب إدخال كافة البيانات";
                lblMSG.ForeColor = GlobalParamters.FaildColor;
                return;
            }

            if (txtBranch.SelectedIndex == -1)
            {
                lblMSG.Text = "لا يبدو انه مصرح لك بالدخول لاي فرع / مشروع";
                lblMSG.ForeColor = GlobalParamters.FaildColor;
                return;
            }
            #endregion

            if (Pre_Authentication.AuthnticateUser(Convert.ToInt32(txtUserName.SelectedValue), txtPassword.Text) == 1)
            {
                PassLogActions(20);

                try
                {
                    Pre_SystemLog.ChangeUserStatus(Convert.ToInt32(txtUserName.SelectedValue), true);
                }
                catch { }

                GlobalParamters.ActiveUserID = Convert.ToInt32(txtUserName.SelectedValue);
                GlobalParamters.ActiveProjectID = Convert.ToInt32(txtBranch.SelectedValue);

                #region Read Configuration
                GlobalParamters.AllowNegativeTransInMasterStores = Pre_Authentication.ReturnBoolConfig(950);
                GlobalParamters.AllowNegativeTransInSubStores = Pre_Authentication.ReturnBoolConfig(951);
                GlobalParamters.SuperVisorPin = Pre_Authentication.ReturnStringConfig(10);
                GlobalParamters.ReciptPrinterName = Pre_Authentication.ReturnStringConfig(1);
                GlobalParamters.LabelsPrinterName = Pre_Authentication.ReturnStringConfig(4);
                #endregion

                frmEnhancedMDI LoadForm = new frmEnhancedMDI();
                LoadForm.Show();
                this.Close();
            }
            else
            {
                lblMSG.Text = "محاولة غير صحيحه";
                lblMSG.ForeColor = GlobalParamters.FaildColor;

                PassLogActions(21);
            }
        }

        private void PassLogActions(int ActionID)
        {
            try
            {
                Pre_SystemLog.InsertLogFromLoginForm(Convert.ToInt32(txtUserName.SelectedValue), 6000, 0, ActionID);
            }
            catch { }
        }

        private void txtUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtUserName.SelectedIndex != -1)
                {
                    this.pre_BranchesPermissionsTableAdapter.Connection = GlobalParamters.DBConnection;
                    this.pre_BranchesPermissionsTableAdapter.FillByUserID(this.premission.Pre_BranchesPermissions, Convert.ToInt16(txtUserName.SelectedValue));
                }
            }
            catch { }
        }
    }
}
