--Create Default--
------------------------------
create default dcity as 'Cairo'
--bind default to column in table student
sp_bindefault dcity,'student.st_address'

sp_bindefault dcity, 'emp3.Address';

--try to insert data
insert into student(St_Id,St_Fname) values(667,'khalid') --city will entered as defaut 'tanta'
--go to table to see reflection
--drop the default from db
drop default dcity  --cann't drop because it is bound to a column
--unbind default from the column
sp_unbindefault 'student.st_address'
--then drop default
---------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------

--Create Rule--
--------------------------
--as check constraint
create rule rule1 as @Col>10 --@salary is a variable refers to the bounded column
--bind to table
sp_bindrule rule1,'student.st_age'


sp_bindrule rule1,'emp3.Salary';

--try it
insert into student(St_Id,St_Age) values(865,4)
--drop rule
drop rule r_age  --cann't drop because it is bound to a column	
--Unbind rule
sp_unbindrule 'student.st_age'
--then drop rule
---------------------------------------------------------------------------------------
CREATE TYPE NameUDD FROM Nvarchar(30)  ;
go
------------------
CREATE TYPE AgeUDD FROM int  ;
go
create default dforAge as 18;
go
create rule rforAge as @a>=18;
go
sp_bindefault dforAge, AgeUDD;
go
sp_bindrule  rforAge,AgeUDD;
go

create table Intake35Students
(
	id int,
	age AgeUDD -- int, default 18, check constranint >=18
)
-------------------------------------------------------------------------------------

