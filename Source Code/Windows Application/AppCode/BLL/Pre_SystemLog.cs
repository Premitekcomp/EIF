using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.BLL
{
    class Pre_SystemLog
    {
        public static int InsertLog(int FormID, int RecordID, int ActionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Pre_Trans_Log (UserID, FormID, RecordID, ActionID) values (@UserID, @FormID, @RecordID, @ActionID)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);
            TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static int InsertLogFromLoginForm(int UserID, int FormID, int RecordID, int ActionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Pre_Trans_Log (UserID, FormID, RecordID, ActionID) values (@UserID, @FormID, @RecordID, @ActionID)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);
            TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static int ChangeUserStatus(int UserID, bool IsOnline)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_UserStatus set IsOnline=@IsOnline where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@IsOnline", IsOnline);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static int GetThemAllOut()
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_UserStatus set IsOnline=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }
    }
}
