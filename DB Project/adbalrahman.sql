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

--give student access to solve types of qustions (McQ , tf  , text )
CREATE ROLE Student
GRANT EXECUTE ON answer_MCQ_Quest TO [Student]
GRANT EXECUTE ON answer_TF_Quest TO [Student]
GRANT EXECUTE ON answer_TEXT_Quest TO [Student]
go


CREATE ROLE Instructor
GRANT EXECUTE ON create_Exam TO [Instructor]
GRANT EXECUTE ON add_MCQ_Question TO [Instructor]
GRANT EXECUTE ON add_TF_Question TO [Instructor]
GRANT EXECUTE ON add_TEXT_Question TO [Instructor]
GRANT EXECUTE ON delete_Question TO [Instructor]
GRANT EXECUTE ON assign_Exam TO [Instructor]
GRANT EXECUTE ON mark_Exam TO [Instructor]
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

--assign new branch 
create procedure add_Branch
@branch_name nvarchar(50) 
as
begin
	insert into Branch values(@branch_name)
end
go
--prevent any operation to public people who not have permission  . 
DENY SELECT, UPDATE, INSERT, DELETE ON DATABASE::[Examination_System] TO public
go


EXEC [dbo].[add_Branch] @branch_name = N'minia'
INSERT INTO	[dbo].[Class] VALUES(1,1,1)

EXEC [dbo].[add_class_course] @class_ID = 1, @course_ID = 1, @inst_ID = 2
EXEC [dbo].[add_TF_Question] @ques_text = N'is double a data type?', @correct_answer = 1, @course_ID = 1
EXEC [dbo].[add_TEXT_Question] @ques_text = N'data type for text values?', @best_accepted_answer = 'String', @course_ID = 1
