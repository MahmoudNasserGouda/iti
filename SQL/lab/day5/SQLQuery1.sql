-- Use SD3x-Company:
--1.	Create a view that will display EmpName, ProjectName for the ‘clerk’ Employees (his job is clerk).
USE [Company]

CREATE VIEW clerk_projects AS
SELECT e.[Fname], p.[Pname]
FROM [dbo].[Employee] e
JOIN [dbo].[Departments] d ON e.[Dno] = d.[Dnum]
JOIN [dbo].[Project] p ON d.[Dnum] = p.[Dnum]
--WHERE e.Job = 'clerk'

--2.	Create a view that will display the project name and the number of employees work on it, and display project names that have no employees work on it. Make an alias for the view's column names. 
--a.	Could you insert, update or delete data from that View? 
--b.	And generally, when you insert, update or delete data to a view, Is this data stored or deleted in/from view itself? 
--c.	What’s check option? And why we use it?
--d.	When you drop a view, what will happen to the data inserted to it?	

CREATE VIEW ProjectEmployeeCount AS
SELECT p.[Pname], COUNT(e.[SSN]) 'No. Employees'
FROM [dbo].[Project] p
LEFT JOIN [dbo].[Employee] e ON p.[Dnum] = e.[Dno]
GROUP BY p.[Pname]




---------------------------------------------------------------------------------------------------------------------------------------------------------




--DQL
--1.	Display (Using Union Function)
--a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--b.	 And the male dependence that depends on Male Employee.

SELECT d.[Dependent_name], d.[Sex]
FROM [dbo].[Dependent] d
JOIN [dbo].[Employee] e ON d.[ESSN] = e.[SSN]
WHERE d.[Sex] = 'F' AND e.[Sex] = 'F'
UNION
SELECT d.[Dependent_name], d.[Sex]
FROM [dbo].[Dependent] d
JOIN [dbo].[Employee] e ON d.[ESSN] = e.[SSN]
WHERE d.[Sex] = 'M' AND e.[Sex] = 'M'

--2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.

SELECT [Pname], SUM([Hours])
FROM [dbo].[Works_for] 
JOIN [dbo].[Project] ON [Pnumber] = [Pno]
GROUP BY [Pname]

--3.	Display the data of the department which has the smallest employee ID over all employees' ID.

SELECT *
FROM [dbo].[Departments]
WHERE [Dnum] = (
	SELECT TOP 1 [Dno]
	FROM [dbo].[Employee]
	ORDER BY [SSN] ASC
	)

--4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

SELECT [Dname], MAX([Salary]) 'max', MIN([Salary]) 'min', AVG([Salary]) 'avg'
FROM [dbo].[Departments]
JOIN [dbo].[Employee] ON [Dnum] = [Dno]
GROUP BY [Dname]

--5.	List the last name of all managers who have no dependents.

SELECT [Lname]
FROM [dbo].[Departments]
LEFT JOIN [dbo].[Dependent] ON [MGRSSN] = [ESSN]
JOIN [dbo].[Employee] ON [MGRSSN] = [SSN]
WHERE [ESSN] IS NULL

--6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.

SELECT [Dnum], [Dname], SUM([SSN]) 'no. employees'
FROM [dbo].[Departments]
JOIN [dbo].[Employee] ON [Dnum] = [Dno]
GROUP BY [Dnum], [Dname]
HAVING AVG([Salary]) < (SELECT AVG([Salary]) FROM [dbo].[Employee])

--7.	Retrieve a list of employees and the projects they are working on ordered by department and within each department, ordered alphabetically by last name, first name.

SELECT *
FROM [dbo].[Employee]
JOIN [dbo].[Project] ON [Dno] = [Dnum]
ORDER BY [Dno] ASC, [Lname] ASC, [Fname] ASC

--8.	Try to get the max 2 salaries using subquery

SELECT TOP 2 [Salary]
FROM [dbo].[Employee]
ORDER BY [Salary] DESC

--9.	Get the names of employees that is similar to any dependent name

--10.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--a.	First try to update her record in the department table
--b.	Update your record to be department 20 manager.
--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

INSERT INTO [dbo].[Departments] VALUES('DP4',100,968574,'')
UPDATE [dbo].[Employee] SET [Dno] = 100 WHERE [SSN] = 968574
UPDATE [dbo].[Departments] SET [MGRSSN] = 102672 WHERE [Dnum] = 20

--11.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

DELETE FROM [dbo].[Employee] WHERE [SSN] = 223344
DELETE FROM [dbo].[Dependent] WHERE [ESSN] = 223344
DELETE FROM [dbo].[Departments] WHERE [MGRSSN] = 223344
DELETE FROM [dbo].[Works_for] WHERE [ESSn] = 223344

--12.	Try to update all salaries of employees who work in Project ‘AlRabwah’ by 30% 

UPDATE [dbo].[Employee] SET [Salary] = [Salary]*1.3 WHERE [Dno] IN (SELECT [Dnum] FROM [dbo].[Project] WHERE [Pname] = 'Al Rabwah')




---------------------------------------------------------------------------------------------------------------------------------------------------------




--SQLServer Lab
--Note: Use ITI DB
--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 
USE [ITI]

CREATE VIEW PassedCourses AS
SELECT CONCAT([St_Fname], ' ', [St_Lname]) AS FullName, [Crs_Name]
FROM [newschema].[Student]
JOIN [dbo].[Stud_Course] ON [newschema].[Student].[St_Id] = [dbo].[Stud_Course].[St_Id]
JOIN [dbo].[Course] ON [dbo].[Course].[Crs_Id] = [dbo].[Stud_Course].[Crs_Id]
WHERE [grade] > 50

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 

CREATE VIEW EncryptedManagers WITH ENCRYPTION AS
SELECT [Ins_Name], [Crs_Name]
FROM [dbo].[Instructor]
JOIN [dbo].[Course] ON [dbo].[Course].[Ins_Id] = [dbo].[Instructor].[Ins_Id]
WHERE [dbo].[Instructor].[Ins_Id] IN (SELECT [Dept_Manager] FROM [dbo].[Department])

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 

CREATE VIEW InstructorDepartment AS
SELECT [Ins_Name], [Dept_Name]
FROM [dbo].[Instructor]
JOIN [dbo].[Department] ON [dbo].[Department].[Dept_Id] = [dbo].[Instructor].[Dept_Id]
WHERE [dbo].[Department].[Dept_Name] = 'SD' OR [dbo].[Department].[Dept_Name] = 'Java'

--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;

CREATE VIEW V1 AS
SELECT *
FROM [newschema].[Student]
WHERE [St_Address] IN ('Alex', 'Cairo')
WITH CHECK OPTION

--5.	Create a view that will display the project name and the number of employees work on it. “Use Company DB”

USE [Company]

CREATE VIEW ProjectEmployee
AS
SELECT 
  [Pname],
  COUNT(*) AS EmployeeCount
FROM 
  [dbo].[Project]
  JOIN [dbo].[Employee] ON [dbo].[Project].[Dnum] = [dbo].[Employee].[Dno]
GROUP BY 
  [dbo].[Project].[Pname]

--6.	Create the following schema and transfer the following tables to it 
--a.	Company Schema 
--i.	Department table (Programmatically)
--ii.	Project table (visually)

CREATE SCHEMA CompanySchema
ALTER SCHEMA CompanySchema TRANSFER [dbo].[Departments]
ALTER SCHEMA CompanySchema TRANSFER [dbo].[Project]

--b.	Human Resource Schema
--i.	  Employee table (Programmatically)

CREATE SCHEMA HumanResourceSchema
ALTER SCHEMA HumanResourceSchema TRANSFER [dbo].[Employee]

--7.	Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?

USE [ITI]
CREATE INDEX IDX_HireDate ON [dbo].[Department] ([Hiredate]) 

--8.	Create index that allow u to enter unique ages in student table. What will happen?

CREATE UNIQUE INDEX UX_age ON [newschema].[Student] ([St_Age])

--9.	Create temporary table [Session based] on Company DB to save employee name and his today task.
USE [Company]
CREATE TABLE #EmployeeTasks (
  EmpName varchar(50),
  Task varchar(100)
)

--10.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB

DECLARE @EmployeeID int
DECLARE @Salary float
DECLARE cur CURSOR FOR
SELECT [SSN], [Salary]
FROM [dbo].[Employee]
OPEN cur
FETCH NEXT FROM cur INTO @EmployeeID, @Salary
WHILE @@FETCH_STATUS = 0
BEGIN
  IF @Salary < 3000
    SET @Salary = @Salary * 1.1
  ELSE
    SET @Salary = @Salary * 1.2

  UPDATE [dbo].[Employee] SET Salary = @Salary WHERE [SSN] = @EmployeeID

  FETCH NEXT FROM cur INTO @EmployeeID, @Salary
END
CLOSE cur
DEALLOCATE cur

--11.	Display Department name with its manager name using cursor. Use ITI DB

DECLARE @DeptName varchar(50)
DECLARE @ManagerName varchar(50)
DECLARE @ManagerID varchar(50)
DECLARE cur CURSOR FOR
SELECT [Dname], [MGRSSN] FROM Departments
OPEN cur
FETCH NEXT FROM cur INTO @DeptName, @ManagerID
WHILE @@FETCH_STATUS = 0
BEGIN
  SELECT @ManagerName = [Fname] + ' ' + [Lname]
  FROM [dbo].[Employee]
  WHERE [SSN] = @ManagerID
  PRINT @DeptName + ': ' + @ManagerName
  FETCH NEXT FROM cur INTO @DeptName, @ManagerID
END
CLOSE cur
DEALLOCATE cur

--12.	Try to display all students first name in one cell separated by comma. Using Cursor 

USE [ITI]

DECLARE @Names varchar(max) = ''
DECLARE @FNames varchar(50)
DECLARE cur CURSOR FOR
SELECT [St_Fname] FROM [newschema].[Student]
OPEN cur
FETCH NEXT FROM cur INTO @Names
WHILE @@FETCH_STATUS = 0
BEGIN
  SET @Names = @Names + ISNULL(', ' + @FNames,'')
  FETCH NEXT FROM cur INTO @FNames
END
PRINT @Names
CLOSE cur
DEALLOCATE cur

--13.	Try to generate script from DB ITI that describes all tables and views in this DB

