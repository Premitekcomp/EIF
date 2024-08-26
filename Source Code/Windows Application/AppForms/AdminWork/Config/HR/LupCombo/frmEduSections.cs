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
    public partial class frmEduSections : Form
    {
        public frmEduSections()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;

        private void frmEduSections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lupDataSet.HR_Lup_QualificationNames' table. You can move, or remove it, as needed.
            this.hR_Lup_QualificationNamesTableAdapter.FillAll(this.lupDataSet.HR_Lup_QualificationNames);
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
                        int mb = HR_Lup_EduSections.InsertRecord(txtSectionNameAr.Text , txtSectionNameEn.Text , Convert.ToInt32(cbQualificationNameID.SelectedValue));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
                        txtSectionNameAr.Focus();
                    }
                }
                else
                {
                    if (IsValed())
                    {

                        int mb = HR_Lup_EduSections.UpdateRecord(SelectedID, txtSectionNameAr.Text, txtSectionNameEn.Text, Convert.ToInt32(cbQualificationNameID.SelectedValue));
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

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
   
        private void RefreshGrid()
        {
            try
            {
                this.hR_Lup_EduSections1TableAdapter.Fill(this.LupDataSet.HR_Lup_EduSections1, ((short)(System.Convert.ChangeType(cbQualificationNameID.SelectedValue, typeof(short)))));
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
            if (txtSectionNameAr.Text == "")
            {
                lblMbox.Text = "يجب ادخال اسم القسم بالغلة العربية";
                txtSectionNameAr.Focus();
                return false;
            }
            if (cbQualificationNameID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب اختيار الشهادة الدراسية";
                txtSectionNameAr.Focus();
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
                        int mb = HR_Lup_EduSections.InsertRecord(txtSectionNameAr.Text, txtSectionNameEn.Text, Convert.ToInt32(cbQualificationNameID.SelectedValue));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
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
                        
            SelectedID = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt = new DataTable();
            dt = HR_Lup_EduSections.SelectByPK(SelectedID);
            txtSectionNameAr.Text = dt.Rows[0][1].ToString();
            txtSectionNameEn.Text = dt.Rows[0][2].ToString();
            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }




    }
}
