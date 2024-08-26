--SM Begin----------------------------------
---------Transfer schema to colllection
USE [EIFCRM]
GO
----update old order  for display id Column

update Design_MenuItems
set DisplayID=DisplayID+1
-----
INSERT INTO [dbo].[Design_MenuItems]
           ([MenuID]
           ,[SectionID]
           ,[MenuItemName]
           ,[AreaName]
           ,[ControllerName]
           ,[ActionName]
           ,[IconClass]
           ,[DisplayID]
           ,[IsDeleted]
           ,[IsDeletable]
           ,[RCDate]
           ,[RCBy]
           ,[LADate]
           ,[LABy])
     VALUES
           (3---for Dashpord tab
           ,1
           ,N'Schema Management'
           ,NULL--<AreaName
           ,N'collection'
           ,N'SchemaManagement'
           , NULL --<IconClass, nvarchar(150),>
           ,1 --<DisplayID, tinyint,>
           ,0--<IsDeleted, bit,>
           ,1--<IsDeletable, bit,>------???
           ,'2018-04-16 15:06:55.767'--<RCDate, datetime,>
           ,NULL--<RCBy, int,>
           ,'2018-04-16 15:06:55.767'--<LADate, datetime,>
           ,NULL--<LABy, int,>
		   )
GO
----------End SM----

