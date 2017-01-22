CREATE TABLE [dbo].[StatusSetAnalysis] (
    [StatusSet_StatusSetId] INT NOT NULL,
    [Analysis_AnalysisId]   INT NOT NULL,
    CONSTRAINT [PK_dbo.AlarmSetAnalysis] PRIMARY KEY CLUSTERED ([StatusSet_StatusSetId] ASC, [Analysis_AnalysisId] ASC),
    CONSTRAINT [FK_dbo.AlarmSetAnalysis_dbo.AlarmSets_AlarmSet_AlarmSetId] FOREIGN KEY ([StatusSet_StatusSetId]) REFERENCES [dbo].[StatusSets] ([StatusSetId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.AlarmSetAnalysis_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AlarmSet_AlarmSetId]
    ON [dbo].[StatusSetAnalysis]([StatusSet_StatusSetId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Analysis_AnalysisId]
    ON [dbo].[StatusSetAnalysis]([Analysis_AnalysisId] ASC);

