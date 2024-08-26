﻿using TMS.AppCode;
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
    public partial class frmSocialInssuranceOffices : Form
    {
        int SocialInssuranceOfficeID;
        int btnAddFlag = 0;

        public frmSocialInssuranceOffices()
        {
            InitializeComponent();
        }

        private void frmSocialInssuranceOffices_Load(object sender, EventArgs e)
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
            this.hR_Lup_SocialInssuranceOfficesTableAdapter.FillAll(this.LupDataSet.HR_Lup_SocialInssuranceOffices);
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
                    SocialInssuranceOfficeID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtSocialInssuranceOfficeCode.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSocialInssuranceOfficeNameAr.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtSocialInssuranceOfficeNameEn.Text = gvForm.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            if (txtSocialInssuranceOfficeCode.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل كود المكتب";
                txtSocialInssuranceOfficeCode.Focus();
                return false;
            }
            if (txtSocialInssuranceOfficeNameAr.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل اسم المكتب باللغةالعربية ";
                txtSocialInssuranceOfficeNameAr.Focus();
                return false;
            }
        

            return true;
        }

        private void InsertMethod()
        {
            if (HR_Lup_SocialInssuranceOffices.InsertRecord(txtSocialInssuranceOfficeCode.Text, txtSocialInssuranceOfficeNameAr.Text, txtSocialInssuranceOfficeNameEn.Text) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Lup_SocialInssuranceOffices.UpdateRecord(SocialInssuranceOfficeID, txtSocialInssuranceOfficeCode.Text, txtSocialInssuranceOfficeNameAr.Text, txtSocialInssuranceOfficeNameEn.Text) == 1)
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
                        txtSocialInssuranceOfficeCode.Focus();
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
                        txtSocialInssuranceOfficeCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1040");
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
                MessageBox.Show(ex.Message, "1041");
            }
        }






    }
}
