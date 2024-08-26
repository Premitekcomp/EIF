INSERT INTO dbo.Pre_Groups(GroupTitle,IsActive,IsDeleted,IsDeletable,RCDate)
VALUES ( 'TeleCaller', 'True','false','true','2022-08-15');

insert into dbo.Sch_Columns values('Legal Action','Text','true','false')

 create table Pre_Offices(
    OfficeId tinyint identity,
    OfficeTitle nvarchar(100) NOT NULL,
    IsActive bit NOT NULL,
    IsDeleted bit NOT NULL,
    IsDeletable bit NOT NULL,
	RCDate  datetime,
	RCByD smallint,
	LADate datetime,
	LABy smallint,
	PRIMARY KEY (OfficeId)
);


create table Pre_OfficesMembers(
    RecordSerial smallint identity,
    UserID smallint NOT NULL FOREIGN KEY REFERENCES Pre_Users(UserId),
    OfficeID tinyint NOT NULL FOREIGN KEY REFERENCES Pre_Offices(OfficeId),
    IsDeleted bit NOT NULL DEFAULT 0,
    IsDeletable bit NOT NULL DEFAULT 0,
	RCDate  datetime,
	RCBy smallint,
	LADate datetime,
	LABy smallint,
	PRIMARY KEY (RecordSerial)
);


go

ALTER VIEW [dbo].[Pre_UsersView]
AS
SELECT        dbo.Pre_Users.UserID, dbo.Pre_Users.DisplayName, dbo.Pre_Users.BranchIDs , 
                             /*(SELECT        TOP (1) BranchID
                                FROM            dbo.Pre_BranchesPermissions
                                WHERE        (UserID = dbo.Pre_Users.UserID)) AS BranchID,*/
                             (SELECT        TOP (1) GroupID
                                FROM            dbo.Pre_GroupsMembers
                                WHERE        (UserID = dbo.Pre_Users.UserID) AND (IsDeleted = 0)) AS GroupID,
								 (SELECT        TOP (1) OfficeId
                                FROM            dbo.Pre_OfficesMembers
                                WHERE        (UserID = dbo.Pre_Users.UserID) AND (IsDeleted = 0)) AS OfficeId
								, dbo.Pre_UsersSections.Label AS SectionIDs,
								 dbo.Pre_Users.UserName, dbo.Pre_Users.ProfileImage
FROM            dbo.Pre_Users LEFT OUTER JOIN
                         dbo.Pre_UsersSections ON dbo.Pre_Users.UserID = dbo.Pre_UsersSections.UserID
WHERE        (dbo.Pre_Users.IsDeleted = 0)
GO




USE [EIFCRM]
GO
/****** Object:  StoredProcedure [dbo].[pre_UsersInsert]    Script Date: 7/24/2022 10:24:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




ALTER proc [dbo].[pre_UsersInsert]--[dbo].[pre_UsersInsert] 'test','test','test',null,1,1,'1',1,'1-1-2017',1


    (@DisplayName nvarchar(500) 
           ,@UserName nvarchar(500) 
           ,@Password varchar(50) 
		   ,@Image varbinary(max)  = null
		   ,@Group int
           ,@IsActive bit
		   ,@RCDate date
		   ,@RCBy int
		   , @branchids nvarchar(50),
		   @Office int
		    )
		   as

		    declare @Userid int

		   if @Image is null
		   begin
INSERT INTO [dbo].[Pre_Users]
           ([DisplayName]
           ,[UserName]
           ,[Password]
           ,[IsActive],[RCDate],[RCBy] , [BranchIDs])
     VALUES
           (@DisplayName  
           ,@UserName  
           ,CONVERT(varbinary(50),@Password) 
           ,@IsActive,@RCDate,@RCBy , @branchids )

		   end
		   else
		   begin

INSERT INTO [dbo].[Pre_Users]
           ([DisplayName]
           ,[UserName]
           ,[Password]
		   ,[ProfileImage]
           ,[IsActive],[RCDate],[RCBy] , [BranchIDs])
     VALUES
           (@DisplayName  
           ,@UserName  
           ,CONVERT(varbinary(50),@Password) 
		   ,@Image
           ,@IsActive,@RCDate,@RCBy , @branchids )		  


		   end

set @Userid =( select scope_identity())

if @Userid>1
begin
 /*INSERT INTO [dbo].[Pre_BranchesPermissions] ([BranchID] ,[UserID])  VALUES (@Branch,@Userid)*/
 
INSERT INTO [dbo].[Pre_GroupsMembers] ([UserID],[GroupID],[RCDate],[RCBy])  VALUES (@Userid,@Group,@RCDate,@RCBy)
INSERT INTO [dbo].[Pre_OfficesMembers] (UserID,OfficeID,RCDate,RCBy)  VALUES (@Userid,@Office,@RCDate,@RCBy)


/*DECLARE @Sec_Tbl TABLE (idx2 smallint Primary Key IDENTITY(1,1),SecID smallint)

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

	*/
     
   
 
end

GO
/****** Object:  StoredProcedure [dbo].[pre_UsersEdit]    Script Date: 7/24/2022 10:36:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




USE [EIFCRM]
GO

/****** Object:  StoredProcedure [dbo].[pre_UsersEdit]    Script Date: 8/2/2022 2:24:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[pre_UsersEdit] --[dbo].[pre_UsersEdit] 17, 'amina','amina',1,1,'2,4','1-1-2018',1


    (@ID smallint,@DisplayName nvarchar(500) 
           ,@UserName nvarchar(500)
		   ,@Group int
		   ,@LADate date
		   ,@LABy int
		   , @branchids nvarchar(50)
		   , @Office int		   
		   )
		   as

UPDATE [dbo].[Pre_Users]
   SET [DisplayName] = @DisplayName
      ,[UserName] = @UserName
	  ,LADate=@LADate
	  ,LABy=@LABy
	  ,BranchIDs = @branchids
	  
 WHERE  [UserID]=@ID

 /*UPDATE [dbo].[Pre_BranchesPermissions]  SET [BranchID] = @Branch WHERE  [UserID]=@ID*/

 UPDATE [dbo].[Pre_GroupsMembers] SET [GroupID] = @Group  ,LADate=@LADate  ,LABy=@LABy WHERE  [UserID]=@ID

 IF EXISTS (SELECT  [UserID] FROM Pre_OfficesMembers WHERE [UserID] =@ID) 
BEGIN
   UPDATE [dbo].[Pre_OfficesMembers] SET [OfficeID] = @Office  ,LADate=@LADate  ,LABy=@LABy WHERE  [UserID]=@ID 
END
ELSE
BEGIN
 INSERT INTO [dbo].[Pre_OfficesMembers] (UserID,OfficeID,RCDate,RCBy)  VALUES (@ID,@Office,@LADate,@LABy)   
END

 

 

 /*Begin transaction

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
DECLARE @SecID tinyint*/

/*SET @Init = 1
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
	End*/

/* If we reach this point, the commands 
completed successfully Commit the transaction
*/

--Commit
 
 --[dbo].[pre_UsersEdit] 17, 'amina','amina',1,1,'2,4','1-1-2018',1
GO
insert into Pre_Offices(OfficeTitle,IsActive,IsDeleted,IsDeletable,RCDate)
values('Alex Office',1,0,1,GETDATE()),
('Sharkia Office',1,0,1,GETDATE()),
('Port Said Office',1,0,1,GETDATE()),
('Aswan Office ',1,0,1,GETDATE()),
('Assuit Office',1,0,1,GETDATE()),
('Cairo Office ',1,0,1,GETDATE()),
('Qnna Office',1,0,1,GETDATE())
go


create  procedure [dbo].[Reports_GetNames]  @textSearch as NVARCHAR(max) ,@t as NVARCHAR(20)
as
set FMTONLY OFF;
SET NOCOUNT OFF
begin 

set FMTONLY OFF;

create table #tableCol  (val NVARCHAR(100))
create table #tableCol1  (names NVARCHAR(max))

declare @text1 NVARCHAR(100)=' like '+QUOTENAME(@textSearch+'%','''')+' or '
insert into #tableCol						
             select distinct  cast( CONCAT('col',c.ColumnIndex) as NVARCHAR(max))as namee from
Dom_DomainsDataExtra as a join Sch_SchemaColList as c  on c.SchemaID=a.SchemaID
where c.ColumnIndex is not null and c.ColumnName=@t
declare @cols NVARCHAR(MAX)
declare @colsCondation NVARCHAR(MAX)
select  @cols= STRING_AGG( val ,',' ) from #tableCol
select  @colsCondation= STRING_AGG( val ,@text1) from #tableCol

declare @sql NVARCHAR(max)
set @colsCondation=SUBSTRING(@colsCondation,0,LEN(@colsCondation)-6)

set @sql = '  insert into #tableCol1 select distinct col from (select '  + @cols+
  ' from  Dom_DomainsDataExtra as a  join  Sch_SchemaColList as c  on  c.SchemaID=a.SchemaID
and  c.ColumnIndex is not null and (' +@colsCondation+') and c.ColumnName= '+QUOTENAME(@t,'''')+') as  results '+
'UNPIVOT (col for cols in( '+@cols+' )) as result '


exec ( @sql)

select * from #tableCol1   where names like  @textSearch+'%'
drop table #tableCol1
drop table #tableCol

end