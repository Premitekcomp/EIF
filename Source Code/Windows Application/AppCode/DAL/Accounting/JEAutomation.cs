using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.Accounting
{
    class JEAutomation
    {
        #region Config
        public static DataTable GetFormsGroupList()
        {
            GlobalParamters.SQLStatment = "SELECT * from A_Auto_Config_FormGroups where IsDeleted=0 and IsActive=1 order by DisplayOrder";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                SqlDataReader dr = TSqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static DataTable GetFormsByGroupID(int GroupID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_Auto_FormsGroupLink where GroupID=@GroupID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                SqlDataReader dr = TSqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static int InsertInEngineCore(bool IsDebit, bool AccountFromTree, int AccountID, int AccountFieldID, bool NoSubAccount, bool SubAccountFromTree, int SubAccountID, int SubFieldID, int FormID, int ActionID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into A_Auto_EngingCore (IsDebit, AccountFromTree, AccountID, AccountFieldID, NoSubAccount, SubAccountFromTree, SubAccountID, SubFieldID, RCBy, FormID, ActionID) values (@IsDebit, @AccountFromTree, @AccountID, @AccountFieldID, @NoSubAccount, @SubAccountFromTree, @SubAccountID, @SubFieldID, @RCBy, @FormID, @ActionID)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@IsDebit", IsDebit);
            TSqlCommand.Parameters.AddWithValue("@AccountFromTree", AccountFromTree);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@AccountFieldID", AccountFieldID);
            TSqlCommand.Parameters.AddWithValue("@NoSubAccount", NoSubAccount);
            TSqlCommand.Parameters.AddWithValue("@SubAccountFromTree", SubAccountFromTree);
            TSqlCommand.Parameters.AddWithValue("@SubAccountID", SubAccountID);
            TSqlCommand.Parameters.AddWithValue("@SubFieldID", SubFieldID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);
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

        public static int DeleteInEngineCore(int RecordID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "delete A_Auto_EngingCore where RecordID=@RecordID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
 
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

        #region Generate
        public static DataTable GetJournalEntryStructure(int FormID, int ActionID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_Auto_EngingCore where FormID=@FormID and ActionID=@ActionID and IsDeleted=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                SqlDataReader dr = TSqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static int RerurnAccountID(string DynamicTSQLStatment)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = DynamicTSQLStatment;
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static int GetAccountType(int AccountID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select AccountTypeID from Fin_AccountsInfo where AccountID=@AccountID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static void AutoGeneratJournalEntry(int FormID, int ActionID)
        {

        }
        #endregion

        #region Accounting Config
        public static int InsertItemInFinCenter(int GroupID, int TopLevelAccountID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into A_Config_FinancialCenter (GroupID, TopLevelAccountID) values (@GroupID, @TopLevelAccountID)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@TopLevelAccountID", TopLevelAccountID);

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

        public static int DeleteItemFromFinCenter(int Serial)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "delete A_Config_FinancialCenter where Serial=@Serial";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@Serial", Serial);

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
