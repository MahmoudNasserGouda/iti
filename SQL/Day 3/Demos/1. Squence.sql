--Create Sequence

--To create a Sequence in SQL Server 2012 is very simple. You can create it with SQL Server Management Studio or T-SQL.

    --Create Sequence with SQL Server Management Studio
    --In Object Explorer window of SQL Server Management Studio, there is a Sequences node under Database -> [Database Name] -> Programmability. You can right click on it to bring up context menu, and then choose New Sequence… to open the New Sequence window. In New Sequence window, you can define the new Sequence, like Sequence Name, Sequence schema, Data type, Precision, Start value, Increment by, etc. After entering all the required information, click OK to save it. The new Sequence will show up in Sequences node.
    --Create Sequence with T-SQL
    --The following T-SQL script is used to create a new Sequence: 

-- Create seq progromatically:
CREATE SEQUENCE DemoSequence
START WITH 1
INCREMENT BY 1;

-- Use Sequence
----The new NEXT VALUE FOR T-SQL keyword is used to get the next sequential number from a Sequence.
SELECT NEXT VALUE FOR DemoSequence

--Use it for insert

insert into [dbo].[Customers] ([CustomerID],[LName],[FName]) 
values(NEXT VALUE FOR DemoSequence,'fff','rrr');

-- Reset squence
ALTER SEQUENCE DemoSequence RESTART WITH 1 ;

-- column can be updated
update [dbo].[Customers]
set [CustomerID]=33
where [CustomerID]=8

--One thing I want to mention in here is Sequence doesn’t support transaction, if you run this script:
BEGIN TRAN
SELECT NEXT VALUE FOR dbo.DemoSequence
ROLLBACK TRAN