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
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;


        private void frmCountries_Load(object sender, EventArgs e)
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
                        int mb = HR_Lup_Countries.InsertRecord(txtInitial.Text, txtNameAr.Text, txtNameEn.Text, txtNationalityTitle.Text, txtCallKey.Text);
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
                        txtCallKey.Focus();
                    }
                }
                else
                {
                    if (IsValed())
                    {

                        int mb = HR_Lup_Countries.UpdateRecord(SelectedID, txtInitial.Text, txtNameAr.Text, txtNameEn.Text, txtNationalityTitle.Text, txtCallKey.Text);
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




        private void RefreshGrid()
        {
            try
            {
                // TODO: This line of code loads data into the 'lupDataSet.HR_Lup_Countries' table. You can move, or remove it, as needed.
                this.hR_Lup_CountriesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Countries);
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

            if (txtInitial.Text == "")
            {
                lblMbox.Text = "يجب ادخال اسم الحروف الاولى ";
                txtInitial.Focus();
                return false;
            }
            if (txtNameAr.Text == "")
            {
                lblMbox.Text = "يجب ادخال اسم الدولة بالغة العربية ";
                txtNameAr.Focus();
                return false;
            }
            if (txtNationalityTitle.Text == "")
            {
                lblMbox.Text = "يجب ادخال الجنسية ";
                txtNationalityTitle.Focus();
                return false;
            }
            if (txtCallKey.Text == "")
            {
                lblMbox.Text = "يجب ادخال كود الاتصال ";
                txtCallKey.Focus();
                return false;
            }
            else
            {
                return true;
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
                        int mb = HR_Lup_Countries.InsertRecord(txtInitial.Text, txtNameAr.Text, txtNameEn.Text, txtNationalityTitle.Text, txtCallKey.Text);
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
            dt = HR_Lup_Countries.SelectByPK(SelectedID);
            txtInitial.Text = dt.Rows[0][1].ToString();
            txtNameAr.Text = dt.Rows[0][2].ToString();
            txtNameEn.Text = dt.Rows[0][3].ToString();
            txtNationalityTitle.Text = dt.Rows[0][4].ToString();
            txtCallKey.Text = dt.Rows[0][5].ToString();

            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }




    }
}
