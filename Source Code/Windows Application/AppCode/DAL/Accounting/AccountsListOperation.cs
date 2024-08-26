using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.Accounting
{
    class AccountsListOperation
    {
        #region Accounts List
        public static DataTable GetAccountByLevel(int LevelID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsList where LevelID=@LevelID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);

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

        public static DataTable GetAccountByParentID(int ParentID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsList where ParentID=@ParentID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

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

        public static DataTable GetAccountByID(int AccountID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsList where AccountID=@AccountID and IsDeleted=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static int GetSubCountNextSerial(int ParentID)
        {

            GlobalParamters.SQLStatment = "select count(AccountID) from A_AccountsList where ParentID=@ParentID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar())+1;
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int CreateNewAccount(int AccountNumber, string AccountName, int ParentID, int LevelID, int AccountTypeID, decimal DepitOpenBalance, decimal CreditOpenBalance)
        {

            GlobalParamters.SQLStatment = "insert into A_AccountsList (AccountNumber, AccountName, ParentID, BranchID, LevelID, AccountTypeID, RCBy, DepitOpenBalance, CreditOpenBalance) values (@AccountNumber, @AccountName, @ParentID, @BranchID, @LevelID, @AccountTypeID, @RCBy, @DepitOpenBalance, @CreditOpenBalance);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            TSqlCommand.Parameters.AddWithValue("@AccountName", AccountName);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);
            TSqlCommand.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@DepitOpenBalance", DepitOpenBalance);
            TSqlCommand.Parameters.AddWithValue("@CreditOpenBalance", CreditOpenBalance);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int UpdateAccountInfo(int AccountID, string AccountName, decimal DepitOpenBalance, decimal CreditOpenBalance)
        {

            GlobalParamters.SQLStatment = "update A_AccountsList set AccountName=@AccountName, DepitOpenBalance=@DepitOpenBalance, CreditOpenBalance=@CreditOpenBalance where AccountID=@AccountID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@AccountName", AccountName);
            TSqlCommand.Parameters.AddWithValue("@DepitOpenBalance", DepitOpenBalance);
            TSqlCommand.Parameters.AddWithValue("@CreditOpenBalance", CreditOpenBalance);


            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int DeleteAccount(int AccountID)
        {

            GlobalParamters.SQLStatment = "Update A_AccountsList set IsDeleted=1 where AccountID=@AccountID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        #endregion

        #region Sub Accounts List
        public static DataTable GetSubAccountByLevel(int LevelID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_SubAccountsList where LevelID=@LevelID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);

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

        public static int GetLevelDownCountNextSerial(int ParentID)
        {

            GlobalParamters.SQLStatment = "select count(AccountID) from A_SubAccountsList where ParentID=@ParentID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar()) + 1;
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int GetNextTopLevelSerial()
        {

            GlobalParamters.SQLStatment = "select count(AccountID) from A_SubAccountsList where ParentID IS NULL";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
        
            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar()) + 1;
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static DataTable GetSubAccountByParentID(int ParentID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_SubAccountsList where ParentID=@ParentID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

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

        public static DataTable GetSubAccountByID(int AccountID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_SubAccountsList where AccountID=@AccountID and IsDeleted=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static int CreateNewSubAccount(int AccountNumber, string AccountName, int ParentID, int LevelID, int AccountTypeID, decimal DepitOpenBalance, decimal CreditOpenBalance)
        {

            GlobalParamters.SQLStatment = "insert into A_SubAccountsList (AccountNumber, AccountName, ParentID, BranchID, LevelID, AccountTypeID, RCBy, DepitOpenBalance, CreditOpenBalance) values (@AccountNumber, @AccountName, @ParentID, @BranchID, @LevelID, @AccountTypeID, @RCBy ,@DepitOpenBalance, @CreditOpenBalance);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            TSqlCommand.Parameters.AddWithValue("@AccountName", AccountName);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);
            TSqlCommand.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@DepitOpenBalance", DepitOpenBalance);
            TSqlCommand.Parameters.AddWithValue("@CreditOpenBalance", CreditOpenBalance);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int CreateNewTopLevelSubAccount(int AccountNumber, string AccountName)
        {

            GlobalParamters.SQLStatment = "insert into A_SubAccountsList (AccountNumber, AccountName, BranchID, LevelID, AccountTypeID, RCBy, DepitOpenBalance, CreditOpenBalance) values (@AccountNumber, @AccountName, @BranchID, @LevelID, @AccountTypeID, @RCBy, @DepitOpenBalance, @CreditOpenBalance);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            TSqlCommand.Parameters.AddWithValue("@AccountName", AccountName);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@LevelID", 1);
            TSqlCommand.Parameters.AddWithValue("@AccountTypeID", 100);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@DepitOpenBalance", 0);
            TSqlCommand.Parameters.AddWithValue("@CreditOpenBalance", 0);


            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }


        public static int UpdateSubAccountInfo(int AccountID, string AccountName, decimal DepitOpenBalance, decimal CreditOpenBalance)
        {

            GlobalParamters.SQLStatment = "update A_SubAccountsList set AccountName=@AccountName, DepitOpenBalance=@DepitOpenBalance, CreditOpenBalance=@CreditOpenBalance where AccountID=@AccountID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@AccountName", AccountName);
            TSqlCommand.Parameters.AddWithValue("@DepitOpenBalance", DepitOpenBalance);
            TSqlCommand.Parameters.AddWithValue("@CreditOpenBalance", CreditOpenBalance);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int BreakSubJoin(int JoinID)
        {

            GlobalParamters.SQLStatment = "Delete A_SubAccountsJoinDetails where JoinID=@JoinID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JoinID", JoinID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int MakeSubJoin(int SubAccountID, int AccountID)
        {
            GlobalParamters.SQLStatment = "insert into A_SubAccountsJoinDetails (SubAccountID, AccountID, BranchID, RCBy) values (@SubAccountID, @AccountID, @BranchID, @RCBy)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@SubAccountID", SubAccountID);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }
        #endregion

        #region Cost Centers
        public static DataTable GetCostCentersListByLevel(int LevelID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsCostCenterList where LevelID=@LevelID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);

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

        public static int GetCCLevelDownCountNextSerial(int ParentID)
        {

            GlobalParamters.SQLStatment = "select count(CostCenterAccountID) from A_AccountsCostCenterList where ParentID=@ParentID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar()) + 1;
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static DataTable GetCCByParentID(int ParentID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsCostCenterList where ParentID=@ParentID and IsDeleted=0 and IsActive=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);

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

        public static DataTable GetCCByID(int CostCenterAccountID)
        {
            GlobalParamters.SQLStatment = "SELECT * from A_AccountsCostCenterList where CostCenterAccountID=@CostCenterAccountID and IsDeleted=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CostCenterAccountID", CostCenterAccountID);

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

        public static int CreateNewCCenter(int CostCenterNumber, string CostCenterName, int ParentID, int LevelID)
        {

            GlobalParamters.SQLStatment = "insert into A_AccountsCostCenterList (CostCenterNumber, CostCenterName, ParentID, BranchID, LevelID, RCBy) values (@CostCenterNumber, @CostCenterName, @ParentID, @BranchID, @LevelID, @RCBy);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CostCenterNumber", CostCenterNumber);
            TSqlCommand.Parameters.AddWithValue("@CostCenterName", CostCenterName);
            TSqlCommand.Parameters.AddWithValue("@ParentID", ParentID);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@LevelID", LevelID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int UpdateCCAccountInfo(int CostCenterAccountID, string CostCenterName)
        {

            GlobalParamters.SQLStatment = "update A_AccountsCostCenterList set CostCenterName=@CostCenterName where CostCenterAccountID=@CostCenterAccountID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CostCenterAccountID", CostCenterAccountID);
            TSqlCommand.Parameters.AddWithValue("@CostCenterName", CostCenterName);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int MakeCCJoin(int CCenterID, int AccountID, decimal Weighet)
        {
            GlobalParamters.SQLStatment = "insert into A_CCentersJoinDetails (CCenterID, AccountID, Weighet, BranchID, RCBy) values (@CCenterID, @AccountID, @Weighet, @BranchID, @RCBy)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CCenterID", CCenterID);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@Weighet", Weighet);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int BreakCCJoin(int CCJoinID)
        {

            GlobalParamters.SQLStatment = "Delete A_CCentersJoinDetails where CCJoinID=@CCJoinID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CCJoinID", CCJoinID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int UpdateCCWeight(int CCJoinID, decimal Weighet)
        {

            GlobalParamters.SQLStatment = "update A_CCentersJoinDetails set Weighet=@Weighet where CCJoinID=@CCJoinID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CCJoinID", CCJoinID);
            TSqlCommand.Parameters.AddWithValue("@Weighet", Weighet);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        #endregion

        #region Misc
        public static int AddTermToEquation(int NodeID, int AccountID, bool IsPositive)
        {

            GlobalParamters.SQLStatment = "insert into A_Config_ListEquation (NodeID, AccountID, IsPositive) values (@NodeID, @AccountID, @IsPositive);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@NodeID", NodeID);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@IsPositive", IsPositive);
  

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        #endregion

        #region Make the Join between ERP and Accounting System
        private void theGovernal(bool WorkInSubAccounts, string AccountName)
        {

        }
        #endregion

    }
}
