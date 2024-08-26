using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.BLL;
using TMS.AppCode;
using System.Diagnostics;

namespace TMS.AppForms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void SkipTimer_Tick(object sender, EventArgs e)
        {
            // Check for Regestration
            if (Pre_Authentication.GetActivationFlag(GlobalParamters.ProgramSerial) == true)
            {
                // Load Login Form
                SkipTimer.Enabled = false;
                frmLogin OpenForm = new frmLogin();
                OpenForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("لم تقم بترخيص البرنامج", GlobalParamters.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            SkipTimer.Enabled = true;
            CustomRiboon(GlobalParamters.ClinetPrefix);

        }

        private void CustomRiboon(string Version)
        {
            
            switch (Version)
            {
                
                case "EIF":
                    {
                        PBEIF.Visible = true;
                        return;
                    }
                
            }

        }
    }
}
