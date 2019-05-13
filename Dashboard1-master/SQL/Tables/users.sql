CREATE TABLE [dbo].[users]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [UserName] NVARCHAR(15) NOT NULL  PRIMARY KEY, 
    [Password] NVARCHAR(15) NOT NULL,
	[Faculty]  NVARCHAR(15) NULL,
	[Age]	   INT			NULL,
	[Salary]   INT			NULL,
)
