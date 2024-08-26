using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.AppCode.DAL.HR
{
    class HR_Basics
    {
        public static int InsertWorkingTime(string WorkingTimeTitle, DateTime StartTime, DateTime EndTime)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Lup_WorkingTimes (WorkingTimeTitle, StartTime, EndTime, RCBy) values (@WorkingTimeTitle, @StartTime, @EndTime, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@WorkingTimeTitle", WorkingTimeTitle);
            TSqlCommand.Parameters.AddWithValue("@StartTime", StartTime);
            TSqlCommand.Parameters.AddWithValue("@EndTime", EndTime);
            
            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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

        public static int InsertWorkingPlan(int EmpID, DateTime AttendanceDate, DateTime ExpectedFrom, DateTime ExpectedTo)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Tra_Attendance (EmpID, AttendanceDate, ExpectedFrom, ExpectedTo, RCBy) values (@EmpID, @AttendanceDate, @ExpectedFrom, @ExpectedTo, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@ExpectedFrom", ExpectedFrom);
            TSqlCommand.Parameters.AddWithValue("@ExpectedTo", ExpectedTo);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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

        public static int GetEmpID(int EmployeeFPNo)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select EmployeeID from HR_Emp_BasicInfo where EmployeeFPNo=@EmployeeFPNo";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmployeeFPNo", EmployeeFPNo);
            

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

        public static int UpdateCheckIn(int EmpID, DateTime AttendanceDate, DateTime ActualFrom)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set ActualFrom=@ActualFrom where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@ActualFrom", ActualFrom);
            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);

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

        public static int UpdateCheckOut(int EmpID, DateTime AttendanceDate, DateTime ActualTo)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set ActualTo=@ActualTo where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@ActualTo", ActualTo);
            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);

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

        public static int UpdateInMission(int EmpID, DateTime AttendanceDate)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set InMission=1 where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);

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

        public static int InsertLeavePermission(int EmpID, DateTime Tra_Date, DateTime FromTime, DateTime ToTime, decimal HourCount, string PermissionType, int PermissionTypeIndex, string Notes)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "insert into HR_Tra_LeavePermissions (EmpID, Tra_Date, FromTime, ToTime, HourCount, PermissionType, PermissionTypeIndex, Notes, RCBy) values (@EmpID, @Tra_Date, @FromTime, @ToTime, @HourCount, @PermissionType, @PermissionTypeIndex, @Notes, @RCBy)";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@Tra_Date", Tra_Date);
            TSqlCommand.Parameters.AddWithValue("@FromTime", FromTime);
            TSqlCommand.Parameters.AddWithValue("@ToTime", ToTime);
            TSqlCommand.Parameters.AddWithValue("@HourCount", HourCount);
            TSqlCommand.Parameters.AddWithValue("@PermissionType", PermissionType);
            TSqlCommand.Parameters.AddWithValue("@PermissionTypeIndex", PermissionTypeIndex);
            TSqlCommand.Parameters.AddWithValue("@Notes", Notes);

            TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);


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

        public static int GetLeavePermissionID(int EmpID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "select max(EmployeeLeavePermissionID) from HR_Tra_LeavePermissions where EmpID=@EmpID";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            
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

        public static int UpdatePermissionComeLate(int EmpID, DateTime AttendanceDate, DateTime ExpectedFrom, int PermissionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set leavePermission=1, ExpectedFrom=@ExpectedFrom, PermissionID=@PermissionID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@ExpectedFrom", ExpectedFrom);
            TSqlCommand.Parameters.AddWithValue("@PermissionID", PermissionID);

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

        public static int UpdatePermissionLeaveEarly(int EmpID, DateTime AttendanceDate, DateTime ExpectedTo, int PermissionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set leavePermission=1, ExpectedTo=@ExpectedTo, PermissionID=@PermissionID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@ExpectedTo", ExpectedTo);
            TSqlCommand.Parameters.AddWithValue("@PermissionID", PermissionID);

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

        public static int UpdatePermissionDuring(int EmpID, DateTime AttendanceDate, int PermissionID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set leavePermission=1, PermissionID=@PermissionID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@PermissionID", PermissionID);

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

        public static DataTable GetVacationAttandanceList(int EmpID, DateTime StartDate, DateTime EndDate)
        {
            GlobalParamters.SQLStatment = "select * from HR_Tra_Attendance where EmpID=@EmpID and AttendanceDate between @StartDate and @EndDate";
            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
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

        public static int UpdateVacation(int EmpID, DateTime AttendanceDate, int VacationtypeID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set InVacation=1, VacationtypeID=@VacationtypeID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@VacationtypeID", VacationtypeID);

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

        public static int UpdateBounce(int EmpID, DateTime AttendanceDate, int BounceID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set BounceID=@BounceID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@BounceID", BounceID);

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

        public static int UpdatePenality(int EmpID, DateTime AttendanceDate, int PenalityID)
        {
            int StatmentFireResult = 0;

            GlobalParamters.SQLStatment = "update HR_Tra_Attendance set PenalityID=@PenalityID where EmpID=@EmpID and AttendanceDate=@AttendanceDate";

            SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

            TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
            TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
            TSqlCommand.Parameters.AddWithValue("@PenalityID", PenalityID);

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
