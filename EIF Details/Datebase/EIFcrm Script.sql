USE [master]
GO
/****** Object:  Database [EIFCRM]    Script Date: 03-Dec-17 4:04:41 PM ******/
CREATE DATABASE [EIFCRM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EIFCRM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EIFCRM.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EIFCRM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EIFCRM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EIFCRM] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EIFCRM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EIFCRM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EIFCRM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EIFCRM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EIFCRM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EIFCRM] SET ARITHABORT OFF 
GO
ALTER DATABASE [EIFCRM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EIFCRM] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EIFCRM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EIFCRM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EIFCRM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EIFCRM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EIFCRM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EIFCRM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EIFCRM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EIFCRM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EIFCRM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EIFCRM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EIFCRM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EIFCRM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EIFCRM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EIFCRM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EIFCRM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EIFCRM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EIFCRM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EIFCRM] SET  MULTI_USER 
GO
ALTER DATABASE [EIFCRM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EIFCRM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EIFCRM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EIFCRM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EIFCRM]
GO
/****** Object:  User [TMSAdmin]    Script Date: 03-Dec-17 4:04:41 PM ******/
CREATE USER [TMSAdmin] FOR LOGIN [TMSAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [dbadmin]    Script Date: 03-Dec-17 4:04:41 PM ******/
CREATE USER [dbadmin] FOR LOGIN [dbadmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [TMSAdmin]
GO
/****** Object:  StoredProcedure [dbo].[Chrt_ContactsSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Chrt_ContactsSP]
@AgencyID int , @BranchID int
as
select * from [dbo].[Chrt_Contacts]
where [AgencyID]=@AgencyID and [BranchID]=@BranchID

GO
/****** Object:  StoredProcedure [dbo].[Chrt_PD_PTP_KeptAmmountSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- where [AgencyID]=@AgencyID and [BranchID]=@BranchID
-- Chrt_PD_PTP_KeptAmmountSP 1,1

CREATE procedure [dbo].[Chrt_PD_PTP_KeptAmmountSP]
@AgencyID int , @BranchID int
as
select AgencyID, BranchID,
  SumType,
  SumVal
from Chrt_PD_PTP_KeptAmmount
cross apply
(
  values
  ('Sum Of Past Due', SumOFPastDue),
  ('Sum Of PTP Amount', SumOFPTPAmount),
  ('Sum Of Kept Amount', SumOFKeptAmount)
) c (SumType, SumVal)
where [AgencyID]=@AgencyID and [BranchID]=@BranchID

GO
/****** Object:  StoredProcedure [dbo].[Config_AgencyListInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Config_AgencyListInsert]
( @AgencyTitle nvarchar(300)
,@BranchList nvarchar(max) 
           ,@IsActive bit )
		   as

INSERT INTO [dbo].[Config_AgencyList]
           ([AgencyTitle]
           ,[IsActive])
     VALUES
           (@AgencyTitle 
           ,@IsActive  )

		   declare @ID tinyint
		   set @ID =( select scope_identity())

		   if @ID>1
begin

DECLARE @Br_Tbl TABLE (idx2 smallint Primary Key IDENTITY(1,1),BID smallint)

INSERT @Br_Tbl SELECT  Item from SplitDelimiterString(@BranchList,',')

declare @Count int
DECLARE @Init int
DECLARE @BrID tinyint

SET @Init = 1
SET @Count = (SELECT COUNT(*) FROM @Br_Tbl)
IF @Count > 0
	WHILE (@Init <= (SELECT MAX(idx2) FROM @Br_Tbl))
    BEGIN
	set @BrID=(select BID from @Br_Tbl where idx2 = @Init)
	INSERT INTO [dbo].[Config_AgencyBranches]  ([BranchID]  ,[AgencyID]) VALUES (@BrID,@ID)
	 SET @Init = @Init + 1
    END


     
   
 
end


GO
/****** Object:  StoredProcedure [dbo].[Config_AgencyListUpdate]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Config_AgencyListUpdate]--Config_AgencyListUpdate 1,'agency','1,',1
(@ID tinyint, @AgencyTitle nvarchar(300)
,@BranchList nvarchar(max) 
           ,@IsActive bit )
		   as

update [dbo].[Config_AgencyList]
         set  [AgencyTitle]=@AgencyTitle
           ,[IsActive]=@IsActive
     where [AgencyID]=@ID
		   if @ID>0
		   select @ID
begin
Begin transaction

delete from [dbo].[Config_AgencyBranches] where [AgencyID]=@ID

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

DECLARE @Br_Tbl TABLE (idx2 smallint Primary Key IDENTITY(1,1),BID smallint)

INSERT @Br_Tbl SELECT  Item from SplitDelimiterString(@BranchList,',')

declare @Count int
DECLARE @Init int
DECLARE @BrID tinyint

SET @Init = 1
SET @Count = (SELECT COUNT(*) FROM @Br_Tbl)
IF @Count > 0
	WHILE (@Init <= (SELECT MAX(idx2) FROM @Br_Tbl))
    BEGIN
	set @BrID=(select BID from @Br_Tbl where idx2 = @Init)
	INSERT INTO [dbo].[Config_AgencyBranches]  ([BranchID]  ,[AgencyID]) VALUES (@BrID,@ID)
	 SET @Init = @Init + 1
    END

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

/* If we reach this point, the commands 
completed successfully Commit the transaction
*/

Commit



     
   
 
end


GO
/****** Object:  StoredProcedure [dbo].[Config_TeamListInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Config_TeamListInsert]
(@BranchID tinyint 
,@AgencyID int 
,@TeamName nvarchar(max) 
,@IsActive bit )
as

INSERT INTO [dbo].[Config_TeamList]
           ([BranchID]
           ,[AgencyID]
           ,[TeamName]
           ,[IsActive])
     VALUES
           (@BranchID 
           ,@AgencyID 
           ,@TeamName 
           ,@IsActive )


GO
/****** Object:  StoredProcedure [dbo].[Config_TeamListUpdate]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Config_TeamListUpdate]
(@TeamID int
,@BranchID tinyint 
,@AgencyID int 
,@TeamName nvarchar(max) 
,@IsActive bit )
as
UPDATE [dbo].[Config_TeamList]
   SET [BranchID] = @BranchID 
      ,[AgencyID] = @AgencyID 
      ,[TeamName] = @TeamName 
      ,[IsActive] = @IsActive 
 WHERE [TeamID]=@TeamID


GO
/****** Object:  StoredProcedure [dbo].[Config_TeamMembersDelete]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Config_TeamMembersDelete]
@TeamID int,@MemberID int
as
delete from Config_TeamMembers where TeamID =@TeamID and MemberID=@MemberID

GO
/****** Object:  StoredProcedure [dbo].[Config_TeamMembersInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE proc [dbo].[Config_TeamMembersInsert]
@TeamID int,@MemberID int,@RoleID int
as
if not exists(select * from Config_TeamMembers where TeamID=@TeamID and MemberID=@MemberID and RoleID=@RoleID)
insert into  Config_TeamMembers  (TeamID ,MemberID,RoleID) values (@TeamID , @MemberID,@RoleID)

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAgencySP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByAgencySP]
  -- [dbo].[DCR_MemberDCRSummaryByAgencySP] 1
 @AgencyID nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByAgencyFn(''' + @AgencyID + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAgencyTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByAgencyTotalSP]
  -- [dbo].[DCR_MemberDCRSummaryByAgencyTotalSP] 1
 @AgencyID nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit from DCR_MemberDCRSummaryByAgencyFn(''' + @AgencyID + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeSP]
  
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByAllDomainBothTypeFn()
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeTotalSP]
  
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit from DCR_MemberDCRSummaryByAllDomainBothTypeFn()
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAllDomainSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByAllDomainSP]
  -- [dbo].[DCR_MemberDCRSummaryByAllDomainSP] 'Active Domain'
 @DomainType nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByAllDomainFn(''' + @DomainType + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByAllDomainTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByAllDomainTotalSP]
   --[dbo].[DCR_MemberDCRSummaryByAllDomainTotalSP] 'Active Domain'
 @DomainType nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit  from DCR_MemberDCRSummaryByAllDomainFn(''' + @DomainType + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByBranchSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByBranchSP]
  -- [dbo].[DCR_MemberDCRSummaryByBranchSP] 1
 @BranchID nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByBranchFn(''' + @BranchID + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByBranchTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByBranchTotalSP]
  -- [dbo].[DCR_MemberDCRSummaryByBranchTotalSP] 1
 @BranchID nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit  from DCR_MemberDCRSummaryByBranchFn(''' + @BranchID + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypeSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypeSP]
   
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByOpenDomainBothTypesFn()
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypeTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypeTotalSP]
   
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit from DCR_MemberDCRSummaryByOpenDomainBothTypesFn()
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByOpenDomainSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummaryByOpenDomainSP]
  -- [dbo].[DCR_MemberDCRSummaryByOpenDomainSP] 'Active Domain'
 @DomainType nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByOpenDomainFn(''' + @DomainType + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryByOpenDomainTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[DCR_MemberDCRSummaryByOpenDomainTotalSP]
  -- [dbo].[DCR_MemberDCRSummaryByOpenDomainSP] 'Active Domain'
 @DomainType nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select  count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit from DCR_MemberDCRSummaryByOpenDomainFn(''' + @DomainType + ''')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummarySP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DCR_MemberDCRSummarySP] -- [dbo].[DCR_MemberDCRSummarySP] 47
 @DomainID nvarchar(max)
 as
begin 
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     'select * from DCR_MemberDCRSummaryByDomainFn(' + @DomainID + ')
       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
end
 

GO
/****** Object:  StoredProcedure [dbo].[DCR_MemberDCRSummaryTotalSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[DCR_MemberDCRSummaryTotalSP]  --  [dbo].[DCR_MemberDCRSummaryTotalSP] 47
@DomainID nvarchar(max)
 as
begin
DECLARE @DynamicPivotQuery AS NVARCHAR(MAX)
DECLARE @ColumnName AS NVARCHAR(MAX)
SELECT @ColumnName= ISNULL(@ColumnName + ',','') 
       + QUOTENAME(ConnectionTypeTitle)
FROM (SELECT DISTINCT TOP 100 Percent   ConnectionTypeTitle,ConnectionTypeID 
		FROM [dbo].[PCR_ConnectionType] order by  ConnectionTypeID) AS [ConnectionType]
SET @DynamicPivotQuery =   
     ' select count( [Action Maker]) as [Action Maker],
	 count([Count Of Accounts]) as [Count Of Accounts],
		sum ([Count Of Connections]) as [Count Of Connections],
        sum ([Count Of PTP]) as [Count Of PTP],
		 sum( [Sum Of PTP Amount]) as [Sum Of PTP Amount], 
		 sum(  [Count Of Promise Kept]) as  [Count Of Promise Kept],
		 sum( [Count Of Promise Brok] ) as [Count Of Promise Brok], 
        sum( [Sum Of Kept Amount])  as [Sum Of Kept Amount]
		,sum(Call) as Call,sum(Visit) as Visit
		from DCR_MemberDCRSummaryByDomainFn('+@DomainID+')

       PIVOT(Count(ConnectionTypeTitle)
      FOR ConnectionTypeTitle IN (' + @ColumnName + ')) AS PVTTable'


EXEC sp_executesql @DynamicPivotQuery 
 
 end

GO
/****** Object:  StoredProcedure [dbo].[Dom_AssignDomainToMembersDelete]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Dom_AssignDomainToMembersDelete]
 (@AccountID bigint ,@MemberID int)
as
delete from [dbo].[Dom_AssignDomainToMembers] where [AccountID]=@AccountID and [MemberID]=@MemberID
 

GO
/****** Object:  StoredProcedure [dbo].[Dom_AssignDomainToMembersInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dom_AssignDomainToMembersInsert]
 (@AccountID bigint 
           ,@MemberID int 
           ,@RoleID smallint 
           ,@TeamID int 
		   ,@IsBank bit)
as
if not exists (select * from [dbo].[Dom_AssignDomainToMembers]
 where [AccountID]=@AccountID and [MemberID]=@MemberID and [IsBank]=@IsBank)
begin
INSERT INTO [dbo].[Dom_AssignDomainToMembers]
           ([AccountID]
           ,[MemberID]
           ,[RoleID]
           ,[TeamID]
		   ,[IsBank])
     VALUES
           (@AccountID  
           ,@MemberID  
           ,@RoleID  
           ,@TeamID 
		   ,@IsBank )
end


GO
/****** Object:  StoredProcedure [dbo].[Dom_Dom_AccountsPaymentsInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 -- Dom_Dom_AccountsPaymentsInsert '4713640161640498','Col1',2,200
 CREATE proc [dbo].[Dom_Dom_AccountsPaymentsInsert]
 (@PKFieldVal nvarchar(max),@PKAliasCol nvarchar(max),@VersionNumber int,@PaymentValue decimal(12,2))
as

          
-- '+  @VersionNumber +'
declare @SQL nvarchar(max);

--set @RecordSerial= (select [RecordSerial] from [dbo].[Dom_DomainsDataExtra] 
--where [VersionNumber]=@VersionNumber and [Col1]=@PKFieldVal)

SET @SQL =   
     'declare @RecordSerial int;
	 set @RecordSerial= ( select [RecordSerial] from [dbo].[Dom_DomainsDataExtra] 
			 where [VersionNumber]='+CONVERT( nvarchar(max),@VersionNumber)   +' and '+@PKAliasCol+'='+@PKFieldVal+
			') 
				INSERT INTO [dbo].[Dom_AccountsPayments] ([RecordSerial] ,[PaymentValue])
					 VALUES (  @RecordSerial,'+CONVERT( nvarchar(max),@PaymentValue)+')
				'
	
	 --select @SQL;
EXEC sp_executesql @SQL 



GO
/****** Object:  StoredProcedure [dbo].[Dom_DomainDelete]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Dom_DomainDelete]
@DomainID bigint
as

if not exists (select * from [dbo].[PCR_PCRHistory] where [DomainID]=@DomainID)
begin
 
Begin transaction

delete from [dbo].[Dom_DomainsDataExtra] where [DomainID]=@DomainID

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

delete from [dbo].[Dom_DomainColumnsAlias] where [DomainID]=@DomainID

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End
	delete from [dbo].[Dom_DomainBasic] where [DomainID]=@DomainID
 If @@ERROR <> 0
	Begin
		Rollback
		Return
	End
/* If we reach this point, the commands 
completed successfully Commit the transaction
*/

Commit

end

GO
/****** Object:  StoredProcedure [dbo].[Dom_DomainDetailsAllVersionsListBy]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dom_DomainDetailsAllVersionsListBy]
--Dom_DomainDetailsAllVersionsListBy '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19','398','47'
@List nvarchar(max),@RecordSerial nvarchar(max),@DomainID nvarchar(max)
--,@Key nvarchar(max),@KeyVal nvarchar(max)
as
DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
declare @KeyVal varchar(max)

set @KeyVal=(select Col1 from Dom_DomainDetailsAllVersionsList where [RecordSerial]=@RecordSerial)
set @DomainID2=@DomainID;

SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsAllVersionsList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 

SET @SQL='SELECT  '+ @column+',VersionNumber FROM'+' '+'Dom_DomainDetailsAllVersionsList
 where [DomainID]='+@DomainID2  +' and Dom_DomainDetailsAllVersionsList.Col1='+@KeyVal
PRINT @SQL

EXEC(@SQL)


GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDomainAssignDynamicColumnForExport]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
--[dbo].[Dom_GetDomainAssignDynamicColumnForExport]',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19',1,2,0
 CREATE proc [dbo].[Dom_GetDomainAssignDynamicColumnForExport]
 @List varchar(max) , @DomainID int,@VersionNumber nvarchar(max),@Type bit
 as

DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;


declare @C int
DECLARE @I int
declare @X nvarchar(max)

declare @item nvarchar(max)
set @X='';

 
SET @I = 1
SET @C = (SELECT COUNT(*) FROM SplitDelimiterString(@List,','))
IF @C > 0
	WHILE (@I <= (SELECT MAX(Item) FROM SplitDelimiterString(@List,',')))
    BEGIN
	
	set @item=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@List,',')
) t2
Where RowNum = @I)

			set @X= @X+ 'Col'+ convert(nvarchar(max), @item)+' as [' +( select [AliasName] 
from [dbo].[Dom_DomainColumnsAlias] where [ColumnName] = 'Col'+convert(nvarchar(max), @item)
 and [DomainID]=@DomainID2 and [VersionNumber]=@VersionNumber)
 + '],'

 

	 SET @I = @I + 1
    END
 
set @X=  LEFT(@X, LEN(@X)-1)
if @Type = 1
begin
SET @SQL='SELECT distinct Supervisor,[Leader],[Collector],  '+ @X +' FROM Dom_DomainDetailsToBankAssignList where [DomainID]='+@DomainID2 
end
else
begin
SET @SQL='SELECT distinct Supervisor,[Leader],[Collector],  '+ @X +' FROM Dom_DomainDetailsToInternalAssignList where [DomainID]='+@DomainID2 
end
PRINT @SQL

EXEC(@SQL)
  

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDomainDynamicColumnForExport]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
--[dbo].[Dom_GetDomainDynamicColumnForExport]'1,3,8,7,2,4,5,13,15,6',47,'4'
 CREATE proc [dbo].[Dom_GetDomainDynamicColumnForExport]
 @List varchar(max) , @DomainID int,@VersionNumber nvarchar(max)
 as

DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;


declare @C int
DECLARE @I int
declare @X nvarchar(max)

declare @item nvarchar(max)
set @X='';

 
SET @I = 1
SET @C = (SELECT COUNT(*) FROM SplitDelimiterString(@List,','))
IF @C > 0
	WHILE (@I <= (SELECT MAX(Item) FROM SplitDelimiterString(@List,',')))
    BEGIN
	
	set @item=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@List,',')
) t2
Where RowNum = @I)

			set @X= @X+ 'Col'+ convert(nvarchar(max), @item)+' as [' +( select [AliasName] 
from [dbo].[Dom_DomainColumnsAlias] where [ColumnName] = 'Col'+convert(nvarchar(max), @item)
 and [DomainID]=@DomainID2 and [VersionNumber]=@VersionNumber)
 + '],'

 

	 SET @I = @I + 1
    END
 
set @X=  LEFT(@X, LEN(@X)-1)
--select @X
SET @SQL='SELECT distinct  '+ @X +' FROM Dom_DomainDetailsList where [DomainID]='+@DomainID2 
PRINT @SQL

EXEC(@SQL)
  --[dbo].[Dom_GetDomainDynamicColumnForExport]',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19',47,'4'

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--[dbo].[Dom_GetDynamicColumn]'1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19',47
 CREATE proc [dbo].[Dom_GetDynamicColumn]--'1,2,3,4,5,6,7,8,9,10,11,12'
 @List varchar(max) , @DomainID int
 as
DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;

--set @List='10,11,12,13,'
SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 

SET @SQL='SELECT  '+ @column+',RecordSerial FROM'+' '+'Dom_DomainDetailsList where [DomainID]='+@DomainID2 
PRINT @SQL

EXEC(@SQL)



 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnByFilter]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [dbo].[Dom_GetDynamicColumnByFilter] ',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19','Col11,Col3,','SouthEastern Asia,MARK ALFAR, ',1,0
 CREATE proc [dbo].[Dom_GetDynamicColumnByFilter]
 @List varchar(max) , @Col varchar(max) , @ColVal varchar(max) , @DomainID int,@Type bit
 as
DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

declare @C int
DECLARE @I int
declare @X nvarchar(max)

declare @item nvarchar(max)
declare @itemVal nvarchar(max)

set @DomainID2=@DomainID;

if @Type = 1
begin


SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsToBankAssignList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 


set @X='';

 
SET @I = 1
SET @C = (SELECT COUNT(*) FROM SplitDelimiterString(@Col,','))
IF @C > 0
	WHILE (@I <= @C)--(SELECT MAX(Item) FROM SplitDelimiterString(@Col,',')))
    BEGIN
	
	set @item=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@Col,',')
) t2
Where RowNum = @I)

	set @itemVal=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@ColVal,',')
) t2
Where RowNum = @I)


set @X= @X + ' and ' + convert(nvarchar(max), @item) + ' Like ''%' + convert(nvarchar(max), @itemVal)+'%'' '
			

	 SET @I = @I + 1
    END
--set @X=  LEFT(@X, LEN(@X)-4)
--select @X
SET @SQL='SELECT  Supervisor,[Leader],[Collector]
, '+ @column+',RecordSerial FROM Dom_DomainDetailsToBankAssignList 
where [DomainID]='+@DomainID2 +  @X
end
else
begin

SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsToInternalAssignList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 


set @X='';

 
SET @I = 1
SET @C = (SELECT COUNT(*) FROM SplitDelimiterString(@Col,','))
IF @C > 0
	WHILE (@I <= @C)--(SELECT MAX(Item) FROM SplitDelimiterString(@Col,',')))
    BEGIN
	
	set @item=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@Col,',')
) t2
Where RowNum = @I)

	set @itemVal=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@ColVal,',')
) t2
Where RowNum = @I)


set @X= @X + ' and ' + convert(nvarchar(max), @item) + ' Like ''%' + convert(nvarchar(max), @itemVal)+'%'' '
			

	 SET @I = @I + 1
    END
--set @X=  LEFT(@X, LEN(@X)-4)
--select @X
SET @SQL='SELECT   Supervisor,[Leader],[Collector]
, '+ @column+',RecordSerial FROM Dom_DomainDetailsToInternalAssignList 
where [DomainID]='+@DomainID2 +  @X
end
PRINT @SQL

EXEC(@SQL)



 -- [dbo].[Dom_GetDynamicColumnByFilter] ',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19','Col11,Col3,','SouthEastern Asia,MARK ALFAR, ',1,1

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnClearFilter]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [dbo].[Dom_GetDynamicColumnCleanFilter] ',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19',1,0
 CREATE proc [dbo].[Dom_GetDynamicColumnClearFilter]
 @List varchar(max) , @DomainID int,@Type bit
 as

DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;



if @Type = 1
begin
 
SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsToBankAssignList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 

SET @SQL='SELECT    Supervisor,[Leader],[Collector], '+ @column+',RecordSerial FROM'+' '+'Dom_DomainDetailsToBankAssignList where [DomainID]='+@DomainID2 

end
else
begin
  
SELECT @column = COALESCE(@column + ', ', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsToInternalAssignList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 

SET @SQL='SELECT     Supervisor,[Leader],[Collector], '+ @column+',RecordSerial FROM'+' '+'Dom_DomainDetailsToInternalAssignList where [DomainID]='+@DomainID2 

end
PRINT @SQL

EXEC(@SQL)



 -- [dbo].[Dom_GetDynamicColumnCleanFilter] ',1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19',1,1

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnForExport]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
--[dbo].[Dom_GetDynamicColumnForExport]'1,3,8,7,2,4,5,13,15,6',47,'4'
 CREATE proc [dbo].[Dom_GetDynamicColumnForExport]
 @List varchar(max) , @DomainID int,@VersionNumber nvarchar(max)
 as

DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;


declare @C int
DECLARE @I int
declare @X nvarchar(max)

declare @item nvarchar(max)
set @X='';

 
SET @I = 1
SET @C = (SELECT COUNT(*) FROM SplitDelimiterString(@List,','))
IF @C > 0
	WHILE (@I <= (SELECT MAX(Item) FROM SplitDelimiterString(@List,',')))
    BEGIN
	
	set @item=
	(Select Item
From 
(
    Select 
      Row_Number() Over (Order By (SELECT 0)) As RowNum
    , *
    From SplitDelimiterString(@List,',')
) t2
Where RowNum = @I)

			set @X= @X+ 'Col'+ convert(nvarchar(max), @item)+' as [' +( select [AliasName] 
from [dbo].[Dom_DomainColumnsAlias] where [ColumnName] = 'Col'+convert(nvarchar(max), @item)
 and [DomainID]=@DomainID2 and [VersionNumber]=@VersionNumber)
 + '],'

 

	 SET @I = @I + 1
    END


--[dbo].[Dom_GetDynamicColumnForImport]'1,3,8,7,2,4,5,13,15,6',47
	






SET @SQL='SELECT  '+ @X +
' DomainTitle as [Domain Title],AgencyTitle as [Agency Title],MonthYear as [Month Year],MemberName as [Action Taker]
,ConnectionTypeTitle as [Connection Type],ConnectionResultTitle as [Connection Result],ConnectionDate as [Connection Date],
SchemaName as [Schema Name],VersionNumber as [Version Number],PTPTypeTitle as [PTP Type],PTPDate as [PTP Date],PTPAmount as [PTP Amount]
,KeptAmount as [Kept Amount],EngComment as [English Comment],ArabicComment as[Arabic Comment]
 FROM'+' '+'DCR_DCRHistoryWithAccountsToImport where [DomainID]='+@DomainID2 
PRINT @SQL

EXEC(@SQL)



---- ,BranchTitle,MemberName
----,ConnectionTypeTitle,ConnectionResultTitle,PTPTypeTitle,
----SchemaName,VersionNumber,ConnectionDate,PTPDate,PTPAmount
----,IsPromiseKept,KeptAmount,EngComment,ArabicComment

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToBucketDiff]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[Dom_GetDynamicColumnToBucketDiff]
 -- Dom_GetDynamicColumnToBucketDiff 47,'Col1','Col6','Col7','Col8'
 @DomainID int,@PK varchar(max),@BuckectCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;


 set @SQL= ' select t1.'+ @BuckectCol  +' as Bucket
 ,(sum(convert(decimal(12,2), t1.'+@BalanceCol+'))-Sum(convert(decimal(12,2), t2.'+@BalanceCol+'))) as BalanceDiff
 ,(sum(convert(decimal(12,2), t1.'+ @PDCol +'))-Sum(convert(decimal(12,2), t2.'+ @PDCol +'))) as PDDiff
from

(select '+ @BuckectCol  +'
, SUM(convert(decimal(12,2), '+@BalanceCol+')) as '+@BalanceCol+'
, SUM(convert(decimal(12,2), '+ @PDCol +')) as '+ @PDCol +'
from Dom_DomainDetailsList  where DomainID = '+@DomainID2+'
group by '+ @BuckectCol  +') t1 
INNER JOIN
(select '+ @BuckectCol  +'
, SUM(convert(decimal(12,2), '+@BalanceCol+')) as '+@BalanceCol+'
, SUM(convert(decimal(12,2), '+ @PDCol +')) as '+ @PDCol +'
from Dom_DomainDetailsListPrev  where DomainID = '+@DomainID2+' group by '+ @BuckectCol  +') t2 
ON t1.'+@BuckectCol+' = t2.'+@BuckectCol+' where t1.'+@BalanceCol+' <> t2.'+@BalanceCol+'
group by t1.'+ @BuckectCol
 

 EXEC(@SQL)


---- select t1.Col6
---- ,(sum(convert(decimal(12,2), t1.Col8))-Sum(convert(decimal(12,2), t2.Col8))) as BalanceDiff
---- ,(sum(convert(decimal(12,2), t1.Col7))-Sum(convert(decimal(12,2), t2.Col7))) as PDDiff
----from

----(select col6, SUM(convert(decimal(12,2), Col8)) as Col8, SUM(convert(decimal(12,2), Col7)) as Col7
----from Dom_DomainDetailsList
----group by col6) t1 
----INNER JOIN
----(select col6, SUM(convert(decimal(12,2), Col8)) as Col8, SUM(convert(decimal(12,2), Col7)) as Col7
----from Dom_DomainDetailsListPrev group by col6) t2 ON t1.col6 = t2.col6 where t1.Col8 <> t2.Col8 and t1.Col7 <> t2.Col7
----group by t1.Col6



 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToCurrentBucket]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Dom_GetDynamicColumnToCurrentBucket]
 -- Dom_GetDynamicColumnToCurrentBucket 47,'Col6','Col7','Col8'
 @DomainID int,@BuckectCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;

set @SQL= 'select d2.'+ @BuckectCol 
		+' as Bucket ,count(d2.'+ @BuckectCol +') as Count, sum(convert(decimal(12,2), d2.'+ @PDCol +')) as PastDue
			, sum(convert(decimal(12,2), d2.'+@BalanceCol+')) as Balance
			from Dom_DomainDetailsList d2  
			 where   d2.DomainID=' + @DomainID2
			 +'group by d2.'+ @BuckectCol 
 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToCurrentCycle]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Dom_GetDynamicColumnToCurrentCycle]
 --[Dom_GetDynamicColumnToCurrentCycle] 47,'Col6','Col7','Col8'
 @DomainID int,@CycleCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;

set @SQL= 'select d2.'+ @CycleCol 
		+' as Cycle ,count(d2.'+ @CycleCol +') as Count, sum(convert(decimal(12,2), d2.'+ @PDCol +')) as PastDue
			, sum(convert(decimal(12,2), d2.'+@BalanceCol+')) as Balance
			from [dbo].[Dom_DomainDetailsList] d2  
			 where   d2.DomainID=' + @DomainID2
			 +'group by d2.'+ @CycleCol 
 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToCycleDiff]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

CREATE proc [dbo].[Dom_GetDynamicColumnToCycleDiff]
 -- Dom_GetDynamicColumnToCycleDiff 47,'Col1','Col5','Col7','Col8'
 @DomainID int,@PK varchar(max),@CycleCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;


 set @SQL= ' select t1.'+ @CycleCol  +' as Cycle
 ,(sum(convert(decimal(12,2), t1.'+@BalanceCol+'))-Sum(convert(decimal(12,2), t2.'+@BalanceCol+'))) as BalanceDiff
 ,(sum(convert(decimal(12,2), t1.'+ @PDCol +'))-Sum(convert(decimal(12,2), t2.'+ @PDCol +'))) as PDDiff
from

(select '+ @CycleCol  +'
, SUM(convert(decimal(12,2), '+@BalanceCol+')) as '+@BalanceCol+'
, SUM(convert(decimal(12,2), '+ @PDCol +')) as '+ @PDCol +'
from Dom_DomainDetailsList where DomainID = '+@DomainID2+'
group by '+ @CycleCol  +') t1 
INNER JOIN
(select '+ @CycleCol  +'
, SUM(convert(decimal(12,2), '+@BalanceCol+')) as '+@BalanceCol+'
, SUM(convert(decimal(12,2), '+ @PDCol +')) as '+ @PDCol +'
from Dom_DomainDetailsListPrev where DomainID = '+@DomainID2+'
 group by '+ @CycleCol  +') t2 
ON t1.'+@CycleCol+' = t2.'+@CycleCol+' where t1.'+@BalanceCol+' <> t2.'+@BalanceCol+'
 
group by t1.'+ @CycleCol
 

 EXEC(@SQL)

  

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToNewRecoreds]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dom_GetDynamicColumnToNewRecoreds]
 -- Dom_GetDynamicColumnToNewRecoreds '1,2,3,4,5,6,7,8,9,10,11,12',47,'Col1'
@List varchar(max) , @DomainID int,@PK varchar(max)
 as
  

DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;

--set @List='10,11,12,13,'
SELECT @column = COALESCE(@column + ', d2.', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 
 

SET @SQL='SELECT d2.'+' '+ @column+' '+ 'FROM'+' '+' Dom_DomainDetailsList d2
full join Dom_DomainDetailsListPrev d1 on d2.'+ @PK +'=d1.'+ @PK +'  where d1.'+ @PK 
+' is null and d2.DomainID='+@DomainID2 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToPrevBucket]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[Dom_GetDynamicColumnToPrevBucket]
 -- Dom_GetDynamicColumnToCurrentBucket 47,'Col6','Col7','Col8'
 @DomainID int,@BuckectCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;

set @SQL= 'select d2.'+ @BuckectCol 
		+' as Bucket ,count(d2.'+ @BuckectCol +') as Count, sum(convert(decimal(12,2), d2.'+ @PDCol +')) as PastDue
			, sum(convert(decimal(12,2), d2.'+@BalanceCol+')) as Balance
			from [dbo].[Dom_DomainDetailsListPrev] d2  
			 where   d2.DomainID=' + @DomainID2
			 +'group by d2.'+ @BuckectCol 
 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToPrevCycle]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Dom_GetDynamicColumnToPrevCycle]
 --[Dom_GetDynamicColumnToPrevCycle] 47,'Col6','Col7','Col8'
 @DomainID int,@CycleCol varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;

set @SQL= 'select d2.'+ @CycleCol 
		+' as Cycle ,count(d2.'+ @CycleCol +') as Count, sum(convert(decimal(12,2), d2.'+ @PDCol +')) as PastDue
			, sum(convert(decimal(12,2), d2.'+@BalanceCol+')) as Balance
			from [dbo].[Dom_DomainDetailsListPrev] d2  
			 where   d2.DomainID=' + @DomainID2
			 +'group by d2.'+ @CycleCol 
 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToRecoredsSummary]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Dom_GetDynamicColumnToRecoredsSummary]
 -- Dom_GetDynamicColumnToRecoredsSummary 47,'Col1','Col7','Col8'
 @DomainID int,@PK varchar(max),@PDCol varchar(max),@BalanceCol varchar(max)
 as
  
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)
 set @DomainID2=@DomainID;

set @SQL= 'select  sum(convert(decimal(12,2), d2.'+ @PDCol +')) as sumPDLast
			, sum(convert(decimal(12,2), d1.'+@PDCol+')) as sumPDPrev
			, sum(convert(decimal(12,2), d2.'+@BalanceCol+')) as sumBalanceLast
			, sum(convert(decimal(12,2), d1.'+@BalanceCol+')) as sumBalancePrev
			, (sum(convert(decimal(12,2), d2.'+ @PDCol +')) - sum(convert(decimal(12,2), d1.'+@PDCol+'))) as PDDiff
			, (sum(convert(decimal(12,2), d2.'+ @BalanceCol +')) - sum(convert(decimal(12,2), d1.'+@BalanceCol+'))) as BalanceDiff
			from Dom_DomainDetailsList d2 full join Dom_DomainDetailsListPrev d1 on d1.'+ @PK +' = d2.'+ @PK 
			+ ' where d1.DomainID=' + @DomainID2 + ' and d2.DomainID=' + @DomainID2
 


EXEC(@SQL)

 

GO
/****** Object:  StoredProcedure [dbo].[Dom_GetDynamicColumnToRemovedRecoreds]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dom_GetDynamicColumnToRemovedRecoreds]
 -- Dom_GetDynamicColumnToRemovedRecoreds '1,2,3,4,5,6,7,8,9,10,11,12',47,'Col1'
@List varchar(max) , @DomainID int,@PK varchar(max)
 as
  

DECLARE @column varchar(max)
DECLARE @SQL varchar(max)
declare @DomainID2 varchar(max)

set @DomainID2=@DomainID;

--set @List='10,11,12,13,'
SELECT @column = COALESCE(@column + ', d1.', '') + 
   CAST(column_name AS varchar(max))
from information_schema.columns
where table_name='Dom_DomainDetailsList'
and ordinal_position in (select * from  SplitDelimiterString(@List,',')) 
 

SET @SQL='SELECT d1.'+' '+ @column+' '+ 'FROM'+' '+' Dom_DomainDetailsList d2
full join Dom_DomainDetailsListPrev d1 on d2.'+ @PK +'=d1.'+ @PK +'  where d2.'+
 @PK +' is null and d1.DomainID='+@DomainID2 

--PRINT @SQL

EXEC(@SQL)



GO
/****** Object:  StoredProcedure [dbo].[Dom_MasterDomainSP]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Dom_MasterDomainSP 'col3','IBRAHIM'

CREATE proc [dbo].[Dom_MasterDomainSP]

@ColName  varchar(max),@ColVal  varchar(max)
as
DECLARE @SQL varchar(max);

if @ColName='col3'
begin
SET @SQL='SELECT  distinct DomainTitle,AgencyTitle,BranchTitle,VersionNumber
  FROM Dom_MasterDomain where '+@ColName+' LIKE ''%'+@ColVal+'%'''
end
else
begin
SET @SQL='SELECT  distinct DomainTitle,AgencyTitle,BranchTitle,VersionNumber
  FROM Dom_MasterDomain where '+@ColName+'='''+@ColVal+''''
end

PRINT @SQL

EXEC(@SQL)



GO
/****** Object:  StoredProcedure [dbo].[Dom_PrepearingBeforeUpdateDomain]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Dom_PrepearingBeforeUpdateDomain]
@DomainID int

as

Begin transaction

/* First statement*/
--delete from [dbo].[Dom_DomainColumnsAlias] where [DomainID] =@DomainID
    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

/* Second statement*/
--delete from [dbo].[Dom_DomainsDataExtra] where [DomainID] =@DomainID
    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End
	

/* If we reach this point, the commands 
completed successfully Commit the transaction
*/

Commit




GO
/****** Object:  StoredProcedure [dbo].[PCR_PCRHistoryInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[PCR_PCRHistoryInsert]
@DomainID bigint	
 			,@MemberID int
           ,@AccountID bigint
           ,@ConnectionTypeID tinyint
           ,@ConnectionResultID tinyint
           ,@PTPTypeID tinyint
           ,@ConnectionDate date
           ,@PTPDate date
           ,@PTPAmount decimal(12,2)=null
           ,@IsPromiseKept bit
           ,@KeptAmount decimal(12,2)=null
           ,@EngComment nvarchar(max)
           ,@ArabicComment nvarchar(max)
as
INSERT  into [dbo].[PCR_PCRHistory]
           ([DomainID]
		   ,[MemberID]
           ,[AccountID]
           ,[ConnectionTypeID]
           ,[ConnectionResultID]
           ,[PTPTypeID]
           ,[ConnectionDate]
           ,[PTPDate]
           ,[PTPAmount]
           ,[IsPromiseKept]
           ,[KeptAmount]
           ,[EngComment]
           ,[ArabicComment])
     VALUES
           (@DomainID
		   ,@MemberID  
           ,@AccountID  
           ,@ConnectionTypeID  
           ,@ConnectionResultID  
           ,@PTPTypeID  
           ,@ConnectionDate 
           ,@PTPDate 
           ,@PTPAmount 
           ,@IsPromiseKept 
           ,@KeptAmount 
           ,@EngComment 
           ,@ArabicComment )


GO
/****** Object:  StoredProcedure [dbo].[PCR_PCRHistoryUpdate]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[PCR_PCRHistoryUpdate]
			@DCRID bigint
			,@DomainID bigint	
 			,@MemberID int
           ,@AccountID bigint
           ,@ConnectionTypeID tinyint
           ,@ConnectionResultID tinyint
           ,@PTPTypeID tinyint
           ,@ConnectionDate date
           ,@PTPDate date
           ,@PTPAmount decimal(12,2)=null
           ,@IsPromiseKept bit
           ,@KeptAmount decimal(12,2)=null
           ,@EngComment nvarchar(max)
           ,@ArabicComment nvarchar(max)
as
update [dbo].[PCR_PCRHistory] set
			
		   [DomainID]			 =  @DomainID
		   ,[MemberID]			 =  @MemberID
           ,[AccountID]			 =  @AccountID
           ,[ConnectionTypeID]	 =  @ConnectionTypeID
           ,[ConnectionResultID] =  @ConnectionResultID
           ,[PTPTypeID]			 =  @PTPTypeID
           ,[ConnectionDate]	 =  @ConnectionDate
           ,[PTPDate]			 =  @PTPDate
           ,[PTPAmount]			 =  @PTPAmount
           ,[IsPromiseKept]		 =  @IsPromiseKept
           ,[KeptAmount]		 =  @KeptAmount
           ,[EngComment]		 =  @EngComment
           ,[ArabicComment]		 =  @ArabicComment
		   
   where   [PCRID]				 =  @DCRID

GO
/****** Object:  StoredProcedure [dbo].[Pre_ChangePassword]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Pre_ChangePassword] (@UserID tinyint , @password varchar(50))
as
begin
update [dbo].[Pre_Users] set [Password]=CONVERT(varbinary(50),@password)
where UserID=@UserID
end
/****** Object:  StoredProcedure [dbo].[Pre_UserPasswordReset]    Script Date: 8/23/2017 4:19:53 PM ******/
SET ANSI_NULLS ON


GO
/****** Object:  StoredProcedure [dbo].[Pre_UserData]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Pre_UserData] --Pre_UserData 1,'1234' --Pre_UserData 13,'123' 

 (@UserID int , @password varchar(50))
 as
SELECT [UserID]
      ,[DisplayName]
      ,[UserName]
	  ,CONVERT(varchar(50) ,[Password])
      ,[IsActive]
      ,[ProfileImage]	 
      ,[IsDeleted]
      ,[IsDeletable]
      ,[RCDate]
      ,[RCBy]
      ,[LADate]
      ,[LABy]
  FROM [dbo].[Pre_Users]
  where [UserID]=@UserID and [Password]=CONVERT(varbinary(50),@password) and [IsActive]=1








GO
/****** Object:  StoredProcedure [dbo].[Pre_UserPasswordReset]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Pre_UserPasswordReset]  

 (@UserID smallint, @Password nvarchar(50) )
 as
exec [Pre_ChangePassword] @UserID,@Password








GO
/****** Object:  StoredProcedure [dbo].[pre_UsersEdit]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pre_UsersEdit] --[dbo].[pre_UsersEdit] 17, 'amina','amina',1,1,'2,4','1-1-2018',1


    (@ID smallint,@DisplayName nvarchar(500) 
           ,@UserName nvarchar(500)
		     ,@Branch int
		   ,@Group int
		   ,@Section nvarchar(max)
		   ,@LADate date
		   ,@LABy int)
		   as

UPDATE [dbo].[Pre_Users]
   SET [DisplayName] = @DisplayName
      ,[UserName] = @UserName
	  ,LADate=@LADate
	  ,LABy=@LABy
 WHERE  [UserID]=@ID

 UPDATE [dbo].[Pre_BranchesPermissions]  SET [BranchID] = @Branch WHERE  [UserID]=@ID

 UPDATE [dbo].[Pre_GroupsMembers] SET [GroupID] = @Group  ,LADate=@LADate  ,LABy=@LABy WHERE  [UserID]=@ID


 Begin transaction

delete from [dbo].[Pre_SectionPermissions] WHERE  [UserID]=@ID

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

 DECLARE @Sec_Tbl TABLE (idx2 smallint Primary Key IDENTITY(1,1),SecID smallint)

INSERT @Sec_Tbl SELECT  Item from SplitDelimiterString(@Section,',')

declare @Count int
DECLARE @Init int
DECLARE @SecID tinyint

SET @Init = 1
SET @Count = (SELECT COUNT(*) FROM @Sec_Tbl)
IF @Count > 0
	WHILE (@Init <= (SELECT MAX(idx2) FROM @Sec_Tbl))
    BEGIN
	set @SecID=(select SecID from @Sec_Tbl where idx2 = @Init)
	INSERT INTO [dbo].[Pre_SectionPermissions]  ([UserID]  ,[SectionID]) VALUES (@ID,@SecID)
	--update [dbo].[Pre_SectionPermissions]  set [SectionID]=@SecID WHERE  [UserID]=@ID 
	 SET @Init = @Init + 1
    END

    If @@ERROR <> 0
	Begin
		Rollback
		Return
	End

/* If we reach this point, the commands 
completed successfully Commit the transaction
*/

Commit
 
 --[dbo].[pre_UsersEdit] 17, 'amina','amina',1,1,'2,4','1-1-2018',1



GO
/****** Object:  StoredProcedure [dbo].[pre_UsersInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pre_UsersInsert]--[dbo].[pre_UsersInsert] 'test','test','test',null,1,1,'1',1,'1-1-2017',1


    (@DisplayName nvarchar(500) 
           ,@UserName nvarchar(500) 
           ,@Password varchar(50) 
		   ,@Image varbinary(max)  = null
		   ,@Branch int
		   ,@Group int
		   ,@Section nvarchar(max)
           ,@IsActive bit
		   ,@RCDate date
		   ,@RCBy int
		    )
		   as

		    declare @Userid int

		   if @Image is null
		   begin
INSERT INTO [dbo].[Pre_Users]
           ([DisplayName]
           ,[UserName]
           ,[Password]
           ,[IsActive],[RCDate],[RCBy])
     VALUES
           (@DisplayName  
           ,@UserName  
           ,CONVERT(varbinary(50),@Password) 
           ,@IsActive,@RCDate,@RCBy)

		   end
		   else
		   begin

INSERT INTO [dbo].[Pre_Users]
           ([DisplayName]
           ,[UserName]
           ,[Password]
		   ,[ProfileImage]
           ,[IsActive],[RCDate],[RCBy])
     VALUES
           (@DisplayName  
           ,@UserName  
           ,CONVERT(varbinary(50),@Password) 
		   ,@Image
           ,@IsActive,@RCDate,@RCBy)		  


		   end

set @Userid =( select scope_identity())

if @Userid>1
begin
 INSERT INTO [dbo].[Pre_BranchesPermissions] ([BranchID] ,[UserID])  VALUES (@Branch,@Userid)
 
INSERT INTO [dbo].[Pre_GroupsMembers] ([UserID],[GroupID],[RCDate],[RCBy])  VALUES (@Userid,@Group,@RCDate,@RCBy)


DECLARE @Sec_Tbl TABLE (idx2 smallint Primary Key IDENTITY(1,1),SecID smallint)

INSERT @Sec_Tbl SELECT  Item from SplitDelimiterString(@Section,',')

declare @Count int
DECLARE @Init int
DECLARE @SecID tinyint

SET @Init = 1
SET @Count = (SELECT COUNT(*) FROM @Sec_Tbl)
IF @Count > 0
	WHILE (@Init <= (SELECT MAX(idx2) FROM @Sec_Tbl))
    BEGIN
	set @SecID=(select SecID from @Sec_Tbl where idx2 = @Init)
	INSERT INTO [dbo].[Pre_SectionPermissions]  ([UserID]  ,[SectionID]) VALUES (@Userid,@SecID)
	 SET @Init = @Init + 1
    END


     
   
 
end

GO
/****** Object:  StoredProcedure [dbo].[Sch_SchemaColomnsDelete]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sch_SchemaColomnsDelete]
@CoID tinyint,@SchemaID tinyint
as
delete from [dbo].[Sch_SchemaColumns] where [CoID]=@CoID and [SchemaID]=@SchemaID

GO
/****** Object:  StoredProcedure [dbo].[Sch_SchemaColomnsInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sch_SchemaColomnsInsert]
@CoID tinyint,@SchemaID tinyint,@ColumnIndex int
as
if not exists (select * from [dbo].[Sch_SchemaColumns] where [CoID]=@CoID and [SchemaID]=@SchemaID)
insert into [dbo].[Sch_SchemaColumns]

([CoID], [SchemaID],[ColumnIndex])
values
(@CoID , @SchemaID,@ColumnIndex)


GO
/****** Object:  StoredProcedure [dbo].[Sch_SchemaInsert]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sch_SchemaInsert]
@SchemaName nvarchar(250),@BranchID tinyint

as
insert into [dbo].[Sch_Schemas]
([SchemaName],[BranchID])
values(@SchemaName ,@BranchID )

   declare @ID tinyint
		   set @ID =( select scope_identity())
		   declare @Count int
DECLARE @Init int
DECLARE @CoID tinyint

SET @Init = 1
SET @Count = (SELECT COUNT(*) FROM Sch_Columns where [IsFixed]=1)
IF @Count > 0
	WHILE (@Init <= (SELECT MAX([CoID]) FROM Sch_Columns  where [IsFixed]=1))
    BEGIN
	set @CoID=(select CoID from Sch_Columns where [CoID] = @Init)
	if @CoID is not null
	INSERT INTO [dbo].[Sch_SchemaColumns] ([CoID]  ,[SchemaID]) VALUES (@CoID,@ID)
	 SET @Init = @Init + 1
    END


 

GO
/****** Object:  UserDefinedFunction [dbo].[SplitDelimiterString]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create FUNCTION [dbo].[SplitDelimiterString] (@StringWithDelimiter VARCHAR(8000), @Delimiter VARCHAR(8))

RETURNS @ItemTable TABLE (Item VARCHAR(8000))

AS
BEGIN
    DECLARE @StartingPosition INT;
    DECLARE @ItemInString VARCHAR(8000);

    SELECT @StartingPosition = 1;
    --Return if string is null or empty
    IF LEN(@StringWithDelimiter) = 0 OR @StringWithDelimiter IS NULL RETURN; 
    
    WHILE @StartingPosition > 0
    BEGIN
        --Get starting index of delimiter .. If string
        --doesn't contain any delimiter than it will returl 0 
        SET @StartingPosition = CHARINDEX(@Delimiter,@StringWithDelimiter); 
        
        --Get item from string        
        IF @StartingPosition > 0                
            SET @ItemInString = SUBSTRING(@StringWithDelimiter,0,@StartingPosition)
        ELSE
            SET @ItemInString = @StringWithDelimiter;
        --If item isn't empty than add to return table    
        IF( LEN(@ItemInString) > 0)
            INSERT INTO @ItemTable(Item) VALUES (@ItemInString);            
        
        --Remove inserted item from string
        SET @StringWithDelimiter = SUBSTRING(@StringWithDelimiter,@StartingPosition + 
                     LEN(@Delimiter),LEN(@StringWithDelimiter) - @StartingPosition)
        
        --Break loop if string is empty
        IF LEN(@StringWithDelimiter) = 0 BREAK;
    END
     
    RETURN
END

GO
/****** Object:  Table [dbo].[Config_AgencyBranches]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config_AgencyBranches](
	[RecoredSerial] [smallint] IDENTITY(1,1) NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[AgencyID] [int] NOT NULL,
 CONSTRAINT [PK_Config_AgencyBranches] PRIMARY KEY CLUSTERED 
(
	[RecoredSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Config_AgencyList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config_AgencyList](
	[AgencyID] [int] IDENTITY(1,1) NOT NULL,
	[AgencyTitle] [nvarchar](300) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Config_AgencyList] PRIMARY KEY CLUSTERED 
(
	[AgencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Config_MembersList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config_MembersList](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Config_MembersList] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Config_TeamList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config_TeamList](
	[TeamID] [int] IDENTITY(1,1) NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[AgencyID] [int] NOT NULL,
	[TeamName] [nvarchar](max) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Config_TeamList] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Config_TeamMembers]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config_TeamMembers](
	[RecoredSerial] [int] IDENTITY(1,1) NOT NULL,
	[TeamID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[RoleID] [smallint] NOT NULL,
 CONSTRAINT [PK_Config_TeamMembers] PRIMARY KEY CLUSTERED 
(
	[RecoredSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Design_MenuBasic]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Design_MenuBasic](
	[MenuID] [smallint] IDENTITY(1,1) NOT NULL,
	[SectionID] [tinyint] NOT NULL,
	[DepartKey] [nvarchar](100) NULL,
	[MenuTitle] [nvarchar](150) NOT NULL,
	[IconClass] [nvarchar](150) NULL,
	[DirectURL] [nvarchar](max) NULL,
	[DisplayID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_MainMenu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Design_MenuItems]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Design_MenuItems](
	[MenuItemID] [smallint] IDENTITY(1,1) NOT NULL,
	[MenuID] [smallint] NOT NULL,
	[SectionID] [tinyint] NULL,
	[MenuItemName] [nvarchar](150) NOT NULL,
	[AreaName] [nvarchar](max) NULL,
	[ControllerName] [nvarchar](max) NULL,
	[ActionName] [nvarchar](max) NULL,
	[IconClass] [nvarchar](150) NULL,
	[DisplayID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED 
(
	[MenuItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_AccountsPayments]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_AccountsPayments](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[RecordSerial] [bigint] NOT NULL,
	[PaymentValue] [decimal](12, 2) NULL,
 CONSTRAINT [PK_Dom_AccountsPayments] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_AssignDomainToMembers]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_AssignDomainToMembers](
	[AssignID] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountID] [bigint] NOT NULL,
	[MemberID] [int] NOT NULL,
	[RoleID] [smallint] NOT NULL,
	[TeamID] [int] NOT NULL,
	[IsBank] [bit] NULL,
 CONSTRAINT [PK_Dom_AssignDomainToMembers] PRIMARY KEY CLUSTERED 
(
	[AssignID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_DomainBasic]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_DomainBasic](
	[DomainID] [bigint] IDENTITY(1,1) NOT NULL,
	[StatusID] [tinyint] NULL,
	[AgencyID] [int] NOT NULL,
	[MonthID] [int] NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[DomainTitle] [nvarchar](250) NULL,
	[DomainType] [nvarchar](250) NULL,
 CONSTRAINT [PK_Dom_DomainBasic] PRIMARY KEY CLUSTERED 
(
	[DomainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_DomainColumnsAlias]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_DomainColumnsAlias](
	[AliasID] [bigint] IDENTITY(1,1) NOT NULL,
	[DomainID] [bigint] NOT NULL,
	[ColumnName] [nvarchar](350) NULL,
	[AliasName] [nvarchar](350) NULL,
	[VersionNumber] [tinyint] NULL,
 CONSTRAINT [PK_Dom_DomainColumnsAlias] PRIMARY KEY CLUSTERED 
(
	[AliasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_DomainsDataExtra]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_DomainsDataExtra](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[SchemaID] [tinyint] NOT NULL,
	[DomainID] [bigint] NULL,
	[VersionNumber] [tinyint] NULL,
	[Col1] [nvarchar](max) NULL,
	[Col2] [nvarchar](max) NULL,
	[Col3] [nvarchar](max) NULL,
	[Col4] [nvarchar](max) NULL,
	[Col5] [nvarchar](max) NULL,
	[Col6] [nvarchar](max) NULL,
	[Col7] [nvarchar](max) NULL,
	[Col8] [nvarchar](max) NULL,
	[Col9] [nvarchar](max) NULL,
	[Col10] [nvarchar](max) NULL,
	[Col11] [nvarchar](max) NULL,
	[Col12] [nvarchar](max) NULL,
	[Col13] [nvarchar](max) NULL,
	[Col14] [nvarchar](max) NULL,
	[Col15] [nvarchar](max) NULL,
	[Col16] [nvarchar](max) NULL,
	[Col17] [nvarchar](max) NULL,
	[Col18] [nvarchar](max) NULL,
	[Col19] [nvarchar](max) NULL,
	[Col20] [nvarchar](max) NULL,
	[Col21] [nvarchar](max) NULL,
	[Col22] [nvarchar](max) NULL,
	[Col23] [nvarchar](max) NULL,
	[Col24] [nvarchar](max) NULL,
	[Col25] [nvarchar](max) NULL,
	[Col26] [nvarchar](max) NULL,
	[Col27] [nvarchar](max) NULL,
	[Col28] [nvarchar](max) NULL,
	[Col29] [nvarchar](max) NULL,
	[Col30] [nvarchar](max) NULL,
	[Col31] [nvarchar](max) NULL,
	[Col32] [nvarchar](max) NULL,
	[Col33] [nvarchar](max) NULL,
	[Col34] [nvarchar](max) NULL,
	[Col35] [nvarchar](max) NULL,
	[Col36] [nvarchar](max) NULL,
	[Col37] [nvarchar](max) NULL,
	[Col38] [nvarchar](max) NULL,
	[Col39] [nvarchar](max) NULL,
	[Col40] [nvarchar](max) NULL,
	[Col41] [nvarchar](max) NULL,
	[Col42] [nvarchar](max) NULL,
	[Col43] [nvarchar](max) NULL,
	[Col44] [nvarchar](max) NULL,
	[Col45] [nvarchar](max) NULL,
	[Col46] [nvarchar](max) NULL,
	[Col47] [nvarchar](max) NULL,
	[Col48] [nvarchar](max) NULL,
	[Col49] [nvarchar](max) NULL,
	[Col50] [nvarchar](max) NULL,
	[Col51] [nvarchar](max) NULL,
	[Col52] [nvarchar](max) NULL,
	[Col53] [nvarchar](max) NULL,
	[Col54] [nvarchar](max) NULL,
	[Col55] [nvarchar](max) NULL,
	[Col56] [nvarchar](max) NULL,
	[Col57] [nvarchar](max) NULL,
	[Col58] [nvarchar](max) NULL,
	[Col59] [nvarchar](max) NULL,
	[Col60] [nvarchar](max) NULL,
	[Col61] [nvarchar](max) NULL,
	[Col62] [nvarchar](max) NULL,
	[Col63] [nvarchar](max) NULL,
	[Col64] [nvarchar](max) NULL,
	[Col65] [nvarchar](max) NULL,
	[Col66] [nvarchar](max) NULL,
	[Col67] [nvarchar](max) NULL,
	[Col68] [nvarchar](max) NULL,
	[Col69] [nvarchar](max) NULL,
	[Col70] [nvarchar](max) NULL,
	[Col71] [nvarchar](max) NULL,
	[Col72] [nvarchar](max) NULL,
	[Col73] [nvarchar](max) NULL,
	[Col74] [nvarchar](max) NULL,
	[Col75] [nvarchar](max) NULL,
	[Col76] [nvarchar](max) NULL,
	[Col77] [nvarchar](max) NULL,
	[Col78] [nvarchar](max) NULL,
	[Col79] [nvarchar](max) NULL,
	[Col80] [nvarchar](max) NULL,
	[Col81] [nvarchar](max) NULL,
	[Col82] [nvarchar](max) NULL,
	[Col83] [nvarchar](max) NULL,
	[Col84] [nvarchar](max) NULL,
	[Col85] [nvarchar](max) NULL,
	[Col86] [nvarchar](max) NULL,
	[Col87] [nvarchar](max) NULL,
	[Col88] [nvarchar](max) NULL,
	[Col89] [nvarchar](max) NULL,
	[Col90] [nvarchar](max) NULL,
	[Col91] [nvarchar](max) NULL,
	[Col92] [nvarchar](max) NULL,
	[Col93] [nvarchar](max) NULL,
	[Col94] [nvarchar](max) NULL,
	[Col95] [nvarchar](max) NULL,
	[Col96] [nvarchar](max) NULL,
	[Col97] [nvarchar](max) NULL,
	[Col98] [nvarchar](max) NULL,
	[Col99] [nvarchar](max) NULL,
	[Col100] [nvarchar](max) NULL,
	[Col101] [nvarchar](max) NULL,
	[Col102] [nvarchar](max) NULL,
	[Col103] [nvarchar](max) NULL,
	[Col104] [nvarchar](max) NULL,
	[Col105] [nvarchar](max) NULL,
	[Col106] [nvarchar](max) NULL,
	[Col107] [nvarchar](max) NULL,
	[Col108] [nvarchar](max) NULL,
	[Col109] [nvarchar](max) NULL,
	[Col110] [nvarchar](max) NULL,
	[Col111] [nvarchar](max) NULL,
	[Col112] [nvarchar](max) NULL,
	[Col113] [nvarchar](max) NULL,
	[Col114] [nvarchar](max) NULL,
	[Col115] [nvarchar](max) NULL,
	[Col116] [nvarchar](max) NULL,
	[Col117] [nvarchar](max) NULL,
	[Col118] [nvarchar](max) NULL,
	[Col119] [nvarchar](max) NULL,
	[Col120] [nvarchar](max) NULL,
	[Col121] [nvarchar](max) NULL,
	[Col122] [nvarchar](max) NULL,
	[Col123] [nvarchar](max) NULL,
	[Col124] [nvarchar](max) NULL,
	[Col125] [nvarchar](max) NULL,
	[Col126] [nvarchar](max) NULL,
	[Col127] [nvarchar](max) NULL,
	[Col128] [nvarchar](max) NULL,
	[Col129] [nvarchar](max) NULL,
	[Col130] [nvarchar](max) NULL,
	[Col131] [nvarchar](max) NULL,
	[Col132] [nvarchar](max) NULL,
	[Col133] [nvarchar](max) NULL,
	[Col134] [nvarchar](max) NULL,
	[Col135] [nvarchar](max) NULL,
	[Col136] [nvarchar](max) NULL,
	[Col137] [nvarchar](max) NULL,
	[Col138] [nvarchar](max) NULL,
	[Col139] [nvarchar](max) NULL,
	[Col140] [nvarchar](max) NULL,
	[Col141] [nvarchar](max) NULL,
	[Col142] [nvarchar](max) NULL,
	[Col143] [nvarchar](max) NULL,
	[Col144] [nvarchar](max) NULL,
	[Col145] [nvarchar](max) NULL,
	[Col146] [nvarchar](max) NULL,
	[Col147] [nvarchar](max) NULL,
	[Col148] [nvarchar](max) NULL,
	[Col149] [nvarchar](max) NULL,
	[Col150] [nvarchar](max) NULL,
	[Col151] [nvarchar](max) NULL,
	[Col152] [nvarchar](max) NULL,
	[Col153] [nvarchar](max) NULL,
	[Col154] [nvarchar](max) NULL,
	[Col155] [nvarchar](max) NULL,
	[Col156] [nvarchar](max) NULL,
	[Col157] [nvarchar](max) NULL,
	[Col158] [nvarchar](max) NULL,
	[Col159] [nvarchar](max) NULL,
	[Col160] [nvarchar](max) NULL,
	[Col161] [nvarchar](max) NULL,
	[Col162] [nvarchar](max) NULL,
	[Col163] [nvarchar](max) NULL,
	[Col164] [nvarchar](max) NULL,
	[Col165] [nvarchar](max) NULL,
	[Col166] [nvarchar](max) NULL,
	[Col167] [nvarchar](max) NULL,
	[Col168] [nvarchar](max) NULL,
	[Col169] [nvarchar](max) NULL,
	[Col170] [nvarchar](max) NULL,
	[Col171] [nvarchar](max) NULL,
	[Col172] [nvarchar](max) NULL,
	[Col173] [nvarchar](max) NULL,
	[Col174] [nvarchar](max) NULL,
	[Col175] [nvarchar](max) NULL,
	[Col176] [nvarchar](max) NULL,
	[Col177] [nvarchar](max) NULL,
	[Col178] [nvarchar](max) NULL,
	[Col179] [nvarchar](max) NULL,
	[Col180] [nvarchar](max) NULL,
	[Col181] [nvarchar](max) NULL,
	[Col182] [nvarchar](max) NULL,
	[Col183] [nvarchar](max) NULL,
	[Col184] [nvarchar](max) NULL,
	[Col185] [nvarchar](max) NULL,
	[Col186] [nvarchar](max) NULL,
	[Col187] [nvarchar](max) NULL,
	[Col188] [nvarchar](max) NULL,
	[Col189] [nvarchar](max) NULL,
	[Col190] [nvarchar](max) NULL,
	[Col191] [nvarchar](max) NULL,
	[Col192] [nvarchar](max) NULL,
	[Col193] [nvarchar](max) NULL,
	[Col194] [nvarchar](max) NULL,
	[Col195] [nvarchar](max) NULL,
	[Col196] [nvarchar](max) NULL,
	[Col197] [nvarchar](max) NULL,
	[Col198] [nvarchar](max) NULL,
	[Col199] [nvarchar](max) NULL,
	[Col200] [nvarchar](max) NULL,
 CONSTRAINT [PK_Col_DomainsDataExtra] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dom_DomainStatus]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dom_DomainStatus](
	[StatusID] [tinyint] NOT NULL,
	[StatusName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Dom_DomainStatus] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lup_BranchList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_BranchList](
	[BranchID] [tinyint] NOT NULL,
	[BranchTitle] [nvarchar](50) NOT NULL,
	[IsDefault] [bit] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Lup_BranchList] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lup_Comments]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[ArbicComment] [nvarchar](max) NULL,
	[Comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Lup_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lup_MonthYear]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_MonthYear](
	[MonthID] [int] IDENTITY(1,1) NOT NULL,
	[MonthYear] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lup_MonthYear] PRIMARY KEY CLUSTERED 
(
	[MonthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lup_TeamRole]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_TeamRole](
	[RoleID] [smallint] NOT NULL,
	[RoleName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Lup_TeamRole] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PCR_ConnectionResult]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCR_ConnectionResult](
	[ConnectionResultID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ConnectionResultTitle] [nvarchar](350) NULL,
 CONSTRAINT [PK_PCR_ConnectionResult] PRIMARY KEY CLUSTERED 
(
	[ConnectionResultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PCR_ConnectionType]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCR_ConnectionType](
	[ConnectionTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ConnectionTypeTitle] [nvarchar](350) NULL,
 CONSTRAINT [PK_PCR_ConnectionType] PRIMARY KEY CLUSTERED 
(
	[ConnectionTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PCR_PCRHistory]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCR_PCRHistory](
	[PCRID] [bigint] IDENTITY(1,1) NOT NULL,
	[DomainID] [bigint] NOT NULL,
	[MemberID] [int] NOT NULL,
	[AccountID] [bigint] NOT NULL,
	[ConnectionTypeID] [tinyint] NOT NULL,
	[ConnectionResultID] [tinyint] NOT NULL,
	[PTPTypeID] [tinyint] NOT NULL,
	[ConnectionDate] [date] NULL,
	[PTPDate] [date] NULL,
	[PTPAmount] [decimal](12, 2) NULL,
	[IsPromiseKept] [bit] NULL,
	[KeptAmount] [decimal](12, 2) NULL,
	[EngComment] [nvarchar](max) NULL,
	[ArabicComment] [nvarchar](max) NULL,
 CONSTRAINT [PK_PCR_PCRHistory] PRIMARY KEY CLUSTERED 
(
	[PCRID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PCR_PTPType]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PCR_PTPType](
	[PTPTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[PTPTypeTitle] [nvarchar](350) NULL,
 CONSTRAINT [PK_PCR_PTPType] PRIMARY KEY CLUSTERED 
(
	[PTPTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Actions]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Actions](
	[ActionID] [tinyint] NOT NULL,
	[ActionTitle] [nvarchar](100) NOT NULL,
	[IsGlobal] [bit] NOT NULL,
	[OnlyLogAction] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Actions] PRIMARY KEY CLUSTERED 
(
	[ActionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_BranchesPermissions]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_BranchesPermissions](
	[RecordID] [smallint] IDENTITY(1,1) NOT NULL,
	[BranchID] [tinyint] NULL,
	[UserID] [smallint] NULL,
 CONSTRAINT [PK_Pre_BranchesPermissions] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Config]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pre_Config](
	[RecordID] [smallint] NOT NULL,
	[FiledTitle] [nvarchar](50) NOT NULL,
	[FieldText] [nvarchar](max) NULL,
	[FieldImage] [varbinary](max) NULL,
	[FieldDate] [date] NULL,
 CONSTRAINT [PK_Pre_Config] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pre_FormActions]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_FormActions](
	[RecordSerial] [smallint] IDENTITY(1,1) NOT NULL,
	[FormID] [smallint] NOT NULL,
	[ActionID] [tinyint] NOT NULL,
	[IsNotificationAction] [bit] NOT NULL,
 CONSTRAINT [PK_Pre_FormActions] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_FormList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pre_FormList](
	[FormID] [smallint] NOT NULL,
	[CodeName] [varchar](50) NOT NULL,
	[FormTitle] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[GetInNotifications] [bit] NOT NULL,
	[TrackViewName] [varchar](150) NULL,
	[KeyFieldName] [nvarchar](100) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_FormList] PRIMARY KEY CLUSTERED 
(
	[FormID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pre_GroupPermissions]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_GroupPermissions](
	[RecordSerial] [smallint] IDENTITY(1,1) NOT NULL,
	[GroupID] [tinyint] NOT NULL,
	[ActionID] [tinyint] NOT NULL,
	[FormID] [smallint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_GroupPermissions] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Groups]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Groups](
	[GroupID] [tinyint] IDENTITY(1,1) NOT NULL,
	[GroupTitle] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_UserGroups] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_GroupsMembers]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_GroupsMembers](
	[RecordSerial] [smallint] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[GroupID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_UsersGroups] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_ModuleForms]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_ModuleForms](
	[RecordSerial] [smallint] NOT NULL,
	[ModuleID] [tinyint] NOT NULL,
	[FormID] [smallint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Pre_ModuleForms] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Section]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Section](
	[SectionID] [tinyint] IDENTITY(1,1) NOT NULL,
	[SectionName] [nvarchar](250) NULL,
	[SectionURL] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pre_Section] PRIMARY KEY CLUSTERED 
(
	[SectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_SectionPermissions]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_SectionPermissions](
	[SectionPermssionID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[SectionID] [tinyint] NOT NULL,
 CONSTRAINT [PK_Pre_SectionPermissions] PRIMARY KEY CLUSTERED 
(
	[SectionPermssionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_SystemModules]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_SystemModules](
	[ModuleID] [tinyint] NOT NULL,
	[ModuleTitle] [nvarchar](50) NOT NULL,
	[DisplayOrder] [tinyint] NOT NULL,
	[IsHidden] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Pre_SystemModules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Trans_Log]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Trans_Log](
	[TransLogID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[FormID] [smallint] NOT NULL,
	[ActionID] [tinyint] NOT NULL,
	[RecordID] [int] NULL,
	[DateTime] [datetime] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Pre_Trans_Log] PRIMARY KEY CLUSTERED 
(
	[TransLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Users]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pre_Users](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varbinary](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ProfileImage] [varbinary](max) NULL,
	[EmployeeID] [smallint] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pre_UserStatus]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_UserStatus](
	[RecordSerial] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NOT NULL,
	[IsOnline] [bit] NOT NULL,
 CONSTRAINT [PK_Pre_UserStatus] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sch_Columns]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sch_Columns](
	[CoID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ColumnName] [nvarchar](350) NULL,
	[ColumnType] [nvarchar](50) NULL,
	[IsDeleteable] [bit] NULL,
	[IsFixed] [bit] NULL,
 CONSTRAINT [PK_Sch_Columns] PRIMARY KEY CLUSTERED 
(
	[CoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sch_SchemaColumns]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sch_SchemaColumns](
	[RecoredSerial] [int] IDENTITY(1,1) NOT NULL,
	[CoID] [tinyint] NOT NULL,
	[SchemaID] [tinyint] NOT NULL,
	[ColumnIndex] [int] NULL,
 CONSTRAINT [PK_Sch_SchemaColumns_1] PRIMARY KEY CLUSTERED 
(
	[RecoredSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sch_Schemas]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sch_Schemas](
	[SchemaID] [tinyint] IDENTITY(1,1) NOT NULL,
	[SchemaName] [nvarchar](250) NULL,
	[BranchID] [tinyint] NULL,
 CONSTRAINT [PK_Sch_Schemas] PRIMARY KEY CLUSTERED 
(
	[SchemaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[Pre_UsersSections]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Pre_UsersSections]
as
select T1.[UserID],
       stuff((select ','+convert(varchar(max), T2.[SectionID])
              from [dbo].[Pre_SectionPermissions] as T2
              where T1.[UserID] = T2.[UserID]
              for xml path(''), type).value('.', 'varchar(max)'), 1, 1, '') as Label
from [dbo].[Pre_SectionPermissions] as T1
group by T1.[UserID]

GO
/****** Object:  View [dbo].[Pre_UsersView]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_UsersView]
AS
SELECT        dbo.Pre_Users.UserID, dbo.Pre_Users.DisplayName,
                             (SELECT        TOP (1) BranchID
                                FROM            dbo.Pre_BranchesPermissions
                                WHERE        (UserID = dbo.Pre_Users.UserID)) AS BranchID,
                             (SELECT        TOP (1) GroupID
                                FROM            dbo.Pre_GroupsMembers
                                WHERE        (UserID = dbo.Pre_Users.UserID) AND (IsDeleted = 0)) AS GroupID, dbo.Pre_UsersSections.Label AS SectionIDs, dbo.Pre_Users.UserName, dbo.Pre_Users.ProfileImage
FROM            dbo.Pre_Users LEFT OUTER JOIN
                         dbo.Pre_UsersSections ON dbo.Pre_Users.UserID = dbo.Pre_UsersSections.UserID
WHERE        (dbo.Pre_Users.IsDeleted = 0)


GO
/****** Object:  View [dbo].[Dom_DomainDetailsList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainDetailsList]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainsDataExtra.RecordSerial, 
                         dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.MonthID, dbo.Dom_DomainBasic.BranchID, dbo.Dom_DomainBasic.DomainTitle, 
                         dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID
WHERE        (dbo.Dom_DomainsDataExtra.VersionNumber =
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainsDataExtra AS Dom_DomainsDataExtra_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC))


GO
/****** Object:  View [dbo].[Dom_DomainList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainList]
AS
SELECT        dbo.Dom_DomainBasic.DomainID,
                             (SELECT        TOP (1) SchemaID
                                FROM            dbo.Dom_DomainDetailsList AS Dom_DomainDetailsList_2
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)) AS SchemaID,
                             (SELECT        TOP (1) SchemaName
                                FROM            dbo.Dom_DomainDetailsList
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)) AS SchemaName,
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainDetailsList AS Dom_DomainDetailsList_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC) AS VersionNumber, dbo.Dom_DomainBasic.DomainTitle, dbo.Config_AgencyList.AgencyID, dbo.Config_AgencyList.AgencyTitle, dbo.Lup_BranchList.BranchID, 
                         dbo.Lup_BranchList.BranchTitle, dbo.Lup_MonthYear.MonthID, dbo.Lup_MonthYear.MonthYear, dbo.Dom_DomainBasic.DomainType, dbo.Dom_DomainStatus.StatusName, 
                         dbo.Dom_DomainStatus.StatusID
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Config_AgencyList ON dbo.Dom_DomainBasic.AgencyID = dbo.Config_AgencyList.AgencyID INNER JOIN
                         dbo.Lup_BranchList ON dbo.Dom_DomainBasic.BranchID = dbo.Lup_BranchList.BranchID INNER JOIN
                         dbo.Lup_MonthYear ON dbo.Dom_DomainBasic.MonthID = dbo.Lup_MonthYear.MonthID INNER JOIN
                         dbo.Dom_DomainStatus ON dbo.Dom_DomainBasic.StatusID = dbo.Dom_DomainStatus.StatusID
WHERE        (dbo.Lup_BranchList.IsDeleted = 0) AND (dbo.Config_AgencyList.IsActive = 1)


GO
/****** Object:  View [dbo].[PCR_PCRHistoryList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PCR_PCRHistoryList]
AS
SELECT        dbo.PCR_ConnectionResult.ConnectionResultTitle, dbo.PCR_ConnectionType.ConnectionTypeTitle, dbo.Config_MembersList.MemberName, dbo.PCR_PTPType.PTPTypeTitle, dbo.PCR_PCRHistory.PCRID, 
                         dbo.PCR_PCRHistory.MemberID, dbo.PCR_PCRHistory.AccountID, dbo.PCR_PCRHistory.ConnectionTypeID, dbo.PCR_PCRHistory.ConnectionResultID, dbo.PCR_PCRHistory.PTPTypeID, 
                         dbo.PCR_PCRHistory.ConnectionDate, dbo.PCR_PCRHistory.PTPDate, dbo.PCR_PCRHistory.PTPAmount, dbo.PCR_PCRHistory.IsPromiseKept, dbo.PCR_PCRHistory.KeptAmount, 
                         dbo.PCR_PCRHistory.EngComment, dbo.PCR_PCRHistory.ArabicComment, dbo.PCR_PCRHistory.DomainID,
                             (SELECT        DomainTitle
                                FROM            dbo.Dom_DomainBasic
                                WHERE        (DomainID = dbo.PCR_PCRHistory.DomainID)) AS DomainTitle
FROM            dbo.PCR_ConnectionResult INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.PCR_ConnectionResult.ConnectionResultID = dbo.PCR_PCRHistory.ConnectionResultID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID INNER JOIN
                         dbo.PCR_PTPType ON dbo.PCR_PCRHistory.PTPTypeID = dbo.PCR_PTPType.PTPTypeID INNER JOIN
                         dbo.Config_MembersList ON dbo.PCR_PCRHistory.MemberID = dbo.Config_MembersList.MemberID


GO
/****** Object:  View [dbo].[DCR_MemberDCRSummary]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DCR_MemberDCRSummary]
AS
SELECT        dbo.PCR_PCRHistoryList.AccountID, dbo.PCR_PCRHistoryList.MemberID, dbo.PCR_PCRHistoryList.DomainID, dbo.Config_MembersList.MemberName AS ActionMaker,
                             (SELECT        COUNT(PCRID) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_1
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID)) AS CountOfConnections,
                             (SELECT        COUNT(DISTINCT AccountID) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID)) AS CountOfAcounts,
                             (SELECT        COUNT(ConnectionResultID) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID) AND (ConnectionResultID = 5)) AS CountOfPTP,
                             (SELECT        SUM(PTPAmount) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID)) AS SumOFPTPAmount,
                             (SELECT        COUNT(IsPromiseKept) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID) AND (IsPromiseKept = 1)) AS CountOfPromiseKept,
                             (SELECT        COUNT(IsPromiseKept) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID) AND (IsPromiseKept = 0)) AS CountOfPromiseBrok,
                             (SELECT        SUM(KeptAmount) AS Expr1
                                FROM            dbo.PCR_PCRHistoryList AS PCR_PCRHistoryList_2
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID) AND (MemberID = dbo.PCR_PCRHistoryList.MemberID)) AS SumOFKeptAmount,
                             (SELECT        DomainType
                                FROM            dbo.Dom_DomainBasic
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID)) AS DomainType,
                             (SELECT        StatusID
                                FROM            dbo.Dom_DomainBasic AS Dom_DomainBasic_1
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID)) AS StatusID,
                             (SELECT        AgencyID
                                FROM            dbo.Dom_DomainList
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID)) AS AgencyID,
                             (SELECT        BranchID
                                FROM            dbo.Dom_DomainList AS Dom_DomainList_1
                                WHERE        (DomainID = dbo.PCR_PCRHistoryList.DomainID)) AS BranchID
FROM            dbo.PCR_PCRHistoryList INNER JOIN
                         dbo.Config_MembersList ON dbo.PCR_PCRHistoryList.MemberID = dbo.Config_MembersList.MemberID
GROUP BY dbo.PCR_PCRHistoryList.MemberID, dbo.PCR_PCRHistoryList.DomainID, dbo.Config_MembersList.MemberName, dbo.PCR_PCRHistoryList.AccountID


GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryFn]()
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID



GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByDomainFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryByDomainFn](@DomainID nvarchar(max))
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
where dbo.DCR_MemberDCRSummary.DomainID=@DomainID
-- select * from  [dbo].[DCR_MemberDCRSummaryByDomainFn](47)

GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByOpenDomainFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryByOpenDomainFn](@DomainType nvarchar(max))
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker]
			,  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
where DomainType = @DomainType and StatusID <> 50

-- select * from  [dbo].[DCR_MemberDCRSummaryByOpenDomainFn] ('Active Domain')
--  select * from  [dbo].[DCR_MemberDCRSummaryByOpenDomainFn] ('W/O Domain')

GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByAllDomainFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Function [dbo].[DCR_MemberDCRSummaryByAllDomainFn](@DomainType nvarchar(max))
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
where DomainType = @DomainType

GO
/****** Object:  View [dbo].[DCR_DCRHistoryWithAccountsToImport]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DCR_DCRHistoryWithAccountsToImport]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainBasic.DomainTitle,
                             (SELECT        AgencyTitle
                                FROM            dbo.Config_AgencyList
                                WHERE        (AgencyID = dbo.Dom_DomainBasic.AgencyID)) AS AgencyTitle,
                             (SELECT        MonthYear
                                FROM            dbo.Lup_MonthYear
                                WHERE        (MonthID = dbo.Dom_DomainBasic.MonthID)) AS MonthYear,
                             (SELECT        BranchTitle
                                FROM            dbo.Lup_BranchList
                                WHERE        (BranchID = dbo.Dom_DomainBasic.BranchID)) AS BranchTitle, dbo.PCR_PCRHistoryList.MemberName, dbo.PCR_PCRHistoryList.ConnectionTypeTitle, 
                         dbo.PCR_PCRHistoryList.ConnectionResultTitle, dbo.PCR_PCRHistoryList.PTPTypeTitle, dbo.Sch_Schemas.SchemaName, dbo.Dom_DomainsDataExtra.VersionNumber, 
                         dbo.PCR_PCRHistoryList.ConnectionDate, dbo.PCR_PCRHistoryList.PTPDate, dbo.PCR_PCRHistoryList.PTPAmount, dbo.PCR_PCRHistoryList.IsPromiseKept, dbo.PCR_PCRHistoryList.KeptAmount, 
                         dbo.PCR_PCRHistoryList.EngComment, dbo.PCR_PCRHistoryList.ArabicComment, dbo.Dom_DomainBasic.DomainID
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID INNER JOIN
                         dbo.PCR_PCRHistoryList ON dbo.Dom_DomainsDataExtra.RecordSerial = dbo.PCR_PCRHistoryList.AccountID
WHERE        (dbo.Dom_DomainsDataExtra.VersionNumber =
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainsDataExtra AS Dom_DomainsDataExtra_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC))


GO
/****** Object:  View [dbo].[DCR_SummaryForCharts]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DCR_SummaryForCharts]
AS
SELECT        dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.BranchID, dbo.PCR_ConnectionType.ConnectionTypeTitle, dbo.PCR_PCRHistory.ConnectionTypeID
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.Dom_DomainBasic.DomainID = dbo.PCR_PCRHistory.DomainID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
WHERE        (dbo.Dom_DomainBasic.StatusID <> 50)


GO
/****** Object:  View [dbo].[Chrt_Contacts]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Chrt_Contacts]
AS
SELECT        AgencyID, BranchID, ConnectionTypeTitle, COUNT(ConnectionTypeID) AS ContactCount
FROM            dbo.DCR_SummaryForCharts
GROUP BY AgencyID, BranchID, ConnectionTypeTitle


GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByAgencyFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryByAgencyFn](@AgencyID nvarchar(max))
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
where AgencyID = @AgencyID  and [StatusID]<> 50

GO
/****** Object:  View [dbo].[Chrt_PD_PTP_KeptAmmount]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Chrt_PD_PTP_KeptAmmount]
AS
SELECT        SUM(SumOFPTPAmount) AS SumOFPTPAmount, SUM(SumOFKeptAmount) AS SumOFKeptAmount, AgencyID, BranchID,
                             (SELECT        SUM(CONVERT(decimal(12, 2), Col4)) AS Expr1
                                FROM            dbo.Dom_DomainDetailsList
                                WHERE        (BranchID = dbo.DCR_MemberDCRSummary.BranchID) AND (AgencyID = dbo.DCR_MemberDCRSummary.AgencyID)) AS SumOFPastDue
FROM            dbo.DCR_MemberDCRSummary
GROUP BY AgencyID, BranchID


GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByBranchFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryByBranchFn](@BranchID nvarchar(max))
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
where BranchID = @BranchID and [StatusID]<> 50

GO
/****** Object:  View [dbo].[Dom_AssignDomainToMembersList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_AssignDomainToMembersList]
AS
SELECT        dbo.Config_MembersList.MemberName + N' (' + dbo.Lup_TeamRole.RoleName + N')' AS AssignedTo, dbo.Lup_TeamRole.RoleName, dbo.Config_TeamList.TeamName, dbo.Config_MembersList.MemberName, 
                         dbo.Dom_AssignDomainToMembers.AssignID, dbo.Dom_AssignDomainToMembers.AccountID, dbo.Dom_AssignDomainToMembers.MemberID, dbo.Dom_AssignDomainToMembers.RoleID, 
                         dbo.Dom_AssignDomainToMembers.TeamID, dbo.Dom_AssignDomainToMembers.IsBank
FROM            dbo.Dom_AssignDomainToMembers INNER JOIN
                         dbo.Config_MembersList ON dbo.Dom_AssignDomainToMembers.MemberID = dbo.Config_MembersList.MemberID INNER JOIN
                         dbo.Lup_TeamRole ON dbo.Dom_AssignDomainToMembers.RoleID = dbo.Lup_TeamRole.RoleID INNER JOIN
                         dbo.Config_TeamList ON dbo.Dom_AssignDomainToMembers.TeamID = dbo.Config_TeamList.TeamID


GO
/****** Object:  View [dbo].[Dom_DomainDetailsToBankAssignList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainDetailsToBankAssignList]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainsDataExtra.RecordSerial, 
                         dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.MonthID, dbo.Dom_DomainBasic.BranchID, dbo.Dom_DomainBasic.DomainTitle, 
                         dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName,
                             (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 1 and [RoleID]=1 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Supervisor]
								,
								 (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 1 and [RoleID]=2 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Leader]
								,
								 (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 1 and [RoleID]=3 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Collector]
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID
WHERE        (dbo.Dom_DomainsDataExtra.VersionNumber =
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainsDataExtra AS Dom_DomainsDataExtra_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC))


GO
/****** Object:  View [dbo].[Dom_DomainDetailsToInternalAssignList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainDetailsToInternalAssignList]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainsDataExtra.RecordSerial, 
                         dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.MonthID, dbo.Dom_DomainBasic.BranchID, dbo.Dom_DomainBasic.DomainTitle, 
                         dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName,
                             (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 0 and [RoleID]=1 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Supervisor]
								,
								 (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 0 and [RoleID]=2 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Leader]
								,
								 (SELECT        stuff
                                                             ((SELECT        ',' + T2.AssignedTo
                                                                 FROM            Dom_AssignDomainToMembersList AS T2
                                                                 WHERE        T1.[AccountID] = T2.[AccountID] AND IsBank = 0 and [RoleID]=3 FOR xml path(''), type ).value('.', 'varchar(max)'), 1, 1, '') AS Label
                                FROM            Dom_AssignDomainToMembersList AS T1
                                WHERE        [AccountID] = Dom_DomainsDataExtra.RecordSerial
                                GROUP BY T1.[AccountID]) AS [Collector]
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID
WHERE        (dbo.Dom_DomainsDataExtra.VersionNumber =
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainsDataExtra AS Dom_DomainsDataExtra_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC))


GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypesFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Function [dbo].[DCR_MemberDCRSummaryByOpenDomainBothTypesFn]()
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker]
			,  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID
 where StatusID <> 50



GO
/****** Object:  UserDefinedFunction [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeFn]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DCR_MemberDCRSummaryByAllDomainBothTypeFn]()
returns Table
as 
return
SELECT      dbo.DCR_MemberDCRSummary.ActionMaker as [Action Maker],  dbo.DCR_MemberDCRSummary.CountOfAcounts  as [Count Of Accounts],
		 dbo.DCR_MemberDCRSummary.CountOfConnections  as [Count Of Connections], 
         dbo.DCR_MemberDCRSummary.CountOfPTP as [Count Of PTP],
		  dbo.DCR_MemberDCRSummary.SumOFPTPAmount as [Sum Of PTP Amount], 
		  dbo.DCR_MemberDCRSummary.CountOfPromiseKept as [Count Of Promise Kept],
		   dbo.DCR_MemberDCRSummary.CountOfPromiseBrok as [Count Of Promise Brok], 
         dbo.DCR_MemberDCRSummary.SumOFKeptAmount as [Sum Of Kept Amount], 
		 dbo.PCR_ConnectionType.ConnectionTypeTitle
FROM            dbo.DCR_MemberDCRSummary INNER JOIN
                         dbo.PCR_PCRHistory ON dbo.DCR_MemberDCRSummary.MemberID = dbo.PCR_PCRHistory.MemberID INNER JOIN
                         dbo.PCR_ConnectionType ON dbo.PCR_PCRHistory.ConnectionTypeID = dbo.PCR_ConnectionType.ConnectionTypeID


GO
/****** Object:  View [dbo].[Config_AgencyBranchList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Config_AgencyBranchList]
AS
SELECT        dbo.Config_AgencyList.AgencyID, dbo.Config_AgencyList.AgencyTitle, dbo.Config_AgencyList.IsActive, dbo.Config_AgencyBranches.BranchID
FROM            dbo.Config_AgencyList INNER JOIN
                         dbo.Config_AgencyBranches ON dbo.Config_AgencyList.AgencyID = dbo.Config_AgencyBranches.AgencyID


GO
/****** Object:  View [dbo].[Config_TeamMembersList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Config_TeamMembersList]
AS
SELECT        dbo.Config_TeamList.TeamID, dbo.Config_TeamList.BranchID, dbo.Config_TeamList.AgencyID, dbo.Config_TeamList.TeamName, dbo.Config_TeamList.IsActive, dbo.Config_MembersList.MemberID, 
                         dbo.Config_MembersList.MemberName
FROM            dbo.Config_TeamList INNER JOIN
                         dbo.Config_TeamMembers ON dbo.Config_TeamList.TeamID = dbo.Config_TeamMembers.TeamID INNER JOIN
                         dbo.Config_MembersList ON dbo.Config_TeamMembers.MemberID = dbo.Config_MembersList.MemberID


GO
/****** Object:  View [dbo].[Config_TeamMembersRoleList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Config_TeamMembersRoleList]
AS
SELECT        TOP (100) PERCENT dbo.Config_MembersList.MemberName + N' (' + dbo.Lup_TeamRole.RoleName + N')' AS MemberRole, dbo.Config_TeamList.TeamID, dbo.Config_TeamList.BranchID, 
                         dbo.Config_TeamList.AgencyID, dbo.Config_TeamList.TeamName, dbo.Config_TeamList.IsActive, dbo.Config_MembersList.MemberID, dbo.Config_MembersList.MemberName, dbo.Lup_TeamRole.RoleName, 
                         dbo.Lup_TeamRole.RoleID
FROM            dbo.Config_TeamList INNER JOIN
                         dbo.Config_TeamMembers ON dbo.Config_TeamList.TeamID = dbo.Config_TeamMembers.TeamID INNER JOIN
                         dbo.Config_MembersList ON dbo.Config_TeamMembers.MemberID = dbo.Config_MembersList.MemberID INNER JOIN
                         dbo.Lup_TeamRole ON dbo.Config_TeamMembers.RoleID = dbo.Lup_TeamRole.RoleID


GO
/****** Object:  View [dbo].[Dom_DomainDetailsAllVersionsList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainDetailsAllVersionsList]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainsDataExtra.RecordSerial, 
                         dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.MonthID, dbo.Dom_DomainBasic.BranchID, dbo.Dom_DomainBasic.DomainTitle, 
                         dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID


GO
/****** Object:  View [dbo].[Dom_DomainDetailsListPrev]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_DomainDetailsListPrev]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainsDataExtra.RecordSerial, 
                         dbo.Dom_DomainBasic.DomainID, dbo.Dom_DomainBasic.AgencyID, dbo.Dom_DomainBasic.MonthID, dbo.Dom_DomainBasic.BranchID, dbo.Dom_DomainBasic.DomainTitle, 
                         dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID
WHERE        (dbo.Dom_DomainsDataExtra.VersionNumber =
                             (SELECT        TOP (1) VersionNumber
                                FROM            dbo.Dom_DomainsDataExtra AS Dom_DomainsDataExtra_1
                                WHERE        (DomainID = dbo.Dom_DomainBasic.DomainID)
                                ORDER BY VersionNumber DESC) - 1)


GO
/****** Object:  View [dbo].[Dom_MasterDomain]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Dom_MasterDomain]
AS
SELECT        dbo.Dom_DomainsDataExtra.Col1, dbo.Dom_DomainsDataExtra.Col2, dbo.Dom_DomainsDataExtra.Col3, dbo.Dom_DomainsDataExtra.Col4, dbo.Dom_DomainsDataExtra.Col5, dbo.Dom_DomainsDataExtra.Col6, 
                         dbo.Dom_DomainsDataExtra.Col7, dbo.Dom_DomainsDataExtra.Col8, dbo.Dom_DomainsDataExtra.Col9, dbo.Dom_DomainsDataExtra.Col10, dbo.Dom_DomainsDataExtra.Col11, 
                         dbo.Dom_DomainsDataExtra.Col12, dbo.Dom_DomainsDataExtra.Col13, dbo.Dom_DomainsDataExtra.Col14, dbo.Dom_DomainsDataExtra.Col15, dbo.Dom_DomainsDataExtra.Col16, 
                         dbo.Dom_DomainsDataExtra.Col17, dbo.Dom_DomainsDataExtra.Col18, dbo.Dom_DomainsDataExtra.Col19, dbo.Dom_DomainsDataExtra.Col20, dbo.Dom_DomainsDataExtra.Col21, 
                         dbo.Dom_DomainsDataExtra.Col22, dbo.Dom_DomainsDataExtra.Col23, dbo.Dom_DomainsDataExtra.Col24, dbo.Dom_DomainsDataExtra.Col25, dbo.Dom_DomainsDataExtra.Col26, 
                         dbo.Dom_DomainsDataExtra.Col27, dbo.Dom_DomainsDataExtra.Col28, dbo.Dom_DomainsDataExtra.Col29, dbo.Dom_DomainsDataExtra.Col30, dbo.Dom_DomainsDataExtra.Col31, 
                         dbo.Dom_DomainsDataExtra.Col32, dbo.Dom_DomainsDataExtra.Col33, dbo.Dom_DomainsDataExtra.Col34, dbo.Dom_DomainsDataExtra.Col35, dbo.Dom_DomainsDataExtra.Col36, 
                         dbo.Dom_DomainsDataExtra.Col37, dbo.Dom_DomainsDataExtra.Col38, dbo.Dom_DomainsDataExtra.Col39, dbo.Dom_DomainsDataExtra.Col40, dbo.Dom_DomainsDataExtra.Col41, 
                         dbo.Dom_DomainsDataExtra.Col42, dbo.Dom_DomainsDataExtra.Col43, dbo.Dom_DomainsDataExtra.Col44, dbo.Dom_DomainsDataExtra.Col45, dbo.Dom_DomainsDataExtra.Col46, 
                         dbo.Dom_DomainsDataExtra.Col47, dbo.Dom_DomainsDataExtra.Col48, dbo.Dom_DomainsDataExtra.Col49, dbo.Dom_DomainsDataExtra.Col50, dbo.Dom_DomainsDataExtra.Col51, 
                         dbo.Dom_DomainsDataExtra.Col52, dbo.Dom_DomainsDataExtra.Col53, dbo.Dom_DomainsDataExtra.Col54, dbo.Dom_DomainsDataExtra.Col55, dbo.Dom_DomainsDataExtra.Col56, 
                         dbo.Dom_DomainsDataExtra.Col57, dbo.Dom_DomainsDataExtra.Col58, dbo.Dom_DomainsDataExtra.Col59, dbo.Dom_DomainsDataExtra.Col60, dbo.Dom_DomainsDataExtra.Col61, 
                         dbo.Dom_DomainsDataExtra.Col62, dbo.Dom_DomainsDataExtra.Col63, dbo.Dom_DomainsDataExtra.Col64, dbo.Dom_DomainsDataExtra.Col65, dbo.Dom_DomainsDataExtra.Col66, 
                         dbo.Dom_DomainsDataExtra.Col67, dbo.Dom_DomainsDataExtra.Col68, dbo.Dom_DomainsDataExtra.Col69, dbo.Dom_DomainsDataExtra.Col70, dbo.Dom_DomainsDataExtra.Col71, 
                         dbo.Dom_DomainsDataExtra.Col72, dbo.Dom_DomainsDataExtra.Col73, dbo.Dom_DomainsDataExtra.Col74, dbo.Dom_DomainsDataExtra.Col75, dbo.Dom_DomainsDataExtra.Col76, 
                         dbo.Dom_DomainsDataExtra.Col77, dbo.Dom_DomainsDataExtra.Col78, dbo.Dom_DomainsDataExtra.Col79, dbo.Dom_DomainsDataExtra.Col80, dbo.Dom_DomainsDataExtra.Col81, 
                         dbo.Dom_DomainsDataExtra.Col82, dbo.Dom_DomainsDataExtra.Col83, dbo.Dom_DomainsDataExtra.Col84, dbo.Dom_DomainsDataExtra.Col85, dbo.Dom_DomainsDataExtra.Col86, 
                         dbo.Dom_DomainsDataExtra.Col87, dbo.Dom_DomainsDataExtra.Col88, dbo.Dom_DomainsDataExtra.Col89, dbo.Dom_DomainsDataExtra.Col90, dbo.Dom_DomainsDataExtra.Col91, 
                         dbo.Dom_DomainsDataExtra.Col92, dbo.Dom_DomainsDataExtra.Col93, dbo.Dom_DomainsDataExtra.Col94, dbo.Dom_DomainsDataExtra.Col95, dbo.Dom_DomainsDataExtra.Col96, 
                         dbo.Dom_DomainsDataExtra.Col97, dbo.Dom_DomainsDataExtra.Col98, dbo.Dom_DomainsDataExtra.Col99, dbo.Dom_DomainsDataExtra.Col100, dbo.Dom_DomainsDataExtra.Col101, 
                         dbo.Dom_DomainsDataExtra.Col102, dbo.Dom_DomainsDataExtra.Col103, dbo.Dom_DomainsDataExtra.Col104, dbo.Dom_DomainsDataExtra.Col105, dbo.Dom_DomainsDataExtra.Col106, 
                         dbo.Dom_DomainsDataExtra.Col107, dbo.Dom_DomainsDataExtra.Col108, dbo.Dom_DomainsDataExtra.Col109, dbo.Dom_DomainsDataExtra.Col110, dbo.Dom_DomainsDataExtra.Col111, 
                         dbo.Dom_DomainsDataExtra.Col112, dbo.Dom_DomainsDataExtra.Col113, dbo.Dom_DomainsDataExtra.Col114, dbo.Dom_DomainsDataExtra.Col115, dbo.Dom_DomainsDataExtra.Col116, 
                         dbo.Dom_DomainsDataExtra.Col117, dbo.Dom_DomainsDataExtra.Col118, dbo.Dom_DomainsDataExtra.Col119, dbo.Dom_DomainsDataExtra.Col120, dbo.Dom_DomainsDataExtra.Col121, 
                         dbo.Dom_DomainsDataExtra.Col122, dbo.Dom_DomainsDataExtra.Col123, dbo.Dom_DomainsDataExtra.Col124, dbo.Dom_DomainsDataExtra.Col125, dbo.Dom_DomainsDataExtra.Col126, 
                         dbo.Dom_DomainsDataExtra.Col127, dbo.Dom_DomainsDataExtra.Col128, dbo.Dom_DomainsDataExtra.Col129, dbo.Dom_DomainsDataExtra.Col130, dbo.Dom_DomainsDataExtra.Col131, 
                         dbo.Dom_DomainsDataExtra.Col132, dbo.Dom_DomainsDataExtra.Col133, dbo.Dom_DomainsDataExtra.Col134, dbo.Dom_DomainsDataExtra.Col135, dbo.Dom_DomainsDataExtra.Col136, 
                         dbo.Dom_DomainsDataExtra.Col137, dbo.Dom_DomainsDataExtra.Col138, dbo.Dom_DomainsDataExtra.Col139, dbo.Dom_DomainsDataExtra.Col140, dbo.Dom_DomainsDataExtra.Col141, 
                         dbo.Dom_DomainsDataExtra.Col142, dbo.Dom_DomainsDataExtra.Col143, dbo.Dom_DomainsDataExtra.Col144, dbo.Dom_DomainsDataExtra.Col145, dbo.Dom_DomainsDataExtra.Col146, 
                         dbo.Dom_DomainsDataExtra.Col147, dbo.Dom_DomainsDataExtra.Col148, dbo.Dom_DomainsDataExtra.Col149, dbo.Dom_DomainsDataExtra.Col150, dbo.Dom_DomainsDataExtra.Col151, 
                         dbo.Dom_DomainsDataExtra.Col152, dbo.Dom_DomainsDataExtra.Col153, dbo.Dom_DomainsDataExtra.Col154, dbo.Dom_DomainsDataExtra.Col155, dbo.Dom_DomainsDataExtra.Col156, 
                         dbo.Dom_DomainsDataExtra.Col157, dbo.Dom_DomainsDataExtra.Col158, dbo.Dom_DomainsDataExtra.Col159, dbo.Dom_DomainsDataExtra.Col160, dbo.Dom_DomainsDataExtra.Col161, 
                         dbo.Dom_DomainsDataExtra.Col162, dbo.Dom_DomainsDataExtra.Col163, dbo.Dom_DomainsDataExtra.Col164, dbo.Dom_DomainsDataExtra.Col165, dbo.Dom_DomainsDataExtra.Col166, 
                         dbo.Dom_DomainsDataExtra.Col167, dbo.Dom_DomainsDataExtra.Col168, dbo.Dom_DomainsDataExtra.Col169, dbo.Dom_DomainsDataExtra.Col170, dbo.Dom_DomainsDataExtra.Col171, 
                         dbo.Dom_DomainsDataExtra.Col172, dbo.Dom_DomainsDataExtra.Col173, dbo.Dom_DomainsDataExtra.Col174, dbo.Dom_DomainsDataExtra.Col175, dbo.Dom_DomainsDataExtra.Col176, 
                         dbo.Dom_DomainsDataExtra.Col177, dbo.Dom_DomainsDataExtra.Col178, dbo.Dom_DomainsDataExtra.Col179, dbo.Dom_DomainsDataExtra.Col180, dbo.Dom_DomainsDataExtra.Col181, 
                         dbo.Dom_DomainsDataExtra.Col182, dbo.Dom_DomainsDataExtra.Col183, dbo.Dom_DomainsDataExtra.Col184, dbo.Dom_DomainsDataExtra.Col185, dbo.Dom_DomainsDataExtra.Col186, 
                         dbo.Dom_DomainsDataExtra.Col187, dbo.Dom_DomainsDataExtra.Col188, dbo.Dom_DomainsDataExtra.Col189, dbo.Dom_DomainsDataExtra.Col190, dbo.Dom_DomainsDataExtra.Col191, 
                         dbo.Dom_DomainsDataExtra.Col192, dbo.Dom_DomainsDataExtra.Col193, dbo.Dom_DomainsDataExtra.Col194, dbo.Dom_DomainsDataExtra.Col195, dbo.Dom_DomainsDataExtra.Col196, 
                         dbo.Dom_DomainsDataExtra.Col197, dbo.Dom_DomainsDataExtra.Col198, dbo.Dom_DomainsDataExtra.Col199, dbo.Dom_DomainsDataExtra.Col200, dbo.Dom_DomainBasic.DomainTitle,
                             (SELECT        AgencyTitle
                                FROM            dbo.Config_AgencyList
                                WHERE        (AgencyID = dbo.Dom_DomainBasic.AgencyID)) AS AgencyTitle,
                             (SELECT        MonthYear
                                FROM            dbo.Lup_MonthYear
                                WHERE        (MonthID = dbo.Dom_DomainBasic.MonthID)) AS MonthYear,
                             (SELECT        BranchTitle
                                FROM            dbo.Lup_BranchList
                                WHERE        (BranchID = dbo.Dom_DomainBasic.BranchID)) AS BranchTitle, dbo.Dom_DomainsDataExtra.VersionNumber, dbo.Dom_DomainBasic.DomainID
FROM            dbo.Dom_DomainBasic INNER JOIN
                         dbo.Dom_DomainsDataExtra ON dbo.Dom_DomainBasic.DomainID = dbo.Dom_DomainsDataExtra.DomainID INNER JOIN
                         dbo.Sch_Schemas ON dbo.Dom_DomainsDataExtra.SchemaID = dbo.Sch_Schemas.SchemaID


GO
/****** Object:  View [dbo].[Pre_BrunchesList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_BrunchesList]
AS
SELECT        dbo.Lup_BranchList.BranchID, dbo.Lup_BranchList.BranchTitle, dbo.Pre_BranchesPermissions.UserID
FROM            dbo.Lup_BranchList INNER JOIN
                         dbo.Pre_BranchesPermissions ON dbo.Lup_BranchList.BranchID = dbo.Pre_BranchesPermissions.BranchID
WHERE        (dbo.Lup_BranchList.IsDeleted = 0)


GO
/****** Object:  View [dbo].[Pre_SectionsList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_SectionsList]
AS
SELECT        dbo.Pre_Section.SectionID, dbo.Pre_Section.SectionName, dbo.Pre_Section.SectionURL, dbo.Pre_SectionPermissions.UserID
FROM            dbo.Pre_Section INNER JOIN
                         dbo.Pre_SectionPermissions ON dbo.Pre_Section.SectionID = dbo.Pre_SectionPermissions.SectionID


GO
/****** Object:  View [dbo].[Sch_SchemaColList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Sch_SchemaColList]
AS
SELECT        dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName, dbo.Sch_Schemas.BranchID, dbo.Sch_SchemaColumns.CoID, dbo.Sch_SchemaColumns.RecoredSerial, 
                         dbo.Sch_SchemaColumns.SchemaID AS Expr1, dbo.Sch_SchemaColumns.ColumnIndex, dbo.Sch_Columns.ColumnName, dbo.Sch_Columns.IsFixed, dbo.Sch_Columns.ColumnType
FROM            dbo.Sch_Schemas INNER JOIN
                         dbo.Sch_SchemaColumns ON dbo.Sch_Schemas.SchemaID = dbo.Sch_SchemaColumns.SchemaID INNER JOIN
                         dbo.Sch_Columns ON dbo.Sch_SchemaColumns.CoID = dbo.Sch_Columns.CoID


GO
/****** Object:  View [dbo].[Sch_SchemaList]    Script Date: 03-Dec-17 4:04:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Sch_SchemaList]
AS
SELECT        dbo.Sch_Schemas.SchemaID, dbo.Sch_Schemas.SchemaName, dbo.Sch_Schemas.BranchID, dbo.Lup_BranchList.BranchTitle
FROM            dbo.Lup_BranchList INNER JOIN
                         dbo.Sch_Schemas ON dbo.Lup_BranchList.BranchID = dbo.Sch_Schemas.BranchID
WHERE        (dbo.Lup_BranchList.IsDeleted = 0)


GO
ALTER TABLE [dbo].[Design_MenuBasic] ADD  CONSTRAINT [DF_Design_MenuBasic_DisplayID]  DEFAULT ((0)) FOR [DisplayID]
GO
ALTER TABLE [dbo].[Design_MenuBasic] ADD  CONSTRAINT [DF_MainMenu_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Design_MenuBasic] ADD  CONSTRAINT [DF_MainMenu_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Design_MenuBasic] ADD  CONSTRAINT [DF_MainMenu_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Design_MenuBasic] ADD  CONSTRAINT [DF_MainMenu_LADate]  DEFAULT (getdate()) FOR [LADate]
GO
ALTER TABLE [dbo].[Design_MenuItems] ADD  CONSTRAINT [DF_Design_MenuItems_DisplayID]  DEFAULT ((0)) FOR [DisplayID]
GO
ALTER TABLE [dbo].[Design_MenuItems] ADD  CONSTRAINT [DF_MenuItems_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Design_MenuItems] ADD  CONSTRAINT [DF_MenuItems_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Design_MenuItems] ADD  CONSTRAINT [DF_MenuItems_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Design_MenuItems] ADD  CONSTRAINT [DF_MenuItems_LADate]  DEFAULT (getdate()) FOR [LADate]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_Actions] ADD  CONSTRAINT [DF_Pre_Actions_IsGlobal]  DEFAULT ((0)) FOR [IsGlobal]
GO
ALTER TABLE [dbo].[Pre_Actions] ADD  CONSTRAINT [DF_Pre_Actions_OnlyLogAction]  DEFAULT ((0)) FOR [OnlyLogAction]
GO
ALTER TABLE [dbo].[Pre_Actions] ADD  CONSTRAINT [DF__Pre_Actio__IsDel__09DE7BCC]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_Actions] ADD  CONSTRAINT [DF__Pre_Actio__IsDel__0AD2A005]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_Actions] ADD  CONSTRAINT [DF__Pre_Actio__RCDat__0BC6C43E]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_FormActions] ADD  CONSTRAINT [DF_Pre_FormActions_IsNotificationAction]  DEFAULT ((0)) FOR [IsNotificationAction]
GO
ALTER TABLE [dbo].[Pre_FormList] ADD  CONSTRAINT [DF_Pre_Lup_FormList_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Pre_FormList] ADD  CONSTRAINT [DF_Pre_FormList_GetInNotifications]  DEFAULT ((0)) FOR [GetInNotifications]
GO
ALTER TABLE [dbo].[Pre_FormList] ADD  CONSTRAINT [DF__Pre_Lup_F__IsDel__5A1A5A11]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_FormList] ADD  CONSTRAINT [DF__Pre_Lup_F__IsDel__5B0E7E4A]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_FormList] ADD  CONSTRAINT [DF__Pre_Lup_F__RCDat__5C02A283]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] ADD  CONSTRAINT [DF_Pre_GroupPermissions_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] ADD  CONSTRAINT [DF__Pre_Group__IsDel__0DAF0CB0]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] ADD  CONSTRAINT [DF__Pre_Group__IsDel__0EA330E9]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] ADD  CONSTRAINT [DF__Pre_Group__RCDat__0F975522]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_Groups] ADD  CONSTRAINT [DF_Pre_Lup_Groups_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Pre_Groups] ADD  CONSTRAINT [DF__Pre_Lup_G__IsDel__145C0A3F]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_Groups] ADD  CONSTRAINT [DF__Pre_Lup_G__IsDel__15502E78]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_Groups] ADD  CONSTRAINT [DF__Pre_Lup_G__RCDat__164452B1]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_GroupsMembers] ADD  CONSTRAINT [DF__Pre_Users__IsDel__1B0907CE]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_GroupsMembers] ADD  CONSTRAINT [DF__Pre_Users__IsDel__1BFD2C07]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_GroupsMembers] ADD  CONSTRAINT [DF__Pre_Users__RCDat__1CF15040]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_ModuleForms] ADD  CONSTRAINT [DF_Pre_ModuleForms_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_ModuleForms] ADD  CONSTRAINT [DF_Pre_ModuleForms_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_ModuleForms] ADD  CONSTRAINT [DF_Pre_ModuleForms_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_SystemModules] ADD  CONSTRAINT [DF_Pre_SystemModules_DisplayOrder]  DEFAULT ((255)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[Pre_SystemModules] ADD  CONSTRAINT [DF_Pre_SystemModules_IsHidden]  DEFAULT ((0)) FOR [IsHidden]
GO
ALTER TABLE [dbo].[Pre_SystemModules] ADD  CONSTRAINT [DF_Pre_SystemModules_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_SystemModules] ADD  CONSTRAINT [DF_Pre_SystemModules_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_SystemModules] ADD  CONSTRAINT [DF_Pre_SystemModules_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_Trans_Log] ADD  CONSTRAINT [DF_Pre_Trans_Log_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[Pre_Trans_Log] ADD  CONSTRAINT [DF_Pre_Trans_Log_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_Trans_Log] ADD  CONSTRAINT [DF_Pre_Trans_Log_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_Trans_Log] ADD  CONSTRAINT [DF_Pre_Trans_Log_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF_Pre_Users_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF_Pre_Users_EmployeeID]  DEFAULT ((0)) FOR [EmployeeID]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__IsDel__573DED66]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__IsDel__5832119F]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__RCDat__592635D8]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_UserStatus] ADD  CONSTRAINT [DF_Pre_UserStatus_IsOnline]  DEFAULT ((0)) FOR [IsOnline]
GO
ALTER TABLE [dbo].[Sch_Columns] ADD  CONSTRAINT [DF_Sch_Columns_IsDeleteable]  DEFAULT ((1)) FOR [IsDeleteable]
GO
ALTER TABLE [dbo].[Sch_Columns] ADD  CONSTRAINT [DF_Sch_Columns_IsFixed]  DEFAULT ((0)) FOR [IsFixed]
GO
ALTER TABLE [dbo].[Config_TeamList]  WITH CHECK ADD  CONSTRAINT [FK_Config_TeamList_Config_AgencyList] FOREIGN KEY([AgencyID])
REFERENCES [dbo].[Config_AgencyList] ([AgencyID])
GO
ALTER TABLE [dbo].[Config_TeamList] CHECK CONSTRAINT [FK_Config_TeamList_Config_AgencyList]
GO
ALTER TABLE [dbo].[Config_TeamList]  WITH CHECK ADD  CONSTRAINT [FK_Config_TeamList_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[Config_TeamList] CHECK CONSTRAINT [FK_Config_TeamList_Lup_BranchList]
GO
ALTER TABLE [dbo].[Design_MenuItems]  WITH CHECK ADD  CONSTRAINT [FK_Design_MenuItems_Design_MenuBasic] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Design_MenuBasic] ([MenuID])
GO
ALTER TABLE [dbo].[Design_MenuItems] CHECK CONSTRAINT [FK_Design_MenuItems_Design_MenuBasic]
GO
ALTER TABLE [dbo].[Dom_AccountsPayments]  WITH CHECK ADD  CONSTRAINT [FK_Dom_AccountsPayments_Dom_DomainsDataExtra] FOREIGN KEY([RecordSerial])
REFERENCES [dbo].[Dom_DomainsDataExtra] ([RecordSerial])
GO
ALTER TABLE [dbo].[Dom_AccountsPayments] CHECK CONSTRAINT [FK_Dom_AccountsPayments_Dom_DomainsDataExtra]
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers]  WITH CHECK ADD  CONSTRAINT [FK_Dom_AssignDomainToMembers_Config_MembersList] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Config_MembersList] ([MemberID])
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers] CHECK CONSTRAINT [FK_Dom_AssignDomainToMembers_Config_MembersList]
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers]  WITH CHECK ADD  CONSTRAINT [FK_Dom_AssignDomainToMembers_Config_TeamList] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Config_TeamList] ([TeamID])
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers] CHECK CONSTRAINT [FK_Dom_AssignDomainToMembers_Config_TeamList]
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers]  WITH CHECK ADD  CONSTRAINT [FK_Dom_AssignDomainToMembers_Dom_DomainsDataExtra] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Dom_DomainsDataExtra] ([RecordSerial])
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers] CHECK CONSTRAINT [FK_Dom_AssignDomainToMembers_Dom_DomainsDataExtra]
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers]  WITH CHECK ADD  CONSTRAINT [FK_Dom_AssignDomainToMembers_Lup_TeamRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Lup_TeamRole] ([RoleID])
GO
ALTER TABLE [dbo].[Dom_AssignDomainToMembers] CHECK CONSTRAINT [FK_Dom_AssignDomainToMembers_Lup_TeamRole]
GO
ALTER TABLE [dbo].[Dom_DomainBasic]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainBasic_Config_AgencyList] FOREIGN KEY([AgencyID])
REFERENCES [dbo].[Config_AgencyList] ([AgencyID])
GO
ALTER TABLE [dbo].[Dom_DomainBasic] CHECK CONSTRAINT [FK_Dom_DomainBasic_Config_AgencyList]
GO
ALTER TABLE [dbo].[Dom_DomainBasic]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainBasic_Dom_DomainBasic] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Dom_DomainBasic] ([DomainID])
GO
ALTER TABLE [dbo].[Dom_DomainBasic] CHECK CONSTRAINT [FK_Dom_DomainBasic_Dom_DomainBasic]
GO
ALTER TABLE [dbo].[Dom_DomainBasic]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainBasic_Dom_DomainStatus] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Dom_DomainStatus] ([StatusID])
GO
ALTER TABLE [dbo].[Dom_DomainBasic] CHECK CONSTRAINT [FK_Dom_DomainBasic_Dom_DomainStatus]
GO
ALTER TABLE [dbo].[Dom_DomainBasic]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainBasic_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[Dom_DomainBasic] CHECK CONSTRAINT [FK_Dom_DomainBasic_Lup_BranchList]
GO
ALTER TABLE [dbo].[Dom_DomainBasic]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainBasic_Lup_MonthYear] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Lup_MonthYear] ([MonthID])
GO
ALTER TABLE [dbo].[Dom_DomainBasic] CHECK CONSTRAINT [FK_Dom_DomainBasic_Lup_MonthYear]
GO
ALTER TABLE [dbo].[Dom_DomainColumnsAlias]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainColumnsAlias_Dom_DomainBasic] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Dom_DomainBasic] ([DomainID])
GO
ALTER TABLE [dbo].[Dom_DomainColumnsAlias] CHECK CONSTRAINT [FK_Dom_DomainColumnsAlias_Dom_DomainBasic]
GO
ALTER TABLE [dbo].[Dom_DomainsDataExtra]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainsDataExtra_Dom_DomainBasic] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Dom_DomainBasic] ([DomainID])
GO
ALTER TABLE [dbo].[Dom_DomainsDataExtra] CHECK CONSTRAINT [FK_Dom_DomainsDataExtra_Dom_DomainBasic]
GO
ALTER TABLE [dbo].[Dom_DomainsDataExtra]  WITH CHECK ADD  CONSTRAINT [FK_Dom_DomainsDataExtra_Sch_Schemas] FOREIGN KEY([SchemaID])
REFERENCES [dbo].[Sch_Schemas] ([SchemaID])
GO
ALTER TABLE [dbo].[Dom_DomainsDataExtra] CHECK CONSTRAINT [FK_Dom_DomainsDataExtra_Sch_Schemas]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_Config_MembersList] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Config_MembersList] ([MemberID])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_Config_MembersList]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_Dom_DomainBasic] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Dom_DomainBasic] ([DomainID])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_Dom_DomainBasic]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_Dom_DomainsDataExtra] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Dom_DomainsDataExtra] ([RecordSerial])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_Dom_DomainsDataExtra]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_PCR_ConnectionResult] FOREIGN KEY([ConnectionResultID])
REFERENCES [dbo].[PCR_ConnectionResult] ([ConnectionResultID])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_PCR_ConnectionResult]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_PCR_ConnectionType] FOREIGN KEY([ConnectionTypeID])
REFERENCES [dbo].[PCR_ConnectionType] ([ConnectionTypeID])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_PCR_ConnectionType]
GO
ALTER TABLE [dbo].[PCR_PCRHistory]  WITH CHECK ADD  CONSTRAINT [FK_PCR_PCRHistory_PCR_PTPType] FOREIGN KEY([PTPTypeID])
REFERENCES [dbo].[PCR_PTPType] ([PTPTypeID])
GO
ALTER TABLE [dbo].[PCR_PCRHistory] CHECK CONSTRAINT [FK_PCR_PCRHistory_PCR_PTPType]
GO
ALTER TABLE [dbo].[Pre_BranchesPermissions]  WITH CHECK ADD  CONSTRAINT [FK_Pre_BranchesPermissions_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[Pre_BranchesPermissions] CHECK CONSTRAINT [FK_Pre_BranchesPermissions_Lup_BranchList]
GO
ALTER TABLE [dbo].[Pre_BranchesPermissions]  WITH CHECK ADD  CONSTRAINT [FK_Pre_BranchesPermissions_Pre_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Pre_Users] ([UserID])
GO
ALTER TABLE [dbo].[Pre_BranchesPermissions] CHECK CONSTRAINT [FK_Pre_BranchesPermissions_Pre_Users]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermissions_Actions] FOREIGN KEY([ActionID])
REFERENCES [dbo].[Pre_Actions] ([ActionID])
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] CHECK CONSTRAINT [FK_GroupPermissions_Actions]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermissions_FormList] FOREIGN KEY([FormID])
REFERENCES [dbo].[Pre_FormList] ([FormID])
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] CHECK CONSTRAINT [FK_GroupPermissions_FormList]
GO
ALTER TABLE [dbo].[Pre_GroupPermissions]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermissions_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Pre_Groups] ([GroupID])
GO
ALTER TABLE [dbo].[Pre_GroupPermissions] CHECK CONSTRAINT [FK_GroupPermissions_Groups]
GO
ALTER TABLE [dbo].[Pre_GroupsMembers]  WITH CHECK ADD  CONSTRAINT [FK_UsersGroups_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Pre_Groups] ([GroupID])
GO
ALTER TABLE [dbo].[Pre_GroupsMembers] CHECK CONSTRAINT [FK_UsersGroups_Groups]
GO
ALTER TABLE [dbo].[Pre_GroupsMembers]  WITH CHECK ADD  CONSTRAINT [FK_UsersGroups_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Pre_Users] ([UserID])
GO
ALTER TABLE [dbo].[Pre_GroupsMembers] CHECK CONSTRAINT [FK_UsersGroups_Users]
GO
ALTER TABLE [dbo].[Pre_ModuleForms]  WITH CHECK ADD  CONSTRAINT [FK_Pre_ModuleForms_Pre_FormList] FOREIGN KEY([FormID])
REFERENCES [dbo].[Pre_FormList] ([FormID])
GO
ALTER TABLE [dbo].[Pre_ModuleForms] CHECK CONSTRAINT [FK_Pre_ModuleForms_Pre_FormList]
GO
ALTER TABLE [dbo].[Pre_ModuleForms]  WITH CHECK ADD  CONSTRAINT [FK_Pre_ModuleForms_Pre_SystemModules] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Pre_SystemModules] ([ModuleID])
GO
ALTER TABLE [dbo].[Pre_ModuleForms] CHECK CONSTRAINT [FK_Pre_ModuleForms_Pre_SystemModules]
GO
ALTER TABLE [dbo].[Pre_Trans_Log]  WITH CHECK ADD  CONSTRAINT [FK_Pre_Trans_Log_Pre_Actions] FOREIGN KEY([ActionID])
REFERENCES [dbo].[Pre_Actions] ([ActionID])
GO
ALTER TABLE [dbo].[Pre_Trans_Log] CHECK CONSTRAINT [FK_Pre_Trans_Log_Pre_Actions]
GO
ALTER TABLE [dbo].[Pre_Trans_Log]  WITH CHECK ADD  CONSTRAINT [FK_Pre_Trans_Log_Pre_Lup_FormList] FOREIGN KEY([FormID])
REFERENCES [dbo].[Pre_FormList] ([FormID])
GO
ALTER TABLE [dbo].[Pre_Trans_Log] CHECK CONSTRAINT [FK_Pre_Trans_Log_Pre_Lup_FormList]
GO
ALTER TABLE [dbo].[Pre_Trans_Log]  WITH CHECK ADD  CONSTRAINT [FK_Pre_Trans_Log_Pre_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Pre_Users] ([UserID])
GO
ALTER TABLE [dbo].[Pre_Trans_Log] CHECK CONSTRAINT [FK_Pre_Trans_Log_Pre_Users]
GO
ALTER TABLE [dbo].[Pre_UserStatus]  WITH CHECK ADD  CONSTRAINT [FK_Pre_UserStatus_Pre_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Pre_Users] ([UserID])
GO
ALTER TABLE [dbo].[Pre_UserStatus] CHECK CONSTRAINT [FK_Pre_UserStatus_Pre_Users]
GO
ALTER TABLE [dbo].[Sch_SchemaColumns]  WITH CHECK ADD  CONSTRAINT [FK_Sch_SchemaColumns_Sch_Columns] FOREIGN KEY([CoID])
REFERENCES [dbo].[Sch_Columns] ([CoID])
GO
ALTER TABLE [dbo].[Sch_SchemaColumns] CHECK CONSTRAINT [FK_Sch_SchemaColumns_Sch_Columns]
GO
ALTER TABLE [dbo].[Sch_SchemaColumns]  WITH CHECK ADD  CONSTRAINT [FK_Sch_SchemaColumns_Sch_Schemas] FOREIGN KEY([SchemaID])
REFERENCES [dbo].[Sch_Schemas] ([SchemaID])
GO
ALTER TABLE [dbo].[Sch_SchemaColumns] CHECK CONSTRAINT [FK_Sch_SchemaColumns_Sch_Schemas]
GO
ALTER TABLE [dbo].[Sch_Schemas]  WITH CHECK ADD  CONSTRAINT [FK_Sch_Schemas_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[Sch_Schemas] CHECK CONSTRAINT [FK_Sch_Schemas_Lup_BranchList]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[29] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DCR_SummaryForCharts"
            Begin Extent = 
               Top = 6
               Left = 37
               Bottom = 248
               Right = 226
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2445
         Alias = 1485
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Chrt_Contacts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Chrt_Contacts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[41] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DCR_MemberDCRSummary"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 268
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1860
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2880
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Chrt_PD_PTP_KeptAmmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Chrt_PD_PTP_KeptAmmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[20] 4[5] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Config_AgencyList"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_AgencyBranches"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 130
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_AgencyBranchList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_AgencyBranchList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Config_TeamList"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 171
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_TeamMembers"
            Begin Extent = 
               Top = 36
               Left = 247
               Bottom = 189
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_MembersList"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_TeamMembersList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_TeamMembersList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[69] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Config_TeamList"
            Begin Extent = 
               Top = 0
               Left = 21
               Bottom = 130
               Right = 191
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_TeamMembers"
            Begin Extent = 
               Top = 3
               Left = 229
               Bottom = 199
               Right = 399
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_MembersList"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Lup_TeamRole"
            Begin Extent = 
               Top = 102
               Left = 437
               Bottom = 198
               Right = 607
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 5985
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3885
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_TeamMembersRoleList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_TeamMembersRoleList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Config_TeamMembersRoleList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[58] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 29
               Left = 647
               Bottom = 211
               Right = 816
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainsDataExtra"
            Begin Extent = 
               Top = 1
               Left = 202
               Bottom = 177
               Right = 457
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 37
               Left = 0
               Bottom = 150
               Right = 170
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_PCRHistoryList"
            Begin Extent = 
               Top = 0
               Left = 502
               Bottom = 191
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 227
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Widt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_DCRHistoryWithAccountsToImport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'h = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Widt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_DCRHistoryWithAccountsToImport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane3', @value=N'h = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3945
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_DCRHistoryWithAccountsToImport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=3 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_DCRHistoryWithAccountsToImport'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[7] 4[63] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PCR_PCRHistoryList"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 328
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_MembersList"
            Begin Extent = 
               Top = 16
               Left = 401
               Bottom = 112
               Right = 587
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2505
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2055
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 7245
         Alias = 3405
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_MemberDCRSummary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_MemberDCRSummary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[37] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 200
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_PCRHistory"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 196
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_ConnectionType"
            Begin Extent = 
               Top = 6
               Left = 478
               Bottom = 102
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1665
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4725
         Alias = 1920
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 780
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_SummaryForCharts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCR_SummaryForCharts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[38] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_AssignDomainToMembers"
            Begin Extent = 
               Top = 0
               Left = 266
               Bottom = 193
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_MembersList"
            Begin Extent = 
               Top = 73
               Left = 0
               Bottom = 169
               Right = 170
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Lup_TeamRole"
            Begin Extent = 
               Top = 0
               Left = 674
               Bottom = 96
               Right = 844
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_TeamList"
            Begin Extent = 
               Top = 24
               Left = 451
               Bottom = 199
               Right = 620
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 2685
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Fil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_AssignDomainToMembersList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_AssignDomainToMembersList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_AssignDomainToMembersList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[9] 4[76] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainsDataExtra"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 119
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 210
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsAllVersionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'dth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsAllVersionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane3', @value=N'dth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsAllVersionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=3 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsAllVersionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[14] 4[43] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 211
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainsDataExtra"
            Begin Extent = 
               Top = 6
               Left = 251
               Bottom = 211
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 5
               Left = 507
               Bottom = 171
               Right = 677
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 210
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'idth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane3', @value=N'idth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 3960
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=3 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[7] 4[40] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainsDataExtra"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 211
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 119
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 210
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsListPrev'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'dth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsListPrev'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane3', @value=N'dth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsListPrev'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=3 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsListPrev'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[1] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 211
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Wid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToBankAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'th = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 8385
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToBankAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToBankAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[8] 4[5] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 213
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Widt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToInternalAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'h = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToInternalAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainDetailsToInternalAssignList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[6] 4[68] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 0
               Left = 380
               Bottom = 179
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_AgencyList"
            Begin Extent = 
               Top = 0
               Left = 14
               Bottom = 113
               Right = 184
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Lup_BranchList"
            Begin Extent = 
               Top = 66
               Left = 157
               Bottom = 196
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Lup_MonthYear"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 102
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainStatus"
            Begin Extent = 
               Top = 102
               Left = 588
               Bottom = 198
               Right = 758
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3840
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_DomainList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[5] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Dom_DomainBasic"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Dom_DomainsDataExtra"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 119
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_MasterDomain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Dom_MasterDomain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[6] 4[84] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PCR_ConnectionResult"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_PCRHistory"
            Begin Extent = 
               Top = 6
               Left = 520
               Bottom = 211
               Right = 714
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_ConnectionType"
            Begin Extent = 
               Top = 6
               Left = 282
               Bottom = 102
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PCR_PTPType"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Config_MembersList"
            Begin Extent = 
               Top = 102
               Left = 246
               Bottom = 198
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Col' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PCR_PCRHistoryList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'umn = 1980
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PCR_PCRHistoryList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PCR_PCRHistoryList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[6] 4[56] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Lup_BranchList"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 196
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_BranchesPermissions"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 175
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_BrunchesList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_BrunchesList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Pre_Section"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_SectionPermissions"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_SectionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_SectionsList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[45] 2[5] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Pre_Users"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Pre_UsersSections"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_UsersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_UsersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_SchemaColumns"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 166
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Columns"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Sch_SchemaColList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Sch_SchemaColList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[19] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Lup_BranchList"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 172
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sch_Schemas"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Sch_SchemaList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Sch_SchemaList'
GO
USE [master]
GO
ALTER DATABASE [EIFCRM] SET  READ_WRITE 
GO
