-- T-SQL Categoris:
--DML
--DML is abbreviation of Data Manipulation Language. It is used to retrieve, store, modify, delete, insert and update data in database.
--Examples: SELECT, UPDATE, INSERT statements

--DDL
--DDL is abbreviation of Data Definition Language. It is used to create and modify the structure of database objects in database.
--Examples: CREATE, ALTER, DROP statements

--DCL
--DCL is abbreviation of Data Control Language. It is used to create roles, permissions, and referential integrity as well it is used to control access to database by securing it.
--Examples: GRANT, REVOKE statements

--TCL
--TCL is abbreviation of Transactional Control Language. It is used to manage different transactions occurring within a database.
--Examples: COMMIT, ROLLBACK statements

-- TQL 
-- SQL Select Statments
--=========================================================

--Sys info & system tables structure
-------------------------------------------------------------
Use ITI;

----------------------------------
--ROWNUMBER() --Self study
----------------------------------
--TOP
select Top 10 [St_Lname],[St_Address],[St_Age]
from [ITI].[dbo].[Student]
order by [St_Age] Desc;
----------------------------------
Use AdventureWorks;
--Compute
SELECT SalesOrderID, UnitPrice, UnitPriceDiscount
FROM Sales.SalesOrderDetail 
ORDER BY SalesOrderID 
COMPUTE SUM(UnitPrice), SUM(UnitPriceDiscount)
--Compute by
SELECT SalesPersonID, CustomerID, OrderDate, SubTotal, TotalDue 
FROM Sales.SalesOrderHeader 
ORDER BY SalesPersonID, OrderDate 
COMPUTE SUM(SubTotal), SUM(TotalDue) BY SalesPersonID
-----------------------------------------------------------
--Correlated SubQueries
/* http://msdn.microsoft.com/en-us/library/ms187638.aspx
Many queries can be evaluated by executing the subquery once and substituting the resulting value or values into the WHERE clause of the outer query. In queries that include a correlated subquery (also known as a repeating subquery), the subquery depends on the outer query for its values. This means that the subquery is executed repeatedly, once for each row that might be selected by the outer query.
*/
--Example
use ITI;
USE AdventureWorks;
GO
SELECT DISTINCT c.LastName, c.FirstName, e.BusinessEntityID 
FROM Person.Person AS c JOIN HumanResources.Employee AS e
ON e.BusinessEntityID = c.BusinessEntityID 
WHERE 5000.00 IN
    (SELECT Bonus
    FROM Sales.SalesPerson sp
    WHERE e.BusinessEntityID = sp.BusinessEntityID) ;
GO
-----------------------------------------------------------
--CTE (Common Table Expression)
/* -- http://msdn.microsoft.com/en-us/library/ms190766.aspx
A common table expression (CTE) can be thought of as a temporary result set that is defined within the execution scope of a single SELECT, INSERT, UPDATE, DELETE, or CREATE VIEW statement. A CTE is similar to a derived table in that it is not stored as an object and lasts only for the duration of the query. Unlike a derived table, a CTE can be self-referencing and can be referenced multiple times in the same query.
A CTE can be used to: 
Create a recursive query. For more information, see Recursive Queries Using Common Table Expressions.
Substitute for a view when the general use of a view is not required; that is, you do not have to store the definition in metadata.

Enable grouping by a column that is derived from a scalar subselect, or a function that is either not deterministic or has external access.
Reference the resulting table multiple times in the same statement.

Using a CTE offers the advantages of improved readability and ease in maintenance of complex queries. The query can be divided into separate, simple, logical building blocks. These simple blocks can then be used to build more complex, interim CTEs until the final result set is generated. 
*/
USE AdventureWorks;
GO
-- Define the CTE expression name and column list.
WITH Sales_CTE (SalesPersonID, SalesOrderID, SalesYear)
AS
-- Define the CTE query.
(
    SELECT SalesPersonID, SalesOrderID, YEAR(OrderDate) AS SalesYear
    FROM Sales.SalesOrderHeader
    WHERE SalesPersonID IS NOT NULL
)
-- Define the outer query referencing the CTE name.
SELECT SalesPersonID, COUNT(SalesOrderID) AS TotalSales, SalesYear
FROM Sales_CTE
GROUP BY SalesYear, SalesPersonID
ORDER BY SalesPersonID, SalesYear;
GO

--Compare CTE to temp Tables
-----------------------------------------------------------
--Pivot --See Resources
--Unpivot -- See Resources
-----------------------------------------------------------
--ROll,Cube 
--Rank
--Merge
-----------------------------------------------------------
--Bulk Insert
--Imports a data file into a database table or view in a user-specified format in SQL Server 2008 R2. Use this statement to efficiently transfer data between SQL Server and heterogeneous data sources.
--http://msdn.microsoft.com/en-us/library/ms188365.aspx
