using DataAccess.Models;

namespace DataAccess.Services
{
    public interface IInternalService
    {
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