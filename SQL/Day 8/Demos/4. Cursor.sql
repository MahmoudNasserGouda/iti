--cursor
--------------------------------
-- is a mechanism that processes the result row-by-row 
-- More about cursors
-- http://technet.microsoft.com/en-us/library/ms191179.aspx
-- http://technet.microsoft.com/en-us/library/ms180169.aspx
-- http://www.mssqlcity.com/Articles/General/UseCursor.htm
----------------------------


--1- Declare Cursor
declare s_cur cursor
	for select CustomerID,LName from dbo.Customers
	for read only  --read only
declare @id int
declare @name nvarchar(50)
--2- open Cursor
open s_cur 
--3- fetch
begin
fetch s_cur into @id,@name
	While @@fetch_status=0  --returns 0 success -- 1 failed  --2 no more rows to fetch
	begin
		select @id,@name 
		fetch s_cur into @id,@name
	end
end
--4-Close Cursoe
close s_cur
--5-deallocate
deallocate s_cur
--------------------------------------------------------------------------	
Alter table Customers
add Ser int
--------------------------------------
declare Ins_cur cursor
	for select CustomerID,LName from dbo.Customers
	for update
declare @idI int
declare @nameI nvarchar(50) 
declare @counter int
set @counter=1;
open Ins_cur 
begin
fetch Ins_cur into @idI,@nameI --for enter while first time
	While @@fetch_status=0
	begin
		--if @idI<100
			begin
				update 	dbo.Customers
				set Ser=@counter
				where CURRENT of ins_cur --Current row
				--where CustomerID=@idI 
				set @counter=@counter+1;
				end
		fetch Ins_cur into @idI,@nameI
			
	end
end
close Ins_cur
deallocate Ins_cur




