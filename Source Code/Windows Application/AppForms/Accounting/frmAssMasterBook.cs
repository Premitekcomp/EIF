using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode;
using TMS.AppCode.DAL.Accounting;

namespace TMS.AppForms.Accounting
{
    public partial class frmAssMasterBook : Form
    {
        int ActiveEntryID = 0;
        private frmEnhancedMDI ParentForm = null;

        public frmAssMasterBook()
        {
            InitializeComponent();
        }

        private void frmJournalEntryList_Load(object sender, EventArgs e)
        {

            LoadAccountListTreeView();
            LoadCombo();
        }

        private void LoadCombo()
        {
            try
            {
                this.a_AccountsListTableAdapter.Fill(this.accounting.A_AccountsList);
                txtAccountName.SelectedIndex = -1;

                this.a_AccountsNumberListTableAdapter.Fill(this.accounting.A_AccountsNumberList);
                txtAccountNumber.SelectedIndex = -1;
            }
            catch { }
        }

        #region AccountList TreeView
        private void LoadAccountListTreeView()
        {
            AccountListTreeView.Nodes.Clear();

            DataTable AccountsTreeDT = new DataTable();
            AccountsTreeDT = AccountsListOperation.GetAccountByLevel(1);

            foreach (DataRow DRow in AccountsTreeDT.Rows)
            {
                TreeNode L1Node = new TreeNode();
                L1Node.Name = DRow["AccountID"].ToString();
                L1Node.Text = DRow["AccountNumber"].ToString() + " " + DRow["AccountName"].ToString();
                L1Node.ForeColor = Color.Green;

                #region Level 2
                if (AccountsListOperation.GetSubCountNextSerial(Convert.ToInt32(DRow["AccountID"].ToString())) - 1 > 0)
                {
                    DataTable AccountsTreeL2DT = new DataTable();
                    AccountsTreeL2DT = AccountsListOperation.GetAccountByParentID(Convert.ToInt32(DRow["AccountID"].ToString()));

                    foreach (DataRow DRowL2 in AccountsTreeL2DT.Rows)
                    {
                        TreeNode L2Node = new TreeNode();
                        L2Node.Name = DRowL2["AccountID"].ToString();
                        L2Node.Text = DRowL2["AccountNumber"].ToString() + " " + DRowL2["AccountName"].ToString();
                        L1Node.Nodes.Add(L2Node);

                        #region Level 3
                        if (AccountsListOperation.GetSubCountNextSerial(Convert.ToInt32(DRowL2["AccountID"].ToString())) - 1 > 0)
                        {
                            DataTable AccountsTreeL3DT = new DataTable();
                            AccountsTreeL3DT = AccountsListOperation.GetAccountByParentID(Convert.ToInt32(DRowL2["AccountID"].ToString()));
                            foreach (DataRow DRowL3 in AccountsTreeL3DT.Rows)
                            {
                                TreeNode L3Node = new TreeNode();
                                L3Node.Name = DRowL3["AccountID"].ToString();
                                L3Node.Text = DRowL3["AccountNumber"].ToString() + " " + DRowL3["AccountName"].ToString();
                                L2Node.Nodes.Add(L3Node);

                                #region Level 4
                                if (AccountsListOperation.GetSubCountNextSerial(Convert.ToInt32(DRowL3["AccountID"].ToString())) - 1 > 0)
                                {
                                    DataTable AccountsTreeL4DT = new DataTable();
                                    AccountsTreeL4DT = AccountsListOperation.GetAccountByParentID(Convert.ToInt32(DRowL3["AccountID"].ToString()));
                                    foreach (DataRow DRowL4 in AccountsTreeL4DT.Rows)
                                    {
                                        TreeNode L4Node = new TreeNode();
                                        L4Node.Name = DRowL4["AccountID"].ToString();
                                        L4Node.Text = DRowL4["AccountNumber"].ToString() + " " + DRowL4["AccountName"].ToString();
                                        L3Node.Nodes.Add(L4Node);
                                    }
                                }
                                #endregion
                            }
                        }
                        #endregion

                    }
                }
                #endregion

                AccountListTreeView.Nodes.Add(L1Node);
            }
        }

        private void AccountListTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = AccountListTreeView.SelectedNode;
            try
            {
                txtAccountNumber.SelectedValue = (Convert.ToInt32(node.Name));
                AccountListTreeView.Visible = false;
            }
            catch { }

        }
        #endregion

        #region Buttons
        private void CmdGetAccountFromJournal_Click(object sender, EventArgs e)
        {
            if (AccountListTreeView.Visible == false)
            {
                AccountListTreeView.Visible = true;
            }
            else
            {
                AccountListTreeView.Visible = false;
            }
        }

        private void txtAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAccountNumber.SelectedIndex != -1)
            {
                txtAccountName.SelectedValue = txtAccountNumber.SelectedValue;
            }
        }

        private void txtAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAccountName.SelectedIndex != -1)
            {
                txtAccountNumber.SelectedValue = txtAccountName.SelectedValue;
                LoadSubAccountList();
            }
        }

        private void LoadSubAccountList()
        {
            try
            {
                this.a_SubAccountsListTableAdapter.FillByMastrAccountID(this.accounting.A_SubAccountsList, Convert.ToInt16(txtAccountName.SelectedValue), Convert.ToInt16(txtAccountName.SelectedValue));
                if (txtSubAccountList.Items.Count > 0)
                {
                    txtSubAccountList.Visible = true;
                    txtSubAccountList.SelectedIndex = -1;
                }
                else
                {
                    txtSubAccountList.Visible = false;
                }
            }
            catch { }
        }

        private void CmdFilterByDate_Click(object sender, EventArgs e)
        {
            if(txtAccountName.SelectedIndex == -1)
            {
                MessageBox.Show("يجب تحديد الحساب");
                txtAccountName.Focus();
                return;
            }
            else
            {
                FilterByAccountInDateRange();
            }
        }

        private void CmdFilterBuSub_Click(object sender, EventArgs e)
        {
            if (txtSubAccountList.SelectedIndex != -1)
            {
                FilterByAnaliticAccountInDateRange();
            }
            else
            {
                MessageBox.Show("يجب تحديد الحساب التحليلي");
            }
        }

        private void CmdExport_Click(object sender, EventArgs e)
        {
            return;
            AppReports.AccountingRep.RepEntryBasicListXLSExport RepName = new AppReports.AccountingRep.RepEntryBasicListXLSExport();
            RepName.SetDataSource(this.accounting);

            AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            Openfrm.CRPreview.ReportSource = RepName;
            Openfrm.CRPreview.ExportReport();
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            return;
            AppReports.AccountingRep.RepEntryBasicList RepName = new AppReports.AccountingRep.RepEntryBasicList();
            RepName.SetDataSource(this.accounting);

            AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            Openfrm.CRPreview.ReportSource = RepName;
            Openfrm.Show();
        }
        #endregion

        #region Filters Method
       
        private void FilterByAccountInDateRange()
        {
            try
            {
                this.a_AssMasterBookReportsTableAdapter.FillByAccountInDateRange(this.accounting.A_AssMasterBookReports, dtStart.Value.ToString(), dtEnd.Value.ToString(), Convert.ToInt16(txtAccountName.SelectedValue), Convert.ToInt16(txtAccountName.SelectedValue));
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByAnaliticAccountInDateRange()
        {
            try
            {
                this.a_AssMasterBookReportsTableAdapter.FillBySubAccountInDateRange(this.accounting.A_AssMasterBookReports, dtStart.Value.ToString(), dtEnd.Value.ToString(), Convert.ToInt16(txtSubAccountList.SelectedValue));
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void GetEntryGlobalBalance()
        {
            decimal OVCreditSum = 0;
            decimal OVDebitSum = 0;

            decimal AccumlatedSum = 0;
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                OVDebitSum = OVDebitSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[13].Value.ToString());
                OVCreditSum = OVCreditSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[14].Value.ToString());

                AccumlatedSum = AccumlatedSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[16].Value.ToString());
                grvEntryList.Rows[grvRow.Index].Cells[17].Value = AccumlatedSum.ToString();
            }

            lblOverAllCredit.Text = OVCreditSum.ToString();
            lblOverAllDepit.Text = OVDebitSum.ToString();
        }

        #endregion

        #region Global Validation
        private void VlidateDecimalInput(object sender, KeyPressEventArgs e)
        {
            if (DataValidation.CheckDeciamlNumber(sender, e) == 1)
            {
                e.Handled = true;
            }
        }

        private void ValidateNonDecimal(object sender, KeyPressEventArgs e)
        {
            if (DataValidation.CheckNonDecimalNumber(e) == 1)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void grvEntryList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                //ActiveEntryID = Convert.ToInt32(grvEntryList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void grvEntryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int EID = Convert.ToInt32(grvEntryList.Rows[e.RowIndex].Cells[1].Value.ToString());

                if(e.ColumnIndex == 4)
                {
                    frmSimpleJournalEntry OpenForm = new frmSimpleJournalEntry(EID);
                    OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    OpenForm.MaximizeBox = false;
                    OpenForm.MinimizeBox = false;
                    OpenForm.ShowDialog();
                }
            }
        }

        private void CmdLookupAccount_Click(object sender, EventArgs e)
        {
            AppCode.GlobalParamters.ScanAccountingID = 0;
            frmLookUpAccount OpenForm = new frmLookUpAccount();
            OpenForm.ShowDialog();
            if (AppCode.GlobalParamters.ScanAccountingID != 0)
            {
                txtAccountName.SelectedValue = GlobalParamters.ScanAccountingID;
                AppCode.GlobalParamters.ScanAccountingID = 0;
            }
        }

      
    }
}
