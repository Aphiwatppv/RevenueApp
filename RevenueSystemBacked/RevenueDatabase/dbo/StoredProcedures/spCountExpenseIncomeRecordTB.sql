CREATE PROCEDURE [dbo].[spCountExpenseIncomeRecordTB]
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Count all records in ExpenseIncomeRecordTB
    SELECT COUNT(*) AS RecordCount
    FROM ExpenseIncomeRecordTB;
END;
