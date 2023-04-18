--Day 3 Lab Assignments
--Use ITI or AdventureWorks according to needed tables:
--1.	Create multi-statement function that takes 2 integers and returns the values between them.

CREATE FUNCTION GetValues(@Start int, @End int)
RETURNS @Values TABLE (Value int)
AS
BEGIN
  DECLARE @CurrentValue int = @Start
  WHILE @CurrentValue <= @End
  BEGIN
    INSERT INTO @Values (Value) VALUES (@CurrentValue)
    SET @CurrentValue = @CurrentValue + 1
  END
  RETURN
END

--2.	Create inline tabled-function that returns Employees name, title, Marital status, Gender (Contact Table in AdventureWorks).
--a.	Return "Not provided" instead of null titles (Use ISNull).
--b.	For Marital status return “Signle or Married” instead of the appreviations used in the table. (Use Case When).
--c.	For Gender return “Male or Female” instead of the appreviations used in the table. (Use Case When).

USE [AdventureWorks2019]

CREATE FUNCTION GetEmployee()
RETURNS TABLE
AS
RETURN (
  SELECT [FirstName] + ' ' + [MiddleName] + ' ' + [LastName] AS fullname, 
		ISNULL([Title], 'Not provided') AS Title, 
		CASE 
			WHEN [MaritalStatus] = 'S' THEN 'Single'
    		WHEN [MaritalStatus] = 'M' THEN 'Married'
			ELSE 'Unknown'
		END AS MaritalStatus, 
		CASE 
			WHEN [Gender] = 'F' THEN 'Female'
    		WHEN [Gender] = 'M' THEN 'Male'
			ELSE 'Unknown'
		END AS Gender
  FROM [Person].[Person]
  JOIN [HumanResources].[Employee] ON [HumanResources].[Employee].[BusinessEntityID] = [Person].[Person].[BusinessEntityID]
)

--3.	Create inline tabled-valued function that return all employees names, titles in AdventureWorks database and thier experience years of work (number of years from current date to hire date), and their graduation date (birth date +21 year) in format (dd, Mon yyy) [without time]. 

CREATE FUNCTION GetEmployeeExperience()
RETURNS TABLE
AS
RETURN (
  SELECT 
    [FirstName] + ' ' + [MiddleName] + ' ' + [LastName] AS fullname, 
    [Title], 
    DATEDIFF(year, [HireDate], GETDATE()) AS ExperienceYears, 
    CONVERT(varchar(12), DATEADD(year, 21, [BirthDate]), 106) AS GraduationDate
  FROM HumanResources.Employee
  JOIN [Person].[Person] ON [HumanResources].[Employee].[BusinessEntityID] = [Person].[Person].[BusinessEntityID]
)

--4.	Create scalar function that takes salary, no. of experience years as parameters, and calculates the net salary after increase, knowing that the employees will take 10% increase on the salary for each experience year, with a maximum of 70% increase.

CREATE FUNCTION CalculateSalary(@Salary float, @ExperienceYears int)
RETURNS float
AS
BEGIN
  DECLARE @Increase float = 0.1 * @ExperienceYears;
  IF @Increase > 0.7
    SET @Increase = 0.7;
  RETURN @Salary * (1 + @Increase);
END

--5.	Create function, that take department id as a parameter, and Select the employees name and salary for employees who earn the highest 10 salary in this department.

USE [Company]

CREATE FUNCTION GetEmployees(@DeptID int)
RETURNS TABLE
AS
RETURN (
  SELECT TOP 10 
    [Fname] + ' ' + [Lname] AS fullname, 
    [Salary]
  FROM [dbo].[Employee]
  WHERE [Dno] = @DeptID
  ORDER BY Salary DESC
)