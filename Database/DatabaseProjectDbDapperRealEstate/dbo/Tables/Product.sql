CREATE TABLE [dbo].[Product] (
    [ProductID]       INT             IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (100)  NULL,
    [Price]           DECIMAL (18, 2) NULL,
    [CoverImage]      NVARCHAR (250)  NULL,
    [City]            NVARCHAR (100)  NULL,
    [District]        NVARCHAR (100)  NULL,
    [Address]         NVARCHAR (500)  NULL,
    [Description]     NVARCHAR (MAX)  NULL,
    [ProductCategory] INT             NULL,
    [EmployeeID]      INT             NULL,
    [Type]            NVARCHAR (10)   NULL,
    [DealOfTheDay]    BIT             CONSTRAINT [DEFAULT_Product_DealOfDay] DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC),
    FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID]),
    FOREIGN KEY ([ProductCategory]) REFERENCES [dbo].[Category] ([CategoryID])
);
GO


ALTER TABLE [dbo].[Product]
    ADD CONSTRAINT [DEFAULT_Product_DealOfDay] DEFAULT ((0)) FOR [DealOfTheDay];
GO

