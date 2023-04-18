--DDL: Data definition language
-------------------------------Database--------------------------------------
--Create:
create database NetQ32023
--ldf: log data file - one and only one - log for trasactions done in DB
--mdf: mandatory data file - one and only one - actual structure and data
--ndf: secondary data file - zero or more - actual structure and data

--primary filegroup: initial file group you can add another. contain mdf

--------------------------------Database--------------------------------
------- primary file group -----x file group------- log file -----------
--------------mdf,ndf--------------ndf,ndf------------------------------
--files properties:
--name
--physical name
--initial size
--max size
--file growth

create database NetQ32023
on(
	Name=datafile1,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ32023.mdf',
	size=10MB,
	maxsize=unlimited,
	filegrowth = 4MB
),
(
	Name=datafile2,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ32023.ndf',
	size=10MB,
	maxsize=unlimited,
	filegrowth = 4MB
),
filegroup secondary 
(
	Name=datafile3,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ320232.ndf',
	size=10MB,
	maxsize=unlimited,
	filegrowth = 4MB
),
(
	Name=datafile4,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ320233.ndf',
	size=10MB,
	maxsize=unlimited,
	filegrowth = 4MB
)
log on
(
	Name=logfile1,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ32023.ldf',
	size=10MB,
	maxsize=50MB,
	filegrowth = 4MB
)

--Alter:
alter database NetQ32023
add filegroup Third

alter database NetQ32023
add file 
(
	Name=datafile5,
	fileName = 'G:\Minia ITP 2022-2023\Q3\.Net 2\SQL\DB\NetQ320234.ndf',
	size=10MB,
	maxsize=unlimited,
	filegrowth = 4MB
) to filegroup Third

alter database NetQ32023
modify filegroup Third default 

alter database NetQ32023
remove file datafile4

alter database NetQ32023
remove filegroup secondary

--Drop:
drop database NetQ32023

--------------------------------Tables----------------------------------------
--Create:
--String DataType: varchar, char, nvarchar, nchar
use NetQ32023

create table Dean 
(
	ID int not null, --primary key,
	Name varchar(50) not null,
	constraint DeanPK primary key (ID)
)

create table Faculty
(
	ID int not null,
	Name varchar(50) not null,
	DeanID int not null --foreign key references Dean(ID)
	--constraint FacultyDeanFK foreign key (DeanID) references Dean(ID)
)

alter table Faculty
add constraint FacultyPK primary key (ID)

alter table Faculty
add constraint FacultyDeanFK foreign key (DeanID) references Dean(ID)

create table Department
(
	ID int not null,
	Name varchar(50) not null,
	FacultyID int not null,
	constraint DeptPK primary key (ID),
	constraint DeptFacultyFK foreign key (FacultyID) references Faculty(ID)
)

alter table Department
add ChairmanID int null
go
alter table Department
add constraint DepartmentProfessorFK foreign key (ChairmanID) references Professor(ID)
go
create table Professor
(
	ID int not null,
	constraint ProfessorPK primary key (ID),
	Name varchar(50) not null,
	constraint ProfessorNameCheck check (len(Name)>2),
	Email varchar(50) not null,
	constraint ProfessorEmailCheck check (Email like '%_@__%.__%'),
	Phone char(11) not null,
	constraint ProfessorPhoneCheck check (len(Phone)=11),
	DeptID int not null,
	constraint ProfessorDeptFK foreign key (DeptID) references Department(ID),
	ManagerID int null,
	constraint ProfessorManagerFK foreign key (ManagerID) references Professor(ID)
)

alter table Professor
add constraint ProfessorUniqueEmail Unique (Email)

alter table Professor
add test int not null

alter table Professor
alter column test char(5) null

alter table Professor
drop constraint ProfessorNameCheck

alter table Professor
drop column test

create table Advisor
(
	ID int not null primary key,
	constraint AdvisorProfessorFK foreign key (ID) references Professor(ID),
	STDN int not null
) on SECONDARY


drop table Advisor

---------------------------------------------------------------------------------
--DML: insert, update, delete

insert into [dbo].[Dean]
values (1,'Dean1')

insert into [dbo].[Dean](Name,ID) values('Dean2',2)

insert into [dbo].[Dean] values(3,'Dean3'),(4,'Dean4'),(5,'Dean5')

update [dbo].[Dean] 
set Name = 'Dean2 - Edited'
where ID = 2

update [dbo].[Professor]
set ManagerID = 1
where DeptID = 1

delete [dbo].[Professor]
where Email = 'p2@gmail.com'

--where colx > val < >= <= !=
--where colx > val and coly < val
--where colx = val or coly = val
--where colx not null
--where colx like '%@gmail.com'
--where colx between val and val
--where colx in (val, val, val, ...)

---------------------------------------------------------------------------------
--DQL: select
select ID, Name from [dbo].[Professor]
where Phone like '010%'
--where Email like '%@gmail.com' or ManagerID is NULL 