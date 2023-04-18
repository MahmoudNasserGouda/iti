--Computed Column
Use [Intake35DB]
CREATE FUNCTION udf_get_FullName (@fname Varchar(50), @lname Varchar(50))
RETURNS varchar(100)
WITH SCHEMABINDING
BEGIN
   DECLARE @FullName  varchar(100)
   SELECT @FullName 
		 = @fname + ' ' + @lname;
   RETURN @FullName 
END


ALTER TABLE [dbo].[Customers]
ADD   FullName --calculated column name
AS dbo.udf_get_FullName ([FName],[LName])


insert into [dbo].[Customers] ([CustomerID],[LName],[FName]) 
values(66,'fff','rrr');

select * from [dbo].[Customers]


