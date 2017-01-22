CREATE PROCEDURE [dbo].[uspAddSamples]
    @filename [nvarchar](255),
    @filedata [varbinary](max)
AS
BEGIN
    DECLARE @docid uniqueidentifier;
    SET @docid = NEWID();
    INSERT INTO dbo.Samples(stream_id, file_stream, name) VALUES (@docId , @filedata, @filename);
    
END