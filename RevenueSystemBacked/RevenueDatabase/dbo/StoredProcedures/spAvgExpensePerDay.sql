CREATE PROCEDURE [dbo].[spAvgExpensePerDay]
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate the average expense per day
    SELECT 
        CAST(Date AS DATE) AS ExpenseDate,
        AVG(Value) AS AvgExpense
    FROM 
        ExpenseIncomeRecordTB
    WHERE 
        IsIncomeOrExpense = 'Expense'
    GROUP BY 
        CAST(Date AS DATE) -- Group by date (ignoring time)
    ORDER BY 
        ExpenseDate; -- Optional: order by date
END;
