using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.CollectionDept
{
    class DomainSchema
    {

        public static int SchemaBasic_Insert(string SchemaTitle, string SheetName, int SchemaOwner, DateTime CreationDate, int AccNoColID, int AccIDColID, int CustomerNameColID, int ProductColID, int CycleColID, int BucketColID, int PastDueColID, int BalanceColID, int CityColID, int OfficeColID)
    {
        int StatmentFireResult = 0;

        GlobalParamters.SQLStatment = "insert into Col_DomainsSchemaBasic (SchemaTitle, SheetName, SchemaOwner, CreationDate, AccNoColID, AccNoColTitle, AccIDColID, AccIDColTitle, CustomerNameColID, CustomerNameColTitle, ProductColID, ProductColTitle, CycleColID, CycleColTItle, BucketColID, BucketColTitle, PastDueColID, PastDueColTitle, BalanceColID, BalanceColTitle, CityColID, CityColTitle, OfficeColID, OfficeColTitle) values (@SchemaTitle, @SheetName, @SchemaOwner, @CreationDate, @AccNoColID, @AccNoColTitle, @AccIDColID, @AccIDColTitle, @CustomerNameColID, @CustomerNameColTitle, @ProductColID, @ProductColTitle, @CycleColID, @CycleColTItle, @BucketColID, @BucketColTitle, @PastDueColID, @PastDueColTitle, @BalanceColID, @BalanceColTitle, @CityColID, @CityColTitle, @OfficeColID, @OfficeColTitle)";

        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

        TSqlCommand.Parameters.AddWithValue("@SchemaTitle", SchemaTitle);
        TSqlCommand.Parameters.AddWithValue("@SheetName", SheetName);
        TSqlCommand.Parameters.AddWithValue("@SchemaOwner", SchemaOwner);
        TSqlCommand.Parameters.AddWithValue("@CreationDate", CreationDate);

        TSqlCommand.Parameters.AddWithValue("@AccNoColID", AccNoColID);
        TSqlCommand.Parameters.AddWithValue("@AccNoColTitle", "Account No");

        TSqlCommand.Parameters.AddWithValue("@AccIDColID", AccIDColID);
        TSqlCommand.Parameters.AddWithValue("@AccIDColTitle", "Account ID");

        TSqlCommand.Parameters.AddWithValue("@CustomerNameColID", CustomerNameColID);
        TSqlCommand.Parameters.AddWithValue("@CustomerNameColTitle", "Customer Name");

        TSqlCommand.Parameters.AddWithValue("@ProductColID", ProductColID);
        TSqlCommand.Parameters.AddWithValue("@ProductColTitle", "Product");

        TSqlCommand.Parameters.AddWithValue("@CycleColID", CycleColID);
        TSqlCommand.Parameters.AddWithValue("@CycleColTItle", "Cycle");

        TSqlCommand.Parameters.AddWithValue("@BucketColID", BucketColID);
        TSqlCommand.Parameters.AddWithValue("@BucketColTitle", "Bucket");

        TSqlCommand.Parameters.AddWithValue("@PastDueColID", PastDueColID);
        TSqlCommand.Parameters.AddWithValue("@PastDueColTitle", "Past Due");

        TSqlCommand.Parameters.AddWithValue("@BalanceColID", BalanceColID);
        TSqlCommand.Parameters.AddWithValue("@BalanceColTitle", "Balance");

        TSqlCommand.Parameters.AddWithValue("@CityColID", CityColID);
        TSqlCommand.Parameters.AddWithValue("@CityColTitle", "Region");

        TSqlCommand.Parameters.AddWithValue("@OfficeColID", OfficeColID);
        TSqlCommand.Parameters.AddWithValue("@OfficeColTitle", "Office");
        

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

        public static int SchemaBasicExtended_Insert(string SchemaTitle, string SheetName, int SchemaOwner, DateTime CreationDate, int AccNoColID, int AccIDColID, int CustomerNameColID, int ProductColID, int CycleColID, int BucketColID, int PastDueColID, int BalanceColID, int CityColID, int OfficeColID, int CardNoID, int NationalityID, int PassportNoID, int CreditLimitID, int MobileNumberID, int AddressID, int WorkPhoneID, int CompanyNameID, int CompanyAddressID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_DomainsSchemaBasic (SchemaTitle, SheetName, SchemaOwner, CreationDate, AccNoColID, AccNoColTitle, AccIDColID, AccIDColTitle, CustomerNameColID, CustomerNameColTitle, ProductColID, ProductColTitle, CycleColID, CycleColTItle, BucketColID, BucketColTitle, PastDueColID, PastDueColTitle, BalanceColID, BalanceColTitle, CityColID, CityColTitle, OfficeColID, OfficeColTitle, CardNoID, NationalityID, PassportNoID, CreditLimitID, MobileNumberID, AddressID, WorkPhoneID, CompanyNameID, CompanyAddressID) values (@SchemaTitle, @SheetName, @SchemaOwner, @CreationDate, @AccNoColID, @AccNoColTitle, @AccIDColID, @AccIDColTitle, @CustomerNameColID, @CustomerNameColTitle, @ProductColID, @ProductColTitle, @CycleColID, @CycleColTItle, @BucketColID, @BucketColTitle, @PastDueColID, @PastDueColTitle, @BalanceColID, @BalanceColTitle, @CityColID, @CityColTitle, @OfficeColID, @OfficeColTitle, @CardNoID, @NationalityID, @PassportNoID, @CreditLimitID, @MobileNumberID, @AddressID, @WorkPhoneID, @CompanyNameID, @CompanyAddressID)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SchemaTitle", SchemaTitle);
            TSqlCommand.Parameters.AddWithValue("@SheetName", SheetName);
            TSqlCommand.Parameters.AddWithValue("@SchemaOwner", SchemaOwner);
            TSqlCommand.Parameters.AddWithValue("@CreationDate", CreationDate);

            TSqlCommand.Parameters.AddWithValue("@AccNoColID", AccNoColID);
            TSqlCommand.Parameters.AddWithValue("@AccNoColTitle", "Account No");

            TSqlCommand.Parameters.AddWithValue("@AccIDColID", AccIDColID);
            TSqlCommand.Parameters.AddWithValue("@AccIDColTitle", "Account ID");

            TSqlCommand.Parameters.AddWithValue("@CustomerNameColID", CustomerNameColID);
            TSqlCommand.Parameters.AddWithValue("@CustomerNameColTitle", "Customer Name");

            TSqlCommand.Parameters.AddWithValue("@ProductColID", ProductColID);
            TSqlCommand.Parameters.AddWithValue("@ProductColTitle", "Product");

            TSqlCommand.Parameters.AddWithValue("@CycleColID", CycleColID);
            TSqlCommand.Parameters.AddWithValue("@CycleColTItle", "Cycle");

            TSqlCommand.Parameters.AddWithValue("@BucketColID", BucketColID);
            TSqlCommand.Parameters.AddWithValue("@BucketColTitle", "Bucket");

            TSqlCommand.Parameters.AddWithValue("@PastDueColID", PastDueColID);
            TSqlCommand.Parameters.AddWithValue("@PastDueColTitle", "Past Due");

            TSqlCommand.Parameters.AddWithValue("@BalanceColID", BalanceColID);
            TSqlCommand.Parameters.AddWithValue("@BalanceColTitle", "Balance");

            TSqlCommand.Parameters.AddWithValue("@CityColID", CityColID);
            TSqlCommand.Parameters.AddWithValue("@CityColTitle", "Region");

            TSqlCommand.Parameters.AddWithValue("@OfficeColID", OfficeColID);
            TSqlCommand.Parameters.AddWithValue("@OfficeColTitle", "Office");

            TSqlCommand.Parameters.AddWithValue("@CardNoID", CardNoID);
            TSqlCommand.Parameters.AddWithValue("@NationalityID", NationalityID);
            TSqlCommand.Parameters.AddWithValue("@PassportNoID", PassportNoID);
            TSqlCommand.Parameters.AddWithValue("@CreditLimitID", CreditLimitID);
            TSqlCommand.Parameters.AddWithValue("@MobileNumberID", MobileNumberID);
            TSqlCommand.Parameters.AddWithValue("@AddressID", AddressID);
            TSqlCommand.Parameters.AddWithValue("@WorkPhoneID", WorkPhoneID);
            TSqlCommand.Parameters.AddWithValue("@CompanyNameID", CompanyNameID);
            TSqlCommand.Parameters.AddWithValue("@CompanyAddressID", CompanyAddressID);

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

        public static int GetMaxSchemaID()
    {
        int StatmentFireResult = 0;
        GlobalParamters.SQLStatment = "Select max([SchemaID]) from Col_DomainsSchemaBasic";

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
   
        public static int SchemaExtended_Insert(int SchemaID, int HeaderOrder, string HeaderTitle)
    {
        int StatmentFireResult = 0;
        GlobalParamters.SQLStatment = "insert into Col_DomainsSchemaExtra (SchemaID, HeaderOrder, HeaderTitle) values (@SchemaID, @HeaderOrder, @HeaderTitle)";

        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            
        TSqlCommand.Parameters.AddWithValue("@SchemaID", SchemaID);
        TSqlCommand.Parameters.AddWithValue("@HeaderOrder", HeaderOrder);
        TSqlCommand.Parameters.AddWithValue("@HeaderTitle", HeaderTitle);

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

    }
}
