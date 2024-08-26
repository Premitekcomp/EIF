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
    public partial class frmASTCRUD : Form
    {
        bool UpdateMood = false;
        int ActiveASTID = 0;

        public frmASTCRUD(int ASTID)
        {
            InitializeComponent();
            ActiveASTID = ASTID;
        }

        private void frmASTCRUD_Load(object sender, EventArgs e)
        {
            LoadCombos();
            if(ActiveASTID != 0)
            {
                LoadASTInfo();
                UpdateMood = true;
            }
        }

        private void LoadASTInfo()
        {
            DataTable ASTInfoDT = new DataTable();
            ASTInfoDT = AssessitOperation.GetASTInfo(ActiveASTID);

            foreach(DataRow Dr in ASTInfoDT.Rows)
            {
                txtASTSerial.Text = Dr["AssetSerialNumber"].ToString();
                txtASTName.Text = Dr["AssetTitle"].ToString();
                txtASTLocation.Text = Dr["ASTLocation"].ToString();
                txtNote.Text = Dr["Notes"].ToString();
                txtBuyCost.Text = Dr["CapitalCost"].ToString();
                txtDepCost.Text = Dr["StartDepsCurrentValue"].ToString();
                txtSellScrabCost.Text = Dr["ScrapValue"].ToString();
                txtDepPercentage.Text = Dr["DepreciationPercentage"].ToString();

                txtBranchID.SelectedValue = Convert.ToInt32(Dr["BranchID"].ToString());
                txtStatusID.SelectedValue = Convert.ToInt32(Dr["AssetStateID"].ToString());
                txtASTGroupID.SelectedValue = Convert.ToInt32(Dr["ASTGroupID"].ToString());

                dtBuyDate.Value = Convert.ToDateTime(Dr["BuyDate"].ToString());
                dtStartDep.Value = Convert.ToDateTime(Dr["StartDepreciationDate"].ToString());

                if (Dr["ScrapDate"].ToString().Trim().Length == 0)
                {
                    CmdScrape.Visible = true;
                }
                else
                {
                    dtScrapDate.Value = Convert.ToDateTime(Dr["ScrapDate"].ToString());
                    CmdScrape.Visible = false;
                    CmdSell.Visible = false;

                    lblScrabDate.Visible = true;
                    dtScrapDate.Visible = true;

                    lblScrabValue.Visible = true;
                    txtSellScrabCost.Visible = true;
                }

                if (Dr["SalesDate"].ToString().Trim().Length == 0)
                {
                    CmdSell.Visible = true;
                }
                else
                {
                    dtSellDate.Value = Convert.ToDateTime(Dr["SalesDate"].ToString());
                    CmdScrape.Visible = false;
                    CmdSell.Visible = false;

                    lblSellDate.Visible = true;
                    dtSellDate.Visible = true;

                    lblScrabValue.Visible = true;
                    txtSellScrabCost.Visible = true;
                }

                

            }
        }

        private void LoadCombos()
        {
            try
            {
                this.aST_GroupsTableAdapter.Fill(this.accounting.AST_Groups);
                txtASTGroupID.SelectedIndex = -1;

                this.aST_Lup_AssetsStateTableAdapter.Fill(this.accounting.AST_Lup_AssetsState);
                txtStatusID.SelectedIndex = -1;

                this.lup_BranchListTableAdapter.Fill(this.lupComboFill.Lup_BranchList);
                if (txtBranchID.Items.Count == 1)
                {
                    txtBranchID.SelectedIndex = 0;
                }
                else
                {
                    txtBranchID.SelectedIndex = -1;
                }
            }
            catch { }
        }

        private void LoadInitialUI()
        {
            lblScrabDate.Visible = false;
            lblSellDate.Visible = false;
            lblScrabValue.Visible = false;
            lblSerialError.Visible = false;
            dtScrapDate.Visible = false;
            dtSellDate.Visible = false;
        }

        private void CmdAddGroup_Click(object sender, EventArgs e)
        {
            frmASTGroups OpenForms = new frmASTGroups();
            OpenForms.FormBorderStyle = FormBorderStyle.FixedSingle;
            OpenForms.ShowDialog();
        }

        private void CmdRefreshGroups_Click(object sender, EventArgs e)
        {
            try
            {
                this.aST_GroupsTableAdapter.Fill(this.accounting.AST_Groups);
                txtASTGroupID.SelectedIndex = -1;
            }
            catch { }
        }

        private void txtASTSerial_Leave(object sender, EventArgs e)
        {
            if (UpdateMood == false)
            {
                if (AssessitOperation.CheckASTSerial(txtASTSerial.Text) != 0)
                {
                    lblSerialError.Visible = true;
                }
                else
                {
                    lblSerialError.Visible = false;
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

        #region Validation
        private bool ValidateInputs()
        {
            if(txtASTSerial.Text.Trim().Length ==0)
            {
                lblMSG.Text = "يجب ادخال مسلسل الاصل";
                txtASTSerial.Focus();
                return false;
            }

            if(UpdateMood == false)
            {
                if(AssessitOperation.CheckASTSerial(txtASTSerial.Text) != 0)
                {
                    lblSerialError.Visible = true;
                    return false;
                }
            }
            if (txtASTName.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب ادخال اسم الاصل";
                txtASTName.Focus();
                return false;
            }

            if (txtStatusID.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب ادخال حالة الإهلاك الحالية ";
                txtStatusID.Focus();
                return false;
            }

            if (txtBranchID.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب ادخال الفرع ";
                txtBranchID.Focus();
                return false;
            }

            if (txtASTGroupID.SelectedIndex == -1)
            {
                lblMSG.Text = "يجب ادخال المجموعه ";
                txtASTGroupID.Focus();
                return false;
            }

            #region Text Default Values
            if (txtBuyCost.Text.Trim().Length == 0)
            {
                txtBuyCost.Text = "0";
            }
            if (txtDepCost.Text.Trim().Length == 0)
            {
                txtDepCost.Text = "0";
            }
            if (txtDepPercentage.Text.Trim().Length == 0)
            {
                txtDepPercentage.Text = "0";
            }
            if (txtDepPercentage.Text.Trim().Length == 0)
            {
                txtDepPercentage.Text = "0";
            }
            if (txtSellScrabCost.Text.Trim().Length == 0)
            {
                txtSellScrabCost.Text = "0";
            }
            #endregion

            return true;
        }
        #endregion

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if(UpdateMood == false)
            {
                SaveAST();
                if (ActiveASTID != 0)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه الحفظ");
                }
            }
            else
            {
                UpdateAST();
                MessageBox.Show("تم التحديث بنجاح");
                this.Hide();

            }
        }

        private void SaveAST()
        {
            try
            {
                if (ValidateInputs() == false)
                {
                    return;
                }

                ActiveASTID = AssessitOperation.RegisterNewAST(Convert.ToInt32(txtStatusID.SelectedValue), txtASTSerial.Text, txtASTName.Text, dtBuyDate.Value, Convert.ToDecimal(txtBuyCost.Text), dtStartDep.Value, Convert.ToDecimal(txtDepCost.Text), Convert.ToDecimal(txtDepPercentage.Text), Convert.ToInt32(txtASTGroupID.SelectedValue), txtASTLocation.Text, txtNote.Text, Convert.ToInt32(txtBranchID.SelectedValue));
            }
            catch { }
        }

        private void UpdateAST()
        {
            try
            {
                if (ValidateInputs() == false)
                {
                    return;
                }
                AssessitOperation.UodateASTInformation(Convert.ToInt32(txtStatusID.SelectedValue), txtASTSerial.Text, txtASTName.Text, dtBuyDate.Value, Convert.ToDecimal(txtBuyCost.Text), dtStartDep.Value, Convert.ToDecimal(txtDepCost.Text), Convert.ToDecimal(txtDepPercentage.Text), Convert.ToInt32(txtASTGroupID.SelectedValue), txtASTLocation.Text, txtNote.Text, Convert.ToInt32(txtBranchID.SelectedValue), ActiveASTID);
            }
            catch { }
        }

        private void CmdSell_Click(object sender, EventArgs e)
        {
            lblSellDate.Visible = true;
            dtSellDate.Visible = true;

            lblScrabDate.Visible = false;
            dtScrapDate.Visible = false;

            lblScrabValue.Visible = true;
            txtSellScrabCost.Visible = true;
        }

        private void CmdScrape_Click(object sender, EventArgs e)
        {
            lblScrabDate.Visible = true;
            dtScrapDate.Visible = true;

            lblSellDate.Visible = false;
            dtSellDate.Visible = false;

            lblScrabValue.Visible = true;
            txtSellScrabCost.Visible = true;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmdSaveNew_Click(object sender, EventArgs e)
        {
            if (UpdateMood == false)
            {
                SaveAST();
                if (ActiveASTID != 0)
                {
                    ResetInputs();
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                else
                {
                    MessageBox.Show("خطأ اثناء عمليه الحفظ");
                }
            }
            else
            {
                UpdateAST();
                MessageBox.Show("تم التحديث بنجاح");
            }
        }

        private void ResetInputs()
        {
            txtASTSerial.Text = "";
            txtASTName.Text = "";
            txtASTLocation.Text = "";
            txtNote.Text = "";

            txtBuyCost.Text = "0";
            txtDepCost.Text = "0";
            txtSellScrabCost.Text = "0";
            txtDepPercentage.Text = "0";
            txtASTSerial.Focus();
        }
        


    }
}
