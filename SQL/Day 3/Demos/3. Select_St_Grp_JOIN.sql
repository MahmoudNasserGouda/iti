				--Retrieving Data by Using the SELECT Statement

USE northwind
--Specifying Columns
SELECT employeeid, lastname, firstname, title
FROM employees
GO
										-----------------------------
USE northwind
SELECT productid, productname, categoryid, unitprice
 FROM products
--Sorting Data
 ORDER BY categoryid, unitprice DESC   --default:Ascending
GO
											------------------------
use AdventureWorks;
SELECT LastName, FirstName, MiddleName
FROM Person.Contact
ORDER BY LastName, FirstName     --Sorting by LastName-FirstName
											------------------------
USE northwind
SELECT employeeid, lastname, firstname, title
FROM employees
--Using the WHERE Clause to Specify Rows  "Filtering ResultSet"
WHERE employeeid = 5
GO
											-----------------------
USE northwind
SELECT lastname, city
FROM employees
--Using Comparison Operators
WHERE country = 'USA'
GO
											-----------------------
--Labeling columns in result set
use AdventureWorks;
SELECT e.EmployeeID AS 'Employee Identification Number'
FROM HumanResources.Employee AS e
--equivalent to
SELECT e.EmployeeID 'Employee Identification Number'
FROM HumanResources.Employee AS e
						--can remove "AS" keyword 
											-----------------------
USE northwind
--Changing Column Names by using Alias
SELECT  firstname AS First, lastname AS Last
     ,'Identification number:' As ' '   --Using Literals
	 ,employeeid AS 'Employee ID:' 
FROM employees
GO
											------------------------
--Using string literals
use AdventureWorks
SELECT (FirstName + ' '+ ISNULL(SUBSTRING(MiddleName, 1, 1), ' ') +' '+ LastName) AS FullName
FROM Person.Contact
ORDER BY  FirstName, MiddleName,LastName
											------------------------
--Using Expressions
use AdventureWorks;
SELECT Name, ProductNumber, ListPrice AS OldPrice, (ListPrice * 1.1) AS NewPrice
FROM Production.Product
WHERE ListPrice > 0 
AND (ListPrice/StandardCost) > .8
											--------------------------
SELECT Name, ProductNumber, ListPrice AS OldPrice, (ListPrice * 1.1) AS NewPrice
FROM Production.Product
WHERE SellEndDate < GETDATE()
											--------------------------
USE northwind
SELECT companyname
FROM customers
--Using String Comparisons
/*
		%				=> any number of characters
		_				=> single character
		[...,...,...]   => range of values
				[a-f]  looks for any of the letters in the sequence a – f
				[abcdef] also looks for any of the letters in the sequence a – f
		[^]				=> looks for all characters except those given in the range 
						or set
		[_]				=>look for '_' char 

*/
WHERE companyname LIKE '%Res[t,g]aur_nt%'
GO
										-----------------------------
USE northwind
SELECT productid, productname, supplierid, unitprice
FROM  products
--Using Logical Operators
WHERE (productname LIKE 'T%' OR productid = 46) 
AND  (unitprice > 16.00) 
GO 
										----------------------------
use ITI
select 	st_id 
from student 
where st_age like '2%' --age "int"										
										----------------------------
USE northwind
SELECT productname, unitprice
FROM products
--Retrieving a Range of Values
WHERE unitprice BETWEEN 10 AND 20
GO
										----------------------------
--Expressions
USE     northwind
SELECT  OrderID, ProductID
       ,(UnitPrice * Quantity) as ExtendedAmount
 FROM  "Order Details"       --i can use either [] or ""
 WHERE (UnitPrice * Quantity) > 10000
GO 
									-------------------------------										
USE northwind
SELECT companyname, country
FROM suppliers
--Using a List of Values as Search Criteria
WHERE country IN ('Japan', 'Italy')
GO
										----------------------------
USE northwind
SELECT companyname, fax
FROM suppliers
--Retrieving Unknown Values
WHERE fax IS NULL
--WHERE fax IS NOT NULL      
GO
										----------------------------
USE northwind
--Eliminating Duplicate Rows by using DISTINCT keyword
SELECT DISTINCT country
 FROM suppliers
 ORDER BY country
GO
									-------------------------
use AdventureWorks;
SELECT distinct LastName, FirstName, MiddleName
FROM Person.Contact
ORDER BY LastName, FirstName
									------------------------
--Ad Hoc Batches
USE northwind
SELECT * FROM products WHERE unitprice = $12.5
SELECT * FROM products WHERE unitprice = 12.5
SELECT * FROM products WHERE unitprice = $12.5
GO 
									-------------------------
use Intake29
select * into MyNewDataTable
from dbo.Student
-- 6 rows affected
/*
will create a new table called MyNewDataTable
with the same structure as student table and copies the data into it
*/
								----------------------------
use Intake29
select * into MyNewTable
from dbo.Student
where 1=0	--false condition 
--  0 rows affected
/*
will create a new table called MyNewTable
with the same structure of the student table 
but copies no data in it
*/
									---------------------------
USE AdventureWorks
GO
SELECT EmployeeID  AS 'Employee Identification Number'
, HireDate, VacationHours, SickLeaveHours
FROM HumanResources.Employee
WHERE HireDate > '01/01/2000'
									----------------------------
use AdventureWorks;
SELECT FirstName, LastName, Phone
FROM Person.Contact
WHERE EmailAddress IS not NULL;  --is null
									-----------------------------
use AdventureWorks
SELECT FirstName, LastName, MiddleName
FROM Person.Contact
WHERE ModifiedDate >= '01/01/2004'
-- comparison operator returns a boolean value
--"true , false , unknown"
									-----------------------------
use AdventureWorks
select * 
from Person .Contact
where  FirstName= 'John' 
AND NOT LastName = 'Smith'
									---------------------------
use AdventureWorks
SELECT OrderDate, AccountNumber, SubTotal
, TaxAmt
FROM Sales.SalesOrderHeader
WHERE OrderDate BETWEEN '08/01/2001' 
AND '08/31/2001'
									----------------------------
use AdventureWorks
SELECT OrderDate, AccountNumber
, SubTotal, TaxAmt
FROM Sales.SalesOrderHeader
WHERE OrderDate >= '08/01/2001' 
	AND OrderDate <= '08/31/2001'
									-----------------------------
use AdventureWorks;
SELECT SalesOrderID, OrderQty, ProductID, UnitPrice
FROM Sales.SalesOrderDetail
WHERE ProductID IN (750, 753, 765, 770)

--equivalent to

SELECT SalesOrderID, OrderQty
, ProductID, UnitPrice
FROM Sales.SalesOrderDetail
WHERE ProductID = 750 
OR ProductID = 753 
OR ProductID = 765 
OR ProductID = 770
									---------------------------------
--using union to Create a Single Result Set from Multiple Queries
USE northwind
SELECT  (firstname + ' ' + lastname) AS name ,city, postalcode
FROM employees
UNION			--union all --"to get the redundant data"
SELECT companyname, city, postalcode
FROM customers
GO
								----------------------------------
use Northwind
select orderid, productid, quantity
FROM [order details]
ORDER BY quantity DESC 
set rowcount  5
--Equivelent to
--Listing the TOP n Values
USE northwind
SELECT TOP 5       orderid, productid, quantity
FROM [order details]
ORDER BY quantity DESC   --Specifies the Range of Values in the ORDER BY Clause
						 --order the result set then retrieve the top n from it
GO
/*
		result : 10764,11072,10398,10451,10515
*/
				/***************/
--Returns Ties if WITH TIES Is Used

USE northwind
SELECT TOP 5 WITH TIES    /*
						  return the rows with the same quantity
						  of the retrieved rows from top n 
						  no matter the number of the rows retrieved are
							**WITH TIES** 
							Specifies that additional rows
							be returned from the base result set 
							with the same value in the ORDER BY columns 
							appearing as the last of the TOP n (PERCENT) rows.
							TOP ...WITH TIES can be specified only in SELECT statements,
							and only if an ORDER BY clause is specified.
						  */
		orderid, productid, quantity
FROM [order details]
ORDER BY quantity DESC      --have to be used with (top n with ties)
GO
			---------------------------
			--Using the COMPUTE clause
USE northwind
SELECT productid, orderid, quantity 
FROM [Order Details]
--ORDER BY productid, orderid
COMPUTE SUM(quantity)
GO
--Equivalent to 
select sum(quantity)
from [Order Details]
					  /***************/
USE northwind
SELECT productid, orderid, quantity 
FROM [Order Details]
ORDER BY productid, orderid
COMPUTE SUM(quantity) BY productid  --All expressions in the compute by 
									--list must also be present in the 
									--order by list with the same order.
COMPUTE SUM(quantity)
GO
--Both COMPUTE and COMPUTE BY can be used in the same query
use AdventureWorks

SELECT SalesOrderID, UnitPrice, UnitPriceDiscount
FROM Sales.SalesOrderDetail 
ORDER BY SalesOrderID 
COMPUTE SUM(UnitPrice), SUM(UnitPriceDiscount)

SELECT SalesPersonID, CustomerID, OrderDate, SubTotal, TotalDue 
FROM Sales.SalesOrderHeader 
ORDER BY SalesPersonID, OrderDate 
COMPUTE SUM(SubTotal), SUM(TotalDue) BY SalesPersonID
/*
One clear advantage for using COMPUTE & COMPUTE BYis that summary 
of information at different levels can be returned in a single call instead of 
multiple calls.
*/
									-----------------------------
USE northwind
SELECT productid, orderid, quantity
FROM [Order Details]
GO
								/***************/
/*
GROUP BY
1. Provides summarized data sets for aggregation functions
2. When using aggregation functions, columns in SELECT list must either be 
in a function or in the GROUP BY
3. Note that in the given GROUP BY example the column grouped on is in a joined table

HAVING
1. Can be used in lieu of WHERE
2. Filters grouping data after the grouping has occurred but before sent as results
*/
use AdventureWorks;

SELECT SalesOrderID, SUM(LineTotal) AS SubTotal
FROM Sales.SalesOrderDetail
GROUP BY SalesOrderID
ORDER BY SalesOrderID
 
SELECT SalesOrderID, SUM(LineTotal) AS SubTotal
FROM Sales.SalesOrderDetail
GROUP BY SalesOrderID
HAVING SUM(LineTotal) > 100000.00
ORDER BY SalesOrderID


select count(ContactID)  
from Person .Contact 
having count(ContactID) >500
--select ContactID  from Person .Contact having count(ContactID) >500 --error
/*can use having instead of where "col's in the select statment have to be 
contained in either an aggregate fn. or a group by clause"
*/
SELECT A.City, COUNT(E. EmployeeID) EmployeeCount
FROM HumanResources.Employee E 
INNER JOIN Person.Address A 
ON E.EmployeeID = A.AddressID 
GROUP BY A.City 
ORDER BY A.City;

SELECT DATEPART(yyyy,OrderDate) AS 'Year' 
,SUM(TotalDue) AS 'Total Order Amount' 
FROM Sales.SalesOrderHeader 
GROUP BY DATEPART(yyyy,OrderDate) 
HAVING DATEPART(yyyy,OrderDate) >= '2003' 
ORDER BY DATEPART(yyyy,OrderDate)
					---------------------------------------
USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM [Order Details]
GROUP BY productid
GO
				/***************/
USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM [Order Details]
WHERE productid = 2     --Only rows that satisfy 
						--the WHERE clause are grouped

GROUP BY productid
GO
				/***************/

USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM [Order Details]
GROUP BY productid
HAVING SUM(quantity)>=30   --Using the GROUP BY Clause
						   --with the HAVING Clause(filtering)
GO
				/***************/

					 /***************/ 
/*
Join between multiple tables to display the following
Category		Sub Category		Product
*/
use AdventureWorks;
SELECT  Production.Product.Name, Production.ProductCategory.Name AS category, Production.ProductSubcategory.Name AS Subcategory
FROM    Production.ProductCategory 
        INNER JOIN 
        Production.ProductSubcategory 
        ON Production.ProductCategory.ProductCategoryID = Production.ProductSubcategory.ProductCategoryID
        INNER JOIN
        Production.Product
        ON Production.ProductSubcategory.ProductSubcategoryID = Production.Product.ProductSubcategoryID
					--------------------------
--equo join
use ITI
select st_fname,Dept_Name 
from student s,department d
where s.Dept_Id=d.Dept_Id

--inner join
select st_fname,Dept_Name 
from student s inner join department d
on s.Dept_Id=d.Dept_Id

--left outer join
select st_fname,Dept_Name 
from student s left outer join department d
on s.Dept_Id=d.Dept_Id

--right outer join
select st_fname,Dept_Name 
from student s right outer join department d
on s.Dept_Id=d.Dept_Id

--full outer join
select st_fname,Dept_Name 
from student s full outer join department d
on s.Dept_Id=d.Dept_Id
									---------------------------
use AdventureWorks									
 
--outer join(left)
--display all products, regardless of whether a review has been written for one
SELECT p.Name, pr.ProductReviewID
FROM Production.Product p
LEFT OUTER JOIN Production.ProductReview pr
ON p.ProductID = pr.ProductID

--outer join(right)
--display all sales persons in the results, regardless of whether they are assigned a territory
SELECT st.Name AS Territory, sp.SalesPersonID
FROM Sales.SalesTerritory st 
RIGHT OUTER JOIN Sales.SalesPerson sp
ON st.TerritoryID = sp.TerritoryID ;

--full outer join
-- The OUTER keyword following the FULL keyword is optional.
SELECT p.Name, sod.SalesOrderID
FROM Production.Product p
FULL OUTER JOIN Sales.SalesOrderDetail sod
ON p.ProductID = sod.ProductID
WHERE p.ProductID IS NULL
OR sod.ProductID IS NULL
ORDER BY p.Name ;

--cross join
SELECT p.SalesPersonID, t.Name AS Territory
FROM Sales.SalesPerson p
CROSS JOIN Sales.SalesTerritory t
ORDER BY p.SalesPersonID

--self join
--find the products that are supplied by more than one vendor.
SELECT DISTINCT pv1.ProductID, pv1.VendorID
FROM Purchasing.ProductVendor pv1
INNER JOIN Purchasing.ProductVendor pv2
ON pv1.ProductID = pv2.ProductID
    AND pv1.VendorID <> pv2.VendorID
ORDER BY pv1.ProductID

-- except
--returns any distinct values from the left query that are not also found on the right query, and is used to exempt members from a result set.
SELECT ProductID 
FROM Production.Product
EXCEPT
SELECT ProductID 
FROM Production.WorkOrder

-- intersect
--returns any distinct values that are returned by both the query on the left and right sides of the INTERSECT operand, and is used to determine which tables share similar data.
SELECT ProductID 
FROM Production.Product
INTERSECT
SELECT ProductID 
FROM Production.WorkOrder

