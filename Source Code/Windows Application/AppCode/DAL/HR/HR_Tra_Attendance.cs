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
class HR_Tra_Attendance
{
public static int InsertRecord(int EmpID, DateTime AttendanceDate, DateTime ExpectedFrom, DateTime ExpectedTo, DateTime ActualFrom, DateTime ActualTo, bool WorkDay, bool IsMission, int VacationtypeID, bool IsWorkByHour, int ShiftID, string Notes, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Tra_Attendance (EmpID, AttendanceDate, ExpectedFrom, ExpectedTo, ActualFrom, ActualTo, WorkDay, IsMission, VacationtypeID, IsWorkByHour, ShiftID, Notes, IsDeleted, IsDeletable, RCDate, RCBy, LADate, LABy, RCBy) values (@EmpID, @AttendanceDate, @ExpectedFrom, @ExpectedTo, @ActualFrom, @ActualTo, @WorkDay, @IsMission, @VacationtypeID, @IsWorkByHour, @ShiftID, @Notes, @IsDeleted, @IsDeletable, @RCDate, @RCBy, @LADate, @LABy, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
TSqlCommand.Parameters.AddWithValue("@ExpectedFrom", ExpectedFrom);
TSqlCommand.Parameters.AddWithValue("@ExpectedTo", ExpectedTo);
TSqlCommand.Parameters.AddWithValue("@ActualFrom", ActualFrom);
TSqlCommand.Parameters.AddWithValue("@ActualTo", ActualTo);
TSqlCommand.Parameters.AddWithValue("@WorkDay", WorkDay);
TSqlCommand.Parameters.AddWithValue("@IsMission", IsMission);
TSqlCommand.Parameters.AddWithValue("@VacationtypeID", VacationtypeID);
TSqlCommand.Parameters.AddWithValue("@IsWorkByHour", IsWorkByHour);
TSqlCommand.Parameters.AddWithValue("@ShiftID", ShiftID);
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

public static int DeleteRecord(int EmployeeAttendanceID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Tra_Attendance where EmployeeAttendanceID=@EmployeeAttendanceID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);

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

public static int UpdateDeleteFlag(int EmployeeAttendanceID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Attendance set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeAttendanceID=@EmployeeAttendanceID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeeAttendanceID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Attendance set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeAttendanceID=@EmployeeAttendanceID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
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

public static int RestoreDeleted(int EmployeeAttendanceID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Attendance set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeAttendanceID=@EmployeeAttendanceID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
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

GlobalParamters.SQLStatment = "select * from HR_Tra_Attendance";

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

GlobalParamters.SQLStatment = "select * from HR_Tra_Attendance where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Tra_Attendance where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeAttendanceID)
{

GlobalParamters.SQLStatment = "Select * from HR_Tra_Attendance where EmployeeAttendanceID=@EmployeeAttendanceID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);

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

GlobalParamters.SQLStatment = "select max([EmployeeAttendanceID]) from HR_Tra_Attendance";

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

GlobalParamters.SQLStatment = "select min([EmployeeAttendanceID]) from HR_Tra_Attendance";

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

GlobalParamters.SQLStatment = "select sum([EmployeeAttendanceID]) from HR_Tra_Attendance";

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

GlobalParamters.SQLStatment = "select count([EmployeeAttendanceID]) from HR_Tra_Attendance";

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

public static int UpdateRecord(int EmployeeAttendanceID, int EmpID, DateTime AttendanceDate, DateTime ExpectedFrom, DateTime ExpectedTo, DateTime ActualFrom, DateTime ActualTo, bool WorkDay, bool IsMission, int VacationtypeID, bool IsWorkByHour, int ShiftID, string Notes, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Attendance set EmpID=@EmpID, AttendanceDate=@AttendanceDate, ExpectedFrom=@ExpectedFrom, ExpectedTo=@ExpectedTo, ActualFrom=@ActualFrom, ActualTo=@ActualTo, WorkDay=@WorkDay, IsMission=@IsMission, VacationtypeID=@VacationtypeID, IsWorkByHour=@IsWorkByHour, ShiftID=@ShiftID, Notes=@Notes, IsDeleted=@IsDeleted, IsDeletable=@IsDeletable, RCDate=@RCDate, RCBy=@RCBy, LADate=@LADate, LABy=@LABy ,LADate=@LADate, LABy=@LABy where EmployeeAttendanceID=@EmployeeAttendanceID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeAttendanceID", EmployeeAttendanceID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@AttendanceDate", AttendanceDate);
TSqlCommand.Parameters.AddWithValue("@ExpectedFrom", ExpectedFrom);
TSqlCommand.Parameters.AddWithValue("@ExpectedTo", ExpectedTo);
TSqlCommand.Parameters.AddWithValue("@ActualFrom", ActualFrom);
TSqlCommand.Parameters.AddWithValue("@ActualTo", ActualTo);
TSqlCommand.Parameters.AddWithValue("@WorkDay", WorkDay);
TSqlCommand.Parameters.AddWithValue("@IsMission", IsMission);
TSqlCommand.Parameters.AddWithValue("@VacationtypeID", VacationtypeID);
TSqlCommand.Parameters.AddWithValue("@IsWorkByHour", IsWorkByHour);
TSqlCommand.Parameters.AddWithValue("@ShiftID", ShiftID);
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
