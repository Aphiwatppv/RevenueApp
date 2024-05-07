CREATE PROCEDURE [dbo].[spGetEmployeeDetail]
    @EN NVARCHAR(50)

AS
BEGIN
    SELECT
        EN,
        Name,
        RoleId
    FROM [dbo].[AccountTb]
    WHERE EN = @EN;
END;