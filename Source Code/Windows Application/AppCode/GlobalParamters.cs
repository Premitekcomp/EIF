using System;
using System.Drawing;
//using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode
{
    class GlobalParamters
    {
        // *** Common Parameters
        public static string MsgTitle = "EIF";
        public static string ClinetPrefix = "EIF";
        public static string ClinetPrefixChild = "EIF";
        public static string ClientName = "EIF";
        public static int ProgramSerial = 22122009;
        public static int CopyVersion = 3;

        public static Color SuccessColor = Color.Green;
        public static Color FaildColor = Color.Red;
        public static Color ActiveControlBGColor = Color.Bisque;
        public static Color InActiveControlBGColor = Color.White;
        public static int LogicalChecksFlag = 0;
        public static int ActiveWorkingShiftID = 1;
        public static int GetResponsBackFromDialogPaymentForm = 0;
        public static decimal GetPaymentBackFromDialogPaymentForm = 0;
        public static int GetResponseFromItemSearch = 0;

        // **** Data Access Parameters
        public static SqlConnection DBConnection = new SqlConnection(global::TMS.Properties.Settings.Default.TMSCS);
        public static SqlConnection DBConnectionB = new SqlConnection(global::TMS.Properties.Settings.Default.DataCS);
        public static SqlConnection AttachmentDBConnection = new SqlConnection(global::TMS.Properties.Settings.Default.TMSVDriveCS);
        public static SqlConnection VoiceDBConnection = new SqlConnection(global::TMS.Properties.Settings.Default.TMSVoiceCS);
        public static SqlConnection ArchiveDBConnection = new SqlConnection(global::TMS.Properties.Settings.Default.AttachCS);

        public static string SQLStatment;
        public static int StatmentFireResult = 0; // Return SQL Fire Results   0 = Failed       1 = Fired
        public static byte[] StatmentFireResultvoice = { 0 };

        // *** for Permissions
        public static int ActiveUserID = 0; // Active User ID
        public static int ActiveDrID = 0;
        public static int ActiveEmpID = 0;

        public static int ActiveProjectID = 0;

        public static int QueryingAccountID = 0;

        public static int CurrentVisitID = 0;
        public static int FlotMessagesUp = 0;
        public static int FlotNotificationUp = 0;
        public static int DisplayedNotiID = 0;

        public static int PassedIPUnitActivePatient = 0;

        public static bool AllowNegativeTransInMasterStores = false;
        public static bool AllowNegativeTransInSubStores = false;
        public static string SuperVisorPin = "0000";
        public static string ReciptPrinterName = "";
        public static string ReciptPrinterNameB = "Ricoh Aficio SP 4100N PCL";
        public static string LabelsPrinterName = "";
        public static bool AutoGenerateJournalEntry = true;
        
        // OBJ
        public static int ScanCaseID = 0;
        public static int ScanDrID = 0;
        public static int ScanInvoiceID = 0;
        public static int ScanSrvID=0;
        public static int ScanAccountingID = 0;

        public static decimal ScanQuantity = 0;
        public static string ScanItemName = "";

        public static DateTime ScanNewBookingDate;
        public static bool YesDoIt = false;
        public static bool OpenNewInvoice = false;
        
    }
}
