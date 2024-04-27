CREATE PROCEDURE [dbo].[spAvgExpensePerMonth]
AS
BEGIN
    SET NOCOUNT ON;

    -- Calculate the average expense per month
    SELECT 
        DATEPART(YEAR, Date) AS ExpenseYear,
        DATEPART(MONTH, Date) AS ExpenseMonth,
        AVG(Value) AS AvgExpense
    FROM 
        ExpenseIncomeRecordTB
    WHERE 
        IsIncomeOrExpense = 'Expense'
    GROUP BY 
        DATEPART(YEAR, Date), -- Group by year
        DATEPART(MONTH, Date) -- Group by month
    ORDER BY 
        ExpenseYear, 
        ExpenseMonth; -- Optional: order by year and month
END;
