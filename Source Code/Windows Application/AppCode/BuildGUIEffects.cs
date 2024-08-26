using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppCode
{
    class BuildGUIEffects
    {
        public static void MakeFormLabelsTranparent(Form FormName, Control ParentName)
        {
            // Assign all Label a Transparent Background
            try
            {
                foreach (Label LabelsNForm in FormName.Controls.OfType<Label>().ToArray())
                {
                    LabelsNForm.Parent = ParentName;
                    LabelsNForm.BackColor = Color.Transparent;
                    LabelsNForm.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void MakeFormPictureBoxTranparent(Form FormName, Control ParentName)
        {
            // Set Picture Box Background color to transparent

            try
            {
                foreach (PictureBox PBoxNForm in FormName.Controls.OfType<PictureBox>().ToArray())
                {
                    PBoxNForm.Parent = ParentName;
                    PBoxNForm.BackColor = Color.Transparent;
                }
            }
            catch { }

        }

        public static void MakeFormGroupBoxTransparent(Form FormName, Control ParentName)
        {
            try
            {
                foreach (GroupBox GBoxNForm in FormName.Controls.OfType<GroupBox>().ToArray())
                {
                    GBoxNForm.Parent = ParentName;
                    GBoxNForm.BackColor = Color.Transparent;
                    GBoxNForm.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void ChangeActiveControlBGColor(Control ActiveControlName, int RaisedAction)
        {
            try
            {
                if (RaisedAction == 1)
                {
                    ActiveControlName.BackColor = GlobalParamters.ActiveControlBGColor;
                }
                else
                {
                    ActiveControlName.BackColor = GlobalParamters.InActiveControlBGColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void FormNavigation(Form FormName, System.Windows.Forms.KeyEventArgs KeyClicked)
        {
            try
            {
                if (KeyClicked.KeyCode == Keys.Enter)
                {
                    FormName.SelectNextControl(FormName.ActiveControl, true, true, true, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void ResetFormControls(Form FormName)
        {
            // Reset Controls in Form
            try
            {
                foreach (TextBox TBoxNForm in FormName.Controls.OfType<TextBox>().ToArray())
                {
                    TBoxNForm.Text = "";
                }

                foreach (ComboBox ComboNForm in FormName.Controls.OfType<ComboBox>().ToArray())
                {
                    ComboNForm.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        public static void ResetFormTextBoxes(Form FormName)
        {
            // Reset Controls in Form
            try
            {
                foreach (TextBox TBoxNForm in FormName.Controls.OfType<TextBox>().ToArray())
                {
                    TBoxNForm.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }
        public static void ResetGroupBoxControls(GroupBox GroupBoxName)
        {
            try
            {
                foreach (TextBox TBoxNForm in GroupBoxName.Controls.OfType<TextBox>().ToArray())
                {
                    TBoxNForm.Text = "";
                }

                foreach (ComboBox ComboNForm in GroupBoxName.Controls.OfType<ComboBox>().ToArray())
                {
                    ComboNForm.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, GlobalParamters.MsgTitle);
            }
        }

        //Load Sidebar Forms

        //Public Function LoadSideBarForms(ByVal FormGroupID As Integer)
        //SQLStatment = "Select * from Per_FormsList where FormGroupID=@FormGroupID order by DisplayOrder"
        //Dim SQLCommand As New SqlCommand(SQLStatment, DBConnection)
        //SQLCommand.Parameters.AddWithValue("@FormGroupID", FormGroupID)

        //If DBConnection.State = ConnectionState.Closed Then DBConnection.Open()
        //Dim DataR As SqlDataReader = SQLCommand.ExecuteReader()

        //Dim RecordFlag As Integer = 0
        //frmMother.SidebarListView.Clear()

        //Do While DataR.Read
        //    frmMother.SidebarListView.Items.Add(DataR.GetValue(1))
        //    frmMother.SidebarListView.Items(RecordFlag).Name = DataR.GetValue(2)
        //    frmMother.SidebarListView.Items(RecordFlag).ImageIndex = DataR.GetInt16(4)
        //    RecordFlag = RecordFlag + 1
        //Loop
        //DataR.Close()

        //End Function

    }
}
