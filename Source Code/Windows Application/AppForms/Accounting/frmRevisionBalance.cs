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
    public partial class frmRevisionBalance : Form
    {
        private frmEnhancedMDI ParentForm = null;

        public frmRevisionBalance()
        {
            InitializeComponent();
        }

        private void frmJournalEntryList_Load(object sender, EventArgs e)
        {
           
        }


        private void GetEntryGlobalBalance()
        {
            int AccountType = 0;
            decimal AccountBalance = 0;

            #region Calaculate
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                AccountType = Convert.ToInt16(grvEntryList.Rows[grvRow.Index].Cells[1].Value.ToString());
                AccountBalance = Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[7].Value.ToString());

                if(AccountType == 1 || AccountType == 4)
                {
                    if(AccountBalance >0)
                    {
                        grvEntryList.Rows[grvRow.Index].Cells[8].Value = AccountBalance.ToString();
                        grvEntryList.Rows[grvRow.Index].Cells[9].Value = "0";
                    }
                    else
                    {
                        grvEntryList.Rows[grvRow.Index].Cells[8].Value = "0";
                        grvEntryList.Rows[grvRow.Index].Cells[9].Value = (AccountBalance * -1).ToString();
                    }
                }
                else
                {
                    if (AccountBalance > 0)
                    {
                        grvEntryList.Rows[grvRow.Index].Cells[8].Value = "0";
                        grvEntryList.Rows[grvRow.Index].Cells[9].Value = AccountBalance.ToString();
                    }
                    else
                    {
                        grvEntryList.Rows[grvRow.Index].Cells[8].Value = (AccountBalance * -1).ToString();
                        grvEntryList.Rows[grvRow.Index].Cells[9].Value = "0";
                    }
                }

            }
            #endregion

            #region Summition
            decimal DepitS = 0;
            decimal CreditS = 0;

            decimal DepitBalance = 0;
            decimal CreditBalance = 0;

            decimal PrevDebit = 0;
            decimal PrevCredit = 0;

            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {

                DepitS = DepitS + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[5].Value.ToString());
                CreditS = CreditS + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[6].Value.ToString());
                DepitBalance = DepitBalance + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[8].Value.ToString());
                CreditBalance = CreditBalance + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[9].Value.ToString());

                PrevDebit = PrevDebit + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[3].Value.ToString());
                PrevCredit = PrevCredit + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[4].Value.ToString());
            }

            lblOverAllDepit.Text = DepitS.ToString();
            lblOverAllCredit.Text = CreditS.ToString();
            lblDeptBalanceSum.Text = DepitBalance.ToString();
            lblCreditBalanceSum.Text = CreditBalance.ToString();

            lblPrevDebitSum.Text = PrevDebit.ToString();
            lblPrevCreditSum.Text = PrevCredit.ToString();
            #endregion

        }

        private void CmdFilterTopLevel_Click(object sender, EventArgs e)
        {
            try
            {
                this.a_RevisionBalanceTableAdapter.Fill(this.accounting.A_RevisionBalance, dtStart.Value.ToString(), dtEndRange.Value.ToString());
                GetEntryGlobalBalance();

            }
            catch { }
        }

    }
}
