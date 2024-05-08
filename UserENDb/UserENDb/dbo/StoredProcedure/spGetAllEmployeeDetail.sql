CREATE PROCEDURE [dbo].[spGetAllEmployeeDetail]
AS
BEGIN
    SELECT
        EN,
        Name,
        RoleId
    FROM [dbo].[AccountTb]

END;