using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.BLL
{
    class Pre_Authentication
    {
        public static bool GetActivationFlag(int CopyID)
        {
            return true;

            // Implement Online Activation Mecanism Later
            #region Activation Online
            //bool StatmentFireResult = false;

            //GlobalParamters.SQLStatment = "select IsActive from Pre_ApplicationList where CopyID=@CopyID";
            //SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            //TSqlCommand.Parameters.AddWithValue("@CopyID", CopyID);

            //try
            //{
            //    if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            //    {
            //        GlobalParamters.DBConnection.Open();
            //    }
            //    StatmentFireResult = Convert.ToBoolean(TSqlCommand.ExecuteScalar());
            //    GlobalParamters.DBConnection.Close();
            //    return StatmentFireResult;
            //}
            //catch
            //{
            //    StatmentFireResult = false;
            //    return StatmentFireResult;
            //}
            #endregion

        }

        public static int CheckSerial(string CopySerial)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select count(CopyID) from Pre_ApplicationList where CopyID=@CopyID and CopySerial=@CopySerial";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@CopySerial", CopySerial);
            TSqlCommand.Parameters.AddWithValue("@CopyID", GlobalParamters.ProgramSerial);

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

        public static int AuthnticateUser(int UserID, string Password)
        {
            int StatmentFireResult = 0;
            
            SqlCommand TSqlCommand = new SqlCommand();
            TSqlCommand.Connection = GlobalParamters.DBConnection;
            TSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            TSqlCommand.CommandText = "Pre_Authenticate";

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@Password", Password);

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


        public static int UpdateUserPW(int UserID, string Password)
        {
            int StatmentFireResult = 0;

            SqlCommand TSqlCommand = new SqlCommand();
            TSqlCommand.Connection = GlobalParamters.DBConnection;
            TSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            TSqlCommand.CommandText = "Pre_ChangePassword";

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@Password", Password);

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

        public static int UpdateUserHRLink(int UserID, int EmployeeID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set EmployeeID=@EmployeeID where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

        public static int UpdateUserDrLink(int UserID, int DoctorID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set DoctorID=@DoctorID, IsDoctor=1 where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static int UpdateUseName(int UserID, string UserName)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set UserName=@UserName where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@UserName", UserName);

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

        // Check User Premission to Access Form
        public static int CheckAccessPremission(int FormID, int ActionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select count([UserID]) from Pre_AccessPremissionView where UserID=@UserID and FormID=@FormID and ActionID=@ActionID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);

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

        public static int BlockActivateUsers(int UserID, bool UserStatus)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set IsActive=@UserStatus where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@UserStatus", UserStatus);

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

        public static int AssignPermission(int GroupID, int FormID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Pre_GroupPermissions (GroupID, ActionID, FormID) values (@GroupID, @ActionID, @FormID)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", 1);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);

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

        public static int AddNewUser(string UserName, string Password)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Pre_Users (UserName, Password) values (@UserName, @Password)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            TSqlCommand.Parameters.AddWithValue("@Password", Password);

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

        public static int AddUsertoGroups(int GroupID, int UserID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into Pre_UsersGroups (UserID, GroupID) values (@UserID, @GroupID)";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);

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

        public static int RemoveUserFromGroups(int RecordSerial)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_UsersGroups set IsDeleted=1 where RecordSerial=@RecordSerial";
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

        public static int RemovePermissionFromGroups(int GroupID, int FormID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "Delete Pre_GroupPermissions where GroupID=@GroupID and FormID=@FormID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);

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

        public static int CurrentOpenShift()
        {
            int OpenShiftID = 0;

            GlobalParamters.SQLStatment = "select ShiftsID from Lup_WorkingShifts where StillOpen=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);


            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                OpenShiftID = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return OpenShiftID;
            }
            catch
            {
                OpenShiftID = 0;
                return OpenShiftID;
            }
        }

        public static DataTable CurrentUserInfo()
        {
            GlobalParamters.SQLStatment = "select * from Pre_Users where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@UserID", GlobalParamters.ActiveUserID);

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

        public static DataTable CurrentSelectedUserInfo(int UserID)
        {
            GlobalParamters.SQLStatment = "select * from Pre_Users where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetUserListWithoutMe(int UserID)
        {
            string TSQL = "SELECT UserID, DisplayName, ProfileImage, (SELECT COUNT(RID) AS Expr1 FROM AOV_LiveChat WHERE FromID=Pre_Users.UserID and ToID=@UserID and SeenDate IS NULL) AS UnReadCount FROM Pre_Users where UserID <> @UserID Order By UnReadCount Desc, DisplayName";
            GlobalParamters.SQLStatment = TSQL; // "select * from Pre_Users where UserID <> @UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetReciverInfo(int ActiveReciverID)
        {
            string TSQL = "SELECT DisplayName, ProfileImage, ChatStatus FROM Pre_Users where UserID=@ActiveReciverID";
            GlobalParamters.SQLStatment = TSQL; // "select * from Pre_Users where UserID <> @UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ActiveReciverID", ActiveReciverID);

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

        public static bool ReturnBoolConfig(int FieldID)
        {
            bool ReturnValue = false;

            GlobalParamters.SQLStatment = "select FieldBoolValue from Configuration where FieldID=@FieldID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@FieldID", FieldID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ReturnValue = Convert.ToBoolean(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return ReturnValue;
            }
            catch
            {
                return ReturnValue;
            }
        }

        public static int ReturnIntConfig(int FieldID)
        {
            int ReturnValue = 0;

            GlobalParamters.SQLStatment = "select FieldNumberValue from Configuration where FieldID=@FieldID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@FieldID", FieldID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ReturnValue = Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return ReturnValue;
            }
            catch
            {
                return ReturnValue;
            }
        }

        public static string ReturnStringConfig(int FieldID)
        {
            string ReturnValue = "";

            GlobalParamters.SQLStatment = "select FieldStringValue from Configuration where FieldID=@FieldID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@FieldID", FieldID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                ReturnValue = TSqlCommand.ExecuteScalar().ToString();
                GlobalParamters.DBConnection.Close();
                return ReturnValue;
            }
            catch
            {
                return ReturnValue;
            }
        }
    }
}
