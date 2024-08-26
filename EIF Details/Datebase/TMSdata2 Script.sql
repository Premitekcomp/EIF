USE [master]
GO
/****** Object:  Database [TMSData2]    Script Date: 03-Dec-17 4:03:42 PM ******/
CREATE DATABASE [TMSData2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TMSData2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMSData2.mdf' , SIZE = 307200KB , MAXSIZE = 1024000KB , FILEGROWTH = 102400KB )
 LOG ON 
( NAME = N'TMSData2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMSData2_log.ldf' , SIZE = 918528KB , MAXSIZE = 1024000KB , FILEGROWTH = 102400KB )
GO
ALTER DATABASE [TMSData2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMSData2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMSData2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TMSData2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TMSData2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TMSData2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TMSData2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TMSData2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TMSData2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TMSData2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TMSData2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TMSData2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TMSData2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TMSData2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TMSData2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TMSData2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TMSData2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TMSData2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TMSData2] SET AUTO_UPDATE_STATISTICS_ASYNC ON 
GO
ALTER DATABASE [TMSData2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TMSData2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TMSData2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TMSData2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TMSData2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TMSData2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TMSData2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TMSData2] SET  MULTI_USER 
GO
ALTER DATABASE [TMSData2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TMSData2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TMSData2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TMSData2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TMSData2]
GO
/****** Object:  User [TMSAdmin]    Script Date: 03-Dec-17 4:03:42 PM ******/
CREATE USER [TMSAdmin] FOR LOGIN [TMSAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [gd_execprocs]    Script Date: 03-Dec-17 4:03:43 PM ******/
CREATE ROLE [gd_execprocs]
GO
ALTER ROLE [db_owner] ADD MEMBER [TMSAdmin]
GO
/****** Object:  FullTextCatalog [TMSData2]    Script Date: 03-Dec-17 4:03:43 PM ******/
CREATE FULLTEXT CATALOG [TMSData2]AS DEFAULT

GO
/****** Object:  StoredProcedure [dbo].[Pre_AddUser]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_AddUser] (@DisplayName nvarchar(50), @UserName varchar(100), @password varchar(50), @IsActive bit, @ProfileImage varbinary(max), @EmployeeID int, @IsDoctor bit, @DoctorID tinyint)
as
begin
insert into [dbo].[Pre_Users] (DisplayName, UserName, Password, IsActive, ProfileImage, EmployeeID, IsDoctor, DoctorID) values (@DisplayName, @UserName, CONVERT(varbinary(50),@password), @IsActive, @ProfileImage, @EmployeeID, @IsDoctor, @DoctorID)
end

GO
/****** Object:  StoredProcedure [dbo].[Pre_Authenticate]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_Authenticate] (@UserID tinyint , @password varchar(50))
as
begin
select COUNT(UserID) from [dbo].[Pre_Users]
where UserID=@UserID And [Password]=CONVERT(varbinary(50),@password)
end

GO
/****** Object:  StoredProcedure [dbo].[Pre_ChangePassword]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_ChangePassword] (@UserID tinyint , @password varchar(50))
as
begin
update [dbo].[Pre_Users] set [Password]=CONVERT(varbinary(50),@password)
where UserID=@UserID
end

GO
/****** Object:  StoredProcedure [dbo].[Pre_GetUsersOutsideGroup]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_GetUsersOutsideGroup] (@GroupID tinyint)
as
begin
drop TABLE UserListTempTable
SELECT        UserID, GroupID into UserListTempTable
FROM            dbo.Pre_GroupsMembers
WHERE        (IsDeleted = 0) AND (GroupID = @GroupID)

SELECT        dbo.Pre_Users.UserID, dbo.Pre_Users.DisplayName, dbo.Pre_Users.UserName, dbo.UserListTempTable.GroupID
FROM            dbo.Pre_Users LEFT OUTER JOIN
                         dbo.UserListTempTable ON dbo.Pre_Users.UserID = dbo.UserListTempTable.UserID
WHERE        (dbo.UserListTempTable.GroupID IS NULL)
order by dbo.Pre_Users.UserID
end

GO
/****** Object:  StoredProcedure [dbo].[Pre_GetUsersOutsideNotification]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_GetUsersOutsideNotification] (@GroupID tinyint)
as
begin
drop TABLE UserListTempTable
SELECT        UserID, GroupID into UserListTempTable
FROM            dbo.Pre_GroupsMembers
WHERE        (IsDeleted = 0) AND (GroupID = @GroupID)

SELECT        dbo.Pre_Users.UserID, dbo.Pre_Users.DisplayName, dbo.UserListTempTable.GroupID
FROM            dbo.Pre_Users LEFT OUTER JOIN
                         dbo.UserListTempTable ON dbo.Pre_Users.UserID = dbo.UserListTempTable.UserID
WHERE        (dbo.UserListTempTable.GroupID IS NULL)
order by dbo.Pre_Users.UserID
end

GO
/****** Object:  StoredProcedure [dbo].[Pre_UpdateUser]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Pre_UpdateUser](@DisplayName nvarchar(50), @UserName varchar(100), @password varchar(50), @IsActive bit, @ProfileImage varbinary(max), @EmployeeID int, @LABy smallint, @UserID smallint)
as
begin
update [dbo].[Pre_Users] set [Password]=CONVERT(varbinary(50),@password), DisplayName=@DisplayName ,UserName=@UserName, IsActive=@IsActive, ProfileImage=@ProfileImage , EmployeeID=@EmployeeID, LADate=GetDate() ,LABy=@LABy  
where UserID=@UserID
end

GO
/****** Object:  Table [dbo].[A_AccountsCostCenterList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_AccountsCostCenterList](
	[CostCenterAccountID] [smallint] IDENTITY(1,1) NOT NULL,
	[CostCenterNumber] [smallint] NOT NULL,
	[CostCenterName] [nvarchar](max) NOT NULL,
	[ParentID] [smallint] NULL,
	[IsActive] [bit] NULL,
	[BranchID] [tinyint] NOT NULL,
	[LevelID] [tinyint] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_AccountsCostCenterList] PRIMARY KEY CLUSTERED 
(
	[CostCenterAccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_AccountsList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_AccountsList](
	[AccountID] [smallint] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [smallint] NOT NULL,
	[AccountName] [nvarchar](max) NOT NULL,
	[ParentID] [smallint] NULL,
	[IsActive] [bit] NULL,
	[BranchID] [tinyint] NOT NULL,
	[LevelID] [tinyint] NULL,
	[AccountTypeID] [tinyint] NULL,
	[DepitOpenBalance] [decimal](14, 2) NULL,
	[CreditOpenBalance] [decimal](14, 2) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_AccountsList] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Auto_Config_FormActions]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Auto_Config_FormActions](
	[ActionID] [smallint] IDENTITY(1,1) NOT NULL,
	[ActionName] [nvarchar](50) NOT NULL,
	[FormID] [smallint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Auto_Config_FormActions] PRIMARY KEY CLUSTERED 
(
	[ActionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Auto_Config_FormFields]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Auto_Config_FormFields](
	[FieldID] [int] IDENTITY(1,1) NOT NULL,
	[FormID] [smallint] NULL,
	[FieldTitle] [nvarchar](50) NULL,
	[FieldInnerCodeName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Auto_Config_FormGroups]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Auto_Config_FormGroups](
	[FormGrouID] [smallint] NOT NULL,
	[FormGroupTitle] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DisplayOrder] [smallint] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Auto_Config_FormGroups] PRIMARY KEY CLUSTERED 
(
	[FormGrouID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Auto_EngingCore]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Auto_EngingCore](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[FormID] [smallint] NOT NULL,
	[ActionID] [smallint] NOT NULL,
	[IsDebit] [bit] NOT NULL,
	[AccountFromTree] [bit] NOT NULL,
	[AccountID] [smallint] NULL,
	[AccountFieldID] [int] NULL,
	[NoSubAccount] [bit] NOT NULL,
	[SubAccountFromTree] [bit] NOT NULL,
	[SubAccountID] [smallint] NULL,
	[SubFieldID] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Auto_EngingCore] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Auto_FormsGroupLink]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Auto_FormsGroupLink](
	[LinkID] [smallint] IDENTITY(1,1) NOT NULL,
	[FormID] [smallint] NULL,
	[FormFriendlyTitle] [nvarchar](50) NULL,
	[GroupID] [smallint] NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Auto_FormsGroupLink] PRIMARY KEY CLUSTERED 
(
	[LinkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_CCentersJoinDetails]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_CCentersJoinDetails](
	[CCJoinID] [int] IDENTITY(1,1) NOT NULL,
	[CCenterID] [smallint] NOT NULL,
	[AccountID] [smallint] NOT NULL,
	[Weighet] [decimal](5, 2) NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_CCentersJoinDetails] PRIMARY KEY CLUSTERED 
(
	[CCJoinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Config_AccountsTypes]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Config_AccountsTypes](
	[AccountTypeID] [tinyint] NOT NULL,
	[AccountTypeTitle] [nvarchar](max) NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsTopLevel] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_AccountsTypes] PRIMARY KEY CLUSTERED 
(
	[AccountTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Config_FinancialCenter]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Config_FinancialCenter](
	[Serial] [smallint] IDENTITY(1,1) NOT NULL,
	[GroupID] [tinyint] NULL,
	[TopLevelAccountID] [smallint] NULL,
 CONSTRAINT [PK_A_Config_FinancialCenter] PRIMARY KEY CLUSTERED 
(
	[Serial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Config_ListEquation]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Config_ListEquation](
	[RecordID] [smallint] IDENTITY(1,1) NOT NULL,
	[NodeID] [tinyint] NOT NULL,
	[AccountID] [smallint] NOT NULL,
	[IsPositive] [bit] NOT NULL,
 CONSTRAINT [PK_A_Config_ListEquation] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Config_ListNodes]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Config_ListNodes](
	[NodeID] [tinyint] NOT NULL,
	[NodeTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_A_Config_ListNodes] PRIMARY KEY CLUSTERED 
(
	[NodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_JournalBasic]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_JournalBasic](
	[EID] [int] IDENTITY(1,1) NOT NULL,
	[ENo] [int] NOT NULL,
	[EDate] [date] NOT NULL,
	[TotalDebit] [decimal](18, 2) NOT NULL,
	[TotalCredit] [decimal](18, 2) NOT NULL,
	[EntryTypeID] [int] NOT NULL,
	[Notes] [nvarchar](500) NULL,
	[Approved] [bit] NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_JournalBasic] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_JournalEntryDetails]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_JournalEntryDetails](
	[JEDetailID] [int] IDENTITY(1,1) NOT NULL,
	[JEMasterID] [int] NOT NULL,
	[AccountID] [smallint] NOT NULL,
	[SubAccountID] [int] NULL,
	[CostCenterID] [smallint] NULL,
	[Debit] [decimal](18, 2) NOT NULL,
	[Credit] [decimal](18, 2) NOT NULL,
	[CurrencyID] [tinyint] NOT NULL,
	[ExchangeRate] [decimal](18, 2) NOT NULL,
	[LocalDebit] [decimal](18, 2) NOT NULL,
	[LocalCredit] [decimal](18, 2) NOT NULL,
	[Notes] [nvarchar](500) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_JournalEntryDetails] PRIMARY KEY CLUSTERED 
(
	[JEDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Lup_ExchangeRateRefTable]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Lup_ExchangeRateRefTable](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyID] [tinyint] NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NULL,
	[ExchangeRate] [decimal](18, 1) NOT NULL,
	[IsCurrentRate] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Lup_ExchangeRateRefTable] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Lup_JETypes]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Lup_JETypes](
	[JETypeID] [int] NOT NULL,
	[JETypeNameAr] [nvarchar](100) NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_Lup_JETypes] PRIMARY KEY CLUSTERED 
(
	[JETypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_SubAccountsJoinDetails]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_SubAccountsJoinDetails](
	[JoinID] [int] IDENTITY(1,1) NOT NULL,
	[SubAccountID] [int] NOT NULL,
	[AccountID] [smallint] NOT NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_SubAccountsJoinDetails] PRIMARY KEY CLUSTERED 
(
	[JoinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_SubAccountsList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_SubAccountsList](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [int] NOT NULL,
	[AccountName] [nvarchar](max) NOT NULL,
	[ParentID] [int] NULL,
	[IsActive] [bit] NULL,
	[BranchID] [tinyint] NOT NULL,
	[LevelID] [tinyint] NULL,
	[AccountTypeID] [tinyint] NULL,
	[DepitOpenBalance] [decimal](14, 2) NULL,
	[CreditOpenBalance] [decimal](14, 2) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_A_SubAccountsList] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AST_AssetsBasic]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AST_AssetsBasic](
	[AssetID] [int] IDENTITY(1,1) NOT NULL,
	[AssetStateID] [int] NULL,
	[AssetSerialNumber] [nvarchar](50) NULL,
	[AssetTitle] [nvarchar](max) NOT NULL,
	[BuyDate] [date] NOT NULL,
	[CapitalCost] [decimal](18, 2) NOT NULL,
	[StartDepreciationDate] [date] NOT NULL,
	[StartDepsCurrentValue] [decimal](18, 2) NOT NULL,
	[DepreciationPercentage] [decimal](5, 2) NOT NULL,
	[SalesDate] [date] NULL,
	[ScrapDate] [date] NULL,
	[ScrapValue] [decimal](5, 2) NOT NULL,
	[ASTGroupID] [smallint] NULL,
	[ASTLocation] [nvarchar](max) NULL,
	[Notes] [nvarchar](500) NULL,
	[BranchID] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_AST_AssetsBasic] PRIMARY KEY CLUSTERED 
(
	[AssetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AST_Groups]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AST_Groups](
	[ASTGroupID] [smallint] IDENTITY(1,1) NOT NULL,
	[ASTGroupTitle] [nvarchar](50) NOT NULL,
	[GroupDepreciationPercentage] [decimal](5, 2) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_AST_Groups] PRIMARY KEY CLUSTERED 
(
	[ASTGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AST_Lup_AssetsState]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AST_Lup_AssetsState](
	[AssetStateID] [tinyint] NOT NULL,
	[AssetStateTitle] [nvarchar](100) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_AST_Lup_AssetsState] PRIMARY KEY CLUSTERED 
(
	[AssetStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Bsk_MonthlyTarget]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Bsk_MonthlyTarget](
	[TargetID] [int] IDENTITY(1,1) NOT NULL,
	[DomainID] [bigint] NULL,
	[MonthID] [smallint] NULL,
	[BankID] [tinyint] NULL,
	[Target] [int] NULL,
 CONSTRAINT [PK_Col_Bsk_MonthlyTarget] PRIMARY KEY CLUSTERED 
(
	[TargetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Bsk_MonthlyTargetDetails]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Bsk_MonthlyTargetDetails](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[TargetID] [int] NULL,
	[BucketValue] [tinyint] NULL,
	[BucketTarget] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Col_Bsk_MonthlyTargetDetails] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DailyVisits]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DailyVisits](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[PointToRecord] [bigint] NULL,
	[Collector] [int] NULL,
	[ConnectionDate] [date] NULL,
	[ConnectionType] [nvarchar](50) NULL,
	[ConnetctionResult] [nvarchar](50) NULL,
	[PTPType] [nvarchar](50) NULL,
	[PTPDate] [date] NULL,
	[PTPAmount] [decimal](8, 2) NULL,
	[KeptBroken] [bit] NULL,
	[Broken] [bit] NULL,
	[KeptAmount] [decimal](8, 2) NULL,
	[TrialDetails] [nvarchar](max) NULL,
	[ActionDate] [date] NULL,
 CONSTRAINT [PK_Col_DailyVisits] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DomainsDataBasic]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DomainsDataBasic](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[DomainID] [bigint] NOT NULL,
	[AccountNo] [nvarchar](max) NULL,
	[AccountID] [nvarchar](max) NULL,
	[CustomerName] [nvarchar](max) NULL,
	[Product] [nvarchar](max) NULL,
	[Cycle] [nvarchar](max) NULL,
	[Bucket] [nvarchar](max) NULL,
	[PastDue] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
	[City] [nvarchar](max) NULL,
	[Office] [nvarchar](max) NULL,
	[TeamLeader] [int] NULL,
	[SuperVisor] [int] NULL,
	[CollectorName] [int] NULL,
	[RecordVersion] [tinyint] NULL,
	[Payment] [decimal](8, 2) NULL,
	[IsBucket] [nvarchar](50) NULL,
	[CardNo] [nvarchar](max) NULL,
	[NationalityTitle] [nvarchar](max) NULL,
	[PassportNo] [nvarchar](max) NULL,
	[CreditLimit] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[AddressT] [nvarchar](max) NULL,
	[WorkPhoneTitle] [nvarchar](max) NULL,
	[CompanyNameTitle] [nvarchar](max) NULL,
	[CompanyAddressTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_DomainsDataBasic] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DomainsDataExtra]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DomainsDataExtra](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[ShortLineID] [bigint] NULL,
	[DomainID] [bigint] NULL,
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
	[CollectorName] [nvarchar](50) NULL,
	[TeamLeader] [nvarchar](50) NULL,
	[SuperVisor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Col_DomainsDataExtra] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DomainsDataPK]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DomainsDataPK](
	[DomainSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[MonthID] [smallint] NULL,
	[BankID] [tinyint] NOT NULL,
	[DomainType] [smallint] NOT NULL,
	[DomainSchema] [int] NULL,
	[Branch] [tinyint] NULL,
	[DomainStatus] [bit] NULL,
	[CurrentVersion] [tinyint] NOT NULL,
 CONSTRAINT [PK_Col_DomainsDataPK] PRIMARY KEY CLUSTERED 
(
	[DomainSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DomainsSchemaBasic]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DomainsSchemaBasic](
	[SchemaID] [int] IDENTITY(1,1) NOT NULL,
	[SchemaTitle] [nvarchar](max) NULL,
	[CreationDate] [datetime] NULL,
	[SheetName] [nvarchar](max) NULL,
	[SchemaOwner] [smallint] NULL,
	[AccNoColID] [smallint] NULL,
	[AccNoColTitle] [nvarchar](max) NULL,
	[AccIDColID] [smallint] NULL,
	[AccIDColTitle] [nvarchar](50) NULL,
	[CustomerNameColID] [smallint] NULL,
	[CustomerNameColTitle] [nvarchar](max) NULL,
	[ProductColID] [smallint] NULL,
	[ProductColTitle] [nvarchar](max) NULL,
	[CycleColID] [smallint] NULL,
	[CycleColTItle] [nvarchar](max) NULL,
	[BucketColID] [smallint] NULL,
	[BucketColTitle] [nvarchar](max) NULL,
	[PastDueColID] [smallint] NULL,
	[PastDueColTitle] [nvarchar](50) NULL,
	[BalanceColID] [smallint] NULL,
	[BalanceColTitle] [nvarchar](50) NULL,
	[CityColID] [smallint] NULL,
	[CityColTitle] [nvarchar](50) NULL,
	[OfficeColID] [smallint] NULL,
	[OfficeColTitle] [nvarchar](50) NULL,
	[SchemaDirection] [tinyint] NULL,
	[Limit2Owner] [bit] NULL,
	[Limit2OwnerGroup] [bit] NULL,
	[Limit2OwnerOffice] [bit] NULL,
	[CardNoID] [smallint] NULL,
	[NationalityID] [smallint] NULL,
	[PassportNoID] [smallint] NULL,
	[CreditLimitID] [smallint] NULL,
	[MobileNumberID] [smallint] NULL,
	[AddressID] [smallint] NULL,
	[WorkPhoneID] [smallint] NULL,
	[CompanyNameID] [smallint] NULL,
	[CompanyAddressID] [smallint] NULL,
	[CardNo] [nvarchar](max) NULL,
	[NationalityTitle] [nvarchar](max) NULL,
	[PassportNo] [nvarchar](max) NULL,
	[CreditLimit] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[AddressT] [nvarchar](max) NULL,
	[WorkPhoneTitle] [nvarchar](max) NULL,
	[CompanyNameTitle] [nvarchar](max) NULL,
	[CompanyAddressTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_Col_DomainsSchemaBasic] PRIMARY KEY CLUSTERED 
(
	[SchemaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_DomainsSchemaExtra]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_DomainsSchemaExtra](
	[RecordSerial] [bigint] IDENTITY(1,1) NOT NULL,
	[SchemaID] [int] NULL,
	[HeaderOrder] [int] NOT NULL,
	[HeaderTitle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Col_DomainsSchemaExtra] PRIMARY KEY CLUSTERED 
(
	[RecordSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Lup_CommentList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Lup_CommentList](
	[CommentID] [smallint] NOT NULL,
	[CommentTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_Col_Lup_CommentList] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Lup_DomainsType]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Col_Lup_DomainsType](
	[DomainTypeID] [smallint] IDENTITY(1,1) NOT NULL,
	[DomainTypeTitle] [varchar](70) NULL,
 CONSTRAINT [PK_Col_Domains_C_Type] PRIMARY KEY CLUSTERED 
(
	[DomainTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Col_Lup_MonthList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Lup_MonthList](
	[MonthID] [smallint] IDENTITY(1,1) NOT NULL,
	[MonthTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_Col_Lup_MonthList] PRIMARY KEY CLUSTERED 
(
	[MonthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Lup_TeamList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Lup_TeamList](
	[TeamID] [int] NOT NULL,
	[TeamName] [nvarchar](150) NULL,
 CONSTRAINT [PK_Col_Lup_TeamList] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_Lup_TeamMembers]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_Lup_TeamMembers](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[TeamID] [int] NULL,
	[MemberID] [smallint] NULL,
	[RoleID] [tinyint] NULL,
	[MemberSince] [date] NULL,
	[LeftIn] [date] NULL,
 CONSTRAINT [PK_Col_Lup_TeamMembers] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Col_lup_TeamRole]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Col_lup_TeamRole](
	[RoleID] [tinyint] NOT NULL,
	[RoleTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_Col_lup_TeamRole] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HR_Emp_BasicInfo]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HR_Emp_BasicInfo](
	[EmployeeID] [smallint] IDENTITY(1,1) NOT NULL,
	[EmpNameAR] [nvarchar](max) NOT NULL,
	[EmpNameEN] [varchar](50) NULL,
	[EmployeeFPNo] [nvarchar](50) NULL,
	[HireDate] [date] NOT NULL,
	[StartWorkingDate] [date] NULL,
	[StartUsingFP] [date] NULL,
	[BirthDate] [date] NULL,
	[GenderID] [tinyint] NOT NULL,
	[CountryID] [tinyint] NOT NULL,
	[CityID] [smallint] NOT NULL,
	[AreaID] [smallint] NULL,
	[Address] [nvarchar](500) NULL,
	[NationalityID] [tinyint] NOT NULL,
	[MilitaryServiceID] [tinyint] NOT NULL,
	[SocialStatusID] [tinyint] NOT NULL,
	[EmployeeProfileImage] [image] NULL,
	[Notes] [nvarchar](max) NULL,
	[ReligionID] [tinyint] NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
	[ExternalID] [nvarchar](50) NULL,
 CONSTRAINT [PK_HR_EmployeeID] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HR_Lup_BankList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HR_Lup_BankList](
	[BankID] [tinyint] IDENTITY(1,1) NOT NULL,
	[BankTitle] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NOT NULL,
	[RCBy] [int] NULL,
	[LADate] [datetime] NULL,
	[LABy] [int] NULL,
 CONSTRAINT [PK_HR_Lup_BankList] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lup_BranchList]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_BranchList](
	[BranchID] [tinyint] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Lup_currencyTypes]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lup_currencyTypes](
	[currncyTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[IsDefault] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
 CONSTRAINT [PK_Lup_currencyTypes] PRIMARY KEY CLUSTERED 
(
	[currncyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pre_Actions]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_BranchesPermissions]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_FormActions]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_FormList]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_GroupPermissions]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_Groups]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_GroupsMembers]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_ModuleForms]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_ModuleForms](
	[RecordSerial] [smallint] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Pre_SystemModules]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_Trans_Log]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[Pre_Users]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
	[IsDoctor] [bit] NOT NULL,
	[DoctorID] [tinyint] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsDeletable] [bit] NOT NULL,
	[RCDate] [datetime] NULL,
	[RCBy] [smallint] NULL,
	[LADate] [datetime] NULL,
	[LABy] [smallint] NULL,
	[ChatStatus] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pre_UserStatus]    Script Date: 03-Dec-17 4:03:43 PM ******/
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
/****** Object:  Table [dbo].[UserListTempTable]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserListTempTable](
	[UserID] [smallint] NOT NULL,
	[GroupID] [tinyint] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[A_JournalDetailsForFinancialReports]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_JournalDetailsForFinancialReports]
AS
SELECT        dbo.A_JournalEntryDetails.JEDetailID, dbo.A_JournalEntryDetails.JEMasterID, dbo.A_JournalEntryDetails.AccountID, CONVERT(nvarchar(MAX), dbo.A_AccountsList.AccountNumber) 
                         + N' - ' + dbo.A_AccountsList.AccountName AS AccountFullName, dbo.A_JournalEntryDetails.SubAccountID, CONVERT(nvarchar(MAX), dbo.A_SubAccountsList.AccountNumber) 
                         + N' -  ' + dbo.A_SubAccountsList.AccountName AS SubAccountFullName, dbo.A_JournalEntryDetails.Debit, dbo.A_JournalEntryDetails.Credit, dbo.A_JournalEntryDetails.CurrencyID, 
                         dbo.Lup_currencyTypes.Title AS CurrencyTitle, dbo.A_JournalEntryDetails.ExchangeRate, dbo.A_JournalEntryDetails.LocalDebit, dbo.A_JournalEntryDetails.LocalCredit, dbo.A_JournalEntryDetails.Notes, 
                         MONTH(dbo.A_JournalBasic.EDate) AS EntryMonth, CASE WHEN A_AccountsList.AccountTypeID = 1 OR
                         A_AccountsList.AccountTypeID = 4 THEN (dbo.A_JournalEntryDetails.LocalDebit - dbo.A_JournalEntryDetails.LocalCredit) ELSE (dbo.A_JournalEntryDetails.LocalCredit - dbo.A_JournalEntryDetails.LocalDebit) 
                         END AS AccountSum, dbo.A_AccountsList.ParentID AS AccountParent, dbo.A_SubAccountsList.ParentID AS SubAccountParent, dbo.A_JournalBasic.EDate, dbo.A_JournalBasic.ENo, 
                         dbo.A_AccountsList.AccountTypeID
FROM            dbo.A_JournalEntryDetails INNER JOIN
                         dbo.A_AccountsList ON dbo.A_JournalEntryDetails.AccountID = dbo.A_AccountsList.AccountID INNER JOIN
                         dbo.Lup_currencyTypes ON dbo.A_JournalEntryDetails.CurrencyID = dbo.Lup_currencyTypes.currncyTypeID INNER JOIN
                         dbo.A_JournalBasic ON dbo.A_JournalEntryDetails.JEMasterID = dbo.A_JournalBasic.EID LEFT OUTER JOIN
                         dbo.A_SubAccountsList ON dbo.A_JournalEntryDetails.SubAccountID = dbo.A_SubAccountsList.AccountID
WHERE        (dbo.A_JournalEntryDetails.IsDeleted = 0) AND (dbo.A_JournalBasic.Approved = 1)



GO
/****** Object:  View [dbo].[A_FinCenterView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_FinCenterView]
AS
SELECT        dbo.A_Config_FinancialCenter.GroupID, dbo.A_Config_FinancialCenter.TopLevelAccountID, dbo.A_AccountsList.AccountName, dbo.A_JournalDetailsForFinancialReports.AccountFullName, 
                         SUM(dbo.A_JournalDetailsForFinancialReports.LocalDebit) AS LocalDebit, SUM(dbo.A_JournalDetailsForFinancialReports.LocalCredit) AS LocalCredit, SUM(dbo.A_JournalDetailsForFinancialReports.AccountSum) 
                         AS AccountSum, dbo.A_JournalDetailsForFinancialReports.EDate
FROM            dbo.A_Config_FinancialCenter INNER JOIN
                         dbo.A_JournalDetailsForFinancialReports ON dbo.A_Config_FinancialCenter.TopLevelAccountID = dbo.A_JournalDetailsForFinancialReports.AccountParent INNER JOIN
                         dbo.A_AccountsList ON dbo.A_JournalDetailsForFinancialReports.AccountParent = dbo.A_AccountsList.AccountID
GROUP BY dbo.A_Config_FinancialCenter.GroupID, dbo.A_Config_FinancialCenter.TopLevelAccountID, dbo.A_JournalDetailsForFinancialReports.AccountFullName, dbo.A_AccountsList.AccountName, 
                         dbo.A_JournalDetailsForFinancialReports.EDate



GO
/****** Object:  View [dbo].[A_FinCenterBalance]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_FinCenterBalance]
AS
SELECT        GroupID, TopLevelAccountID, AccountName, AccountFullName, LocalDebit, LocalCredit, AccountSum AS Balance, CASE WHEN GroupID = 0 THEN N'إجمالي الاستثمار' ELSE N'إجمالي مصادر التمويل' END AS GroupTitle, 
                         EDate
FROM            dbo.A_FinCenterView



GO
/****** Object:  View [dbo].[A_MasterBookPivot]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_MasterBookPivot]
AS
SELECT        *
FROM            dbo.A_JournalDetailsForFinancialReports
Pivot (Sum(AccountSum) FOR Entrymonth IN ([1], [2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12]))As monthSum








GO
/****** Object:  View [dbo].[A_Auto_EnginCoreView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_Auto_EnginCoreView]
AS
SELECT        TOP (100) PERCENT dbo.A_Auto_EngingCore.RecordID, dbo.A_Auto_EngingCore.FormID, CASE WHEN IsDebit = 1 THEN N'من' ELSE N'الي' END AS DirectionTitle, 
                         CASE WHEN AccountFromTree = 1 THEN A_AccountsList.AccountName ELSE A_Auto_Config_FormFields.FieldTitle END AS AccountTitle, 
                         CASE WHEN NoSubAccount = 0 THEN (CASE WHEN SubAccountFromTree = 1 THEN A_SubAccountsList.AccountName ELSE A_Auto_Config_FormFields_1.FieldTitle END) END AS SubAccountTitle, 
                         dbo.A_Auto_EngingCore.IsDebit, dbo.A_Auto_EngingCore.ActionID
FROM            dbo.A_Auto_EngingCore LEFT OUTER JOIN
                         dbo.A_Auto_Config_FormFields AS A_Auto_Config_FormFields_1 ON dbo.A_Auto_EngingCore.SubFieldID = A_Auto_Config_FormFields_1.FieldID LEFT OUTER JOIN
                         dbo.A_Auto_Config_FormFields ON dbo.A_Auto_EngingCore.AccountFieldID = dbo.A_Auto_Config_FormFields.FieldID LEFT OUTER JOIN
                         dbo.A_SubAccountsList ON dbo.A_Auto_EngingCore.SubAccountID = dbo.A_SubAccountsList.AccountID LEFT OUTER JOIN
                         dbo.A_AccountsList ON dbo.A_Auto_EngingCore.AccountID = dbo.A_AccountsList.AccountID
WHERE        (dbo.A_Auto_EngingCore.IsDeleted = 0)








GO
/****** Object:  View [dbo].[A_Config_CashView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_Config_CashView]
AS
SELECT        dbo.A_Config_ListEquation.NodeID, dbo.A_Config_ListNodes.NodeTitle, dbo.A_Config_ListEquation.AccountID, CONVERT(nvarchar(MAX), dbo.A_AccountsList.AccountNumber) 
                         + N' - ' + dbo.A_AccountsList.AccountName AS AccountFullName, CASE WHEN IsPositive = 1 THEN N'موجب' ELSE N'سالب' END AS TermSign
FROM            dbo.A_Config_ListNodes INNER JOIN
                         dbo.A_Config_ListEquation ON dbo.A_Config_ListNodes.NodeID = dbo.A_Config_ListEquation.NodeID INNER JOIN
                         dbo.A_AccountsList ON dbo.A_Config_ListEquation.AccountID = dbo.A_AccountsList.AccountID








GO
/****** Object:  View [dbo].[A_CostCenterValues]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_CostCenterValues]
AS
SELECT        dbo.A_JournalEntryDetails.JEDetailID, dbo.A_JournalEntryDetails.JEMasterID, CONVERT(nvarchar(MAX), dbo.A_AccountsCostCenterList.CostCenterNumber) 
                         + N'- ' + dbo.A_AccountsCostCenterList.CostCenterName AS CCFullName, CONVERT(nvarchar(MAX), dbo.A_CCentersJoinDetails.Weighet) + N'%' AS WeightAsText, 
                         dbo.A_JournalEntryDetails.LocalDebit + dbo.A_JournalEntryDetails.LocalCredit AS EntryValue, dbo.A_CCentersJoinDetails.Weighet / 100 AS WeightAsNo
FROM            dbo.A_AccountsList INNER JOIN
                         dbo.A_CCentersJoinDetails ON dbo.A_AccountsList.AccountID = dbo.A_CCentersJoinDetails.AccountID INNER JOIN
                         dbo.A_JournalEntryDetails ON dbo.A_AccountsList.AccountID = dbo.A_JournalEntryDetails.AccountID INNER JOIN
                         dbo.A_AccountsCostCenterList ON dbo.A_CCentersJoinDetails.CCenterID = dbo.A_AccountsCostCenterList.CostCenterAccountID








GO
/****** Object:  View [dbo].[A_JournalBasicView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_JournalBasicView]
AS
SELECT     dbo.A_JournalBasic.EID, dbo.A_JournalBasic.ENo, dbo.A_JournalBasic.EDate, dbo.A_JournalBasic.TotalDebit, dbo.A_JournalBasic.TotalCredit, 
                      dbo.A_JournalBasic.EntryTypeID, dbo.A_Lup_JETypes.JETypeNameAr, dbo.A_JournalBasic.Notes, 
                      CASE WHEN Approved = 1 THEN N'معتمد' ELSE N'غير معتمد' END AS EntryApproveStatus, 
                      CASE WHEN A_JournalBasic.IsDeleted = 1 THEN N'ملغي' ELSE N'' END AS EntryDelStatus, 
                      CASE WHEN TotalCredit = TotalDebit THEN N'متزن' ELSE N'غير متزن' END AS EntryBalanceStatus, dbo.A_JournalBasic.Approved AS ApproveFlag, 
                      dbo.A_JournalBasic.IsDeleted AS CancelFlag, dbo.A_JournalBasic.RCDate, Pre_Users_1.DisplayName AS CreatedBy, dbo.A_JournalBasic.LADate, 
                      dbo.Pre_Users.DisplayName AS ModifiedBy, CASE WHEN TotalCredit = TotalDebit THEN 1 ELSE 0 END AS BalanceFlag
FROM         dbo.A_JournalBasic INNER JOIN
                      dbo.A_Lup_JETypes ON dbo.A_JournalBasic.EntryTypeID = dbo.A_Lup_JETypes.JETypeID LEFT OUTER JOIN
                      dbo.Pre_Users ON dbo.A_JournalBasic.LABy = dbo.Pre_Users.UserID LEFT OUTER JOIN
                      dbo.Pre_Users AS Pre_Users_1 ON dbo.A_JournalBasic.RCBy = Pre_Users_1.UserID







GO
/****** Object:  View [dbo].[A_JournalDetailsForFinancialReportsPrev]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_JournalDetailsForFinancialReportsPrev]
AS
SELECT        dbo.A_JournalEntryDetails.JEDetailID, dbo.A_JournalEntryDetails.JEMasterID, dbo.A_JournalEntryDetails.AccountID, CONVERT(nvarchar(MAX), dbo.A_AccountsList.AccountNumber) 
                         + N' - ' + dbo.A_AccountsList.AccountName AS AccountFullName, dbo.A_JournalEntryDetails.SubAccountID, CONVERT(nvarchar(MAX), dbo.A_SubAccountsList.AccountNumber) 
                         + N' -  ' + dbo.A_SubAccountsList.AccountName AS SubAccountFullName, dbo.A_JournalEntryDetails.Debit, dbo.A_JournalEntryDetails.Credit, dbo.A_JournalEntryDetails.CurrencyID, 
                         dbo.Lup_currencyTypes.Title AS CurrencyTitle, dbo.A_JournalEntryDetails.ExchangeRate, dbo.A_JournalEntryDetails.LocalDebit, dbo.A_JournalEntryDetails.LocalCredit, dbo.A_JournalEntryDetails.Notes, 
                         MONTH(dbo.A_JournalBasic.EDate) AS EntryMonth, CASE WHEN A_AccountsList.AccountTypeID = 1 OR
                         A_AccountsList.AccountTypeID = 4 THEN (dbo.A_JournalEntryDetails.LocalDebit - dbo.A_JournalEntryDetails.LocalCredit) ELSE (dbo.A_JournalEntryDetails.LocalCredit - dbo.A_JournalEntryDetails.LocalDebit) 
                         END AS AccountSum, dbo.A_AccountsList.ParentID AS AccountParent, dbo.A_SubAccountsList.ParentID AS SubAccountParent, dbo.A_JournalBasic.EDate, dbo.A_JournalBasic.ENo, 
                         dbo.A_AccountsList.AccountTypeID
FROM            dbo.A_JournalEntryDetails INNER JOIN
                         dbo.A_AccountsList ON dbo.A_JournalEntryDetails.AccountID = dbo.A_AccountsList.AccountID INNER JOIN
                         dbo.Lup_currencyTypes ON dbo.A_JournalEntryDetails.CurrencyID = dbo.Lup_currencyTypes.currncyTypeID INNER JOIN
                         dbo.A_JournalBasic ON dbo.A_JournalEntryDetails.JEMasterID = dbo.A_JournalBasic.EID LEFT OUTER JOIN
                         dbo.A_SubAccountsList ON dbo.A_JournalEntryDetails.SubAccountID = dbo.A_SubAccountsList.AccountID
WHERE        (dbo.A_JournalEntryDetails.IsDeleted = 0) AND (dbo.A_JournalBasic.Approved = 1)



GO
/****** Object:  View [dbo].[A_JournalDetailsView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[A_JournalDetailsView]
AS
SELECT        dbo.A_JournalEntryDetails.JEDetailID, dbo.A_JournalEntryDetails.JEMasterID, dbo.A_JournalEntryDetails.AccountID, dbo.A_AccountsList.AccountNumber, CONVERT(nvarchar(MAX), 
                         dbo.A_AccountsList.AccountNumber) + N' - ' + dbo.A_AccountsList.AccountName AS AccountFullName, dbo.A_JournalEntryDetails.SubAccountID, CONVERT(nvarchar(MAX), dbo.A_SubAccountsList.AccountNumber)
                          + N' -  ' + dbo.A_SubAccountsList.AccountName AS SubAccountFullName, dbo.A_JournalEntryDetails.CostCenterID, CONVERT(nvarchar(MAX), dbo.A_AccountsCostCenterList.CostCenterNumber) 
                         + N' - ' + dbo.A_AccountsCostCenterList.CostCenterName AS CostCenterFullAccountName, dbo.A_JournalEntryDetails.Debit, dbo.A_JournalEntryDetails.Credit, dbo.A_JournalEntryDetails.CurrencyID, 
                         dbo.Lup_currencyTypes.Title AS CurrencyTitle, dbo.A_JournalEntryDetails.ExchangeRate, dbo.A_JournalEntryDetails.LocalDebit, dbo.A_JournalEntryDetails.LocalCredit, dbo.A_JournalEntryDetails.Notes
FROM            dbo.A_JournalEntryDetails INNER JOIN
                         dbo.A_AccountsList ON dbo.A_JournalEntryDetails.AccountID = dbo.A_AccountsList.AccountID INNER JOIN
                         dbo.Lup_currencyTypes ON dbo.A_JournalEntryDetails.CurrencyID = dbo.Lup_currencyTypes.currncyTypeID LEFT OUTER JOIN
                         dbo.A_AccountsCostCenterList ON dbo.A_JournalEntryDetails.CostCenterID = dbo.A_AccountsCostCenterList.CostCenterAccountID LEFT OUTER JOIN
                         dbo.A_SubAccountsList ON dbo.A_JournalEntryDetails.SubAccountID = dbo.A_SubAccountsList.AccountID
WHERE        (dbo.A_JournalEntryDetails.IsDeleted = 0)








GO
/****** Object:  View [dbo].[Col_CompareDomainSummaryByBucket]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Col_CompareDomainSummaryByBucket]
AS
SELECT     RecordVersion, COUNT(RecordSerial) AS AccountCount, Bucket, SUM(PastDue) AS TotalPastDue, SUM(Balance) AS TotalBalance
FROM         dbo.Col_DomainsDataBasic
GROUP BY Bucket, RecordVersion

GO
/****** Object:  View [dbo].[Col_DCRFullView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Col_DCRFullView]
AS
SELECT     dbo.Col_DailyVisits.RecordSerial, dbo.Col_DomainsDataBasic.AccountID, dbo.Col_DomainsDataBasic.DomainID, dbo.HR_Emp_BasicInfo.EmpNameAR AS CollectorName, 
                      dbo.Col_DailyVisits.ConnectionDate, dbo.Col_DailyVisits.ConnectionType, dbo.Col_DailyVisits.ConnetctionResult, dbo.Col_DailyVisits.PTPType, dbo.Col_DailyVisits.PTPDate, 
                      dbo.Col_DailyVisits.PTPAmount, CASE WHEN KeptBroken = 1 THEN 1 ELSE 0 END AS Kept, CASE WHEN Broken = 1 THEN 1 ELSE 0 END AS Broken, dbo.Col_DailyVisits.KeptAmount
FROM         dbo.Col_DailyVisits INNER JOIN
                      dbo.Col_DomainsDataBasic ON dbo.Col_DailyVisits.PointToRecord = dbo.Col_DomainsDataBasic.RecordSerial INNER JOIN
                      dbo.Col_Lup_TeamMembers ON dbo.Col_DailyVisits.Collector = dbo.Col_Lup_TeamMembers.RecordID INNER JOIN
                      dbo.HR_Emp_BasicInfo ON dbo.Col_Lup_TeamMembers.MemberID = dbo.HR_Emp_BasicInfo.EmployeeID

GO
/****** Object:  View [dbo].[Per_GroupPermissionView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Per_GroupPermissionView]
AS
SELECT     dbo.Pre_GroupPermissions.RecordSerial, dbo.Pre_GroupPermissions.GroupID, dbo.Pre_GroupPermissions.ActionID, dbo.Pre_Actions.ActionTitle, dbo.Pre_GroupPermissions.FormID, 
                      dbo.Pre_FormList.FormTitle
FROM         dbo.Pre_GroupPermissions INNER JOIN
                      dbo.Pre_Actions ON dbo.Pre_GroupPermissions.ActionID = dbo.Pre_Actions.ActionID INNER JOIN
                      dbo.Pre_FormList ON dbo.Pre_GroupPermissions.FormID = dbo.Pre_FormList.FormID

GO
/****** Object:  View [dbo].[Pre_AccessPremissionView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_AccessPremissionView]
AS
SELECT     dbo.Pre_GroupPermissions.FormID, dbo.Pre_GroupsMembers.UserID, dbo.Pre_GroupPermissions.ActionID, dbo.Pre_GroupPermissions.GroupID
FROM         dbo.Pre_GroupPermissions INNER JOIN
                      dbo.Pre_GroupsMembers ON dbo.Pre_GroupPermissions.GroupID = dbo.Pre_GroupsMembers.GroupID
WHERE     (dbo.Pre_GroupPermissions.IsActive = 1) AND (dbo.Pre_GroupsMembers.IsDeleted = 0)

GO
/****** Object:  View [dbo].[Pre_FormActionsView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_FormActionsView]
AS
SELECT     dbo.Pre_FormActions.RecordSerial, dbo.Pre_FormActions.FormID, dbo.Pre_FormActions.ActionID, dbo.Pre_Actions.ActionTitle
FROM         dbo.Pre_Actions INNER JOIN
                      dbo.Pre_FormActions ON dbo.Pre_Actions.ActionID = dbo.Pre_FormActions.ActionID
WHERE     (dbo.Pre_Actions.OnlyLogAction = 0)

GO
/****** Object:  View [dbo].[Pre_GroupMemebersView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_GroupMemebersView]
AS
SELECT        dbo.Pre_GroupsMembers.RecordSerial, dbo.Pre_GroupsMembers.UserID, dbo.Pre_GroupsMembers.GroupID, dbo.Pre_Users.DisplayName, dbo.Pre_Users.ProfileImage, dbo.Pre_Users.UserName
FROM            dbo.Pre_GroupsMembers INNER JOIN
                         dbo.Pre_Users ON dbo.Pre_GroupsMembers.UserID = dbo.Pre_Users.UserID
WHERE        (dbo.Pre_Users.IsDeleted = 0) AND (dbo.Pre_GroupsMembers.IsDeleted = 0)

GO
/****** Object:  View [dbo].[Pre_ModuleFormsView]    Script Date: 03-Dec-17 4:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pre_ModuleFormsView]
AS
SELECT     dbo.Pre_ModuleForms.RecordSerial, dbo.Pre_ModuleForms.ModuleID, dbo.Pre_ModuleForms.FormID, dbo.Pre_FormList.FormTitle
FROM         dbo.Pre_ModuleForms INNER JOIN
                      dbo.Pre_FormList ON dbo.Pre_ModuleForms.FormID = dbo.Pre_FormList.FormID
WHERE     (dbo.Pre_ModuleForms.IsDeleted = 0)

GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] ADD  CONSTRAINT [DF_A_AccountsCostCenterList_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] ADD  CONSTRAINT [DF_A_AccountsCostCenterList_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] ADD  CONSTRAINT [DF_A_AccountsCostCenterList_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] ADD  CONSTRAINT [DF_A_AccountsCostCenterList_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_BranchID]  DEFAULT ((1)) FOR [BranchID]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_anydesk.com/download]  DEFAULT ((0)) FOR [DepitOpenBalance]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_CreditOpenBalance]  DEFAULT ((0)) FOR [CreditOpenBalance]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_AccountsList] ADD  CONSTRAINT [DF_A_AccountsList_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormActions] ADD  CONSTRAINT [DF_A_Auto_Config_FormActions_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormActions] ADD  CONSTRAINT [DF_A_Auto_Config_FormActions_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormActions] ADD  CONSTRAINT [DF_A_Auto_Config_FormActions_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormFields] ADD  CONSTRAINT [DF_A_Auto_Config_FormFields_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormFields] ADD  CONSTRAINT [DF_A_Auto_Config_FormFields_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormFields] ADD  CONSTRAINT [DF_A_Auto_Config_FormFields_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormGroups] ADD  CONSTRAINT [DF_A_Auto_Config_FormGroups_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormGroups] ADD  CONSTRAINT [DF_A_Auto_Config_FormGroups_DisplayOrder]  DEFAULT ((255)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormGroups] ADD  CONSTRAINT [DF_A_Auto_Config_FormGroups_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormGroups] ADD  CONSTRAINT [DF_A_Auto_Config_FormGroups_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Auto_Config_FormGroups] ADD  CONSTRAINT [DF_A_Auto_Config_FormGroups_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_ActionID]  DEFAULT ((0)) FOR [ActionID]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_IsDebit]  DEFAULT ((1)) FOR [IsDebit]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_AccountFromTree]  DEFAULT ((1)) FOR [AccountFromTree]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_NoSubAccount]  DEFAULT ((0)) FOR [NoSubAccount]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_SubAccountFromTree]  DEFAULT ((1)) FOR [SubAccountFromTree]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] ADD  CONSTRAINT [DF_A_Auto_EngingCore_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink] ADD  CONSTRAINT [DF_A_Auto_FormsGroupLink_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink] ADD  CONSTRAINT [DF_A_Auto_FormsGroupLink_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink] ADD  CONSTRAINT [DF_A_Auto_FormsGroupLink_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink] ADD  CONSTRAINT [DF_A_Auto_FormsGroupLink_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_CCentersJoinDetails] ADD  CONSTRAINT [DF_A_CCentersJoinDetails_Weighet]  DEFAULT ((0)) FOR [Weighet]
GO
ALTER TABLE [dbo].[A_CCentersJoinDetails] ADD  CONSTRAINT [DF_A_CCentersJoinDetails_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_CCentersJoinDetails] ADD  CONSTRAINT [DF_A_CCentersJoinDetails_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_CCentersJoinDetails] ADD  CONSTRAINT [DF_A_CCentersJoinDetails_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Config_AccountsTypes] ADD  CONSTRAINT [DF_A_Config_AccountsTypes_IsTopLevel]  DEFAULT ((0)) FOR [IsTopLevel]
GO
ALTER TABLE [dbo].[A_Config_AccountsTypes] ADD  CONSTRAINT [DF_A_AccountsTypes_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Config_AccountsTypes] ADD  CONSTRAINT [DF_A_AccountsTypes_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Config_AccountsTypes] ADD  CONSTRAINT [DF_A_AccountsTypes_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Config_ListEquation] ADD  CONSTRAINT [DF_A_Config_ListEquation_IsPositive]  DEFAULT ((1)) FOR [IsPositive]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_TotalDebit]  DEFAULT ((0)) FOR [TotalDebit]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_TotalCredit]  DEFAULT ((0)) FOR [TotalCredit]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_Approved]  DEFAULT ((0)) FOR [Approved]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_JournalBasic] ADD  CONSTRAINT [DF_A_JournalBasic_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_Debit]  DEFAULT ((0)) FOR [Debit]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_Credit]  DEFAULT ((0)) FOR [Credit]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_LocalDebit]  DEFAULT ((0)) FOR [LocalDebit]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_LocalCredit]  DEFAULT ((0)) FOR [LocalCredit]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] ADD  CONSTRAINT [DF_A_JournalEntryDetails_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable] ADD  CONSTRAINT [DF_A_Lup_ExchangeRateRefTable_IsCurrentRate]  DEFAULT ((1)) FOR [IsCurrentRate]
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable] ADD  CONSTRAINT [DF_A_Lup_ExchangeRateRefTable_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable] ADD  CONSTRAINT [DF_A_Lup_ExchangeRateRefTable_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable] ADD  CONSTRAINT [DF_A_Lup_ExchangeRateRefTable_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_Lup_JETypes] ADD  CONSTRAINT [DF_A_Lup_JETypes_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_Lup_JETypes] ADD  CONSTRAINT [DF_A_Lup_JETypes_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_Lup_JETypes] ADD  CONSTRAINT [DF_A_Lup_JETypes_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] ADD  CONSTRAINT [DF_A_SubAccountsJoinDetails_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] ADD  CONSTRAINT [DF_A_SubAccountsJoinDetails_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] ADD  CONSTRAINT [DF_A_SubAccountsJoinDetails_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_DepitOpenBalance]  DEFAULT ((0)) FOR [DepitOpenBalance]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_CreditOpenBalance]  DEFAULT ((0)) FOR [CreditOpenBalance]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[A_SubAccountsList] ADD  CONSTRAINT [DF_A_SubAccountsList_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_CapitalCost]  DEFAULT ((0)) FOR [CapitalCost]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_StartDepsCurrentValue]  DEFAULT ((0)) FOR [StartDepsCurrentValue]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_ScrapValue]  DEFAULT ((0)) FOR [ScrapValue]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[AST_AssetsBasic] ADD  CONSTRAINT [DF_AST_AssetsBasic_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[AST_Groups] ADD  CONSTRAINT [DF_AST_Groups_GroupDepreciationPercentage]  DEFAULT ((0)) FOR [GroupDepreciationPercentage]
GO
ALTER TABLE [dbo].[AST_Groups] ADD  CONSTRAINT [DF_AST_Groups_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[AST_Groups] ADD  CONSTRAINT [DF_AST_Groups_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[AST_Groups] ADD  CONSTRAINT [DF_AST_Groups_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[AST_Lup_AssetsState] ADD  CONSTRAINT [DF_AST_Lup_AssetsState_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[AST_Lup_AssetsState] ADD  CONSTRAINT [DF_AST_Lup_AssetsState_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[AST_Lup_AssetsState] ADD  CONSTRAINT [DF_AST_Lup_AssetsState_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Col_DomainsDataBasic] ADD  CONSTRAINT [DF_Col_DomainsDataBasic_RecordVersion]  DEFAULT ((1)) FOR [RecordVersion]
GO
ALTER TABLE [dbo].[Col_DomainsDataBasic] ADD  CONSTRAINT [DF_Col_DomainsDataBasic_Payment]  DEFAULT ((0)) FOR [Payment]
GO
ALTER TABLE [dbo].[Col_DomainsDataPK] ADD  CONSTRAINT [DF_Col_DomainsDataPK_DomainStatus]  DEFAULT ((1)) FOR [DomainStatus]
GO
ALTER TABLE [dbo].[Col_DomainsDataPK] ADD  CONSTRAINT [DF_Col_DomainsDataPK_CurrentVersion]  DEFAULT ((1)) FOR [CurrentVersion]
GO
ALTER TABLE [dbo].[Col_DomainsSchemaBasic] ADD  CONSTRAINT [DF_Col_DomainsSchemaBasic_SchemaDirection]  DEFAULT ((1)) FOR [SchemaDirection]
GO
ALTER TABLE [dbo].[Col_DomainsSchemaBasic] ADD  CONSTRAINT [DF_Col_DomainsSchemaBasic_Limit2Owner]  DEFAULT ((1)) FOR [Limit2Owner]
GO
ALTER TABLE [dbo].[Col_DomainsSchemaBasic] ADD  CONSTRAINT [DF_Col_DomainsSchemaBasic_Limit2OwnerGroup]  DEFAULT ((1)) FOR [Limit2OwnerGroup]
GO
ALTER TABLE [dbo].[Col_DomainsSchemaBasic] ADD  CONSTRAINT [DF_Col_DomainsSchemaBasic_Limit2OwnerOffice]  DEFAULT ((1)) FOR [Limit2OwnerOffice]
GO
ALTER TABLE [dbo].[HR_Emp_BasicInfo] ADD  CONSTRAINT [DF_HR_Emp_BasicInfo_IsActive1]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[HR_Emp_BasicInfo] ADD  CONSTRAINT [DF__HR_Emp_Ba__IsDel1__42ECDBF6]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[HR_Emp_BasicInfo] ADD  CONSTRAINT [DF__HR_Emp_Ba__IsDel1__43E1002F]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[HR_Emp_BasicInfo] ADD  CONSTRAINT [DF__HR_Emp_Ba__RCDat1__44D52468]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[HR_Lup_BankList] ADD  CONSTRAINT [DF__HR_Lup_Ba__IsDel__6FF48C97]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[HR_Lup_BankList] ADD  CONSTRAINT [DF__HR_Lup_Ba__IsDel__70E8B0D0]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[HR_Lup_BankList] ADD  CONSTRAINT [DF__HR_Lup_Ba__RCDat__71DCD509]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Lup_BranchList] ADD  CONSTRAINT [DF_Lup_BranchList_RCDate]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Lup_currencyTypes] ADD  CONSTRAINT [DF_Lup_currencyTypes_IsDefault]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[Lup_currencyTypes] ADD  CONSTRAINT [DF_Lup_currencyTypes_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Lup_currencyTypes] ADD  CONSTRAINT [DF_Lup_currencyTypes_IsDeletable]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Lup_currencyTypes] ADD  CONSTRAINT [DF_Lup_currencyTypes_RCDate]  DEFAULT (getdate()) FOR [RCDate]
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
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF_Pre_Users_IsDoctor]  DEFAULT ((0)) FOR [IsDoctor]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF_Pre_Users_DoctorID]  DEFAULT ((0)) FOR [DoctorID]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__IsDel__573DED66]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__IsDel__5832119F]  DEFAULT ((1)) FOR [IsDeletable]
GO
ALTER TABLE [dbo].[Pre_Users] ADD  CONSTRAINT [DF__Pre_Users__RCDat__592635D8]  DEFAULT (getdate()) FOR [RCDate]
GO
ALTER TABLE [dbo].[Pre_UserStatus] ADD  CONSTRAINT [DF_Pre_UserStatus_IsOnline]  DEFAULT ((0)) FOR [IsOnline]
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList]  WITH CHECK ADD  CONSTRAINT [FK_A_AccountsCostCenterList_A_AccountsCostCenterList1] FOREIGN KEY([ParentID])
REFERENCES [dbo].[A_AccountsCostCenterList] ([CostCenterAccountID])
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] CHECK CONSTRAINT [FK_A_AccountsCostCenterList_A_AccountsCostCenterList1]
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList]  WITH CHECK ADD  CONSTRAINT [FK_A_AccountsCostCenterList_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[A_AccountsCostCenterList] CHECK CONSTRAINT [FK_A_AccountsCostCenterList_Lup_BranchList]
GO
ALTER TABLE [dbo].[A_AccountsList]  WITH CHECK ADD  CONSTRAINT [FK_A_AccountsList_A_AccountsList] FOREIGN KEY([ParentID])
REFERENCES [dbo].[A_AccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_AccountsList] CHECK CONSTRAINT [FK_A_AccountsList_A_AccountsList]
GO
ALTER TABLE [dbo].[A_AccountsList]  WITH CHECK ADD  CONSTRAINT [FK_A_AccountsList_A_Config_AccountsTypes] FOREIGN KEY([AccountTypeID])
REFERENCES [dbo].[A_Config_AccountsTypes] ([AccountTypeID])
GO
ALTER TABLE [dbo].[A_AccountsList] CHECK CONSTRAINT [FK_A_AccountsList_A_Config_AccountsTypes]
GO
ALTER TABLE [dbo].[A_AccountsList]  WITH CHECK ADD  CONSTRAINT [FK_A_AccountsList_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[A_AccountsList] CHECK CONSTRAINT [FK_A_AccountsList_Lup_BranchList]
GO
ALTER TABLE [dbo].[A_Auto_EngingCore]  WITH CHECK ADD  CONSTRAINT [FK_A_Auto_EngingCore_A_Auto_Config_FormActions] FOREIGN KEY([ActionID])
REFERENCES [dbo].[A_Auto_Config_FormActions] ([ActionID])
GO
ALTER TABLE [dbo].[A_Auto_EngingCore] CHECK CONSTRAINT [FK_A_Auto_EngingCore_A_Auto_Config_FormActions]
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink]  WITH CHECK ADD  CONSTRAINT [FK_A_Auto_FormsGroupLink_A_Auto_Config_FormGroups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[A_Auto_Config_FormGroups] ([FormGrouID])
GO
ALTER TABLE [dbo].[A_Auto_FormsGroupLink] CHECK CONSTRAINT [FK_A_Auto_FormsGroupLink_A_Auto_Config_FormGroups]
GO
ALTER TABLE [dbo].[A_Config_ListEquation]  WITH CHECK ADD  CONSTRAINT [FK_A_Config_ListEquation_A_AccountsList] FOREIGN KEY([AccountID])
REFERENCES [dbo].[A_AccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_Config_ListEquation] CHECK CONSTRAINT [FK_A_Config_ListEquation_A_AccountsList]
GO
ALTER TABLE [dbo].[A_Config_ListEquation]  WITH CHECK ADD  CONSTRAINT [FK_A_Config_ListEquation_A_Config_ListNodes] FOREIGN KEY([NodeID])
REFERENCES [dbo].[A_Config_ListNodes] ([NodeID])
GO
ALTER TABLE [dbo].[A_Config_ListEquation] CHECK CONSTRAINT [FK_A_Config_ListEquation_A_Config_ListNodes]
GO
ALTER TABLE [dbo].[A_JournalBasic]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalBasic_A_Lup_JETypes] FOREIGN KEY([EntryTypeID])
REFERENCES [dbo].[A_Lup_JETypes] ([JETypeID])
GO
ALTER TABLE [dbo].[A_JournalBasic] CHECK CONSTRAINT [FK_A_JournalBasic_A_Lup_JETypes]
GO
ALTER TABLE [dbo].[A_JournalBasic]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalBasic_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[A_JournalBasic] CHECK CONSTRAINT [FK_A_JournalBasic_Lup_BranchList]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalEntryDetails_A_AccountsCostCenterList] FOREIGN KEY([CostCenterID])
REFERENCES [dbo].[A_AccountsCostCenterList] ([CostCenterAccountID])
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] CHECK CONSTRAINT [FK_A_JournalEntryDetails_A_AccountsCostCenterList]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalEntryDetails_A_AccountsList] FOREIGN KEY([AccountID])
REFERENCES [dbo].[A_AccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] CHECK CONSTRAINT [FK_A_JournalEntryDetails_A_AccountsList]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalEntryDetails_A_JournalBasic] FOREIGN KEY([JEMasterID])
REFERENCES [dbo].[A_JournalBasic] ([EID])
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] CHECK CONSTRAINT [FK_A_JournalEntryDetails_A_JournalBasic]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalEntryDetails_A_SubAccountsList] FOREIGN KEY([SubAccountID])
REFERENCES [dbo].[A_SubAccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] CHECK CONSTRAINT [FK_A_JournalEntryDetails_A_SubAccountsList]
GO
ALTER TABLE [dbo].[A_JournalEntryDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_JournalEntryDetails_Lup_currencyTypes] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Lup_currencyTypes] ([currncyTypeID])
GO
ALTER TABLE [dbo].[A_JournalEntryDetails] CHECK CONSTRAINT [FK_A_JournalEntryDetails_Lup_currencyTypes]
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable]  WITH CHECK ADD  CONSTRAINT [FK_A_Lup_ExchangeRateRefTable_Lup_currencyTypes] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Lup_currencyTypes] ([currncyTypeID])
GO
ALTER TABLE [dbo].[A_Lup_ExchangeRateRefTable] CHECK CONSTRAINT [FK_A_Lup_ExchangeRateRefTable_Lup_currencyTypes]
GO
ALTER TABLE [dbo].[A_Lup_JETypes]  WITH CHECK ADD  CONSTRAINT [FK_A_Lup_JETypes_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[A_Lup_JETypes] CHECK CONSTRAINT [FK_A_Lup_JETypes_Lup_BranchList]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_SubAccountsJoinDetails_A_AccountsList] FOREIGN KEY([AccountID])
REFERENCES [dbo].[A_AccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] CHECK CONSTRAINT [FK_A_SubAccountsJoinDetails_A_AccountsList]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_SubAccountsJoinDetails_A_SubAccountsList] FOREIGN KEY([SubAccountID])
REFERENCES [dbo].[A_SubAccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] CHECK CONSTRAINT [FK_A_SubAccountsJoinDetails_A_SubAccountsList]
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails]  WITH CHECK ADD  CONSTRAINT [FK_A_SubAccountsJoinDetails_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[A_SubAccountsJoinDetails] CHECK CONSTRAINT [FK_A_SubAccountsJoinDetails_Lup_BranchList]
GO
ALTER TABLE [dbo].[A_SubAccountsList]  WITH CHECK ADD  CONSTRAINT [FK_A_SubAccountsList_A_Config_AccountsTypes] FOREIGN KEY([AccountTypeID])
REFERENCES [dbo].[A_Config_AccountsTypes] ([AccountTypeID])
GO
ALTER TABLE [dbo].[A_SubAccountsList] CHECK CONSTRAINT [FK_A_SubAccountsList_A_Config_AccountsTypes]
GO
ALTER TABLE [dbo].[A_SubAccountsList]  WITH CHECK ADD  CONSTRAINT [FK_A_SubAccountsList_A_SubAccountsList] FOREIGN KEY([ParentID])
REFERENCES [dbo].[A_SubAccountsList] ([AccountID])
GO
ALTER TABLE [dbo].[A_SubAccountsList] CHECK CONSTRAINT [FK_A_SubAccountsList_A_SubAccountsList]
GO
ALTER TABLE [dbo].[AST_AssetsBasic]  WITH CHECK ADD  CONSTRAINT [FK_AST_AssetsBasic_Lup_BranchList] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Lup_BranchList] ([BranchID])
GO
ALTER TABLE [dbo].[AST_AssetsBasic] CHECK CONSTRAINT [FK_AST_AssetsBasic_Lup_BranchList]
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTarget]  WITH CHECK ADD  CONSTRAINT [FK_Col_Bsk_MonthlyTarget_Col_DomainsDataPK] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Col_DomainsDataPK] ([DomainSerial])
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTarget] CHECK CONSTRAINT [FK_Col_Bsk_MonthlyTarget_Col_DomainsDataPK]
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTarget]  WITH CHECK ADD  CONSTRAINT [FK_Col_Bsk_MonthlyTarget_Col_Lup_MonthList] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Col_Lup_MonthList] ([MonthID])
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTarget] CHECK CONSTRAINT [FK_Col_Bsk_MonthlyTarget_Col_Lup_MonthList]
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTargetDetails]  WITH CHECK ADD  CONSTRAINT [FK_Col_Bsk_MonthlyTargetDetails_Col_Bsk_MonthlyTarget] FOREIGN KEY([TargetID])
REFERENCES [dbo].[Col_Bsk_MonthlyTarget] ([TargetID])
GO
ALTER TABLE [dbo].[Col_Bsk_MonthlyTargetDetails] CHECK CONSTRAINT [FK_Col_Bsk_MonthlyTargetDetails_Col_Bsk_MonthlyTarget]
GO
ALTER TABLE [dbo].[Col_DailyVisits]  WITH CHECK ADD  CONSTRAINT [FK_Col_DailyVisits_Col_DomainsDataExtra] FOREIGN KEY([PointToRecord])
REFERENCES [dbo].[Col_DomainsDataBasic] ([RecordSerial])
GO
ALTER TABLE [dbo].[Col_DailyVisits] CHECK CONSTRAINT [FK_Col_DailyVisits_Col_DomainsDataExtra]
GO
ALTER TABLE [dbo].[Col_DailyVisits]  WITH CHECK ADD  CONSTRAINT [FK_Col_DailyVisits_Col_Lup_TeamMembers] FOREIGN KEY([Collector])
REFERENCES [dbo].[Col_Lup_TeamMembers] ([RecordID])
GO
ALTER TABLE [dbo].[Col_DailyVisits] CHECK CONSTRAINT [FK_Col_DailyVisits_Col_Lup_TeamMembers]
GO
ALTER TABLE [dbo].[Col_DomainsDataExtra]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsDataExtra_Col_DomainsDataBasic] FOREIGN KEY([ShortLineID])
REFERENCES [dbo].[Col_DomainsDataBasic] ([RecordSerial])
GO
ALTER TABLE [dbo].[Col_DomainsDataExtra] CHECK CONSTRAINT [FK_Col_DomainsDataExtra_Col_DomainsDataBasic]
GO
ALTER TABLE [dbo].[Col_DomainsDataExtra]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsDataExtra_Col_DomainsDataPK] FOREIGN KEY([DomainID])
REFERENCES [dbo].[Col_DomainsDataPK] ([DomainSerial])
GO
ALTER TABLE [dbo].[Col_DomainsDataExtra] CHECK CONSTRAINT [FK_Col_DomainsDataExtra_Col_DomainsDataPK]
GO
ALTER TABLE [dbo].[Col_DomainsDataPK]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsDataPK_Col_Lup_MonthList] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Col_Lup_MonthList] ([MonthID])
GO
ALTER TABLE [dbo].[Col_DomainsDataPK] CHECK CONSTRAINT [FK_Col_DomainsDataPK_Col_Lup_MonthList]
GO
ALTER TABLE [dbo].[Col_DomainsDataPK]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsPK_Col_DomainsCType] FOREIGN KEY([DomainType])
REFERENCES [dbo].[Col_Lup_DomainsType] ([DomainTypeID])
GO
ALTER TABLE [dbo].[Col_DomainsDataPK] CHECK CONSTRAINT [FK_Col_DomainsPK_Col_DomainsCType]
GO
ALTER TABLE [dbo].[Col_DomainsDataPK]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsPK_Col_DomainsSchemaBasic] FOREIGN KEY([DomainSchema])
REFERENCES [dbo].[Col_DomainsSchemaBasic] ([SchemaID])
GO
ALTER TABLE [dbo].[Col_DomainsDataPK] CHECK CONSTRAINT [FK_Col_DomainsPK_Col_DomainsSchemaBasic]
GO
ALTER TABLE [dbo].[Col_DomainsSchemaExtra]  WITH CHECK ADD  CONSTRAINT [FK_Col_DomainsSchemaExtra_Col_DomainsSchemaBasic] FOREIGN KEY([SchemaID])
REFERENCES [dbo].[Col_DomainsSchemaBasic] ([SchemaID])
GO
ALTER TABLE [dbo].[Col_DomainsSchemaExtra] CHECK CONSTRAINT [FK_Col_DomainsSchemaExtra_Col_DomainsSchemaBasic]
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_Col_Lup_TeamMembers_Col_Lup_TeamList] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Col_Lup_TeamList] ([TeamID])
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers] CHECK CONSTRAINT [FK_Col_Lup_TeamMembers_Col_Lup_TeamList]
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_Col_Lup_TeamMembers_Col_lup_TeamRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Col_lup_TeamRole] ([RoleID])
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers] CHECK CONSTRAINT [FK_Col_Lup_TeamMembers_Col_lup_TeamRole]
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_Col_Lup_TeamMembers_HR_Emp_BasicInfo] FOREIGN KEY([MemberID])
REFERENCES [dbo].[HR_Emp_BasicInfo] ([EmployeeID])
GO
ALTER TABLE [dbo].[Col_Lup_TeamMembers] CHECK CONSTRAINT [FK_Col_Lup_TeamMembers_HR_Emp_BasicInfo]
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Finger Print No.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HR_Emp_BasicInfo', @level2type=N'COLUMN',@level2name=N'EmployeeFPNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'(1) already working (0) will start work in future' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HR_Emp_BasicInfo', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[32] 2[10] 3) )"
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
         Begin Table = "Col_DomainsDataBasic"
            Begin Extent = 
               Top = 0
               Left = 172
               Bottom = 229
               Right = 447
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Col_CompareDomainSummaryByBucket'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Col_CompareDomainSummaryByBucket'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[27] 4[35] 2[13] 3) )"
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
         Begin Table = "Col_DailyVisits"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 184
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Col_DomainsDataBasic"
            Begin Extent = 
               Top = 6
               Left = 310
               Bottom = 179
               Right = 640
            End
            DisplayFlags = 344
            TopColumn = 0
         End
         Begin Table = "Col_Lup_TeamMembers"
            Begin Extent = 
               Top = 20
               Left = 571
               Bottom = 140
               Right = 731
            End
            DisplayFlags = 344
            TopColumn = 1
         End
         Begin Table = "HR_Emp_BasicInfo"
            Begin Extent = 
               Top = 6
               Left = 769
               Bottom = 126
               Right = 964
            End
            DisplayFlags = 344
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
         Width = 1200
         Width = 885
         Width = 1425
         Width = 1500
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
         Column = 3210
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 117' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Col_DCRFullView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Col_DCRFullView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Col_DCRFullView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[36] 2[20] 3) )"
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
         Begin Table = "Pre_GroupPermissions"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 161
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_Actions"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 126
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_FormList"
            Begin Extent = 
               Top = 101
               Left = 495
               Bottom = 221
               Right = 655
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Per_GroupPermissionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Per_GroupPermissionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[30] 2[11] 3) )"
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
         Begin Table = "Pre_GroupPermissions"
            Begin Extent = 
               Top = 0
               Left = 20
               Bottom = 205
               Right = 362
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_GroupsMembers"
            Begin Extent = 
               Top = 6
               Left = 400
               Bottom = 136
               Right = 570
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
         Table = 1995
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_AccessPremissionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_AccessPremissionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[37] 2[15] 3) )"
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
         Begin Table = "Pre_Actions"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 179
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_FormActions"
            Begin Extent = 
               Top = 4
               Left = 336
               Bottom = 109
               Right = 605
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
         Width = 1545
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_FormActionsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_FormActionsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[37] 2[13] 3) )"
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
               Top = 0
               Left = 270
               Bottom = 170
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_GroupsMembers"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
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
         Column = 3330
         Alias = 900
         Table = 1875
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_GroupMemebersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_GroupMemebersView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[32] 2[20] 3) )"
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
         Begin Table = "Pre_ModuleForms"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 176
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pre_FormList"
            Begin Extent = 
               Top = 12
               Left = 316
               Bottom = 132
               Right = 476
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_ModuleFormsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pre_ModuleFormsView'
GO
USE [master]
GO
ALTER DATABASE [TMSData2] SET  READ_WRITE 
GO
