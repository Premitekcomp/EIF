using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL
{
    class AdminWork
    {
        #region User Groups
        public static int NewGroup(string GroupTitle)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Pre_Groups (GroupTitle, RCBy) values (@GroupTitle, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@GroupTitle", GroupTitle);


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

        public static int UpdateGroup(int GroupID, string GroupTitle)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Pre_Groups set GroupTitle=@GroupTitle, LADate=@LADate, LABy=@LABy where GroupID=@GroupID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@GroupTitle", GroupTitle);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate",System.DateTime.Today);


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

        public static int DeleteGroup(int GroupID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Pre_Groups set IsDeleted=1, LADate=@LADate, LABy=@LABy where GroupID=@GroupID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static int RestoreGroup(int GroupID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Pre_Groups set IsDeleted=0, LADate=@LADate, LABy=@LABy where GroupID=@GroupID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static DataTable SelectGroup(int GroupID)
        {
            GlobalParamters.SQLStatment = "select * from Pre_Groups where GroupID=@GroupID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);


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

        public static DataTable SelectGroupMembers(int GroupID)
        {
            GlobalParamters.SQLStatment = "select * from Pre_GroupMemebersView where GroupID=@GroupID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);


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

        public static DataTable SelectPriceListMembers(int PricListID)
        {
            GlobalParamters.SQLStatment = "select * from Pre_PriceListPermission where PricListID=@PricListID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@PricListID", PricListID);


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


        public static DataTable SelectStoreMembers(int StoreID)
        {
            GlobalParamters.SQLStatment = "select * from Per_StorePermissionView where StoreID=@StoreID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@StoreID", StoreID);


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

        public static int DeleteGroupMember(int GroupID, int UserID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Pre_GroupsMembers set IsDeleted=1, LADate=@LADate, LABy=@LABy where GroupID=@GroupID and UserID=@UserID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static int DeleteStoreMember(int StoreID, int UserID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "delete Pre_StorePermissions where StoreID=@StoreID and UserID=@UserID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@StoreID", StoreID);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static int InsertGroupMember(int UserID, int GroupID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Pre_GroupsMembers (UserID, GroupID, RCBy) values (@UserID, @GroupID, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
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

        public static int InsertStoreMember(int UserID, int StoreID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Pre_StorePermissions (UserID, StoreID, RCBy) values (@UserID, @StoreID, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@StoreID", StoreID);


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
        #endregion

        #region Users
        public static int CheckLogicalInUserProfile(int EmployeeID, string UserName, string DisplayName)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select count(UserID) from Pre_Users where EmployeeID=@EmployeeID or DisplayName=@DisplayName or UserName=@UserName";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            TSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            TSqlCommand.Parameters.AddWithValue("@DisplayName", DisplayName);
            
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

        public static int CheckLogicalLinke(int EmployeeID, string UserName, string DisplayName)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "select count(UserID) from Pre_Users where EmployeeID=@EmployeeID and DisplayName=@DisplayName and UserName=@UserName";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            TSqlCommand.Parameters.AddWithValue("@UserName", UserName);
            TSqlCommand.Parameters.AddWithValue("@DisplayName", DisplayName);

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

        public static int NewUser(string DisplayName, string UserName, string Password, bool IsActive, byte[] ProfileImage, int EmployeeID, bool IsDoctor, int DoctorID)
        {
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("Pre_AddUser", GlobalParamters.DBConnection);
                SQLCmd.CommandType = CommandType.StoredProcedure;

                SQLCmd.Parameters.AddWithValue("@DisplayName", DisplayName);
                SQLCmd.Parameters.AddWithValue("@UserName", UserName);
                SQLCmd.Parameters.AddWithValue("@Password", Password);
                SQLCmd.Parameters.AddWithValue("@IsActive", IsActive);
                SQLCmd.Parameters.AddWithValue("@ProfileImage", ProfileImage);
                SQLCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                SQLCmd.Parameters.AddWithValue("@IsDoctor", IsDoctor);
                SQLCmd.Parameters.AddWithValue("@DoctorID", DoctorID);
                
                GlobalParamters.StatmentFireResult = SQLCmd.ExecuteNonQuery();
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }

            return GlobalParamters.StatmentFireResult;
        }

        public static int UpdateUser(string DisplayName, string UserName, string Password, bool IsActive, byte[] ProfileImage, int EmployeeID, int UserID)
        {
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("Pre_AddUser", GlobalParamters.DBConnection);
                SQLCmd.CommandType = CommandType.StoredProcedure;

                SQLCmd.Parameters.AddWithValue("@DisplayName", DisplayName);
                SQLCmd.Parameters.AddWithValue("@UserName", UserName);
                SQLCmd.Parameters.AddWithValue("@Password", Password);
                SQLCmd.Parameters.AddWithValue("@IsActive", IsActive);
                SQLCmd.Parameters.AddWithValue("@ProfileImage", ProfileImage);
                SQLCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                SQLCmd.Parameters.AddWithValue("@UserID", UserID);
                SQLCmd.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

                GlobalParamters.StatmentFireResult = SQLCmd.ExecuteNonQuery();
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }

            return GlobalParamters.StatmentFireResult;
        }

        public static int UpdateMyInfo(string DisplayName, byte[] ProfileImage, string ChatStatus)
        {
            if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
            {
                GlobalParamters.DBConnection.Open();
            }
            try
            {
                SqlCommand SQLCmd = new SqlCommand("Pre_UpdateMyInfor", GlobalParamters.DBConnection);
                SQLCmd.CommandType = CommandType.StoredProcedure;

                SQLCmd.Parameters.AddWithValue("@DisplayName", DisplayName);
                SQLCmd.Parameters.AddWithValue("@ProfileImage", ProfileImage);
                SQLCmd.Parameters.AddWithValue("@UserID", GlobalParamters.ActiveUserID);
                SQLCmd.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
                SQLCmd.Parameters.AddWithValue("@ChatStatus", ChatStatus);

                GlobalParamters.StatmentFireResult = SQLCmd.ExecuteNonQuery();
            }
            finally
            {

                GlobalParamters.DBConnection.Close();
            }

            return GlobalParamters.StatmentFireResult;
        }


        #endregion

        #region Permission
        public static int AddGroupPermission(int GroupID,int ActionID,int FormID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Pre_GroupPermissions (GroupID, ActionID, FormID, RCBy) values (@GroupID, @ActionID, @FormID, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);
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

        public static int RemoveGroupPermission(int GroupID, int ActionID, int FormID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "Delete Pre_GroupPermissions where GroupID=@GroupID and ActionID=@ActionID and FormID=@FormID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@ActionID", ActionID);
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

        public static DataTable GetSystemModules()
        {
            GlobalParamters.SQLStatment = "select ModuleID, ModuleTitle from Pre_SystemModules where IsHidden = 0 and IsDeleted = 0 order by DisplayOrder";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);


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

        public static DataTable GetModuleForms(int ModuleID)
        {
            GlobalParamters.SQLStatment = "select FormTitle, FormID from Pre_ModuleFormsView where ModuleID=@ModuleID order by FormTitle";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@ModuleID", ModuleID);


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

        public static DataTable GetFormsActions(int FormID)
        {
            GlobalParamters.SQLStatment = "select ActionID, ActionTitle from Pre_FormActionsView where FormID=@FormID order by ActionTitle";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);


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

        public static DataTable GetGroupPermissionsForms(int GroupID)
        {
            GlobalParamters.SQLStatment = "select FormID, FormTitle from Per_GroupPermissionView where GroupID=@GroupID Group By FormID, FormTitle";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);


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

        public static DataTable GetGroupPermissionsFormsForForm(int GroupID, int FormID)
        {
            GlobalParamters.SQLStatment = "select FormID, FormTitle from Per_GroupPermissionView where GroupID=@GroupID and FormID=@FormID Group By FormID, FormTitle";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);

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


        public static DataTable GetGroupPermissionsActions(int GroupID, int FormID)
        {
            GlobalParamters.SQLStatment = "select ActionID, ActionTitle from Per_GroupPermissionView where GroupID=@GroupID and FormID=@FormID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@FormID", FormID);

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

        public static int CheckUserInGroup(int GroupID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "Select count(RecordSerial) from Pre_GroupsMembers where GroupID=@GroupID and UserID=@UserID and IsDeleted=0";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@GroupID", GroupID);
            TSqlCommand.Parameters.AddWithValue("@UserID", GlobalParamters.ActiveUserID);

            try
            {
                if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
                {
                    GlobalParamters.DBConnection.Open();
                }
                StatmentFireResult =Convert.ToInt32(TSqlCommand.ExecuteScalar());
                GlobalParamters.DBConnection.Close();
                return StatmentFireResult;
            }
            catch
            {
                StatmentFireResult = 0;
                return StatmentFireResult;
            }
        }

        #endregion

        #region Misc
        public static DataTable LoadOnlineUsers()
        {
            GlobalParamters.SQLStatment = "select DisplayName, UserName, ProfileImage, Pre_UserStatus.UserID from Pre_Users INNER JOIN Pre_UserStatus ON Pre_Users.UserID = Pre_UserStatus.UserID where IsOnline=1";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

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

        public static DataTable LoadBlockedUsers()
        {
            GlobalParamters.SQLStatment = "select DisplayName, UserName, ProfileImage, UserID from Pre_Users where IsActive=0";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

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

        public static int ChengeUserBlockStatus(int UserID, bool IsActive)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set IsActive=@IsActive where UserID=@UserID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@IsActive", IsActive);

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

        public static int UnBlockAllUsesr(bool IsActive)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update Pre_Users set IsActive=@IsActive";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@IsActive", IsActive);

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
        #endregion

        #region SafeBox
        public static int NewSafeBox(string SafeBoxTiltle, bool IsBankAccount, int BrnachID, int SubAccountID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Fin_Lup_SafeBoxList (SafeBoxTiltle, IsBankAccount, RCBy, BrnachID) values (@SafeBoxTiltle, @IsBankAccount, @RCBy, @BrnachID)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@SafeBoxTiltle", SafeBoxTiltle);
            TSqlCommand.Parameters.AddWithValue("@IsBankAccount", IsBankAccount);
            TSqlCommand.Parameters.AddWithValue("@BrnachID", BrnachID);
            TSqlCommand.Parameters.AddWithValue("@SubAccountID", SubAccountID);

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

        public static int DeleteSafeBox(int SafeBoxID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Fin_Lup_SafeBoxList set IsDeleted=1, LADate=@LADate, LABy=@LABy where SafeBoxID=@SafeBoxID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SafeBoxID", SafeBoxID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static int RestoreSafeBox(int SafeBoxID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Fin_Lup_SafeBoxList set IsDeleted=0, LADate=@LADate, LABy=@LABy where SafeBoxID=@SafeBoxID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SafeBoxID", SafeBoxID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        public static DataTable SelectSafeBoxMembers(int SafeBoxID)
        {
            GlobalParamters.SQLStatment = "select * from Fin_SafeBoxMembersView where SafeBoxID=@SafeBoxID";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SafeBoxID", SafeBoxID);


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

        public static int InsertSafeBoxMember(int SafeBoxID, int UserID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Fin_Lup_SafeBoxUsers (SafeBoxID, UserID, RCBy) values (@SafeBoxID, @UserID, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@SafeBoxID", SafeBoxID);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);


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

        public static int DeleteSafeBoxMember(int SafeBoxID, int UserID)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "update Fin_Lup_SafeBoxUsers set IsDeleted=1, LADate=@LADate, LABy=@LABy where SafeBoxID=@SafeBoxID and UserID=@UserID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@SafeBoxID", SafeBoxID);
            TSqlCommand.Parameters.AddWithValue("@UserID", UserID);
            TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Today);


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

        #endregion

        public static int NewSrvGroup(string GroupTitle)
        {
            int StatmentFireResult = 0;
            GlobalParamters.SQLStatment = "insert into Inv_ItemServiceGroup (GroupTitle, RCBy) values (@GroupTitle, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
            TSqlCommand.Parameters.AddWithValue("@GroupTitle", GroupTitle);



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
