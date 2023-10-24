CREATE TABLE [dbo].[History] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [WorkItemId]  VARCHAR (200)   NOT NULL,
    [Name]        NVARCHAR (255)  NULL,
    [Description] NVARCHAR (MAX)  NULL,
    [Hours]       DECIMAL (10, 2) NULL,
    [CreatedDate] DATETIME DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

