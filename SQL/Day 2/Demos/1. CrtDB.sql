--creates a database with explicit specifications for
--database and transaction log files.
--Because the PRIMARY option is omitted
--the first file is assumed as the primary file
--If the MAXSIZE option is not specified
--or is set to UNLIMITED, the file will grow until the disk is full
--if ON exists all files of db must be specified

--create db
USE master;
create database test;

--defining more options
CREATE DATABASE projects
ON 
(
	NAME=projects_dat, --logical name
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\projects_dat.mdf',
	SIZE = 5,
	MAXSIZE = 10,
	FILEGROWTH = 2
)
LOG ON
(
	NAME=projects_log,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\projects_log.ldf',
	SIZE = 1,
	MAXSIZE = 10,
	FILEGROWTH = 1
);	

-- more than data file
CREATE DATABASE projects
ON 
(
	NAME=projects_dat,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\projects_dat.mdf',
	SIZE = 3,
	MAXSIZE = 10,
	FILEGROWTH = 2
),
(
	NAME=projects1_dat,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\projects1_dat.ndf',
	SIZE = 3,
	MAXSIZE = 10,
	FILEGROWTH = 2
)
LOG ON
(
	NAME=projects_log,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\projects_log.ldf',
	SIZE = 4,
	MAXSIZE = 10,
	FILEGROWTH = 1
);	
		

			------------------------------
			
--create db with file groups
CREATE DATABASE MyNewDB 
ON
--PRIMARY --optional
( 
	NAME = Df1, 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df1.mdf',
	SIZE = 3MB--at least 3 M
),
( 
	NAME = Df2, 
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df2.ndf',
	SIZE = 3MB
),
FILEGROUP SECONDARY_fg 
( 
	NAME = Df3,
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df3.ndf',
	SIZE = 1
),
( 
	NAME = Df4,
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\Df4.ndf',
	SIZE = 1MB
)
LOG ON 
( 
	NAME = Log1,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\lg1.ldf', 
	SIZE = 1MB
);

-- alter db to make filegroup is the default
ALTER DATABASE MyNewDB 
  MODIFY FILEGROUP 
  SECONDARY_fg DEFAULT;
GO

--Alter db to add new filegroup
USE master;
ALTER DATABASE MyNewDB
ADD FILEGROUP FGNew
GO

--Alter db to add secondary file
ALTER DATABASE MyNewDB
ADD FILE
( 
	NAME = 'DFNew',
	FILENAME ='C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\DFNew.ndf',
	SIZE = 2MB,
	MAXSIZE=5,
	FILEGROWTH=1
)
TO FILEGROUP FGNew;				
				-------------------------------
use master ;

alter database myDB
Remove file df1
--The file 'df1' cannot be removed because it is not empty
			-------------------------------

--drop db -- detach, delete DB files
drop database projects;	


-- Create a table in the user-defined filegroup.
--This command assigns the table to the filegroup, but not to any particular file.
--Where in files the object is created is strictly out of your control
USE MyNewDB;
CREATE TABLE MyTable
  (
	    colA int PRIMARY KEY,
		colB char(8) 
    )
ON SECONDARY_fg;
GO			
				-------------------------------

			-------------------------------	