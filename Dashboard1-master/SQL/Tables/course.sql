CREATE TABLE [dbo].[course]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVarChar(10) NOT NULL,
	[Birthday]   Date not null
)
