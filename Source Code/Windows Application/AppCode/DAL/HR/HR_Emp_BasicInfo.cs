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
class HR_Emp_BasicInfo
{
    public static int InsertRecord(string EmpNameAR, string EmpNameEN, string EmployeeFPNo, DateTime HireDate, DateTime BirthDate, int GenderID, int CountryID, int CityID, int AreaID, string Address, int NationalityID, int MilitaryServiceID, int SocialStatusID, string Notes, int ReligionID, bool IsActive, string ExternalID, DateTime StartUsingFP, int SubAccountID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_BasicInfo (EmpNameAR, EmpNameEN, EmployeeFPNo, HireDate, BirthDate, GenderID, CountryID, CityID, AreaID, Address, NationalityID, MilitaryServiceID, SocialStatusID, Notes, ReligionID, IsActive , RCBy, ExternalID, StartUsingFP, SubAccountID) values (@EmpNameAR, @EmpNameEN, @EmployeeFPNo, @HireDate, @BirthDate, @GenderID, @CountryID, @CityID, @AreaID, @Address, @NationalityID, @MilitaryServiceID, @SocialStatusID, @Notes, @ReligionID , @IsActive , @RCBy, @ExternalID, @StartUsingFP, @SubAccountID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpNameAR", EmpNameAR);
TSqlCommand.Parameters.AddWithValue("@EmpNameEN", EmpNameEN);
TSqlCommand.Parameters.AddWithValue("@EmployeeFPNo", EmployeeFPNo);
TSqlCommand.Parameters.AddWithValue("@HireDate", HireDate);
TSqlCommand.Parameters.AddWithValue("@BirthDate", BirthDate);
TSqlCommand.Parameters.AddWithValue("@GenderID", GenderID);
TSqlCommand.Parameters.AddWithValue("@CountryID", CountryID);
TSqlCommand.Parameters.AddWithValue("@CityID", CityID);
TSqlCommand.Parameters.AddWithValue("@AreaID", AreaID);
TSqlCommand.Parameters.AddWithValue("@Address", Address);
TSqlCommand.Parameters.AddWithValue("@NationalityID", NationalityID);
TSqlCommand.Parameters.AddWithValue("@MilitaryServiceID", MilitaryServiceID);
TSqlCommand.Parameters.AddWithValue("@SocialStatusID", SocialStatusID);
TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
TSqlCommand.Parameters.AddWithValue("@ReligionID", ReligionID);
TSqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
TSqlCommand.Parameters.AddWithValue("@ExternalID", ExternalID);
    TSqlCommand.Parameters.AddWithValue("@StartUsingFP", StartUsingFP);
TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
TSqlCommand.Parameters.AddWithValue("@SubAccountID", SubAccountID);


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

    public static int CheckforFingerPrint(string EmployeeFPNo)
    {
        int StatmentFireResult = 0;

        GlobalParamters.SQLStatment = "select count([EmployeeID]) from HR_Emp_BasicInfo where EmployeeFPNo=@EmployeeFPNo";
        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
        TSqlCommand.Parameters.AddWithValue("@EmployeeFPNo", EmployeeFPNo);

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

    public static int CheckforFingerPrintB4Update(string EmployeeFPNo, int EmployeeID)
    {
        int StatmentFireResult = 0;

        GlobalParamters.SQLStatment = "select count([EmployeeID]) from HR_Emp_BasicInfo where EmployeeFPNo=@EmployeeFPNo and EmployeeID<>@EmployeeID";
        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
        TSqlCommand.Parameters.AddWithValue("@EmployeeFPNo", EmployeeFPNo);
        TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

    public static int CheckforExternalID(string ExternalID)
    {
        int StatmentFireResult = 0;

        GlobalParamters.SQLStatment = "select count([EmployeeID]) from HR_Emp_BasicInfo where ExternalID=@ExternalID";
        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
        TSqlCommand.Parameters.AddWithValue("@ExternalID", ExternalID);

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

    public static int CheckforExternalIDB4Update(string ExternalID, int EmployeeID)
    {
        int StatmentFireResult = 0;

        GlobalParamters.SQLStatment = "select count([EmployeeID]) from HR_Emp_BasicInfo where ExternalID=@ExternalID and EmployeeID<>@EmployeeID";
        SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);
        TSqlCommand.Parameters.AddWithValue("@ExternalID", ExternalID);
        TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

public static int DeleteRecord(int EmployeeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_BasicInfo where EmployeeID=@EmployeeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

public static int UpdateDeleteFlag(int EmployeeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_BasicInfo set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeID=@EmployeeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_BasicInfo set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeID=@EmployeeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
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

public static int RestoreDeleted(int EmployeeID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_BasicInfo set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeID=@EmployeeID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_BasicInfo";

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

// To Fill Emp ComboBox in frmSalary
public static DataTable SelectForComboBox()
{

    GlobalParamters.SQLStatment = "select EmployeeID, EmpNameAR from HR_Emp_BasicInfo where IsActive = 1 and IsDeleted = 0";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_BasicInfo where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_BasicInfo where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_BasicInfo where EmployeeID=@EmployeeID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

GlobalParamters.SQLStatment = "select max([EmployeeID]) from HR_Emp_BasicInfo";

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

GlobalParamters.SQLStatment = "select min([EmployeeID]) from HR_Emp_BasicInfo";

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

GlobalParamters.SQLStatment = "select sum([EmployeeID]) from HR_Emp_BasicInfo";

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

GlobalParamters.SQLStatment = "select count([EmployeeID]) from HR_Emp_BasicInfo";

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

public static int UpdateRecord(int EmployeeID, string EmpNameAR, string EmpNameEN, string EmployeeFPNo, DateTime HireDate, DateTime BirthDate, int GenderID, int CountryID, int CityID, int AreaID, string Address, int NationalityID, int MilitaryServiceID, int SocialStatusID, string Notes, int ReligionID, bool IsActive, string ExternalID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_BasicInfo set EmpNameAR=@EmpNameAR, EmpNameEN=@EmpNameEN, EmployeeFPNo=@EmployeeFPNo, HireDate=@HireDate, BirthDate=@BirthDate, GenderID=@GenderID, CountryID=@CountryID, CityID=@CityID, AreaID=@AreaID, Address=@Address, NationalityID=@NationalityID, MilitaryServiceID=@MilitaryServiceID, SocialStatusID=@SocialStatusID, Notes=@Notes, ReligionID=@ReligionID, IsActive=@IsActive, ExternalID=@ExternalID, LADate=@LADate, LABy=@LABy where EmployeeID=@EmployeeID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
TSqlCommand.Parameters.AddWithValue("@EmpNameAR", EmpNameAR);
TSqlCommand.Parameters.AddWithValue("@EmpNameEN", EmpNameEN);
TSqlCommand.Parameters.AddWithValue("@EmployeeFPNo", EmployeeFPNo);
TSqlCommand.Parameters.AddWithValue("@HireDate", HireDate);
TSqlCommand.Parameters.AddWithValue("@BirthDate", BirthDate);
TSqlCommand.Parameters.AddWithValue("@GenderID", GenderID);
TSqlCommand.Parameters.AddWithValue("@CountryID", CountryID);
TSqlCommand.Parameters.AddWithValue("@CityID", CityID);
TSqlCommand.Parameters.AddWithValue("@AreaID", AreaID);
TSqlCommand.Parameters.AddWithValue("@Address", Address);
TSqlCommand.Parameters.AddWithValue("@NationalityID", NationalityID);
TSqlCommand.Parameters.AddWithValue("@MilitaryServiceID", MilitaryServiceID);
TSqlCommand.Parameters.AddWithValue("@SocialStatusID", SocialStatusID);
TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
TSqlCommand.Parameters.AddWithValue("@ReligionID", ReligionID);
TSqlCommand.Parameters.AddWithValue("@IsActive", IsActive);
TSqlCommand.Parameters.AddWithValue("@ExternalID", ExternalID);
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
