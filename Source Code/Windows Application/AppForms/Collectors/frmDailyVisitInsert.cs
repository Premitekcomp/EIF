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
    public partial class frmDailyVisitInsert : Form
    {
        int CurrentrecordID = 0;
        public frmDailyVisitInsert()
        {
            InitializeComponent();
        }

        private void frmDailyVisitInsert_Load(object sender, EventArgs e)
        {
            try
            {
                this.col_Lup_CommentListTableAdapter.Fill(this.eIFCollector.Col_Lup_CommentList);
            }
            catch
            {
                try
                {
                    this.col_Lup_CommentListTableAdapter.Fill(this.eIFCollector.Col_Lup_CommentList);
                }
                catch
                { }
            }
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
            if(txtAvaliableIDs.SelectedIndex != -1)
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
                    this.gridDomainFullDataTableAdapter.FillByIDandVersion(this.eIFCollector.GridDomainFullData, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));

                    //this.gridDomainFullDataTableAdapter.FillByIDandVersion(this.eIFCollector.GridDomainFullData, Convert.ToInt32(txtAvaliableIDs.Text), 1);
                    UpdateHeaderText();

                    this.col_DomainsDataBasicTableAdapter.FillByDomainandVersion(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                    this.lupFCustTableAdapter.FillByDomainInfo(this.eIFCollector.LupFCust, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                    this.lupAccountNoTableAdapter.FillByDomain(this.eIFCollector.LupAccountNo, Convert.ToInt32(txtAvaliableIDs.Text), Convert.ToByte(txtAvaliableIDs.SelectedValue));
                }
                catch { }
            }
        }

        private void UpdateHeaderText()
        {
            int SchemaID = Convert.ToInt32(grvFullDomain.Rows[0].Cells[4].Value.ToString());

            System.Data.DataTable SchemaDT = new System.Data.DataTable();
            SchemaDT = DomainOperations.GetSchemaExtendedInfo(SchemaID);

            int PointerX = 0;
            foreach (DataRow r in SchemaDT.Rows)
            {
                grvFullDomain.Columns[PointerX + 11].HeaderText = r[3].ToString();
                PointerX++;
            }
        }

        private void CmdSaveVisitInfo_Click(object sender, EventArgs e)
        {
            if (CurrentrecordID == 0)
            {
                MessageBox.Show("No Records from DCR are Selected, Please Click on the Record to Select it");
                return;
            }

            bool PTPPassedDate= false;
            if(PTPTypeTextBox.Text.Trim().Length != 0)
            {
                PTPPassedDate = true;
            }


            if (DomainOperations.DailyVisit_Insert(CurrentrecordID, Convert.ToInt32(txtActionTakerID.SelectedValue), dtConnectionDate.Value, ConnectionTypeTextBox.Text, ConnetctionResultTextBox.Text, PTPTypeTextBox.Text, dtPTPDate.Value, Convert.ToDecimal(PTPAmountTextBox.Text), KeptBrokenCheckBox.Checked, Convert.ToDecimal(KeptAmountTextBox.Text), TrialDetailsTextBox.Text, isBroken.Checked, PTPPassedDate) == 1)
            {
                MessageBox.Show("Visit Details Saved");

                CurrentrecordID = 0;
                //txtActionTakerID.SelectedIndex = -1;
                ConnectionTypeTextBox.Text = ""; 
                ConnetctionResultTextBox.Text= "";
                PTPTypeTextBox.Text = "";
                PTPAmountTextBox.Text = "0";
                KeptBrokenCheckBox.Checked = false;
                KeptAmountTextBox.Text = "0";
                TrialDetailsTextBox.Text = "";

                grvFullDomain.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error During Save");
            }
        }

        private void grvFullDomain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CurrentrecordID = Convert.ToInt32(grvFullDomain.Rows[e.RowIndex].Cells[8].Value.ToString());
                grvFullDomain.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                try
                {
                    this.col_DomainsDataBasicTableAdapter.FillByNameLike(this.eIFCollector.Col_DomainsDataBasic, txtFilterByName.Text);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Must Select Domain");
            }
        }

        private void txtFilterByFCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtFilterByFCust.SelectedIndex == -1)
            {
                return;
            }
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                try
                {
                    this.col_DomainsDataBasicTableAdapter.FillByRSerial(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(txtFilterByFCust.SelectedValue));
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Must Select Domain");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CurrentrecordID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dataGridView1.Rows[e.RowIndex].Selected = true;

                try
                {
                    this.gridDomainFullDataTableAdapter.FillByShortLineID(this.eIFCollector.GridDomainFullData, CurrentrecordID);
                   UpdateHeaderText();
                }
                catch { }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrialDetailsTextBox.Text = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                return;
            }
            if (txtAvaliableIDs.SelectedIndex != -1)
            {
                try
                {
                    this.col_DomainsDataBasicTableAdapter.FillByRSerial(this.eIFCollector.Col_DomainsDataBasic, Convert.ToInt32(comboBox2.SelectedValue));
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Must Select Domain");
            }
        }

        private void CmdSearchByPassport_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length != 0)
            {
                try
                {
                    this.col_DomainsDataBasicTableAdapter.FillByPassNo(this.eIFCollector.Col_DomainsDataBasic, textBox1.Text);
                }
                catch { }
            }
        }
    }
}
