CREATE TABLE [dbo].[Client] (
    [ClientID] INT             IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100)  NULL,
    [Title]    NVARCHAR (100)  NULL,
    [Comment]  NVARCHAR (2000) NULL,
    PRIMARY KEY CLUSTERED ([ClientID] ASC)
);
GO

