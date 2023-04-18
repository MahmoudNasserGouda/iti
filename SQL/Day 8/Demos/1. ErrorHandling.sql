--Using try/catch
begin try
	select 1/0
end try
begin catch
	print 'Error'
end catch
------------------------------------------------------
begin try
	select 1/0
end try
begin catch
	print 'Error'
	select ERROR_MESSAGE() 'Error Message'
	,ERROR_NUMBER() 'Error Number'
	,ERROR_LINE () 'Error Line Number'
	,ERROR_SEVERITY () 'Error Severity Level'
	,ERROR_PROCEDURE() 'Error Procedure'
	,ERROR_STATE () 'Error State'
end catch
--------------------------------------------------------------------
use AdventureWorks;
begin try
	insert into Production.Product(Name) values('n') 
end try
begin catch
	select @@ERROR
end catch
---------------------------
--RaiseError					
declare @msgnum int,
@severity int
,@msgtext nvarchar(30)
go
sp_addmessage @msgnum = 50005,
              @severity = 10,
              @msgtext = N'this is User define message';--7char displayed,take 1st 3char from msg
GO
RAISERROR (50005, -- Message id.
           10, -- Severity,
           1 -- State
		   )
-- The message text returned is: <<    abc>>.
GO
sp_dropmessage @msgnum = 50005;
GO

select * from sys.messages
where message_id=50005