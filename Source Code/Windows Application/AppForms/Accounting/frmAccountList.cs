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
    public partial class frmAccountList : Form
    {
        int ActiveAccountID = 0;

        int ActiveLevel = 0;
        int ActiveAccountType = 0;
        int ParentID = 0;

        public frmAccountList()
        {
            InitializeComponent();
        }

        private void frmAccountList_Load(object sender, EventArgs e)
        {
            LoadAccountListTreeView();
            txtAccountTitle.SelectedIndex = -1;
        }

        private void LoadAccountsList()
        {
            try
            {
                this.a_AccountsListTableAdapter.Fill(this.accounting.A_AccountsList);
                txtAccountTitle.SelectedIndex = -1;
            }
            catch { }
        }

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

            AccountListTreeView.ExpandAll();
            LoadAccountsList();
        }

        private void CmdReLoad_Click(object sender, EventArgs e)
        {
            LoadAccountListTreeView();
        }
        
        private void AccountListTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = AccountListTreeView.SelectedNode;
            LoadSelectAccountInfo(Convert.ToInt32(node.Name));
            lblAccountPath.Text = node.FullPath.ToString();
        }

        private void LoadSelectAccountInfo(int AccountID)
        {
            DataTable AccountsTreeDT = new DataTable();
            AccountsTreeDT = AccountsListOperation.GetAccountByID(AccountID);

            foreach (DataRow DRow in AccountsTreeDT.Rows)
            {
                ActiveAccountID = Convert.ToInt32(DRow["AccountID"].ToString());
                lblAccountNumber.Text = DRow["AccountNumber"].ToString();
                txtAccountTitle.Text = DRow["AccountName"].ToString();
                ActiveLevel = Convert.ToInt32(DRow["LevelID"].ToString());
                ActiveAccountType = Convert.ToInt32(DRow["AccountTypeID"].ToString());
                txtCridtLocalCurrency.Text = DRow["CreditOpenBalance"].ToString();
                txtDebitLocalCurrency.Text = DRow["DepitOpenBalance"].ToString();
            }   
        }

        private void CmdAddSub_Click(object sender, EventArgs e)
        {
            string NewAccountNumber = lblAccountNumber.Text + AccountsListOperation.GetSubCountNextSerial(ActiveAccountID).ToString();
            lblAccountNumber.Text = NewAccountNumber;
            txtAccountTitle.Text = "";
            txtCridtLocalCurrency.Text = "0";
            txtDebitLocalCurrency.Text = "0";
            ParentID = ActiveAccountID; 
            ActiveAccountID = 0;
            ActiveLevel = ActiveLevel + 1;
        }

        private void CmdDoAction_Click(object sender, EventArgs e)
        {
            if(txtAccountTitle.Text.Trim().Length==0)
            {
                MessageBox.Show("يجب تحديد اسم الحساب");
                return;
            }
            if(ActiveAccountID == 0)
            {
                #region Insert
                ActiveAccountID = AccountsListOperation.CreateNewAccount(Convert.ToInt32(lblAccountNumber.Text), txtAccountTitle.Text, ParentID, ActiveLevel, ActiveAccountType, Convert.ToDecimal(txtDebitLocalCurrency.Text), Convert.ToDecimal(txtCridtLocalCurrency.Text));
                if (ActiveAccountID > 0)
                {
                    //LoadAccountListTreeView();
                    lblAccountPath.Text = "NA";
                    txtCridtLocalCurrency.Text = "0";
                    txtDebitLocalCurrency.Text = "0";
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه الحفظ");
                }
                #endregion
            }
            else
            {
                if(AccountsListOperation.UpdateAccountInfo(ActiveAccountID, txtAccountTitle.Text, Convert.ToDecimal(txtDebitLocalCurrency.Text), Convert.ToDecimal(txtCridtLocalCurrency.Text)) == 1)
                {
                    LoadAccountListTreeView();
                    lblAccountPath.Text = "NA";
                    txtCridtLocalCurrency.Text = "0";
                    txtDebitLocalCurrency.Text = "0";
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه التحديث");
                }
            }

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

        private void CmdDelAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AccountsListOperation.DeleteAccount(ActiveAccountID);
                LoadAccountsList();
                LoadAccountListTreeView();
            }
            catch { }
        }

    }
}
