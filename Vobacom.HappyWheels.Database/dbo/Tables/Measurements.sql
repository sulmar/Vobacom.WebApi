CREATE TABLE [dbo].[Measurements] (
    [MeasurementId]     INT            IDENTITY (1, 1) NOT NULL,
    [DateTime]          DATETIME2 (7)  NOT NULL,
    [Notes]             NVARCHAR (MAX) NULL,
    [SamplingFrequency] INT            NOT NULL,
    [Resolution]        REAL           NOT NULL,
    CONSTRAINT [PK_dbo.Measurements] PRIMARY KEY CLUSTERED ([MeasurementId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_DateTime]
    ON [dbo].[Measurements]([DateTime] ASC);

