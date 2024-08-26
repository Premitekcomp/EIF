using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.CollectionDept
{
    class DCRReporting
    {

        public static DataTable VisitTypeStstics(int DomainID, DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.SQLStatment = "select ConnectionType, COUNT(RecordSerial) AS Count from Col_DCRFullView where DomainID=@DomainID and ConnectionDate Between @StartDate and @EndDate Group By ConnectionType";
            //GlobalParamters.SQLStatment = "select * from v1 where DomainID=@DomainID Group By ConnectionType";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@StartDate", StartDate);
            TSqlCommand.Parameters.AddWithValue("@EndDate", EndDate);

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

        public static DataTable PTPStstics(int DomainID, DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.SQLStatment = "select PTPType, COUNT(RecordSerial) AS PTPTypeCount from Col_DCRFullView where DomainID=@DomainID and ConnectionDate Between @StartDate and @EndDate Group By PTPType";
            //GlobalParamters.SQLStatment = "select * from v1 where DomainID=@DomainID Group By ConnectionType";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@StartDate", StartDate);
            TSqlCommand.Parameters.AddWithValue("@EndDate", EndDate);

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

        public static DataTable CollectionStstics(int DomainID, DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.SQLStatment = "select SUM(PTPAmount) as PTPSUM, SUM(Kept) AS KeptNo, SUM(KeptAmount) AS KeptSum, SUM(Broken) as BrokenNo from Col_DCRFullView where DomainID=@DomainID and ConnectionDate Between @StartDate and @EndDate";
            //GlobalParamters.SQLStatment = "select * from v1 where DomainID=@DomainID Group By ConnectionType";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@DomainID", DomainID);
            TSqlCommand.Parameters.AddWithValue("@StartDate", StartDate);
            TSqlCommand.Parameters.AddWithValue("@EndDate", EndDate);

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

        public static int DeleteDCRRecord(int RecordSerial)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "delete Col_DailyVisits where RecordSerial=@RecordSerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);

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
