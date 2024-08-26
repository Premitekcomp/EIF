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
//  17/2/2015 3:37:37 PM

namespace TMS.AppCode.DAL.HR
{
class HR_Emp_Salary
{
public static int InsertRecord(int EmpID, decimal BasicSalaryWithoutAdvance, decimal TotaLAdvance, decimal BasicSalary, decimal VariantSalary)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_Salary (EmpID, BasicSalaryWithoutAdvance, TotaLAdvance, BasicSalary, VariantSalary, IsCurrent, RCBy) values (@EmpID, @BasicSalaryWithoutAdvance, @TotaLAdvance, @BasicSalary, @VariantSalary, @IsCurrent, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@BasicSalaryWithoutAdvance", BasicSalaryWithoutAdvance);
TSqlCommand.Parameters.AddWithValue("@TotaLAdvance", TotaLAdvance);
TSqlCommand.Parameters.AddWithValue("@BasicSalary", BasicSalary);
TSqlCommand.Parameters.AddWithValue("@VariantSalary", VariantSalary);
TSqlCommand.Parameters.AddWithValue("@IsCurrent", 1);
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

public static int DeleteRecord(int EmployeeSalaryHistoryID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_Salary where EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);

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

public static int UpdateDeleteFlag(int EmployeeSalaryHistoryID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Salary set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);
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

    GlobalParamters.SQLStatment = "Update HR_Emp_Salary set IsCurrent=0, LADate=@LADate, LABy=@LABy where EmpID=@EmpID";

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

public static int UpdateDeleteFlagWithCheck(int EmployeeSalaryHistoryID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Salary set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);
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

public static int RestoreDeleted(int EmployeeSalaryHistoryID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Salary set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_Salary";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Salary where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Salary where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeSalaryHistoryID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_Salary where EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);

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

GlobalParamters.SQLStatment = "select max([EmployeeSalaryHistoryID]) from HR_Emp_Salary";

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

GlobalParamters.SQLStatment = "select min([EmployeeSalaryHistoryID]) from HR_Emp_Salary";

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

GlobalParamters.SQLStatment = "select sum([EmployeeSalaryHistoryID]) from HR_Emp_Salary";

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

GlobalParamters.SQLStatment = "select count([EmployeeSalaryHistoryID]) from HR_Emp_Salary";

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

public static int UpdateRecord(int EmployeeSalaryHistoryID, int EmpID, decimal BasicSalaryWithoutAdvance, decimal TotaLAdvance, decimal BasicSalary, decimal VariantSalary, bool IsCurrent, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Salary set EmpID=@EmpID, BasicSalaryWithoutAdvance=@BasicSalaryWithoutAdvance, TotaLAdvance=@TotaLAdvance, BasicSalary=@BasicSalary, VariantSalary=@VariantSalary, IsCurrent=@IsCurrent, IsDeleted=@IsDeleted, IsDeletable=@IsDeletable, RCDate=@RCDate, RCBy=@RCBy, LADate=@LADate, LABy=@LABy ,LADate=@LADate, LABy=@LABy where EmployeeSalaryHistoryID=@EmployeeSalaryHistoryID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeSalaryHistoryID", EmployeeSalaryHistoryID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@BasicSalaryWithoutAdvance", BasicSalaryWithoutAdvance);
TSqlCommand.Parameters.AddWithValue("@TotaLAdvance", TotaLAdvance);
TSqlCommand.Parameters.AddWithValue("@BasicSalary", BasicSalary);
TSqlCommand.Parameters.AddWithValue("@VariantSalary", VariantSalary);
TSqlCommand.Parameters.AddWithValue("@IsCurrent", IsCurrent);
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
