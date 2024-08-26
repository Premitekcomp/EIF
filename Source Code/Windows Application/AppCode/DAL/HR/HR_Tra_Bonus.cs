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
class HR_Tra_Bonus
{
public static int InsertRecord(int EmpID, DateTime Tra_Date, int BonusID, bool ByDay, bool ByAmount, decimal Value, string Notes)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Tra_Bonus (EmpID, Tra_Date, BonusID, ByDay, ByAmount, Value, Notes) values (@EmpID, @Tra_Date, @BonusID, @ByDay, @ByAmount, @Value, @Notes)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@Tra_Date", Tra_Date);
TSqlCommand.Parameters.AddWithValue("@BonusID", BonusID);
TSqlCommand.Parameters.AddWithValue("@ByDay", ByDay);
TSqlCommand.Parameters.AddWithValue("@ByAmount", ByAmount);
TSqlCommand.Parameters.AddWithValue("@Value", Value);
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

public static int DeleteRecord(int EmployeeBonusID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Tra_Bonus where EmployeeBonusID=@EmployeeBonusID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);

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

public static int UpdateDeleteFlag(int EmployeeBonusID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Bonus set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeBonusID=@EmployeeBonusID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeeBonusID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Bonus set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeBonusID=@EmployeeBonusID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);
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

public static int RestoreDeleted(int EmployeeBonusID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Bonus set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeBonusID=@EmployeeBonusID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);
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

GlobalParamters.SQLStatment = "select * from HR_Tra_Bonus";

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

GlobalParamters.SQLStatment = "select * from HR_Tra_Bonus where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Tra_Bonus where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeBonusID)
{

GlobalParamters.SQLStatment = "Select * from HR_Tra_Bonus where EmployeeBonusID=@EmployeeBonusID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);

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

GlobalParamters.SQLStatment = "select max([EmployeeBonusID]) from HR_Tra_Bonus";

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

GlobalParamters.SQLStatment = "select min([EmployeeBonusID]) from HR_Tra_Bonus";

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

GlobalParamters.SQLStatment = "select sum([EmployeeBonusID]) from HR_Tra_Bonus";

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

GlobalParamters.SQLStatment = "select count([EmployeeBonusID]) from HR_Tra_Bonus";

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

public static int UpdateRecord(int EmployeeBonusID, int EmpID, DateTime Tra_Date, int BonusID, bool ByDay, bool ByAmount, decimal Value, string Notes )
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Tra_Bonus set EmpID=@EmpID, Tra_Date=@Tra_Date, BonusID=@BonusID, ByDay=@ByDay, ByAmount=@ByAmount, Value=@Value, Notes=@Notes ,LADate=@LADate, LABy=@LABy where EmployeeBonusID=@EmployeeBonusID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeBonusID", EmployeeBonusID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@Tra_Date", Tra_Date);
TSqlCommand.Parameters.AddWithValue("@BonusID", BonusID);
TSqlCommand.Parameters.AddWithValue("@ByDay", ByDay);
TSqlCommand.Parameters.AddWithValue("@ByAmount", ByAmount);
TSqlCommand.Parameters.AddWithValue("@Value", Value);
TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
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
