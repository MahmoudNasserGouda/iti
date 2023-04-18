--Aggregate Function
--calculate average value for a column
USE northwind
SELECT AVG (unitprice) AS AvgPrice 
FROM products
GO
			               -----------------------
--calculate maximum value for a column
USE northwind
SELECT MAX (unitprice) AS MaxPrice 
FROM products
GO
							-----------------------
--calculate minimum value for a column
USE northwind
SELECT MIN (unitprice) AS MinPrice 
FROM products
GO
							----------------------
--Return the number of values in an expression
USE northwind
SELECT count (Fax) AS NoOfVal 
FROM customers
GO
							-------------------------
--Return the number of selected rows
USE northwind
SELECT RowsNo=count (*)  --Counts Rows with Null Values
												 --RowsNo will be the alias column name
FROM customers
GO
							-------------------------
--calculate Total values in a numeric expression
USE northwind
SELECT SUM(unitprice) AS SumPrice 
FROM products
GO
								-----------------------
use AdventureWorks
SELECT COUNT(*) 
FROM HumanResources.Employee;--290

SELECT COUNT(ManagerID) 
FROM HumanResources.Employee;--289

SELECT AVG(VacationHours)
FROM HumanResources.Employee;--50

SELECT MAX(VacationHours) 
FROM HumanResources.Employee;--99

SELECT SUM(VacationHours) 
FROM HumanResources.Employee;--14678

/*Aggregate functions can only appear in 
the SELECT statement, COMPUTE/COMPUTE BY 
clause and the HAVING clause.
*/
USE AdventureWorks
SELECT MAX(TaxRate)
FROM Sales.SalesTaxRate
GROUP BY TaxType;

--Most aggregate functions ignore NULL values
--NULL values may produce unexpected or incorrect results
--Use the ISNULL function to correct this issue
--The COUNT(*) function is an exception and returns the total number of records in a table
--Note: count(col_name)will exclude the null values 
USE AdventureWorks
SELECT AVG(ISNULL(Weight,0)) 
AS 'AvgWeight'
FROM Production.Product
									--------------------------
SELECT Description, DiscountPct, MinQty
, ISNULL(MaxQty, 0) AS 'Max Quantity'
FROM Sales.SpecialOffer;
--ISNULL()returns a given value if the column value is NULL
			-------------------
								-------------------------
/*
3.The special SPARSE keyword can be used to conserve space
in columns that allow NULL values.--new in sql2008
*/
USE AdventureWorks
GO
CREATE TABLE DocumentStore
(
		DocID int PRIMARY KEY
		,Title varchar(200) NOT NULL
		,ProductionSpecification varchar(20) SPARSE NULL
		,ProductionLocation smallint SPARSE NULL
		,MarketingSurveyGroup varchar(20) SPARSE NULL 
) ;
GO
								------------------------
