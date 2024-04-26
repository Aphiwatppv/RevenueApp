CREATE PROCEDURE [dbo].[spAddDetailIncomeExpense]
    @Detail NVARCHAR(100),
    @Type NVARCHAR(100)
AS
BEGIN
    -- Prevent extra informational messages
    SET NOCOUNT ON;

    -- Insert a new record into DetailIncomeExpenseTB
    INSERT INTO DetailIncomeExpenseTB (Detail, Type)
    VALUES (@Detail, @Type);
END;
