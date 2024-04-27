CREATE PROCEDURE [dbo].[spCurrentMonthExpense]
AS
BEGIN
    SET NOCOUNT ON;

    -- Get the current year and month
    DECLARE @CurrentYear INT = DATEPART(YEAR, GETDATE());
    DECLARE @CurrentMonth INT = DATEPART(MONTH, GETDATE());

    -- Calculate the total expense for the current month
    SELECT 
        @CurrentYear AS ExpenseYear,
        @CurrentMonth AS ExpenseMonth,
        SUM(Value) AS TotalExpense
    FROM 
        ExpenseIncomeRecordTB
    WHERE 
        IsIncomeOrExpense = 'Expense'
        AND DATEPART(YEAR, Date) = @CurrentYear
        AND DATEPART(MONTH, Date) = @CurrentMonth;
END;
