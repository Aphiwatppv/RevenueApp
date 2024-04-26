CREATE PROCEDURE [dbo].[spUpdateDetailIncomeExpense]
    @DetailId INT,
    @Detail NVARCHAR(100) = NULL, -- Optional, defaults to no update
    @Type NVARCHAR(100) = NULL   -- Optional, defaults to no update
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Check if the record exists
    IF NOT EXISTS (SELECT 1 FROM DetailIncomeExpenseTB WHERE DetailId = @DetailId)
    BEGIN
        RAISERROR('Record with the specified ID does not exist.', 16, 1);
        RETURN;
    END;

    -- Update the record with provided values
    UPDATE DetailIncomeExpenseTB
    SET
        Detail = COALESCE(@Detail, Detail), -- Update only if new value is provided
        Type = COALESCE(@Type, Type)
    WHERE
        DetailId = @DetailId;
END;
