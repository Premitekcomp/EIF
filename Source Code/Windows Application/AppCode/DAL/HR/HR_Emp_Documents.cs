using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
class HR_Emp_Documents
{
public static int InsertRecord(int EmpID, int DocumentTypeID,bool Deliverd , DateTime DeliverdDate, DateTime ValidTo, string Notes)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "insert into HR_Emp_Documents (EmpID, DocumentTypeID, Deliverd, DeliverdDate, ValidTo, Notes, RCBy) values (@EmpID, @DocumentTypeID, @Deliverd, @DeliverdDate, @ValidTo, @Notes, @RCBy)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@DocumentTypeID", DocumentTypeID);
TSqlCommand.Parameters.AddWithValue("@Deliverd", Deliverd);   
TSqlCommand.Parameters.AddWithValue("@DeliverdDate", DeliverdDate);
TSqlCommand.Parameters.AddWithValue("@ValidTo", ValidTo);
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

public static int InsertRecordWithAttachment(int EmpID, int DocumentTypeID, bool Deliverd, DateTime DeliverdDate, DateTime ValidTo, string Notes, byte[] DocumentCopy, string AttachmentName)
{
    int StatmentFireResult = 0;

    GlobalParamters.SQLStatment = "insert into HR_Emp_Documents (EmpID, DocumentTypeID, Deliverd, DeliverdDate, ValidTo, Notes, RCBy, DocumentCopy, AttachmentName) values (@EmpID, @DocumentTypeID, @Deliverd, @DeliverdDate, @ValidTo, @Notes, @RCBy, @DocumentCopy, @AttachmentName)";

    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
    TSqlCommand.Parameters.AddWithValue("@DocumentTypeID", DocumentTypeID);
    TSqlCommand.Parameters.AddWithValue("@Deliverd", Deliverd);
    TSqlCommand.Parameters.AddWithValue("@DeliverdDate", DeliverdDate);
    TSqlCommand.Parameters.AddWithValue("@ValidTo", ValidTo);
    TSqlCommand.Parameters.AddWithValue("@Notes", Notes);
    TSqlCommand.Parameters.AddWithValue("@RCBy", GlobalParamters.ActiveUserID);
    TSqlCommand.Parameters.AddWithValue("@DocumentCopy", DocumentCopy);
    TSqlCommand.Parameters.AddWithValue("@AttachmentName", AttachmentName);

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

public static string GetAttachmentName(int EmployeeDocumentID)
{
    string StatmentFireResult = "";
    GlobalParamters.SQLStatment = "select AttachmentName from HR_Emp_Documents where EmployeeDocumentID=@EmployeeDocumentID";
    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);

    try
    {
        if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
        {
            GlobalParamters.DBConnection.Open();
        }
        StatmentFireResult = TSqlCommand.ExecuteScalar().ToString();
        GlobalParamters.DBConnection.Close();
        return StatmentFireResult;
    }
    catch
    {
        StatmentFireResult = "";
        return StatmentFireResult;
    }

}

public static DataTable DownloadDocAttachment(int EmployeeDocumentID, string SaveLocation)
{
    GlobalParamters.SQLStatment = "select DocumentCopy from HR_Emp_Documents where EmployeeDocumentID=@EmployeeDocumentID";
    SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

    TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);


    try
    {
        if (GlobalParamters.DBConnection.State == ConnectionState.Closed)
        {
            GlobalParamters.DBConnection.Open();
        }
        SqlDataReader dr = TSqlCommand.ExecuteReader();

        if (dr != null)
        {
            dr.Read();
            var blob = new Byte[(dr.GetBytes(0, 0, null, 0, int.MaxValue))];
            dr.GetBytes(0, 0, blob, 0, blob.Length);
            using (var fs = new FileStream(SaveLocation, FileMode.Create, FileAccess.Write))
                fs.Write(blob, 0, blob.Length);
        }

        DataTable dt = new DataTable();
        dt.Load(dr);
        return dt;
    }
    finally
    {

        GlobalParamters.DBConnection.Close();
    }

}

public static int DeleteRecord(int EmployeeDocumentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Delete from HR_Emp_Documents where EmployeeDocumentID=@EmployeeDocumentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);

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

public static int UpdateDeleteFlag(int EmployeeDocumentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Documents set IsDeleted=1, LADate=@LADate, LABy=@LABy where EmployeeDocumentID=@EmployeeDocumentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);
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

public static int UpdateDeleteFlagWithCheck(int EmployeeDocumentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Documents set IsDeleted=1, LADate=@LADate, LABy=@LABy where IsDeletable=1 and EmployeeDocumentID=@EmployeeDocumentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);
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

public static int RestoreDeleted(int EmployeeDocumentID)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Documents set IsDeleted=0, LADate=@LADate, LABy=@LABy where EmployeeDocumentID=@EmployeeDocumentID)";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);
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

GlobalParamters.SQLStatment = "select * from HR_Emp_Documents";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Documents where IsDeleted=1";

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

GlobalParamters.SQLStatment = "select * from HR_Emp_Documents where IsDeleted=0";

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

public static DataTable SelectByPK(int EmployeeDocumentID)
{

GlobalParamters.SQLStatment = "Select * from HR_Emp_Documents where EmployeeDocumentID=@EmployeeDocumentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);

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

GlobalParamters.SQLStatment = "select max([EmployeeDocumentID]) from HR_Emp_Documents";

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

GlobalParamters.SQLStatment = "select min([EmployeeDocumentID]) from HR_Emp_Documents";

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

GlobalParamters.SQLStatment = "select sum([EmployeeDocumentID]) from HR_Emp_Documents";

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

GlobalParamters.SQLStatment = "select count([EmployeeDocumentID]) from HR_Emp_Documents";

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

public static int UpdateRecord(int EmployeeDocumentID, int EmpID, int DocumentTypeID, bool Deliverd, DateTime DeliverdDate, DateTime ValidTo, string Notes)
{
int StatmentFireResult = 0;

GlobalParamters.SQLStatment = "Update HR_Emp_Documents set EmpID=@EmpID, DocumentTypeID=@DocumentTypeID, Deliverd=@Deliverd, DeliverdDate=@DeliverdDate, ValidTo=@ValidTo, Notes=@Notes, LADate=@LADate, LABy=@LABy where EmployeeDocumentID=@EmployeeDocumentID";

SqlCommand TSqlCommand = new SqlCommand(GlobalParamters.SQLStatment, GlobalParamters.DBConnection);

TSqlCommand.Parameters.AddWithValue("@EmployeeDocumentID", EmployeeDocumentID);
TSqlCommand.Parameters.AddWithValue("@EmpID", EmpID);
TSqlCommand.Parameters.AddWithValue("@DocumentTypeID", DocumentTypeID);
TSqlCommand.Parameters.AddWithValue("@Deliverd", Deliverd);
TSqlCommand.Parameters.AddWithValue("@DeliverdDate", DeliverdDate);
TSqlCommand.Parameters.AddWithValue("@ValidTo", ValidTo);
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
