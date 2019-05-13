CREATE TABLE [dbo].[student_subject]
(
	[Id]		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Student_Id	INT not null FOREIGN KEY REFERENCES students(ID),
	Subjects_Id INT not null FOREIGN KEY REFERENCES subjects(ID),
	Mark		INT		null,
)
