--Identity(start, inc)

use [NetQ32023]

create table Course
(
	Code int identity(1,1),
	Name varchar(20) not null,
	Hours int not null default 10,
	Degree int not null default 100,
	constraint CoursePK primary key (Code),
	constraint CourseHoursCheck check (Hours between 10 and 70),
	constraint CourseDegreeCheck check (Degree between 100 and 200)
)

insert into [dbo].[Course]
values ('C#',60,200),('HTML',15,100)

delete from [dbo].[Course]

--Truncate: effects-> restarting the identity counter
--it drops the table and recreates it

Truncate table [dbo].[Course]

--check current value of identity field
DBCC CHECKIDENT ('Course')

delete from  [dbo].[Course] where Name = 'C#'

--backward 1 step identity
DBCC CHECKIDENT ('Course', RESEED, 1)

--select the identity Step
select IDENT_INCR('Course') as 'Identity Increment'

--select current identity value for the last command excuted that change it
select @@IDENTITY

-------------------------------------------------------------------------
--sequance:
--database object
--not releated to table
--has it's own DDL commands
--can be reset

create sequence [counter] start with 1 increment by 1 

select Next value for [counter]  --1

insert into Faculty values(Next value for [counter], 'F2',1) --2

select Next value for [counter] --3

insert into Faculty values(Next value for [counter], 'F4',1) --4

alter sequence [counter] restart with 10

insert into Faculty values(Next value for [counter], 'F10',1) --10

--11 skiped with insert error confilct with FK
insert into Department values(Next value for [counter], 'Dept11',10,1) --12

drop sequence [counter]
---------------------------------------------------------------------------------
--Schema: logical categorization for tables (virtual)
--to group tables and add cridentials
--dbo: initial default schema (database owner)

create schema StudentAffers

create table StudentAffers.Student
(
	ID int identity(1,1) primary key,
	Name varchar(50) not null,
	Email varchar(100) not null,
	AdisorID int not null foreign key references Professor(ID)
)

alter schema StudentAffers
transfer dbo.Course

alter schema StudentAffers
transfer dbo.Dean

create schema Manger

alter schema Manger
transfer Department

alter table [StudentAffers].[Student]
add DeptID int not null 

alter table StudentAffers.Student
add constraint StudentDeptFK foreign key (DeptID) references Manger.Department

create table Department
(
ID int primary key,
Name varchar(50)
)

create sequence StudentAffers.Counter as smallint start with 1 increment by 1
-------------------------------------------------------------------------------
--DQL:
use AdventureWorks

select * from [HumanResources].[Employee]

select [EmployeeID], [NationalIDNumber], [Title] 
from [HumanResources].[Employee]

select [EmployeeID], [NationalIDNumber], [Title] 
from [HumanResources].[Employee]
where [Title] like '%WC_0'

select [EmployeeID] as 'Employee ID' , 
[NationalIDNumber] as SSN, 
[Title] 
from [HumanResources].[Employee]
where [Title] like '%WC_0'
order by [Title] DESC, [EmployeeID] DESC

select [EmployeeID] as 'Employee ID' , 
[NationalIDNumber] as SSN, 
[Title] 
from [HumanResources].[Employee]
where [Title] like '%WC_0'
order by [SickLeaveHours]

select top 10 --4 
[EmployeeID] as 'Employee ID' , 
[NationalIDNumber] as SSN, 
[Title] 
from [HumanResources].[Employee] --1
where [Title] like '%WC_0' --2
order by [SickLeaveHours] --3

select [Title],[FirstName],[MiddleName],[LastName]
from [Person].[Contact]

select [Title] + ' ' + [FirstName] + ' ' + ISNULL([MiddleName],'') + ' ' + [LastName]
from  [Person].[Contact]

--select COALESCE(null,null,null,'End')
select [Title],[FirstName], COALESCE(MiddleName,LastName,'')
from [Person].[Contact]

select CONCAT([Title],[FirstName], COALESCE(MiddleName,LastName,''))
from [Person].[Contact]

select [FirstName]+' Phone: '+[Phone]
from [Person].[Contact]

select CONVERT(nvarchar(max),[BillOfMaterialsID]) + ' ' +[UnitMeasureCode]
from [Production].[BillOfMaterials]

select distinct [Title]
from [HumanResources].[Employee]

select ([Rate]*1.0) as 'Tax'
from [HumanResources].[EmployeePayHistory]

create table Titles
(
	Name nvarchar(50)
)

delete from Titles

--insert pased on select
--table must be created first
insert into Titles
select distinct [Title]
from [HumanResources].[Employee]

--table is created on the fly
select distinct [Title] 
into Titles2
from [HumanResources].[Employee]

--aggregation functions
--can't select any non aggregate column with aggregate except group by column
select Gender,count([MaritalStatus]),avg([VacationHours])
from [HumanResources].[Employee]
where [MaritalStatus] = 'M'
group by [Gender]

select Gender,[MaritalStatus],count([MaritalStatus]),avg([VacationHours])
from [HumanResources].[Employee]
group by [Gender],[MaritalStatus]

--select count of emps and avg vecation hours grouped by their gender and marital status
--for those who has avg vacation hours more than 50
select Gender,[MaritalStatus],count([MaritalStatus]),avg([VacationHours])
from [HumanResources].[Employee]
--where avg([VacationHours])>50
group by [Gender],[MaritalStatus] having avg([VacationHours])>50

select Gender,[MaritalStatus],count([MaritalStatus]),avg([VacationHours])
from [HumanResources].[Employee]
--where avg([VacationHours])>50
group by [Gender],[MaritalStatus] having avg([VacationHours])>50

-------------------------------------------------------------------------------
--Synonyms:
create synonym e for [HumanResources].[Employee]

select * from [HumanResources].[Employee]

select * from e

--select substring('Mrihan Mohamed',1,6)