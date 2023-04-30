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
--assign new track  
create procedure add_Track
@track_name nvarchar(50) ,
@dept_id int
as
begin
	insert into Track values(@track_name, @dept_id)
end
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

--delete specific instructor with id 
create procedure delete_Instructor
@inst_id int
as
begin
	update Class_Course set inst_ID = null where inst_ID = @inst_id
	delete from Instructor where inst_ID = @inst_id
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
--assign new track  
create procedure add_Track
@track_name nvarchar(50) ,
@dept_id int
as
begin
	insert into Track values(@track_name, @dept_id)
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



EXEC [dbo].[add_Instructor] @inst_name = N'mahmoud', @inst_username = N'mahnas', @inst_password = N'123456', @is_tm = 0
INSERT INTO	[dbo].[Department] VALUES('SD')

EXEC [dbo].[add_Track] @track_name = N'.Net', @dept_id = 1

EXEC [dbo].[add_Intake] @intake_name = N'Q32023', @end_date = '2023-06-30', @start_date = '2023-03-06'
EXEC [dbo].[create_Exam] @Exam_date = '2023-05-12', @start_time = '12:00:00', @End_Time = '02:00:00', @allownece_option = '', @inst_id = 2, @Number_OF_MCQ_Question = 1 , @Number_OF_TF_Question = 1 , @Number_OF_TEXT_Question = 1 , @course_id = 1


EXEC [dbo].[assign_Exam] @class_ID = 1, @course_ID = 1, @inst_ID = 2, @exam_ID = 4
EXEC [dbo].[answer_MCQ_Quest] @student_id = 1, @exam_id = 4, @ques_id = 1, @student_answer = 'a'
EXEC [dbo].[answer_TEXT_Quest] @student_id = 1, @exam_id = 4, @ques_id = 3, @student_answer = 'String'
