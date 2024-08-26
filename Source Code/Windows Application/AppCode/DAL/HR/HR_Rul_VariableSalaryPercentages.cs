//using FSECampus.AppCode;
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
class HR_Rul_VariableSalaryPercentages
{
public static int InsertRecord(string RuleTitle, decimal RuleValue, bool IsPercent, bool IsDeductions, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Rul_VariableSalaryPercentages (RuleTitle, RuleValue, IsPercent, IsDeductions, IsDeleted, IsDeletable, RCDate, RCBy, LADate, LABy, RCBy) values (@RuleTitle, @RuleValue, @IsPercent, @IsDeductions, @IsDeleted, @IsDeletable, @RCDate, @RCBy, @LADate, @LABy, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RuleTitle", RuleTitle);
TSqlCommand.Parameters.AddWithValue("@RuleValue", RuleValue);
TSqlCommand.Parameters.AddWithValue("@IsPercent", IsPercent);
TSqlCommand.Parameters.AddWithValue("@IsDeductions", IsDeductions);
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



public static int InsertRecord(string RuleTitle, decimal RuleValue, bool IsPercent, bool IsDeductions)
{
    int StatmentFireResult = 0;

    GlobalParamters.SQLStatment = "insert into HR_Rul_VariableSalaryPercentages (RuleTitle, RuleValue, IsPercent, IsDeductions , RCBy) values (@RuleTitle, @RuleValue, @IsPercent, @IsDeductions, @RCBy)";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@RuleTitle", RuleTitle);
    TSqlCommand.Parameters.AddWithValue("@RuleValue", RuleValue);
    TSqlCommand.Parameters.AddWithValue("@IsPercent", IsPercent);
    TSqlCommand.Parameters.AddWithValue("@IsDeductions", IsDeductions);

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

public static int DeleteRecord(int VariablePercentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Rul_VariableSalaryPercentages where VariablePercentID=@VariablePercentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);

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

public static int UpdateDeleteFlag(int VariablePercentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Rul_VariableSalaryPercentages set IsDeleted=1, LADate=@LADate, LABy=@LABy where VariablePercentID=@VariablePercentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);
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

public static int UpdateDeleteFlagWithCheck(int VariablePercentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Rul_VariableSalaryPercentages set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and VariablePercentID=@VariablePercentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);
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

public static int RestoreDeleted(int VariablePercentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Rul_VariableSalaryPercentages set IsDeleted=0, LADate=@LADate, LABy=@LABy where VariablePercentID=@VariablePercentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);
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

GlobalParamters.SQLStatment = "select * from HR_Rul_VariableSalaryPercentages";

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

GlobalParamters.SQLStatment = "select * from HR_Rul_VariableSalaryPercentages where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Rul_VariableSalaryPercentages where IsDeleted=0";

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

public static DataTable SelectByPK(int VariablePercentID)
{

GlobalParamters.SQLStatment = "Select * from HR_Rul_VariableSalaryPercentages where VariablePercentID=@VariablePercentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);

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


public static DataTable SelectActiveRecordeWithAlias()
{

    GlobalParamters.SQLStatment = "select VariablePercentID as [رقم التسلسل] , RuleTitle as [اسم اللائحة] , RuleValue as [قمية] , IsPercent as [نسبة]  , IsDeductions as [استقطاعات] from HR_Rul_VariableSalaryPercentages where IsDeleted=0";

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
public static int GetMax()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select max([VariablePercentID]) from HR_Rul_VariableSalaryPercentages";

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

GlobalParamters.SQLStatment = "select min([VariablePercentID]) from HR_Rul_VariableSalaryPercentages";

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

GlobalParamters.SQLStatment = "select sum([VariablePercentID]) from HR_Rul_VariableSalaryPercentages";

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

GlobalParamters.SQLStatment = "select count([VariablePercentID]) from HR_Rul_VariableSalaryPercentages";

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

public static int UpdateRecord(int VariablePercentID, string RuleTitle, decimal RuleValue, bool IsPercent, bool IsDeductions, bool IsDeleted, bool IsDeletable, DateTime RCDate, int RCBy, DateTime LADate, int LABy)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Rul_VariableSalaryPercentages set RuleTitle=@RuleTitle, RuleValue=@RuleValue, IsPercent=@IsPercent, IsDeductions=@IsDeductions, IsDeleted=@IsDeleted, IsDeletable=@IsDeletable, RCDate=@RCDate, RCBy=@RCBy, LADate=@LADate, LABy=@LABy ,LADate=@LADate, LABy=@LABy where VariablePercentID=@VariablePercentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);
TSqlCommand.Parameters.AddWithValue("@RuleTitle", RuleTitle);
TSqlCommand.Parameters.AddWithValue("@RuleValue", RuleValue);
TSqlCommand.Parameters.AddWithValue("@IsPercent", IsPercent);
TSqlCommand.Parameters.AddWithValue("@IsDeductions", IsDeductions);
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

public static int UpdateRecord(int VariablePercentID, string RuleTitle, decimal RuleValue, bool IsPercent, bool IsDeductions)
{
    int StatmentFireResult = 0;

    GlobalParamters.SQLStatment = "Update HR_Rul_VariableSalaryPercentages set RuleTitle=@RuleTitle, RuleValue=@RuleValue, IsPercent=@IsPercent, IsDeductions=@IsDeductions, LADate=@LADate, LABy=@LABy where VariablePercentID=@VariablePercentID";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@VariablePercentID", VariablePercentID);
    TSqlCommand.Parameters.AddWithValue("@RuleTitle", RuleTitle);
    TSqlCommand.Parameters.AddWithValue("@RuleValue", RuleValue);
    TSqlCommand.Parameters.AddWithValue("@IsPercent", IsPercent);
    TSqlCommand.Parameters.AddWithValue("@IsDeductions", IsDeductions);

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
