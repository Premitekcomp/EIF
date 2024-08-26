using TMS.AppCode;
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
//  2/3/2015 10:42:05 AM

namespace TMS.AppCode.DAL.HR
{
class HR_Lup_YearsMonths
{
public static int InsertRecord(int MonthIndex, int YearID, DateTime FromDate, DateTime ToDate, bool Closed)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Lup_YearsMonths (MonthIndex, YearID, FromDate, ToDate, Closed, RCDate, RCBy) values (@MonthIndex, @YearID, @FromDate, @ToDate, @Closed, @RCDate, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@MonthIndex", MonthIndex);
TSqlCommand.Parameters.AddWithValue("@YearID", YearID);
TSqlCommand.Parameters.AddWithValue("@FromDate", FromDate);
TSqlCommand.Parameters.AddWithValue("@ToDate", ToDate);
TSqlCommand.Parameters.AddWithValue("@Closed", Closed);
TSqlCommand.Parameters.AddWithValue("@RCDate", DateTime.Now);
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

public static int DeleteRecord(int YearMonthID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Lup_YearsMonths where YearMonthID=@YearMonthID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);

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

public static int UpdateDeleteFlag(int YearMonthID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_YearsMonths set IsDeleted=1, LADate=@LADate, LABy=@LABy where YearMonthID=@YearMonthID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);
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

public static int UpdateDeleteFlagWithCheck(int YearMonthID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_YearsMonths set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and YearMonthID=@YearMonthID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);
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

public static int RestoreDeleted(int YearMonthID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_YearsMonths set IsDeleted=0, LADate=@LADate, LABy=@LABy where YearMonthID=@YearMonthID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);
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

GlobalParamters.SQLStatment = "select * from HR_Lup_YearsMonths";

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

GlobalParamters.SQLStatment = "select * from HR_Lup_YearsMonths where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Lup_YearsMonths where IsDeleted=0";

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

public static DataTable SelectByPK(int YearMonthID)
{

GlobalParamters.SQLStatment = "Select * from HR_Lup_YearsMonths where YearMonthID=@YearMonthID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);

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

GlobalParamters.SQLStatment = "select max([YearMonthID]) from HR_Lup_YearsMonths";

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

GlobalParamters.SQLStatment = "select min([YearMonthID]) from HR_Lup_YearsMonths";

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

GlobalParamters.SQLStatment = "select sum([YearMonthID]) from HR_Lup_YearsMonths";

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

GlobalParamters.SQLStatment = "select count([YearMonthID]) from HR_Lup_YearsMonths";

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

public static int UpdateRecord(int YearMonthID, bool Closed)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_YearsMonths set  Closed=@Closed, LADate=@LADate, LABy=@LABy where YearMonthID=@YearMonthID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@YearMonthID", YearMonthID);
TSqlCommand.Parameters.AddWithValue("@Closed", Closed);
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
