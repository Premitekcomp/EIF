using TMS.AppCode;
using TMS.AppCode.BLL;
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

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmPenalty : Form
    {
        public frmPenalty()
        {
            InitializeComponent();
        }
        
        public int SelectedID;
        public bool Updated = false;

        #region Methods
        private void GetMbox(int resalt)
        {
            if (resalt == 1)
            {
                RefreshGrid();
                lblMbox.Text = "تم الحفظ";
            }
            else
            {
                lblMbox.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
            }
        }

        public bool IsValed()
        {
            if (txtValue.Text.Trim().Length == 0 || txtValue.Text == "0")
            {
                lblMbox.Text = "يجب تحديد قيمة";
                txtValue.Focus();
                return false;
            }

            if (CbEmpID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار أسم الموظف";
                CbEmpID.Focus();
                return false;
            }

            if (cbPenaltyNameID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار البند";
                cbPenaltyNameID.Focus();
                return false;
            }
            if (DataValidation.EnsureTodayToPast(dtTra_Date.Value) == false)
            {
                lblMbox.Text = "يجب إختيار تاريخ سابق لتاريخ اليوم";
                dtTra_Date.Focus();
                return false;
            }
            if (dtTra_Date.Value == null)
            {
                lblMbox.Text = "يجب إختيار تاريخ صالح";
                dtTra_Date.Focus();
                return false;
            }
            if (chbByDay.Checked == false && chbByAmount.Checked == false)
            {
                lblMbox.Text = "يجب اختيار طريقة التعبير عن القيمة إما باليوم او كقيمة مطلقة";
                return false;
            }
            return true;
        }

        private void RefreshGrid()
        {
            try
            {
                this.grid_Tra_PenaltyTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Penalty, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmPenalty_Load(object sender, EventArgs e)
        {
            try
            {
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                this.hR_Lup_PenaltiesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Penalties);
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

                chbByDay.Parent = this.PictureBG;
                //chbByDay.ForeColor = Color.White;
                chbByDay.BackColor = Color.Transparent;

                chbByAmount.Parent = this.PictureBG;
                //chbByAmount.ForeColor = Color.White;
                chbByAmount.BackColor = Color.Transparent;

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


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Penalty.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue) , dtTra_Date.Value, Convert.ToInt32(cbPenaltyNameID.SelectedValue), chbByDay.Checked, chbByAmount.Checked, Convert.ToDecimal(txtValue.Text), txtNotes.Text);

                    // Get Transaction ID
                    int BounceTransactionID = HR_Tra_Penalty.GetMax();

                    // Update Employee Tra
                    DateTime ActualComeTime = Convert.ToDateTime(dtTra_Date.Value.ToShortDateString());
                    HR_Basics.UpdatePenality(Convert.ToInt32(CbEmpID.SelectedValue), ActualComeTime, BounceTransactionID);

                    GetMbox(mb);
                    BuildGUIEffects.ResetFormTextBoxes(this);

                    txtValue.Text = "0";
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
            else if (Updated == true)
            {

                int mb = HR_Tra_Penalty.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, Convert.ToInt32(cbPenaltyNameID.SelectedValue), chbByDay.Checked, chbByAmount.Checked, Convert.ToDecimal(txtValue.Text), txtNotes.Text);

                GetMbox(mb); 
                BuildGUIEffects.ResetFormTextBoxes(this);
               
                btnDelete.Visible = false;
                btnadd.Text = "اضافة";
                SelectedID = 0;
                Updated = false;
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (Updated == true)
            {
                BuildGUIEffects.ResetFormTextBoxes(this);
                txtValue.Text = "0";
                chbByDay.Checked = true;
                SelectedID = 0;
                Updated = false;
                CbEmpID.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedID != 0)
                {
                    int mb = HR_Tra_Penalty.UpdateDeleteFlagWithCheck(SelectedID);
                    GetMbox(mb);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
            }
            catch { }
        }

        private void grForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedID = int.Parse(grForm.Rows[e.RowIndex].Cells[0].Value.ToString());

                DataTable dt = new DataTable();
                dt = HR_Tra_Penalty.SelectByPK(SelectedID);

                CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
                dtTra_Date.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                cbPenaltyNameID.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());
                chbByDay.Checked = Convert.ToBoolean(dt.Rows[0][4].ToString());
                chbByAmount.Checked = Convert.ToBoolean(dt.Rows[0][5].ToString());
                txtValue.Text = dt.Rows[0][6].ToString();
                txtNotes.Text = dt.Rows[0][7].ToString();

                Updated = true;
                btnadd.Text = "تعديل";
                btnDelete.Visible = true;
                CbEmpID.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
