CREATE PROCEDURE [dbo].[spCurrentDayExpense]
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate today's date
    DECLARE @Today DATE = CAST(GETDATE() AS DATE);

    -- Calculate the total expense for the current day
    SELECT 
        @Today AS ExpenseDate,
        SUM(Value) AS TotalExpense
    FROM 
        ExpenseIncomeRecordTB
    WHERE 
        IsIncomeOrExpense = 'Expense'
        AND CAST(Date AS DATE) = @Today;
END;
