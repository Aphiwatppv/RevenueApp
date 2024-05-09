using LoginRegisterProject.Model;

namespace LoginRegisterProject
{
    public interface IApi
    {
        Task<IEnumerable<ExpenseIncomeRecord>> GetRecordsAsync();
        Task<IEnumerable<DailyExpenseSummary>> GetSummaryAsync(int limit);
    }
}