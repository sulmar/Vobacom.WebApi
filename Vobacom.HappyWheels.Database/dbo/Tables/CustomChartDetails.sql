CREATE TABLE [dbo].[CustomChartDetails] (
    [CustomChartDetailId]                   INT            IDENTITY (1, 1) NOT NULL,
    [Analysis_AnalysisId]                   INT            NOT NULL,
    [CustomChart_CustomChartId]             INT            NOT NULL,
    [MeasurementDetail_MeasurementDetailId] INT            NOT NULL,
    [Color]                                 NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.CustomChartDetails] PRIMARY KEY CLUSTERED ([CustomChartDetailId] ASC),
    CONSTRAINT [FK_dbo.CustomChartDetails_dbo.Analyses_Analysis_AnalysisId] FOREIGN KEY ([Analysis_AnalysisId]) REFERENCES [dbo].[Analyses] ([AnalysisId]),
    CONSTRAINT [FK_dbo.CustomChartDetails_dbo.CustomCharts_CustomChart_CustomChartId] FOREIGN KEY ([CustomChart_CustomChartId]) REFERENCES [dbo].[CustomCharts] ([CustomChartId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CustomChartDetails_dbo.MeasurementDetails_MeasurementDetail_MeasurementDetailId] FOREIGN KEY ([MeasurementDetail_MeasurementDetailId]) REFERENCES [dbo].[MeasurementDetails] ([MeasurementDetailId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Analysis_AnalysisId]
    ON [dbo].[CustomChartDetails]([Analysis_AnalysisId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CustomChart_CustomChartId]
    ON [dbo].[CustomChartDetails]([CustomChart_CustomChartId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_MeasurementDetail_MeasurementDetailId]
    ON [dbo].[CustomChartDetails]([MeasurementDetail_MeasurementDetailId] ASC);

