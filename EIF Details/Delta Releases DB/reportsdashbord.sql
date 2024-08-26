insert into  dbo.Design_MenuBasic(SectionID,MenuTitle,DisplayID,IsDeleted,IsDeletable,LADate,RCDate)
values(1,'Reports',4,'false','true',GETDATE(),GETDATE())
​
declare  @menuId as smallint
select @menuId= MenuID from  dbo.Design_MenuBasic where MenuTitle='Reports'

​
insert into dbo.LicensedFunctions values ('Supervisor productivity Monthly and yearly',
'Supervisorproductivity-monthlyandyearly','Reports',1,'/collection/GetTeamLeadersReport')
​
insert into dbo.LicensedFunctions values ('Collector productivity Monthly And yearly',
'totalproductivity-monthlyandyearly','Reports',1,'/collection/GetReportCollector')
​
insert into dbo.LicensedFunctions values ('Amounts Collected From Alex And Cairo Team',
'AmountsCollectedFromAllAlexaAndCairoTeam','Reports',1,'/collection/GetPayment')
​
insert into dbo.LicensedFunctions values ('Productivity Of Alex And Cairo Team',
'TheProductivityOfAlexAndCairo','Reports',1,'/collection/GetPaymentReport')
​
insert into dbo.LicensedFunctions values ('Percentage Of Each Collector Per Domain And Team',
'PercentageOfEachCollectorPerDomainAndTheRest','Reports',1,'/collection/GetPaymentPerBank')
​
insert into dbo.LicensedFunctions values ('Clients percentage have Lawsuits And Not have',
'ClientspercentageAgainstLawsuitsFiledAndNot','Reports',1,'/collection/GetLegalPaymentPerBank')

insert into dbo.LicensedFunctions values ('Daily Collected Numbers Per Branch',
'DailyCollectedNumbers','Reports',1,'/collection/GetDailyReportPerBranch')
​
​
​
​
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Collector productivity Monthly And yearly','collection','GetReportCollector',1,'false','true',GETDATE(),GETDATE())
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Supervisor productivity Monthly and yearly','collection','GetTeamLeadersReport',2,'false','true',GETDATE(),GETDATE())

insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Amounts Collected From Alex And Cairo Team','collection','GetPayment',3,'false','true',GETDATE(),GETDATE())
​
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Productivity Of Alex And Cairo Team','collection','GetPaymentReport',4,'false','true',GETDATE(),GETDATE())
​
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Percentage Of Each Collector Per Domain And Team','collection','GetPaymentPerBank',5,'false','true',GETDATE(),GETDATE())
​
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Clients percentage have Lawsuits And Not have','collection','GetLegalPaymentPerBank',6,'false','true',GETDATE(),GETDATE())
​
insert into dbo.Design_MenuItems(MenuID,SectionID,MenuItemName,ControllerName,ActionName,DisplayID,IsDeleted,IsDeletable,RCDate,LADate)
values(@menuId,1,'Daily Collected Numbers Per Branch','collection','GetDailyReportPerBranch',7,'false','true',GETDATE(),GETDATE())



