using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.Accounting
{
    class AssessitOperation
    {

        #region Assessit Groups
        public static int CreateNewASTGroups(string ASTGroupTitle, decimal GroupDepreciationPercentage)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into AST_Groups (ASTGroupTitle, GroupDepreciationPercentage, RCBy) values (@ASTGroupTitle, @GroupDepreciationPercentage, @RCBy)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ASTGroupTitle", ASTGroupTitle);
            TSqlCommand.Parameters.AddWithValue("@GroupDepreciationPercentage", GroupDepreciationPercentage);
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

        public static int UpdateASTGroups(string ASTGroupTitle, decimal GroupDepreciationPercentage, int ASTGroupID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update AST_Groups set ASTGroupTitle=@ASTGroupTitle, GroupDepreciationPercentage=@GroupDepreciationPercentage, LABy=@LABy, LADate=@LADate where ASTGroupID=@ASTGroupID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ASTGroupTitle", ASTGroupTitle);
            TSqlCommand.Parameters.AddWithValue("@GroupDepreciationPercentage", GroupDepreciationPercentage);
            TSqlCommand.Parameters.AddWithValue("@ASTGroupID", ASTGroupID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
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

        public static int DeleteASTGroups(int ASTGroupID)
        {
            UpdateASTLinkedToDeletedGroups(ASTGroupID);
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "delete AST_Groups where ASTGroupID=@ASTGroupID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@ASTGroupID", ASTGroupID);

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

        public static int UpdateASTLinkedToDeletedGroups(int ASTGroupID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update AST_AssetsBasic set ASTGroupID=1 where ASTGroupID=@ASTGroupID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@ASTGroupID", ASTGroupID);

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

        #region ASTs
        public static int CheckASTSerial(string AssetSerialNumber)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select count(AssetID) from AST_AssetsBasic where AssetSerialNumber=@AssetSerialNumber";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@AssetSerialNumber", AssetSerialNumber);

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

        public static int RegisterNewAST(int AssetStateID, string AssetSerialNumber, string AssetTitle, DateTime BuyDate, decimal CapitalCost, DateTime StartDepreciationDate, decimal StartDepsCurrentValue, decimal DepreciationPercentage, int ASTGroupID, string ASTLocation, string Notes, int BranchID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into AST_AssetsBasic (AssetStateID, AssetSerialNumber, AssetTitle, BuyDate, CapitalCost, StartDepreciationDate, StartDepsCurrentValue, DepreciationPercentage, ASTGroupID, ASTLocation, Notes, BranchID, RCBy) values (@AssetStateID, @AssetSerialNumber, @AssetTitle, @BuyDate, @CapitalCost, @StartDepreciationDate, @StartDepsCurrentValue, @DepreciationPercentage, @ASTGroupID, @ASTLocation, @Notes, @BranchID, @RCBy);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            
            TSqlCommand.Parameters.AddWithValue("@AssetStateID", AssetStateID);
            TSqlCommand.Parameters.AddWithValue("@AssetSerialNumber", AssetSerialNumber);
            TSqlCommand.Parameters.AddWithValue("@AssetTitle", AssetTitle);
            TSqlCommand.Parameters.AddWithValue("@BuyDate", BuyDate);
            TSqlCommand.Parameters.AddWithValue("@CapitalCost", CapitalCost);
            TSqlCommand.Parameters.AddWithValue("@StartDepreciationDate", StartDepreciationDate);
            TSqlCommand.Parameters.AddWithValue("@StartDepsCurrentValue", StartDepsCurrentValue);
            TSqlCommand.Parameters.AddWithValue("@DepreciationPercentage", DepreciationPercentage);
            TSqlCommand.Parameters.AddWithValue("@ASTGroupID", ASTGroupID);
            TSqlCommand.Parameters.AddWithValue("@ASTLocation", ASTLocation);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@BranchID", BranchID);
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

        public static int UodateASTInformation(int AssetStateID, string AssetSerialNumber, string AssetTitle, DateTime BuyDate, decimal CapitalCost, DateTime StartDepreciationDate, decimal StartDepsCurrentValue, decimal DepreciationPercentage, int ASTGroupID, string ASTLocation, string Notes, int BranchID, int AssetID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update AST_AssetsBasic set AssetStateID=@AssetStateID, AssetSerialNumber=@AssetSerialNumber, AssetTitle=@AssetTitle, BuyDate=@BuyDate, CapitalCost=@CapitalCost, StartDepreciationDate=@StartDepreciationDate, StartDepsCurrentValue=@StartDepsCurrentValue, DepreciationPercentage=@DepreciationPercentage, ASTGroupID=@ASTGroupID, ASTLocation=@ASTLocation, Notes=@Notes, BranchID=@BranchID where AssetID=@AssetID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@AssetStateID", AssetStateID);
            TSqlCommand.Parameters.AddWithValue("@AssetSerialNumber", AssetSerialNumber);
            TSqlCommand.Parameters.AddWithValue("@AssetTitle", AssetTitle);
            TSqlCommand.Parameters.AddWithValue("@BuyDate", BuyDate);
            TSqlCommand.Parameters.AddWithValue("@CapitalCost", CapitalCost);
            TSqlCommand.Parameters.AddWithValue("@StartDepreciationDate", StartDepreciationDate);
            TSqlCommand.Parameters.AddWithValue("@StartDepsCurrentValue", StartDepsCurrentValue);
            TSqlCommand.Parameters.AddWithValue("@DepreciationPercentage", DepreciationPercentage);
            TSqlCommand.Parameters.AddWithValue("@ASTGroupID", ASTGroupID);
            TSqlCommand.Parameters.AddWithValue("@ASTLocation", ASTLocation);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@BranchID", BranchID);
            TSqlCommand.Parameters.AddWithValue("@AssetID", AssetID);

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


        public static DataTable GetASTInfo(int AssetID)
        {
            GlobalParamters.SQLStatment = "SELECT * from AST_AssetsBasic where AssetID=@AssetID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@AssetID", AssetID);

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
        #endregion

    }
}
