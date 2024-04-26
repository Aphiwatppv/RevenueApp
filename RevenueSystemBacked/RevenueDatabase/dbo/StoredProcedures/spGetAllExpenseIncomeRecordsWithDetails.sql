CREATE PROCEDURE [dbo].[spGetAllExpenseIncomeRecordsWithDetails]
AS
BEGIN
   
    SET NOCOUNT ON;
    SELECT
        ExpenseIncomeRecordTB.RecordId,
        ExpenseIncomeRecordTB.Account,
        DetailIncomeExpenseTB.Detail, 
        DetailIncomeExpenseTB.Type,  
        DetailIncomeExpenseTB.DetailId,
        ExpenseIncomeRecordTB.IsIncomeOrExpense,
        ExpenseIncomeRecordTB.Value,
        ExpenseIncomeRecordTB.Date
    FROM
        ExpenseIncomeRecordTB
    JOIN
        DetailIncomeExpenseTB ON ExpenseIncomeRecordTB.DetailId = DetailIncomeExpenseTB.DetailId
    ORDER BY
        ExpenseIncomeRecordTB.Date DESC; -- Optional, sorts records by date in descending order
END;