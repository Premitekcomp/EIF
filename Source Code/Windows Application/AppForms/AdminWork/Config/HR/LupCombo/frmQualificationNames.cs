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

namespace TMS.AppForms.AdminWork.Config.HR.LupCombo
{
    public partial class frmQualificationNames : Form
    {
        int QualificationNameID;
        int btnAddFlag = 0;

        public frmQualificationNames()
        {
            InitializeComponent();
        }

        private void frmQualificationNames_Load(object sender, EventArgs e)
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
                this.hR_Lup_QualificationsTypesTableAdapter.FillAll(this.LupDataSet.HR_Lup_QualificationsTypes);
                if (hR_Lup_QualificationsTypesComboBox.SelectedIndex != -1)
                { 
                    this.hR_Lup_QualificationNamesTableAdapter.FillByQualificationTypeID(this.LupDataSet.HR_Lup_QualificationNames, ((byte)(System.Convert.ChangeType(hR_Lup_QualificationsTypesComboBox.SelectedValue, typeof(byte)))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void hR_Lup_QualificationsTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_QualificationNamesTableAdapter.FillByQualificationTypeID(this.LupDataSet.HR_Lup_QualificationNames, ((byte)(System.Convert.ChangeType(hR_Lup_QualificationsTypesComboBox.SelectedValue, typeof(byte)))));
            }
            catch (Exception)
            {
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
                    QualificationNameID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                   // hR_Lup_QualificationsTypesComboBox.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQualificationNameAr.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtQualificationNameEN.Text = gvForm.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            if (txtQualificationNameAr.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل اسم المؤهل باللغة العربية";
                txtQualificationNameAr.Focus();
                return false;
            }
            //if (txtQualificationNameEN.Text.Trim().Length == 0)
            //{
            //    lblMsg.Text = "من فضلك ادخل اسم المؤهل باللغة الانجليزية";
            //    txtQualificationNameEN.Focus();
            //    return false;
            //}
            if (hR_Lup_QualificationsTypesComboBox.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر نوع المؤهل";
                hR_Lup_QualificationsTypesComboBox.Focus();
                return false;
            }

            return true;
        }

        private void InsertMethod()
        {
            if (HR_Lup_QualificationNames.InsertRecord(txtQualificationNameAr.Text, txtQualificationNameEN.Text,Convert.ToInt32(hR_Lup_QualificationsTypesComboBox.SelectedValue)) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Lup_QualificationNames.UpdateRecord(QualificationNameID, txtQualificationNameAr.Text, txtQualificationNameEN.Text, Convert.ToInt32(hR_Lup_QualificationsTypesComboBox.SelectedValue)) == 1)
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
                        //RefreshGrid();
                        this.hR_Lup_QualificationNamesTableAdapter.FillByQualificationTypeID(this.LupDataSet.HR_Lup_QualificationNames, ((byte)(System.Convert.ChangeType(hR_Lup_QualificationsTypesComboBox.SelectedValue, typeof(byte)))));
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtQualificationNameAr.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                    if (EmptyOrNot())
                    {
                        UpdateMethod();
                        lblMsg.Text = "تم التعديل بنجاح";
                        ChangeControlByFlags(0);
                        //RefreshGrid();
                        this.hR_Lup_QualificationNamesTableAdapter.FillByQualificationTypeID(this.LupDataSet.HR_Lup_QualificationNames, ((byte)(System.Convert.ChangeType(hR_Lup_QualificationsTypesComboBox.SelectedValue, typeof(byte)))));
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        txtQualificationNameAr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1032");
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
                MessageBox.Show(ex.Message, "1033");
            }
        }





    }
}
