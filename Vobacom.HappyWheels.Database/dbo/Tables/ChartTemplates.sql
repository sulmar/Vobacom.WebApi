CREATE TABLE [dbo].[ChartTemplates] (
    [ChartTemplateId]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]                NVARCHAR (100) NOT NULL,
    [Parameters]          NVARCHAR (MAX) NOT NULL,
    [Analysis_AnalysisId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.ChartTemplates] PRIMARY KEY CLUSTERED ([ChartTemplateId] ASC),
    CONSTRAINT [FK_dbo.ChartTemplates_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Analysis_AnalysisId]
    ON [dbo].[ChartTemplates]([Analysis_AnalysisId] ASC);

