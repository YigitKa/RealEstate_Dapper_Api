CREATE TABLE [dbo].[MailSubscribe] (
    [SubScribeID] INT            IDENTITY (1, 1) NOT NULL,
    [EMail]       NVARCHAR (100) NOT NULL
);
GO

ALTER TABLE [dbo].[MailSubscribe]
    ADD CONSTRAINT [PK_MailSubscribe] PRIMARY KEY CLUSTERED ([SubScribeID] ASC);
GO

