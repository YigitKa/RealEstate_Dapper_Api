CREATE TABLE [dbo].[Contact] (
    [ContactID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (100) NOT NULL,
    [Subject]   NVARCHAR (100) NOT NULL,
    [EMail]     NVARCHAR (100) NOT NULL,
    [Message]   NVARCHAR (250) NOT NULL,
    [SentDate]  DATETIME       NOT NULL
);
GO

ALTER TABLE [dbo].[Contact]
    ADD CONSTRAINT [DEFAULT_Contact_SentDate] DEFAULT (getdate()) FOR [SentDate];
GO

ALTER TABLE [dbo].[Contact]
    ADD CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([ContactID] ASC);
GO

