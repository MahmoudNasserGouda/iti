--User defined Data Types--
use Intake29
--Creating user defined data type
CREATE TYPE SSN FROM varchar(11) NOT NULL ;
--OR
sp_addtype new_dtype,'nvarchar(50)','not null'
--exists in Programmability=>Types=>User-Defined Data Types

--Removing user defined Data type
drop type SSN
--OR
sp_droptype new_dtype
			-----------------------
--Using User defined data type on a table
create table emp 
(
IDNo ssn,
Name nvarchar(50)
)

alter table student
alter column st_fname new_dtype

			------------------------	
--Table data type
/*
In Sql Server 2008 you can pass a table variable in a stored procedure as 
a parameter. now you have the ability to send multiple rows of data in 
a stored procedure.one main advantage of that is that it will reduce the amount 
of round trips to the server. 
*/
								------------------------------
create type customertype as table
(
		Cust_ID int not null
		,Cust_Name varchar(50)
		,Cust_Surname varchar(50)
		,Cust_Email varchar(50)
)
go
-- Creating variable from User defined table
declare @c customertype
insert into @c values (1,'steven','gerrard','sg@liverpool.com')
insert into @c values (2,'jamie','caragher','jc@liverpool.com')
select * from @c	