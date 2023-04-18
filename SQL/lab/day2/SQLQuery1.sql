--1.	Create the following database “Programatically”:
--•	Database Name: Net23-Company 
--•	Data File Name: Net23-Company-Data 
--•	Location: (Default path) 
--•	Initial size: 10MB 
--•	File Group: Primary 
--•	File Growth: 10 percent 
--•	Max. File Size: 50 MB 
--•	Log File Name: Net23-Company-Log 
--•	Location: (Default) 
--•	Initial Size: 5MB 
--•	File Growth: 10 Percent 
--•	Log File Max. Size: 40MB

CREATE DATABASE [Net23-Company]
ON 
(
	NAME=[Net23-Company-Data], --logical name
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Net23-Company-Data.mdf',
	SIZE = 10MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 10%
)
LOG ON
(
	NAME=[Net23-Company-Log],
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Net23-Company-Log.ldf',
	SIZE = 5MB,
	MAXSIZE = 40MB,
	FILEGROWTH = 10%
);

USE [Net23-Company]

--2.	Create the following tables with all the required information and insert the required data as specified in each table using insert statements[at least two rows]:
--a.	Table name: Department (Programatically)
--i.	Columns: 
--1.	DeptNo: int , PK.
--2.	DeptName: Nvarchar(20)
--a.	Why did we choose Nvarchar Data type not Nchar or varchar?
--3.	Location: Nchar(2)
--a.	Why did we choose Nchar data type not Nvarchar?
--b.	Can we make the data type for that column as char(2)?
--ii.	Table values of location should be one of the following values only (NY,DS,KW)), do what’s required to make sure that user can’t enter any different values than the prev. defined values.
--iii.	Make the location column value ”NY” as a default value in case of user didn’t insert it.

CREATE TABLE Department
(
	DeptNo Nchar(2),
	CONSTRAINT DepartmentPK primary key (DeptNo),
	DeptName Nvarchar(20),
	[Location] Nchar(2) DEFAULT 'NY',
	CONSTRAINT locationVal CHECK ([Location] IN ('NY','DS','KW')),
);

--b.	Create the following tables, and use Suitable data types and constraints:

CREATE TABLE Employee
(
	EmpNo int, --IDENTITY(1,1),
	CONSTRAINT EmployeePK primary key (EmpNo),
	EmpFname Nvarchar(20) not null,
	EmpLname Nvarchar(20) not null,
	DeptNo Nchar(2),
	CONSTRAINT DepartmentFK foreign key (DeptNo) references Department(DeptNo),
	Salary int UNIQUE,
	CONSTRAINT SalaryChk CHECK (Salary > 700 and Salary < 6000)
);

CREATE TABLE Project
(
	ProjectNo Nchar(2),
	CONSTRAINT ProjectPK primary key (ProjectNo),
	ProjectName Nvarchar(20) not null,
	Budget int
);

CREATE TABLE Works_on
(
	EmpNo int not null,
	ProjectNo Nchar(2) not null,
	Job Nvarchar(20),
	Enter_Date DateTime not null Default GETDATE(),
	CONSTRAINT WorksonPK primary key (EmpNo,ProjectNo),
	CONSTRAINT EmployeeFK foreign key (EmpNo) references Employee(EmpNo),
	CONSTRAINT ProjectFK foreign key (ProjectNo) references Project(ProjectNo)
);

--3.	Modify the tables as following:
--a.	Add  TelephoneNumber column to the employee table[programmatically]
--b.	drop this column[programmatically]

ALTER TABLE Employee
ADD TelephoneNumber Nchar(10)

ALTER TABLE Employee
DROP COLUMN TelephoneNumber

--5.	Delete the primary key of the Employee table. Why it will not work?
--a.	Can a Primary key refer to Unique key instead of Foreign key?

ALTER TABLE Employee
DROP COLUMN EmpNo

--6.	Insert at least 3 records (Programatically) in each table from the data shown in the above image, and the other records you can insert them Visually.
--7.	Try update and Delete on the previous data.

INSERT INTO [dbo].[Employee]
values(25348,'Mathew','Smith','d3',2500),(10102,'Ann','Jones','d3',3000),(18316,'John','Barrimore','d1',2400)

INSERT INTO [dbo].[Project]
values('p1','Apollo',120000),('p2','Gemini',95000),('p3','Mercury',185600)

INSERT INTO [dbo].[Works_on]
values(10102,'p1','Analyst'),(10102,'p3','Manager'),(25348,'p2','Clerk')

UPDATE [dbo].[Employee]
set DeptNo = 'd1'
where EmpNo = 25348

DELETE [dbo].[Project]
where ProjectName = 'Apollo'

--a.	Testing Referential Integrity:
--i.	Add new employee with EmpNo =11111 In the works_on table [Is there error what is it].

INSERT INTO [dbo].[Works_on]

values(11111,'p1','Analyst')
--ii.	Change the employee number 10102  to 11111  in the works on table [is there error what is it].

UPDATE [dbo].[Works_on]
set EmpNo = 11111
where EmpNo = 10102

--iii.	Modify the employee number 10102 in the employee table to 22222. [is there error what is it].

UPDATE [dbo].[Employee]
set EmpNo = 22222
where EmpNo = 10102

--iv.	Delete the employee with id 10102

DELETE [dbo].[Employee]
where EmpNo = 10102