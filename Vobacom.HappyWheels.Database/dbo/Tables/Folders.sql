CREATE TABLE [dbo].[Folders] (
    [FolderId]        INT            IDENTITY (1, 1) NOT NULL,
    [Parent_FolderId] INT            NULL,
    [CreatedDate]     DATETIME2 (7)  NOT NULL,
    [ModifiedDate]    DATETIME2 (7)  NOT NULL,
    [Name]            NVARCHAR (100) NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Folders] PRIMARY KEY CLUSTERED ([FolderId] ASC),
    CONSTRAINT [FK_dbo.Folders_dbo.Folders_Parent_FolderId] FOREIGN KEY ([Parent_FolderId]) REFERENCES [dbo].[Folders] ([FolderId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Parent_FolderId]
    ON [dbo].[Folders]([Parent_FolderId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Name]
    ON [dbo].[Folders]([Name] ASC, [Parent_FolderId] ASC);

