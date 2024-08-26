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
    public partial class frmEmploymentDegree : Form
    {
        int EmployeeDegreeID;
        int btnAddFlag = 0;


        public frmEmploymentDegree()
        {
            InitializeComponent();
        }

        private void frmEmploymentDegree_Load(object sender, EventArgs e)
        {
            
            this.combo_ExternalIDTableAdapter.Fill(this.empDataSet.Combo_ExternalID);
            
            try
            {
                this.hR_Lup_DegreesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Degrees);
                this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
                RefreshGrid();
            }
            catch { }

            MakeCommonGUITaska(this, PictureBG);
            IsCurrent.Parent = this.PictureBG;
            IsCurrent.BackColor = Color.Transparent;
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
                    this.grid_Emp_EmploymentDegreeTableAdapter.FillByEmpID(this.empDataSet.Grid_Emp_EmploymentDegree, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
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


        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EmployeeDegreeID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                CbEmpID.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDegreeID.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtFromDate.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[3].Value.ToString());
                dtEndDate.Value = DateTime.Parse(gvForm.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtNote.Text = gvForm.Rows[e.RowIndex].Cells[6].Value.ToString();

                btnAddFlag = 1;
                ChangeControlByFlags(1);
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
                        CloseLastEmpDegreeMethod();
                        InsertMethod();
                        RefreshGrid();
                        ValidationClass.ClearControlsWithoutComboBox(this);
                        CbEmpID.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                     if (EmptyOrNot())
                    {
                        UpdateMethod();
                        RefreshGrid();
                        ValidationClass.ClearControlsWithoutComboBox(this);
                        CbEmpID.Focus();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1008");
            }
        }

        private void CloseLastEmpDegreeMethod()
        {
            if (IsCurrent.Checked == true)
            {
                HR_Emp_EmploymentDegree.UpdateIsCurrentFlag(Convert.ToInt32(CbEmpID.SelectedValue));    
            }

            
        }

        private void InsertMethod()
        {
            if (HR_Emp_EmploymentDegree.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(txtDegreeID.SelectedValue), dtFromDate.Value, dtEndDate.Value, IsCurrent.Checked, txtNote.Text)!=0)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Emp_EmploymentDegree.UpdateRecord(EmployeeDegreeID,Convert.ToInt32(CbEmpID.SelectedValue),Convert.ToInt32(txtDegreeID.SelectedValue), dtFromDate.Value, dtEndDate.Value, IsCurrent.Checked, txtNote.Text) != 0)
            {
                lblMsg.Text = "تم التعديل بنجاح";
                btnAddFlag = 0;
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

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (btnAddFlag == 1)
            {
                btnAddFlag = 0;
                ChangeControlByFlags(0);
            }
            else if (btnAddFlag == 0)
            {
                try
                {
                    //To Save
                    if (btnAddFlag == 0)
                    {
                        if (EmptyOrNot())
                        {
                            CloseLastEmpDegreeMethod();
                            InsertMethod();
                            MessageBox.Show("تم الحفظ بنجاح");
                            this.Close();
                        }
                    }
                    else if (btnAddFlag == 1)
                    {
                        if (EmptyOrNot())
                        {
                            UpdateMethod();
                            MessageBox.Show("تم التعديل بنجاح");
                            this.Close();
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "1009");
                }
            }
        }


        private bool EmptyOrNot()
        {
            if (CbEmpID.Text=="")
            {
                lblMsg.Text = "من فضلك اختر الموظف";
                CbEmpID.Focus();
                return false;
            }
            else if (txtDegreeID.Text == "")
            {
                lblMsg.Text = "من فضلك اختر الدرجة الوظيفية";
                txtDegreeID.Focus();
                return false;
            }

            else 
            {
                return true;
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
