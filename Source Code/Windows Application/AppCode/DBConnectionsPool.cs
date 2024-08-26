using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode
{
    class DBConnectionsPool
    {
        public static void PickRightDBConnection()
        {
            if(GlobalParamters.ClientName == "EIF")
            {
                GlobalParamters.DBConnection.ConnectionString = "Data Source=.;Initial Catalog=Ehospital_am_DataCollection;User ID=TMSAdmin;password=10001";
            }
            
        }
        
    }
}
