-- http://msdn.microsoft.com/en-us/library/ms179932.aspx
-- http://msdn.microsoft.com/en-us/library/ms174365.aspx
--Returns DB files and groups
select * 
from sys.database_files
									------------------
--returnes information about attached DBs
use master
select * from sys.databases
									------------------
--To check the value of a specific db property
SELECT DATABASEPROPERTYEX
('AdventureWorks', 'IsAutoShrink');

SELECT DATABASEPROPERTYEX
('AdventureWorks', 'Collation');
									----------------	
--Retrieve Info about all objects
sp_help

--Retrieving Info about all dbs
sp_helpdb 

--Retrieving Info about a specific db
sp_helpdb AdventureWorks

--To retrieve info. about a specific DataType
sp_help nvarchar
/*Type_name:nvarchar		Storage_type:nvarchar
    Length: 8000					Prec :4000
    Scale:NULL					Nullable:  yes
    Default_name:none		Rule_name:  none
    Collation:SQL_Latin1_General_CP1_Cl_AS 
*/
								------------------
--Retrieving Info about the db size, unallocated space
--data size, index size, free "unused" space
use ITI
go
sp_spaceused 
								------------------
				/** MetaData Fn (scalar fn.) **/
--select ID of the current Database
select DB_ID()

--select name of the current Database
SELECT DB_NAME() AS 'database'    


select file_id( N'Northwind')  --Returns the file ID for the given
							   --logical file name in the current database.

select FILE_NAME(1)			   --Returns the logical file name
							   --for the given file ID.

select FILEGROUP_ID('primary') --Returns the filegroup ID for
							   -- a specified filegroup name.

select FILEGROUP_NAME(1)	   --Returns the filegroup name
							   --for the specified filegroup ID.
									------------------------
exec sys.sp_databases
									------------------------	
--Returns one row for each column of an object that contains columns
--(for example, a table or a view)a row of each column in that table
--columns of the same table will have the same obj_id
select * 
from sys.columns

select * 
from sys.tables

select * 
from sys.schemas
									-------------------------																
--You can query the sys.filegroups catalog view 
--to view the files in the newly created database:
USE MyNewDB
GO
SELECT fg.name as file_group,
df.name as file_logical_name,
df.physical_name as physical_file_name
FROM sys.filegroups fg
join sys.database_files df
on fg.data_space_id = df.data_space_id	
				------------------------------
--getting the schemas from specified db
SELECT name,
SCHEMA_NAME(schema_id) as schemaName,
USER_NAME(principal_id) as principal
FROM AdventureWorks.sys.schemas	
				--------------------------------
--To retrieve data about tables in a specific schema
SELECT TABLE_NAME
FROM AdventureWorks.INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'Purchasing'
ORDER BY TABLE_NAME	
				-------------------------------
--Retrieving MetaDate about a DB file "data file"
select * from sys.database_files
where name='AdventureWorks_Data'				
				------------------------------
--To see the constraints created on a specific table
use ITI
sp_helpconstraint emp										