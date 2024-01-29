CREATE TABLE [dbo].[BottomGrid] (
    [BottomGridID] INT            IDENTITY (1, 1) NOT NULL,
    [Icon]         NVARCHAR (100) NULL,
    [Title]        NVARCHAR (100) NULL,
    [Description]  NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([BottomGridID] ASC)
);
GO

