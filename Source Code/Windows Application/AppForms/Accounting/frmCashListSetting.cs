using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.Accounting;

namespace TMS.AppForms.Accounting
{
    public partial class frmCashListSetting : Form
    {
        int ActiveNode = 0;
        bool IsPositive = true;
        public frmCashListSetting()
        {
            InitializeComponent();
        }

        private void frmCashListSetting_Load(object sender, EventArgs e)
        {
            try
            {
                this.a_AccountsListTableAdapter.Fill(this.accounting.A_AccountsList);
                this.a_AccountsNumberListTableAdapter.Fill(this.accounting.A_AccountsNumberList);
            }
            catch { }
            treeView1.ExpandAll();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            label2.Text = node.FullPath.ToString();
            ActiveNode = Convert.ToInt32(node.Name);
            LoadFilterdGrid();
        }

        private void LoadFilterdGrid()
        {
            try
            {
                this.a_Config_CashViewTableAdapter.FillByNodeID(this.accounting.A_Config_CashView, Convert.ToByte(ActiveNode));
            }
            catch { }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if(ActiveNode != 0)
            {
                try
                {
                    AccountsListOperation.AddTermToEquation(ActiveNode, Convert.ToInt32(comboBox1.SelectedValue), IsPositive);
                    LoadFilterdGrid();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("لا يوجد عنصر مفعل");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == 1)
            {
                IsPositive = true;
            }

            if (comboBox3.SelectedIndex == 2)
            {
                IsPositive = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox1.SelectedValue = comboBox2.SelectedValue;
            }
        }
    }
}
