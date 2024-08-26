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
using TMS.AppCode.DAL;
using TMS.AppCode;
using TMS.AppCode.BLL;

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmBonus : Form
    {
        public frmBonus()
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

            if (cbBonusID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار البند";
                cbBonusID.Focus();
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
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.grid_Tra_BonusTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Bonus, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmBonus_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_BonusTableAdapter.FillAll(this.lupDataSet.HR_Lup_Bonus);
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


        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (Updated == true)
            {
                //ValidationClass.ClearControls(this);
                BuildGUIEffects.ResetFormTextBoxes(this);
                txtValue.Text = "0";
                chbByDay.Checked = true;
                SelectedID = 0;
                Updated = false;
            }
            else
            {
                this.Close();
            }
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());

                DataTable dt = new DataTable();
                dt = HR_Tra_Bonus.SelectByPK(SelectedID);

                CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
                dtTra_Date.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                cbBonusID.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                if (SelectedID != 0)
                {
                    int mb = HR_Tra_Bonus.UpdateDeleteFlagWithCheck(SelectedID);
                    GetMbox(mb);
                    // ValidationClass.ClearControls(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
            }
            catch
            { }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Bonus.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, Convert.ToInt32(cbBonusID.SelectedValue), chbByDay.Checked, chbByAmount.Checked, Convert.ToDecimal(txtValue.Text), txtNotes.Text);
                    
                    // Get Transaction ID
                    int BounceTransactionID = HR_Tra_Bonus.GetMax();

                    // Update Employee Tra
                    DateTime ActualComeTime = Convert.ToDateTime(dtTra_Date.Value.ToShortDateString());
                    HR_Basics.UpdateBounce(Convert.ToInt32(CbEmpID.SelectedValue), ActualComeTime, BounceTransactionID);

                    // ValidationClass.ClearControlsWithoutComboBox(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                    GetMbox(mb);
                    txtValue.Text = "0";
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
            else if (Updated == true)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Bonus.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, Convert.ToInt32(cbBonusID.SelectedValue), chbByDay.Checked, chbByAmount.Checked, Convert.ToDecimal(txtValue.Text), txtNotes.Text);
                    // ValidationClass.ClearControlsWithoutComboBox(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                    GetMbox(mb);
                    btnDelete.Visible = false;
                    btnadd.Text = "اضافة";
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
