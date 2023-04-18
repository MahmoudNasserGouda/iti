use AdventureWorks
--1)isnull function
USE AdventureWorks;
GO
SELECT [Description], DiscountPct, MinQty,MaxQty, ISNULL(MaxQty, 0) AS 'Max Quantity'
FROM Sales.SpecialOffer;
GO
--------------------------
select getdate();
--------------------------
declare @i int;
set @i=5;
--select ' Mynumber:' + @i
 
select' Mynumber:' + convert(nvarchar(3), @i) 

-------------------------------

--2)convert function
/*     style
		102   =>  yy.mm.dd
		113   =>  dd mmName yy time
		111   =>  yy/mm/dd
*/

select getdate();

SELECT '102 - ANSI:', CONVERT(varchar(30), GETDATE(), 102) AS Style
UNION
SELECT '111 - Japanese:', CONVERT(varchar(30), GETDATE(), 111)
UNION
SELECT '113 - European:', CONVERT(varchar(30), GETDATE(), 113)
GO

select BirthDate , convert(nvarchar(20),BirthDate,113)--to get the date with a specific style
from HumanResources.Employee

--3)system function
select db_name()

select SUSER_SNAME()

--4)aggregate function
select COUNT(*) from HumanResources.Employee



select BirthDate
from HumanResources.Employee

select BirthDate,datename(dd,BirthDate) 
from HumanResources.Employee


select datename(mm,getdate()) 


select datename(yy,BirthDate) 
from HumanResources.Employee

select datename(dd,getdate())

--6)string
select upper(Color) from Production.Product
select lower(Color) from Production.Product
select substring(Color,1,3) from Production.Product  --start--length 

--7)math
select sin(100)
select power(100,2)

