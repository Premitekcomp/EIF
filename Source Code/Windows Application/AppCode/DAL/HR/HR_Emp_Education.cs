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
class HR_Emp_Education
{
public static int InsertRecord(int EmpID, int QualificationNameID, int UniversityID, int FacultyID, int SectionNameID, int QualificationYear, string Notes)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_Education (EmpID, QualificationNameID, UniversityID, FacultyID, SectionNameID, QualificationYear, Notes, RCBy) values (@EmpID, @QualificationNameID, @UniversityID, @FacultyID, @SectionNameID, @QualificationYear, @Notes,  @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@QualificationNameID", QualificationNameID);
TSqlCommand.Parameters.AddWithValue("@UniversityID", UniversityID);
TSqlCommand.Parameters.AddWithValue("@FacultyID", FacultyID);
TSqlCommand.Parameters.AddWithValue("@SectionNameID", SectionNameID);
TSqlCommand.Parameters.AddWithValue("@QualificationYear", QualificationYear);
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

public static int DeleteRecord(int RecordID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_Education where RecordID=@RecordID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);

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

public static int UpdateDeleteFlag(int RecordID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Education set IsDeleted=1, LADate=@LADate, LABy=@LABy where RecordID=@RecordID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
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

public static int UpdateDeleteFlagWithCheck(int RecordID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Education set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and RecordID=@RecordID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
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

public static int RestoreDeleted(int RecordID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Education set IsDeleted=0, LADate=@LADate, LABy=@LABy where RecordID=@RecordID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_Education";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Education where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Education where IsDeleted=0";

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

public static DataTable SelectByPK(int RecordID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_Education where RecordID=@RecordID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);

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

GlobalParamters.SQLStatment = "select max([RecordID]) from HR_Emp_Education";

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

GlobalParamters.SQLStatment = "select min([RecordID]) from HR_Emp_Education";

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

GlobalParamters.SQLStatment = "select sum([RecordID]) from HR_Emp_Education";

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

GlobalParamters.SQLStatment = "select count([RecordID]) from HR_Emp_Education";

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

public static int UpdateRecord(int RecordID, int EmpID, int QualificationNameID, int UniversityID, int FacultyID, int SectionNameID, int QualificationYear, string Notes)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Education set EmpID=@EmpID, QualificationNameID=@QualificationNameID, UniversityID=@UniversityID, FacultyID=@FacultyID, SectionNameID=@SectionNameID, QualificationYear=@QualificationYear, Notes=@Notes ,LADate=@LADate, LABy=@LABy where RecordID=@RecordID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@QualificationNameID", QualificationNameID);
TSqlCommand.Parameters.AddWithValue("@UniversityID", UniversityID);
TSqlCommand.Parameters.AddWithValue("@FacultyID", FacultyID);
TSqlCommand.Parameters.AddWithValue("@SectionNameID", SectionNameID);
TSqlCommand.Parameters.AddWithValue("@QualificationYear", QualificationYear);
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
