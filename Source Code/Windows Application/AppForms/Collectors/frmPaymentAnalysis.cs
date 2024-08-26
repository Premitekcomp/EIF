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
    public partial class frmPaymentAnalysis : Form
    {
        public frmPaymentAnalysis()
        {
            InitializeComponent();
        }

        private void frmPaymentAnalysis_Load(object sender, EventArgs e)
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
            }
        }

        private void CmdLoadDomain_Click(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                try
                {
                    this.gridCompareDomainGBBucketTableAdapter.FillWithPaymentSum(this.eIFCollector.GridCompareDomainGBBucket, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                    LoadFullView();
                }
                catch { }
            }
        }

        private void LoadFullView()
        {
            foreach (DataGridViewRow grvRow in grvFullDomain.Rows)
            {
                // Read Bucket
                int CatchedBucket = Convert.ToInt32(grvFullDomain.Rows[grvRow.Index].Cells[0].Value.ToString());

                // Get Bucket Target
                decimal BucketTarget = DomainOperations.GetBucketTarget(Convert.ToInt32(txtAvaliableIDs.Text), CatchedBucket);

                // Update Columns
                grvFullDomain.Rows[grvRow.Index].Cells[1].Value = BucketTarget.ToString();
                
                decimal TargetRemaining = BucketTarget - Convert.ToDecimal(grvFullDomain.Rows[grvRow.Index].Cells[2].Value.ToString());
                grvFullDomain.Rows[grvRow.Index].Cells[4].Value = TargetRemaining.ToString();

                decimal TargetPercentage = Convert.ToDecimal(grvFullDomain.Rows[grvRow.Index].Cells[2].Value.ToString()) / BucketTarget;
                grvFullDomain.Rows[grvRow.Index].Cells[3].Value = Convert.ToString(Math.Round(TargetPercentage, 2) * 100);

            }
        }
        
    }
}
