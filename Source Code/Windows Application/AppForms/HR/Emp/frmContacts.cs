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
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Variables
        /// </summary>
        /// <param name="resalt"></param>
        public int SelectedID;
        public bool Updated = false;

        private void frmContacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.hR_Lup_ContactsTypeTableAdapter.FillAll(this.lupDataSet.HR_Lup_ContactsType);
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
                    this.grid_EmpContactsTableAdapter.FillByEmpID(this.empDataSet.Grid_EmpContacts, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
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
            try
            {
                if (Updated == false)
                {
                    if (IsValed())
                    {
                        int mb = HR_Emp_Contacts.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtContactTypeID.SelectedValue), txtContactValue.Text, IsCurrent.Checked);
                        if (mb == 1)
                        {

                            TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                            RefreshGrid();
                            CbEmpID.Focus();
                        }
                        GetMbox(mb);

                    }
                }
                else if (Updated == true)
                {
                    int mb = HR_Emp_Contacts.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtContactTypeID.SelectedValue), txtContactValue.Text, IsCurrent.Checked);
                    GetMbox(mb);
                    if (mb == 1)
                    {
                        TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                        RefreshGrid();
                        Updated = false;
                        btnDelete.Visible = false;
                        btnSaveClose.Enabled = true;
                        btnSaveNew.Text = "حفظ / جديد";
                        SelectedID = 0;
                    }

                }
            }
            catch (Exception)
            {
            }


        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = HR_Emp_Contacts.SelectByPK(SelectedID);
                CbEmpID.SelectedValue = dt.Rows[0][1].ToString();
                txtContactTypeID.SelectedValue = dt.Rows[0][2].ToString();
                txtContactValue.Text = dt.Rows[0][3].ToString();
                IsCurrent.Checked = Convert.ToBoolean(dt.Rows[0][4].ToString());
                Updated = true;
                btnDelete.Visible = true;
                btnSaveNew.Text = "تعديل";
                btnSaveClose.Enabled = false;
            }
            catch (Exception)
            {
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updated == true)
                {
                    int mb = HR_Emp_Contacts.UpdateDeleteFlagWithCheck(SelectedID);
                    if (mb ==1)
                    {
                        TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                        RefreshGrid();
                        Updated = false;
                        btnDelete.Visible = false;
                        btnSaveNew.Text = "حفظ / جديد";
                        btnSaveClose.Enabled = true;
                        SelectedID = 0;
                    }
                    GetMbox(mb, true);
                }
            }
            catch (Exception)
            {
            }

        }
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValed())
                {
                    int mb = HR_Emp_Contacts.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtContactTypeID.SelectedValue), txtContactValue.Text, IsCurrent.Checked);
                    GetMbox(mb);
                    if (mb == 1)
                    {
                        TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                        RefreshGrid();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void GetMbox(int resalt , bool IsForDelete = false)
        {
            if (IsForDelete == false)
            {
                if (resalt == 1)
                {
                    lblMsg.Text = "تم الحفظ";
                }
                else
                {
                    lblMsg.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
                }
            }
            if (IsForDelete == true)
            {
                if (resalt == 1)
                {
                    lblMsg.Text = "تم حذف البينات ";
                }
                else
                {
                    lblMsg.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
                }
            }

        }
        public bool IsValed()
        {
            if (CbEmpID.SelectedIndex ==  -1)
            {
                lblMsg.Text = "يجب اختيار اسم الموظف";
                CbEmpID.Focus();
                return false;

            }
            if (txtContactTypeID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار نوع البيان";
                CbEmpID.Focus();
                return false;
            }
            if (txtContactValue.Text.Trim().ToString() == "")
            {
                lblMsg.Text = "يجب ادخال قيمة البيان";
                CbEmpID.Focus();
                return false;
            }
            else
            {
                return true;
            }
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
