using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.AppCode
{
    // Check Mandatory Fields in GroupBox
    // Check Mandatory Fields in Form

    // Check Small    // Check Capital    // Check Numbers    // Check Special Characters
    // Check Language    //Check Mail Format

    // *** ASCII Code Guide
    // Small  : a=97     z=122    // Capital: A=65     Z=90    // Numbers: 0=48     9=57
    // Special Characters: From 0 to 47     and from 58 to 64    and from 91 to 96    and from 123 to 127

    class DataValidation
    {
       
        public static int CheckLang(string TextString)
        {
            GlobalParamters.LogicalChecksFlag = 0;

            //Dim TextLenght As Integer = TextString.Length
            // Dim CatchLetter As String

            //    For x = 1 To TextLenght
            //        CatchLetter = Mid(TextString, x, 1)
            //        If Asc(CatchLetter) < 0 Or Asc(CatchLetter) > 127 Then
            //            LogicalChecksFlag = 1
            //        End If
            //Next

            return GlobalParamters.LogicalChecksFlag;
        }

        public static int CheckMailFormat(string TextString)
        {
            //This Function Return 1 if Check Failed

            GlobalParamters.LogicalChecksFlag = 0;

            if (TextString.Contains("@") || TextString.Contains("."))
            {
                GlobalParamters.LogicalChecksFlag = 0;
            }
            else
            {
                GlobalParamters.LogicalChecksFlag = 1;
            }

            return GlobalParamters.LogicalChecksFlag;

        }
                
        public static int CheckNonDecimalNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return 1;
            }
            return 0;
        }
        
        public static int CheckDeciamlNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                return 1;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                return 1;
            }
            return 0;
        }

        public static bool EnsureTodayToPast(DateTime GivenDate)
        {
            // If GivenDate Before Today Return True
            // If GivenDate After Today Return False

            bool CheckResult = false;
            int DateInterval = ((TimeSpan)(GivenDate - System.DateTime.Today.Date)).Days;
            if (DateInterval <= 0)
            {
                CheckResult = true;
            }
            return CheckResult;
        }

        public static bool EnsureTodayToFuture(DateTime GivenDate)
        {
            // If GivenDate After Today Return True
            // If GivenDate Before Today Return False

            bool CheckResult = false;
            int DateInterval = ((TimeSpan)(GivenDate - System.DateTime.Today.Date)).Days;
            if (DateInterval >= 0)
            {
                CheckResult = true;
            }
            return CheckResult;
        }

        public static bool EnsureDate(DateTime DateTo, DateTime DateFrom)
        {
            // If DateTo After DateFrom Return True
            // If DateTo Before DateFrom Return False

            bool CheckResult = false;
            int DateInterval = ((TimeSpan)(DateTo - DateFrom)).Days;
            if (DateInterval > 0)
            {
                CheckResult = true;
            }
            return CheckResult;
        }
    }
}
