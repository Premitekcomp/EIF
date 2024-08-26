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
    public partial class frmWorkingPlans : Form
    {
        DateTime WorkingStartTime;
        DateTime WorkingEndTime;

        public frmWorkingPlans()
        {
            InitializeComponent();
        }

        private void frmWorkingPlans_Load(object sender, EventArgs e)
        {
            LoadCombo();
            txtEmploymentGroupID.SelectedIndex = -1;
            txtWorkingTimesID.SelectedIndex = -1;
        }

        private void LoadCombo()
        {
            try
            {
                this.hR_Lup_WorkingTimesComboTableAdapter.Fill(this.traDataSet.HR_Lup_WorkingTimesCombo);
                this.hR_Lup_EmplymentGroupTableAdapter.Fill(this.empDataSet.HR_Lup_EmplymentGroup);
            }
            catch { }
        }

        private void txtWorkingTimesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtWorkingTimesID.SelectedIndex != -1)
            {
                try
                {
                    this.hR_Lup_WorkingTimesTableAdapter.FillByID(this.traDataSet.HR_Lup_WorkingTimes, Convert.ToByte(txtWorkingTimesID.SelectedValue));
                    if (dgvWorkingTime.Rows.Count >0)
                    {
                        WorkingStartTime = Convert.ToDateTime(dgvWorkingTime.Rows[0].Cells[2].Value.ToString());
                        WorkingEndTime = Convert.ToDateTime(dgvWorkingTime.Rows[0].Cells[3].Value.ToString());
                    }
                }
                catch { }
            }
        }

        private void txtEmploymentGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmploymentGroupID.SelectedIndex != -1)
            {
                try
                {
                    this.grid_GroupMembersTableAdapter.FillBy(this.empDataSet.Grid_GroupMembers, Convert.ToByte(txtEmploymentGroupID.SelectedValue));
                }
                catch { }
            }
        }

        private void dgvEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    if (dgvEmpList.Rows[e.RowIndex].Cells[4].Value == null)
                    {
                        dgvEmpList.Rows[e.RowIndex].Cells[4].Value = true;
                    }
                    else
                    {
                        dgvEmpList.Rows[e.RowIndex].Cells[4].Value = null;
                    }
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DateTime StartLoopingDate = dtAttStartDate.Value;

            for (int xLoops = 0; xLoops < Convert.ToInt32(txtLoopingTime.Text); xLoops++)
            {
                TimeSpan ByDay = new TimeSpan(xLoops * 1, 0, 0, 0);
                DateTime AccumaltedDate = StartLoopingDate + ByDay;

                foreach (DataGridViewRow GRow in dgvEmpList.Rows)
                {
                    if (GRow.Cells[4].Value != null)
                    {
                        int EmpID = Convert.ToInt32(GRow.Cells[2].Value);
                        HR_Basics.InsertWorkingPlan(EmpID, AccumaltedDate, WorkingStartTime, WorkingEndTime);
                    }
                }
            }

            MessageBox.Show("Done");
            
        }
    }
}
