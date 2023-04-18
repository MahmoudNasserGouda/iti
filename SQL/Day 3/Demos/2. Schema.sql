use ITI 
create schema sd;
--exists in Security=>Schemas
		------------------------ 
--create table on specific Schema
use ITI;
create table sd.emp2
(
EmpID int  primary key,
EmpName nvarchar(50),
Salary int
)
-------------------------
--to move an existing table to my new schema
alter schema sd 
transfer dbo.Instructor 
		-------------------------
		