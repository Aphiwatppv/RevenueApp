namespace RevenueWebApp.Model
{
    public class ExpenseIncomeRecord
    {
        public int RecordId { get; set; } // Primary key
        public string Account { get; set; } // Account name or identifier
        public string Detail { get; set; } // Detail from DetailIncomeExpenseTB
        public string Type { get; set; } // Type from DetailIncomeExpenseTB
        public int DetailId { get; set; } // Foreign key reference to DetailIncomeExpenseTB
        public string IsIncomeOrExpense { get; set; } // Income or expense
        public decimal Value { get; set; } // Expense or income amount
        public DateTime Date { get; set; } // Record creation date
    }
}
