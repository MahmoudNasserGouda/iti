--Day 6 Lab Assignments

--1.	Create backup from your database (using three types) and try to restore it  after drop.
--a.	Explain when to use each type.

--Full backup:
BACKUP DATABASE MyDatabase TO DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_full.bak';
RESTORE DATABASE MyDatabase_Restored FROM DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_full.bak';

--Differential backup:
BACKUP DATABASE MyDatabase TO DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_diff.bak' WITH DIFFERENTIAL;
RESTORE DATABASE MyDatabase_Restored FROM DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_diff.bak' WITH RECOVERY;

--Transaction log backup:
BACKUP LOG MyDatabase TO DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_log.bak';
RESTORE LOG MyDatabase_Restored FROM DISK = 'F:\computer science\iti\SQL\lab\day8\MyDatabase_log.bak' WITH RECOVERY;

------------------------------------------------------------------------------------------------------------------------------------------

--3.	Create a  clustered index on Employee table (EmpNo column).
--a.	 can it be created yes or no and why?

CREATE CLUSTERED INDEX IX_Employee_ID ON [HR].[Employee]([EmpNo])

--b.	If not, create new table, and try to create cluster index on the ID column of it.

CREATE TABLE NewEmployee
(
    EmpNo INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    HireDate DATE
)

CREATE CLUSTERED INDEX IX_NewEmployee_ID ON [dbo].[NewEmployee]([EmpNo])

--c.	Can you create a clustered index on a column that isn’t a primary key?
--d.	Does SQL server create a clustered index on the primary kery as default?
--e.	Can you change it and make it as a non-clustered index and create a clustered index on other column?

-----------------------------------------------------------------------------------------------------------------------------------------------------

--4.	Create non-clustered index on name column in employee table.
--a.	What's an index? And what's its advantages and disadvantages? Why we use it?
--b.	What's the difference between clustered and non-clustered index?

CREATE NONCLUSTERED INDEX IX_Employee_Name ON [HR].[Employee]([EmpFname],[EmpLname])