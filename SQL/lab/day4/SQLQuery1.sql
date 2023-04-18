--1.	Create new Schema named HR, and move the Employee table to it.

USE [Net23-Company]

CREATE SCHEMA HR

ALTER SCHEMA HR TRANSFER [company].[Employee]

--2.	Create new User-Defined datatype named CityUDD, of type Nvarchar(10).

CREATE TYPE CityUDD FROM nvarchar(10)

--3.	Create new User-Defined datatype named Tel, of type Nvarchar(11), and not allow null.

CREATE TYPE Tel FROM nvarchar(11) NOT NULL

--4.	Create Default that Make the column value "Not Applied".
--a.	What's the difference between this Default, and default constraint? 

CREATE DEFAULT notApplied AS 'Not Applied'

--5.	Create rule, that make sure that column values is "Assiut" or "Mansoura" or "Cairo" or "Alex" or "Ismalia".
--a.	What's the difference between that rule, and check constraints?

CREATE RULE CheckCity AS @Value IN ('Assiut', 'Mansoura', 'Cairo', 'Alex', 'Ismalia')

--6.	Apply the previous rule and default to the CityUDD user-defined datatype.

EXEC sp_bindrule CheckCity, CityUDD

EXEC sp_bindefault notApplied, CityUDD

--7.	Create New table Named Student, and use the new UDD on it.
--a.	Make ID column and don’t make it identity.

CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    StudentName NVARCHAR(50) NOT NULL,
    StudentCity CityUDD
)

--8.	Create new sequence for the ID values of the previous table.

CREATE SEQUENCE StudentIDSequence
    START WITH 1
    INCREMENT BY 1

--a.	Insert 3 records in the table using the sequence.

INSERT INTO Student (StudentID, StudentName, StudentCity)
    VALUES (NEXT VALUE FOR StudentIDSequence, 'Ahmed', 'Cairo'),
           (NEXT VALUE FOR StudentIDSequence, 'Mahmoud', 'Alex'),
           (NEXT VALUE FOR StudentIDSequence, 'Mohamed', 'Mansoura')

--b.	Delete the second row of the table.

DELETE FROM Student WHERE StudentID = 2

--c.	Insert 2 other records using the sequnce.

INSERT INTO Student (StudentID, StudentName, StudentCity) 
VALUES (NEXT VALUE FOR StudentIDSequence, 'Mostafa', 'Assiut'),
	   (NEXT VALUE FOR StudentIDSequence, 'Ali', 'Ismalia')

--d.	Can you insert another record without using the sequence? Try it!

INSERT INTO Student (StudentID, StudentName, StudentCity) VALUES (6, 'Hassan Ali', 'Cairo')

--i.	Can you do the same if it was an identity column?
--e.	Can you edit the value if the ID column in any of inserted records? Try it!
--i.	Can you do the same if it was an identity column?
--f.	Can you use the same sequence to insert in another table?
--g.	If yes, do you think that the sequence will start from its initial value in the new table and insert the same IDs that were inserted in the old table?
--h.	How to skip some values from the sequence not to be inserted in the tabel? Try it.

SELECT NEXT VALUE FOR StudentIDSequence
SELECT NEXT VALUE FOR StudentIDSequence
SELECT NEXT VALUE FOR StudentIDSequence

INSERT INTO Student (StudentID, StudentName, StudentCity) VALUES (NEXT VALUE FOR StudentIDSequence, 'Sara', 'Alex')

--i.	Can you do the same with Identity column?
--i.	What’re the differences between Identity column and Sequence?
--9.	Create a synonm for any table in your DB, and try it.

CREATE SYNONYM std FOR dbo.Student;

SELECT *
FROM std
WHERE StudentCity = 'Alex';

--1.	Try Connecting to SQL Server Using Windows authentication and using SQL server authenication.
--2.	Attach AdventureWorks database.
--3.	Create New solution and name it Day1_lab, and save all following queries on it each query on separete sql file.
--4.	Display all the data from the Employee table (HumanResources Schema) 

USE [AdventureWorks2019]

SELECT * FROM [HumanResources].[Employee]

--5.	Display the Employee National ID, LoginID, JobTitle from the Employee table (HumanResources Schema) as a report to your manager.

SELECT [NationalIDNumber],[LoginID],[JobTitle] FROM [HumanResources].[Employee]

--6.	Display the Contact Title,FirstName and LastName for those holding Title ‘Ms” OR  LastName=’Antrim’

SELECT [Title],[FirstName],[LastName]
FROM [Person].[Person]
WHERE [Title] = 'Ms' OR [LastName] = 'Antrim'

--7.	Display the Contact Title, FirstName,LastName who is not holding Title ‘Ms”.

SELECT [Title],[FirstName],[LastName]
FROM [Person].[Person]
WHERE [Title] != 'Ms'

--8.	Display all Contacts with a Title ‘Ms.’ & a FirstName ‘Catherine’.
--      In addition to displaying anyone else with a LastName ‘Adams’ regardless of  his/her Title and FirstName.

SELECT *
FROM [Person].[Person]
WHERE ([Title] = 'Ms.' AND [FirstName] = 'Catherine') OR [LastName] = 'Adams'

--9.	Display the SalesOrderID, ShipDate of the SalesOrderHearder table (Sales schema) to designate SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2002’

SELECT [SalesOrderID],[ShipDate]
FROM [Sales].[SalesOrderHeader]
WHERE [OrderDate] BETWEEN '2011-7-28' AND '2011-7-29'

--10.	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)

SELECT [ProductID],[Name]
FROM [Production].[Product]
WHERE [StandardCost] < 110

--11.	Display ProductID, Name if its weight is unknown (Null).

SELECT [ProductID], [Name]
FROM [Production].[Product]
WHERE [Weight] IS NULL

--12.	Display each product name along with its its sub categoray name and category name. 

SELECT p.[Name],sc.[Name],c.[Name]
FROM [Production].[Product] AS p
JOIN [Production].[ProductSubcategory] AS sc ON p.[ProductSubcategoryID] = sc.[ProductSubcategoryID]
JOIN [Production].[ProductCategory] AS c ON sc.[ProductCategoryID] = c.[ProductCategoryID]

--13.	 Display all Products with  a Silver, Black, or Red Color (use in keyword).

SELECT *
FROM [Production].[Product]
WHERE Color IN ('Silver', 'Black', 'Red')

--14.	 Display any Product with a Name starting with the letter B.

SELECT *
FROM [Production].[Product]
WHERE [Name] LIKE 'B%'

--15.	Display the Sub Categories that contain products start with B letter (Use Sub Queries). 

SELECT *
FROM [Production].[ProductSubcategory]
WHERE [ProductSubcategoryID] IN (SELECT [ProductSubcategoryID] FROM [Production].[Product] WHERE [Name] LIKE 'B%')

--16.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2001'

SELECT SUM([TotalDue]), [OrderDate]
FROM [Sales].[SalesOrderHeader]
GROUP BY [OrderDate]
HAVING [OrderDate] BETWEEN '2011-7-1' AND '2011-7-31'

--17.	Display the Employees HireDate (note no repeated values are allowed)

SELECT DISTINCT [HireDate] FROM [HumanResources].[Employee]

--18.	 Calculate the average of the unique ListPrices and category id in the Product table for each product category id which have average listPrice>1000

SELECT AVG(p.[ListPrice]),sc.[ProductCategoryID]
FROM [Production].[Product] AS p
JOIN [Production].[ProductSubcategory] AS sc ON p.[ProductSubcategoryID] = sc.[ProductSubcategoryID]
GROUP BY sc.[ProductCategoryID]
HAVING AVG(p.[ListPrice]) > 1000

--a.	Group by Category name instead of Category ID.

SELECT AVG(p.[ListPrice]),c.[Name]
FROM [Production].[Product] AS p
JOIN [Production].[ProductSubcategory] AS sc ON p.[ProductSubcategoryID] = sc.[ProductSubcategoryID]
JOIN [Production].[ProductCategory] AS c ON sc.[ProductCategoryID] = c.[ProductCategoryID]
GROUP BY c.[Name]
HAVING AVG(p.[ListPrice]) > 1000

--19.	 Display the Product Name and its ListPrice within the values of 100 and 120 The list should has the following format 
--"The [product name] is only! [List price]"
--(the list will be sorted according to its ListPrice value)

SELECT 'The ' + [Name] + ' is only! ' + CONVERT(VARCHAR, [ListPrice])
FROM [Production].[Product]
WHERE [ListPrice] BETWEEN 100 AND 120
ORDER BY [ListPrice]
