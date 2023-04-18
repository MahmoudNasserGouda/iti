--cursor:
select Top 10 [FirstName],[LastName] from [Person].[Contact]
where [Title] in ('Mr.','Ms.','Mrs.')
order by [FirstName],[LastName]

--1. create cursor that will hold query result set
declare getData cursor for 
select Top 10 [FirstName],[LastName] from [Person].[Contact]
where [Title] in ('Mr.','Ms.','Mrs.')
order by [FirstName],[LastName]

--2. open cursor
open getData

--3. declare variables to hold data fetched in this row
declare @firstName nvarchar(50), @lastName nvarchar(50)

--4. fetch the row
fetch next from getData into @firstName,@lastName

while @@FETCH_STATUS = 0
begin
	insert into #FullNames
	select @firstName + ' ' + @lastName
	fetch next from getData into @firstName,@lastName
end

close getData
deallocate getData

create table #FullNames
(
	FullName nvarchar(100)
)

select * from #FullNames


select * from [HumanResources].[Department]

declare getDepartment cursor for select DepartmentID,Name from [HumanResources].[Department]
open getDepartment
declare @DeptID int, @DeptName nvarchar(50)
fetch next from getDepartment into @DeptID, @DeptName
while @@FETCH_STATUS = 0
begin
	declare @EmpCount int
	select @EmpCount = count(*) from [HumanResources].[EmployeeDepartmentHistory]
	where EndDate is null and DepartmentID = @DeptID

	insert into #DeptEmployeeCount values(@DeptID,@DeptName,@EmpCount)

	fetch next from getDepartment into @DeptID, @DeptName
end

close getDepartment
deallocate getDepartment

create table #DeptEmployeeCount
(
	DeptID int,
	DeptName nvarchar(50),
	EmployeeCount int
)

select * from #DeptEmployeeCount

--------------------------------------------------------------------------
--proc:
--query
--parser
--optimizer
--query tree (procedure query tree is stored after the first execution)
--execution plan
--result set

--Caractarestics:
----better performance
----DML
----Dynamic SQL
----Output params
----No Return or Return Int ONLY
----Default values for parameters
----Parameters can be table typed (READONLY)
use [World]
create proc checkCountryLanuage @Code char(3), @lang char(30), @official bit, @P float
as begin
	if exists (select * from [dbo].[Country] where [Code] = @Code)
	begin
		declare @totalP float = 0
		select @totalP = sum([Percentage]) from [dbo].[CountryLanguage]
		where CountryCode = @Code

		set @totalP = @totalP + @P
		if @totalP > 100
			print 'you cant add another language here'
		else 
		begin
			insert into [dbo].[CountryLanguage] values(@Code,@lang,@official,@P)
			print 'Added Successfully'
		end
	end
end

insert into [dbo].[Country]
values('TCC','Test Code','Africa','Central Africa',1246700,null,1000000,null,null,null,'tc','Republic',null,null,'T2')

exec checkCountryLanuage 'TCC','English',0,50
exec checkCountryLanuage 'TCC','French',0,30
exec checkCountryLanuage 'TCC','Arabic',0,20
exec checkCountryLanuage 'TCC','X',0,1

use [AdventureWorks]
create function countEmployeeInTitle (@title nvarchar(50))
returns int
as begin
	declare @count int = 0
	select @count = count(*) from [HumanResources].[Employee]
	where Title = @title
	return @count
end

select dbo.countEmployeeInTitle('Buyer')

create proc AllTitleEmployees @Titles t2 READONLY
as begin
	declare getTitle cursor for select * from @Titles
	open getTitle
	declare @titleName nvarchar(50)
	declare @result table (TitleName nvarchar(50), EmplyeeCount int)
	Fetch next from getTitle into @titleName
	while @@FETCH_STATUS = 0
	begin
		declare @count int = dbo.countEmployeeInTitle(@titleName)
		insert into @result values(@titleName,@count)

		Fetch next from getTitle into @titleName
	end
	close getTitle
	deallocate getTitle

	select * from @result
end

declare @titles t2
insert into @titles
select distinct Title from HumanResources.Employee

exec AllTitleEmployees @titles

create proc getHighestPayed @DeptID int, @EmployeeName nvarchar(100) output
as begin
	--variable to hold Employee IDs still working in this department
	declare @EmpIDsInDept table (EmpID int)

	insert into @EmpIDsInDept
	select [EmployeeID] from [HumanResources].[EmployeeDepartmentHistory]
	where DepartmentID = @DeptID and [EndDate] is null

	--variable to hold rate for each Employee in this department
	declare @EmpRateInDept table (EMPID int, Rate money)

	insert into @EmpRateInDept
	select [EmployeeID],[Rate]
	from [HumanResources].[EmployeePayHistory]
	where [EmployeeID] in (select * from @EmpIDsInDept)

	--variable to hold ID of top Rated Employee in this department
	declare @EMPID int = (select EMPID from @EmpRateInDept
	where [Rate] = (select Max(Rate) from @EmpRateInDept))

	select @EmployeeName = [FirstName]+' '+[LastName] from [Person].[Contact]
	where [ContactID] = (select [ContactID] from [HumanResources].[Employee]
	where [EmployeeID] = @EMPID)
end

declare @DeptID int = 10, @EmpName nvarchar(100)
exec getHighestPayed @DeptID, @EmpName output
select @EmpName

select [EmployeeID],[Rate] into #Test
from [HumanResources].[EmployeePayHistory]
where [EmployeeID] in (select [EmployeeID] from [HumanResources].[EmployeeDepartmentHistory]
where DepartmentID = 10 and [EndDate] is null)

select FirstName+' '+LastName from Person.Contact where ContactID = 
(select ContactID from HumanResources.Employee where EmployeeID = (select EmployeeID from #Test where Rate = (select Max(Rate) from #Test)
))
---------------------------------------------------------------------------
--triggers: special type of stored procedure that will fire automatically
--when a desired command happened
--DML Trigger: insert, update, delete after|for, instead of
--DDL Trigger: create, alter, drop after|for
--Trigger inherits their object schema

use [NetQ32023]
go
alter table [dbo].[Faculty]
add Deleted bit default 0

alter table [dbo].[Faculty]
alter column Deleted bit not null

create trigger FacultyDeleteTrig
on [dbo].[Faculty] instead of Delete as
begin
	print 'you cant delete'
end

delete from [dbo].[Faculty]

create proc DeleteFacult @FacultyID int
as begin
	delete from [dbo].[Faculty] WHERE ID =@FacultyID
end

exec DeleteFacult 18

--soft delete
alter trigger FacultyDeleteTrig
on [dbo].[Faculty] instead of Delete as
begin
	--deleted is a table in tempdb that holds the rows that should be deleted
	update [dbo].[Faculty] 
	set Deleted = 1 
	where ID in (select ID from deleted)
end

delete from [dbo].[Faculty] where ID in (10,18,19)

drop trigger FacultyDeleteTrig

alter trigger FacultyDeleteTrig
on [dbo].[Faculty] after delete
as begin 
	select * into FacultyDeleted from deleted
end

delete from [dbo].[Faculty] 
where ID = 19

alter trigger [Manger].StopInsertOnDept 
on [Manger].[Department] instead of insert
as begin
	select * from inserted
end

insert into [Manger].[Department] values(70,'x',10,null)


use [World]
go 
create trigger checkContryLanguagePercent
on [dbo].[CountryLanguage] instead of insert
as begin
	declare @code char(3) = (select [CountryCode] from inserted)
	if exists (select * from [dbo].[Country] where [Code] = @code)
	begin
		declare @totalP float = 0
		select @totalP = sum([Percentage]) from [dbo].[CountryLanguage]
		where CountryCode = @Code

		declare @P float  = (select [Percentage] from inserted)
		set @totalP = @totalP + @P
		if @totalP > 100
			print 'you cant add another language here'
		else 
		begin
			insert into [dbo].[CountryLanguage] 
			select * from inserted

			print 'Added Successfully'
		end
	end
end

drop trigger checkContryLanguagePercent

create trigger oninsert 
on [dbo].[CountryLanguage] instead of insert
as begin
	select * from inserted
end

insert into [dbo].[CountryLanguage] values('TCC','English',0,50),('TCC','French',0,30),('TCC','Arabic',0,20)
insert into [dbo].[CountryLanguage] values('TCC','French',0,30)
insert into [dbo].[CountryLanguage] values('TCC','Arabic',0,20)
insert into [dbo].[CountryLanguage] values('TCC','X',0,1)
