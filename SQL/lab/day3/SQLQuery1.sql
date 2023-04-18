--1.	Create the following schema and transfer the following tables to it
--a.	Company  schema  
--i.	Department table (Programmatically)
--ii.	Employee table (visually)

USE [Net23-Company]

CREATE SCHEMA company

ALTER SCHEMA company
TRANSFER [dbo].[Department]

ALTER SCHEMA company
TRANSFER [dbo].[Employee]

--2.	Delete the primary key of the Employee table. Why it will not work?
--a.	Can a Primary key refer to Unique key instead of Foreign key?

ALTER TABLE Employee
DROP COLUMN EmpNo

--4.	Attach AdventureWorks database (Search for attaching a DB). 
--5.	Display the Employee National ID, LoginID, JobTitle from the Employee table (HumanResources Schema) as a report to your manager.

USE [AdventureWorks2019]

SELECT [NationalIDNumber],[LoginID],[JobTitle]
FROM [HumanResources].[Employee]

--6.	Display the Contact Title,FirstName and LastName for those holding Title ‘Ms” OR  LastName=’Antrim’

SELECT [Title],[FirstName],[LastName]
FROM [Person].[Person]
WHERE [Title] = 'Ms' OR [LastName] = 'Antrim'

--7.	Display the SalesOrderID, ShipDate of the SalesOrderHearder table (Sales schema) to designate SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2002’

SELECT [SalesOrderID],[ShipDate]
FROM [Sales].[SalesOrderHeader]
WHERE [OrderDate] BETWEEN '2011-7-28' AND '2011-7-29'

--8.	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)

SELECT [ProductID],[Name]
FROM [Production].[Product]
WHERE [StandardCost] < 110

--9.	Display each product name along with its its sub categoray name and category name.

SELECT p.[Name],sc.[Name],c.[Name]
FROM [Production].[Product] AS p
JOIN [Production].[ProductSubcategory] AS sc ON p.[ProductSubcategoryID] = sc.[ProductSubcategoryID]
JOIN [Production].[ProductCategory] AS c ON sc.[ProductCategoryID] = c.[ProductCategoryID]

--10.	Display any Product with a Name starting with the letter B.

SELECT *
FROM [Production].[Product]
WHERE [Name] LIKE 'B%'

--11.	Display the Sub Categories that contain products start with B letter (Use Sub Queries).

SELECT *
FROM [Production].[ProductSubcategory]
WHERE [ProductSubcategoryID] IN (SELECT [ProductSubcategoryID] FROM [Production].[Product] WHERE [Name] LIKE 'B%')

--12.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2001'

SELECT SUM([TotalDue]), [OrderDate]
FROM [Sales].[SalesOrderHeader]
GROUP BY [OrderDate]
HAVING [OrderDate] BETWEEN '2011-7-1' AND '2011-7-31'

--13.	 Calculate the average of the unique ListPrices and category name in the Product table for each product category which have average listPrice>1000

SELECT DISTINCT AVG(p.[ListPrice]),c.[Name]
FROM [Production].[Product] AS p
JOIN [Production].[ProductSubcategory] AS sc ON p.[ProductSubcategoryID] = sc.[ProductSubcategoryID]
JOIN [Production].[ProductCategory] AS c ON sc.[ProductCategoryID] = c.[ProductCategoryID]
GROUP BY c.[Name]
HAVING AVG(p.[ListPrice]) > 1000
