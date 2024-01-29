CREATE TABLE [dbo].[PopularLocation] (
    [LocationID] INT            IDENTITY (1, 1) NOT NULL,
    [CityName]   NVARCHAR (50)  NOT NULL,
    [ImageURL]   NVARCHAR (500) NULL
);
GO

ALTER TABLE [dbo].[PopularLocation]
    ADD CONSTRAINT [PK_PopularLocation] PRIMARY KEY CLUSTERED ([LocationID] ASC);
GO

