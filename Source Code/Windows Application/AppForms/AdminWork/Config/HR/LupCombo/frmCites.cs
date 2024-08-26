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
    public partial class frmCites : Form
    {
        public frmCites()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;
        private void frmCites_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Lup_CountriesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Countries);

                RefreshGrid();
            }
            catch (Exception)
            {

            }

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


        private void cbCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (Updated == false)
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Cites.InsertRecord(txtNameAr.Text, txtNameEn.Text, txtCallKey.Text, Convert.ToInt32(cbCountryID.SelectedValue));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
                        txtNameAr.Focus();
                    }
                }
                else
                {
                    if (IsValed())
                    {

                        int mb = HR_Lup_Cites.UpdateRecord(SelectedID, txtNameAr.Text, txtNameEn.Text, txtCallKey.Text, Convert.ToInt32(cbCountryID.SelectedValue));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                            btnAddNew.Text = "حفظ / جديد";
                            Updated = false;
                            btnAddClose.Enabled = true;
                            txtCallKey.Text = "0";
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
                        int mb = HR_Lup_Cites.InsertRecord(txtNameAr.Text, txtNameEn.Text, txtCallKey.Text, Convert.ToInt32(cbCountryID.SelectedValue));
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
            dt = HR_Lup_Cites.SelectByPK(SelectedID);
            txtNameAr.Text = dt.Rows[0][1].ToString();
            txtNameEn.Text = dt.Rows[0][2].ToString();
            txtCallKey.Text = dt.Rows[0][3].ToString();
            cbCountryID.SelectedValue = Convert.ToInt32(dt.Rows[0][4].ToString());
            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }


        private void RefreshGrid()
        {
            try
            {
                this.hR_Lup_Cites1TableAdapter.FillCitysByCuntry(this.LupDataSet.HR_Lup_Cites1, ((byte)(System.Convert.ChangeType(cbCountryID.SelectedValue, typeof(byte)))));

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
            if (cbCountryID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب اختيار اسم الدولة";
                txtNameAr.Focus();
                return false;
            }
            //if (txtNameAr.Text == "")
            //{
            //    lblMbox.Text = "يجب ادخال اسم المدينة بالغلة العربية";
            //    txtNameAr.Focus();
            //    return false;
            //}
            //if (txtCallKey.Text == "")
            //{
            //    lblMbox.Text = "يجب ادخال مفتاح الاتصال";
            //    txtNameAr.Focus();
            //    return false;
            //}
            
            return true;
            
        }



    }
}
