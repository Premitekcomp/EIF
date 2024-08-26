using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.Collectors
{
    public partial class frmDomainMatchRecords : Form
    {
        public frmDomainMatchRecords()
        {
            InitializeComponent();
        }

        private void frmDomainMatchRecords_Load(object sender, EventArgs e)
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
                int MajorVersion = Convert.ToInt32(txtAvaliableIDs.SelectedValue);
                lblMajor.Text = "Major Version: " + MajorVersion.ToString();
                lblMinor.Text = "Minor Version: " + Convert.ToString(MajorVersion - 1);
                LoadData();
            }
        }

        private void LoadData()
        {
            // Minor
            try
            {
                int MinorVersion = Convert.ToInt32(txtAvaliableIDs.SelectedValue) - 1;
                this.gridDomainMinorVersionTableAdapter.FillByIDandVersion(this.eIFCollector.GridDomainMinorVersion, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(MinorVersion));
            }
            catch { }

            // Major
            try
            {
                this.gridDomainMajorVersionTableAdapter.FillByIDandMajorVersion(this.eIFCollector.GridDomainMajorVersion, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
            }
            catch { }
        }

        private void CmdCompareRecords_Click(object sender, EventArgs e)
        {
            // From Minor to Major
            foreach (DataGridViewRow MinorRow in grvMinor.Rows)
            {
                string MinorAccountNo = grvMinor.Rows[MinorRow.Index].Cells[2].Value.ToString();

                foreach (DataGridViewRow MajorRow in grvMajor.Rows)
                {
                    string MajorAccountNo = grvMajor.Rows[MajorRow.Index].Cells[2].Value.ToString();
                    grvMinor.Rows[MinorRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                    if (string.Compare(MinorAccountNo,MajorAccountNo, true) == 0)
                    {
                        grvMinor.Rows[MinorRow.Index].DefaultCellStyle.BackColor = Color.White;
                        break;
                    }
                }
            }

            // From Major to Minor
            foreach (DataGridViewRow MajorRowRound2 in grvMajor.Rows)
            {
                string MajorAccountNo2 = grvMajor.Rows[MajorRowRound2.Index].Cells[2].Value.ToString();

                foreach (DataGridViewRow MinorRow2 in grvMinor.Rows)
                {
                    string MinorAccountNo2 = grvMinor.Rows[MinorRow2.Index].Cells[2].Value.ToString();
                    grvMajor.Rows[MajorRowRound2.Index].DefaultCellStyle.BackColor = Color.LightGray;
                    if (string.Compare(MajorAccountNo2, MinorAccountNo2, true) == 0)
                    {
                        grvMajor.Rows[MajorRowRound2.Index].DefaultCellStyle.BackColor = Color.White;
                        break;
                    }
                }
            }
        }
    }
}
