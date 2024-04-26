CREATE PROCEDURE [dbo].[spUpdateExpenseIncomeRecord]
    @RecordId INT, -- The ID of the record to update
    @Account NVARCHAR(255) = NULL, -- Optional, defaults to NULL (no update)
    @DetailId INT = NULL, -- Optional, defaults to NULL (no update)
    @IsIncomeOrExpense NVARCHAR(20) = NULL, -- Optional
    @Value DECIMAL(10,2) = NULL, -- Optional
    @Date DATETIME = NULL -- Optional
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

    -- Update the record with non-null values
    UPDATE ExpenseIncomeRecordTB
    SET
        Account = COALESCE(@Account, Account), -- Update only if new value is provided
        DetailId = COALESCE(@DetailId, DetailId),
        IsIncomeOrExpense = COALESCE(@IsIncomeOrExpense, IsIncomeOrExpense),
        Value = COALESCE(@Value, Value),
        Date = COALESCE(@Date, Date)
    WHERE
        RecordId = @RecordId;
END;
