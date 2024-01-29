CREATE TABLE [dbo].[Services] (
    [ServiceID]     INT            IDENTITY (1, 1) NOT NULL,
    [ServiceName]   NVARCHAR (100) NULL,
    [ServiceStatus] BIT            NULL,
    PRIMARY KEY CLUSTERED ([ServiceID] ASC)
);


GO

