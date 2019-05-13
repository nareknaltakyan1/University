﻿/*
Deployment script for DB_A4753D_university

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DB_A4753D_university"
:setvar DefaultFilePrefix "DB_A4753D_university"
:setvar DefaultDataPath "H:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data\"
:setvar DefaultLogPath "H:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[users]...';


GO
CREATE TABLE [dbo].[users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (15) NOT NULL,
    [Password] NVARCHAR (15) NOT NULL,
    [Faculty]  NVARCHAR (15) NULL,
    [Age]      INT           NULL,
    [Salary]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Update complete.';


GO
