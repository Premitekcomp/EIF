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

namespace TMS.AppForms.HR.HR_Tra
{
    public partial class frmVacation : Form
    {
        int EmployeeVacationID;
        int btnAddFlag = 0;
        int VacationLength = 0;


        public frmVacation()
        {
            InitializeComponent();
        }


        // Check Mandtory Fiedls
        private int ValidateForm()
        {
            Control[] newcontrol = new Control[] { CbEmpID, cbVacationTypeID, dtFromDate ,dtToDate};
            return ValidationClass.RequiredControls(newcontrol);
        }


        private void frmVacation_Load(object sender, EventArgs e)
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
            
            this.hR_Lup_VacationTypesTableAdapter.FillAll(this.lupDataSet.HR_Lup_VacationTypes);
            
            this.lup_EmpNameListTableAdapter.FillActiveEmp(this.empDataSet.Lup_EmpNameList);
            //CbEmpID.SelectedIndex = -1;
            RefreshGrid();
        }

        private void CbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                if (CbEmpID.SelectedIndex != -1)
                {
                    this.grid_Tra_VacationsTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Vacations, ((short)(System.Convert.ChangeType(CbEmpID.SelectedValue, typeof(short)))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        // To Add Or Update
        private void btnadd_Click(object sender, EventArgs e)
        {
            try 
	        {
	            if (ValidateForm() == 0) // Check Mandtory Fields
                {
                    if (VacationLength == 0)
                    {
                        txtVacationLengthMethod();
                    }
                    if (VacationLength == 1 || VacationLength > 1)
                    {
                        if (btnAddFlag == 0)
                        {
                            InsertMethod();
                            lblMsg.Text = "تم الحفظ بنجاح";

                        }
                        else if (btnAddFlag == 1)
                        {
                            UpdateRecordMethod();
                            lblMsg.Text = "تم التعديل بنجاح";
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء التأكد من التاريخ");  
                    }
                }
                else
                {
                    lblMsg.Text = "برجاء ادخال جميع الحقول";
                }
		
	        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1005");
            }
        }

        //To Insert
        private void InsertMethod()
        {
            if ( HR_Tra_Vacations.InsertRecord(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(cbVacationTypeID.SelectedValue), dtFromDate.Value, dtToDate.Value, Convert.ToInt32(txtVacationLength.Text), txtNotes.Text) == 1 )
            {
                ValidationClass.ClearControlsWithoutComboBox(this);
                RefreshGrid();
                this.grid_Tra_VacationsTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Vacations, Convert.ToSByte(CbEmpID.SelectedValue));

                // Update Trans
                DateTime VacationStart = Convert.ToDateTime(dtFromDate.Value.ToShortDateString());
                DateTime VacationEnd = Convert.ToDateTime(dtToDate.Value.ToShortDateString());

                DataTable AttendanceSheet = new DataTable();
                AttendanceSheet = HR_Basics.GetVacationAttandanceList(Convert.ToInt32(CbEmpID.SelectedValue), VacationStart, VacationEnd);

                foreach (DataRow r in AttendanceSheet.Rows)
                {
                    //r["CategoryID"].ToString()
                    HR_Basics.UpdateVacation(Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToDateTime(r["AttendanceDate"].ToString()), Convert.ToInt32(cbVacationTypeID.SelectedValue));
                }
                //txtVacationLengthMethod();

                //for (int i = 0; i < VacationLength; i++)
                //{
                //    TimeSpan ByDay = new TimeSpan(1 * i, 0, 0, 0);
                //    DateTime AccumaltedDate = VacationStart + ByDay;
                //    // Update Vacation Field
                //}

            }
            else
            {
                lblMsg.Text = "برجاء المحاولة مرة اخرى";
            }
           
        }

        private void GrdVacation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EmployeeVacationID = int.Parse(GrdVacation.Rows[e.RowIndex].Cells[0].Value.ToString());

                dtFromDate.Value = Convert.ToDateTime(GrdVacation.Rows[e.RowIndex].Cells[3].Value.ToString());
                dtToDate.Value = Convert.ToDateTime(GrdVacation.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtVacationLength.Text = GrdVacation.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNotes.Text = GrdVacation.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbVacationTypeID.Text = GrdVacation.Rows[e.RowIndex].Cells[8].Value.ToString();
                btnAddFlag = 1;
                ChangeControlByFlags(1);
            }
        }

        //Flag
        private void ChangeControlByFlags(int btnAddFlag)
        {
            if (btnAddFlag == 0)
            {
                 btnadd.Text = "إضافة";
                 btnDelete.Visible = false;
                 btnCansel.Visible = false;
            }
            else if (btnAddFlag == 1)
            {
                btnadd.Text = "تعديل";
                btnDelete.Visible = true;
                btnCansel.Visible = true;
            }

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            ChangeControlByFlags(0);
            ValidationClass.ClearControls(this);
        }

        //To Calculate VacationLength
        private void dtFromDate_Leave(object sender, EventArgs e)
        {
            txtVacationLengthMethod();
        }

        //To Calculate VacationLength
        private void dtToDate_Leave(object sender, EventArgs e)
        {
            txtVacationLengthMethod();
        }

        //To Calculate VacationLength
        private void txtVacationLengthMethod()
        {
            try
            {
                DateTime VacFrom = dtFromDate.Value;
                DateTime VacTo = dtToDate.Value;
                int VacLength = Convert.ToInt32((VacTo - VacFrom).TotalDays);
                txtVacationLength.Text = (VacLength + 1).ToString();
                VacationLength = Convert.ToInt32(txtVacationLength.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1007");
            }
      
            
        }

        //To Clear Controls 
        private void ClearControlsAfterSave()
        {
            ValidationClass.ClearControls(this);
        }

        // To delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDeleteMethod();
                lblMsg.Text = "تم الحذف";
                ChangeControlByFlags(0);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1006");
            }
      
        }

        private void UpdateDeleteMethod()
        {
            if (HR_Tra_Vacations.UpdateDeleteFlagWithCheck(EmployeeVacationID) != 0)
            {
                ValidationClass.ClearControlsWithoutComboBox(this);
                this.grid_Tra_VacationsTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Vacations, Convert.ToSByte(CbEmpID.SelectedValue));
            }
            else
            {
                lblMsg.Text = "برجاء المحاولة مرة اخرى";
            }

        }

        private void UpdateRecordMethod()
        {
            if (HR_Tra_Vacations.UpdateRecord(EmployeeVacationID, Convert.ToInt32(CbEmpID.SelectedValue), Convert.ToInt32(cbVacationTypeID.SelectedValue), dtFromDate.Value, dtToDate.Value, Convert.ToInt32(txtVacationLength.Text), txtNotes.Text) != 0)
            {
                ValidationClass.ClearControlsWithoutComboBox(this);
               this.grid_Tra_VacationsTableAdapter.FillByEmpID(this.traDataSet.Grid_Tra_Vacations, Convert.ToSByte(CbEmpID.SelectedValue));
            }
            else
            {
                lblMsg.Text = "برجاء المحاولة مرة اخرى";
            }

        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {

        }       
    }
}
