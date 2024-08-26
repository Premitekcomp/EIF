using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.DAL.HR;

namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    public partial class frmEmplumentGroupMembers : Form
    {
        int DBRecordSerial = 0;
        public frmEmplumentGroupMembers()
        {
            InitializeComponent();
        }

        private void frmEmplumentGroupMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            LoadCombo();
            txtEmplyeeID.SelectedIndex = -1;
        }

        private void LoadCombo()
        {
            try
            {
                this.combo_NameListTableAdapter.Fill(this.empDataSet.Combo_NameList);
                this.hR_Lup_EmplymentGroupTableAdapter.Fill(this.empDataSet.HR_Lup_EmplymentGroup);
            }
            catch
            { }
        }

        private void LoadFilterdGrid(string SelectedGroup)
        {
            if (DBRecordSerial == 0)
            {
                try
                {
                    this.grid_GroupMembersTableAdapter.FillBy(this.empDataSet.Grid_GroupMembers, ((byte)(System.Convert.ChangeType(SelectedGroup, typeof(byte)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void txtGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGroupID.SelectedIndex != -1)
            {
                LoadFilterdGrid(txtGroupID.SelectedValue.ToString());
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtEmplyeeID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب تحديد الموظف";
                return;
            }

            if (txtGroupID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب تحديد المجموعه";
                return;
            }
            #endregion

            if (DBRecordSerial == 0)
            {
                if (HR_Lup_EmplymentGroup.InsertMember(Convert.ToInt32(txtGroupID.SelectedValue), Convert.ToInt32(txtEmplyeeID.SelectedValue)) == 1)
                {
                    lblMsg.Text = "تم اضافه الموظف للمجموعه";
                    LoadFilterdGrid(txtGroupID.SelectedValue.ToString());
                    txtEmplyeeID.SelectedIndex = -1;
                }
                else
                {
                    lblMsg.Text = "حظث خطأ اثناء عمليه الاضافه";
                }
            }
            else
            {
                if (HR_Lup_EmplymentGroup.UpdateMember(Convert.ToInt32(txtGroupID.SelectedValue), Convert.ToInt32(txtEmplyeeID.SelectedValue), DBRecordSerial) == 1)
                {
                    lblMsg.Text = "تم التحديث بنجاحه";
                    DBRecordSerial = 0;
                    LoadFilterdGrid(txtGroupID.SelectedValue.ToString());
                    txtEmplyeeID.SelectedIndex = -1;
                }
                else
                {
                    lblMsg.Text = "حظث خطأ اثناء عمليه التحديث";
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DBRecordSerial = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                txtEmplyeeID.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                txtGroupID.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            }
        }

        private void CmdCancelUpdate_Click(object sender, EventArgs e)
        {
            DBRecordSerial = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                txtEmplyeeID.SelectedValue = comboBox1.SelectedValue;
            }
        }
    }
}
