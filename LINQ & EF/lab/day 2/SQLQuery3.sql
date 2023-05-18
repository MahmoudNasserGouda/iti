USE [ITI];  
GO  
CREATE PROCEDURE GetCoursesNames    
AS   
    SELECT  [Crs_Name]
    FROM  [dbo].[Course] 
GO  