CREATE TABLE [dbo].[StatusSets] (
    [StatusSetId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Refresh]     TIME (7)       NOT NULL,
    [Period]      TIME (7)       NOT NULL,
    [Notes]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.AlarmSets] PRIMARY KEY CLUSTERED ([StatusSetId] ASC)
);

