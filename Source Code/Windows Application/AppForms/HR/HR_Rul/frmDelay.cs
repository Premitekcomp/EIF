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

namespace TMS.AppForms.HR.HR_Rul
{
    public partial class frmDelay : Form
    {
        int DBRecordSerial = 0;
        public frmDelay()
        {
            InitializeComponent();
        }

        private void frmDelay_Load(object sender, EventArgs e)
        {
            LoadGrid();
            MakeCommonGUITaska(this);
        }

        private void MakeCommonGUITaska(Form PassedFormName)
        {
            try
            {
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

        private void LoadGrid()
        {
            try
            {
                this.hR_Rul_DelayTableAdapter.Fill(this.rulDataSet.HR_Rul_Delay);
            }
            catch { }
        }

        private void CmdRuleDetails_Click(object sender, EventArgs e)
        {
            HR.HR_Rul.frmDelayRulesDetails OpenForm = new HR.HR_Rul.frmDelayRulesDetails();
            if (GlobalEvents.PreventDuplicateLoadFlag(OpenForm.Text) == 1)
            {
                OpenForm.MdiParent = this.ParentForm;
                OpenForm.Show();
            }
        }

        private bool ValidateInputs()
        {

            return true;
        }

        private void ResetInputs()
        {
            AppCode.BuildGUIEffects.ResetFormTextBoxes(this);
            LoadGrid();
            DBRecordSerial = 0;
            CmdCancelUpdate.Visible = false;
            CmdDelete.Visible = false;

            txtDelayRuleNameAr.Focus();
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (DBRecordSerial == 0)
            {
                if (AppCode.DAL.HR.HR_Rules.InsertNewDelayRule(txtDelayRuleNameAr.Text, txtNotes.Text) == 1)
                {
                    lblMsg.Text = "تم الحفظ بنجاح";
                    lblMsg.ForeColor = GlobalParamters.SuccessColor;
                    ResetInputs();
                }
                else
                {
                    lblMsg.Text = "خطأ اثناء عمليه الحفظ";
                    lblMsg.ForeColor = GlobalParamters.FaildColor;
                }
            }
            else
            {
                if (AppCode.DAL.HR.HR_Rules.UpdateDelayRule(txtDelayRuleNameAr.Text, txtNotes.Text, DBRecordSerial) == 1)
                {
                    lblMsg.Text = "تم التحديث بنجاح";
                    lblMsg.ForeColor = GlobalParamters.SuccessColor;
                    ResetInputs();
                }
                else
                {
                    lblMsg.Text = "خطأ اثناء عمليه التحديث";
                    lblMsg.ForeColor = GlobalParamters.FaildColor;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBRecordSerial != 0)
            {

            }
        }

        private void CmdCancelUpdate_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void gvForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DBRecordSerial = Convert.ToInt32(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDelayRuleNameAr.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNotes.Text= gvForm.Rows[e.RowIndex].Cells[2].Value.ToString();

                CmdCancelUpdate.Visible = true;
                //CmdDelete.Visible = true;
            }
        }
    }
}
