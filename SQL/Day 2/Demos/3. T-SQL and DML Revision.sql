/*
T-SQL Queries Types:
	DML (Data Manipulation Language): used to retrieve, store, modify, delete, insert and update data in database (Examples: select, insert, update, delete statements).
	DDL (Data Definition Language): used to create and modify the structure of database objects in database (Examples: CREATE, ALTER, DROP statements).
	DCL (Data Control Language): used to control access to database and securing it (Examples: GRANT, REVOKE, Deny statements)
	TCL (Transactional Control Language): used to manage different transactions occurring within a database (Examples: COMMIT, ROLLBACK statements).

*/

				--Modifying Data
		/** Inserting a Row of Data by Values **/
USE northwind
INSERT customers
	(customerid, companyname, contactname, contacttitle,address, 
	 city, region, postalcode, country, phone,fax)
VALUES ('PECOF', 'Pecos Coffee Company', 'Michael Dunn','Owner',
	    '1900 Oak Street', 'Vancouver', 'BC','V3F 2K1', 'Canada',
	    '(604) 555-3392','(604) 555-7293')
GO
		/** Using the INSERT…SELECT Statement **/
USE northwind
INSERT into customers
		SELECT substring(firstname, 1, 3)+ substring (lastname, 1, 2)
			   ,lastname, firstname, title, address, city
			   ,region, postalcode, country, homephone, NULL
		FROM employees
GO
		/** Inserting Data by Using Column Defaults **/
/*
	1-	Inserts default values for specified columns
	2-	Columns must have a default value or allow null values
*/
USE northwind
INSERT shippers (companyname, phone)
VALUES ('Kenya Coffee Co.', DEFAULT)
GO

select * 
from shippers 
where companyname='Kenya Coffee Co.'
----------------------------------------------------------------------------
		/** Using the DELETE Statement **/
USE northwind
DELETE orders 
WHERE DateDiff(MONTH, shippeddate, GETDATE()) >= 6
GO 
		/** Using the TRUNCATE TABLE Statement **/
USE northwind
TRUNCATE TABLE customer		--drop
GO 
----------------------------------------------------------------------------
		/** Updating Rows Based on Data in the Table **/
USE northwind
UPDATE products
SET unitprice = (unitprice * 1.1)
GO
					-----------------------------------
use ITI
--inserting more than 1 row in the same statment					
insert into dbo.Student
values('10','Sally','','24','','4')
,('11','Sally2','','24','','4')		
					----------------------------------
/** Creating a Table Using the SELECT INTO Statement **/
USE northwind
SELECT productname AS products,unitprice AS price,(unitprice * 1.1) AS tax
INTO #pricetable
FROM products
GO

select * from #pricetable		--Temporary table
					----------------------------------								