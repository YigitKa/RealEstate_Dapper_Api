CREATE TABLE [dbo].[SocailMedia] (
    [SocialMediaID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [Icon]          NVARCHAR (50)  NOT NULL,
    [URL]           NVARCHAR (250) NOT NULL
);
GO

ALTER TABLE [dbo].[SocailMedia]
    ADD CONSTRAINT [PK_SocailMedia] PRIMARY KEY CLUSTERED ([SocialMediaID] ASC);
GO

