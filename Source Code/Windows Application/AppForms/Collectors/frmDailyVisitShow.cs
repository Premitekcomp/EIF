using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.CollectionDept;

namespace TMS.AppForms.Collectors
{
    public partial class frmDailyVisitShow : Form
    {
        public frmDailyVisitShow()
        {
            InitializeComponent();
        }

        private void frmDailyVisitShow_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadDefaultUI();
        }

        private void LoadCombo()
        {
            try
            {
                this.lup_BranchListTableAdapter.Fill(this.eIFCollector1.Lup_BranchList);
                this.hR_Lup_BankListTableAdapter.Fill(this.eIFCollector1.HR_Lup_BankList);
                this.col_Lup_MonthListTableAdapter.Fill(this.eIFCollector1.Col_Lup_MonthList);
            }
            catch { }
        }

        private void LoadDefaultUI()
        {
            txtBankBranch.SelectedIndex = -1;
            txtBranchID.SelectedIndex = -1;
            txtMonth.SelectedIndex = -1;

        }

        private void CmdGetDomainIDs_Click(object sender, EventArgs e)
        {
            if (txtBankBranch.SelectedIndex != -1 && txtBranchID.SelectedIndex != -1 && txtMonth.SelectedIndex != -1)
            {
                try
                {
                    this.col_Lup_DomainSerialFilterdTableAdapter.FillByFilterdData(this.eIFCollector1.Col_Lup_DomainSerialFilterd, Convert.ToInt16(txtMonth.SelectedValue), Convert.ToByte(txtBankBranch.SelectedValue), Convert.ToByte(txtBranchID.SelectedValue));
                    txtAvaliableIDs.SelectedIndex = -1;
                }
                catch { }
            }
        }

        private void CmdLoadDomain_Click(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                LoadGridandStstics();
            }
        }

        private void LoadGridandStstics()
        {
            try
            {
                int ActivatedDomainID = Convert.ToInt32(txtAvaliableIDs.Text);
                DateTime StartFilterDate = Convert.ToDateTime(dtStartDate.Value.ToShortDateString());
                DateTime EndFilterDate = Convert.ToDateTime(dtEndDate.Value.ToShortDateString());

                this.gridDailyVisitFullTableAdapter.FillByDomainInDate(this.eIFCollector.GridDailyVisitFull, ActivatedDomainID, StartFilterDate.ToString(), EndFilterDate.ToString());

                #region Load Statstics
                listView1.Items.Clear();

                ListViewItem ClientsCount = new ListViewItem();
                ClientsCount.Text = "Client No.";
                ClientsCount.SubItems.Add(dataGridView1.RowCount.ToString());
                listView1.Items.Add(ClientsCount);

                ListViewItem RecordCount = new ListViewItem();
                RecordCount.Text = "Record No.";
                RecordCount.SubItems.Add(dataGridView1.RowCount.ToString());
                listView1.Items.Add(RecordCount);

                #region Connection Type
                // Head
                ListViewItem vtitemhead = new ListViewItem();
                vtitemhead.Text = "Connection Info";
                listView1.Items.Add(vtitemhead);

                // Info
                DataTable ContactTypedt = new DataTable();
                ContactTypedt = DCRReporting.VisitTypeStstics(ActivatedDomainID, StartFilterDate, EndFilterDate);

                foreach (DataRow r in ContactTypedt.Rows)
                {
                    ListViewItem itemInfo = new ListViewItem { Name = r["ConnectionType"].ToString(), Text = r["ConnectionType"].ToString() };
                    itemInfo.SubItems.Add(r["Count"].ToString());
                    listView1.Items.Add(itemInfo);
                }

                listView1.Items.Add("");
                #endregion

                #region PTP Info
                // Head
                ListViewItem PTPItemHead = new ListViewItem();
                PTPItemHead.Text = "PTP Info";
                listView1.Items.Add(PTPItemHead);

                // Info
                DataTable PTPdt = new DataTable();
                PTPdt = DCRReporting.PTPStstics(ActivatedDomainID, StartFilterDate, EndFilterDate);

                foreach (DataRow r in PTPdt.Rows)
                {
                    if (r["PTPType"].ToString().Trim().Length == 0)
                    {
                        ListViewItem NullItem = new ListViewItem();
                        NullItem.SubItems.Add(r["PTPTypeCount"].ToString());
                        listView1.Items.Add("No PTP");
                    }
                    else
                    {
                        ListViewItem itemInfo = new ListViewItem { Name = r["PTPType"].ToString(), Text = r["PTPType"].ToString() };
                        itemInfo.SubItems.Add(r["PTPTypeCount"].ToString());
                        listView1.Items.Add(itemInfo);
                    }

                }

                listView1.Items.Add("");
                #endregion

                #region Money Info
                // Head
                ListViewItem MoneyInfoHead = new ListViewItem();
                MoneyInfoHead.Text = "Money Info";
                listView1.Items.Add(MoneyInfoHead);

                // Info
                DataTable Moneydt = new DataTable();
                Moneydt = DCRReporting.CollectionStstics(ActivatedDomainID, StartFilterDate, EndFilterDate);

                foreach (DataRow r in Moneydt.Rows)
                {
                    ListViewItem PTPSum = new ListViewItem();
                    PTPSum.Text = "PTP SUM";
                    PTPSum.SubItems.Add(r["PTPSUM"].ToString());
                    listView1.Items.Add(PTPSum);

                    ListViewItem PTPKept = new ListViewItem();
                    PTPKept.Text = "Kept SUM";
                    PTPKept.SubItems.Add(r["KeptSum"].ToString());
                    listView1.Items.Add(PTPKept);

                    ListViewItem KeptCount = new ListViewItem();
                    KeptCount.Text = "Kept Count";
                    KeptCount.SubItems.Add(r["KeptNo"].ToString());
                    listView1.Items.Add(KeptCount);

                    ListViewItem BrokenCount = new ListViewItem();
                    BrokenCount.Text = "Broken Count";
                    BrokenCount.SubItems.Add(r["BrokenNo"].ToString());
                    listView1.Items.Add(BrokenCount);
                }
                #endregion
                #endregion
            }
            catch { }
        }

        private void txtAvaliableIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                lblDomainVersion.Text = "Current Domain Version: " + txtAvaliableIDs.SelectedValue.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                if(e.ColumnIndex == 3)
                {
                    DialogResult GetConfirmation = MessageBox.Show("You gonna Delete this Entry, Are You Sure You Wanna Procced?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(GetConfirmation == DialogResult.Yes)
                    {
                        if(DCRReporting.DeleteDCRRecord(RID) == 1)
                        {
                            MessageBox.Show("Done !");
                            LoadGridandStstics();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong, System Couldn't Procced with Record Deleting Process");
                        }
                    }
                }
            }
        }

        private void CmdXLSExport_Click(object sender, EventArgs e)
        {
            RepExportDCRDaily RepName = new RepExportDCRDaily();
            RepName.SetDataSource(this.eIFCollector);

            //AppReports.Inv.frmInvRepPreview OpenForm = new AppReports.Inv.frmInvRepPreview();
            //OpenForm.crystalReportViewer1.ReportSource = RepName;
            //OpenForm.crystalReportViewer1.ExportReport();
        }
    }
}
