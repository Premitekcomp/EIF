using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.CollectionDept
{
    class CollectorsConfig
    {
        public static int InsertNewTeam(string TeamName)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Col_Lup_TeamList (TeamName) values (@TeamName)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@TeamName", TeamName);
            

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

        public static int UpdateTeamName(int TeamID, string TeamName)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Col_Lup_TeamList set TeamName=@TeamName where TeamID=@TeamID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@TeamName", TeamName);
            TSqlCommand.Parameters.AddWithValue("@TeamID", TeamID);


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
