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
    public partial class frmJournalEntryList : Form
    {
        int ActiveEntryID = 0;
        private frmEnhancedMDI ParentForm = null;
        byte WhichFilter = 0;

        public frmJournalEntryList()
        {
            InitializeComponent();
        }

        private void frmJournalEntryList_Load(object sender, EventArgs e)
        {

            try
            {
                this.a_Lup_JETypesTableAdapter.Fill(this.accounting.A_Lup_JETypes);
                txtEntryTypeID.SelectedIndex = -1;
            }
            catch { }
        }

        #region Buttons
        private void CmdShowAll_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void CmdFilterByNumbers_Click(object sender, EventArgs e)
        {
            if (txtStart.Text.Trim().Length != 0 && txtEnd.Text.Trim().Length != 0)
            {
                FilterByNumberRange(Convert.ToInt32(txtStart.Text), Convert.ToInt32(txtEnd.Text));
            }
            else
            {
                MessageBox.Show("يجب تحديد بداية و نهاية ارقام القيد المطلوبة");
            }
        }

        private void CmdFilterByDate_Click(object sender, EventArgs e)
        {
            if(IsAllType.Checked)
            {
                FilterByDateRange();
            }
            else
            {
                if(txtEntryTypeID.SelectedIndex != -1)
                {
                    FilterByTypeNDateRange();
                }
                else
                {
                    MessageBox.Show("يجب تحديد نوع القيد");
                }
            }
        }

        private void CmdApprove_Click(object sender, EventArgs e)
        {
            if (ActiveEntryID != 0)
            {
                JournalOperations.UpdateEntryApproveStatus(ActiveEntryID, true);
                ReFilter();
            }
            else
            {
                MessageBox.Show("يجب اختيار القيد اولا");
            }
        }

        private void CmdDisApprove_Click(object sender, EventArgs e)
        {
            if (ActiveEntryID != 0)
            {
                JournalOperations.UpdateEntryApproveStatus(ActiveEntryID, false);
                ReFilter();
            }
            else
            {
                MessageBox.Show("يجب اختيار القيد اولا");
            }

        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (ActiveEntryID != 0)
            {
                JournalOperations.UpdateEntryDeleteStatus(ActiveEntryID, true);
                ReFilter();
            }
            else
            {
                MessageBox.Show("يجب اختيار القيد اولا");
            }
        }

        private void CmdRestore_Click(object sender, EventArgs e)
        {
            if (ActiveEntryID != 0)
            {
                JournalOperations.UpdateEntryDeleteStatus(ActiveEntryID, false);
                ReFilter();
            }
            else
            {
                MessageBox.Show("يجب اختيار القيد اولا");
            }
        }

        private void CmdExport_Click(object sender, EventArgs e)
        {
            AppReports.AccountingRep.RepEntryBasicListXLSExport RepName = new AppReports.AccountingRep.RepEntryBasicListXLSExport();
            RepName.SetDataSource(this.accounting);

            AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            Openfrm.CRPreview.ReportSource = RepName;
            Openfrm.CRPreview.ExportReport();
        }

        private void CmdPrint_Click(object sender, EventArgs e)
        {
            AppReports.AccountingRep.RepEntryBasicList RepName = new AppReports.AccountingRep.RepEntryBasicList();
            RepName.SetDataSource(this.accounting);

            AppReports.AccountingRep.frmPreview Openfrm = new AppReports.AccountingRep.frmPreview();
            Openfrm.CRPreview.ReportSource = RepName;
            Openfrm.Show();
        }

        private void CmdApproveMulti_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) != null)
                {
                    if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) == true)
                    {
                        int SelectedEntryID = Convert.ToInt32(grvEntryList.Rows[grvRow.Index].Cells[0].Value);
                        JournalOperations.UpdateEntryApproveStatus(SelectedEntryID, true);
                    }
                }
            }
            ReFilter();
        }

        private void CmdDeApproveMulti_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) != null)
                {
                    if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) == true)
                    {
                        int SelectedEntryID = Convert.ToInt32(grvEntryList.Rows[grvRow.Index].Cells[0].Value);
                        JournalOperations.UpdateEntryApproveStatus(SelectedEntryID, false);
                    }
                }
            }
            ReFilter();
        }

        private void CmdCancelMulti_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) != null)
                {
                    if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) == true)
                    {
                        int SelectedEntryID = Convert.ToInt32(grvEntryList.Rows[grvRow.Index].Cells[0].Value);
                        JournalOperations.UpdateEntryDeleteStatus(SelectedEntryID, true);
                    }
                }
            }
            ReFilter();
        }

        private void CmdRestoreMulti_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) != null)
                {
                    if (Convert.ToBoolean(grvEntryList.Rows[grvRow.Index].Cells[2].Value) == true)
                    {
                        int SelectedEntryID = Convert.ToInt32(grvEntryList.Rows[grvRow.Index].Cells[0].Value);
                        JournalOperations.UpdateEntryDeleteStatus(SelectedEntryID, false);
                    }
                }
            }
            ReFilter();
        }

        private void CmdGetAllUnApproved_Click(object sender, EventArgs e)
        {
            FilterByApproveFlag(false);
        }

        private void CmdGetAllUnBalanced_Click(object sender, EventArgs e)
        {
            FilterByBalanceFlag(0);
        }

        private void CmdGetAllDeleted_Click(object sender, EventArgs e)
        {
            FilterByCancelFlag(true);
        }

        #endregion

        #region Filters Method
        private void LoadAll()
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.Fill(this.accounting.A_JournalBasicView);
                WhichFilter = 1;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByNumberRange(int StartRange, int EndRange)
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByEntryNumberRange(this.accounting.A_JournalBasicView, StartRange, EndRange);
                WhichFilter = 2;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByDateRange()
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByDateRange(this.accounting.A_JournalBasicView, dtStart.Value.ToString(), dtEnd.Value.ToString());
                WhichFilter = 3;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByTypeNDateRange()
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByTypeInDateRange(this.accounting.A_JournalBasicView, dtStart.Value.ToString(), dtEnd.Value.ToString(), Convert.ToInt32(txtEntryTypeID.SelectedValue));
                WhichFilter = 4;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByApproveFlag(bool PassedFlag)
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByApproveFlag(this.accounting.A_JournalBasicView, PassedFlag);
                WhichFilter = 5;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByCancelFlag(bool PassedFlag)
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByCancelFlag(this.accounting.A_JournalBasicView, PassedFlag);
                WhichFilter = 6;
                GetEntryGlobalBalance();
            }
            catch { }
        }

        private void FilterByBalanceFlag(int PassedFlag)
        {
            try
            {
                this.a_JournalBasicViewTableAdapter.FillByBalanceFlag(this.accounting.A_JournalBasicView, PassedFlag);
                WhichFilter = 7;
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
                OVDebitSum = OVDebitSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[7].Value.ToString());
                OVCreditSum = OVCreditSum + Convert.ToDecimal(grvEntryList.Rows[grvRow.Index].Cells[8].Value.ToString());

                if (grvEntryList.Rows[grvRow.Index].Cells[10].Value.ToString() != "متزن")
                {
                    grvRow.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            
            }

            lblOverAllCredit.Text = OVCreditSum.ToString();
            lblOverAllDepit.Text = OVDebitSum.ToString();
        }

        #endregion

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

        private void IsAllType_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAllType.Checked== true)
            {
                txtEntryTypeID.Visible = false;
            }
            else
            {
                txtEntryTypeID.Visible = true;
            }
        }

        private void grvEntryList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                ActiveEntryID = Convert.ToInt32(grvEntryList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void grvEntryList_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow grvRow in grvEntryList.Rows)
            {
                if (grvEntryList.Rows[grvRow.Index].Cells[2].Value == null || grvEntryList.Rows[grvRow.Index].Cells[2].Value.ToString() == "false")
                {
                    grvEntryList.Rows[grvRow.Index].Cells[2].Value = true;
                }
                else
                { grvEntryList.Rows[grvRow.Index].Cells[2].Value = false; }
            }
            
        }

        private void grvEntryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int EID = Convert.ToInt32(grvEntryList.Rows[e.RowIndex].Cells[0].Value.ToString());
               
                #region Select
                if (e.ColumnIndex == 2)
                {
                    if(Convert.ToBoolean(grvEntryList.Rows[e.RowIndex].Cells[2].Value) == null)
                    {
                        grvEntryList.Rows[e.RowIndex].Cells[2].Value=true;
                    }
                    else
                    { grvEntryList.Rows[e.RowIndex].Cells[2].Value = false; }
                }
                #endregion

                #region Edit
                if (e.ColumnIndex == 3)
                {
                    frmSimpleJournalEntry OpenForm = new frmSimpleJournalEntry(EID);
                    OpenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    OpenForm.MaximizeBox = false;
                    OpenForm.MinimizeBox = false;
                    OpenForm.ShowDialog();
                }
                #endregion

            }
        }

        private void ReFilter()
        {
            switch (WhichFilter)
            {
                case 1:
                    {
                        LoadAll();
                        break;
                    }
                case 2:
                    {
                        if (txtStart.Text.Trim().Length != 0 && txtEnd.Text.Trim().Length != 0)
                        {
                            FilterByNumberRange(Convert.ToInt32(txtStart.Text), Convert.ToInt32(txtEnd.Text));
                        }
                        break;
                    }
                case 3:
                    {
                        FilterByDateRange();
                        break;
                    }
                case 4:
                    {
                        FilterByTypeNDateRange();
                        break;
                    }
                case 5:
                    {
                        FilterByApproveFlag(false);
                        break;
                    }
                case 6:
                    {
                        FilterByCancelFlag(true);
                        break;
                    }
                case 7:
                    {
                        FilterByBalanceFlag(0);
                        break;
                    }
            }
        }

       

    }
}
