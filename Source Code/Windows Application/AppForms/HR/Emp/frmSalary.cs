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
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        //To Check Mandtory Fiedls
        private int ValidateForm()
        {
                // Check Mandtory Fiedls
                Control[] newcontrol = new Control[] { cboEmpID, txtBasicSalaryWithoutAdvance, txtTotaLAdvance, txtVariantSalary };
                return ValidationClass.RequiredControls(newcontrol);

        }

        private void RefreshGrid()
        {
            try
            {
                if (cboEmpID.SelectedIndex != -1)
                {
                    this.grid_EmpSalaryTableAdapter.FillByEmpID(this.empDataSet.Grid_EmpSalary, ((short)(System.Convert.ChangeType(cboEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void frmSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
                //DataTable dt = HR_Emp_BasicInfo.SelectForComboBox();
                //cboEmpID.DataSource = dt;
                //cboEmpID.DisplayMember = "EmpNameAR";
                //cboEmpID.ValueMember = "EmployeeID";
                //cboEmpID.SelectedIndex = -1;
            }
            catch (Exception)
            {
            }
           
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


        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == 0) // Check Mandtory Fields
                {
                    UpdateIsCurrentFlag();
                    InsertMethod();
                    RefreshGrid();
                    lblMsg.Text = "تم الحفظ بنجاح";
                }
                else
                {
                    lblMsg.Text = "برجاء ادخال جميع الحقول";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1003");
            }
        }


        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == 0) // Check Mandtory Fields
                {
                        UpdateIsCurrentFlag();
                        InsertMethod();
                        RefreshGrid();
                        MessageBox.Show("تم الحفظ بنجاح", "تنبية");
                        this.Close();
                }
                else
                {
                    lblMsg.Text = "برجاء ادخال جميع الحقول";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1004");
            }
        }

        private void InsertMethod()
        {
            try
            {
                if (HR_Emp_Salary.InsertRecord(Convert.ToInt32(cboEmpID.SelectedValue), Convert.ToDecimal(txtBasicSalaryWithoutAdvance.Text), Convert.ToDecimal(txtTotaLAdvance.Text), Convert.ToDecimal(txtBasicSalary.Text), Convert.ToDecimal(txtVariantSalary.Text)) != 0)
                {
                    //ValidationClass.ClearControls(this);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
                else
                {
                    lblMsg.Text = "برجاء المحاولة مرة اخرى";
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void UpdateIsCurrentFlag()
        {
            HR_Emp_Salary.UpdateIsCurrentFlag(Convert.ToInt32(cboEmpID.SelectedValue));
        }

        private void txtBasicSalaryWithoutAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtTotaLAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void txtVariantSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void txtBasicSalaryWithoutAdvance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal BasicSalaryWithoutAdvance = Convert.ToDecimal(txtBasicSalaryWithoutAdvance.Text);
                decimal TotaLAdvance = Convert.ToDecimal(txtTotaLAdvance.Text);
                txtBasicSalary.Text = (TotaLAdvance + BasicSalaryWithoutAdvance).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtTotaLAdvance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal BasicSalaryWithoutAdvance = Convert.ToDecimal(txtBasicSalaryWithoutAdvance.Text);
                decimal TotaLAdvance = Convert.ToDecimal(txtTotaLAdvance.Text);
                txtBasicSalary.Text = (TotaLAdvance + BasicSalaryWithoutAdvance).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpID.SelectedIndex != -1)
            {
                txtEmpID.SelectedValue = cboEmpID.SelectedValue;
            }

            RefreshGrid();
        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex != -1)
            {
                cboEmpID.SelectedValue = txtEmpID.SelectedValue;
            }
        }

        private void PictureBG_Click(object sender, EventArgs e)
        {

        }
    }
}
