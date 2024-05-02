using DataAccess.Models;

namespace DataAccess.Services
{
    /// <summary>
    /// Interface defining the services for managing financial records.
    /// </summary>
    public interface IServices
    {
        /// <summary>
        /// Asynchronously retrieves a summary of daily expenses.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing an enumerable list of DailyExpenseSummary.</returns>
        Task<IEnumerable<DailyExpenseSummary>> DailyExpenseSummariesAsync(decimal limit);

        /// <summary>
        /// Asynchronously retrieves all expense and income records with details.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing an enumerable list of ExpenseIncomeRecord.</returns>
        Task<IEnumerable<ExpenseIncomeRecord>> ExpenseIncomeRecordAsync();
    }

}