namespace RevenueWebApp.Model
{
    public class DailyExpenseSummary
    {
        public DateTime ExpenseDate { get; set; }  // Property for the expense date
        public decimal TotalExpense { get; set; }  // Property for the total expense
        public string ExpenseStatus { get; set; }  // Property for "Within Limit" or "Out of Limit"
    }
}
