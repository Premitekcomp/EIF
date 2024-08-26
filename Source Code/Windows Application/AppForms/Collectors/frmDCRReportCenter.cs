using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.Collectors
{
    public partial class frmDCRReportCenter : Form
    {
        public frmDCRReportCenter()
        {
            InitializeComponent();
        }

        private void frmDCRReportCenter_Load(object sender, EventArgs e)
        {   
            LoadCombo();
            LoadDefaultUI();
        }

        #region Filter Head
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

        #endregion

        #region Non Worked
        private void CmdNunWorkedGetData_Click(object sender, EventArgs e)
        {
            try
            {
                this.col_Reports_NunWorkedAccountsTableAdapter.FillByDomain(this.eIFCollectorAnalysis.Col_Reports_NunWorkedAccounts, Convert.ToInt64(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                NonWorkedSummary();
            }
            catch {
                try
                    {
                        this.col_Reports_NunWorkedAccountsTableAdapter.FillByDomain(this.eIFCollectorAnalysis.Col_Reports_NunWorkedAccounts, Convert.ToInt64(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                        NonWorkedSummary();
                    }
                catch { }
            }
        }

        private void NonWorkedSummary()
        {
            int CallCount = 0;
            int VisitCount = 0;

            foreach (DataGridViewRow grvNunWorkedRow in grvNunWorked.Rows)
            {
                CallCount = CallCount + Convert.ToInt32(grvNunWorked.Rows[grvNunWorkedRow.Index].Cells[5].Value.ToString());
                VisitCount = VisitCount + Convert.ToInt32(grvNunWorked.Rows[grvNunWorkedRow.Index].Cells[6].Value.ToString());
            }

            lvNonWorked.Items.Clear();

            ListViewItem NonWorkedRecordCount = new ListViewItem();
            NonWorkedRecordCount.Text = "Account No.";
            NonWorkedRecordCount.SubItems.Add(grvNunWorked.Rows.Count.ToString());
            lvNonWorked.Items.Add(NonWorkedRecordCount);

            ListViewItem NonWorkedCallCount = new ListViewItem();
            NonWorkedCallCount.Text = "Call Count";
            NonWorkedCallCount.SubItems.Add(CallCount.ToString());
            lvNonWorked.Items.Add(NonWorkedCallCount);

            ListViewItem NonWorkedVisitCount = new ListViewItem();
            NonWorkedVisitCount.Text = "Visit Count";
            NonWorkedVisitCount.SubItems.Add(VisitCount.ToString());
            lvNonWorked.Items.Add(NonWorkedVisitCount);

            ListViewItem NonWorkedGrandTotal = new ListViewItem();
            NonWorkedGrandTotal.Text = "Total";
            NonWorkedGrandTotal.SubItems.Add((CallCount + VisitCount).ToString());
            lvNonWorked.Items.Add(NonWorkedGrandTotal);
        }
        
        #endregion

        #region Trials
        private void CmdtrialsBuild_Click(object sender, EventArgs e)
        {
            try
            {
                this.col_Reports_TrialsRepTableAdapter.FillByDomain(this.eIFCollectorAnalysis.Col_Reports_TrialsRep, Convert.ToInt64(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                TrialsSummary();
            }
            catch { }
        }

        private void TrialsSummary()
        {
            int AccountCount = 0;
            int BalanceSum = 0;

            foreach (DataGridViewRow grvNunWorkedRow in grvTrials.Rows)
            {
                AccountCount = AccountCount + Convert.ToInt32(grvTrials.Rows[grvNunWorkedRow.Index].Cells[5].Value.ToString());
                BalanceSum = BalanceSum + Convert.ToInt32(grvTrials.Rows[grvNunWorkedRow.Index].Cells[6].Value.ToString());
            }

            LVTrials.Items.Clear();
            
            ListViewItem AccountRecordCount = new ListViewItem();
            AccountRecordCount.Text = "Account Count";
            AccountRecordCount.SubItems.Add(AccountCount.ToString());
            LVTrials.Items.Add(AccountRecordCount);

            ListViewItem BalanceRecordSum = new ListViewItem();
            BalanceRecordSum.Text = "Balance Sum";
            BalanceRecordSum.SubItems.Add(BalanceSum.ToString());
            LVTrials.Items.Add(BalanceRecordSum);

        }
        #endregion

        #region Productivity
        private void CmdProductivityBuild_Click(object sender, EventArgs e)
        {
            try
            {
                this.col_Reports_ProductivityRep2TableAdapter.FillByDomain(this.eIFCollectorAnalysis.Col_Reports_ProductivityRep2, Convert.ToByte(txtAvaliableIDs.SelectedValue), Convert.ToInt64(txtAvaliableIDs.Text));
                this.col_Reports_ProductivityRep1TableAdapter.FillByDomain(this.eIFCollectorAnalysis.Col_Reports_ProductivityRep1, Convert.ToByte(txtAvaliableIDs.SelectedValue), Convert.ToInt64(txtAvaliableIDs.Text));
            }
            catch { }
        }
        #endregion

        #region DCR Report
        private void CmdDCRBuild_Click(object sender, EventArgs e)
        {
            try
            {
                this.col_RepDCRReportTableAdapter.FillBy(this.eIFCollectorAnalysis.Col_RepDCRReport, Convert.ToInt64(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
            }
            catch { }
        }
        #endregion


    }
}
