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
    public partial class frmDelayRulesDetails : Form
    {
        int DBRecordSerial = 0;
        public frmDelayRulesDetails()
        {
            InitializeComponent();
        }

        private void frmDelayRulesDetails_Load(object sender, EventArgs e)
        {
            try
            {
                this.hR_Rul_DelayTableAdapter.Fill(this.rulDataSet.HR_Rul_Delay);
            }
            catch { }

            MakeCommonGUITaska(this);
            txtDelayRuleID.SelectedIndex = -1;
        }

        private void ValidateNonDecimal(object sender, KeyPressEventArgs e)
        {
            if (DataValidation.CheckNonDecimalNumber(e) == 1)
            {
                e.Handled = true;
            }
        }

        private void ValidateDecimal(object sender, KeyPressEventArgs e)
        {
            if (DataValidation.CheckDeciamlNumber(sender, e) == 1)
            {
                e.Handled = true;
            }
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

        private void LoadFilterdGrid()
        {
            if (txtDelayRuleID.SelectedIndex != -1 && DBRecordSerial == 0)
            {
                try
                {
                    this.hR_Rul_DelayRulesDetailsTableAdapter.FillByID(this.rulDataSet.HR_Rul_DelayRulesDetails, Convert.ToInt32(txtDelayRuleID.SelectedValue));
                }
                catch { }
            }
        }

        private void ResetInputs()
        {
            LoadFilterdGrid();
            DBRecordSerial = 0;
            AppCode.BuildGUIEffects.ResetFormTextBoxes(this);

        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {

            if (DBRecordSerial == 0)
            {
                if (AppCode.DAL.HR.HR_Rules.InsertNewDelayRuleDetails(Convert.ToInt32(txtDelayRuleID.SelectedValue), Convert.ToInt32(txtFromMinute.Text), Convert.ToInt32(txtToMinute.Text), Convert.ToInt32(txtValue.Text)) == 1)
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
                if (AppCode.DAL.HR.HR_Rules.UpdateNewDelayRuleDetails(Convert.ToInt32(txtDelayRuleID.SelectedValue), Convert.ToInt32(txtFromMinute.Text), Convert.ToInt32(txtToMinute.Text), Convert.ToInt32(txtValue.Text), DBRecordSerial) == 1)
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

        private void CmdCancelUpdate_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void txtDelayRuleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilterdGrid();
        }
    }
}
