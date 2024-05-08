CREATE PROCEDURE [dbo].[spGetSaltHash]
    @EN NVARCHAR(100)
AS
BEGIN
    SELECT
        Salt,
        HashPassword
    FROM [dbo].[AccountTb]
    WHERE EN = @EN;
END;
