using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.Accounting
{
    public partial class frmASTBasicInfo : Form
    {
        private AppForms.frmEnhancedMDI ParentForm = null;

        public frmASTBasicInfo(Form callingForm)
        {
            InitializeComponent();
            ParentForm = callingForm as AppForms.frmEnhancedMDI; 
        }

        private void frmASTBasicInfo_Load(object sender, EventArgs e)
        {
            ShowAll();
            try
            {
                this.aST_GroupsTableAdapter.Fill(this.accounting.AST_Groups);
            }
            catch { }
        }

        private void CmdShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            try
            {
                this.aST_BasicInfoViewTableAdapter.Fill(this.accounting.AST_BasicInfoView);
            }
            catch { }
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            frmASTCRUD OpenForm = new frmASTCRUD(0);
            OpenForm.ShowDialog();
            ShowAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int RID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                if(e.ColumnIndex == 2)
                {
                    frmASTCRUD OpenForm = new frmASTCRUD(RID);
                    OpenForm.ShowDialog();
                }
            }
        }

        private void txtNameLike_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.aST_BasicInfoViewTableAdapter.FillByNameLike(this.accounting.AST_BasicInfoView, txtNameLike.Text);
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.aST_BasicInfoViewTableAdapter.FillByLocationLike(this.accounting.AST_BasicInfoView, txtLocation.Text);
            }
            catch { }
        }

        private void txtASTGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtASTGroup.SelectedIndex != -1)
            {
                try
                {
                    this.aST_BasicInfoViewTableAdapter.FillByGroupID(this.accounting.AST_BasicInfoView, Convert.ToInt16(txtASTGroup.SelectedValue));
                }
                catch { }
            }
        }

    }
}
