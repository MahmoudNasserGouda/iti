/*
SQL Server 2005 introduces the concept of a synonym: 
a single-part name that can replace a two-, three-, or 
four-part name in many SQL statements. Using synonyms 
lets you cut down on typing 
*/
create synonym mySyn 
for HumanResources.Employee
--exists in Synonyms=>mySyn
				-----------------------
select * from HumanResources.Employee;
--------------------
select * from mySyn
				-----------------------


-------------------------------------------
select s.st_lname from newschema.Student as s
-----------------------------------------

create synonym s
for newschema.student

select *from s
				-----------------------

				------------------------
				
