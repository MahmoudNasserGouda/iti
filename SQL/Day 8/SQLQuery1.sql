--DML Update Trigger
use [NetQ32023]
go 
alter trigger StoppdateOnFaculty
on [dbo].[Faculty] instead of update
as begin
	if update(ID)
		print 'ID cant be updated'
	else if update (Name)
		print 'Name cant be updated'
	else 
	begin
		select * from inserted
		select * from deleted
		update [dbo].[Faculty]
		set [DeanID] = (select DeanID from inserted)
		where ID = (select ID from inserted)
	end
end
go
update [dbo].[Faculty]
set DeanID = 3 where ID = 10

--logging:
create trigger logupdateonFaculty
on [dbo].[Faculty] after update
as begin
	select SUSER_NAME() 'user',GETDATE()'date', inserted.DeanID 'newdata', deleted.DeanID 'olddata' 
	into FacultyLog
	from inserted, deleted
	where inserted.ID = deleted.ID
end

----------------------------------------------------------------------------------
--DDL Triggers:
create trigger stopCreating
on database
for Create_Table -- for = after
as begin
	print 'no creation allowed'
	rollback --undo the creation
end

DROP TRIGGER stopCreating  
ON Database;  

create table x
(
	ID int not null,
	Name nvarchar(20)
)

insert into x values(5,'E')

select * from x

delete from x where ID = 4

insert into x values(8,'F'),(9,'H')

delete from Faculty where ID = 10

alter table [Manger].[Department]
add constraint DeptFacultyFK foreign key (FacultyID) references Faculty(ID)
on delete cascade --no action --set default --set null --cascade
on update set null

update Faculty set ID = 18 where ID = 90

----------------------------------------------------------------------------------
begin try
	update Faculty set ID = 17 where ID = 18
end try
begin catch
	select @@ERROR, ERROR_MESSAGE(),ERROR_LINE()
end catch

alter proc divide @input1 int, @input2 int
as begin
	if(@input2 = 0)
		throw 50000,'cant divide by zero',1
		--raiserror('cant divide by zero',18,1)
	else
		print @input1/@input2
end

begin try
	exec divide 4,0
end try
begin catch
	select ERROR_NUMBER(), ERROR_MESSAGE()
end catch

----------------------------------------------------------------------------------
--transactions:
----batch: selected statments to be executed - error in one does not affect others
----script: group of batches sperated by 'go' - error affect other statment in the script
----transaction: group of statments to be executed as one atom
------implicit tran
--insert -----begin tran insertStatment commit|rollback --try insert
------explicit tran

begin tran 
	update [Manger].[Department]
	set Name = 'Test Tran 2' where ID = 14
	rollback --commit

begin tran
	begin try
		insert into Manger.Department values(21,'IS',1,null)
		insert into Professor values(8,'P8','p8','0101',21,1,10000)
		update Manger.Department set ChairmanID = 8 where ID = 21
		commit
	end try
	begin catch
		rollback
	end catch

begin tran
	begin try
		update Production.Product set ProductNumber='19A' where ProductID=3;
		save tran s1									--save point
		update Production.Product set ReorderPoint=null where ProductID=3;	
		update Production.Product set ReorderPoint=null where ProductID=4;
		commit tran
		print 'Done'
	end try
	begin catch
		rollback tran s1			--partially rollback
		commit tran					--without this statment "engin hanging"
	end catch
-------------------------------------------------------------------------------------------
--Indexing: create file in easy to traverse way for the column|s to be indexed
----clustred: one and only one clusrtred index goes by default to primary key
----non-clustred: zero or more
----unique non-clustred: zero or more

create table IndexTest
(
	ID int not null primary key, --automatically take clustred index
	Name nvarchar(50) not null,
	SSN char(14) not null check(len(SSN)=14),
	Address nvarchar(max)
)

create nonclustered index NameIndex on IndexTest(Name)

create unique nonclustered index SSNUniqueIndex on IndexTest(SSN)

drop table IndexTest

create table IndexTest
(
	ID int identity(1,1) not null, --unique non clustred
	Name nvarchar(50) not null,
	SSN char(14) not null check(len(SSN)=14), --clustred
	Address nvarchar(max)
)

create clustered index SSNIndex on IndexTest(SSN)

alter table IndexTest
add constraint IndexTestPK primary key (ID) 
-----------------------------------------------------------------------------------------
--backups:
----full backup
----diffrential backup
----transactional backup