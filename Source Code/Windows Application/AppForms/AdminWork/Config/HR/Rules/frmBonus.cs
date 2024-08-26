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
    public partial class frmBonus : Form
    {
        public frmBonus()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;

        private void frmBonus_Load(object sender, EventArgs e)
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


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updated == false)
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Bonus.InsertRecord(txtBonusNameAr.Text ,txtBonusNameEn.Text , chbByDay.Checked , chbByAmount.Checked, decimal.Parse( txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
                        txtBonusNameAr.Focus();
                    }
                }
                else
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Bonus.UpdateRecord(SelectedID, txtBonusNameAr.Text, txtBonusNameEn.Text, chbByDay.Checked, chbByAmount.Checked, decimal.Parse(txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            btnAddNew.Text = "حفظ / جديد";
                            Updated = false;
                            btnAddClose.Enabled = true;
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
                        int mb = HR_Lup_Bonus.InsertRecord(txtBonusNameAr.Text, txtBonusNameEn.Text, chbByDay.Checked, chbByAmount.Checked, decimal.Parse(txtValue.Text));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);

                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = HR_Lup_Bonus.SelectByPK(SelectedID);
            txtBonusNameAr.Text = dt.Rows[0][1].ToString();
            txtBonusNameEn.Text = dt.Rows[0][2].ToString();
            chbByAmount.Checked = Convert.ToBoolean(dt.Rows[0][4].ToString());
            chbByDay.Checked = Convert.ToBoolean(dt.Rows[0][3].ToString());
            txtValue.Text = dt.Rows[0][5].ToString();
            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }


        private void RefreshGrid()
        {
            try
            {
                this.hR_Lup_BonusTableAdapter.FillAll(this.lupDataSet.HR_Lup_Bonus);
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
            if (txtBonusNameAr.Text == "")
            {
                lblMbox.Text = "يجب ادخال الأسم باللغة العربية";
                txtBonusNameAr.Focus();
                return false;
            }
            if (txtValue.Text == "")
            {
                txtValue.Text = "0";
                //lblMbox.Text = "يجب ادخال قيمة العلاوة ";
                //txtValue.Focus();
                //return false;
            }

            //if (chbByAmount.Checked == false && chbByDay.Checked== false)
            //{
            //    lblMbox.Text = "طريقة حساب العلاوة ";
            //    return false;
            //}
            
            return true;
            
        }


    }
}
