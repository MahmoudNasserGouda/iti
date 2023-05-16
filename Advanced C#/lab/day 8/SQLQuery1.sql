create procedure add_article (@head nvarchar(500), @body nvarchar(max), @files nvarchar(500)) as 
begin  
    declare @done int = 0; 
	begin try 
		begin tran addTrans 
			insert into Article (Head, Body,[Date]) values (@head,@body,Getdate()); 
			insert into ArticlePhoto (ArticleID,[Path]) 
			select (select ID from Article where Head = @head), * from string_split(@files,','); 
		commit tran addTrans; 
		set @done  = 1; 
	end try  
	begin catch  
		rollback tran addTrans; 
		set @done  = 0; 
	end catch 
	return @done; 
end 