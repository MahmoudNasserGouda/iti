--Triggers
/*
CREATE TRIGGER trigger_name
ON {table|view}
[WITH ENCRYPTION]
{
{{FOR {AFTER|INSTEAD OF} {[INSERT] [,] [UPDATE] [,] [DELETE]}
AS
[{IF [UPDATE (column)
[{AND|OR} UPDATE (column)]] ]
COLUMNS_UPDATE()]
sql_statements}}
http://msdn.microsoft.com/en-us/library/ms189799.aspx
http://www.dotnet-tricks.com/Tutorial/sqlserver/OJ97170312-Different-Types-of-SQL-Server-Triggers.html
*/
/*A powerful tool that can be used when creating DDL triggers is the
EVENTDATA() function. Any time a DDL trigger fires, the information
about the trigger is captured in the EVENTDATA() function as XML data.*/
--Add a trigger to prevent the modification of any tables within the
--Sales database with the following code:

USE Master;
GO

CREATE DATABASE Sales2;

GO
USE Sales2;
GO
--DDL Trigger
create TRIGGER trgNoChange
ON DATABASE --define the scope
 after ALTER_TABLE -- with DDL we can use After trigger only.
AS
begin
	rollback;
	PRINT 'User can not change on a table'
end

							/****************/
USE Sales2;
GO


CREATE TABLE Customers 
(
	CustomerID int NOT NULL,
	LName varchar(50) NOT NULL,
	FName varchar(50) NULL,
	[Status] varchar (10) NULL,
	ModifiedBy varchar(30) NULL
)

alter table Customers drop column CustomerID

go

drop trigger trgNoChange

----------------------------------------------------
--DML Triggers
--Trigger on table
Create trigger PreventDelete
on Customers instead of delete
as 
begin
	print 'You can not delete form this table'	
end

delete from Customers

drop trigger PreventDelete

--Add an UPDATE trigger on the Customers table with the following code:
alter TRIGGER trgRecordModifyDate
ON Customers
AFTER UPDATE
AS
begin
IF UPDATE (LName)
	begin
		--DECLARE @CustomerID int;
		--SET @CustomerID = 
						--(SELECT CustomerID FROM inserted);
		UPDATE Customers
		SET ModifiedBy = suser_sname()
		--WHERE CustomerID = @CustomerID;
		WHERE CustomerID in (SELECT CustomerID FROM inserted);
	end
end

select * from Customers
--Modify the customer data with the following query:
UPDATE Customers
SET LName = 'test'
WHERE CustomerID = 1

UPDATE Customers
SET LName = 'iti'
WHERE CustomerID = 2
--Modify fname
UPDATE Customers
SET FName = 'SQL'
WHERE CustomerID = 2

UPDATE Customers
SET LName = 'test'
WHERE CustomerID in (4,5)

--This causes the UPDATE trigger to fire and add data to the ModifiedBy column.
--View your new customer data with the following query:
SELECT * FROM Customers
--You should see that the ModifiedBy column is no longer NULL.
--=================*****************===========
go
--Add an INSTEAD OF DELETE trigger to prevent the deletion of customers
--with the following code:
alter TRIGGER trgNoDelete
ON Customers
INSTEAD OF DELETE
AS
		--RAISERROR ('Customers can’’t be deleted. Customer
				--changed to inactive instead.', 16, 10) WITH LOG			
		UPDATE Customers
		SET [Status] = 'Inactive'
		where CustomerID in (select CustomerID from deleted)
		--FROM Customers as c INNER JOIN deleted as d
		--ON c.CustomerID = d.CustomerID

--note The trigger is an INSTEAD OF trigger, so the actual DELETE statement
--doesn’t fire.
--Try to delete a customer with the following code:
DELETE FROM Customers
Where CustomerID = 2

DELETE FROM Customers
Where CustomerID in (1,3)
--Instead of deleting the customer, the message Customers can’t be deleted.
--Customer changed to inactive is displayed.
--View your new customer data with the following query:
SELECT * FROM Customers
--The status has been changed to Inactive.




--====================================================================--
