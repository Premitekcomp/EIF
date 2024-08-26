CREATE TABLE CollectorNames (
    Id int identity(1,1),
    CollecterName NVARCHAR(max),
);

CREATE TABLE CollectorCodes (
    Id int identity(1,1),
    CollecterCode NVARCHAR(max),
);

CREATE TABLE TeamLeaders (
    Id int identity(1,1),
    TeamLeaderName NVARCHAR(max),
);


go 

ALTER   procedure [dbo].[Reports_GetNames]  @textSearch as NVARCHAR(max) ,@t as NVARCHAR(20)
as

if @t='Collector Code'

 select  CollecterCode from CollectorCodes   where CollecterCode is not null and CollecterCode like  @textSearch+'%' 

 if @t='Collector Name'

select  CollecterName from CollectorNames where  CollecterName is not null and CollecterName like  @textSearch+'%' 


  if @t='Team Leader'

  select  TeamLeaderName from TeamLeaders where  TeamLeaderName is not null and TeamLeaderName like  @textSearch+'%' 
  
GO

declare @count int;
declare @schemaid tinyint ;
declare @colName NVARCHAR(50);
declare @columnnme NVARCHAR(50);
declare @query NVARCHAR(max);
DECLARE @cnt INT

create table #tableCol  (id int identity(1,1), schemaid tinyint)

insert into #tableCol

select distinct c.SchemaID from
Sch_SchemaColList as c where ColumnName='Collector Name'
 
--declare @count int;
--declare @schemaid tinyint ;
--declare @colName NVARCHAR(50);
--declare @columnnme NVARCHAR(50);
--declare @query NVARCHAR(max);
--DECLARE @cnt INT
select @count= count(id) from #tableCol
select @count

set  @cnt  = 1;

WHILE @cnt <= @count
BEGIN

select  @schemaid=  schemaid from #tableCol where @cnt=id
select  @colName=  c.ColumnIndex from  Dom_DomainsDataExtra as a join Sch_SchemaColList as c  on c.SchemaID=a.SchemaID
where c.ColumnIndex is not null and c.ColumnName='Collector Name' and c.SchemaID=@schemaid
select @columnnme= cast( CONCAT('col',@colName) as NVARCHAR(max))
set @query ='   insert into CollectorNames  '+
'select DISTINCT   '+ @columnnme +'     from Dom_DomainsDataExtra where SchemaID='+ cast (@schemaid as nvarchar(50))

execute( @query)
  SET @cnt = @cnt + 1;
END;



drop table   #tableCol 






















create table #tableCol1  (id int identity(1,1), schemaid tinyint)

insert into #tableCol1

select distinct c.SchemaID from
Sch_SchemaColList as c where ColumnName='Team Leader'
 
declare @count1 int;
declare @schemaid1 tinyint ;
declare @colName1 NVARCHAR(50);
declare @columnnme1 NVARCHAR(50);


select @count1= count(id) from #tableCol1



set  @cnt  = 1;

WHILE @cnt <= @count1
BEGIN


select  @schemaid1=  schemaid from #tableCol1 where @cnt=id
select  @colName1=  c.ColumnIndex from  Dom_DomainsDataExtra as a join Sch_SchemaColList as c  on c.SchemaID=a.SchemaID
where c.ColumnIndex is not null and c.ColumnName='Team Leader' and c.SchemaID=@schemaid1
select @columnnme1= cast( CONCAT('col',@colName1) as NVARCHAR(max))
set @query ='   insert into TeamLeaders  '+
'select DISTINCT   '+ @columnnme1 +'     from Dom_DomainsDataExtra where SchemaID='+ cast (@schemaid1 as nvarchar(50))


execute( @query)
  SET @cnt = @cnt + 1;
END;

 

 drop table #tableCol1 










 create table #tableCol2  (id int identity(1,1), schemaid tinyint)


insert into #tableCol2

select distinct c.SchemaID from
Sch_SchemaColList as c where ColumnName='Collector Code'
 
declare @count2 int;
declare @schemaid2 tinyint ;
declare @colName2 NVARCHAR(50);
declare @columnnme2 NVARCHAR(50);
--declare @query NVARCHAR(max);
select @count2= count(id) from #tableCol2


set @cnt  = 1;

WHILE @cnt <= @count2
BEGIN

select  @schemaid2=  schemaid from #tableCol2 where @cnt=id
select  @colName2=  c.ColumnIndex from  Dom_DomainsDataExtra as a join Sch_SchemaColList as c  on c.SchemaID=a.SchemaID
where c.ColumnIndex is not null and c.ColumnName='Collector Code' and c.SchemaID=@schemaid2
select @columnnme2= cast( CONCAT('col',@colName2) as NVARCHAR(max))
set @query ='   insert into CollectorCodes  '+
'select DISTINCT   '+ @columnnme2 +'     from Dom_DomainsDataExtra where SchemaID='+ cast (@schemaid2 as nvarchar(50))

execute( @query)
  SET @cnt = @cnt + 1;
END;



drop table #tableCol2 
go




  


