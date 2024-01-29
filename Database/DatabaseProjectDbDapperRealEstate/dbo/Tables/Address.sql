CREATE TABLE [dbo].[Address] (
    [AddressID]      INT            IDENTITY (1, 1) NOT NULL,
    [AddressTitle1]  NVARCHAR (150) NOT NULL,
    [Description]    NVARCHAR (150) NOT NULL,
    [AddressTitile2] NVARCHAR (150) NOT NULL,
    [Phone1]         NVARCHAR (150) NOT NULL,
    [EMail]          NVARCHAR (150) NOT NULL,
    [Location]       NVARCHAR (500) NOT NULL
);
GO

ALTER TABLE [dbo].[Address]
    ADD CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressID] ASC);
GO

