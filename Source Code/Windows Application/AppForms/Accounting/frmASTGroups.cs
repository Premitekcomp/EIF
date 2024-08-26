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
    public partial class frmASTGroups : Form
    {
        public frmASTGroups()
        {
            InitializeComponent();
        }

        private void frmASTGroups_Load(object sender, EventArgs e)
        {
            LoadFullGrid();
        }

        private void LoadFullGrid()
        {
            try
            {
                this.aST_GroupsTableAdapter.Fill(this.accounting.AST_Groups);
            }
            catch { }
        }

        private void grvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(grvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                string GTitle = grvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal GDValue = Convert.ToDecimal(grvList.Rows[e.RowIndex].Cells[2].Value.ToString());

                if(e.ColumnIndex == 3)
                {
                    try
                    {
                        AssessitOperation.UpdateASTGroups(GTitle, GDValue, RID);
                        LoadFullGrid();
                    }
                    catch { } 
                }

                if(e.ColumnIndex ==4)
                {
                    DialogResult GetConfirmation = MessageBox.Show("ستقوم بحذف هذه المجموعه, و فك الارتباط بكل الاصول داخلها", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.Yes)
                    {
                        try
                    {
                        AssessitOperation.DeleteASTGroups(RID);
                        LoadFullGrid();
                    }
                    catch { } 
                    }
                    
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            #region Validation
            if(txtASTGroupTitle.Text.Trim().Length == 0)
            {
                lblMSG.Text = "يجب ادخال اسم المجموعة";
                return;
            }
            #endregion

            if (AssessitOperation.CreateNewASTGroups(txtASTGroupTitle.Text, Convert.ToDecimal(txtGroupDepreciationPercentage.Text)) == 1)
            {
                LoadFullGrid();
                txtGroupDepreciationPercentage.Text = "0";
                txtASTGroupTitle.Text = "";
                txtASTGroupTitle.Focus();
            }
            else
            {
                lblMSG.Text = "خطأ اثناء عملية الحفظ";
                return;
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
    }
}
