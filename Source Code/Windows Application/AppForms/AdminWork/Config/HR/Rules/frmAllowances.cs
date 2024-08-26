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

namespace TMS.AppForms.AdminWork.Config.HR.Rules
{
    public partial class frmAllowances : Form
    {
        public frmAllowances()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;


        private void frmAllowances_Load(object sender, EventArgs e)
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


        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updated == false)
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Allowances.InsertRecord(txtAllowanceNameAr.Text,txtAllowanceNameEn.Text ,chbIsMonthly.Checked , chbInTax.Checked , chbInInsurance.Checked , chbInPenalty.Checked,Convert.ToDecimal(txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);

                    }
                }
                else
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Allowances.UpdateRecord(SelectedID ,txtAllowanceNameAr.Text, txtAllowanceNameEn.Text, chbIsMonthly.Checked, chbInTax.Checked, chbInInsurance.Checked, chbInPenalty.Checked, Convert.ToDecimal(txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            btnAddNew.Text = "حفظ / جديد";
                            Updated = false;
                            btnAddClose.Enabled = true;
                            txtValue.Text = "0";
                            txtAllowanceNameAr.Focus();
                        }
                        GetMbox(mb);

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAddClose_Click(object sender, EventArgs e)
        {
            try
            {
                                
                if (Updated == false)
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Allowances.InsertRecord(txtAllowanceNameAr.Text,txtAllowanceNameEn.Text ,chbIsMonthly.Checked , chbInTax.Checked , chbInInsurance.Checked , chbInPenalty.Checked,Convert.ToDecimal(txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            this.Close();
                        }
                        GetMbox(mb);

                    }
                }
            }
            catch (Exception)
            {
            }
        }



        private void RefreshGrid()
        {
            try
            {
                // TODO: This line of code loads data into the 'lupDataSet.HR_Lup_Allowances' table. You can move, or remove it, as needed.
                this.hR_Lup_AllowancesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Allowances);
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void GetMbox(int resalt)
        {
            if (resalt == 1)
            {
                RefreshGrid();
                lblMbox.Text = "تم الحفظ";
            }
            else
            {
                lblMbox.Text = "حدث خطاء اثناء العملية يرجى المحاولة مرة اخرى";
            }
        }

        public bool IsValed()
        {
            if (txtAllowanceNameAr.Text == "")
            {
                lblMbox.Text = "يجب ادخال اسم البدل بالغلة العربية";
                txtAllowanceNameAr.Focus();
                return false;
            }
            if (txtValue.Text == "")
            {
                txtValue.Text = "0";
                //lblMbox.Text = "يجب ادخال اسم البدل بالغلة العربية";
                //txtValue.Focus();
                //return false;
            }
            //if (chbInTax.Checked == false && chbInPenalty.Checked == false && chbInInsurance.Checked == false)
            //{
            //    lblMbox.Text = "يجب ااختيار نوع البدل";
            //    return false;
            //}

            return true;
            
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = HR_Lup_Allowances.SelectByPK(SelectedID);
            txtAllowanceNameAr.Text = dt.Rows[0][1].ToString();
            txtAllowanceNameEn.Text = dt.Rows[0][2].ToString();
            chbIsMonthly.Checked = Convert.ToBoolean(dt.Rows[0][3].ToString());
            chbInTax.Checked = Convert.ToBoolean(dt.Rows[0][4].ToString());
            chbInInsurance.Checked = Convert.ToBoolean(dt.Rows[0][5].ToString());
            chbInPenalty.Checked = Convert.ToBoolean(dt.Rows[0][6].ToString());
            txtValue.Text = dt.Rows[0][7].ToString();

            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }







    }
}
