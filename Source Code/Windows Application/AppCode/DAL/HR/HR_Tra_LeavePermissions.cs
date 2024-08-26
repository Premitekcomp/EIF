using System;
using System.Data;
using System.Data.SqlClient;

//  ************************************************************  '
//  ***                                                      ***  '
//  *** Created By   : Miskasoft Programming and Web Design  ***  '
//  *** Developer    : Eng. Mohamed Roshdey                  ***  '
//  ***                                                      ***  '
//  *** Contacts     :mroshdey@miskasoft.com                 ***  '
//  *** Mobile       :+2 012 88499 007                       ***  '
//----------------------------------------------------------------'
//  18/2/2015 3:51:10 PM

namespace TMS.AppCode.DAL.HR
{
class HR_Tra_LeavePermissions
{
    public static int InsertRecord(int EmpID, DateTime Tra_Date, int EmployeeAttendanceID, DateTime FromTime, DateTime ToTime, string Notes, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Tra_LeavePermissions (EmpID, Tra_Date, EmployeeAttendanceID, FromTime, ToTime, Notes, IsDeleted, IsDeletable, RCDate, RCBy, LADate, LABy, RCBy) values (@EmpID, @Tra_Date, @EmployeeAttendanceID, @FromTime, @ToTime, @Notes, @IsDeleted, @IsDeletable, @RCDate, @RCBy, @LADate, @LABy, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@Tra_Date", Tra_Date);
TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
TSqlCommand.Parameters.AddWithValue("@FromTime", FromTime);
TSqlCommand.Parameters.AddWithValue("@ToTime", ToTime);
TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
TSqlCommand.Parameters.AddWithValue("@IsDeleted", IsDeleted);
TSqlCommand.Parameters.AddWithValue("@IsDeletable", IsDeletable);
TSqlCommand.Parameters.AddWithValue("@RCDate", RCDate);
TSqlCommand.Parameters.AddWithValue("@RCBy", RCBy);
TSqlCommand.Parameters.AddWithValue("@LADate", LADate);
TSqlCommand.Parameters.AddWithValue("@LABy", LABy);
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

public static int DeleteRecord(int EmployeeLeavePermissionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Tra_LeavePermissions where EmployeeLeavePermissionID=@EmployeeLeavePermissionID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);

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

public static int UpdateDeleteFlag(int EmployeeLeavePermissionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_LeavePermissions set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeLeavePermissionID=@EmployeeLeavePermissionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);
TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

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

public static int UpdateDeleteFlagWithCheck(int EmployeeLeavePermissionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_LeavePermissions set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeLeavePermissionID=@EmployeeLeavePermissionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);
TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

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

public static int RestoreDeleted(int EmployeeLeavePermissionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_LeavePermissions set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeLeavePermissionID=@EmployeeLeavePermissionID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);
TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

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

public static DataTable SelectAll()
{

GlobalParamters.SQLStatment = "select * from HR_Tra_LeavePermissions";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);


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

public static DataTable SelectAllDeleted()
{

GlobalParamters.SQLStatment = "select * from HR_Tra_LeavePermissions where IsDeleted=1";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);


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

public static DataTable SelectActiveRecorde()
{

GlobalParamters.SQLStatment = "select * from HR_Tra_LeavePermissions where IsDeleted=0";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);


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

public static DataTable SelectByPK(int EmployeeLeavePermissionID)
{

GlobalParamters.SQLStatment = "Select * from HR_Tra_LeavePermissions where EmployeeLeavePermissionID=@EmployeeLeavePermissionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);

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

public static int GetMax()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select max([EmployeeLeavePermissionID]) from HR_Tra_LeavePermissions";

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

public static int GetMin()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select min([EmployeeLeavePermissionID]) from HR_Tra_LeavePermissions";

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

public static int GetSum()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select sum([EmployeeLeavePermissionID]) from HR_Tra_LeavePermissions";

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

public static int GetCount()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select count([EmployeeLeavePermissionID]) from HR_Tra_LeavePermissions";

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

public static int UpdateRecord(int EmployeeLeavePermissionID, int EmpID, DateTime Tra_Date, int EmployeeAttendanceID, DateTime FromTime, DateTime ToTime, string Notes, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_LeavePermissions set EmpID=@EmpID, Tra_Date=@Tra_Date, EmployeeAttendanceID=@EmployeeAttendanceID, FromTime=@FromTime, ToTime=@ToTime, Notes=@Notes, IsDeleted=@IsDeleted, IsDeletable=@IsDeletable, RCDate=@RCDate, RCBy=@RCBy, LADate=@LADate, LABy=@LABy ,LADate=@LADate, LABy=@LABy where EmployeeLeavePermissionID=@EmployeeLeavePermissionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeLeavePermissionID", EmployeeLeavePermissionID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@Tra_Date", Tra_Date);
TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
TSqlCommand.Parameters.AddWithValue("@FromTime", FromTime);
TSqlCommand.Parameters.AddWithValue("@ToTime", ToTime);
TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
TSqlCommand.Parameters.AddWithValue("@IsDeleted", IsDeleted);
TSqlCommand.Parameters.AddWithValue("@IsDeletable", IsDeletable);
TSqlCommand.Parameters.AddWithValue("@RCDate", RCDate);
TSqlCommand.Parameters.AddWithValue("@RCBy", RCBy);
TSqlCommand.Parameters.AddWithValue("@LADate", LADate);
TSqlCommand.Parameters.AddWithValue("@LABy", LABy);
TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

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
