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
    public partial class frmMasterBook : Form
    {
        private frmEnhancedMDI ParentForm = null;

        public frmMasterBook()
        {
            InitializeComponent();
        }

        private void frmJournalEntryList_Load(object sender, EventArgs e)
        {
           
        }


        #region Buttons
        private void CmdExport_Click(object sender, EventArgs e)
        {
            //AppReports.AccountingRep.RepEntryBasicListXLSExport RepName = new AppReports.AccountingRep.RepEntryBasicListXLSExport();
            //RepName.SetDataSource(this.accounting);

            //AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            //Openfrm.CRPreview.ReportSource = RepName;
            //Openfrm.CRPreview.ExportReport();
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            //AppReports.AccountingRep.RepEntryBasicList RepName = new AppReports.AccountingRep.RepEntryBasicList();
            //RepName.SetDataSource(this.accounting);

            //AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            //Openfrm.CRPreview.ReportSource = RepName;
            //Openfrm.Show();
        }
        #endregion

        #region Filters Method

        private void CmdFilterByDate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable MBTLAccDT = new DataTable();
                MBTLAccDT = JournalOperations.GetMasterBookTLAccounts(dtStart.Value, dtEnd.Value);

                grvEntryList.AutoGenerateColumns = true;
                grvEntryList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                grvEntryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                grvEntryList.DataSource = MBTLAccDT;
                grvEntryList.Refresh();
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void CmdFilterAnalyticLevel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable MBTLAccDT = new DataTable();
                MBTLAccDT = JournalOperations.GetMasterBookSubAccounts(dtStart.Value, dtEnd.Value);

                grvEntryList.AutoGenerateColumns = true;
                grvEntryList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                grvEntryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                grvEntryList.DataSource = MBTLAccDT;
                grvEntryList.Refresh();
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void GetEntryGlobalBalance()
        {
            decimal OVCreditSum = 0;
            decimal OVDebitSum = 0;
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                OVDebitSum = OVDebitSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[1].Value.ToString());
                OVCreditSum = OVCreditSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[2].Value.ToString());
            }

            lblOverAllCredit.Text = OVCreditSum.ToString();
            lblOverAllDepit.Text = OVDebitSum.ToString();
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
                //int EID = Convert.ToInt32(grvEntryList.Rows[e.RowIndex].Cells[0].Value.ToString());

                //frmSimpleJournalEntry OpenForm = new frmSimpleJournalEntry(EID);
                //OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                //OpenForm.MaximizeBox = false;
                //OpenForm.MinimizeBox = false;
                //OpenForm.ShowDialog();
            }
        }

        

      
    }
}
