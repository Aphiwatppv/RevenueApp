CREATE PROCEDURE [dbo].[spGetAllDetails]
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Retrieve all records from the DetailIncomeExpenseTB table
    SELECT
        DetailId,
        Detail,
        Type
    FROM
        DetailIncomeExpenseTB
    ORDER BY
        DetailId; -- Optional, you can change the sorting order or criteria
END;
