using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppCode
{
    public  class ValidationClass
    {
        //Clear Controls
        public static void ClearControls(Form control)
        {
            foreach (Control c in control.Controls)
            {

                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex= -1;
                }

                
            }
            //ValidationClass.ClearControls(this);
        }
        public static void ClearControlsWithoutComboBox(Form control)
        {
            foreach (Control c in control.Controls)
            {

                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                //if (c is ComboBox)
                //{
                //    ((ComboBox)c).SelectedIndex= -1;
                //}


            }
            //ValidationClass.ClearControls(this);
        }
        //Required Controls 
        public static int RequiredControls(Control [] newcontrol)
        {
            int result=0;
            for (int inti = 0; inti < newcontrol.Length; inti++)
            {
                if (newcontrol[inti].Text == string.Empty)
                {
                    newcontrol[inti].Focus();
                    newcontrol[inti].BackColor = Color.GreenYellow;
                    result = 1;
                }
            }
            return result;



       //private int  ValidateForm()
       //{
       // // Check Mandtory Fiedls
            //Control[] newcontrol = new Control[] { txt_ExpenseReceiptNo, dTP_ExpenseDate, txt_Value, lup_ExpenseGroupComboBox, lup_EmployeesComboBox, lup_InventoryListComboBox };
            //return ValidationClass.RequiredControls(newcontrol); 

       // //    // Check Duplication in Rec. No
       // }


        }

        public static bool dateValidate(Form control)
        {
            bool result = true;
            foreach (Control c in control.Controls)
            {
                if (c is DateTimePicker)
                {
                    DateTime inputdate = Convert.ToDateTime(((DateTimePicker)c).Text);
                    DateTime actualDateTime = DateTime.Now;
                    if (inputdate > actualDateTime)
                    {
                        result = false; 
                    }
                }
            }
           return result ;
        }



    }
}

   

