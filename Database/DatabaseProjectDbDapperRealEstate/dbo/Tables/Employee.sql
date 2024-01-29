CREATE TABLE [dbo].[Employee] (
    [EmployeeID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (100) NULL,
    [Title]      NVARCHAR (100) NULL,
    [Phone]      NVARCHAR (100) NULL,
    [Mail]       NVARCHAR (100) NULL,
    [ImageURL]   NVARCHAR (100) NULL,
    [Status]     BIT            NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);
GO

