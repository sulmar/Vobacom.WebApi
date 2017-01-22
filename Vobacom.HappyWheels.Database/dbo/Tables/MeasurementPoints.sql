CREATE TABLE [dbo].[MeasurementPoints] (
    [MeasurementPointId] INT            IDENTITY (1, 1) NOT NULL,
    [Parent_FolderId]    INT            NOT NULL,
    [CreatedDate]        DATETIME2 (7)  NOT NULL,
    [ModifiedDate]       DATETIME2 (7)  NOT NULL,
    [Name]               NVARCHAR (100) NOT NULL,
    [Description]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.MeasurementPoints] PRIMARY KEY CLUSTERED ([MeasurementPointId] ASC),
    CONSTRAINT [FK_dbo.MeasurementPoints_dbo.Folders_Parent_FolderId] FOREIGN KEY ([Parent_FolderId]) REFERENCES [dbo].[Folders] ([FolderId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Parent_FolderId]
    ON [dbo].[MeasurementPoints]([Parent_FolderId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Name]
    ON [dbo].[MeasurementPoints]([Name] ASC, [Parent_FolderId] ASC);

