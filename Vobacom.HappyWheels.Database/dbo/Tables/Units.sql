CREATE TABLE [dbo].[Units] (
    [UnitId]           INT           IDENTITY (1, 1) NOT NULL,
    [CoefficientA]     REAL          NOT NULL,
    [CoefficientB]     REAL          NOT NULL,
    [UnitSymbol]       NVARCHAR (10) NOT NULL,
    [PhysicalQuantity] NVARCHAR (12) NOT NULL,
    [Common]           BIT           NOT NULL,
    CONSTRAINT [PK_dbo.Units] PRIMARY KEY CLUSTERED ([UnitId] ASC)
);

