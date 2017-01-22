CREATE TABLE [dbo].[SingleValueResults] (
    [SingleValueResultId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Analysis_AnalysisId] INT            NOT NULL,
    [DateTime]            DATETIME2 (7)  NOT NULL,
    [Value]               REAL           NOT NULL,
    [Notes]               NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.SingleValueResults] PRIMARY KEY CLUSTERED ([SingleValueResultId] ASC),
    CONSTRAINT [FK_dbo.SingleValueResults_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]) ON DELETE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_DateTime_Analysis]
    ON [dbo].[SingleValueResults]([DateTime] ASC, [Analysis_AnalysisId] ASC);

