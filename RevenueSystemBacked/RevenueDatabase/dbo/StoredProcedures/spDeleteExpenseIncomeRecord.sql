CREATE PROCEDURE [dbo].[spDeleteExpenseIncomeRecord]
    @RecordId INT -- The ID of the record to delete
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Check if the record exists
    IF NOT EXISTS (SELECT 1 FROM ExpenseIncomeRecordTB WHERE RecordId = @RecordId)
    BEGIN
        RAISERROR('Record with the specified ID does not exist.', 16, 1);
        RETURN;
    END;

    -- Delete the record with the specified ID
    DELETE FROM ExpenseIncomeRecordTB
    WHERE RecordId = @RecordId;
END;
