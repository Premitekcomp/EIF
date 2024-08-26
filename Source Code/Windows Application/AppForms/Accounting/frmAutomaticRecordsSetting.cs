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
    public partial class frmAutomaticRecordsSetting : Form
    {
        int ActiveFormID = 0;
        public frmAutomaticRecordsSetting()
        {
            InitializeComponent();
        }

        private void frmAutomaticRecordsSetting_Load(object sender, EventArgs e)
        {
            LoadComboList();
            LoadFormsList();
            LoadFormListCombo();
        }

        #region Combo and List
        private void LoadComboList()
        {
            try
            {
                this.a_AccountsListTableAdapter.Fill(this.accounting.A_AccountsList);
                txtAccountList.SelectedIndex = -1;
            }
            catch { }
        }

        private void LoadFormsList()
        {
            FormListTV.Nodes.Clear();

            DataTable FormsTreeDT = new DataTable();
            FormsTreeDT = JEAutomation.GetFormsGroupList();

            foreach (DataRow DRow in FormsTreeDT.Rows)
            {
                TreeNode L1Node = new TreeNode();
                L1Node.Name = DRow["FormGrouID"].ToString();
                L1Node.Text = DRow["FormGroupTitle"].ToString();
                L1Node.ForeColor = Color.Green;

                #region Level 2
                DataTable GroupFormListDT = new DataTable();
                GroupFormListDT = JEAutomation.GetFormsByGroupID(Convert.ToInt32(DRow["FormGrouID"].ToString()));

                foreach (DataRow DRowL2 in GroupFormListDT.Rows)
                {
                    TreeNode L2Node = new TreeNode();
                    L2Node.Name = DRowL2["FormID"].ToString();
                    L2Node.Text = DRowL2["FormFriendlyTitle"].ToString();
                    L1Node.Nodes.Add(L2Node);
                }
                #endregion

                FormListTV.Nodes.Add(L1Node);
            }

        }

        private void LoadFormListCombo()
        {
            try
            {
                this.automationFormListTableAdapter.Fill(this.accountingSub.AutomationFormList);
                txtFormListID.SelectedIndex = -1;
            }
            catch { }
        }

        private void RefreshUponActiveFormChange()
        {
            try
            {
                this.a_Auto_Config_FormFieldsTableAdapter.FillByFormID(this.accountingSub.A_Auto_Config_FormFields, Convert.ToInt16(ActiveFormID));
                this.a_Auto_Config_FormFields1TableAdapter.FillByFormID(this.accountingSub.A_Auto_Config_FormFields1, Convert.ToInt16(ActiveFormID));
                txtFieldIDforSubAccount.SelectedIndex = -1;
                txtFieldIDforMasterAccount.SelectedIndex = -1;
                LoadGrid();
            }
            catch { }
        }

        private void LoadGrid()
        {
            if (txtActionID.SelectedIndex != -1)
            {
                this.a_Auto_EnginCoreViewTableAdapter.FillByFormID(this.accountingSub.A_Auto_EnginCoreView, Convert.ToInt16(ActiveFormID), Convert.ToInt16(txtActionID.SelectedValue));
            }
        }
        #endregion
        
        #region UI
        private void FormListTV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = FormListTV.SelectedNode;
            ActiveFormID = (Convert.ToInt32(node.Name));
            lblFormName.Text = node.Text;

            try
            {
                this.a_Auto_Config_FormActionsTableAdapter.FillByFormID(this.accountingSub.A_Auto_Config_FormActions, Convert.ToInt16(ActiveFormID));
            }
            catch { }
            RefreshUponActiveFormChange();
        }

        private void RMasterFromTree_CheckedChanged(object sender, EventArgs e)
        {
            if(RMasterFromForm.Checked==true)
            {
                txtAccountList.Visible = true;
                txtFieldIDforMasterAccount.Visible = false;
            }
        }

        private void RMasterFromForm_CheckedChanged(object sender, EventArgs e)
        {
            if (RMasterFromForm.Checked == true)
            {
                txtAccountList.Visible = false;
                txtFieldIDforMasterAccount.Visible = true;
            }
        }

        private void RWithNoSub_CheckedChanged(object sender, EventArgs e)
        {
            if (RWithNoSub.Checked == true)
            {
                txtSubAccountList.Visible = false;
                txtFieldIDforSubAccount.Visible = false;
            }
        }

        private void RSubFromTree_CheckedChanged(object sender, EventArgs e)
        {
            if (RSubFromTree.Checked == true)
            {
                txtSubAccountList.Visible = true;
                txtFieldIDforSubAccount.Visible = false;
            }
        }

        private void RSubFromForm_CheckedChanged(object sender, EventArgs e)
        {
            if (RSubFromForm.Checked == true)
            {
                txtSubAccountList.Visible = false;
                txtFieldIDforSubAccount.Visible = true;
            }
        }

        private void txtAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAccountList.SelectedIndex != -1)
            {
                try
                {
                    this.a_SubAccountsListTableAdapter.FillByMastrAccountID(this.accounting.A_SubAccountsList, Convert.ToInt16(txtAccountList.SelectedValue), Convert.ToInt16(txtAccountList.SelectedValue));
                }
                catch { }
            }
        }
        #endregion

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            #region Insert Fields Mapping
            
            bool IsDebit = true;
            if(RDepit.Checked == true)
            { IsDebit = true; } else { IsDebit = false; }

            bool AccountFromTree = true;
            if (RMasterFromTree.Checked == true)
            { AccountFromTree = true; }
            else { AccountFromTree = false; }

            bool NoSubAccount = false;
            bool SubAccountFromTree = false;
            if (RWithNoSub.Checked == true)
            {
                NoSubAccount = true;
            }
            else
            {
                NoSubAccount = false;

                if (RSubFromTree.Checked == true)
                { SubAccountFromTree = true; }
                else { SubAccountFromTree = false; }
            }
           
            int AccountID=0;
            if(txtAccountList.Visible == true)
            {
                AccountID = Convert.ToInt32(txtAccountList.SelectedValue);
            }

            int SubAccountID = 0;
            if (txtSubAccountList.Visible == true)
            {
                SubAccountID = Convert.ToInt32(txtSubAccountList.SelectedValue);
            }

            int AccountFieldID = 0;
            if (txtFieldIDforMasterAccount.Visible == true)
            {
                AccountFieldID = Convert.ToInt32(txtFieldIDforMasterAccount.SelectedValue);
            }

            int SubFieldID = 0;
            if (txtFieldIDforSubAccount.Visible == true)
            {
                SubFieldID = Convert.ToInt32(txtFieldIDforSubAccount.SelectedValue);
            }
            #endregion

            if (JEAutomation.InsertInEngineCore(IsDebit, AccountFromTree, AccountID, AccountFieldID, NoSubAccount, SubAccountFromTree, SubAccountID, SubFieldID, ActiveFormID, Convert.ToInt32(txtActionID.SelectedValue)) == 1)
            {
                LoadGrid();
                txtAccountList.SelectedIndex = -1;
                txtSubAccountList.SelectedIndex = -1;
                txtFieldIDforMasterAccount.SelectedIndex = -1;
                txtFieldIDforSubAccount.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("خطأ اثناء عمليه الحفظ");
            }
        }

        private void txtActionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtActionID.SelectedIndex != -1)
            {
                LoadGrid();
            }
        }

        private void grvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(grvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                if(e.ColumnIndex == 5)
                {
                    DialogResult GetConfirmation = MessageBox.Show("عند قيامك بحذف إعدادت القيد سيؤثر ذلك علي القيود المولده تلقائيا من هذا الاجراء, هل تريد الاستمرار", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.Yes)
                    {
                        JEAutomation.DeleteInEngineCore(RID);
                        LoadGrid();
                    }
                }
            }
        }

        
    }
}
