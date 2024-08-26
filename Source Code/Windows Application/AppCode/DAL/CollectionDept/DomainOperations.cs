using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.CollectionDept
{
    class DomainOperations
    {
        
        public static int DomainPK_Insert(int MonthID, int BankID, int DomainType, int DomainSchema, int Branch)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_DomainsDataPK (MonthID, BankID, DomainType, DomainSchema, Branch) values (@MonthID, @BankID, @DomainType, @DomainSchema, @Branch)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            
            TSqlCommand.Parameters.AddWithValue("@MonthID", MonthID);
            TSqlCommand.Parameters.AddWithValue("@BankID", BankID);
            TSqlCommand.Parameters.AddWithValue("@DomainType", DomainType);
            TSqlCommand.Parameters.AddWithValue("@DomainSchema", DomainSchema);
            TSqlCommand.Parameters.AddWithValue("@Branch", Branch);

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

        public static int GetMaxDomainID()
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select max([DomainSerial]) from Col_DomainsDataPK";
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

        public static DataTable GetSchemaInfo(int SchemaID)
        {
            GlobalParamters.SQLStatment = "select * from Col_DomainsSchemaBasic where SchemaID=@SchemaID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SchemaID", SchemaID);
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

        public static DataTable GetSchemaExtendedInfo(int SchemaID)
        {
            GlobalParamters.SQLStatment = "select * from Col_DomainsSchemaExtra where SchemaID=@SchemaID order by HeaderOrder";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SchemaID", SchemaID);
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

        public static int DomainBasic_Insert(int DomainID, string AccountNo, string AccountID, string CustomerName, string Product, string Cycle, string Bucket, string PastDue, string Balance, string City, string Office)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_DomainsDataBasic (DomainID, AccountNo, AccountID, CustomerName, Product, Cycle, Bucket, PastDue, Balance, City, Office) values (@DomainID, @AccountNo, @AccountID, @CustomerName, @Product, @Cycle, @Bucket, @PastDue, @Balance, @City, @Office)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            TSqlCommand.Parameters.AddWithValue("@Product", Product);
            TSqlCommand.Parameters.AddWithValue("@Cycle", Cycle);
            TSqlCommand.Parameters.AddWithValue("@Bucket", Bucket);
            TSqlCommand.Parameters.AddWithValue("@PastDue", PastDue);
            TSqlCommand.Parameters.AddWithValue("@Balance", Balance);
            TSqlCommand.Parameters.AddWithValue("@City", City);
            TSqlCommand.Parameters.AddWithValue("@Office", Office);

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

        public static int DomainBasicExtended_Insert(int DomainID, string AccountNo, string AccountID, string CustomerName, string Product, string Cycle, string Bucket, string PastDue, string Balance, string City, string Office, string CardNo, string NationalityTitle, string PassportNo, string CreditLimit, string MobileNumber, string AddressT, string WorkPhoneTitle, string CompanyNameTitle, string CompanyAddressTitle)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_DomainsDataBasic (DomainID, AccountNo, AccountID, CustomerName, Product, Cycle, Bucket, PastDue, Balance, City, Office, CardNo, NationalityTitle, PassportNo, CreditLimit, MobileNumber, AddressT, WorkPhoneTitle, CompanyNameTitle, CompanyAddressTitle) values (@DomainID, @AccountNo, @AccountID, @CustomerName, @Product, @Cycle, @Bucket, @PastDue, @Balance, @City, @Office, @CardNo, @NationalityTitle, @PassportNo, @CreditLimit, @MobileNumber, @AddressT, @WorkPhoneTitle, @CompanyNameTitle, @CompanyAddressTitle)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            TSqlCommand.Parameters.AddWithValue("@Product", Product);
            TSqlCommand.Parameters.AddWithValue("@Cycle", Cycle);
            TSqlCommand.Parameters.AddWithValue("@Bucket", Bucket);
            TSqlCommand.Parameters.AddWithValue("@PastDue", PastDue);
            TSqlCommand.Parameters.AddWithValue("@Balance", Balance);
            TSqlCommand.Parameters.AddWithValue("@City", City);
            TSqlCommand.Parameters.AddWithValue("@Office", Office);

            TSqlCommand.Parameters.AddWithValue("@CardNo", CardNo);
            TSqlCommand.Parameters.AddWithValue("@NationalityTitle", NationalityTitle);
            TSqlCommand.Parameters.AddWithValue("@PassportNo", PassportNo);
            TSqlCommand.Parameters.AddWithValue("@CreditLimit", CreditLimit);
            TSqlCommand.Parameters.AddWithValue("@MobileNumber", MobileNumber);
            TSqlCommand.Parameters.AddWithValue("@AddressT", AddressT);
            TSqlCommand.Parameters.AddWithValue("@WorkPhoneTitle", WorkPhoneTitle);
            TSqlCommand.Parameters.AddWithValue("@CompanyNameTitle", CompanyNameTitle);
            TSqlCommand.Parameters.AddWithValue("@CompanyAddressTitle", CompanyAddressTitle);

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

        public static int DomainBasic_InsertWithVersion(int DomainID, string AccountNo, string AccountID, string CustomerName, string Product, string Cycle, string Bucket, string PastDue, string Balance, string City, string Office, int RecordVersion)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_DomainsDataBasic (DomainID, AccountNo, AccountID, CustomerName, Product, Cycle, Bucket, PastDue, Balance, City, Office, RecordVersion) values (@DomainID, @AccountNo, @AccountID, @CustomerName, @Product, @Cycle, @Bucket, @PastDue, @Balance, @City, @Office, @RecordVersion)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            TSqlCommand.Parameters.AddWithValue("@Product", Product);
            TSqlCommand.Parameters.AddWithValue("@Cycle", Cycle);
            TSqlCommand.Parameters.AddWithValue("@Bucket", Bucket);
            TSqlCommand.Parameters.AddWithValue("@PastDue", PastDue);
            TSqlCommand.Parameters.AddWithValue("@Balance", Balance);
            TSqlCommand.Parameters.AddWithValue("@City", City);
            TSqlCommand.Parameters.AddWithValue("@Office", Office);
            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);

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

        public static int GetMaxDomainBasicRecord()
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select max([RecordSerial]) from Col_DomainsDataBasic";
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

        public static int DomainExtra_Insert(string InsertStatment)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = InsertStatment;
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

        public static int UpdateDomainVersion(int DomainSerial, int CurrentVersion)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataPK set CurrentVersion=@CurrentVersion where DomainSerial=@DomainSerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainSerial", DomainSerial);
            TSqlCommand.Parameters.AddWithValue("@CurrentVersion", CurrentVersion);

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

        public static int DailyVisit_Insert(int PointToRecord, int Collector, DateTime ConnectionDate, string ConnectionType, string ConnetctionResult, string PTPType, DateTime PTPDate, decimal PTPAmount, bool KeptBroken, decimal KeptAmount, string TrialDetails, bool Broken, bool PTPDateIncluded)
        {
            int StatmentFireResult = 0;
            if (PTPDateIncluded == true)
            {
                GlobalParamters.SQLStatment = "insert into Col_DailyVisits (PointToRecord, Collector, ConnectionDate, ConnectionType, ConnetctionResult, PTPType, PTPDate, PTPAmount, KeptBroken, KeptAmount, TrialDetails, Broken) values (@PointToRecord, @Collector, @ConnectionDate, @ConnectionType, @ConnetctionResult, @PTPType, @PTPDate, @PTPAmount, @KeptBroken, @KeptAmount, @TrialDetails, @Broken)";
            }
            else
            {
                GlobalParamters.SQLStatment = "insert into Col_DailyVisits (PointToRecord, Collector, ConnectionDate, ConnectionType, ConnetctionResult, PTPType, PTPAmount, KeptBroken, KeptAmount, TrialDetails, Broken) values (@PointToRecord, @Collector, @ConnectionDate, @ConnectionType, @ConnetctionResult, @PTPType, @PTPAmount, @KeptBroken, @KeptAmount, @TrialDetails, @Broken)";
            }
            
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@PointToRecord", PointToRecord);
            TSqlCommand.Parameters.AddWithValue("@Collector", Collector);
            TSqlCommand.Parameters.AddWithValue("@ConnectionDate", ConnectionDate);
            TSqlCommand.Parameters.AddWithValue("@ConnectionType", ConnectionType);
            TSqlCommand.Parameters.AddWithValue("@ConnetctionResult", ConnetctionResult);
            TSqlCommand.Parameters.AddWithValue("@PTPType", PTPType);
            TSqlCommand.Parameters.AddWithValue("@PTPDate", PTPDate);
            TSqlCommand.Parameters.AddWithValue("@PTPAmount", PTPAmount);
            TSqlCommand.Parameters.AddWithValue("@KeptBroken", KeptBroken);
            TSqlCommand.Parameters.AddWithValue("@KeptAmount", KeptAmount);
            TSqlCommand.Parameters.AddWithValue("@TrialDetails", TrialDetails);
            TSqlCommand.Parameters.AddWithValue("@Broken", Broken);

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

        public static int UpdateDomainByAccountID(string AccountID, int DomainID, int RecordVersion, decimal Payment, string IsBucket)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set Payment=@Payment, IsBucket=@IsBucket where DomainID=@DomainID and RecordVersion=@RecordVersion and AccountID=@AccountID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@AccountID", AccountID);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);
            TSqlCommand.Parameters.AddWithValue("@Payment", Payment);
            TSqlCommand.Parameters.AddWithValue("@IsBucket", IsBucket);

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

        public static int UpdateDomainByAccountNo(string AccountNo, int DomainID, int RecordVersion, decimal Payment, string IsBucket)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set Payment=@Payment, IsBucket=@IsBucket where DomainID=@DomainID and RecordVersion=@RecordVersion and AccountNo=@AccountNo";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);
            TSqlCommand.Parameters.AddWithValue("@Payment", Payment);
            TSqlCommand.Parameters.AddWithValue("@IsBucket", IsBucket);

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

        public static int UpdateDomainByCustomerName(string CustomerName, int DomainID, int RecordVersion, decimal Payment, string IsBucket)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set Payment=@Payment, IsBucket=@IsBucket where DomainID=@DomainID and RecordVersion=@RecordVersion and CustomerName=@CustomerName";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);
            TSqlCommand.Parameters.AddWithValue("@Payment", Payment);
            TSqlCommand.Parameters.AddWithValue("@IsBucket", IsBucket);

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

        public static int AssignTeamLeader(int RecordSerial, int TeamLeader)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set TeamLeader=@TeamLeader where RecordSerial=@RecordSerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
            TSqlCommand.Parameters.AddWithValue("@TeamLeader", TeamLeader);

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

        public static int AssignDTL(int RecordSerial, int SuperVisor)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set SuperVisor=@SuperVisor where RecordSerial=@RecordSerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
            TSqlCommand.Parameters.AddWithValue("@SuperVisor", SuperVisor);

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

        public static int AssignCollector(int RecordSerial, int CollectorName)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set CollectorName=@CollectorName where RecordSerial=@RecordSerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
            TSqlCommand.Parameters.AddWithValue("@CollectorName", CollectorName);

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

        public static DataTable GetV1DomainTeamInfo(int DomainID, int RecordVersion)
        {
            GlobalParamters.SQLStatment = "select TeamLeader, SuperVisor, CollectorName, AccountNo from Col_DomainsDataBasic where RecordVersion=@RecordVersion and DomainID=@DomainID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
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

        public static int UpdateTeam(int DomainID, int RecordVersion, string AccountNo, int TeamLeader, int SuperVisor, int CollectorName)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_DomainsDataBasic set TeamLeader=@TeamLeader, SuperVisor=@SuperVisor, CollectorName=@CollectorName where DomainID=@DomainID and RecordVersion=@RecordVersion and AccountNo=@AccountNo";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@RecordVersion", RecordVersion);
            TSqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
            TSqlCommand.Parameters.AddWithValue("@TeamLeader", TeamLeader);
            TSqlCommand.Parameters.AddWithValue("@SuperVisor", SuperVisor);
            TSqlCommand.Parameters.AddWithValue("@CollectorName", CollectorName);

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

        public static int InsertBasicTarget(int DomainID, int Target)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_Bsk_MonthlyTarget (DomainID, Target) values (@DomainID, @Target)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@Target", Target);

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

        public static int InsertDetailsTarget(int TargetID, int BucketValue, decimal BucketTarget)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_Bsk_MonthlyTargetDetails (TargetID, BucketValue, BucketTarget) values (@TargetID, @BucketValue, @BucketTarget)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@TargetID", TargetID);
            TSqlCommand.Parameters.AddWithValue("@BucketValue", BucketValue);
            TSqlCommand.Parameters.AddWithValue("@BucketTarget", BucketTarget);

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

        public static decimal GetBucketTarget(int DomainID, int BucketValue)
        {
            decimal StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select BucketTarget from Col_Bsk_MonthlyTarget INNER JOIN Col_Bsk_MonthlyTargetDetails ON Col_Bsk_MonthlyTarget.TargetID = Col_Bsk_MonthlyTargetDetails.TargetID where DomainID=@DomainID and BucketValue=@BucketValue";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@BucketValue", BucketValue);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult = Convert.ToDecimal(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        public static int DeleteTeamMember(int RecordID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "delete Col_Lup_TeamMembers where RecordID=@RecordID";
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

        public static int InsertTeamMember(int TeamID, int MemberID, int RoleID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_Lup_TeamMembers (TeamID, MemberID, RoleID) values (@TeamID, @MemberID, @RoleID)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@TeamID", TeamID);
            TSqlCommand.Parameters.AddWithValue("@MemberID", MemberID);
            TSqlCommand.Parameters.AddWithValue("@RoleID", RoleID);

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
