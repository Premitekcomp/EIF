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
class HR_Lup_AdministrativeDepartments
{
public static int InsertRecord(string DepartmentNameAr, string DepartmentNameEn)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Lup_AdministrativeDepartments (DepartmentNameAr, DepartmentNameEn,   RCBy) values (@DepartmentNameAr, @DepartmentNameEn , @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentNameAr", DepartmentNameAr);
TSqlCommand.Parameters.AddWithValue("@DepartmentNameEn", DepartmentNameEn);

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

public static int DeleteRecord(int DepartmentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Lup_AdministrativeDepartments where DepartmentID=@DepartmentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);

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

public static int UpdateDeleteFlag(int DepartmentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_AdministrativeDepartments set IsDeleted=1, LADate=@LADate, LABy=@LABy where DepartmentID=@DepartmentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);
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

public static int UpdateDeleteFlagWithCheck(int DepartmentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_AdministrativeDepartments set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and DepartmentID=@DepartmentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);
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

public static int RestoreDeleted(int DepartmentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_AdministrativeDepartments set IsDeleted=0, LADate=@LADate, LABy=@LABy where DepartmentID=@DepartmentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);
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

GlobalParamters.SQLStatment = "select * from HR_Lup_AdministrativeDepartments";

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

GlobalParamters.SQLStatment = "select * from HR_Lup_AdministrativeDepartments where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Lup_AdministrativeDepartments where IsDeleted=0";

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

public static DataTable SelectByPK(int DepartmentID)
{

GlobalParamters.SQLStatment = "Select * from HR_Lup_AdministrativeDepartments where DepartmentID=@DepartmentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);

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

GlobalParamters.SQLStatment = "select max([DepartmentID]) from HR_Lup_AdministrativeDepartments";

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

GlobalParamters.SQLStatment = "select min([DepartmentID]) from HR_Lup_AdministrativeDepartments";

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

GlobalParamters.SQLStatment = "select sum([DepartmentID]) from HR_Lup_AdministrativeDepartments";

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

GlobalParamters.SQLStatment = "select count([DepartmentID]) from HR_Lup_AdministrativeDepartments";

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

public static int UpdateRecord(int DepartmentID, string DepartmentNameAr, string DepartmentNameEn )
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Lup_AdministrativeDepartments set DepartmentNameAr=@DepartmentNameAr, DepartmentNameEn=@DepartmentNameEn , LADate=@LADate, LABy=@LABy where DepartmentID=@DepartmentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@DepartmentID", DepartmentID);
TSqlCommand.Parameters.AddWithValue("@DepartmentNameAr", DepartmentNameAr);
TSqlCommand.Parameters.AddWithValue("@DepartmentNameEn", DepartmentNameEn);
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
