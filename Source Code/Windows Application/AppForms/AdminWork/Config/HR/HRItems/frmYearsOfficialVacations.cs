using TMS.AppCode;
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

namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    public partial class frmYearsOfficialVacations : Form
    {

        int YearOfficialVacationID;
        int btnAddFlag = 0;

        public frmYearsOfficialVacations()
        {
            InitializeComponent();
        }

        private void frmYearsOfficialVacations_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_YearsTableAdapter.FillAll(this.lupDataSet.HR_Lup_Years);
            }   
            catch
            { }
            
            RefreshGrid();
            MakeCommonGUITaska(this);
        }

        private void MakeCommonGUITaska(Form PassedFormName)
        {
            try
            {
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


        private void RefreshGrid()
        {
            try
            {
                
                if (hR_Lup_YearsComboBox.SelectedIndex != -1)
                {
                    this.hR_Lup_YearsOfficialVacationsTableAdapter.FillByYearID(this.lupDataSet.HR_Lup_YearsOfficialVacations, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                }

            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void hR_Lup_YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (hR_Lup_YearsComboBox.SelectedIndex != -1)
                {
                    this.hR_Lup_YearsOfficialVacationsTableAdapter.FillByYearID(this.lupDataSet.HR_Lup_YearsOfficialVacations, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Flag
        private void ChangeControlByFlags(int btnAddFlag)
        {
            if (btnAddFlag == 0)
            {
                btnSaveNew.Text = "حفظ / جديد";
                btnSaveClose.Text = "حفظ / اغلاق";

            }
            else if (btnAddFlag == 1)
            {
                btnSaveNew.Text = "تعديل";
                btnSaveClose.Text = "الغاء الامر";

            }
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    YearOfficialVacationID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtYearOfficialVacationNameAr.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtYearOfficialVacationLength.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dTPYearOfficialVacationDate.Value = DateTime.Parse( gvForm.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtNotes.Text = gvForm.Rows[e.RowIndex].Cells[5].Value.ToString();
                    btnAddFlag = 1;
                    ChangeControlByFlags(1);
                }
            }
            catch (Exception)
            {
            }
        }

        private bool EmptyOrNot()
        {
            
            if (hR_Lup_YearsComboBox.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر السنة";
                txtYearOfficialVacationNameAr.Focus();
                return false;
            }
            if (dTPYearOfficialVacationDate.Value.Year != Convert.ToInt32( hR_Lup_YearsComboBox.Text))
            {
                lblMsg.Text = "من فضلك تأكد من التاريخ ";
                dTPYearOfficialVacationDate.Focus();
                return false;
            }
            if (txtYearOfficialVacationNameAr.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل اسم الاجازة باللغة العربية";
                txtYearOfficialVacationNameAr.Focus();
                return false;
            }
            if (txtYearOfficialVacationLength.Text.Trim().Length == 0 || txtYearOfficialVacationLength.Text == "0")
            {
                lblMsg.Text = "قم بتحديد مده الإجازه رقم موجب اكبر من صفر";
                txtYearOfficialVacationNameAr.Focus();
                return false;
            }
            return true;
        }

        private void InsertMethod()
        {
            if (HR_Lup_YearsOfficialVacations.InsertRecord(txtYearOfficialVacationNameAr.Text, Convert.ToInt32(txtYearOfficialVacationLength.Text), Convert.ToInt32(hR_Lup_YearsComboBox.SelectedValue),Convert.ToDateTime( dTPYearOfficialVacationDate.Value), txtNotes.Text) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
            else
            {
                lblMsg.Text = "خطأ في الحفظ برجاء إعاده المحاولة";
            }
        }

        private void UpdateMethod()
        {
            if (HR_Lup_YearsOfficialVacations.UpdateRecord(YearOfficialVacationID, txtYearOfficialVacationNameAr.Text, Convert.ToInt32(txtYearOfficialVacationLength.Text), Convert.ToDateTime(dTPYearOfficialVacationDate.Value), txtNotes.Text) == 1)
            {
                lblMsg.Text = "تم التعديل بنجاح";
                btnAddFlag = 0;
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                //To Save
                if (btnAddFlag == 0)
                {
                    if (EmptyOrNot())
                    {
                        InsertMethod();
                        this.hR_Lup_YearsOfficialVacationsTableAdapter.FillByYearID(this.lupDataSet.HR_Lup_YearsOfficialVacations, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                        //RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtYearOfficialVacationLength.Text = "1";
                        txtYearOfficialVacationNameAr.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                    if (EmptyOrNot())
                    {
                        UpdateMethod();
                        lblMsg.Text = "تم التعديل بنجاح";
                        ChangeControlByFlags(0);
                        this.hR_Lup_YearsOfficialVacationsTableAdapter.FillByYearID(this.lupDataSet.HR_Lup_YearsOfficialVacations, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                        //RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtYearOfficialVacationNameAr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1050");
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAddFlag == 1)
                {
                    btnAddFlag = 0;
                    ChangeControlByFlags(0);
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
                else if (btnAddFlag == 0)
                {
                    //To Save
                    if (btnAddFlag == 0)
                    {
                        if (EmptyOrNot())
                        {
                            InsertMethod();
                            MessageBox.Show("تم الحفظ بنجاح");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1051");
            }
        }


    
    }
}
