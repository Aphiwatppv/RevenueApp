using RevenueWebApp.Model;

namespace RevenueWebApp.API
{
    public interface IApi
    {
        Task<IEnumerable<ExpenseIncomeRecord>> GetRecordsAsync();
        Task<IEnumerable<DailyExpenseSummary>> GetSummaryAsync(int limit);
    }
}