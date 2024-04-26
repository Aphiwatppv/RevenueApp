CREATE TABLE [dbo].[DetailIncomeExpenseTB]
(
    [DetailId] INT IDENTITY(1,1) PRIMARY KEY,
    [Detail] NVARCHAR(100) NOT NULL,
    [Type] NVARCHAR(100) NOT NULL
);
