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
    public partial class frmCreateTeam : Form
    {
        public frmCreateTeam()
        {
            InitializeComponent();
        }

        private void frmCreateTeam_Load(object sender, EventArgs e)
        {
            RefreshTeamGridandCombo();
            LoadCombo();
            LoadDefaultUI();
        }

        private void LoadDefaultUI()
        {
            txtTeamID.SelectedIndex = -1;
            txtMemberID.SelectedIndex = -1;
            txtRoleID.SelectedIndex = -1;

        }
        private void LoadCombo()
        {
            try
            {
                this.hR_Emp_BasicInfoTableAdapter.Fill(this.eIFCollector.HR_Emp_BasicInfo);
                this.col_lup_TeamRoleTableAdapter.Fill(this.eIFCollector.Col_lup_TeamRole);
            }
            catch { }
        }

        private void RefreshTeamGridandCombo()
        {
            try
            {
                this.col_Grid_TeamListTableAdapter.Fill(this.eIFCollector.Col_Grid_TeamList);
                this.col_Lup_TeamListTableAdapter.Fill(this.eIFCollector.Col_Lup_TeamList);
            }
            catch { }
        }

        private void LoadFilterdMembersGrid()
        {
            try
            {
                if(txtTeamID.SelectedIndex != -1)
                {
                    this.col_Lup_TeamMembersTableAdapter.FillByTeamID(this.eIFCollector.Col_Lup_TeamMembers, Convert.ToInt32(txtTeamID.SelectedValue));
                }
            }
            catch { }
        }

        private void txtTeamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilterdMembersGrid();
        }

        private void CmdRefreshTeams_Click(object sender, EventArgs e)
        {
            RefreshTeamGridandCombo();
        }

        private void CmdSaveTeams_Click(object sender, EventArgs e)
        {
            if(txtTeamName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must Have a Team Name");
                txtTeamName.Focus();
                return;
            }

            CollectorsConfig.InsertNewTeam(txtTeamName.Text);
            RefreshTeamGridandCombo();
        }

        private void grvTeamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int TeamID = Convert.ToInt32(grvTeamList.Rows[e.RowIndex].Cells[0].Value.ToString());
                string NewTeamName = grvTeamList.Rows[e.RowIndex].Cells[1].Value.ToString();
                if(e.ColumnIndex == 2)
                {
                    CollectorsConfig.UpdateTeamName(TeamID, NewTeamName);
                    RefreshTeamGridandCombo();
                }
            }
        }

        private void CmdAddtoTeam_Click(object sender, EventArgs e)
        {
            if(txtTeamID.SelectedIndex != -1 && txtRoleID.SelectedIndex!= -1 && txtMemberID.SelectedIndex != -1)
            {
                try
                {
                    DomainOperations.InsertTeamMember(Convert.ToInt32(txtTeamID.SelectedValue), Convert.ToInt32(txtMemberID.SelectedValue), Convert.ToInt32(txtRoleID.SelectedValue));
                    LoadFilterdMembersGrid();
                }
                catch{}
            }
        }

        private void grvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(grvMembers.Rows[e.RowIndex].Cells[0].Value.ToString());

                if(e.ColumnIndex==1)
                {
                    try
                    {
                        DomainOperations.DeleteTeamMember(RID);
                        LoadFilterdMembersGrid();
                    }
                    catch{}
                }
            }
        }
        
    }
}
