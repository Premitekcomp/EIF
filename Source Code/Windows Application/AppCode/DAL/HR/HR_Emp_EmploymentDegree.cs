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
//  19/2/2015 3:18:18 PM

namespace TMS.AppCode.DAL.HR
{
class HR_Emp_EmploymentDegree
{
public static int InsertRecord(int EmpID, int DegreeID, DateTime FromDate, DateTime ToDate, bool IsCurrent, string Note)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_EmploymentDegree (EmpID, DegreeID, FromDate, ToDate, IsCurrent, Note, RCBy) values (@EmpID, @DegreeID, @FromDate, @ToDate, @IsCurrent, @Note, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@DegreeID", DegreeID);
TSqlCommand.Parameters.AddWithValue("@FromDate", FromDate);
TSqlCommand.Parameters.AddWithValue("@ToDate", ToDate);
TSqlCommand.Parameters.AddWithValue("@IsCurrent", IsCurrent);
TSqlCommand.Parameters.AddWithValue("@Note", Note);
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

public static int DeleteRecord(int EmployeeDegreeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_EmploymentDegree where EmployeeDegreeID=@EmployeeDegreeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);

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

public static int UpdateDeleteFlag(int EmployeeDegreeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_EmploymentDegree set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeDegreeID=@EmployeeDegreeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);
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

public static int UpdateIsCurrentFlag(int EmpID)
{
    int StatmentFireResult = 0;

    GlobalParamters.SQLStatment = "Update HR_Emp_EmploymentDegree set IsCurrent=0, LADate=@LADate, LABy=@LABy where EmpID=@EmpID";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeeDegreeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_EmploymentDegree set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeDegreeID=@EmployeeDegreeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);
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

public static int RestoreDeleted(int EmployeeDegreeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_EmploymentDegree set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeDegreeID=@EmployeeDegreeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_EmploymentDegree";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_EmploymentDegree where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_EmploymentDegree where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeDegreeID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_EmploymentDegree where EmployeeDegreeID=@EmployeeDegreeID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);

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

GlobalParamters.SQLStatment = "select max([EmployeeDegreeID]) from HR_Emp_EmploymentDegree";

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

GlobalParamters.SQLStatment = "select min([EmployeeDegreeID]) from HR_Emp_EmploymentDegree";

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

GlobalParamters.SQLStatment = "select sum([EmployeeDegreeID]) from HR_Emp_EmploymentDegree";

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

GlobalParamters.SQLStatment = "select count([EmployeeDegreeID]) from HR_Emp_EmploymentDegree";

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

public static int UpdateRecord(int EmployeeDegreeID, int EmpID, int DegreeID, DateTime FromDate, DateTime ToDate, bool IsCurrent,string Note)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_EmploymentDegree set EmpID=@EmpID, DegreeID=@DegreeID, FromDate=@FromDate, ToDate=@ToDate, IsCurrent=@IsCurrent, Note=@Note, LADate=@LADate, LABy=@LABy where EmployeeDegreeID=@EmployeeDegreeID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDegreeID", EmployeeDegreeID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@DegreeID", DegreeID);
TSqlCommand.Parameters.AddWithValue("@FromDate", FromDate);
TSqlCommand.Parameters.AddWithValue("@ToDate", ToDate);
TSqlCommand.Parameters.AddWithValue("@IsCurrent", IsCurrent);
TSqlCommand.Parameters.AddWithValue("@Note", Note);
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
