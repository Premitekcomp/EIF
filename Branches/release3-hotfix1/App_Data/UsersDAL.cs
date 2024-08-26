using EIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EIF
{
    public class UsersDAL
    {
        UserAccountEntities _enty = new UserAccountEntities();
        public short IsValid(string _username, string _password)
        {

            using (UserAccountEntities db = new UserAccountEntities())
            {
                int UserID = Convert.ToInt16(_username);
                Pre_UserData_Result res = db.Pre_UserData(UserID, _password).FirstOrDefault();

                if (res != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }

        public short HasPermission(int UserID, string PagePath)
        {

            using (UserAccountEntities db = new UserAccountEntities())
            {

                //Web_CheckUserPermission_Result res = db.Web_CheckUserPermission(UserID, PagePath).FirstOrDefault();

                //if (res != null)
                //{
                //    return 1;
                //}
                //else
                //{
                //    return 0;
                //}
                return 1;
            }
        }
    }
}