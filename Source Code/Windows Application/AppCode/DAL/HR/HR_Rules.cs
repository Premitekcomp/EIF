using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.HR
{
    class HR_Rules
    {
        #region Delay
        public static int InsertNewDelayRule(string DelayRuleNameAr, string Notes)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Rul_Delay (DelayRuleNameAr, Notes, RCBy) values (@DelayRuleNameAr, @Notes, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DelayRuleNameAr", DelayRuleNameAr);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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

        public static int UpdateDelayRule(string DelayRuleNameAr, string Notes, int DelayRuleID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "Update HR_Rul_Delay set DelayRuleNameAr=@DelayRuleNameAr, Notes=@Notes, LABy=@LABy, LADate=@LADate where DelayRuleID=@DelayRuleID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DelayRuleNameAr", DelayRuleNameAr);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@DelayRuleID", DelayRuleID);

            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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
        #endregion

        #region Delay Details
        public static int InsertNewDelayRuleDetails(int DelayRuleID, int FromMinute, int ToMinute, decimal FirstPenalty)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Rul_DelayRulesDetails (DelayRuleID, FromMinute, ToMinute, FirstPenalty, RCBy) values (@DelayRuleID, @FromMinute, @ToMinute, @FirstPenalty, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DelayRuleID", DelayRuleID);
            TSqlCommand.Parameters.AddWithValue("@FromMinute", FromMinute);
            TSqlCommand.Parameters.AddWithValue("@ToMinute", ToMinute);
            TSqlCommand.Parameters.AddWithValue("@FirstPenalty", FirstPenalty);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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

        public static int UpdateNewDelayRuleDetails(int DelayRuleID, int FromMinute, int ToMinute, decimal FirstPenalty, int DelayRuleDetailID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Rul_DelayRulesDetails set DelayRuleID=@DelayRuleID, FromMinute=@FromMinute, ToMinute=@ToMinute, FirstPenalty=@FirstPenalty, LADate=@LADate, LABy=@LABy where DelayRuleDetailID=@DelayRuleDetailID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DelayRuleID", DelayRuleID);
            TSqlCommand.Parameters.AddWithValue("@FromMinute", FromMinute);
            TSqlCommand.Parameters.AddWithValue("@ToMinute", ToMinute);
            TSqlCommand.Parameters.AddWithValue("@FirstPenalty", FirstPenalty);
            TSqlCommand.Parameters.AddWithValue("@DelayRuleDetailID", DelayRuleDetailID);

            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);

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
        #endregion

        #region Group Ploicy
        public static int InsertNewGroupPloicy(int GroupID, int DelayRuleID, int ExtraTimeRuleID, int LeavPermissionRuleID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Lup_EmplymentGroupPolicy (GroupID, DelayRuleID, ExtraTimeRuleID, LeavPermissionRuleID, RCBy) values (@GroupID, @DelayRuleID, @ExtraTimeRuleID, @LeavPermissionRuleID, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@DelayRuleID", DelayRuleID);
            TSqlCommand.Parameters.AddWithValue("@ExtraTimeRuleID", ExtraTimeRuleID);
            TSqlCommand.Parameters.AddWithValue("@LeavPermissionRuleID", LeavPermissionRuleID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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
        #endregion
    }
}
