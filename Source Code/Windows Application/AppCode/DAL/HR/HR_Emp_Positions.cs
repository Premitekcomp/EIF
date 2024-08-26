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
class HR_Emp_Positions
{
public static int InsertRecord(int EmpID, int PositionID, DateTime FromDate, DateTime ToDate, string Note)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_Positions (EmpID, PositionID, FromDate, ToDate, Note,  RCBy) values (@EmpID, @PositionID, @FromDate, @ToDate, @Note,  @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@PositionID", PositionID);
TSqlCommand.Parameters.AddWithValue("@FromDate", FromDate);
TSqlCommand.Parameters.AddWithValue("@ToDate", ToDate);
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

public static int DeleteRecord(int EmployeePositionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_Positions where EmployeePositionID=@EmployeePositionID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);

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

public static int UpdateDeleteFlag(int EmployeePositionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Positions set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeePositionID=@EmployeePositionID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeePositionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Positions set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeePositionID=@EmployeePositionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);
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

public static int RestoreDeleted(int EmployeePositionID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Positions set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeePositionID=@EmployeePositionID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_Positions";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Positions where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Positions where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeePositionID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_Positions where EmployeePositionID=@EmployeePositionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);

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

public static DataTable SelectByEmpID(int EmpID)
{

    GlobalParamters.SQLStatment = "Select * from HR_Emp_Positions where EmpID=@EmpID";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);

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

public static DataTable SelectByEmpIDIsCurrent(int EmpID)
{

    GlobalParamters.SQLStatment = "Select * from HR_Emp_Positions where EmpID=@EmpID and IsCurrent =1";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);

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

public static int UpdateIsCurrentFlagWithCheck(int EmployeePositionID)
{
    int StatmentFireResult = 0;

    GlobalParamters.SQLStatment = "Update HR_Emp_Positions set IsCurrent =0 , ToDate = @ToDate  where IsDeletable=1 and EmployeePositionID=@EmployeePositionID";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);
    //TSqlCommand.Parameters.AddWithValue("@LADate", System.DateTime.Now);
    TSqlCommand.Parameters.AddWithValue("@ToDate", System.DateTime.Now);
    //TSqlCommand.Parameters.AddWithValue("@LABy", GlobalParamters.ActiveUserID);

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

public static int GetMax()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select max([EmployeePositionID]) from HR_Emp_Positions";

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

GlobalParamters.SQLStatment = "select min([EmployeePositionID]) from HR_Emp_Positions";

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

GlobalParamters.SQLStatment = "select sum([EmployeePositionID]) from HR_Emp_Positions";

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

GlobalParamters.SQLStatment = "select count([EmployeePositionID]) from HR_Emp_Positions";

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

public static int UpdateRecord(int EmployeePositionID, int EmpID, int PositionID, DateTime FromDate, DateTime ToDate, string Note)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Positions set EmpID=@EmpID, PositionID=@PositionID, FromDate=@FromDate, ToDate=@ToDate, Note=@Note, IsCurrent=@IsCurrent, LADate=@LADate, LABy=@LABy where EmployeePositionID=@EmployeePositionID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeePositionID", EmployeePositionID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@PositionID", PositionID);
TSqlCommand.Parameters.AddWithValue("@Note", Note);
TSqlCommand.Parameters.AddWithValue("@FromDate", FromDate);
TSqlCommand.Parameters.AddWithValue("@ToDate", ToDate);
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
