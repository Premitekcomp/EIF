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
    public partial class frmDomainCollectorAssign : Form
    {
        int CurrentrecordID = 0;
        public frmDomainCollectorAssign()
        {
            InitializeComponent();
        }

        private void frmDomainCollectorAssign_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadDefaultUI();
        }

        private void LoadCombo()
        {
            try
            {
                this.lup_BranchListTableAdapter.Fill(this.eIFCollector.Lup_BranchList);
                this.hR_Lup_BankListTableAdapter.Fill(this.eIFCollector.HR_Lup_BankList);
                this.col_Lup_MonthListTableAdapter.Fill(this.eIFCollector.Col_Lup_MonthList);

                this.LupTeamLeadersListTableAdapter.FillTeamLeaders(this.eIFCollector.LupTeamLeadersList);
                this.lupCollectorsListTableAdapter.FillCollectorsList(this.eIFCollector.LupCollectorsList);
                this.lupDTLListTableAdapter.FillDTL(this.eIFCollector.LupDTLList);
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
                    this.col_Lup_DomainSerialFilterdTableAdapter.FillByFilterdData(this.eIFCollector.Col_Lup_DomainSerialFilterd, Convert.ToInt16(txtMonth.SelectedValue), Convert.ToByte(txtBankBranch.SelectedValue), Convert.ToByte(txtBranchID.SelectedValue));
                    txtAvaliableIDs.SelectedIndex = -1;
                }
                catch { }
            }
        }

        private void txtAvaliableIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                lblDomainVersion.Text = "Current Domain Version: " + txtAvaliableIDs.SelectedValue.ToString();
            }
        }

        private void CmdLoadDomain_Click(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            try
            {
                this.col_DomainsDataBasicTableAdapter.FillByDomainandVersion(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                UpdateHeaderText();
            }
            catch { }
        }

        private void UpdateHeaderText()
        {
            int SchemaID = Convert.ToInt32(grvDomainData.Rows[0].Cells[4].Value.ToString());

            System.Data.DataTable SchemaDT = new System.Data.DataTable();
            SchemaDT = DomainOperations.GetSchemaExtendedInfo(SchemaID);

            int PointerX = 0;
            foreach (DataRow r in SchemaDT.Rows)
            {
                grvDomainData.Columns[PointerX + 11].HeaderText = r[3].ToString();
                PointerX++;
            }
        }

        private void CmdTLAssign_Click(object sender, EventArgs e)
        {
            if (grvDomainData.SelectedRows.Count == 0)
            {
                MessageBox.Show("You Must Select One Row at leaset");
                return;
            }
            if (txtTeamLeaderID.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Select a Teamleader");
                txtTeamLeaderID.Focus();
                return;
            }

            int TLID = Convert.ToInt32(txtTeamLeaderID.SelectedValue);
            foreach (DataGridViewRow grvSelectedRow in grvDomainData.SelectedRows)
            {
                int RecordDBID = Convert.ToInt32(grvDomainData.Rows[grvSelectedRow.Index].Cells[0].Value.ToString());
                try
                {
                    DomainOperations.AssignTeamLeader(RecordDBID, TLID);
                }
                catch { }
            }
            LoadGrid();
        }

        private void CmdDTLAssign_Click(object sender, EventArgs e)
        {
            if (grvDomainData.SelectedRows.Count == 0)
            {
                MessageBox.Show("You Must Select One Row at leaset");
                return;
            }
            if (txtDTLID.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Select a D.T.L");
                txtDTLID.Focus();
                return;
            }

            int DTLID = Convert.ToInt32(txtDTLID.SelectedValue);
            foreach (DataGridViewRow grvSelectedRow in grvDomainData.SelectedRows)
            {
                int RecordDBID = Convert.ToInt32(grvDomainData.Rows[grvSelectedRow.Index].Cells[0].Value.ToString());
                try
                {
                    DomainOperations.AssignDTL(RecordDBID, DTLID);
                }
                catch { }
            }
            LoadGrid();
        }

        private void CmdCollectorAssign_Click(object sender, EventArgs e)
        {
            if (grvDomainData.SelectedRows.Count == 0)
            {
                MessageBox.Show("You Must Select One Row at leaset");
                return;
            }
            if (txtCollectorID.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Select a Collector");
                txtCollectorID.Focus();
                return;
            }

            int CollectorID = Convert.ToInt32(txtCollectorID.SelectedValue);
            foreach (DataGridViewRow grvSelectedRow in grvDomainData.SelectedRows)
            {
                int RecordDBID = Convert.ToInt32(grvDomainData.Rows[grvSelectedRow.Index].Cells[0].Value.ToString());
                try
                {
                    DomainOperations.AssignCollector(RecordDBID, CollectorID);
                }
                catch { }
            }
            LoadGrid();
        }

        
    }
}
