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

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmAllowances : Form
    {
        public frmAllowances()
        {
            InitializeComponent();
        }

        public int SelectedID;
        public bool Updated = false;

        #region Methods
        private void GetMbox(int Result)
        {
            if (Result == 1)
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
            if (txtDupplicationTime.Text.Trim().Length == 0)
            {
                txtDupplicationTime.Text = "0";
            }

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

            if (cbAllowanceID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار البند";
                cbAllowanceID.Focus();
                return false;
            }
            if (DataValidation.EnsureTodayToPast(dtTra_Date.Value) == false)
            {
                lblMbox.Text = "يجب إختيار تاريخ سابق لتاريخ اليوم";
                dtTra_Date.Focus();
                return false;
            }
            if(dtTra_Date.Value == null)
            {
                lblMbox.Text = "يجب إختيار تاريخ صالح";
                dtTra_Date.Focus();
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
                    this.grid_Tra_AllowancesTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Allowances, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void frmAllowances_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_AllowancesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Allowances);
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
            }
            catch {}            
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
                chbIsPercent.Parent = this.PictureBG;
                //chbIsPercent.ForeColor = Color.White;
                chbIsPercent.BackColor = Color.Transparent;

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


        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ValidateNonDecimal(object sender, KeyPressEventArgs e)
        {
            if (DataValidation.CheckNonDecimalNumber(e) == 1)
            {
                e.Handled = true;
            }
        }

        private void MultiInsert(int LoopingTime)
        {
            DateTime OrginalDate = dtTra_Date.Value;
            
            
            for (int i = 0; i < LoopingTime; i++)
            {
                TimeSpan ByYear = new TimeSpan(30 * i, 0, 0, 0);
                DateTime AccumaltedDate = OrginalDate + ByYear;
                int mb = HR_Tra_Allowances.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), AccumaltedDate, Convert.ToInt32(cbAllowanceID.SelectedValue), Convert.ToDecimal(txtValue.Text), chbIsPercent.Checked, txtNotes.Text);
                GetMbox(mb);
            }
            
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {
                    if (Convert.ToInt32(txtDupplicationTime.Text) > 1)
                    {
                        MultiInsert(Convert.ToInt32(txtDupplicationTime.Text));
                    }
                    else
                    {
                        int mb = HR_Tra_Allowances.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, Convert.ToInt32(cbAllowanceID.SelectedValue), Convert.ToDecimal(txtValue.Text), chbIsPercent.Checked, txtNotes.Text);
                        GetMbox(mb);
                    }
                    BuildGUIEffects.ResetFormTextBoxes(this);
                    txtValue.Text = "0";
                    txtDupplicationTime.Text = "0";
                    SelectedID = 0;
                    CbEmpID.Focus();
                    Updated = false;
                }
            }
            else if (Updated == true)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Allowances.UpdateRecord(SelectedID ,Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value, Convert.ToInt32(cbAllowanceID.SelectedValue), Convert.ToDecimal(txtValue.Text), chbIsPercent.Checked, txtNotes.Text);
                    // ValidationClass.ClearControlsWithoutComboBox(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                    GetMbox(mb);

                    btnDelete.Visible = false;

                    btnadd.Text = "اضافة";
                    txtValue.Text = "0";
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());

            //! I Like IT //
            DataTable dt = new DataTable();
            dt = HR_Tra_Allowances.SelectByPK(SelectedID);
            
            CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
            dtTra_Date.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
            chbIsPercent.Checked = Convert.ToBoolean(dt.Rows[0][5].ToString());
            txtNotes.Text = dt.Rows[0][6].ToString();
            txtValue.Text = dt.Rows[0][4].ToString();
            cbAllowanceID.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());

            btnadd.Text = "تعديل";
            btnDelete.Visible = true;
            Updated = true;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (Updated == true)
            {
                // ValidationClass.ClearControlsWithoutComboBox(this);
                BuildGUIEffects.ResetFormTextBoxes(this);

                btnDelete.Visible = false;

                btnadd.Text = "اضافة";
                txtValue.Text = "0";
                SelectedID = 0;
                Updated = false;
            }
            else
            {
                this.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID != 0)
            {
                int mb = HR_Tra_Allowances.UpdateDeleteFlagWithCheck(SelectedID);
                GetMbox(mb);
                //ValidationClass.ClearControlsWithoutComboBox(this);
                BuildGUIEffects.ResetFormTextBoxes(this);
            }
            
        }
    }
}
