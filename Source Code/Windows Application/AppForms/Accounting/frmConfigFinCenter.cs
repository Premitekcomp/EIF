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
    public partial class frmConfigFinCenter : Form
    {
        public frmConfigFinCenter()
        {
            InitializeComponent();
        }

        private void frmConfigFinCenter_Load(object sender, EventArgs e)
        {
            #region Call Account List from Level 2
            try
            {
                this.a_AccountsListTableAdapter.FillByAccountLevel(this.accounting.A_AccountsList, 2);
                txtAccountID.SelectedIndex = -1;
            }
            catch
            { }
            #endregion

            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                this.a_Config_FinancialCenterTableAdapter.Fill(this.accounting.A_Config_FinancialCenter);
            }
            catch { }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if(txtAccountID.SelectedIndex == -1 || txtAccountType.SelectedIndex == -1)
            {
                MessageBox.Show("يجب اكمال كافه البيانات");
                return;
            }

            if (JEAutomation.InsertItemInFinCenter(Convert.ToInt32(txtAccountType.SelectedIndex), Convert.ToInt32(txtAccountID.SelectedValue)) == 1)
            {
                LoadGrid();
                txtAccountID.SelectedIndex = -1;
            }
        }

        private void grvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int SID = Convert.ToInt32(grvList.Rows[e.RowIndex].Cells[0].Value.ToString());

                if(e.ColumnIndex == 3)
                {
                    DialogResult GetConfirmation = MessageBox.Show("هل تريد التأكيد علي حذف الحساب من قائمة الدخل", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.Yes)
                    {
                        try
                        {
                            JEAutomation.DeleteItemFromFinCenter(SID);
                            LoadGrid();
                        }
                        catch { }
                    }
                }
            }
        }
    }
}
