CREATE TABLE [dbo].[AnalysedMeasurementNotes] (
    [Analysis_AnalysisId]       INT            NOT NULL,
    [Measurement_MeasurementId] INT            NOT NULL,
    [Notes]                     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.AnalysedMeasurementNotes] PRIMARY KEY CLUSTERED ([Analysis_AnalysisId] ASC, [Measurement_MeasurementId] ASC),
    CONSTRAINT [FK_dbo.AnalysedMeasurementNotes_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.AnalysedMeasurementNotes_dbo.Measurements_Measurement_MeasurementId] FOREIGN KEY ([Measurement_MeasurementId]) REFERENCES [dbo].[Measurements] ([MeasurementId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Analysis_AnalysisId]
    ON [dbo].[AnalysedMeasurementNotes]([Analysis_AnalysisId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Measurement_MeasurementId]
    ON [dbo].[AnalysedMeasurementNotes]([Measurement_MeasurementId] ASC);

