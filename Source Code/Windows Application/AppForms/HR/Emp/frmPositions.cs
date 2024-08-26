using TMS.AppCode;
using TMS.AppCode.DAL.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppForms.HR.Emp
{
    public partial class frmPositions : Form
    {
        public frmPositions()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variables
        /// </summary>
        /// <param name="resalt"></param>
        public int SelectedID;
        public bool Updated = false;

        private void frmPositions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.hR_Lup_PositionsTableAdapter.FillAll(this.lupDataSet.HR_Lup_Positions);
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
            }
            catch { }
            MakeCommonGUITaska(this, PictureBG);
        }

        private void MakeCommonGUITaska(Form PassedFormName, Control PassedParent)
        {
            try
            {
                GlobalEvents.GLobalGUIEvents(PassedFormName, PassedParent);
                foreach (TextBox TBox in this.Controls.OfType<TextBox>().ToArray())
                {
                    TBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
                foreach (ComboBox CBox in this.Controls.OfType<ComboBox>().ToArray())
                {
                    CBox.KeyDown += new KeyEventHandler(ControlKeyDown);
                }
                IsCurrent.Parent = this.PictureBG;
                //IsCurrent.ForeColor = Color.White;
                IsCurrent.BackColor = Color.Transparent;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        private void ControlKeyDown(System.Object Sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                BuildGUIEffects.FormNavigation(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }

        }


        private void RefreshGrid()
        {
            try
            {
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.grid_EmpPositionTableAdapter.FillByEmpID(this.empDataSet.Grid_EmpPosition, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEmpID.SelectedIndex != -1)
            {
                txtEmpID.SelectedValue = CbEmpID.SelectedValue;
            }
            RefreshGrid();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {
                    int mb = HR_Emp_Positions.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtPositionID.SelectedValue), dtFromDate.Value, dtEndDate.Value, txtNotes.Text);
                    GetMbox(mb);
                    RefreshGrid();
                    TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                }
            }
            if (Updated == true)
            {
                int mb = HR_Emp_Positions.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtPositionID.SelectedValue), dtFromDate.Value, dtEndDate.Value, txtNotes.Text);
                GetMbox(mb);
                RefreshGrid();
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                btnSaveNew.Text = "حفظ / جديد";
                Updated = false;
                btnDelete.Visible = false;
                btnSaveClose.Enabled = true;
            }

        }


        private DataTable GetIsCurrent()
        {
            DataTable dt = new DataTable();
            try
            {                
                dt=  HR_Emp_Positions.SelectByEmpIDIsCurrent(Convert.ToInt32( CbEmpID.SelectedValue));
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
            
        }

        public bool IsValed()
        {
            if (CbEmpID.Text == "")
            {
                lblMbox.Text = "يجب اختيار اسم الموظف";
                CbEmpID.Focus();
                return false;

            }
            if (txtPositionID.Text == "")
            {
                lblMbox.Text = "يجب اختيار اسم اللقب الوظيفى";
                CbEmpID.Focus();
                return false;
            }
            if (txtPositionID.Text == "")
            {
                lblMbox.Text = "يجب اختيار اسم اللقب الوظيفى";
                CbEmpID.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }        

        private void GetMbox(int resalt)
        {
            if (resalt == 1)
            {
                lblMbox.Text = "تم الحفظ";
            }
            else
            {
                lblMbox.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (IsValed())
            {
                int mb = HR_Emp_Positions.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtPositionID.SelectedValue), dtFromDate.Value, dtEndDate.Value, txtNotes.Text);
                GetMbox(mb);
                RefreshGrid();
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                this.Close();
            }
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = HR_Emp_Positions.SelectByPK(SelectedID);
            CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
            txtPositionID.SelectedValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            dtFromDate.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            dtEndDate.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
            txtNotes.Text = dt.Rows[0][5].ToString();
            
            btnSaveNew.Text = "تعديل";
            Updated = true;
            btnDelete.Visible = true;
            btnSaveClose.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int mb = HR_Emp_Positions.UpdateDeleteFlagWithCheck(SelectedID);
            GetMbox(mb);
            RefreshGrid();
            TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
            btnSaveNew.Text = "حفظ / جديد";
            Updated = false;
            btnDelete.Visible = false;
            btnSaveClose.Enabled = true;
        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex != -1)
            {
                CbEmpID.SelectedValue = txtEmpID.SelectedValue;
            }
        }
    }
}
