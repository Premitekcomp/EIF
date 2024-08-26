using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppForms.HR;
using TMS.AppCode;
using TMS.AppCode.DAL.HR;
using TMS.AppCode.DAL.Accounting;


namespace TMS.AppForms.HR.Emp
{
    public partial class frmBasicInfo : Form
    {
        public frmBasicInfo()
        {
            InitializeComponent();
        }

        //To Check Mandtory Fiedls
        private int ValidateForm()
        {
            // Check Mandtory Fiedls
            Control[] newcontrol = new Control[] { txtEmpNameAR,
                    dTPHireDate, dTPBirthDate,
                    hR_Lup_GenderComboBox,
                    hR_Lup_CountriesComboBox,
                    hR_Lup_CitesComboBox,hR_Lup_AreasComboBox,
                    txtAddress,hR_Lup_NationalitiesComboBox,
                    hR_Lup_MilitaryServiceComboBox,
                    hR_Lup_SocialStatusComboBox 
                    ,hR_Lup_ReligionListComboBox };
            return ValidationClass.RequiredControls(newcontrol);
        }

        private void frmHR_Emp_BasicInfo_Load(object sender, EventArgs e)
        {
            LoadMethod();
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
                cboIsActive.Parent = this.PictureBG;
                //cboIsActive.ForeColor = Color.White;
                cboIsActive.BackColor = Color.Transparent;
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


        private void LoadMethod()
        {
            try
            {
                this.hR_Lup_ReligionListTableAdapter.FillAll(this.lupDataSet.HR_Lup_ReligionList);
                this.hR_Lup_SocialStatusTableAdapter.FillAll(this.lupDataSet.HR_Lup_SocialStatus);
                this.hR_Lup_MilitaryServiceTableAdapter.FillAll(this.lupDataSet.HR_Lup_MilitaryService);
                this.hR_Lup_NationalitiesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Nationalities);
                this.hR_Lup_CountriesTableAdapter.FillActive(this.lupDataSet.HR_Lup_Countries);
                this.hR_Lup_GenderTableAdapter.FillAll(this.lupDataSet.HR_Lup_Gender);
            }
            catch { }
            
            hR_Lup_ReligionListComboBox.SelectedIndex = -1;
            hR_Lup_SocialStatusComboBox.SelectedIndex = -1;
            hR_Lup_MilitaryServiceComboBox.SelectedIndex = -1;
            hR_Lup_NationalitiesComboBox.SelectedIndex = -1;
            hR_Lup_CountriesComboBox.SelectedIndex = -1;
            hR_Lup_GenderComboBox.SelectedIndex = -1;
        }

        //To Clear Controls 
        private void ClearControlsAfterSave()
        {
             ValidationClass.ClearControls(this);
        }

        //To Fill hR_Lup_CitesComboBox By CountryID
        private void hR_Lup_CountriesComboBox_TextChanged(object sender, EventArgs e)
        {
            if (hR_Lup_CountriesComboBox.SelectedIndex != -1)
            {
                try
                {
                    this.hR_Lup_CitesTableAdapter.FillByCountryID(this.lupDataSet.HR_Lup_Cites, Convert.ToByte(hR_Lup_CountriesComboBox.SelectedValue));
                }
                catch
                { }
            }
        }

        //To Fill hR_Lup_AreasComboBox By CityID
        private void hR_Lup_CitesComboBox_TextChanged(object sender, EventArgs e)
        {
            if(hR_Lup_CitesComboBox.SelectedIndex != -1)
            {
                try
                {
                    this.hR_Lup_AreasTableAdapter.FillByCityRecordID(this.lupDataSet.HR_Lup_Areas, Convert.ToByte(hR_Lup_CitesComboBox.SelectedValue));
                }
                catch
                { }
            }
        }

        //To Save and still open
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (HR_Emp_BasicInfo.CheckforFingerPrint(txtEmployeeFPNo.Text) != 0)
                {
                    lblMsg.Text = "رقم ماكينه البصمه مستخدم من قبل";
                    txtEmployeeFPNo.Focus();
                    return;
                }

                if (HR_Emp_BasicInfo.CheckforExternalID(txtExternalID.Text) != 0)
                {
                    lblMsg.Text = "رقم السجل مستخدم من قبل";
                    txtExternalID.Focus();
                    return;
                }


                if (ValidateForm() == 0) // Check Mandtory Fields
                {
                    if (IsActiveDates() == 1)
                    {
                        if (dTPHireDate.Value == DateTime.Now.Date || dTPHireDate.Value < DateTime.Now.Date)
                        {
                            Insert();
                            txtEmpNameAR.Focus();
                            lblMsg.Text = "تم الحفظ بنجاح";
                            txtEmpNameAR.Focus();
                        }
                        else
                        {
                            MessageBox.Show("يجب ان يكون تاريخ اليوم او تاريخ قديم ", "من فضلك تأكد من التاريخ");
                        }
                    }
                    else if (IsActiveDates() == 0)
                    {
                        if (dTPHireDate.Value > DateTime.Now.Date)
                        {
                            Insert();
                            lblMsg.Text = "تم الحفظ بنجاح";
                        }
                        else
                        {
                            MessageBox.Show("يجب ان يكون تاريخ مستقبلى ", "من فضلك تأكد من التاريخ");
                        }
                    }
                }
                else
                {
                    lblMsg.Text = "برجاء ادخال جميع الحقول";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1001");
            }
        }

        //To Save and close
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm() == 0) // Check Mandtory Fields
                {
                    if (IsActiveDates() == 1)
                    {
                        if (dTPHireDate.Value == DateTime.Now.Date || dTPHireDate.Value < DateTime.Now.Date)
                        {
                            Insert();
                            MessageBox.Show("تم الحفظ بنجاح", "تنبية");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("يجب ان يكون تاريخ اليوم او تاريخ قديم ", "من فضلك تأكد من التاريخ");
                        }
                    }
                    else if (IsActiveDates() == 0)
                    {
                        if (dTPHireDate.Value > DateTime.Now.Date)
                        {
                            Insert();
                            MessageBox.Show("تم الحفظ بنجاح", "تنبية");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("يجب ان يكون تاريخ مستقبلى ", "من فضلك تأكد من التاريخ");
                        }
                    }
                }
                else
                {
                    lblMsg.Text = "برجاء ادخال جميع الحقول";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1002");
            }
        }

        //To Insert In Database
        private void Insert()
        {
            #region Work In Sub Account Tree
            int ParentID = 2;
            int AccType = 6;
            string NewSubAccountNumber = ParentID.ToString() + AccountsListOperation.GetLevelDownCountNextSerial(ParentID).ToString();
            int NewSubAccountID = AccountsListOperation.CreateNewSubAccount(Convert.ToInt32(NewSubAccountNumber), txtEmpNameAR.Text, ParentID, 2, AccType, 0, 0);
            #endregion

            if (HR_Emp_BasicInfo.InsertRecord(txtEmpNameAR.Text, txtEmpNameEN.Text, txtEmployeeFPNo.Text, dTPHireDate.Value, dTPBirthDate.Value, Convert.ToInt32(hR_Lup_GenderComboBox.SelectedValue), Convert.ToInt32(hR_Lup_CountriesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_CitesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_AreasComboBox.SelectedValue), txtAddress.Text, Convert.ToInt32(hR_Lup_NationalitiesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_MilitaryServiceComboBox.SelectedValue), Convert.ToInt32(hR_Lup_SocialStatusComboBox.SelectedValue), txtNotes.Text, Convert.ToInt32(hR_Lup_ReligionListComboBox.SelectedValue), cboIsActive.Checked, txtExternalID.Text, dtStartUsingFP.Value, NewSubAccountID) != 0)
            {
                ClearControlsAfterSave();
            }
            else
            {
                lblMsg.Text = "برجاء المحاولة مرة اخرى";
            }
        }

        //To Check HireDate
        private int IsActiveDates()
        {
            if (cboIsActive.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void dTPBirthDate_Leave(object sender, EventArgs e)
        {
            DateTime birthday = dTPBirthDate.Value;
            int ThisYear = DateTime.Now.Year;
            int BirthDateYear = birthday.Year;

            if (ThisYear - BirthDateYear <= 16)
            {
                MessageBox.Show("العمر اقل من 16 سنة, هل انت متأكد من إدخاله بطريقه صحيحه", GlobalParamters.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            ClearControlsAfterSave();
            txtEmpNameAR.Focus();
        }
    }
}
