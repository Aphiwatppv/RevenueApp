CREATE TABLE [dbo].[ExpenseIncomeRecordTB]
(
    [RecordId] INT IDENTITY(1,1) PRIMARY KEY,
    [Account] NVARCHAR(255),
    [DetailId] INT, -- Foreign key reference to DetailIncomeExpenseTB
    [IsIncomeOrExpense] NVARCHAR(20) CHECK ([IsIncomeOrExpense] IN ('Income', 'Expense')), 
    [Value] DECIMAL(10,2),
    [Date] DATETIME NOT NULL,
    FOREIGN KEY (DetailId) REFERENCES DetailIncomeExpenseTB(DetailId) -- Ensures referential integrity
);
