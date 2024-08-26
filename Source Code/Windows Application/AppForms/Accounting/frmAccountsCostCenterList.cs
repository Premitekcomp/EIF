using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.Accounting;

namespace TMS.AppForms.Accounting
{
    public partial class frmAccountsCostCenterList : Form
    {
        int ActiveCostCenterAccountID = 0;

        int ActiveLevel = 0;
        int ParentID = 0;

        public frmAccountsCostCenterList()
        {
            InitializeComponent();
        }

        private void frmAccountList_Load(object sender, EventArgs e)
        {
            LoadCostCentersAccountListTreeView();
            LoadAccountListTreeView();
            
            txtCCenterTitle.SelectedIndex = -1;
        }

        #region Cost Centers Accounts TreeView
        private void LoadCostCentersAccountListTreeView()
        {
            CostCentersListTreeView.Nodes.Clear();

            DataTable CCListTreeDT = new DataTable();
            CCListTreeDT = AccountsListOperation.GetCostCentersListByLevel(1);

            foreach (DataRow DRow in CCListTreeDT.Rows)
            {
                TreeNode L1Node = new TreeNode();
                L1Node.Name = DRow["CostCenterAccountID"].ToString();
                L1Node.Text = DRow["CostCenterNumber"].ToString() + " " + DRow["CostCenterName"].ToString();
                L1Node.ForeColor = Color.Green;

                #region Level 2
                if (AccountsListOperation.GetCCLevelDownCountNextSerial(Convert.ToInt32(DRow["CostCenterAccountID"].ToString())) - 1 > 0)
                {
                    DataTable CCTreeL2DT = new DataTable();
                    CCTreeL2DT = AccountsListOperation.GetCCByParentID(Convert.ToInt32(DRow["CostCenterAccountID"].ToString()));

                    foreach (DataRow DRowL2 in CCTreeL2DT.Rows)
                    {
                        TreeNode L2Node = new TreeNode();
                        L2Node.Name = DRowL2["CostCenterAccountID"].ToString();
                        L2Node.Text = DRowL2["CostCenterNumber"].ToString() + " " + DRowL2["CostCenterName"].ToString();
                        L1Node.Nodes.Add(L2Node);

                        #region Level 3
                        if (AccountsListOperation.GetCCLevelDownCountNextSerial(Convert.ToInt32(DRowL2["CostCenterAccountID"].ToString())) - 1 > 0)
                        {
                            DataTable CCTreeL3DT = new DataTable();
                            CCTreeL3DT = AccountsListOperation.GetCCByParentID(Convert.ToInt32(DRowL2["CostCenterAccountID"].ToString()));
                            foreach (DataRow DRowL3 in CCTreeL3DT.Rows)
                            {
                                TreeNode L3Node = new TreeNode();
                                L3Node.Name = DRowL3["CostCenterAccountID"].ToString();
                                L3Node.Text = DRowL3["CostCenterNumber"].ToString() + " " + DRowL3["CostCenterName"].ToString();
                                L2Node.Nodes.Add(L3Node);

                                #region Level 4
                                if (AccountsListOperation.GetCCLevelDownCountNextSerial(Convert.ToInt32(DRowL3["CostCenterAccountID"].ToString())) - 1 > 0)
                                {
                                    DataTable CCTreeL4DT = new DataTable();
                                    CCTreeL4DT = AccountsListOperation.GetCCByParentID(Convert.ToInt32(DRowL3["CostCenterAccountID"].ToString()));
                                    foreach (DataRow DRowL4 in CCTreeL4DT.Rows)
                                    {
                                        TreeNode L4Node = new TreeNode();
                                        L4Node.Name = DRowL4["CostCenterAccountID"].ToString();
                                        L4Node.Text = DRowL4["CostCenterNumber"].ToString() + " " + DRowL4["CostCenterName"].ToString();
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

                CostCentersListTreeView.Nodes.Add(L1Node);
            }

            CostCentersListTreeView.ExpandAll();
            LoadCostCentersList();
        }

        private void SubAccountsListTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = CostCentersListTreeView.SelectedNode;
            LoadSelectSubAccountInfo(Convert.ToInt32(node.Name));
            lblAccountPath.Text = node.FullPath.ToString();
        }

        private void LoadSelectSubAccountInfo(int AccountID)
        {
            DataTable CCsTreeDT = new DataTable();
            CCsTreeDT = AccountsListOperation.GetCCByID(AccountID);

            foreach (DataRow DRow in CCsTreeDT.Rows)
            {
                ActiveCostCenterAccountID = Convert.ToInt32(DRow["CostCenterAccountID"].ToString());
                lblAccountNumber.Text = DRow["CostCenterNumber"].ToString();
                txtCCenterTitle.Text = DRow["CostCenterName"].ToString();
                ActiveLevel = Convert.ToInt32(DRow["LevelID"].ToString());
            }

            LoadLinkedAccounts();
        }

        private void LoadLinkedAccounts()
        {
            try
            {
                this.a_CCentersJoinDetailsTableAdapter.FillByCCAccountID(this.accounting.A_CCentersJoinDetails, Convert.ToInt16(ActiveCostCenterAccountID));
            }
            catch { }
        }

        private void CmdAddSub_Click(object sender, EventArgs e)
        {
            string NewCCNumber = lblAccountNumber.Text + AccountsListOperation.GetCCLevelDownCountNextSerial(ActiveCostCenterAccountID).ToString();
            lblAccountNumber.Text = NewCCNumber;
            txtCCenterTitle.Text = "";
            ParentID = ActiveCostCenterAccountID;
            ActiveCostCenterAccountID = 0;
            ActiveLevel = ActiveLevel + 1;
        }

        private void CmdDoAction_Click(object sender, EventArgs e)
        {

            if (txtCCenterTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("يجب تحديد اسم مركز التكلفه");
                return;
            }
            if (ActiveCostCenterAccountID == 0)
            {
                #region Insert
                ActiveCostCenterAccountID = AccountsListOperation.CreateNewCCenter(Convert.ToInt32(lblAccountNumber.Text), txtCCenterTitle.Text, ParentID, ActiveLevel);
                if (ActiveCostCenterAccountID > 0)
                {
                    LoadCostCentersAccountListTreeView();
                    MakeTheJoin();
                    LoadLinkedAccounts();
                    txtCCenterTitle.SelectedValue = ActiveCostCenterAccountID;
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه الحفظ");
                }
                #endregion
            }
            else
            {
                if (AccountsListOperation.UpdateCCAccountInfo(ActiveCostCenterAccountID, txtCCenterTitle.Text) == 1)
                {
                    LoadCostCentersAccountListTreeView();
                    MakeTheJoin();
                    LoadLinkedAccounts();
                    txtCCenterTitle.SelectedValue = ActiveCostCenterAccountID;
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه التحديث");
                }
            }

        }

        private void MakeTheJoin()
        {
            TreeNodeCollection nodes = AccountListTreeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                LoopInAllNodes(n);
            }
        }

        private void LoopInAllNodes(TreeNode TNode)
        {
            foreach (TreeNode tn in TNode.Nodes)
            {
                LoopInAllNodes(tn);
                if (tn.Checked == true)
                {
                    AccountsListOperation.MakeCCJoin(ActiveCostCenterAccountID, Convert.ToInt32(tn.Name), 0);
                    tn.Checked = false;
                }
            }
        }
        #endregion

        private void LoadCostCentersList()
        {
            try
            {
                this.a_AccountsCostCenterListTableAdapter.Fill(this.accounting.A_AccountsCostCenterList);
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
            //TreeNode node = AccountListTreeView.SelectedNode;
            //LoadSelectAccountInfo(Convert.ToInt32(node.Name));
            //lblAccountPath.Text = node.FullPath.ToString();
        }

        private void LoadSelectAccountInfo(int AccountID)
        {
            //DataTable AccountsTreeDT = new DataTable();
            //AccountsTreeDT = AccountsListOperation.GetAccountByID(AccountID);

            //foreach (DataRow DRow in AccountsTreeDT.Rows)
            //{
            //    ActiveAccountID = Convert.ToInt32(DRow["AccountID"].ToString());
            //    lblAccountNumber.Text = DRow["AccountNumber"].ToString();
            //    txtCCenterTitle.Text = DRow["AccountName"].ToString();
            //    ActiveLevel = Convert.ToInt32(DRow["LevelID"].ToString());
            //    ActiveAccountType = Convert.ToInt32(DRow["AccountTypeID"].ToString());
            //}
        }

        #endregion

        
        private void CmdReLoad_Click(object sender, EventArgs e)
        {
            LoadAccountListTreeView();
            LoadCostCentersAccountListTreeView();
        }

        private void grvLinkedAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int LinkID = Convert.ToInt32(grvLinkedAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
                decimal Weight = Convert.ToDecimal(grvLinkedAccounts.Rows[e.RowIndex].Cells[2].Value.ToString());

                if (e.ColumnIndex == 3)
                {
                    AccountsListOperation.UpdateCCWeight(LinkID, Weight);
                    LoadLinkedAccounts();
                }

                if(e.ColumnIndex==4)
                {
                    DialogResult GetConfirmation = MessageBox.Show("ستقوم بفك الارتباط بين الحساب و مركز التكلفه, هل تريد الاستمرار", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.Yes)
                    {
                        AccountsListOperation.BreakCCJoin(LinkID);
                        LoadLinkedAccounts();
                    }
                }
            }
        }

    }
}
