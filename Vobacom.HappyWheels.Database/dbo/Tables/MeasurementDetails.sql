CREATE TABLE [dbo].[MeasurementDetails] (
    [MeasurementDetailId]                 INT            IDENTITY (1, 1) NOT NULL,
    [DeviceSerialNumber]                  VARCHAR (8)    NOT NULL,
    [SensorSerialNumber]                  VARCHAR (12)   NOT NULL,
    [MeasurementPoint_MeasurementPointId] INT            NOT NULL,
    [Measurement_MeasurementId]           INT            NOT NULL,
    [Channel]                             SMALLINT       NOT NULL,
    [SamplesFilename]                     NVARCHAR (255) NOT NULL,
    [SensorSensitivity]                   REAL           NOT NULL,
    [SensorOffset]                        REAL           NOT NULL,
    [InputUnit_UnitId]                    INT            NOT NULL,
    [OutputUnit_UnitId]                   INT            NOT NULL,
    CONSTRAINT [PK_dbo.MeasurementDetails] PRIMARY KEY CLUSTERED ([MeasurementDetailId] ASC),
    CONSTRAINT [FK_dbo.MeasurementDetails_dbo.MeasurementPoints_MeasurementPoint_MeasurementPointId] FOREIGN KEY ([MeasurementPoint_MeasurementPointId]) REFERENCES [dbo].[MeasurementPoints] ([MeasurementPointId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.MeasurementDetails_dbo.Measurements_Measurement_MeasurementId] FOREIGN KEY ([Measurement_MeasurementId]) REFERENCES [dbo].[Measurements] ([MeasurementId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.MeasurementDetails_dbo.Units_InputUnit_UnitId] FOREIGN KEY ([InputUnit_UnitId]) REFERENCES [dbo].[Units] ([UnitId]),
    CONSTRAINT [FK_dbo.MeasurementDetails_dbo.Units_OutputUnit_UnitId] FOREIGN KEY ([OutputUnit_UnitId]) REFERENCES [dbo].[Units] ([UnitId])
);


GO
CREATE NONCLUSTERED INDEX [IX_MeasurementPoint_MeasurementPointId]
    ON [dbo].[MeasurementDetails]([MeasurementPoint_MeasurementPointId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_MeasurementPoint_Measurement]
    ON [dbo].[MeasurementDetails]([MeasurementPoint_MeasurementPointId] ASC, [Measurement_MeasurementId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Measurement_MeasurementId]
    ON [dbo].[MeasurementDetails]([Measurement_MeasurementId] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_SamplesFilename]
    ON [dbo].[MeasurementDetails]([SamplesFilename] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_InputUnit_UnitId]
    ON [dbo].[MeasurementDetails]([InputUnit_UnitId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_OutputUnit_UnitId]
    ON [dbo].[MeasurementDetails]([OutputUnit_UnitId] ASC);


GO
CREATE TRIGGER OnDeleteMeasurementDetail
    ON [dbo].[MeasurementDetails]
    FOR DELETE
AS
DELETE [dbo].[Samples]  FROM [dbo].[Samples] 
INNER JOIN deleted ON [dbo].[Samples].name = deleted.SamplesFilename