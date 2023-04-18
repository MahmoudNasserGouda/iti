/*
A transaction is a single unit of work. If a transaction is successful, all of the data modifications made during the transaction are committed and become a permanent part of the database. If a transaction encounters errors and must be canceled or rolled back, then all of the data modifications are erased.

SQL Server operates in the following transaction modes.

Autocommit transactions

    Each individual statement is a transaction.
Explicit transactions

    Each transaction is explicitly started with the BEGIN TRANSACTION statement and explicitly ended with a COMMIT or ROLLBACK statement.
Implicit transactions

    A new transaction is implicitly started when the prior transaction completes, but each transaction is explicitly completed with a COMMIT or ROLLBACK statement.
Batch-scoped transactions

    Applicable only to multiple active result sets (MARS), a Transact-SQL explicit or implicit transaction that starts under a MARS session becomes a batch-scoped transaction. A batch-scoped transaction that is not committed or rolled back when a batch completes is automatically rolled back by SQL Server.

 A transaction has four key properties that are abbreviated ACID. ACID is an acronym for for Atomic Consistent Isolated Durability.
	--Atomic means that all the work in the transaction is treated as a single unit. Either it is all performed or none of it is. 
	--Consistent means that a completed transaction leaves the database in a consistent internal state. 
	--Isolations means that the transaction sees the database in a consistent state. This transaction operates on a consistent view of the data. If two transactions try to update the same table, one will go first and then the other will follow. 
	--Durability means that the results of the transaction are permanently stored in the system.
 - See more at: http://www.sqlteam.com/article/introduction-to-transactions#sthash.jPHDSRfo.dpuf
*/
--transactions and batches:
use AdventureWorks;
begin tran t
update Production.Product set Name='iti1' where ProductID=1;
update Production.Product set Name='iti2' where ProductID=2;
rollback
--commit

select Name from Production.Product
where ProductID in (1,2);
---------------------------------------

use AdventureWorks;				
begin tran t1
	declare @r1 int, @r2 int;
	update Production.Product set ProductNumber='19A'  where ProductID=3;
	--insert into Production.Product (ProductNumber) values('19A');
	set @r1=@@error
	update Production.Product set ReorderPoint=88 where ProductID=3;
	set @r2=@@error
	if @r1 = 0 and @r2=0
		begin
			commit tran
			select 'Done'
		end
	else
		begin
			rollback tran
			select @r1,@r2
		end;
go
---------------------------------------------------------------------
--Save point
use AdventureWorks;
begin tran t1
	declare @r2 int, @r1 int
	update Production.Product set ProductNumber='19A' where ProductID=3;
	save tran s1									--save point
	update Production.Product set ReorderPoint=null where ProductID=3;
	set @r1=@@error			
	update Production.Product set ReorderPoint=null where ProductID=4;
	set @r2=@@error                                 
	if @r1=0 and @r2 = 0
		begin
			commit tran
			select 'true'
		end
	else
		begin
			rollback tran s1			--partially rollback
			commit tran					--without this statment "engin hanging"
			select @r1,@r2
		end



select ProductNumber from Production.Product where ProductID=3
--------------------------------------------------------------------------