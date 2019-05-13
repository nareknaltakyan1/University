CREATE TABLE [dbo].[teachers]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName NVarChar(20) not null,
	LastName  NVarChar(20) not null,
	MiddleName NVarChar(20) not null,
	Birthday   Date not null,
	Address	   NVarChar(30) null,
	Phone	   VarChar(15) null,
)
