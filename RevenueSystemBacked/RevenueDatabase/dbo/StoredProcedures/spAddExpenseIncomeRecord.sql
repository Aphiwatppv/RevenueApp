CREATE PROCEDURE [dbo].[spAddExpenseIncomeRecord]
    @Account NVARCHAR(255) = NULL,
    @DetailId INT, -- References the DetailIncomeExpenseTB table
    @IsIncomeOrExpense NVARCHAR(20), -- Must be either 'Income' or 'Expense'
    @Value DECIMAL(10,2),
    @Date DATETIME = NULL -- Optional parameter, defaults to current date
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Default account if not provided
    IF @Account IS NULL
        SET @Account = 'Aphiwat';

    -- Use current date if not provided
    IF @Date IS NULL
        SET @Date = GETDATE();

    -- Insert a new record into the ExpenseIncomeRecordTB table
    INSERT INTO ExpenseIncomeRecordTB (
        Account,
        DetailId,
        IsIncomeOrExpense,
        Value,
        Date
    ) VALUES (
        @Account,
        @DetailId,
        @IsIncomeOrExpense,
        @Value,
        @Date
    );
END;
