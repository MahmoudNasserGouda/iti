-- http://msdn.microsoft.com/en-us/library/ms186986.aspx
/*
Local Temporary Tables:
------------------------
Local temporary tables are the tables stored in tempdb. Local temporary tables are temporary tables that are available only to the session that created them. These tables are automatically destroyed at the termination of the procedure or session. They are specified with the prefix #, for example #table_name and these temp tables can be created with the same name in multiple windows. 
*/
create table #myTbl
(
		ID int identity Primary Key,
		Name nvarchar(20)
)
-- its lifetime for current session only
--exists in tempdb=>Temporary Tables
insert into #myTbl(Name)
values ('Karim')
,('Mostafa')
,('Ibrahim') 
go
select * from #myTbl
go

--try to open a new query and repeat the previous query
--Invalid object name '#temp'
							-------------------


/*Global Temporary Tables:  
--------------------------
Global temporary tables are also stored in tempdb. Global temporary tables are temporary tables that are available to all sessions and all users. They are dropped automatically when the last session using the temporary table has completed. They are specified with the prefix #, for example ##table_name.
*/
use tempdb
create table ##MySharedTemp
(
		ID int identity Primary Key,
		Name nvarchar(20)
)
--exists in tempdb=>Tables
--dbo.MySharedTemp
use tempdb
insert into ##MySharedTemp(Name)
values ('Karim')
,('Mostafa')
,('Ibrahim') 
go	
use tempdb;				
select * from ##MySharedTemp
--open a new Query and write the following query
use tempdb
select * from dbo.##MySharedTemp 
--data will be retrieved	
--will be removed when
--			1. Drop it manually
--			2. Restart the server				
				------------------------------