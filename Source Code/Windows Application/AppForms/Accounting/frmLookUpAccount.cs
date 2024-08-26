using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.Accounting
{
    public partial class frmLookUpAccount : Form
    {
        public frmLookUpAccount()
        {
            InitializeComponent();
        }

        private void frmLookUpAccount_Load(object sender, EventArgs e)
        {
            txtByAccountName.Focus();
        }

        private void GetList()
        {
            try
            {
                this.a_LookupAccountsListTableAdapter.FillByNameForJournal(this.accounting.A_LookupAccountsList, txtByAccountName.Text);
            }
            catch { }
        }

        private void txtByAccountName_TextChanged(object sender, EventArgs e)
        {
            if(txtByAccountName.Text.Trim().Length != 0)
            {
                GetList();
            }
        }

        private void CmdCanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtByAccountName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                grvAccountList.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (grvAccountList.RowCount == 1)
                {
                    AppCode.GlobalParamters.ScanAccountingID = Convert.ToInt32(grvAccountList.Rows[0].Cells[0].Value.ToString());
                    this.Hide();
                }
            }
        }

        private void grvAccountList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grvAccountList.SelectedCells.Count > 0)
                {
                    int RowIndex = grvAccountList.CurrentRow.Index;
                    DataGridViewRow selectedRow = grvAccountList.Rows[RowIndex];
                    AppCode.GlobalParamters.ScanAccountingID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    this.Hide();
                }
                else
                {
                    AppCode.GlobalParamters.ScanAccountingID = Convert.ToInt32(grvAccountList.Rows[0].Cells[0].Value.ToString());
                    this.Hide();
                }
            }
        }

        private void grvAccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AppCode.GlobalParamters.ScanAccountingID = Convert.ToInt32(grvAccountList.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Hide();

            }
        }
    }
}
