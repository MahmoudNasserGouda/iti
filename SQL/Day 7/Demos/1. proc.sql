--stored procedure
----allows the end user to execute a group of precompiled statements by
----entering a single predefined command

--benifits
----Simplify repeated tasks
----Run faster
----Reduce network traffic
----Can catch user errors before they are entered into the database
----Establish consistency by performing tasks the same way 
----Help to provide security 
----Can enforce complex business rules and defaults


--performance benifits
--A compiled stored procedure executes more rapidly than a batch because:
--1)The stored procedure has already been parsed
--2)Server does not need to build a query tree;
--3)it can use the one in sysprocedures
--3)If an unused query plan for the procedure exists in procedure cache
--Server does not need to create a query plan

--Differences Between Procedures and Functions
-- -- http://www.c-sharpcorner.com/uploadfile/skumaar_mca/differences-between-procedures-and-functions/
-- -- http://www.stupidcodes.com/difference-between-stored-procedures-and-function


--create procedure with no pramaters
create proc p22
as
begin
	declare @x nvarchar(20)
	set @x='test'
	select @x	
			--without return
end
--execute proceder
p22 
-- or
exec p22

----------------------------------
--with return
create proc p33
as
begin
	declare @x nvarchar(20)
	set @x='test'
	select @x	
	return 1 -- return for user to detect run successfully or not.		
end

--Run Without getting return
p33
---print the return
declare @n int
exec @n=p33
--exec p33
select 'result of Execution:' + str(@n)
--select @q
-----------------------------------
--procedure take  paramater
create proc p2(@x nvarchar(22))
as
begin
	select 'Welcome ' + @x 
end			
---
exec p2 'SQL Server'

--------------------------------------------
--Default paramater
create proc p3(@x int,@y int=3)
as
begin
	select (@x+@y);
end			
---
exec p3 1

--OR
exec p3 1,4
--------------------------------------------------
--procedure take output pramater
Create  proc p4(@x nvarchar(20) output)
as
begin
set @x='test'
end		
---

declare @y nvarchar(50)
exec p4 @y output
set @y='This is test for output paramater: ' + @y
select @y
----------------------------------------------------
--procedure take output pramater 2
Create  proc getProductsCountOfSpecColor(@pColor nvarchar(10), @pCount int output)
as
begin
	--select @pCount=count ([ProductID]) 
	--from [Production].[Product]
	--where [Color]=@pColor
	set @pCount= 
	(
		select count ([ProductID]) 
		from [Production].[Product]
		where [Color]=@pColor
	)
end		
----------
declare @ProdCount int
declare @prodColor nvarchar(10)
Set @prodColor='Black'
exec getProductsCountOfSpecColor @prodColor, @ProdCount output
--exec getProductsCountOfSpecColor 'Black', @ProdCount output
Select str(@ProdCount) + '   products found for this color'
----------------------------------------------------
create proc p44(@d nvarchar(22),@t nvarchar(22))
as
begin

	exec('use ' + @d + '; select * from '+ @t )
end
---execute procedure
p44 'AdventureWorks' ,'Person.Contact'
---------------------------------------------
create proc InsertTopic(@id int,@name nvarchar(50))
as
begin

insert into ITI.dbo.Topic values (@id,@name);

end

exec InsertTopic 97,'test topic2'
----------------------------------------------
use AdventureWorks;

CREATE PROCEDURE HumanResources.uspGetAllEmployees
AS
    SELECT LastName, FirstName, JobTitle, Department
    FROM HumanResources.vEmployeeDepartment;
GO

exec HumanResources.uspGetAllEmployees
	-----------------------------------------------------------
	
USE AdventureWorks;
GO
CREATE PROCEDURE uspNResults 
AS
SELECT COUNT(ContactID) FROM Person.Contact;
SELECT COUNT(CustomerID) FROM Sales.Customer;
GO

EXEC dbo.uspNResults

						--------------------------		
						
use AdventureWorks 
go						
SELECT *
FROM Person.Contact p
INNER JOIN HumanResources.Employee e
ON e.ContactID = p.ContactID
--encapsulate into stored procedure
go

CREATE PROC usp_GetEmp
AS
SELECT *
FROM Person.Contact p
INNER JOIN HumanResources.Employee e
ON (e.ContactID = p.ContactID)
order by p.FirstName;

EXEC usp_GetEmp

--Modify the stored procedure to add a parameter
ALTER PROC usp_GetEmp(@LastName varchar(50))
AS
SELECT *
FROM Person.Contact p
INNER JOIN HumanResources.Employee e
ON e.ContactID = p.ContactID
WHERE LastName = @LastName

EXEC usp_GetEmp 'Gilbert'

-----------------------------------------------
--Pass a table data type to a proc
/*
In Sql Server 2008 you can pass a table variable in a stored procedure as 
a parameter. now you have the ability to send multiple rows of data in 
a stored procedure.one main advantage of that is that it will reduce the amount 
of round trips to the server. 

Limitations to passing table parameters
 - You must use the READONLY clause when passing in the table valued variable into the procedure. Data in the table variable cannot be modified -- you can use the data in the table for any other operation. Also, you cannot use table variables as OUTPUT parameters -- you can only use table variables as input parameters.
*/
--use sales
CREATE TABLE Customers
(
   	 Cust_ID int NOT NULL
	,Cust_Name varchar(50) NOT NULL
	,Cust_Surname varchar(50) NOT NULL
	,Cust_Email varchar(50) NOT NULL
)
Go
------------------------------
create procedure insertintocustomer
		(
				@Cust_ID int
				,@Cust_Name varchar(50)
				,@Cust_Surname varchar(50)
				,@Cust_Email varchar(50)
		)
as
begin 
		insert into dbo.Customers
		values(@Cust_ID, @Cust_Name,@Cust_Surname,@Cust_Email)
end
Go
-- insert using procedures with paramaters
exec insertintocustomer  3,'steven','gerrard','sg@liverpool.com'
exec insertintocustomer  5,'jamie','caragher','jc@liverpool.com'
exec insertintocustomer  6,'Ahmed','Sleepy','ahmed@liverpool.com'

---------------------------------------
select * from dbo.Customers
------------------------------------
-- Procedure with table-type paramater
create type customertype as table
(
		Cust_ID int not null
		,Cust_Name varchar(50)
		,Cust_Surname varchar(50)
		,Cust_Email varchar(50)
)
go

-----------------------------

create procedure InsertIntoCustomerNew
		(@Customer_details customertype READONLY)
		--to be read only it have to be a table value data type
as
begin 
		insert into Customers
		select * from @Customer_details
end
			----------------------------
-- Insert Using Proc that take table type paramter
declare @c customertype
insert into @c values (7,'steven','gerrard','sg@liverpool.com')
insert into @c values (8,'jamie','caragher','jc@liverpool.com')
insert into @c values (9,'Ahmed','Sleepy','ahmed@liverpool.com')

execute InsertIntoCustomerNew @c


---------------------------------------
select * from dbo.Customers
------------------------------------



-- select data for test
select *
from dbo.Customers										