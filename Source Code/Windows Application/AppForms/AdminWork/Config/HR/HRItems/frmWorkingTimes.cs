using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.HR;

namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    public partial class frmWorkingTimes : Form
    {
        public frmWorkingTimes()
        {
            InitializeComponent();
        }

        private void frmWorkingTimes_Load(object sender, EventArgs e)
        {
            
            
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                this.hR_Lup_WorkingTimesTableAdapter.Fill(this.traDataSet.HR_Lup_WorkingTimes);
            }
            catch { }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (HR_Basics.InsertWorkingTime(txtName.Text, dtStartTime.Value, dtEndTime.Value) ==1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                txtName.Text = "";
                txtName.Focus();
                LoadGrid();
            }
            else
            {
                lblMsg.Text = "خطأ اثناء عمليه الحفظ";
            }
        }
    }
}
