using TMS.AppCode;
using TMS.AppCode.BLL;
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
    public partial class frmYearsMonths : Form
    {

        int YearMonthID;
        int btnAddFlag = 0;

        public frmYearsMonths()
        {
            InitializeComponent();
        }

        private void frmYearsMonths_Load(object sender, EventArgs e)
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
                cboClosed.Parent = this.PictureBG;
                cboClosed.ForeColor = Color.White;
                cboClosed.BackColor = Color.Transparent;
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
                
                this.hR_Lup_YearsTableAdapter.FillAll(this.LupDataSet.HR_Lup_Years);
                this.hR_Lup_MonthIndexTableAdapter.FillAll(this.LupDataSet.HR_Lup_MonthIndex);
                if (hR_Lup_YearsComboBox.SelectedIndex != -1)
                { 
                    this.hR_Lup_YearsMonthsTableAdapter.FillByYearID(this.LupDataSet.HR_Lup_YearsMonths, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
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
                this.hR_Lup_YearsMonthsTableAdapter.FillByYearID(this.LupDataSet.HR_Lup_YearsMonths, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
            }
            catch (Exception)
            {}
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
                    YearMonthID = int.Parse(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                    hR_Lup_YearsComboBox.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    hR_Lup_MonthIndexComboBox.Text = gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dTPFromDate.Value = Convert.ToDateTime( gvForm.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dTPToDate.Value =Convert.ToDateTime(  gvForm.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cboClosed.Checked = bool.Parse(gvForm.Rows[e.RowIndex].Cells[5].Value.ToString());
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
            if (hR_Lup_YearsComboBox.SelectedIndex==-1)
            {
                lblMsg.Text = "من فضلك اختر السنة";
                hR_Lup_YearsComboBox.Focus();
                return false;
            }

            if (hR_Lup_MonthIndexComboBox.SelectedIndex == -1)
            {
                lblMsg.Text = "من فضلك اختر الشهر";
                hR_Lup_MonthIndexComboBox.Focus();
                return false;
            }

            if (DataValidation.EnsureDate(dTPToDate.Value, dTPFromDate.Value) == false)
            {
                lblMsg.Text = "من فضلك تأكد من التاريخ";
                dTPFromDate.Focus();
                return false;
            }

            return true;
        }

        private void InsertMethod()
        {
            if (HR_Lup_YearsMonths.InsertRecord(Convert.ToInt32( hR_Lup_MonthIndexComboBox.SelectedValue), Convert.ToInt32(hR_Lup_YearsComboBox.SelectedValue), Convert.ToDateTime( dTPFromDate.Value), Convert.ToDateTime( dTPToDate.Value),cboClosed.Checked) == 1)
            {
                lblMsg.Text = "تم الحفظ بنجاح";
                btnAddFlag = 0;
            }
        }

        private void UpdateMethod()
        {
            if (HR_Lup_YearsMonths.UpdateRecord(YearMonthID, cboClosed.Checked) == 1)
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
                       // RefreshGrid();
                        this.hR_Lup_YearsMonthsTableAdapter.FillByYearID(this.LupDataSet.HR_Lup_YearsMonths, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        hR_Lup_YearsComboBox.Focus();
                    }
                }
                else if (btnAddFlag == 1)
                {
                    if (EmptyOrNot())
                    {
                        UpdateMethod();
                        lblMsg.Text = "تم التعديل بنجاح";
                        ChangeControlByFlags(0);
                        this.hR_Lup_YearsMonthsTableAdapter.FillByYearID(this.LupDataSet.HR_Lup_YearsMonths, Convert.ToByte(hR_Lup_YearsComboBox.SelectedValue));
                        //RefreshGrid();
                        BuildGUIEffects.ResetFormTextBoxes(this);
                        hR_Lup_YearsComboBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "1048");
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
                MessageBox.Show(ex.Message, "1049");
            }
        }


  
    }
}
