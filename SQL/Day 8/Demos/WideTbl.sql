/* 
Wide Tables
http://msdn.microsoft.com/en-us/library/ms186986.aspx
A wide table is a table that has defined a column set. Wide tables use sparse columns to increase the total of columns that a table can have to 30,000. The number of indexes and statistics is also increased to 1,000 and 30,000, respectively. The maximum size of a wide table row is 8,019 bytes. Therefore, most of the data in any particular row should be NULL. To create or change a table into a wide table, you add a column set to the table definition. The maximum number of nonsparse columns plus computed columns in a wide table remains 1,024.
By using wide tables, you can create flexible schemas within an application. You can add or drop columns whenever you want. Keep in mind that using wide tables has unique performance considerations, such as increased run-time and compile-time memory requirements. 
Spare Columns
http://msdn.microsoft.com/en-us/library/cc280604.aspx
Sparse columns are ordinary columns that have an optimized storage for null values. Sparse columns reduce the space requirements for null values at the cost of more overhead to retrieve nonnull values. Consider using sparse columns when the space saved is at least 20 percent to 40 percent. Sparse columns and column sets are defined by using the CREATE TABLE or ALTER TABLE statements.
Sparse columns have the following characteristics:
The SQL Server Database Engine uses the SPARSE keyword in a column definition to optimize the storage of values in that column. Therefore, when the column value is NULL for any row in the table, the values require no storage.
Catalog views for a table that has sparse columns are the same as for a typical table. The sys.columns catalog view contains a row for each column in the table and includes a column set if one is defined.
Sparse columns are a property of the storage layer, rather than the logical table. Therefore a SELECT…INTO statement does not copy over the sparse column property into a new table. 
A sparse column must be nullable and cannot have the ROWGUIDCOL or IDENTITY properties. A sparse column cannot be of the following data types: text, ntext, image, timestamp, user-defined data type, geometry, or geography; or have the FILESTREAM attribute.
A sparse column cannot have a default value.
A sparse column cannot be bound to a rule.
*/
--Creating spare columns
USE AdventureWorks;
GO
CREATE TABLE DocumentStore
(DocID int PRIMARY KEY,
Title varchar(200) NOT NULL,
ProductionSpecification varchar(20) SPARSE NULL,
ProductionLocation smallint SPARSE NULL,
MarketingSurveyGroup varchar(20) SPARSE NULL ) ;
GO

INSERT DocumentStore(DocID, Title, ProductionSpecification, ProductionLocation)
VALUES (1, 'Tire Spec 1', 'AXZZ217', 27);
GO

INSERT DocumentStore(DocID, Title, MarketingSurveyGroup)
VALUES (2, 'Survey 2142', 'Men 25 - 35');
GO

--To select all the columns from the table returns an ordinary result set
SELECT * FROM DocumentStore ;

-- Using column set
--http://msdn.microsoft.com/en-us/library/cc280521.aspx
/*
Tables that use sparse columns can designate a column set to return all sparse columns in the table. A column set is an untyped XML representation that combines all the sparse columns of a table into a structured output. A column set is like a calculated column in that the column set is not physically stored in the table. A column set differs from a calculated column in that the column set is directly updatable.

You should consider using column sets when the number of columns in a table is large, and operating on them individually is cumbersome. Applications might see some performance improvement when they select and insert data by using column sets on tables that have lots of columns. However, the performance of column sets can be reduced when many indexes are defined on the columns in the table. This is because the amount of memory that is required for an execution plan increases.
*/

CREATE TABLE t (i int SPARSE, cs xml column_set FOR ALL_SPARSE_COLUMNS)
GO
INSERT t(cs) VALUES ('<i/>')
GO
SELECT i FROM t
GO
