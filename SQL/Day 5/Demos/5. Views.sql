/** Views **/
/*
IS A Saved select statment (Saved Query)
•	Simplify construction of complex queries
•	Specify user view
•	Limit access to data [grant revoke]
•	Hide names of database objects [table name and columns]
*/								


/** Creating Views **/
--Create view
use AdventureWorks;
go

create view product_info
as
(
SELECT 
       [Name]
      ,[ProductNumber]
      ,[MakeFlag]
      ,[FinishedGoodsFlag]
      ,[Color]
      ,[SafetyStockLevel]
      ,[ReorderPoint]
      ,[StandardCost]
      ,[ListPrice]
      ,[Size]
     
  FROM [Production].[Product]
)
--Altrer View
alter view product_info
as
(
SELECT 
      ProductID
      ,[Name]
      ,[ProductNumber]
      ,[MakeFlag]
      ,[FinishedGoodsFlag]
      ,[Color]
      ,[SafetyStockLevel]
      ,[ReorderPoint]
      ,[StandardCost]
      ,[ListPrice]
      ,[Size]
     
  FROM [AdventureWorks].[Production].[Product]
)					
-------------------------------------------------						
select [Name] from 	product_info
where ProductID<10

select * from 	product_info
where ProductID<10

--Drop View
drop view product_info;
---------------------------------
go
create view product_details
as
(
 select [Production].[Product].[Name] as ProductName, [Production].[ProductCategory].[Name] as CategoryName, [Production].[ProductSubcategory].[Name] as SubCategoryName
 from [Production].[Product], [Production].[ProductSubcategory], [Production].[ProductCategory]
 where [Production].[Product].[ProductSubcategoryID]=[Production].[ProductSubcategory].[ProductSubcategoryID]
 and [Production].[ProductSubcategory].[ProductCategoryID]=[Production].[ProductCategory].[ProductCategoryID]
)
go

select * from product_details

select ProductName, CategoryName, SubCategoryName from product_details
where ProductName like'S%'




--Create view with alias					
create view product_Info2(ID,Pname,Price)
as
(
	/*select ProductID as ID,Name as Pname,ListPrice as Price from Production.Product
	where ProductID>10*/

	select ProductID,Name,ListPrice from Production.Product
	where ProductID>10
)
go
select ProductID from product_Info2 -- Will not Execute
select ID from product_Info2


-----------------------------------------------------------
--insert through a view if:
----All the affected columns belong to one table
----All the columns not named in the view either allow NULLs
----, have default clauses, or are IDENTITY columns

--update if:
----All the affected columns belong to one table

--delete if:
----The view is based on only one table	
create view v 
as
select st_id, st_fname from newschema.Student
------------------------------------------------------

insert into v(st_id, st_fname) values (444,'test')
					
						/****************/
-- 'CREATE VIEW' must be the first statement in a query batch.
use northwind
Go			
CREATE VIEW dbo.EmpData
AS 
SELECT EmployeeID,FirstName,LastName,title
FROM Employees
GO

-----------------------------------------------------------------------
--with check option
----working with insert & update only

--Case 1 (Without check option)
create view TestView1
as
	select st_id,st_fname,st_age
	from dbo.student
	where st_age>20
-------------------------------------
insert into TestView1 
values(111,'ali',33)-- work

insert into TestView1 
values(112,'ali',10)-- work

select * from TestView1

select * from Student

-------------------------------------------------
--Case 2 (With check option)
create view TestView2
as
	select st_id,st_fname,st_age
	from dbo.student
	where st_age>20
	with check option;

insert into TestView2 
values(113,'ali',33)-- work

insert into TestView2 
values(114,'ali',10)-- Not work

select * from TestView2

select * from Student



---------------------------
-- The same with Update
update TestView2
set st_age=30
where st_age=10 --will not work
--------------------------------------------------------------------
