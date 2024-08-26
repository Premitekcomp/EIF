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
    public partial class frmSimpleJournalEntry : Form
    {
        int ActiveMasterEntryID = 0;

        public frmSimpleJournalEntry(int EntryID)
        {
            InitializeComponent();
            ActiveMasterEntryID = EntryID;
        }

        private void frmSimpleJournalEntry_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadAccountsList();
            LoadAccountListTreeView();

            if(ActiveMasterEntryID!= 0)
            {
                DataTable DT = new DataTable();
                DT = JournalOperations.ReadEntryBasicDate(ActiveMasterEntryID);
                foreach(DataRow dr in DT.Rows)
                {
                    lblEntryNo.Text = dr["ENo"].ToString();
                    txtEntryNote.Text = dr["Notes"].ToString();
                    lblOverAllCredit.Text = dr["TotalCredit"].ToString();
                    lblOverAllDepit.Text = dr["TotalDebit"].ToString();
                    txtEntryType.SelectedValue = Convert.ToInt32(dr["EntryTypeID"].ToString());
                    dtEntryDate.Value = Convert.ToDateTime(dr["EDate"].ToString());
                }
                if (lblOverAllCredit.Text != lblOverAllDepit.Text)
                {
                    lblUnBalancedEntry.Visible = true;
                    lblOverAllCredit.BackColor = Color.Red;
                    lblOverAllDepit.BackColor = Color.Red;
                }
                else
                {
                    lblUnBalancedEntry.Visible = false;
                    lblOverAllCredit.BackColor = Color.Green;
                    lblOverAllDepit.BackColor = Color.Green;
                }
                
                LoadJournalDetails();
            }
        }

        private void LoadCombo()
        {
            try
            {
                this.lup_currencyTypesTableAdapter.Fill(this.lupComboFill.Lup_currencyTypes);
                try { txtCurrency.SelectedValue = 1; }
                catch { }

                this.a_Lup_JETypesTableAdapter.Fill(this.accounting.A_Lup_JETypes);
                txtEntryType.SelectedIndex = -1;
            }
            catch { }
        }

        private void LoadAccountsList()
        {
            try
            {
                this.accountNameForJournalTableAdapter.Fill(this.accounting.AccountNameForJournal);
                txtAccountName.SelectedIndex = -1;

                this.accountNumberForJournalTableAdapter.Fill(this.accounting.AccountNumberForJournal);
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

                                        #region Level 5
                                        if (AccountsListOperation.GetSubCountNextSerial(Convert.ToInt32(DRowL4["AccountID"].ToString())) - 1 > 0)
                                        {
                                            DataTable AccountsTreeL5DT = new DataTable();
                                            AccountsTreeL5DT = AccountsListOperation.GetAccountByParentID(Convert.ToInt32(DRowL4["AccountID"].ToString()));
                                            foreach (DataRow DRowL5 in AccountsTreeL5DT.Rows)
                                            {
                                                TreeNode L5Node = new TreeNode();
                                                L5Node.Name = DRowL5["AccountID"].ToString();
                                                L5Node.Text = DRowL5["AccountNumber"].ToString() + " " + DRowL5["AccountName"].ToString();
                                                L4Node.Nodes.Add(L5Node);

                                                #region Level 6
                                                if (AccountsListOperation.GetSubCountNextSerial(Convert.ToInt32(DRowL5["AccountID"].ToString())) - 1 > 0)
                                                {
                                                    DataTable AccountsTreeL6DT = new DataTable();
                                                    AccountsTreeL6DT = AccountsListOperation.GetAccountByParentID(Convert.ToInt32(DRowL5["AccountID"].ToString()));
                                                    foreach (DataRow DRowL6 in AccountsTreeL6DT.Rows)
                                                    {
                                                        TreeNode L6Node = new TreeNode();
                                                        L6Node.Name = DRowL6["AccountID"].ToString();
                                                        L6Node.Text = DRowL6["AccountNumber"].ToString() + " " + DRowL6["AccountName"].ToString();
                                                        L5Node.Nodes.Add(L6Node);
                                                    }
                                                }
                                                #endregion
                                            }
                                        }
                                        #endregion
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

        #region UI
        private void LoadSubAccountList()
        {
            try
            {
                this.a_SubAccountsListTableAdapter.FillByMastrAccountID(this.accounting.A_SubAccountsList, Convert.ToInt16(txtAccountName.SelectedValue), Convert.ToInt16(txtAccountName.SelectedValue));
                if(txtSubAccountList.Items.Count >0)
                {
                    txtSubAccountList.Visible = true;
                    txtSubAccountList.SelectedIndex = -1;
                }
                else
                {
                    txtSubAccountList.Visible = false   ;
                }
            }
            catch { }
        }

        private void txtAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtAccountNumber.SelectedIndex != -1)
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

        private void txtCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCurrency.SelectedIndex != -1)
            {
                if (Convert.ToInt16(txtCurrency.SelectedValue) == 1)
                {
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;

                    txtExchangeRate.Visible = false;
                    txtDebitForginCurreny.Visible = false;
                    txtCridtForginCurrency.Visible = false;
                }
                else
                {
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;

                    txtExchangeRate.Visible = true;
                    txtDebitForginCurreny.Visible = true;
                    txtCridtForginCurrency.Visible = true;

                    txtExchangeRate.Text = (JournalOperations.GetCurrentExcnageRate(Convert.ToInt16(txtCurrency.SelectedValue))).ToString();
                }
            }
        }

        private void txtDebitForginCurreny_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ExchangeRate = Convert.ToDecimal(txtExchangeRate.Text);
                decimal ForginDepit = Convert.ToDecimal(txtDebitForginCurreny.Text);
                decimal LocalDepti = ForginDepit * ExchangeRate;

                txtDebitLocalCurrency.Text = LocalDepti.ToString();
            }
            catch { }
        }

        private void txtCridtForginCurrency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ExchangeRate = Convert.ToDecimal(txtExchangeRate.Text);
                decimal ForginCredit = Convert.ToDecimal(txtCridtForginCurrency.Text);
                decimal LocalCredit = ForginCredit * ExchangeRate;

                txtCridtLocalCurrency.Text = LocalCredit.ToString();
            }
            catch { }
        }

        private void txtDebitLocalCurrency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //decimal ExchangeRate = Convert.ToDecimal(txtExchangeRate.Text);
                //decimal LocalDepti = Convert.ToDecimal(txtDebitLocalCurrency.Text);
                //decimal ForginDepit = LocalDepti / ExchangeRate;

                //txtDebitForginCurreny.Text = ForginDepit.ToString();
            }
            catch { }
        }

        private void txtCridtLocalCurrency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //decimal ExchangeRate = Convert.ToDecimal(txtExchangeRate.Text);
                //decimal LocalCridit = Convert.ToDecimal(txtCridtLocalCurrency.Text);
                //decimal ForginCridt = LocalCridit / ExchangeRate;

                //txtCridtForginCurrency.Text = ForginCridt.ToString();
            }
            catch { }
        }

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
        #endregion

        #region DAL
        private bool ValidateEntryHeader()
        {
            if(txtEntryType.SelectedIndex == -1)
            {
                txtEntryType.SelectedValue = 500;
            }
            return true;
        }

        private bool ValidateEntryDetails()
        {
            if(ActiveMasterEntryID == 0)
            {
                lblMSG.Text = "لا يوجد قيد مفتوح";
                return false;
            }

            if (txtAccountName.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب تحديد الحساب";
                txtAccountName.Focus();
                return false;
            }

            if (txtSubAccountList.Visible==true && txtSubAccountList.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب اختيار الحساب التحليلي";
                txtSubAccountList.Focus();
                return false;
            }

            if (txtCurrency.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب تحديد العمله";
                txtSubAccountList.Focus();
                return false;
            }

            if (txtCridtLocalCurrency.Text.Trim().Length != 0 && txtDebitLocalCurrency.Text.Trim().Length != 0)
            {
                if (Convert.ToDecimal(txtCridtLocalCurrency.Text) > 0 && Convert.ToDecimal(txtDebitLocalCurrency.Text) > 0)
                {
                    DialogResult GetConfirmation = MessageBox.Show("لا يبدو ان هذا القيد سليم محاسبيا, هل تريد الحفظ علي اي حال ؟", "Get Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.No)
                    {
                        return false;
                    }
                } 
            }
            return true;
        }

        private void ResetDetails()
        {
            lblMSG.Text = "";
            txtAccountNumber.SelectedIndex = -1;
            txtAccountName.SelectedIndex = -1;
            txtSubAccountList.SelectedIndex = -1;
            txtExchangeRate.Text = "0";
            txtCridtForginCurrency.Text = "0";
            txtDebitForginCurreny.Text = "0";
            txtCridtLocalCurrency.Text = "0";
            txtDebitLocalCurrency.Text = "0";
            txtSubNote.Text = "";

            txtAccountName.Focus();
        }

        private void PrepareForNew()
        {
            ActiveMasterEntryID = 0;
            lblEntryNo.Text = "NA";
            txtEntryNote.Text = "";
            if(txtEntryType.SelectedIndex == -1)
            {
                txtEntryType.SelectedValue = 500;
            }
            lblOverAllCredit.Text = "0";
            lblOverAllDepit.Text = "0";
            txtSubNote.Text = "";

            LoadJournalDetails();
            txtAccountName.Focus();

        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if(ActiveMasterEntryID == 0)
            {
                #region Create New Journal Entry
                ValidateEntryHeader();
                lblEntryNo.Text = JournalOperations.GetNextJournalEntryNumber().ToString();
                ActiveMasterEntryID = JournalOperations.MakeNewJournalEntry(Convert.ToInt32(lblEntryNo.Text), dtEntryDate.Value, Convert.ToInt32(txtEntryType.SelectedValue), txtEntryNote.Text, true);
                if (ActiveMasterEntryID > 0)
                {
                    InsertJournalDetails();
                }
                else
                {
                    lblMSG.Text = "خطأ اثناء فتح القيد";
                    return;
                }
                #endregion
            }
            else
            {
                InsertJournalDetails();
            }
            UpdateJoutnalTotals();

        }

        private void InsertJournalDetails()
        {
            if(ValidateEntryDetails()==false)
            {
                return;
            }
            if(txtSubNote.Text.Trim().Length ==0)
            {
                txtSubNote.Text = txtEntryNote.Text;
            }

            int SubAccID = 0;
            if(txtSubAccountList.Visible == true)
            { SubAccID = Convert.ToInt32(txtSubAccountList.SelectedValue); }

            if (JournalOperations.MakeNewEntryDetails(ActiveMasterEntryID, Convert.ToInt32(txtAccountName.SelectedValue), SubAccID, Convert.ToDecimal(txtDebitForginCurreny.Text), Convert.ToDecimal(txtCridtForginCurrency.Text), Convert.ToInt32(txtCurrency.SelectedValue), Convert.ToDecimal(txtExchangeRate.Text), Convert.ToDecimal(txtDebitLocalCurrency.Text), Convert.ToDecimal(txtCridtLocalCurrency.Text), txtSubNote.Text) > 0)
            {
                ResetDetails();
                LoadJournalDetails();
                GetEntryGlobalBalance();
            }
            else
            {
                lblMSG.Text = "خطأ اثناء اضافه تفاصيل القيد";
            }
        }

        private void LoadJournalDetails()
        {
            try
            {
                this.a_JournalDetailsViewTableAdapter.FillByEntryID(this.accounting.A_JournalDetailsView, ActiveMasterEntryID);
                this.a_CostCenterValuesTableAdapter.FillByEID(this.accounting.A_CostCenterValues, ActiveMasterEntryID);
            }
            catch { }
        }

        private void GetEntryGlobalBalance()
        {
            decimal OVCreditSum = 0;
            decimal OVDebitSum = 0;

            foreach(DataGridViewRow grvRow in grvEntryDetails.Rows)
            {
                OVDebitSum = OVDebitSum + Convert.ToDecimal(grvEntryDetails.Rows[grvRow.Index].Cells[13].Value.ToString());
                OVCreditSum = OVCreditSum + Convert.ToDecimal(grvEntryDetails.Rows[grvRow.Index].Cells[14].Value.ToString());
            }

            lblOverAllCredit.Text = OVCreditSum.ToString();
            lblOverAllDepit.Text = OVDebitSum.ToString();

            if(OVCreditSum != OVDebitSum)
            {
                lblOverAllCredit.BackColor = Color.Red;
                lblOverAllDepit.BackColor = Color.Red;
                lblUnBalancedEntry.Visible = true;
            }
            else
            {
                lblOverAllCredit.BackColor = Color.Green;
                lblOverAllDepit.BackColor = Color.Green;
                lblUnBalancedEntry.Visible = false;
            }
        }
        #endregion

        private void CmdCloseEntry_Click(object sender, EventArgs e)
        {
            decimal GCredit=Convert.ToDecimal(lblOverAllCredit.Text);
            decimal GDepit=Convert.ToDecimal(lblOverAllDepit.Text);

            #region Optional Validation
            if(GCredit != GDepit)
            {
                DialogResult GetConfirmation = MessageBox.Show("القيد غير متزن, هل تريد الحفظ علي اي حال ؟", "Get Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (GetConfirmation == DialogResult.No)
                {
                    return;
                }
            }
            #endregion

            if(ValidateEntryHeader() == false)
            {
                return;
            }
            if(JournalOperations.UpdateEntryGlobalBalance(ActiveMasterEntryID, GDepit, GCredit, txtEntryNote.Text, dtEntryDate.Value, Convert.ToInt32(txtEntryType.SelectedValue)) == 1)
            {
                PrepareForNew();
            }
            else
            {
                MessageBox.Show("خطأ اثناء حفظ القيد");
            }

        }

        private void grvEntryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(grvEntryDetails.Rows[e.RowIndex].Cells[0].Value.ToString());

                decimal ForginDepit = Convert.ToDecimal(grvEntryDetails.Rows[e.RowIndex].Cells[10].Value.ToString());
                decimal ForignCredit = Convert.ToDecimal(grvEntryDetails.Rows[e.RowIndex].Cells[11].Value.ToString());
                decimal EXRate = Convert.ToDecimal(grvEntryDetails.Rows[e.RowIndex].Cells[12].Value.ToString());
                decimal Depit = Convert.ToDecimal(grvEntryDetails.Rows[e.RowIndex].Cells[13].Value.ToString());
                decimal Credit = Convert.ToDecimal(grvEntryDetails.Rows[e.RowIndex].Cells[14].Value.ToString());
                string EntryNote = grvEntryDetails.Rows[e.RowIndex].Cells[15].Value.ToString();

                #region Edit
                if (e.ColumnIndex==16)
                {
                    if(ForginDepit != 0)
                    {
                        Depit = ForginDepit * EXRate;
                    }
                    if (ForignCredit != 0)
                    {
                        Credit = ForignCredit * EXRate;
                    }
                    if (JournalOperations.UpdateEntryDetails(RID, ForginDepit, ForignCredit, Depit, Credit, EntryNote) == 1)
                    {
                        LoadJournalDetails();
                        GetEntryGlobalBalance();
                    }
                    else
                    {
                        lblMSG.Text = "خطأ اثناء عمليه التحديث";
                    }

                }
                #endregion

                #region Delete
                if (e.ColumnIndex == 17)
                {
                    DialogResult GetConfirmation = MessageBox.Show("ستقوم بحذف هذا القيد مما سيؤثر علي القيد و الحسابات عموما, هل تريد الاستمرار علي اي حال ؟", "Get Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (GetConfirmation == DialogResult.Yes)
                    {
                        if (JournalOperations.DeleteEntryDetails(RID) == 1)
                        {
                            LoadJournalDetails();
                            GetEntryGlobalBalance();
                        }
                        else
                        {
                            lblMSG.Text = "خطأ اثناء عمليه الحذف";
                        }
                    }
                }
                #endregion

                UpdateJoutnalTotals();
            }
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            if(ActiveMasterEntryID != 0)
            {
                #region Load Basic Data
                try
                {
                    this.a_JournalBasicViewTableAdapter.FillByEID(this.accounting.A_JournalBasicView, ActiveMasterEntryID);
                }
                catch { }
                #endregion

                AppReports.AccountingRep.RepEntrySingleRecord RepName = new AppReports.AccountingRep.RepEntrySingleRecord();
                RepName.SetDataSource(this.accounting);

                AppReports.AccountingRep.frmPreview OpenForm = new AppReports.AccountingRep.frmPreview();
                OpenForm.CRPreview.ReportSource = RepName;
                OpenForm.Show();
            }
        }

        private void CmdShowEntry_Click(object sender, EventArgs e)
        {
            if(txtEntryNo.Text.Trim().Length != 0)
            {
                ActiveMasterEntryID =JournalOperations.GetEntryIDbyEntryNo(Convert.ToInt32(txtEntryNo.Text));
                DataTable DT = new DataTable();
                DT = JournalOperations.ReadEntryBasicDate(ActiveMasterEntryID);
                foreach (DataRow dr in DT.Rows)
                {
                    lblEntryNo.Text = dr["ENo"].ToString();
                    txtEntryNote.Text = dr["Notes"].ToString();
                    lblOverAllCredit.Text = dr["TotalCredit"].ToString();
                    lblOverAllDepit.Text = dr["TotalDebit"].ToString();
                    txtEntryType.SelectedValue = Convert.ToInt32(dr["EntryTypeID"].ToString());
                    dtEntryDate.Value = Convert.ToDateTime(dr["EDate"].ToString());
                }
                if (lblOverAllCredit.Text != lblOverAllDepit.Text)
                {
                    lblUnBalancedEntry.Visible = true;
                    lblOverAllCredit.BackColor = Color.Red;
                    lblOverAllDepit.BackColor = Color.Red;
                }
                else
                {
                    lblUnBalancedEntry.Visible = false;
                    lblOverAllCredit.BackColor = Color.Green;
                    lblOverAllDepit.BackColor = Color.Green;
                }

                LoadJournalDetails();
            }
            else
            {
                MessageBox.Show("يجب ادخال رقم القيد");
            }
        }

        private void frmSimpleJournalEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                CmdLookupAccount.PerformClick();
            }

        }

        private void CmdLookupAccount_Click(object sender, EventArgs e)
        {
            AppCode.GlobalParamters.ScanAccountingID = 0;
            frmLookUpAccount OpenForm = new frmLookUpAccount();
            OpenForm.ShowDialog();
            if(AppCode.GlobalParamters.ScanAccountingID != 0)
            {
                txtAccountName.SelectedValue = GlobalParamters.ScanAccountingID;
                AppCode.GlobalParamters.ScanAccountingID = 0;
            }
            
        }

        private void UpdateJoutnalTotals()
        {
            try
            {
                decimal GCredit=Convert.ToDecimal(lblOverAllCredit.Text);
                decimal GDepit=Convert.ToDecimal(lblOverAllDepit.Text);
                JournalOperations.UpdateEntryGlobalBalanceQuick(ActiveMasterEntryID, GDepit, GCredit);

            }
            catch{}
        }

    }
}
