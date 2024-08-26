using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.HR
{
    class HR_PreSalCalculationSheetView
    {
        public static DataTable SelectByPK(int EmployeeID)
        {

            GlobalParamters.SQLStatment = "Select * from HR_PreSalCalculationSheetView where EmployeeID=@EmployeeID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            DataTable dt = new DataTable();
            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                SqlDataReader dr = TSqlCommand.ExecuteReader();
                dt.Load(dr);
                GlobalParamters.DBConnection.Close();
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
