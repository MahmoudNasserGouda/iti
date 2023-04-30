USE [Examination_System]
GO

EXEC [dbo].[add_Instructor] @inst_name = N'mahmoud', @inst_username = N'mahnas', @inst_password = N'123456', @is_tm = 0

EXEC [dbo].[add_course] @course_name = N'C#', @course_desc = N'lorem ipsum', @max_deg = 90, @min_deg = 45

INSERT INTO	[dbo].[Department] VALUES('SD')
EXEC [dbo].[add_Track] @track_name = N'.Net', @dept_id = 1
EXEC [dbo].[add_Branch] @branch_name = N'minia'
EXEC [dbo].[add_Intake] @intake_name = N'Q32023', @end_date = '2023-06-30', @start_date = '2023-03-06'

INSERT INTO	[dbo].[Class] VALUES(1,1,1)

EXEC [dbo].[add_class_course] @class_ID = 1, @course_ID = 1, @inst_ID = 2

EXEC [dbo].[add_MCQ_Question] @ques_text = N'what is not a data type?', @correct_answer = 'a', @choices = N'car,int,bool,float', @course_ID = 1
EXEC [dbo].[add_TF_Question] @ques_text = N'is double a data type?', @correct_answer = 1, @course_ID = 1
EXEC [dbo].[add_TEXT_Question] @ques_text = N'data type for text values?', @best_accepted_answer = 'String', @course_ID = 1

EXEC [dbo].[add_Student] @student_name = N'Ali', @student_username = N'al1', @student_password = N'11111', @student_class_id = 1
EXEC [dbo].[add_Student] @student_name = N'Mostafa', @student_username = N'mo1', @student_password = N'22222', @student_class_id = 1
EXEC [dbo].[add_Student] @student_name = N'Said', @student_username = N'sa1', @student_password = N'33333', @student_class_id = 1

EXEC [dbo].[create_Exam] @Exam_date = '2023-05-12', @start_time = '12:00:00', @End_Time = '02:00:00', @allownece_option = '', @inst_id = 2, @Number_OF_MCQ_Question = 1 , @Number_OF_TF_Question = 1 , @Number_OF_TEXT_Question = 1 , @course_id = 1

EXEC [dbo].[assign_Exam] @class_ID = 1, @course_ID = 1, @inst_ID = 2, @exam_ID = 4

EXEC [dbo].[answer_MCQ_Quest] @student_id = 1, @exam_id = 4, @ques_id = 1, @student_answer = 'a'
EXEC [dbo].[answer_TF_Quest] @student_id = 1, @exam_id = 4, @ques_id = 2, @student_answer = 1
EXEC [dbo].[answer_TEXT_Quest] @student_id = 1, @exam_id = 4, @ques_id = 3, @student_answer = 'String'

EXEC [dbo].[mark_Exam] @student_ID = 1, @class_ID = 1, @course_ID = 1