CREATE TABLE [dbo].[Analyses] (
    [AnalysisId]                INT            IDENTITY (1, 1) NOT NULL,
    [Parent_MeasurementPointId] INT            NOT NULL,
    [SamplingFrequency]         INT            NULL,
    [Resolution]                REAL           NULL,
    [Parameters]                NVARCHAR (MAX) NULL,
    [CreatedDate]               DATETIME2 (7)  NOT NULL,
    [ModifiedDate]              DATETIME2 (7)  NOT NULL,
    [Name]                      NVARCHAR (100) NOT NULL,
    [Description]               NVARCHAR (MAX) NULL,
    [ArgumentUnit_UnitId]       INT            NULL,
    [ValueUnit_UnitId]          INT            NOT NULL,
    CONSTRAINT [PK_dbo.Analyses] PRIMARY KEY CLUSTERED ([AnalysisId] ASC),
    CONSTRAINT [FK_dbo.Analyses_dbo.MeasurementPoints_Parent_MeasurementPointId] FOREIGN KEY ([Parent_MeasurementPointId]) REFERENCES [dbo].[MeasurementPoints] ([MeasurementPointId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Analyses_dbo.Units_ArgumentUnit_UnitId] FOREIGN KEY ([ArgumentUnit_UnitId]) REFERENCES [dbo].[Units] ([UnitId]),
    CONSTRAINT [FK_dbo.Analyses_dbo.Units_ValueUnit_UnitId] FOREIGN KEY ([ValueUnit_UnitId]) REFERENCES [dbo].[Units] ([UnitId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Parent_MeasurementPointId]
    ON [dbo].[Analyses]([Parent_MeasurementPointId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Name]
    ON [dbo].[Analyses]([Name] ASC, [Parent_MeasurementPointId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ArgumentUnit_UnitId]
    ON [dbo].[Analyses]([ArgumentUnit_UnitId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ValueUnit_UnitId]
    ON [dbo].[Analyses]([ValueUnit_UnitId] ASC);

