using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.Accounting
{
    class JournalOperations
    {
        public static decimal GetCurrentExcnageRate(int CurrencyID)
        {
            decimal ExchangeRate = 0;
            GlobalParamters.SQLStatment = "select ExchangeRate from A_Lup_ExchangeRateRefTable where IsCurrentRate=1 and CurrencyID=@CurrencyID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ExchangeRate = Convert.ToDecimal(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return ExchangeRate;
            }
            catch
            {
                return ExchangeRate;
            }

        }

        public static int GetNextJournalEntryNumber()
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select ISNULL(max(ENo), 0) from A_JournalBasic";
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

        public static int MakeNewJournalEntry(int ENo, DateTime EDate, int EntryTypeID, string Notes, bool Approved)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into A_JournalBasic (ENo, EDate, EntryTypeID, Notes, Approved, BranchID, RCBy) values (@ENo, @EDate, @EntryTypeID, @Notes, @Approved, @BranchID, @RCBy);select SCOPE_IDENTITY();";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ENo", ENo);
            TSqlCommand.Parameters.AddWithValue("@EDate", EDate);
            TSqlCommand.Parameters.AddWithValue("@EntryTypeID", EntryTypeID);
            TSqlCommand.Parameters.AddWithValue("@BranchID", GlobalParamters.ActiveProjectID);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@Approved", Approved);
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

        public static int MakeNewEntryDetails(int JEMasterID, int AccountID, int SubAccountID, decimal Debit, decimal Credit, int CurrencyID, decimal ExchangeRate, decimal LocalDebit, decimal LocalCredit, string Notes)
        {
            GlobalParamters.StatmentFireResult = 0;
            if(SubAccountID==0)
            {
                GlobalParamters.SQLStatment = "insert into A_JournalEntryDetails (JEMasterID, AccountID, Debit, Credit, CurrencyID, ExchangeRate, LocalDebit, LocalCredit, Notes, RCBy) values (@JEMasterID, @AccountID, @Debit, @Credit, @CurrencyID, @ExchangeRate, @LocalDebit, @LocalCredit, @Notes, @RCBy);select SCOPE_IDENTITY();";

            }
            else
            {
                GlobalParamters.SQLStatment = "insert into A_JournalEntryDetails (JEMasterID, AccountID, SubAccountID, Debit, Credit, CurrencyID, ExchangeRate, LocalDebit, LocalCredit, Notes, RCBy) values (@JEMasterID, @AccountID, @SubAccountID, @Debit, @Credit, @CurrencyID, @ExchangeRate, @LocalDebit, @LocalCredit, @Notes, @RCBy);select SCOPE_IDENTITY();";
            }

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JEMasterID", JEMasterID);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@SubAccountID", SubAccountID);
            TSqlCommand.Parameters.AddWithValue("@Debit", Debit);
            TSqlCommand.Parameters.AddWithValue("@Credit", Credit);
            TSqlCommand.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            TSqlCommand.Parameters.AddWithValue("@ExchangeRate", ExchangeRate);
            TSqlCommand.Parameters.AddWithValue("@LocalDebit", LocalDebit);
            TSqlCommand.Parameters.AddWithValue("@LocalCredit", LocalCredit);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
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

        public static int UpdateEntryGlobalBalance(int EID, decimal TotalDebit, decimal TotalCredit, string Notes, DateTime EDate, int EntryTypeID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalBasic set TotalDebit=@TotalDebit, TotalCredit=@TotalCredit, Notes=@Notes, EDate=@EDate, EntryTypeID=@EntryTypeID where EID=@EID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EID", EID);
            TSqlCommand.Parameters.AddWithValue("@TotalDebit", TotalDebit);
            TSqlCommand.Parameters.AddWithValue("@TotalCredit", TotalCredit);

            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
            TSqlCommand.Parameters.AddWithValue("@EDate", EDate);
            TSqlCommand.Parameters.AddWithValue("@EntryTypeID", EntryTypeID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                GlobalParamters.StatmentFireResult =TSqlCommand.ExecuteNonQuery();
                GlobalParamters.DBConnection.Close();
                return GlobalParamters.StatmentFireResult;
            }
            catch
            {
                return GlobalParamters.StatmentFireResult;
            }

        }

        public static int UpdateEntryGlobalBalanceQuick(int EID, decimal TotalDebit, decimal TotalCredit)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalBasic set TotalDebit=@TotalDebit, TotalCredit=@TotalCredit where EID=@EID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EID", EID);
            TSqlCommand.Parameters.AddWithValue("@TotalDebit", TotalDebit);
            TSqlCommand.Parameters.AddWithValue("@TotalCredit", TotalCredit);

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


        public static int UpdateEntryGlobalBalanceBrif(int EID, decimal TotalDebit, decimal TotalCredit)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalBasic set TotalDebit=@TotalDebit, TotalCredit=@TotalCredit where EID=@EID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EID", EID);
            TSqlCommand.Parameters.AddWithValue("@TotalDebit", TotalDebit);
            TSqlCommand.Parameters.AddWithValue("@TotalCredit", TotalCredit);

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

        public static DataTable ReadEntryBasicDate(int EID)
        {
            GlobalParamters.StatmentFireResult = 0;
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("SELECT * FROM A_JournalBasic where EID=@EID", GlobalParamters.DBConnection);
                SqlParameter param1 = new SqlParameter("@EID", EID);
                SQLCmd.Parameters.Add(param1);

                SqlDataReader dr = SQLCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static int GetEntryIDbyEntryNo(int ENo)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select EID from A_JournalBasic where ENo=@ENo";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ENo", ENo);
            
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


        public static int UpdateEntryDetails(int JEDetailID, decimal Debit, decimal Credit, decimal LocalDebit, decimal LocalCredit, string Notes)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalEntryDetails set Debit=@Debit, Credit=@Credit, LocalDebit=@LocalDebit, LocalCredit=@LocalCredit, Notes=@Notes where JEDetailID=@JEDetailID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JEDetailID", JEDetailID);
            TSqlCommand.Parameters.AddWithValue("@Debit", Debit);
            TSqlCommand.Parameters.AddWithValue("@Credit", Credit);
            TSqlCommand.Parameters.AddWithValue("@LocalDebit", LocalDebit);
            TSqlCommand.Parameters.AddWithValue("@LocalCredit", LocalCredit);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);

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

        public static int DeleteEntryDetails(int JEDetailID)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "delete A_JournalEntryDetails where JEDetailID=@JEDetailID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JEDetailID", JEDetailID);

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

        public static int UpdateEntryApproveStatus(int EID, bool Approved)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalBasic set Approved=@Approved where EID=@EID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EID", EID);
            TSqlCommand.Parameters.AddWithValue("@Approved", Approved);

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

        public static int UpdateEntryDeleteStatus(int EID, bool IsDeleted)
        {
            GlobalParamters.StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update A_JournalBasic set IsDeleted=@IsDeleted where EID=@EID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EID", EID);
            TSqlCommand.Parameters.AddWithValue("@IsDeleted", IsDeleted);

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

        public static DataTable GetMasterBookTLAccounts(DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.StatmentFireResult = 0;
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("SELECT AccountFullName AS [اسم الحساب], SUM(LocalDebit) AS [اجمالي مدين], SUM(LocalCredit) AS [اجمالي دائن] FROM A_JournalDetailsForFinancialReports WHERE (EDate BETWEEN @StartDate AND @EndDate) GROUP BY AccountFullName", GlobalParamters.DBConnection);
                SqlParameter param1 = new SqlParameter("@StartDate", StartDate);
                SqlParameter param2 = new SqlParameter("@EndDate", EndDate);

                SQLCmd.Parameters.Add(param1);
                SQLCmd.Parameters.Add(param2);

                SqlDataReader dr = SQLCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static DataTable GetMasterBookSubAccounts(DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.StatmentFireResult = 0;
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("SELECT SubAccountFullName AS [اسم الحساب], SUM(LocalDebit) AS [اجمالي مدين], SUM(LocalCredit) AS [اجمالي دائن] FROM A_JournalDetailsForFinancialReports WHERE (EDate BETWEEN @StartDate AND @EndDate) And SubAccountFullName IS Not NULL GROUP BY SubAccountFullName", GlobalParamters.DBConnection);
                SqlParameter param1 = new SqlParameter("@StartDate", StartDate);
                SqlParameter param2 = new SqlParameter("@EndDate", EndDate);

                SQLCmd.Parameters.Add(param1);
                SQLCmd.Parameters.Add(param2);

                SqlDataReader dr = SQLCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }
        }

        public static decimal GetGlobalDepitSum(int JEMasterID)
        {
            decimal ExchangeRate = 0;
            GlobalParamters.SQLStatment = "select ISNULL(Sum(LocalDebit), 0) from A_JournalEntryDetails where JEMasterID=@JEMasterID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JEMasterID", JEMasterID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ExchangeRate = Convert.ToDecimal(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return ExchangeRate;
            }
            catch
            {
                return ExchangeRate;
            }

        }

        public static decimal GetGlobalCredittSum(int JEMasterID)
        {
            decimal ExchangeRate = 0;
            GlobalParamters.SQLStatment = "select ISNULL(Sum(LocalCredit), 0) from A_JournalEntryDetails where JEMasterID=@JEMasterID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@JEMasterID", JEMasterID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ExchangeRate = Convert.ToDecimal(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return ExchangeRate;
            }
            catch
            {
                return ExchangeRate;
            }

        }

    }
}
