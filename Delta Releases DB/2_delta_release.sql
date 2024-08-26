create nonclustered index  monthyear on Dom_AccountsPayments (paymentdate)
create nonclustered index  schema_index on Dom_DomainsDataExtra (schemaid)

create nonclustered index  domain_index  on Dom_DomainsDataExtra (domainid)

create nonclustered index  monthyear_index  on lup_monthyear (monthyear)

CREATE NONCLUSTERED INDEX paymentindex ON Dom_AccountsPayments(RecordSerial)

go 

ALTER   procedure [dbo].[Reports_GetNames]  @textSearch as NVARCHAR(max) ,@t as NVARCHAR(20)
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
if @t='Collector Code'
select distinct * from #tableCol1   where names  not like '%.%'  and names  not like '%,%' and names  like  @textSearch+'%' 
else
 select distinct * from #tableCol1   where names is not null and names like  @textSearch+'%' 

drop table #tableCol1
drop table #tableCol

end
GO
INSERT INTO dbo.Sch_Columns
VALUES ('Team Leader Code', 'Text', 'false','true'),
  (' deputy Team Leader Code', 'Text', 'false','true'),
   ('deputy Team Leader Name', 'Text', 'false','true'),
	 ('Owner', 'Text', 'true','false')
go	 
	 
UPDATE Sch_Columns
SET ColumnName = 'Team Leader Name', IsDeleteable='false'
WHERE ColumnName='Team Leader';
go
 UPDATE Sch_Columns
SET IsDeleteable='false',IsFixed='true'
WHERE ColumnName='Legal Action';

go

	
