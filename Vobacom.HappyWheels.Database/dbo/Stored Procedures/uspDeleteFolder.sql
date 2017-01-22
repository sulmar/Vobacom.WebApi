CREATE PROCEDURE [dbo].[uspDeleteFolder]
    @FolderId [int]
AS
BEGIN
    WITH    q AS
    (
    SELECT  FolderId
    FROM    dbo.Folders
    WHERE   FolderId = @FolderId
    UNION ALL
    SELECT  tc.FolderId
    FROM    q
    JOIN    dbo.Folders tc
    ON      tc.Parent_FolderId = q.FolderId
    
    )
    DELETE
    FROM    dbo.Folders
    WHERE   EXISTS
    (
    SELECT  FolderId
    INTERSECT
    SELECT  FolderId
    FROM    q
    )
END