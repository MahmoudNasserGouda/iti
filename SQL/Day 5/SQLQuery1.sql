--Views: store select statment, reflects changes in tables
--can be used for different views for users, for security
--All DQL can be done
--DML: 
-------1. this view selects from 1 table only
-------2. this view selects all table columns
-------3. or missing columns should allow null or has default values
use [AdventureWorks]
go 
create View EmployeeManagerData as
select E.EmployeeID 'EMP ID', EC.FirstName 'EMP Name', E.Title 'EMP Title',
M.EmployeeID 'Manager ID', MC.FirstName 'Manager Name', M.Title 'Manager Title'
from [HumanResources].[Employee] as E
join [HumanResources].[Employee] as M
on E.ManagerID = M.EmployeeID
join [Person].[Contact] as EC
on E.ContactID = EC.ContactID
join [Person].[Contact] as MC
on M.ContactID = MC.ContactID

drop view EmployeeManagerData

select * from EmployeeManagerData

use [NetQ32023]
go
alter View FacultyView as
select [ID] 'Faculty ID'
, [DeanID] 'Faculty Dean'
from [dbo].[Faculty]

select * from FacultyView

insert into FacultyView values(19,1)

create view FacultData(FacultyID,FacultyName)as
select ID,Name from Faculty

select * from FacultData

alter view Faculty1Departments as
select * from [Manger].[Department]
where [FacultyID] = 1
with check option

select * from Faculty1Departments

insert into Faculty1Departments values(3,'Dept3',18,NULL)

-------------------------------------------------------------------------------------------
--Variables:
----Local Var: user define - declare @varname DT - set, select - select, print
----can't select other columns when assigning value to variable using select statment
declare @x int = 10, @name varchar(60)  
set @x = 10 
set @name = 'x'
select @x = 10

select @x, @name
print @x

declare @maxRate money = (select max([Rate]) from [AdventureWorks].[HumanResources].[EmployeePayHistory])
select @maxRate = max([Rate]) from [AdventureWorks].[HumanResources].[EmployeePayHistory]
print @maxRate

declare @maxRate money
set @maxRate = (select max([Rate]) from [AdventureWorks].[HumanResources].[EmployeePayHistory])
print @maxRate

declare @Title nvarchar(50)
(select distinct @Title = [Title] from AdventureWorks.HumanResources.Employee)
print @Title

declare @Title nvarchar(50), @EmpID int;
select top 1 @Title = [Title], @EmpID = EmployeeID from AdventureWorks.HumanResources.Employee
order by [VacationHours]
print @Title
print @EmpID

create type EmpTble as table (
	Title nvarchar(50),
	EmpID int
)

--declare @EmpData table (
--	Title nvarchar(50),
--	EmpID int
--)

declare @EmpData EmpTble

insert into @EmpData
select top 10 [Title], [EmployeeID]
from AdventureWorks.HumanResources.Employee
order by [VacationHours]

select Title,count(*) from @EmpData
group by Title

----Global Var: server - readonly - start with @@
select @@SERVERNAME -- name of current server
select @@IDENTITY -- value on identity column for last DML statment excuted

insert into Faculty1Departments values(3,'Dept3',18,NULL)
go
select @@ERROR -- error number happiens in the last statment executed

--Dynamic SQL:
use [AdventureWorks]
go
declare @ID int = 13, 
@source nvarchar(max) = '[AdventureWorks].HumanResources.Employee', 
@col1 nvarchar(max) = 'EmployeeID', 
@col2 nvarchar(max) = 'Title';
execute ('select '+ @col1+' , '+ @col2 +' from ' +@source +' where EmployeeID ='+ @ID)

select EmployeeID,Title from AdventureWorks.HumanResources.Employee where EmployeeID = 13
-------------------------------------------------------------------------------------------
--Tables:
----Physical table
----Table Data type
----Table Variable
----Temp Table: (tempdb) global ## (all sessions), local # (1 session)

create table #FacultyData
(
	FacultyID int,
	FacultyName nvarchar(50),
	DepartmentCount int
)

insert into #FacultyData 
select f.ID,f.Name, count(d.ID)
from Faculty as f,[Manger].[Department] as d
where f.ID = d.FacultyID
group by f.ID,f.Name

delete from #FacultyData

select * from #FacultyData

create table ##FacultyData
(
	FacultyID int,
	FacultyName nvarchar(50),
	DepartmentCount int
)

insert into ##FacultyData 
select f.ID,f.Name, count(d.ID)
from Faculty as f,[Manger].[Department] as d
where f.ID = d.FacultyID
group by f.ID,f.Name
-----------------------------------------------------------------------------------------
--Control of flow:
----conditions: select case col when x then y end, iif, if else, if exists, if not exists
----loops: while

--select case: switch
select [ProductID], [Name], case [MakeFlag] 
	when 1 then 'created'
	when 0 then 'not yet'
	end as 'MakeFlag'
	from [Production].[Product]


--if statment:
declare @colorcount table(
colorname nvarchar(15),
count int
)

insert into @colorcount
select Color, count(*) from [Production].[Product]
where Color is not null
group by [Color]

declare @topcolor nvarchar(15) = (select top 1 colorname from @colorcount order by [count])

--print @topcolor

if @topcolor = 'Black'
begin
	print 'Black is the trend now'
end
else if @topcolor = 'Grey'
	print 'its grey'
else
begin
	print 'colorful is the trend now'
end

--iif: trainary opertor in js
select [Name],iif([SafetyStockLevel]>500,'safe','not safe') from [Production].[Product]

--exists and not exists:
if exists (select [Name] from [Production].[Product] where [Color] = 'Red')
	print 'there are red products'
else
	print 'we need to create red products'

if not exists (select [Name] from [Production].[Product] where [Color] = 'Red')
	print 'true'
else
	print 'false'

--While

declare @x int = 0
while @x<5
begin
	print @x
	set @x = @x+1
end

declare @x int = 0
while @x<=5
begin
	set @x = @x+1
	print @x
	if @x = 4
		break;
end
-------------------------------------------------------------------------------------------
--Built-In Functions:
----NULL: isnull(value), colases(value,e1,e2,e2),ifnull(value,e)
----Convert:convert,cast
SELECT CONVERT(nvarchar, getdate(), 130);
----System Functions: db_name, suser_name, error_line, newid
select NEWID() --GUID global universal identfier
select * from X
go 
select @@ERROR, ERROR_LINE(),ERROR_MESSAGE()
select SUSER_Name()
select DB_NAME()
----aggregations: max, min, count, sum, avg
----string: substring(start,length), upper, lower, format, concat
----math: sin, cosn, tan, power
select power(2,2)
----date: getdate,month,year,day
select day(getdate())
----Ranking functions: row_number, dense_rank, ntile, rank 
----Windowing Functions: lead, lag, firstvalue, lastvalue
----logical Functions:iif,choose
-------------------------------------------------------------------------------------------
--union family: 
----union (no duplication), 
----union all (with duplication), 
----inersect (exists in both queries),
----except (exists in first query and not the second)
select Phone,Name from [dbo].[Professor]
union all
select Phone,Name from [StudentAffers].[Student]

select p.Name, p.Phone, s.Name,s.Phone
from [dbo].[Professor] as p
full join [StudentAffers].[Student] as s
on p.ID = s.AdisorID

