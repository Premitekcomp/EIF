using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.AppCode.BLL;

namespace TMS.AppCode
{
    class GlobalEvents
    {
        public static void GLobalGUIEvents(Form PassedFormName, Control PassedParent)
        {
            try
            {
                BuildGUIEffects.MakeFormLabelsTranparent(PassedFormName, PassedParent);
                BuildGUIEffects.MakeFormPictureBoxTranparent(PassedFormName, PassedParent);
                BuildGUIEffects.MakeFormGroupBoxTransparent(PassedFormName, PassedParent);

                GlobalEvents.Assign_Handler_to_TextBox_in_Form(PassedFormName);
                GlobalEvents.Assign_Handler_to_ComboBox_in_Form(PassedFormName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void GLobalGUIEventsV2(Form PassedFormName)
        {
            try
            {
                GlobalEvents.Assign_Handler_to_TextBox_in_Form(PassedFormName);
                GlobalEvents.Assign_Handler_to_ComboBox_in_Form(PassedFormName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void ControlBecameActive(object sender, EventArgs e)
        {
            // Detect Clicked Text Box and Send Entered Flag (1) to ChangeActiveControlBGColor Procedure
            //Dim GetClickedButton As Button = DirectCast(sender, Button)
            Control Mo7all = (Control)sender;
            BuildGUIEffects.ChangeActiveControlBGColor(Mo7all, 1);
        }

        public static void ControlBecomeUnActive(System.Object sender, System.EventArgs e)
        {
            // Detect Leaved Text Box and Send Leave Flag (0) to ChangeActiveControlBGColor Procedure
            Control Mo7all = (Control)sender;
            BuildGUIEffects.ChangeActiveControlBGColor(Mo7all, 0);
        }

        public static void Assign_Handler_to_TextBox_in_Form(Form FormName)
        {
            try
            {
                foreach (TextBox TBoxNForm in FormName.Controls.OfType<TextBox>().ToArray())
                {
                    TBoxNForm.Enter += new EventHandler(ControlBecameActive);
                    TBoxNForm.Leave += new EventHandler(ControlBecomeUnActive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void Assign_Handler_to_ComboBox_in_Form(Form FormName)
        {
            try
            {
                foreach (ComboBox ComboBoxNForm in FormName.Controls.OfType<ComboBox>().ToArray())
                {
                    ComboBoxNForm.Enter += new EventHandler(ControlBecameActive);
                    ComboBoxNForm.Leave += new EventHandler(ControlBecomeUnActive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void Assign_Handler_to_TextBox_in_GroupBox(GroupBox GroupBoxName)
        {
            try
            {
                foreach (TextBox TBoxNForm in GroupBoxName.Controls.OfType<TextBox>().ToArray())
                {
                    TBoxNForm.Enter += new EventHandler(ControlBecameActive);
                    TBoxNForm.Leave += new EventHandler(ControlBecomeUnActive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static int PreventDuplicateLoadFlag(string PassedFormName)
        {
            foreach (Form FormItem in Application.OpenForms)
            {
                if (FormItem.Text == PassedFormName)
                {
                    return 0;
                }
            }
            return 1;
        }

        public static int CheckFormAccessPremission(int FormID, int ActionID)
        {
            if (Pre_Authentication.CheckAccessPremission(FormID, ActionID) == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
