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
    public partial class frmCustody : Form
    {
        public frmCustody()
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
                lblMbox.Text = "حدث خطاء يرجى المحاولة مرة اخرى";
            }
        }

        public bool IsValed()
        {
            if (CbEmpID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار أسم الموظف";
                CbEmpID.Focus();
                return false;
            }

            if (cbCustodyID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب إختيار البند";
                cbCustodyID.Focus();
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
            if(dtFromDate.Value >= dtToDate .Value)
            {
                lblMbox.Text = "يجب ان يكون تاريخ البداية سابق لتاريخ النهاية";
                dtFromDate.Focus();
                return false;
            }
            return true;
        }

        private void RefreshGrid()
        {
            try
            {
                this.grid_Tra_CustodyTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Custody, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmCustody_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_CustodyTableAdapter.FillAll(this.lupDataSet.HR_Lup_Custody);
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
                    int mb = HR_Tra_Custody.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value,Convert.ToInt32(cbCustodyID.SelectedValue) , dtFromDate.Value, dtToDate.Value, txtNotes.Text);
                    GetMbox(mb);
                    // ValidationClass.ClearControlsWithoutComboBox(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
            else if (Updated == true)
            {
                if (IsValed())
                {
                    int mb = HR_Tra_Custody.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), dtTra_Date.Value,Convert.ToInt32(cbCustodyID.SelectedValue), dtFromDate.Value, dtToDate.Value, txtNotes.Text);
                    GetMbox(mb);
                    // ValidationClass.ClearControlsWithoutComboBox(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);

                    btnDelete.Visible = false;
                    btnadd.Text = "اضافة";
                    CbEmpID.Focus();
                    SelectedID = 0;
                    Updated = false;
                }
            }
        }
        
        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (Updated == true)
            {
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                btnDelete.Visible = false;
                btnadd.Text = "اضافة";

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
            int mb = HR_Tra_Custody.UpdateDeleteFlagWithCheck(SelectedID);
            GetMbox(mb);
            // ValidationClass.ClearControlsWithoutComboBox(this);
            BuildGUIEffects.ResetFormTextBoxes(this);
            btnDelete.Visible = false;
            btnadd.Text = "اضافة";
            SelectedID = 0;
            Updated = false;
        }

        private void grForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = int.Parse(grForm.Rows[e.RowIndex].Cells[0].Value.ToString());

            DataTable dt = new DataTable();
            dt = HR_Tra_Custody.SelectByPK(SelectedID);

            CbEmpID.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
            dtTra_Date.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
            cbCustodyID.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());
            dtFromDate.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
            dtFromDate.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
            txtNotes.Text = dt.Rows[0][6].ToString();

            btnadd.Text = "تعديل";
            btnDelete.Visible = true;
            Updated = true;

        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();

        }
    }
}
