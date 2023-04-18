--Creat etable
use ITI;
create table emp1
(
EmpID int ,
EmpName nvarchar(50),
Salary int
);
------------------------------------------------------------
--create table on specific file group
USE MyNewDB;
CREATE TABLE MyTable
  (
	    colA int ,
		colB char(8) 
    )
ON SECONDARY_fg;
GO			
-----------------------------------
--create table on specific Schema
use ITI;
create schema sd;
go
create table sd.emp2
(
EmpID int  primary key,
EmpName nvarchar(50),
Salary int
)



---------------------------------------------------
--create table with constraints
use Testdb1;
create table emp3
(
EmpID int  primary key,
EmpName nvarchar(50) not null,
Salary int unique
,[Address] nvarchar(50) default 'cairo'
,overtime int
,did int

,constraint c4 check (overtime between 100 and 1000)
--,constraint c3 primary key(EmpID)
,constraint c2 check ([Address] in ('cairo','alex'))
,constraint c5 foreign key(did) references Dept(ID),
constraint c1 check (Salary>100)
)

--Altering table
-- Altering table (Add column)
alter table emp1
add  zipcode int
--Altering table (Remove column)
alter table emp1
drop column zipcode
--Altering table (Changing column data type)
alter table emp1
alter  column zipcode nvarchar(11)
--------------------------------
--Altering table(Add Constraint)
alter table emp1
add constraint c55 unique (EmpName)
--Altering table (Remove constraint)
alter table emp1
drop constraint c55

--Displaying constraints on specific table
sp_helpconstraint '[dbo].[Student]'