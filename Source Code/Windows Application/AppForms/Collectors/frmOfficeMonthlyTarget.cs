using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.CollectionDept;

namespace TMS.AppForms.Collectors
{
    public partial class frmOfficeMonthlyTarget : Form
    {
        public frmOfficeMonthlyTarget()
        {
            InitializeComponent();
        }

        private void frmOfficeMonthlyTarget_Load(object sender, EventArgs e)
        {
         
            LoadCombo();
            LoadDefaultUI();
        }

        private void LoadCombo()
        {
            try
            {
                this.lup_BranchListTableAdapter.Fill(this.eIFCollector.Lup_BranchList);
                this.hR_Lup_BankListTableAdapter.Fill(this.eIFCollector.HR_Lup_BankList);
                this.col_Lup_MonthListTableAdapter.Fill(this.eIFCollector.Col_Lup_MonthList);
            }
            catch { }
        }

        private void LoadDefaultUI()
        {
            txtBankBranch.SelectedIndex = -1;
            txtBranchID.SelectedIndex = -1;
            txtMonth.SelectedIndex = -1;

        }

        private void CmdGetDomainIDs_Click(object sender, EventArgs e)
        {
            if (txtBankBranch.SelectedIndex != -1 && txtBranchID.SelectedIndex != -1 && txtMonth.SelectedIndex != -1)
            {
                try
                {
                    this.col_Lup_DomainSerialFilterdTableAdapter.FillByFilterdData(this.eIFCollector.Col_Lup_DomainSerialFilterd, Convert.ToInt16(txtMonth.SelectedValue), Convert.ToByte(txtBankBranch.SelectedValue), Convert.ToByte(txtBranchID.SelectedValue));
                    txtAvaliableIDs.SelectedIndex = -1;
                }
                catch { }
            }
        }

        private void txtAvaliableIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                lblDomainVersion.Text = "Current Domain Version: " + txtAvaliableIDs.SelectedValue.ToString();
                LoadTargetGrid();
            }
        }

        private void LoadTargetGrid()
        {
            try
            {
                this.col_Bsk_MonthlyTargetTableAdapter.FillByDomainID(this.eIFCollectorAnalysis.Col_Bsk_MonthlyTarget, Convert.ToInt32(txtAvaliableIDs.Text));
                LoadBucketTarget(Convert.ToInt32(grvTargetBasic.Rows[0].Cells[0].Value.ToString()));
            }
            catch { }
        }

        private void LoadBucketTarget(int TargetID)
        {
            try
            {
                this.col_Bsk_MonthlyTargetDetailsTableAdapter.FillByTargetID(this.eIFCollectorAnalysis.Col_Bsk_MonthlyTargetDetails, TargetID);
            }
            catch { }
        }

        private void CmdSaveOverallTarget_Click(object sender, EventArgs e)
        {
            try
            {
                DomainOperations.InsertBasicTarget(Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToInt32(txtOverallTarget.Text));
                LoadTargetGrid();
            }
            catch { }
        }

        private void CmdSaveBucketTarget_Click(object sender, EventArgs e)
        {
            try
            {
                int TargetID = Convert.ToInt32(grvTargetBasic.Rows[0].Cells[0].Value.ToString());
                DomainOperations.InsertDetailsTarget(TargetID, Convert.ToInt32(txtBucket.Text), Convert.ToDecimal(txtBucketTarget.Text));
                LoadBucketTarget(TargetID);
            }
            catch { }
        }
        
    }
}
