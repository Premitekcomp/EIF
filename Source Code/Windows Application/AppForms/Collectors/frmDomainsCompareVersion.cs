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
    public partial class frmDomainsCompareVersion : Form
    {
        public frmDomainsCompareVersion()
        {
            InitializeComponent();
        }

        private void frmDomainsCompareVersion_Load(object sender, EventArgs e)
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
                this.col_Lup_TeamMembersTableAdapter.Fill(this.eIFCollector.Col_Lup_TeamMembers);
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
                try
                {
                    //this.gridDomainFullDataTableAdapter.FillByDomainIDOnly(this.eIFCollector.GridDomainFullData, Convert.ToInt32(txtAvaliableIDs.Text));
                    //UpdateHeaderText();

                    this.col_DomainsDataBasicTableAdapter.FillByDomainID(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(txtAvaliableIDs.Text));

                    this.gridCompareDomainSummaryTableAdapter.FillByDomainID(this.eIFCollector.GridCompareDomainSummary, Convert.ToInt32(txtAvaliableIDs.Text));
                    this.gridCompareDomainGBBucketTableAdapter.FillByDomainID(this.eIFCollector.GridCompareDomainGBBucket, Convert.ToInt32(txtAvaliableIDs.Text));
                }
                catch { }
            }
        }

        private void UpdateHeaderText()
        {
            int SchemaID = Convert.ToInt32(grvFullDomain.Rows[0].Cells[4].Value.ToString());

            System.Data.DataTable SchemaDT = new System.Data.DataTable();
            SchemaDT = DomainOperations.GetSchemaExtendedInfo(SchemaID);

            int PointerX = 0; // +12 as Col1 Index
            foreach (DataRow r in SchemaDT.Rows)
            {
                grvFullDomain.Columns[PointerX + 12].HeaderText = r[3].ToString();
                PointerX++;
            }
        }
    }
}
