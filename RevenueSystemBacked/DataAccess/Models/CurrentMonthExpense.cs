namespace DataAccess.Models
{
    public class CurrentMonthExpense
    {
        public int ExpenseYear { get; set; } // Represents the year of the expense
        public int ExpenseMonth { get; set; } // Represents the month of the expense
        public decimal TotalExpense { get; set; } // Represents the total expense for the month
    }
}
