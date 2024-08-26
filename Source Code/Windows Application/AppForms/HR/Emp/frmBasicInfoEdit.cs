using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode;
using TMS.AppCode.DAL.HR;

namespace TMS.AppForms.HR.Emp
{
    public partial class frmBasicInfoEdit : Form
    {
        int RecordID = 0;
        public frmBasicInfoEdit()
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

        private void frmBasicInfoEdit_Load(object sender, EventArgs e)
        {
            RefreshFiltersCombo();

            txtSearchByExternalID.SelectedIndex = -1;
            txtSearchByFingerPrint.SelectedIndex = -1;
            txtSearchByName.SelectedIndex = -1;
            
            LoadMethod();
            MakeCommonGUITaska(this, PictureBG);

            txtSearchByName.Focus();
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

        private void RefreshFiltersCombo()
        {
            try
            {
                this.combo_NameListTableAdapter.Fill(this.empDataSet.Combo_NameList);
                this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
                this.combo_FingerPrintListTableAdapter.Fill(this.empDataSet.Combo_FingerPrintList);
            }
            catch { }
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
                this.hR_Lup_CitesTableAdapter.FillByCountryID(this.lupDataSet.HR_Lup_Cites, Convert.ToByte(hR_Lup_CountriesComboBox.SelectedValue));
            }
        }

        //To Fill hR_Lup_AreasComboBox By CityID
        private void hR_Lup_CitesComboBox_TextChanged(object sender, EventArgs e)
        {
            if (hR_Lup_CitesComboBox.SelectedIndex != -1)
            {
                this.hR_Lup_AreasTableAdapter.FillByCityRecordID(this.lupDataSet.HR_Lup_Areas, Convert.ToByte(hR_Lup_CitesComboBox.SelectedValue));
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

        //To Save and still open
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (HR_Emp_BasicInfo.CheckforFingerPrintB4Update(txtEmployeeFPNo.Text, RecordID) != 0)
                {
                    lblMsg.Text = "رقم ماكينه البصمه مستخدم من قبل";
                    txtEmployeeFPNo.Focus();
                    return;
                }

                if (HR_Emp_BasicInfo.CheckforExternalIDB4Update(txtExternalID.Text, RecordID) != 0)
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
                            Update();
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
                            Update();
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

        //To Insert In Database
        private void Update()
        {
            if (HR_Emp_BasicInfo.UpdateRecord(RecordID, txtEmpNameAR.Text, txtEmpNameEN.Text, txtEmployeeFPNo.Text, dTPHireDate.Value, dTPBirthDate.Value, Convert.ToInt32(hR_Lup_GenderComboBox.SelectedValue), Convert.ToInt32(hR_Lup_CountriesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_CitesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_AreasComboBox.SelectedValue), txtAddress.Text, Convert.ToInt32(hR_Lup_NationalitiesComboBox.SelectedValue), Convert.ToInt32(hR_Lup_MilitaryServiceComboBox.SelectedValue), Convert.ToInt32(hR_Lup_SocialStatusComboBox.SelectedValue), txtNotes.Text, Convert.ToInt32(hR_Lup_ReligionListComboBox.SelectedValue), cboIsActive.Checked, txtExternalID.Text) != 0)
            {
                lblMsg.Text = "تم التحديث بنجاح";
                //ClearControlsAfterSave();
            }
            else
            {
                lblMsg.Text = "برجاء المحاولة مرة اخرى";
            }
        }

        private void txtSearchByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.SelectedIndex != -1)
            {
                RecordID = Convert.ToInt32(txtSearchByName.SelectedValue);
                GetProfileInfo();
            }
        }

        private void txtSearchByFingerPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchByFingerPrint.SelectedIndex != -1)
            {
                RecordID = Convert.ToInt32(txtSearchByFingerPrint.SelectedValue);
                GetProfileInfo();
            }
        }

        private void txtSearchByExternalID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchByExternalID.SelectedIndex != -1)
            {
                RecordID = Convert.ToInt32(txtSearchByExternalID.SelectedValue);
                GetProfileInfo();
            }
        }

        private void GetProfileInfo()
        {
            if (RecordID != 0)
            {
                DataTable Empdt = new DataTable();
                Empdt = HR_Emp_BasicInfo.SelectByPK(RecordID);

                foreach (DataRow r in Empdt.Rows)
                {
                    txtEmpNameAR.Text = r["EmpNameAR"].ToString();
                    txtEmpNameEN.Text = r["EmpNameEN"].ToString();
                    txtEmployeeFPNo.Text = r["EmployeeFPNo"].ToString();
                    txtExternalID.Text = r["ExternalID"].ToString();
                    dTPHireDate.Value = Convert.ToDateTime(r["HireDate"].ToString());
                    dTPBirthDate.Value = Convert.ToDateTime(r["BirthDate"].ToString());
                    dtStartUsingFP.Value = Convert.ToDateTime(r["StartUsingFP"].ToString());
                    hR_Lup_GenderComboBox.SelectedValue = Convert.ToInt32(r["GenderID"].ToString());
                    hR_Lup_CountriesComboBox.SelectedValue = Convert.ToInt32(r["CountryID"].ToString());
                    hR_Lup_CitesComboBox.SelectedValue = Convert.ToInt32(r["CityID"].ToString());
                    hR_Lup_AreasComboBox.SelectedValue = Convert.ToInt32(r["AreaID"].ToString());
                    txtAddress.Text =  r["Address"].ToString();
                    hR_Lup_NationalitiesComboBox.SelectedValue = Convert.ToInt32(r["NationalityID"].ToString());
                    hR_Lup_MilitaryServiceComboBox.SelectedValue = Convert.ToInt32(r["MilitaryServiceID"].ToString());
                    hR_Lup_SocialStatusComboBox.SelectedValue = Convert.ToInt32(r["SocialStatusID"].ToString());
                    hR_Lup_ReligionListComboBox.SelectedValue = Convert.ToInt32(r["ReligionID"].ToString());
                    txtNotes.Text = r["Notes"].ToString();
                }
            }
        }

        private void PictureBG_Click(object sender, EventArgs e)
        {

        }

    }
}
