CREATE PROCEDURE [dbo].[spGetDailyExpenseSummary]
    @limit DECIMAL(10,2) -- User-defined limit for total expense per day
AS
BEGIN
    SELECT 
        CAST([Date] AS DATE) AS ExpenseDate, -- Get the date without time
        SUM([Value]) AS TotalExpense, -- Total expense for the day
        CASE 
            WHEN SUM([Value]) > @limit THEN 'Out of Limit'
            ELSE 'Within Limit'
        END AS ExpenseStatus -- Whether the expense is over or under the limit
    FROM 
        [dbo].[ExpenseIncomeRecordTB]
    WHERE 
        [IsIncomeOrExpense] = 'Expense' -- We're only interested in expenses
    GROUP BY 
        CAST([Date] AS DATE) -- Group by day
    ORDER BY
        ExpenseDate DESC
END