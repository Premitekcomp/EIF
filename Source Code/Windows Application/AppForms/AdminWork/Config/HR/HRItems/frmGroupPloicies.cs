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
    public partial class frmGroupPloicies : Form
    {
        public frmGroupPloicies()
        {
            InitializeComponent();
        }

        private void frmGroupPloicies_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Rul_LeavePermissionTableAdapter.Fill(this.rulDataSet.HR_Rul_LeavePermission);
                this.hR_Rul_ExtraTimeTableAdapter.Fill(this.rulDataSet.HR_Rul_ExtraTime);
                this.hR_Rul_DelayTableAdapter.Fill(this.rulDataSet.HR_Rul_Delay);
                this.hR_Lup_EmplymentGroupTableAdapter.Fill(this.empDataSet.HR_Lup_EmplymentGroup);
            }
            catch { }
            
        }

        private void LoadGrid()
        {
            try
            {
                this.gridGroupPloicyTableAdapter.FillByGroupID(this.rulDataSet.GridGroupPloicy, Convert.ToByte(txtGroupID.SelectedValue));
            }
            catch { }
        }
        private void txtGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGroupID.SelectedIndex != -1)
            {
                LoadGrid();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

            if (HR_Rules.InsertNewGroupPloicy(Convert.ToInt32(txtGroupID.SelectedValue), Convert.ToInt32(txtDelayRuleID.SelectedValue), Convert.ToInt32(txtExtratimeRuleID.SelectedValue), Convert.ToInt32(txtLeavPermissionRuleID.SelectedValue)) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                LoadGrid();

                txtDelayRuleID.SelectedIndex = -1;
                txtExtratimeRuleID.SelectedIndex = -1;
                txtLeavPermissionRuleID.SelectedIndex = -1;
            }
            else
            {
                lblMsg.Text = "خطأ اثناء عمليه الحفظ";
            }
        }
    }
}
