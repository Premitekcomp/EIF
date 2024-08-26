using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmBonusTransaction : Form
    {
        DateTime FilterStartRange;
        DateTime FilterEndRange;
        int GroupID = 0;
        int EmpID = 0;

        public frmBonusTransaction()
        {
            InitializeComponent();
        }

        private void frmBonusTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_EmplymentGroupTableAdapter.Fill(this.empDataSet.HR_Lup_EmplymentGroup);
                this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
            }
            catch { }

            txtEmpFileID.SelectedIndex = -1;
            txtGroupID.SelectedIndex = -1;
            txtEmpName.SelectedIndex = -1;

            FilterStartRange = dtStartDate.Value;
            FilterEndRange = dtEndDate.Value;
        }

        private void loadFilterGridByGroup()
        {
            try
            {
                this.hR_Tra_BounceTransactionViewTableAdapter.FillByGroupID(this.traDataSet.HR_Tra_BounceTransactionView, FilterStartRange.ToString(), FilterEndRange.ToString(), Convert.ToByte(GroupID));
            }
            catch { }
        }

        private void loadFilterGridByEmpID()
        {
            try
            {
                this.hR_Tra_BounceTransactionViewTableAdapter.FillByEmpID(this.traDataSet.HR_Tra_BounceTransactionView, Convert.ToInt16(EmpID), FilterStartRange.ToString(), FilterEndRange.ToString());
            }
            catch { }
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            FilterStartRange = dtStartDate.Value;
            dtEndDate.Value = dtStartDate.Value;
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            FilterEndRange = dtEndDate.Value;
        }

        private void txtGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGroupID.SelectedIndex != -1)
            {
                GroupID = Convert.ToInt32(txtGroupID.SelectedValue);
                loadFilterGridByGroup();

                txtGroupID.SelectedIndex = -1;
            }
        }

        private void txtEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpName.SelectedIndex != -1)
            {
                EmpID = Convert.ToInt32(txtEmpName.SelectedValue);
                loadFilterGridByEmpID();

                txtEmpName.SelectedIndex = -1;
            }
        }

        private void txtEmpFileID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpFileID.SelectedIndex != -1)
            {
                EmpID = Convert.ToInt32(txtEmpFileID.SelectedValue);
                loadFilterGridByEmpID();

                txtEmpFileID.SelectedIndex = -1;

            }
        }

    }
}
