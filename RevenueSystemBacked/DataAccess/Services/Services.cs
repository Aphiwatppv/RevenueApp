using DataAccess.Models;
using DataAccess.SqlAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    /// <summary>
    /// Services class to handle business operations related to financial records.
    /// </summary>
    public class Services : IServices
    {
        // Field to hold the SQL access layer interface
        private readonly ISqlAccess _sqlAccess;

        /// <summary>
        /// Constructor that injects the SQL access service used by this class.
        /// </summary>
        /// <param name="sqlAccess">The SQL access layer dependency.</param>
        public Services(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }

        /// <summary>
        /// Asynchronously retrieves all expense and income records with details.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing an enumerable list of ExpenseIncomeRecord.</returns>
        public async Task<IEnumerable<ExpenseIncomeRecord>> ExpenseIncomeRecordAsync()
        {
            // Executes a stored procedure to get all expense and income records with additional details
            var result = await _sqlAccess.GetDataAsync<ExpenseIncomeRecord,
                dynamic>(storedProcedure: "dbo.spGetAllExpenseIncomeRecordsWithDetails", new { });
            return result;
        }

        /// <summary>
        /// Asynchronously retrieves a summary of daily expenses.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing an enumerable list of DailyExpenseSummary.</returns>
        public async Task<IEnumerable<DailyExpenseSummary>> DailyExpenseSummariesAsync( decimal limit)
        {
            // Executes a stored procedure to get daily expense summaries
            var result = await _sqlAccess.GetDataAsync<DailyExpenseSummary,
                dynamic>(storedProcedure: "dbo.spGetDailyExpenseSummary", new { 
                
                limit = limit});
            return result;
        }
    }

}
