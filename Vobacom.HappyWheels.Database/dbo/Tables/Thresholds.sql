CREATE TABLE [dbo].[Thresholds] (
    [ThresholdId]         INT  IDENTITY (1, 1) NOT NULL,
    [Value]               REAL NOT NULL,
    [Analysis_AnalysisId] INT  NOT NULL,
    CONSTRAINT [PK_dbo.Thresholds] PRIMARY KEY CLUSTERED ([ThresholdId] ASC),
    CONSTRAINT [FK_dbo.Thresholds_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Analysis_AnalysisId]
    ON [dbo].[Thresholds]([Analysis_AnalysisId] ASC);

