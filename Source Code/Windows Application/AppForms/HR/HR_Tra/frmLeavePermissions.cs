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

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmLeavePermissions : Form
    {
        public frmLeavePermissions()
        {
            InitializeComponent();
        }

        private void frmLeavePermissions_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        private void LoadCombo()
        {
            try
            {
                this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
                this.combo_NameListTableAdapter.Fill(this.empDataSet.Combo_NameList);
            }
            catch { }
        }

        private void LoadFilterdGrid()
        {
            if(txtEmpName.SelectedIndex != -1)
            {
                try
                {
                    this.grid_LeavePermissionTableAdapter.FillByEmpID(this.traDataSet.Grid_LeavePermission, Convert.ToInt16(txtEmpName.SelectedValue));
                }
                catch { }
            }
            
        }

        private void txtEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpName.SelectedIndex != -1)
            {
                txtFPID.SelectedValue = txtEmpName.SelectedValue;
                LoadFilterdGrid();
            }
            
        }

        private void txtFPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFPID.SelectedIndex != -1)
            {
                txtEmpName.SelectedValue = txtFPID.SelectedValue;
                LoadFilterdGrid();
            }
        }

        private void ResetInputForm()
        {
            txtNote.Text = "";
            dtCount.Text = "0";
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (HR_Basics.InsertLeavePermission(Convert.ToInt32(txtEmpName.SelectedValue), dtTransDate.Value, dtTransStartTime.Value, dtTransEndTime.Value, Convert.ToDecimal(dtCount.Text), txtTransType.Text, txtTransType.SelectedIndex, txtNote.Text) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                LoadFilterdGrid();

                #region Update Attendance Tr
                int LPermissionID = HR_Basics.GetLeavePermissionID(Convert.ToInt32(txtEmpName.SelectedValue));

                DateTime PermissionDate = Convert.ToDateTime(dtTransDate.Value.ToShortDateString());
                // Update Trans
                try
                {
                    if (txtTransType.SelectedIndex == 0) // حضور متأخر
                    {
                        DateTime ActualComeTime = Convert.ToDateTime(dtTransEndTime.Value.ToShortTimeString());
                        HR_Basics.UpdatePermissionComeLate(Convert.ToInt32(txtEmpName.SelectedValue), PermissionDate, ActualComeTime, LPermissionID);
                    }

                    if (txtTransType.SelectedIndex == 1) // انصراف مبكر
                    {
                        DateTime ActualLeaveTime = Convert.ToDateTime(dtTransStartTime.Value.ToShortTimeString());
                        HR_Basics.UpdatePermissionLeaveEarly(Convert.ToInt32(txtEmpName.SelectedValue), PermissionDate, ActualLeaveTime, LPermissionID);
                    }

                    if (txtTransType.SelectedIndex == 2) // خلال اليوم
                    {
                        HR_Basics.UpdatePermissionDuring(Convert.ToInt32(txtEmpName.SelectedValue), PermissionDate, LPermissionID);
                    }
                    
                }
                catch { }

                #endregion
            }
        }
    }
}
