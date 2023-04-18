use Intake29
/* 
Creating Partitioned Tables and Indexes
http://msdn.microsoft.com/en-us/library/ms188730.aspx
Planning Guidelines for Partitioned Tables and Indexes
http://msdn.microsoft.com/en-us/library/ms180767.aspx
Implementing Partitioned Tables and Indexes
http://msdn.microsoft.com/en-us/library/ms190199.aspx

The steps for creating a partitioned table or index include the following: 

1.Create a partition function to specify how a table or index that uses the function can be partitioned.

2.Create a partition scheme to specify the placement of the partitions of a partition function on filegroups.

3.Create a table or index using the partition scheme.
*/
--Creating partitioned table
-- http://msdn.microsoft.com/en-us/library/ms187802.aspx
/*
Patition function specify in it (col_data_type,range)
A partition function specifies how the table or index is partitioned. 
The function maps the domain into a set of partitions. 
To create a partition function, you specify the number of partitions, the partitioning column, and the range of partition column values for each partition. 
Note that when you specify the partitioning column, you can only specify one.
*/
create partition function pfn(int)
as range left
for values (10,20,30)
--exists in Storage=>Partition Functions
---------------------------------------
--Partition scheme
-- http://msdn.microsoft.com/en-us/library/ms179854.aspx
/*
A partition scheme maps the partitions produced by a partition function to a set of filegroups that you define.

When you create a partition scheme, you define the filegroups where the table partitions are mapped, based on the parameters of the partition function. You must specify enough filegroups to hold the number of partitions. You can specify that all partitions map to a different filegroup, that some partitions map to a single filegroup, or that all partitions map to a single filegroup. You can also specify additional, "unassigned" filegroups in the event you want to add more partitions later. In this case, SQL Server marks one of the filegroups with the NEXT USED property. This means that the filegroup will hold the next partition that is added. 

A partition scheme can use only one partition function. However, a partition function can participate in more than one partition scheme.
*/
create partition scheme pschema
as partition pfn
to (fg1,fg2,fg3,fg4)
--exists in Storage=>Partition Schemes
---------------------------------------
--Create Partitioned table
/*
To partition a table or index at the time you create it, you specify the following in the CREATE TABLE or CREATE INDEX statement: 

The partition scheme that the table will use to map the partitions to filegroups.

The column on which to partition the table (the partitioning column). The partitioning column must match that specified in the partition function that the partition scheme is using in terms of data type, length, and precision. If the column is computed, it must be specified as PERSISTED. 
*/
create table t
(
fullName nvarchar(30),
age int
)on pschema(age)
------------------------------
insert into t values
('Farida',12)
,('Adham',9)
,('Mohab',21)
,('Darin',33)
,('Logy',25)

------------------------------------------------------
--Drop partitioning
drop partition scheme pschema	--execute this first before trying to drop the partition function
drop partition function pfn 

--Retrieving information about partitions
------------------------------
select * ,$partition.pfn(age)
from t
set rowcount 1  --to return only (1) row in result set
------------------------------------
select * 
from sys.partitions
where OBJECT_NAME(OBJECT_ID )='t'
-------------------------------------------------