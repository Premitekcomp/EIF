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

namespace TMS.AppForms.AdminWork.Config.HR.HRItems
{
    public partial class frmDegrees : Form
    {
        public frmDegrees()
        {
            InitializeComponent();
        }
        public int SelectedID;
        public bool Updated = false;
        private void frmDegrees_Load(object sender, EventArgs e)
        {
           
            this.hR_Lup_EmplymentGroupTableAdapter.FillAll(this.lupDataSet.HR_Lup_EmplymentGroup);

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
                        int mb = HR_Lup_Degrees.InsertRecord(txtDegreeNameAr.Text, txtDegreeNameEn.Text, Convert.ToInt32(cbEmpGroupID.SelectedValue.ToString()));
                        if (mb == 1)
                        {
                            BuildGUIEffects.ResetFormTextBoxes(this);
                            RefreshGrid();
                        }
                        GetMbox(mb);
                        txtDegreeNameAr.Focus();
                    }
                }
                else
                {
                    if (IsValed())
                    {
                        int mb = HR_Lup_Degrees.UpdateRecord(SelectedID, txtDegreeNameAr.Text, txtDegreeNameEn.Text, Convert.ToInt32(cbEmpGroupID.SelectedValue.ToString())); 
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
                        int mb = HR_Lup_Degrees.InsertRecord(txtDegreeNameAr.Text, txtDegreeNameEn.Text, Convert.ToInt32(cbEmpGroupID.SelectedValue));
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
            dt = HR_Lup_Degrees.SelectByPK(SelectedID);
            txtDegreeNameAr.Text = dt.Rows[0][1].ToString();
            txtDegreeNameEn.Text = dt.Rows[0][2].ToString();
            cbEmpGroupID.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());
            btnAddNew.Text = "تعديل";
            Updated = true;
            btnAddClose.Enabled = false;
        }


        private void RefreshGrid()
        {
            try
            {
                // TODO: This line of code loads data into the 'lupDataSet.HR_Lup_Degrees' table. You can move, or remove it, as needed.
                this.hR_Lup_DegreesTableAdapter.FillAll(this.lupDataSet.HR_Lup_Degrees);
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
            if (txtDegreeNameAr.Text == "")
            {
                lblMbox.Text = "يجب ادخال اسم الدرجة العلمية بالغلة العربية";
                txtDegreeNameAr.Focus();
                return false;
            }
            if (cbEmpGroupID.SelectedIndex == -1)
            {
                lblMbox.Text = "يجب اختبار اسم مجموعة الموظفين";
                cbEmpGroupID.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
