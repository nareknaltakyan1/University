CREATE TABLE [dbo].[teacher_subject]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Teacher_id INT not null FOREIGN KEY REFERENCES teachers(ID),
	Subject_id INT not null FOREIGN KEY REFERENCES subjects(ID)
)
