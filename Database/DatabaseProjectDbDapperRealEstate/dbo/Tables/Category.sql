CREATE TABLE [dbo].[Category] (
    [CategoryID]     INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]   NVARCHAR (50) NULL,
    [CategoryStatus] BIT           NULL,
    PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);
GO

