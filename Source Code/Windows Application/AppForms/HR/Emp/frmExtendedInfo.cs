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
    public partial class frmExtendedInfo : Form
    {
        public frmExtendedInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variables
        /// </summary>
        /// <param name="resalt"></param>
        public int SelectedID;
        public bool Updated = false;

        private void frmPapers_Load(object sender, EventArgs e)
        {
            try
            { 
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                this.hR_Lup_HealthInsuranceTypesTableAdapter.FillAll(this.lupDataSet.HR_Lup_HealthInsuranceTypes);
                this.hR_Lup_SocialInssuranceOfficesTableAdapter.FillAll(this.lupDataSet.HR_Lup_SocialInssuranceOffices);
                this.hR_Lup_BankListTableAdapter.FillAll(this.lupDataSet.HR_Lup_BankList);
                RefreshGrid();
            }
            catch { }
           
        MakeCommonGUITaska(this, PictureBG);
        CbEmpID.SelectedIndex = -1;
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
                IsHasPassport.Parent = this.PictureBG;
                //IsHasPassport.ForeColor = Color.White;
                IsHasPassport.BackColor = Color.Transparent;

                ISHasPrivateCar.Parent = this.PictureBG;
                //ISHasPrivateCar.ForeColor = Color.White;
                ISHasPrivateCar.BackColor = Color.Transparent;

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
                    //this.grid_Emp_DocumentsTableAdapter.FillByEmpID(this.empDataSet.Grid_Emp_Documents, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RefreshGrid();
            try
            {
                DataTable dt = new DataTable();
                dt = HR_Emp_Papers.SelectByEmpID(Convert.ToInt32(CbEmpID.SelectedValue));
                if (dt.Rows[0][0].ToString() != "" )
                {
                    nationalIDNoTextBox.Text = dt.Rows[0][2].ToString();
                    if (dt.Rows[0][3].ToString() != "")
                    {
                        nationalIDIssueDateDateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                    }
                    else
                    {
                        nationalIDIssueDateDateTimePicker.Value = System.DateTime.Now;
                    }

                    if (dt.Rows[0][4].ToString() != "")
                    {
                        nationalIDExpireDateDateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                    }
                    else
                    {
                        nationalIDExpireDateDateTimePicker.Value = System.DateTime.Now;
                    }
                    
                    IsHasPassport.Checked = Convert.ToBoolean(dt.Rows[0][5].ToString());
                    IsHasPassportcheck();
                    passportNoTextBox.Text = dt.Rows[0][6].ToString();

                    if (dt.Rows[0][7].ToString() != "")
                    {
                        passportExpireDateDateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
                    }
                    else
                    {
                        passportExpireDateDateTimePicker.Value = System.DateTime.Now;
                    }

                    
                    ISHasPrivateCar.Checked = Convert.ToBoolean(dt.Rows[0][8].ToString());
                    ISHasPrivateCarCheck();
                    drivingLicenseIDTextBox.Text = dt.Rows[0][9].ToString();
                    txtBankID.SelectedValue = Convert.ToInt32(dt.Rows[0][10].ToString());
                    bankAccountNoTextBox.Text = dt.Rows[0][11].ToString();
                    txtInsuranceOfficeID.SelectedValue = Convert.ToInt32(dt.Rows[0][13].ToString());
                    socialInssuranceNoTextBox.Text = dt.Rows[0][12].ToString();

                    if (dt.Rows[0][14].ToString() != "")
                    {
                        firstInssuranceDateDateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][14].ToString());
                    }
                    else
                    {
                        firstInssuranceDateDateTimePicker.Value = System.DateTime.Now;
                    }

                    if (dt.Rows[0][15].ToString() != "")
                    {
                        inssuranceDateDateTimePicker.Value = Convert.ToDateTime(dt.Rows[0][15].ToString());
                    }
                    else
                    {
                        inssuranceDateDateTimePicker.Value = System.DateTime.Now;
                    }

                    
                    txtHealthInsuranceTypeID.SelectedValue = dt.Rows[0][16].ToString();
                    Updated = true;
                    SelectedID = Convert.ToInt32(dt.Rows[0][0].ToString());
                    btnSaveNew.Text = "تعديل";
                    btnSaveClose.Enabled = false;
                }

            }
            catch (Exception)
            {
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                Updated = false;
                SelectedID = 0;
                btnSaveNew.Text = "حفظ / جديد";
                btnSaveClose.Enabled = true;
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (Updated == false)
            {
                if (IsValed())
                {

                    int mb = HR_Emp_Papers.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), nationalIDNoTextBox.Text, nationalIDIssueDateDateTimePicker.Value, nationalIDExpireDateDateTimePicker.Value, IsHasPassport.Checked, passportNoTextBox.Text, passportExpireDateDateTimePicker.Value, ISHasPrivateCar.Checked, int.Parse( drivingLicenseIDTextBox.Text), Convert.ToInt32(txtBankID.SelectedValue), bankAccountNoTextBox.Text, socialInssuranceNoTextBox.Text, Convert.ToInt32(txtInsuranceOfficeID.SelectedValue), firstInssuranceDateDateTimePicker.Value, inssuranceDateDateTimePicker.Value, Convert.ToInt32(txtHealthInsuranceTypeID.SelectedValue));
                    if (mb == 1)
                    {

                        TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                        //RefreshGrid();
                        CbEmpID.Focus();

                    }
                    GetMbox(mb);
                }
            }
            if (Updated == true)
            {
                if (IsValed())
                {

                    int mb = HR_Emp_Papers.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), nationalIDNoTextBox.Text, nationalIDIssueDateDateTimePicker.Value, nationalIDExpireDateDateTimePicker.Value, IsHasPassport.Checked, passportNoTextBox.Text, passportExpireDateDateTimePicker.Value, ISHasPrivateCar.Checked, int.Parse(drivingLicenseIDTextBox.Text), Convert.ToInt32(txtBankID.SelectedValue), bankAccountNoTextBox.Text, socialInssuranceNoTextBox.Text, Convert.ToInt32(txtInsuranceOfficeID.SelectedValue), firstInssuranceDateDateTimePicker.Value, inssuranceDateDateTimePicker.Value, Convert.ToInt32(txtHealthInsuranceTypeID.SelectedValue));
                    if (mb != 0)
                    {

                        TMS.AppCode.ValidationClass.ClearControls(this);
                        //RefreshGrid();
                        Updated = false;
                        SelectedID = 0;
                        btnSaveNew.Text = "حفظ / جديد";
                        btnSaveClose.Enabled = true;
                    }
                    GetMbox(mb);

                }
            }
        }


        private void GetMbox(int resalt, bool IsForDelete = false)
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
            if (CbEmpID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار اسم الموظف";
                CbEmpID.Focus();
                return false;
            }
            if (nationalIDNoTextBox.Text.Trim().Length != 14)
            {
                lblMsg.Text = "يجب ادخال الرقم القومى كاملا 14 خانه";
                nationalIDNoTextBox.Focus();
                return false;
            }
            //if (txtBankID.SelectedIndex == -1)
            //{
            //    lblMsg.Text = "يجب اختيار اسم البنك";
            //    txtBankID.Focus();
            //    return false;
            //}
            //if (bankAccountNoTextBox.Text.Trim().Length == 0)
            //{
            //    lblMsg.Text = "يجب ادخال رقم الحساب البنك ";
            //    bankAccountNoTextBox.Focus();
            //    return false;
            //}
            //if (txtInsuranceOfficeID.SelectedIndex == -1)
            //{
            //    lblMsg.Text = "يجب اختيار اسم مكتب التأمينات";
            //    txtInsuranceOfficeID.Focus();
            //    return false;
            //}
            //if (socialInssuranceNoTextBox.Text == "" && socialInssuranceNoTextBox.Text == "0")
            //{
            //    lblMsg.Text = "يجب ادخال الرقم التأمينات";
            //    socialInssuranceNoTextBox.Focus();
            //    return false;
            //}
            //if (txtHealthInsuranceTypeID.SelectedIndex == -1)
            //{
            //    lblMsg.Text = "يجب اختيار  نوع التأمين الصحي";
            //    txtHealthInsuranceTypeID.Focus();
            //    return false;
            //}
            if (DataValidation.EnsureTodayToPast(nationalIDIssueDateDateTimePicker.Value) == false)
            {
                lblMsg.Text = "يجب اختيار  التاريخ اصدار الرقم القومى بشكل صحيح";
                nationalIDIssueDateDateTimePicker.Focus();
                return false;
            }
            if (nationalIDExpireDateDateTimePicker.Value.Date != nationalIDIssueDateDateTimePicker.Value.Date.AddYears(7))
            {
                lblMsg.Text = "يجب اختيار  التاريخ انتهاء الرقم القومى بشكل صحيح";
                nationalIDExpireDateDateTimePicker.Focus();
                return false;
            }
            //firstInssuranceDateDateTimePicker
            if (DataValidation.EnsureTodayToPast(firstInssuranceDateDateTimePicker.Value) == false)
            {
                lblMsg.Text = "يجب اختيار  تاريخ بداية التأمين  بشكل صحيح";
                firstInssuranceDateDateTimePicker.Focus();
                return false;
            }
            if (DataValidation.EnsureTodayToPast(inssuranceDateDateTimePicker.Value) == false)
            {
                lblMsg.Text = "يجب اختيار  تاريخ بداية التأمين  بشكل صحيح";
                inssuranceDateDateTimePicker.Focus();
                return false;
            }
            
            return true;
            
        }

        private void IsHasPassport_CheckedChanged(object sender, EventArgs e)
        {
            IsHasPassportcheck();
            
        }

        private void IsHasPassportcheck()
        {
            if (IsHasPassport.Checked == true)
            {
                passportNoTextBox.Visible = true;
                passportNolbl.Visible = true;
            }
            if (IsHasPassport.Checked == false)
            {
                passportNoTextBox.Visible = false;
                passportNolbl.Visible = false;
            }
        }

        private void ISHasPrivateCar_CheckedChanged(object sender, EventArgs e)
        {
            ISHasPrivateCarCheck();

        }

        private void ISHasPrivateCarCheck()
        {
            if (ISHasPrivateCar.Checked == true)
            {
                drivingLicenseIDTextBox.Visible = true;
                drivingLicenseIDLbl.Visible = true;
            }
            if (ISHasPrivateCar.Checked == false)
            {
                drivingLicenseIDTextBox.Visible = false;
                drivingLicenseIDLbl.Visible = false;
            }
        }

        private void nationalIDIssueDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            nationalIDExpireDateDateTimePicker.Value = nationalIDIssueDateDateTimePicker.Value.AddYears(7);
        }

        private void passportNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void drivingLicenseIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nationalIDNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bankAccountNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void socialInssuranceNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        
    }
}
