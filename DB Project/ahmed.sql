create table Course
(
	course_ID int Primary key identity(1,1) ,
	course_name nvarchar(50) not null , 
	course_description nvarchar(max) , 
	max_degree int not null , 
	min_degree int not null 
)
go 
--question table contain all information about question . 

create table question
(
	ques_ID int primary key  identity(1,1), 
	ques_text nvarchar(max)  not null , 
	course_ID int not null ,
	constraint que_courFK foreign key (course_ID) references Course(course_ID) 
)
go

--mcQ_ques table contain all information about mcQ_questions  . 

create table mcQ_ques
(
	correct_answer char not null , 
	A nvarchar(50)  not null , 
	B nvarchar(50)  not null , 
	C nvarchar(50)  not null , 
	D nvarchar(50)  not null , 
	ques_ID int primary key , 
	constraint MCQ_QuesFK foreign key (ques_ID) references question(ques_ID) 

)

go


create table Class
(
	class_ID int primary key identity(1,1) , 
	branch_ID int  not null ,
	Intake_ID int   not null ,
	Track_ID int   not null ,
	CONSTRAINT Cl_branchFK FOREIGN KEY (branch_ID) REFERENCES Branch(branch_ID),
	CONSTRAINT Cl_IntakeFK FOREIGN KEY (Intake_ID) REFERENCES Intake(Intake_ID),
	CONSTRAINT Cl_TRackFK FOREIGN KEY (Track_ID) REFERENCES Track(Track_ID)
)
go 
--student table contain all info about students . 

create table Student	
(
	st_ID int primary key Identity(1,1) , 
	st_name nvarchar(50)  not null , 
	st_username nvarchar(50)  not null ,
	st_password  varchar(50)  not null ,
	class_ID int   not null ,
	CONSTRAINT st_classfk FOREIGN KEY (class_ID) REFERENCES Class(class_ID)
) 
go

--table descripe the relationship between student's and it's ques_exam and answer for each exam 

create table st_quesexam_answer
(
	st_ID  int  not null ,
	exam_ID int   not null ,
	ques_ID int  not null ,
	st_answer nvarchar(max)  , 
	iscorrect bit  not null ,
	CONSTRAINT Sqa_STFK FOREIGN KEY (st_ID) REFERENCES Student(st_ID),
	CONSTRAINT Sqa_EXFK FOREIGN KEY (exam_ID) REFERENCES Exam(exam_ID),
	CONSTRAINT Sqa_QUFK FOREIGN KEY (ques_ID) REFERENCES question(ques_ID)
)
go 


--determine mcQ questions (number of questions and questions itself)

create procedure add_MCQ_Question
@ques_text nvarchar(max) ,
@correct_answer char , 
@choices nvarchar(max) , 
@course_ID int
as
begin
	insert into question values(@ques_text, @course_ID)
	declare @ques_ID int 
	set @ques_ID = SCOPE_Identity()
	DECLARE @choices_table TABLE (id int identity(1,1), choice nvarchar(50))
	INSERT INTO @choices_table SELECT value FROM STRING_SPLIT(@choices, ',')
	DECLARE @a nvarchar(50) = (select choice FROM @choices_table where id = 1)
	DECLARE @b nvarchar(50) = (select choice FROM @choices_table where id = 2)
	DECLARE @c nvarchar(50) = (select choice FROM @choices_table where id = 3)
	DECLARE @d nvarchar(50) = (select choice FROM @choices_table where id = 4)
	insert into mcQ_ques values(@correct_answer, @a, @b, @c, @d, @ques_ID)
end
go

create procedure delete_Question
@ques_id int
as
begin
	delete from mcQ_ques where ques_ID = @ques_id
	delete from true_false_ques where ques_ID = @ques_id
	delete from text_ques where ques_ID = @ques_id
	delete from question where ques_ID = @ques_id
end
go

--assign and give adegree for student in exam.
create procedure mark_Exam
@student_ID int ,
@class_ID int ,
@course_ID int 
as
begin
	DECLARE @exam_ID int
	SET @exam_ID = (select exam_ID from Class_Course where class_ID = @class_ID and course_ID = @course_ID)
	DECLARE @final_result int = 0
	DECLARE @is_correct int
	DECLARE @ques_degree int
	DECLARE @ques_id int
	DECLARE mark_cursor CURSOR FOR SELECT ques_id from Exam_Question where exam_ID = @exam_ID
	OPEN mark_cursor
	FETCH NEXT FROM mark_cursor INTO @ques_id
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @is_correct = (SELECT iscorrect FROM st_quesexam_answer where st_ID = @student_ID and exam_ID = @exam_ID and ques_ID = @ques_id)
		SET @ques_degree = (SELECT Degree FROM Exam_Question where exam_ID = @exam_ID and ques_ID = @ques_id)
		IF @is_correct = 1
		BEGIN
			SET @final_result = @final_result + @ques_degree
		END
		FETCH NEXT FROM mark_cursor INTO @ques_id
	END
	CLOSE mark_cursor
	DEALLOCATE mark_cursor
	insert into Student_Class_Course values(@student_ID, @class_ID, @course_ID, @final_result)
end
go

create procedure add_course
@course_name nvarchar(50) ,
@course_desc nvarchar(max) , 
@max_deg int ,
@min_deg int
as
begin
	insert into Course values(@course_name, @course_desc, @max_deg, @min_deg)
end
go
--delete specific course  with id 
create procedure delete_Course
@course_id int
as
begin
	delete from Course where course_ID = @course_id
	delete from Class_Course where course_ID = @course_id
	delete from Student_Class_Course where course_ID = @course_id
	delete from question where course_ID = @course_id
end
go
--insert new student in system . 
create procedure add_Student
@student_name nvarchar(50) ,
@student_username nvarchar(50) ,
@student_password nvarchar(50) ,
@student_class_id int
as
begin
	insert into Student values(@student_name, @student_username, @student_password, @student_class_id)
end
go

--assign as tranning manager for each instruor has @is_tm equal 1 . 
CREATE TRIGGER AddTrainningManagerToRoleTrigger
ON Instructor
AFTER INSERT
AS
BEGIN
	DECLARE @is_TM bit
	SELECT @is_TM = inserted.istrainning_manager FROM inserted
	IF @is_TM = 1
	BEGIN
		DECLARE @UserName NVARCHAR(50)
		SELECT @UserName = inserted.inst_username FROM inserted
		DECLARE @Password NVARCHAR(50)
		SELECT @Password = inserted.inst_password FROM inserted
		DECLARE @Sql NVARCHAR(MAX)
		SET @Sql = 'CREATE LOGIN ' + QUOTENAME(@UserName) + ' WITH PASSWORD = ''' + @Password + ''';'
		EXEC sp_executesql @Sql
		SET @Sql = 'CREATE USER ' + QUOTENAME(@UserName) + ' FOR LOGIN ' + QUOTENAME(@UserName) + ';'
		EXEC sp_executesql @Sql
		EXEC sp_addrolemember 'Trainning_Manager', @UserName
	END
END
go

--check correct answer for true/false questions 

create procedure answer_TF_Quest
@student_id int ,
@exam_id int ,
@ques_id int ,
@student_answer bit
as
begin
	DECLARE @is_correct bit
	IF @student_answer = (select correct_answer from true_false_ques where ques_ID = @ques_id)
	BEGIN
		set @is_correct = 1
	END
	ELSE
	BEGIN
		set @is_correct = 0
	END
	insert into st_quesexam_answer values(@student_id, @exam_id, @ques_id, @student_answer, @is_correct)
end
go


--create account for each insetred student  . 
CREATE TRIGGER AddStudentToRoleTrigger
ON Student
AFTER INSERT
AS
BEGIN
	DECLARE @UserName NVARCHAR(50)
	SELECT @UserName = inserted.st_username FROM inserted
	DECLARE @Password NVARCHAR(50)
	SELECT @Password = inserted.st_password FROM inserted
	DECLARE @Sql NVARCHAR(MAX)
	SET @Sql = 'CREATE LOGIN ' + QUOTENAME(@UserName) + ' WITH PASSWORD = ''' + @Password + ''';'
	EXEC sp_executesql @Sql
	SET @Sql = 'CREATE USER ' + QUOTENAME(@UserName) + ' FOR LOGIN ' + QUOTENAME(@UserName) + ';'
	EXEC sp_executesql @Sql
	EXEC sp_addrolemember 'Student', @UserName
END
go


EXEC [dbo].[add_course] @course_name = N'C#', @course_desc = N'lorem ipsum', @max_deg = 90, @min_deg = 45
EXEC [dbo].[add_MCQ_Question] @ques_text = N'what is not a data type?', @correct_answer = 'a', @choices = N'car,int,bool,float', @course_ID = 1
EXEC [dbo].[add_Student] @student_name = N'Ali', @student_username = N'al1', @student_password = N'11111', @student_class_id = 1
EXEC [dbo].[add_Student] @student_name = N'Mostafa', @student_username = N'mo1', @student_password = N'22222', @student_class_id = 1
EXEC [dbo].[add_Student] @student_name = N'Said', @student_username = N'sa1', @student_password = N'33333', @student_class_id = 1
EXEC [dbo].[answer_TF_Quest] @student_id = 1, @exam_id = 4, @ques_id = 2, @student_answer = 1
EXEC [dbo].[mark_Exam] @student_ID = 1, @class_ID = 1, @course_ID = 1