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
class HR_Emp_Papers
{
public static int InsertRecord(int EmpID, string NationalIDNo, DateTime NationalIDIssueDate, DateTime NationalIDExpireDate, bool HasPassport, string PassportNo, DateTime PassportExpireDate, bool HasPrivateCar, int DrivingLicenseID, int BankID, string BankAccountNo, string SocialInssuranceNo, int SocialInssuranceOfficeID, DateTime FirstInssuranceDate, DateTime InssuranceDate, int HealthInsuranceTypeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_Papers (EmpID, NationalIDNo, NationalIDIssueDate, NationalIDExpireDate, HasPassport, PassportNo, PassportExpireDate, HasPrivateCar, DrivingLicenseID, BankID, BankAccountNo, SocialInssuranceNo, SocialInssuranceOfficeID, FirstInssuranceDate, InssuranceDate, HealthInsuranceTypeID, RCBy) values (@EmpID, @NationalIDNo, @NationalIDIssueDate, @NationalIDExpireDate, @HasPassport, @PassportNo, @PassportExpireDate, @HasPrivateCar, @DrivingLicenseID, @BankID, @BankAccountNo, @SocialInssuranceNo, @SocialInssuranceOfficeID, @FirstInssuranceDate, @InssuranceDate, @HealthInsuranceTypeID, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@NationalIDNo", NationalIDNo);
TSqlCommand.Parameters.AddWithValue("@NationalIDIssueDate", NationalIDIssueDate);
TSqlCommand.Parameters.AddWithValue("@NationalIDExpireDate", NationalIDExpireDate);
TSqlCommand.Parameters.AddWithValue("@HasPassport", HasPassport);
TSqlCommand.Parameters.AddWithValue("@PassportNo", PassportNo);
TSqlCommand.Parameters.AddWithValue("@PassportExpireDate", PassportExpireDate);
TSqlCommand.Parameters.AddWithValue("@HasPrivateCar", HasPrivateCar);
TSqlCommand.Parameters.AddWithValue("@DrivingLicenseID", DrivingLicenseID);
TSqlCommand.Parameters.AddWithValue("@BankID", BankID);
TSqlCommand.Parameters.AddWithValue("@BankAccountNo", BankAccountNo);
TSqlCommand.Parameters.AddWithValue("@SocialInssuranceNo", SocialInssuranceNo);
TSqlCommand.Parameters.AddWithValue("@SocialInssuranceOfficeID", SocialInssuranceOfficeID);
TSqlCommand.Parameters.AddWithValue("@FirstInssuranceDate", FirstInssuranceDate);
TSqlCommand.Parameters.AddWithValue("@InssuranceDate", InssuranceDate);
TSqlCommand.Parameters.AddWithValue("@HealthInsuranceTypeID", HealthInsuranceTypeID);

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

public static int DeleteRecord(int RecordSerial)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_Papers where RecordSerial=@RecordSerial)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);

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

public static int UpdateDeleteFlag(int RecordSerial)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Papers set IsDeleted=1, LADate=@LADate, LABy=@LABy where RecordSerial=@RecordSerial)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
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

public static int UpdateDeleteFlagWithCheck(int RecordSerial)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Papers set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and RecordSerial=@RecordSerial";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
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

public static int RestoreDeleted(int RecordSerial)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Papers set IsDeleted=0, LADate=@LADate, LABy=@LABy where RecordSerial=@RecordSerial)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_Papers";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Papers where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Papers where IsDeleted=0";

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

public static DataTable SelectByPK(int RecordSerial)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_Papers where RecordSerial=@RecordSerial";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);

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

    GlobalParamters.SQLStatment = "Select * from HR_Emp_Papers where EmpID=@EmpID";

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

public static int GetMax()
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "select max([RecordSerial]) from HR_Emp_Papers";

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

GlobalParamters.SQLStatment = "select min([RecordSerial]) from HR_Emp_Papers";

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

GlobalParamters.SQLStatment = "select sum([RecordSerial]) from HR_Emp_Papers";

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

GlobalParamters.SQLStatment = "select count([RecordSerial]) from HR_Emp_Papers";

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

public static int UpdateRecord(int RecordSerial, int EmpID, string NationalIDNo, DateTime NationalIDIssueDate, DateTime NationalIDExpireDate, bool HasPassport, string PassportNo, DateTime PassportExpireDate, bool HasPrivateCar, int DrivingLicenseID, int BankID, string BankAccountNo, string SocialInssuranceNo, int SocialInssuranceOfficeID, DateTime FirstInssuranceDate, DateTime InssuranceDate, int HealthInsuranceTypeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Papers set EmpID=@EmpID, NationalIDNo=@NationalIDNo, NationalIDIssueDate=@NationalIDIssueDate, NationalIDExpireDate=@NationalIDExpireDate, HasPassport=@HasPassport, PassportNo=@PassportNo, PassportExpireDate=@PassportExpireDate, HasPrivateCar=@HasPrivateCar, DrivingLicenseID=@DrivingLicenseID, BankID=@BankID, BankAccountNo=@BankAccountNo, SocialInssuranceNo=@SocialInssuranceNo, SocialInssuranceOfficeID=@SocialInssuranceOfficeID, FirstInssuranceDate=@FirstInssuranceDate, InssuranceDate=@InssuranceDate, HealthInsuranceTypeID=@HealthInsuranceTypeID,LADate=@LADate, LABy=@LABy where RecordSerial=@RecordSerial";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordSerial", RecordSerial);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@NationalIDNo", NationalIDNo);
TSqlCommand.Parameters.AddWithValue("@NationalIDIssueDate", NationalIDIssueDate);
TSqlCommand.Parameters.AddWithValue("@NationalIDExpireDate", NationalIDExpireDate);
TSqlCommand.Parameters.AddWithValue("@HasPassport", HasPassport);
TSqlCommand.Parameters.AddWithValue("@PassportNo", PassportNo);
TSqlCommand.Parameters.AddWithValue("@PassportExpireDate", PassportExpireDate);
TSqlCommand.Parameters.AddWithValue("@HasPrivateCar", HasPrivateCar);
TSqlCommand.Parameters.AddWithValue("@DrivingLicenseID", DrivingLicenseID);
TSqlCommand.Parameters.AddWithValue("@BankID", BankID);
TSqlCommand.Parameters.AddWithValue("@BankAccountNo", BankAccountNo);
TSqlCommand.Parameters.AddWithValue("@SocialInssuranceNo", SocialInssuranceNo);
TSqlCommand.Parameters.AddWithValue("@SocialInssuranceOfficeID", SocialInssuranceOfficeID);
TSqlCommand.Parameters.AddWithValue("@FirstInssuranceDate", FirstInssuranceDate);
TSqlCommand.Parameters.AddWithValue("@InssuranceDate", InssuranceDate);
TSqlCommand.Parameters.AddWithValue("@HealthInsuranceTypeID", HealthInsuranceTypeID);

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
