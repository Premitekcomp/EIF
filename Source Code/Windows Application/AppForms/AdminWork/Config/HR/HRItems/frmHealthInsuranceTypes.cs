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
    public partial class frmHealthInsuranceTypes : Form
    {
        int HealthInsuranceTypeID;
        int btnAddFlag = 0;
        public frmHealthInsuranceTypes()
        {
            InitializeComponent();
        }

        private void frmHealthInsuranceTypes_Load(object sender, EventArgs e)
        {
            RefreshGrid();
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


        private void RefreshGrid()
        {
            try
            {
                this.hR_Lup_HealthInsuranceTypesTableAdapter.FillAll(this.LupDataSet.HR_Lup_HealthInsuranceTypes);
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    HealthInsuranceTypeID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtHealthInsuranceTypeAr.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtHealthInsuranceTypeEn.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtValue.Text = gvForm.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtNotes.Text = gvForm.Rows[e.RowIndex].Cells[4].Value.ToString();
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
            if (txtHealthInsuranceTypeAr.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل اسم النوع باللغة العربية";
                txtHealthInsuranceTypeAr.Focus();
                return false;
            }
            //if (txtHealthInsuranceTypeEn.Text.Trim().Length == 0)
            //{
            //    lblMsg.Text = "من فضلك ادخل اسم النوع باللغة الانجليزية";
            //    txtHealthInsuranceTypeEn.Focus();
            //    return false;
            //}
            if (txtValue.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل القيمة";
                txtValue.Focus();
                return false;
            }


            return true;
        }

        private void InsertMethod()
        {
            if (HR_Lup_HealthInsuranceTypes.InsertRecord(txtHealthInsuranceTypeAr.Text, txtHealthInsuranceTypeEn.Text, Convert.ToDecimal(txtValue.Text), txtNotes.Text) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Lup_HealthInsuranceTypes.UpdateRecord(HealthInsuranceTypeID, txtHealthInsuranceTypeAr.Text, txtHealthInsuranceTypeEn.Text, Convert.ToDecimal(txtValue.Text), txtNotes.Text) == 1)
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
                        lblMsg.Text = "تم الحفظ بنجاح";
                        RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtHealthInsuranceTypeAr.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                    if (EmptyOrNot())
                    {
                        UpdateMethod();
                        lblMsg.Text = "تم التعديل بنجاح";
                        ChangeControlByFlags(0);
                        RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtHealthInsuranceTypeAr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "1022");
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
                MessageBox.Show(ex.Message, "1023");
            }
        }




    }
}
