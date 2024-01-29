CREATE TABLE [dbo].[SubFeature] (
    [SubFeatureID] INT            IDENTITY (1, 1) NOT NULL,
    [Icon]         NVARCHAR (100) NOT NULL,
    [TopTitle]     NVARCHAR (100) NOT NULL,
    [MainTitle]    NVARCHAR (100) NOT NULL,
    [Description]  NVARCHAR (250) NOT NULL,
    [SubTitle]     NVARCHAR (100) NOT NULL
);
GO

ALTER TABLE [dbo].[SubFeature]
    ADD CONSTRAINT [PK_SubFeature] PRIMARY KEY CLUSTERED ([SubFeatureID] ASC);
GO

