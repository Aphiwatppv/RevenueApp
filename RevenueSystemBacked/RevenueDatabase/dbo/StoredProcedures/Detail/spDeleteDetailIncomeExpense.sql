CREATE PROCEDURE [dbo].[spDeleteDetailIncomeExpense]
    @DetailId INT
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

    -- Delete the record with the specified ID
    DELETE FROM DetailIncomeExpenseTB
    WHERE DetailId = @DetailId;
END;
