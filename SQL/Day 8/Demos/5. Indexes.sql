--indexes---
--table scan is a scan that reads every row in a table
--table that does not have any indexes created on it can be searched only via a table scan
--An index is an on-disk structure associated with a table or view that speeds retrieval of rows from the table or view. An index contains keys built from one or more columns in the table or view. These keys are stored in a structure (B-tree) that enables SQL Server to find the row or rows associated with the key values quickly and efficiently.
/*
--Clustered 
Clustered indexes sort and store the data rows in the table or view based on their key values. These are the columns included in the index definition. There can be only one clustered index per table, because the data rows themselves can be sorted in only one order. 
A clustered index stores the actual data rows at the leaf level of the index.
The only time the data rows in a table are stored in sorted order is when the table contains a clustered index. When a table has a clustered index, the table is called a clustered table. If a table has no clustered index, its data rows are stored in an unordered structure called a heap. 


--Nonclustered 
Nonclustered indexes have a structure separate from the data rows. A nonclustered index contains the nonclustered index key values and each key value entry has a pointer to the data row that contains the key value. 
The pointer from an index row in a nonclustered index to a data row is called a row locator. The structure of the row locator depends on whether the data pages are stored in a heap or a clustered table. For a heap, a row locator is a pointer to the row. For a clustered table, the row locator is the clustered index key.
Unlike a clustered indexed, the leaf nodes of a nonclustered index contain only the values from the indexed columns and row locators that point to the actual data rows, rather than contain the data rows themselves. This means that the query engine must take an additional step in order to locate the actual data.
--Allow Null, and Allow repaeat data

--Unique
A unique index ensures that the index key contains no duplicate values and therefore every row in the table or view is in some way unique.
A unique index is automatically created when you define a primary key or unique constraint
*/
--Indexes basics
-- http://msdn.microsoft.com/en-us/library/ms190457.aspx
--Indexes types
-- http://msdn.microsoft.com/en-us/library/ms175049.aspx
--Implementing Indexes
-- http://msdn.microsoft.com/en-us/library/ms180857.aspx

--Simple explanation for Indexes
-- http://www.codeproject.com/Articles/190263/Indexes-in-MS-SQL-Server
-- https://www.simple-talk.com/sql/learn-sql-server/sql-server-index-basics/
-- http://www.programmerinterview.com/index.php/database-sql/clustered-vs-non-clustered-index/
----------------------------------------------------------------------------
drop  table stud
go
create table stud
(
id int,
sname nvarchar(50),
sal int,
age int
)



--indexing affect with the existing data
insert into stud(id) values (3)
insert into stud(id) values (1)

insert into stud(id,sal) values (9,99)
insert into stud(id,sal) values (7,11)

select * from stud 
 
create clustered index cindex
	on stud(id)

insert into stud(id,sal) values (5,11)

create nonclustered index cindex2
	on stud(sal)

select sname,age from  stud
where sname ='e'

create unique index uni_index  
on stud(age)

drop index stud.uni_index
---------------
--table can have one clustered index
--table can have up to 249
use ITI
--1)unique index
create unique index uni_index
on stud(sname)

drop index student.non_uni_index
---unique nonclustered noncomposite

--2)non unique index

create index non_uni_index  
on student(st_fname)

--3)clustured index
create clustered index clus_ind --nonclustered
on department(Dept_Manager)

--5)composite index
--6)non composite attribute

-----------------------------------------------------------------------------
--the TerminationReason table was created without a primary key defined,
--meaning that initially, the table was a “heap.” 
--The primary key was then added afterward using ALTER TABLE.
--The word CLUSTERED follows the PRIMARY KEY statement,
--thus designating a clustered index with the new constraint
USE AdventureWorks
GO
drop table HumanResources.TerminationReason
go
CREATE TABLE HumanResources.TerminationReason(
TerminationReasonID smallint IDENTITY(1,1) NOT NULL,
TerminationReason varchar(50) NOT NULL,
DepartmentID smallint NOT NULL,
CONSTRAINT FK_TerminationReason_DepartmentID
FOREIGN KEY (DepartmentID) REFERENCES
HumanResources.Department(DepartmentID)
)
---create pk (Clustered)
ALTER TABLE HumanResources.TerminationReason
ADD CONSTRAINT PK_TerminationReason 
PRIMARY KEY CLUSTERED (TerminationReasonID)


ALTER TABLE HumanResources.TerminationReason
drop CONSTRAINT PK_TerminationReason 

---create pk (NONClustered)
ALTER TABLE HumanResources.TerminationReason
ADD CONSTRAINT PK_TerminationReason 
PRIMARY KEY NONCLUSTERED (TerminationReasonID)
---------


CREATE CLUSTERED INDEX CI_TerminationReason_TerminationReasonID ON
HumanResources.TerminationReason (TerminationReason)
---------------------------
CREATE NONCLUSTERED INDEX NCI_TerminationReason_DepartmentID ON
HumanResources.TerminationReason (DepartmentID)
