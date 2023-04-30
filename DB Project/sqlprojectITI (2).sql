--database name
create database Examination_System 
go 

use  Examination_System
go
--course table contain all information about courses . 

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
--text_ques table contain all information about text_ques  . 

create table text_ques
(
	best_accpeted_Answer  nvarchar(max) not null , 
	ques_ID int primary key , 
	constraint text_QuesFK foreign key (ques_ID) references question(ques_ID) 
)
go
--true_false_ques table contain all information about true_false_ques  . 

create table true_false_ques
(
	Correct_Answer bit not null , 
	ques_ID int primary key , 
	constraint TrFalse_QuesFK foreign key (ques_ID) references question(ques_ID) 
)
go
--Instructor table contain all information about Instructors  . 

create table Instructor	
(
	inst_ID int primary key Identity(1,1) , 
	ins_name nvarchar(50) not null , 
	inst_username nvarchar(50) not null , 
	inst_password varchar(50) not null , 
	istrainning_manager bit , 
)
go
--Exam table contain all information about Exam  . 

create table Exam
(
	exam_ID int primary key identity(1,1) , 
	exam_date	date  not null ,
	start_time 	time  not null ,
	End_Time time  not null ,
	total_time int  not null ,
	allownece_option	nvarchar(50) , 
	inst_ID int   not null ,
	constraint Exam_InsFK  foreign key (inst_ID) references Instructor(inst_ID)
)
go
--Exam_Question table conatin  info about exam &ques  and degree for each exam 

create table Exam_Question
(
	exam_ID int  , 
	ques_ID int  , 
	Degree float  not null ,
	constraint Exam_QUFK  foreign key (exam_ID) references Exam(exam_ID) , 
	constraint Qus_QuFK foreign key (ques_ID) references question(ques_ID) , 
	constraint Ex_QuesPK primary key (exam_ID,ques_ID)
)
go
--department table conatin info about departments . 

create table Department
(
	dept_ID int primary key Identity(1,1) , 
	dept_name nvarchar(50)  not null 
)
go 
--Branch table conatin info about Branchs . 
CREATE TABLE Branch 
(
	branch_ID INT PRIMARY KEY Identity(1,1) , 
	branch_name NVARCHAR(50)  not null 
)
go
--Intake table conatin info about Intakes . 

CREATE TABLE Intake 
(
	intake_ID INT PRIMARY KEY Identity(1,1) , 
	intake_name NVARCHAR(50)  not null ,
	intake_end_date DATE  not null ,
	intake_start_date DATE  not null 
)
go
--Track table conatin info about Track . 

CREATE TABLE Track 
(
	track_ID INT PRIMARY KEY Identity(1,1) , 
	track_name NVARCHAR(50)  not null ,
	dept_ID INT  not null ,
	CONSTRAINT fk_track_dept FOREIGN KEY (dept_ID) REFERENCES Department(dept_ID)
)
go 


--class table conatin info about classes that link class with it's branch,intake and track

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
--table descripe relationship betwwen classes and courses for each class

create table Class_Course
(
	class_ID  int  not null ,
	course_ID int  not null ,
	inst_ID	  int ,
	exam_ID	  int ,
	CONSTRAINT class_classcoursefk FOREIGN KEY (class_ID) REFERENCES class(class_ID), 
	CONSTRAINT course_classcoursefk FOREIGN KEY (course_ID) REFERENCES Course(course_ID),
	CONSTRAINT ins_classcoursefk FOREIGN KEY (inst_ID) REFERENCES Instructor(inst_ID),
	CONSTRAINT exam_classcoursefk FOREIGN KEY (exam_ID) REFERENCES Exam(exam_ID),
	CONSTRAINT classcoursePK primary key(class_ID,course_ID)
)
go 
--descripe relationship between students and class_course relationship

CREATE TABLE Student_Class_Course 
(
	student_ID INT  not null ,
	class_ID INT  not null ,
	course_ID INT  not null ,
	final_result INT  not null ,
	CONSTRAINT scc PRIMARY KEY (student_ID, class_ID, course_ID),
	CONSTRAINT SCC_STFK FOREIGN KEY (student_ID) REFERENCES Student(st_ID),
	CONSTRAINT SCC_CLFK FOREIGN KEY (class_ID) REFERENCES Class(class_ID),
	CONSTRAINT  SCC_COFK FOREIGN KEY (course_ID) REFERENCES Course(course_ID)
)
go
--descripe relationship between branchs and intakes

CREATE TABLE Branch_Intake 
(
	branch_ID INT  not null ,
	intake_ID INT  not null ,
	CONSTRAINT Branch_IntakePK PRIMARY KEY (branch_ID, intake_ID),
	CONSTRAINT  BI_branchFK FOREIGN KEY (branch_ID) REFERENCES Branch(branch_ID),
	CONSTRAINT   BI_IntakeFK FOREIGN KEY (intake_ID) REFERENCES Intake(intake_ID)
)
go 
--big relationship between branch and intakes ,track for each branch

create table Branch_Intake_Track
(
	branch_ID int   not null ,
	intake_ID int   not null ,
	track_ID int   not null ,
	CONSTRAINT  BIT_branchFK FOREIGN KEY (branch_ID) REFERENCES Branch(branch_ID),
	CONSTRAINT  BIT_intakFK FOREIGN KEY (intake_ID) REFERENCES Intake(intake_ID) , 
	CONSTRAINT  BIT_trackFK FOREIGN KEY (track_ID) REFERENCES Track(track_ID),
	CONSTRAINT BITPK primary key (branch_ID , intake_ID , track_ID)
)
go
--for this procedure , we can create exams manually or auto through some informations like determine number of questions for each type of 
--questions we have like t/f questions ,mcq questions  and finally text questions  .
--determine degree foreach question in exam  . 
create procedure create_Exam
@Exam_date date ,
@start_time time , 
@End_Time time  ,
@allownece_option nvarchar(50) , 
@inst_ID int  , 
@Number_OF_MCQ_Question int = 0 ,
@Number_OF_TF_Question int = 0 ,
@Number_OF_TEXT_Question int = 0 ,
@course_ID int ,
@questions nvarchar(max) = null ,
@degrees nvarchar(max) = null
as
begin
	insert into Exam values(@Exam_date , @start_time ,  @End_Time ,DATEDIFF(MINUTE , @End_Time,@start_time) , @allownece_option , @inst_ID )
	declare @exam_ID int 
	set @exam_ID = SCOPE_Identity()
	IF @questions IS NOT NULL and @degrees is not null
	BEGIN
		DECLARE @ques_id_table TABLE (ques_id int)
		INSERT INTO @ques_id_table SELECT value FROM STRING_SPLIT(@questions, ',')
		DECLARE @ques_degree_table TABLE (ques_degree int)
		INSERT INTO @ques_degree_table SELECT value FROM STRING_SPLIT(@degrees, ',')
		DECLARE @ques_id int
		DECLARE @ques_degree int
		DECLARE questions_cursor CURSOR FOR SELECT ques_id , ques_degree FROM @ques_id_table , @ques_degree_table
		OPEN questions_cursor
		FETCH NEXT FROM questions_cursor INTO @ques_id , @ques_degree
		WHILE @@FETCH_STATUS = 0
		BEGIN
			insert into Exam_Question values (@exam_ID , @ques_id , @ques_degree)
			FETCH NEXT FROM questions_cursor INTO @ques_id , @ques_degree
		END
		CLOSE questions_cursor
		DEALLOCATE questions_cursor
	END
	ELSE
	BEGIN
		declare @degree float = (select max_degree from Course where course_ID = @course_ID )/ (@Number_OF_MCQ_Question + @Number_OF_TF_Question + @Number_OF_TEXT_Question)
		declare @i  int  = 0
		declare @q_ID int
		while @i < @Number_OF_MCQ_Question
		begin
			set @i = @i + 1
			set @q_ID = (select top (@Number_OF_MCQ_Question) [mcQ_ques].[ques_ID] from mcQ_ques join question on mcQ_ques.ques_ID = question.ques_ID where course_ID = @course_ID order by RAND())
			insert into Exam_Question values (@exam_ID , @q_ID , @degree)
		end
		set @i = 0
		while @i < @Number_OF_TF_Question
		begin
			set @i = @i + 1
			set @q_ID = (select top (@Number_OF_TF_Question) [true_false_ques].[ques_ID] from true_false_ques join question on true_false_ques.ques_ID = question.ques_ID where course_ID = @course_ID order by RAND())
			insert into Exam_Question values (@exam_ID , @q_ID , @degree)
		end
		set @i = 0
		while @i < @Number_OF_TEXT_Question
		begin
			set @i = @i + 1
			set @q_ID = (select top (@Number_OF_TEXT_Question) [text_ques].[ques_ID] from text_ques join question on text_ques.ques_ID = question.ques_ID where course_ID = @course_ID order by RAND())
			insert into Exam_Question values (@exam_ID , @q_ID , @degree)
		end
	end
end
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
--determine TF questions (number of questions and the correct answer for each question )

create procedure add_TF_Question
@ques_text nvarchar(max) ,
@correct_answer bit , 
@course_ID int
as
begin
	insert into question values(@ques_text, @course_ID)
	declare @ques_ID int 
	set @ques_ID = SCOPE_Identity()
	insert into true_false_ques values(@correct_answer, @ques_ID)
end
go
--determine TEXT questions (number of questions and best_accepted_answer for each question )

create procedure add_TEXT_Question
@ques_text nvarchar(max) ,
@best_accepted_answer nvarchar(max) , 
@course_ID int
as
begin
	insert into question values(@ques_text, @course_ID)
	declare @ques_ID int 
	set @ques_ID = SCOPE_Identity()
	insert into text_ques values(@best_accepted_answer, @ques_ID)
end
go
-- delete question through it's ID in the determined question's table  . 

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
-- assign Exam in  Class_Course table . 

create procedure assign_Exam
@class_ID int ,
@course_ID int ,
@inst_ID int ,
@exam_ID int
as
begin
	update Class_Course set exam_ID = @exam_ID where class_ID = @class_ID and course_ID = @course_ID and inst_ID = @inst_ID
end
go


--assign degree for each exam we have 
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
-- make Roles for  Instructor

CREATE ROLE Instructor
GRANT EXECUTE ON create_Exam TO [Instructor]
GRANT EXECUTE ON add_MCQ_Question TO [Instructor]
GRANT EXECUTE ON add_TF_Question TO [Instructor]
GRANT EXECUTE ON add_TEXT_Question TO [Instructor]
GRANT EXECUTE ON delete_Question TO [Instructor]
GRANT EXECUTE ON assign_Exam TO [Instructor]
GRANT EXECUTE ON mark_Exam TO [Instructor]
go
--create account for new instrcutor

CREATE TRIGGER AddInstructorToRoleTrigger
ON Instructor
AFTER INSERT
AS
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
	EXEC sp_addrolemember 'Instructor', @UserName
END
go
--assign new instructor 
create procedure add_Instructor
@inst_name nvarchar(50) ,
@inst_username nvarchar(50) , 
@inst_password nvarchar(50) ,
@is_tm bit
as
begin
	insert into Instructor values(@inst_name, @inst_username, @inst_password, @is_tm)
end
go


--assign new course 
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


--assign class course and instructor for each class/course 
create procedure add_class_course
@class_ID int ,
@course_ID int ,
@inst_ID int 
as
begin
	insert into Class_Course values(@class_ID, @course_ID, @inst_ID, null)
end
go


--delete specific instructor with id 
create procedure delete_Instructor
@inst_id int
as
begin
	update Class_Course set inst_ID = null where inst_ID = @inst_id
	delete from Instructor where inst_ID = @inst_id
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


--assign new branch 
create procedure add_Branch
@branch_name nvarchar(50) 
as
begin
	insert into Branch values(@branch_name)
end
go


--assign new track  
create procedure add_Track
@track_name nvarchar(50) ,
@dept_id int
as
begin
	insert into Track values(@track_name, @dept_id)
end
go

--assign new intake  
create procedure add_Intake
@intake_name nvarchar(50) ,
@end_date date ,
@start_date date
as
begin
	insert into Intake values(@intake_name, @end_date, @start_date)
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


--assign hole roles for Trainning_Manager
CREATE ROLE Trainning_Manager
GRANT EXECUTE ON add_Instructor TO [Trainning_Manager]
GRANT EXECUTE ON add_course TO [Trainning_Manager]
GRANT EXECUTE ON add_class_course TO [Trainning_Manager]
GRANT EXECUTE ON delete_Instructor TO [Trainning_Manager]
GRANT EXECUTE ON delete_Course TO [Trainning_Manager]
GRANT EXECUTE ON add_Branch TO [Trainning_Manager]
GRANT EXECUTE ON add_Track TO [Trainning_Manager]
GRANT EXECUTE ON add_Intake TO [Trainning_Manager]
GRANT EXECUTE ON add_Student TO [Trainning_Manager]
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

--check correct answer for mcq questions 
create procedure answer_MCQ_Quest
@student_id int ,
@exam_id int ,
@ques_id int ,
@student_answer char
as
begin
	DECLARE @is_correct bit
	IF @student_answer = (select correct_answer from mcQ_ques where ques_ID = @ques_id)
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


--check correct answer for text questions 

create procedure answer_TEXT_Quest
@student_id int ,
@exam_id int ,
@ques_id int ,
@student_answer nvarchar(50)
as
begin
	DECLARE @is_correct bit
	IF @student_answer like '%' + (select best_accpeted_Answer from text_ques where ques_ID = @ques_id) + '%'
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


--give student access to solve types of qustions (McQ , tf  , text )
CREATE ROLE Student
GRANT EXECUTE ON answer_MCQ_Quest TO [Student]
GRANT EXECUTE ON answer_TF_Quest TO [Student]
GRANT EXECUTE ON answer_TEXT_Quest TO [Student]
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
--prevent any operation to public people who not have permission  . 
DENY SELECT, UPDATE, INSERT, DELETE ON DATABASE::[Examination_System] TO public
go