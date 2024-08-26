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
    public partial class frmUpdateDomainTeam : Form
    {
        public frmUpdateDomainTeam()
        {
            InitializeComponent();
        }

        private void frmUpdateDomainTeam_Load(object sender, EventArgs e)
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

        private void CmdUpdateVersion_Click(object sender, EventArgs e)
        {
            int MostVersion = Convert.ToInt32(txtAvaliableIDs.SelectedValue);
            int DomainID = Convert.ToInt32(txtAvaliableIDs.Text);

            // Get The Domain Version 1
            DataTable DomainInfo = new DataTable();
            DomainInfo = DomainOperations.GetV1DomainTeamInfo(DomainID, 1);

            int TeamLeader = 0;
            int DTL = 0;
            int CollectorName = 0;
            string AccountNo = "";

            // Loop with each record
            foreach (DataRow r in DomainInfo.Rows)
            {
                // Update the Most Recent Domain, Match with Account ID
                TeamLeader = Convert.ToInt32(r["TeamLeader"].ToString());
                DTL = Convert.ToInt32(r["SuperVisor"].ToString());
                CollectorName = Convert.ToInt32(r["CollectorName"].ToString());
                AccountNo = r["AccountNo"].ToString();

                try
                {
                    DomainOperations.UpdateTeam(DomainID, MostVersion, AccountNo, TeamLeader, DTL, CollectorName);
                }
                catch { }
            }

            MessageBox.Show("Update Compleated !");
        }
    }
}
