CREATE TABLE [dbo].[CustomCharts] (
    [CustomChartId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (100) NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [CreateDate]    DATETIME2 (7)  NOT NULL,
    [Notes]         NVARCHAR (MAX) NULL,
    [Parameters]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.CustomCharts] PRIMARY KEY CLUSTERED ([CustomChartId] ASC)
);

