use DB_A4753D_university;

go

INSERT INTO dbo.users (UserName, Password, Faculty, Age, Salary)
VALUES ('Narek','94954838Ln#','IT','20','20000');

go

INSERT INTO dbo.course(Name,Birthday)
VALUES ('H719-1','2017-09-01');

go

INSERT INTO dbo.students(FirstName,LastName,MiddleName,Birthday,Address,Phone,Course_Id)
VALUES ('Narek','Naltakyan','Levon','1999-11-12','Charentsavan 4-13-29','094954838',1);

go

INSERT INTO dbo.subjects(Name)
VALUES ('Math');

go

INSERT INTO dbo.teachers(FirstName,LastName,MiddleName,Birthday,Address,Phone)
VALUES('Levon','Khachatryan','Armen','1970-04-05','Yerevan Charents 1', '456654321');

go

INSERT INTO dbo.teacher_subject(Teacher_id,Subject_id)
VALUES (1,1);

go

INSERT INTO dbo.student_subject(Student_Id,Subjects_Id)
VALUES (1,1);

go

