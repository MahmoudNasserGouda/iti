
--Day 7 Lab

--1.	Create a stored procedure to show the number of students per department.[use ITI DB] 

USE [ITI]

CREATE PROC students_department
AS
BEGIN
    SELECT [Dept_Name], COUNT(*) as NumberOfStudents
    FROM [newschema].[Student]
    JOIN [dbo].[Department] ON [newschema].[Student].[Dept_Id] = [dbo].[Department].[Dept_Id]
    GROUP BY [Dept_Name]
END

EXEC students_department

-----------------------------------------------------------------------------------------------------------------------------------------------------

--2.	Create a stored procedure that will check for the number of employees in the project p1 if they are more than 3 print message to the user 
--		“'The number of employees in the project p1 is 3 or more'” if they are less display a message to the user 
--		“'The following employees work for the project p1'” in addition to the first name and last name of each one. [Company DB] 

USE [CompanyDB]

CREATE PROC project_employees
AS
BEGIN
	DECLARE @employee_count INT

	SELECT @employee_count = 
		COUNT(*) FROM [dbo].[Employee] WHERE [SSN] IN
			(SELECT [ESSN] FROM [dbo].[Works_ON] WHERE [PNO] = 
				(SELECT [PNumber] FROM [dbo].[Project] WHERE [PName] = 'p1'))

	IF @employee_count >= 3
    BEGIN
        PRINT 'The number of employees in the project p1 is 3 or more'
    END
    ELSE
    BEGIN
        PRINT 'The following employees work for the project p1:'
		SELECT [FName], [LName]
		FROM [dbo].[Employee]
		WHERE [SSN] IN
			(SELECT [ESSN] FROM [dbo].[Works_ON] WHERE [PNO] = 
				(SELECT [PNumber] FROM [dbo].[Project] WHERE [PName] = 'p1'))
	END
END

EXEC project_employees

----------------------------------------------------------------------------------------------------------------------------------------------------

--3.	Create a stored procedure that will be used in case there is an old employee has left the project and a new one become instead of him.
--		The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number)
--		and it will be used to update works_on table. [Company DB]

CREATE PROC replace_employee @old_emp_number INT, @new_emp_number INT, @project_number INT
AS
BEGIN
    UPDATE [dbo].[Works_ON]
    SET [ESSN] = @new_emp_number
    WHERE [ESSN] = @old_emp_number AND [PNO] = @project_number
END

EXEC replace_employee 123456, 654123, 50

----------------------------------------------------------------------------------------------------------------------------------------------------

--4.	Create a trigger that prevents the insertion Process for Employee table in March [Company DB].

CREATE TRIGGER prevent_employee_insert_in_march ON [dbo].[Employee] INSTEAD OF INSERT
AS
BEGIN
    IF MONTH(GETDATE()) = 4
    BEGIN
        PRINT('Insertion of Employee records in APRIL is not allowed.')
    END
	ELSE
	BEGIN
		insert into [dbo].[Employee] select * from inserted
	END
END

INSERT INTO [dbo].[Employee] VALUES('Ahmed','Mahmoud','123789','','cairo','M','2500','123456','10')

----------------------------------------------------------------------------------------------------------------------------------------------------

--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--		“Print a message for user to tell him that he can’t insert a new record in that table”

USE [ITI]

CREATE TRIGGER prevent_department_insert ON [dbo].[Department] INSTEAD OF INSERT
AS
BEGIN
	PRINT('You can’t insert a new record in Department table.')
END

INSERT INTO [dbo].[Department] VALUES('Test','17','123456','')

----------------------------------------------------------------------------------------------------------------------------------------------------

--6.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name, Date, Note)
--		where note will be “[username] Insert New Row with ID=[ID Value] in table Student”

CREATE TABLE StudentAudit (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(128) NOT NULL,
    AuditDate DATETIME NOT NULL DEFAULT GETDATE(),
    Note NVARCHAR(MAX)
)

CREATE TRIGGER add_student ON [newschema].[Student] AFTER INSERT
AS
BEGIN
    DECLARE @username NVARCHAR(128)
    SET @username = SYSTEM_USER
    
    INSERT INTO [dbo].[StudentAudit] ([Username], [AuditDate], [Note])
    SELECT @username, GETDATE(), CONCAT('[', @username, '] Insert New Row with ID=[', INSERTED.[St_Id], '] in table Student')
    FROM INSERTED
END

INSERT INTO [newschema].[Student] VALUES(14,'Ahmed','Mahmoud','',28,20,9)

----------------------------------------------------------------------------------------------------------------------------------------------------

--7.	Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note)
--		where note will be“[username]  try to delete Row with ID=[ID Value]”

CREATE TRIGGER delete_student ON [newschema].[Student] INSTEAD OF DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(128)
    SET @username = SYSTEM_USER
    
    INSERT INTO [dbo].[StudentAudit] ([Username], [AuditDate], [Note])
    SELECT @username, GETDATE(), CONCAT('[', @username, '] try to delete Row with ID=[', DELETED.[St_Id], '] in table Student')
    FROM DELETED
END

DELETE FROM [newschema].[Student] WHERE [St_Id] = 14
