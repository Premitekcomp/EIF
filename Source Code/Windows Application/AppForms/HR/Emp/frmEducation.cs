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
    public partial class frmEducation : Form
    {
        public frmEducation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variables
        /// </summary>
        /// <param name="resalt"></param>
        public int SelectedID;
        public bool Updated = false;

        private void frmEducation_Load(object sender, EventArgs e)
        {
            
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            try
            {
                this.hR_Lup_QualificationsTypesTableAdapter.FillAll(this.lupDataSet.HR_Lup_QualificationsTypes);
                

                this.hR_Lup_FacultiesTableAdapter.FillAll(this.lupDataSet1.HR_Lup_Faculties);
                this.hR_Lup_EduSectionsTableAdapter.FillAll(this.lupDataSet.HR_Lup_EduSections);
                this.hR_Lup_UniversitiesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Universities);
                
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
                    this.grid_EmpEducationTableAdapter.FillByEmpID(this.empDataSet.Grid_EmpEducation, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
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
                        int mb = HR_Emp_Education.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtQualificationNameID.SelectedValue), Convert.ToInt32(txtUniversityID.SelectedValue), Convert.ToInt32(txtFacultyID.SelectedValue), Convert.ToInt32(txtSectionNameID.SelectedValue), int.Parse(txtQualificationYear.Text),txtNotes.Text);
                        if (mb == 1)
                        {

                            TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                            RefreshGrid();
                            CbEmpID.Focus();
                        }
                        GetMbox(mb);
                    }
                }
                if (Updated == true)
                {
                    if (IsValed())
                    {
                        int mb = HR_Emp_Education.UpdateRecord(SelectedID, Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtQualificationNameID.SelectedValue), Convert.ToInt32(txtUniversityID.SelectedValue), Convert.ToInt32(txtFacultyID.SelectedValue), Convert.ToInt32(txtSectionNameID.SelectedValue), int.Parse(txtQualificationYear.Text), txtNotes.Text);
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
            }
            catch (Exception)
            {}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updated == true)
                {
                    int mb = HR_Emp_Education.UpdateDeleteFlagWithCheck(SelectedID);
                    if (mb == 1)
                    {
                        TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                        RefreshGrid();
                        Updated = false;
                        btnDelete.Visible = false;
                        btnSaveNew.Text = "حفظ / جديد";
                        btnSaveClose.Visible = true;
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
                    int mb = HR_Emp_Education.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtQualificationNameID.SelectedValue), Convert.ToInt32(txtUniversityID.SelectedValue), Convert.ToInt32(txtFacultyID.SelectedValue), Convert.ToInt32(txtSectionNameID.SelectedValue), int.Parse(txtQualificationYear.Text), txtNotes.Text);
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

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                TMS.AppCode.ValidationClass.ClearControlsWithoutComboBox(this);
                SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataTable dt = new DataTable();
                dt = HR_Emp_Education.SelectByPK(SelectedID);
                CbEmpID.SelectedValue = dt.Rows[0][1].ToString();
                txtQualificationNameID.SelectedValue = dt.Rows[0][2].ToString();
                txtUniversityID.SelectedValue = dt.Rows[0][3].ToString();
                txtFacultyID.SelectedValue = dt.Rows[0][4].ToString();
                txtSectionNameID.SelectedValue = dt.Rows[0][5].ToString();
                txtQualificationYear.Text = dt.Rows[0][6].ToString();
                txtNotes.Text = dt.Rows[0][7].ToString(); 

                Updated = true;
                btnDelete.Visible = true;
                btnSaveNew.Text = "تعديل";
                btnSaveClose.Visible = false;
                btnDelete.Visible =  true;
                //RefreshGrid();
            }
            catch (Exception)
            {
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
            if (txtQualificationNameID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار المؤهل";
                txtQualificationNameID.Focus();
                return false;
            }
            if (txtUniversityID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار الجامعة";
                txtUniversityID.Focus();
                return false;
            }
            if (txtFacultyID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار الكلية";
                txtFacultyID.Focus();
                return false;
            }
            if (txtSectionNameID.SelectedIndex == -1)
            {
                lblMsg.Text = "يجب اختيار التخصص";
                txtSectionNameID.Focus();
                return false;
            }
            if (txtQualificationYear.Text == "")
            {
                lblMsg.Text = "يجب ادخال سنة التخرج ";
                txtQualificationYear.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtQualificationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEmpID.SelectedIndex != -1)
            {
                CbEmpID.SelectedValue = txtEmpID.SelectedValue;
            }
        }

        private void txtQTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtQTypeID.SelectedIndex != -1 && Updated != true)
            {
                this.hR_Lup_QualificationNamesTableAdapter.FillByQualificationTypeID(this.lupDataSet.HR_Lup_QualificationNames, Convert.ToByte(txtQTypeID.SelectedValue));
            }
        }

    }
}
