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

namespace TMS.AppForms.HR.Emp
{
    public partial class frmCertificates : Form
    {
        int EmployeeCertificateID;
        int btnAddFlag = 0;

        public frmCertificates()
        {
            InitializeComponent();
        }
        #region Methods

        //Flag
        private void ChangeControlByFlags(int btnAddFlag)
        {
            if (btnAddFlag == 0)
            {
                btnSaveNew.Text = "حفظ / جديد";
                btnSaveClose.Text = "حفظ / اغلاق";
                btnDelete.Visible = false;
            }
            else if (btnAddFlag == 1)
            {
                btnSaveNew.Text = "تعديل";
                btnSaveClose.Text = "الغاء الامر";
                btnDelete.Visible = true;
            }
        }

        private void RefreshGrid()
        {
            try
            {
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.grid_Emp_CertificatesTableAdapter.FillByEmpID(this.empDataSet.Grid_Emp_Certificates, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private bool EmptyOrNot()
        {
            if (CbEmpID.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر الموظف";
                CbEmpID.Focus();
                return false;
            }

            if (txtCertificateNameAr.Text.Trim().Length == 0)
            {
                lblMsg.Text = "من فضلك ادخل اسم الشهادة";
                txtCertificateNameAr.Focus();
                return false;
            }

            //if (txtCertificateNameEn.Text.Trim().Length == 0)
            //{
            //    lblMsg.Text = "من فضلك ادخل اسم الشهادة";
            //    txtCertificateNameEn.Focus();
            //    return false;
            //}

            if (DataValidation.EnsureTodayToPast(dtCertificateDate.Value) == false)
            {
                lblMsg.Text = "من فضلك تأكد من التاريخ";
                dtCertificateDate.Focus();
                return false;
            }

            return true;
        }

        private void InsertMethod()
        {
            if (HR_Emp_Certificates.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), txtCertificateNameAr.Text, txtCertificateNameEn.Text, dtCertificateDate.Value, dtExpireDate.Value) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Emp_Certificates.UpdateRecord(EmployeeCertificateID, Convert.ToInt32(CbEmpID.SelectedValue), txtCertificateNameAr.Text, txtCertificateNameEn.Text, dtCertificateDate.Value, dtExpireDate.Value) == 1)
            {
                lblMsg.Text = "تم التعديل بنجاح";
                btnAddFlag = 0;
            }
        }

        #endregion
        private void frmCertificates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataSet.Combo_ExternalID' table. You can move, or remove it, as needed.
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
            }
            catch {}
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


        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEmpID.SelectedIndex != -1)
            {
                txtEmpID.SelectedValue = CbEmpID.SelectedValue;
            }
            RefreshGrid();
        }

        private void dtCertificateDate_Leave(object sender, EventArgs e)
        {
            try
            {
                dtExpireDate.Value = dtCertificateDate.Value;
            }
            catch (Exception)
            {}
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    EmployeeCertificateID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());

                    CbEmpID.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCertificateNameAr.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtCertificateNameEn.Text = gvForm.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtCertificateDate.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[4].Value.ToString());
                    dtExpireDate.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[5].Value.ToString());

                    btnAddFlag = 1;
                    ChangeControlByFlags(1);
                }
            }
            catch (Exception)
            {}
           
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
                MessageBox.Show(ex.Message, "1013");
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
                        RefreshGrid();
                        CbEmpID.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                    if (EmptyOrNot())
                    {
                        UpdateMethod();
                        lblMsg.Text = "تم التعديل بنجاح";
                        RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        RefreshGrid();
                        CbEmpID.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1014");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (HR_Emp_Certificates.UpdateDeleteFlagWithCheck(EmployeeCertificateID) == 1)
                {
                    RefreshGrid();
                    BuildGUIEffects.ResetFormTextBoxes(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1015");
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
