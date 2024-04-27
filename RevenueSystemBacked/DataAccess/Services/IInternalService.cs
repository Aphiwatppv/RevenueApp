using DataAccess.Models;

namespace DataAccess.Services
{
    public interface IInternalService
    {
        Task<CurrentDayExpense?> CurrentDayExpenseAsync();
        Task<CurrentMonthExpense?> CurrentMonthExpenseAsync();
        Task<IEnumerable<DailyExpenseSummary>> DailyExpenseSummariesAsync(decimal limit);
        Task DeleteDetailTypesAsync(DetailTypes DetailTypes);
        Task DeleteRecordAsync(int _RecordId);
        Task<IEnumerable<DetailTypes>> GetAllDetailTypesAsync();
        Task<IEnumerable<ExpenseIncomeRecord>> GetRecordsAsync();
        Task SaveDetailTypesAsync(DetailTypes DetailTypes);
        Task SaveRecordAsync(ExpenseIncomeRecordAdd expenseIncomeRecordAdd);
        Task UpdateDetailTypesAsync(DetailTypes DetailTypes);
        Task UpdateRecordAsync(int _RecordId, ExpenseIncomeRecordAdd expenseIncomeRecordAdd);
    }
}