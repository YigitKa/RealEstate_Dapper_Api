CREATE TABLE [dbo].[ProductDetails] (
    [ProductDetailID] INT             IDENTITY (1, 1) NOT NULL,
    [ProductID]       INT             NULL,
    [ProductSize]     INT             NULL,
    [BedroomCount]    TINYINT         NULL,
    [BathCount]       TINYINT         NULL,
    [RoomCount]       TINYINT         NULL,
    [GarageSize]      TINYINT         NULL,
    [BuildYear]       CHAR (4)        NULL,
    [Price]           DECIMAL (18, 2) NULL,
    [Location]        NVARCHAR (500)  NULL,
    [VideoURL]        NVARCHAR (500)  NULL,
    PRIMARY KEY CLUSTERED ([ProductDetailID] ASC),
    FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID]),
    FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ProductID])
);


GO

