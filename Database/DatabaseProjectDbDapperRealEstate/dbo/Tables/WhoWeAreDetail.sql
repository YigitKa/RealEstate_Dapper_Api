CREATE TABLE [dbo].[WhoWeAreDetail] (
    [WhoWeAreDetailID] INT            IDENTITY (1, 1) NOT NULL,
    [Title]            NVARCHAR (100) NULL,
    [SubTitle]         NVARCHAR (100) NULL,
    [Description1]     NVARCHAR (500) NULL,
    [Description2]     NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([WhoWeAreDetailID] ASC)
);
GO

