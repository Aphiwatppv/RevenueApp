CREATE PROCEDURE [dbo].[spGetEmployeeDetail]
    @EN NVARCHAR(100)

AS
BEGIN
    SELECT
        EN,
        Name,
        RoleId
    FROM [dbo].[AccountTb]
    WHERE EN = @EN;
END;