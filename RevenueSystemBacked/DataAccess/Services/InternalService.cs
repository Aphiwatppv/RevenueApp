using DataAccess.Models;
using DataAccess.SqlAccess;
using System.Security.Principal;

namespace DataAccess.Services
{
    public class InternalService : IInternalService
    {
        private readonly ISqlAccessInternal _sqlAccessInternal;

        public InternalService(ISqlAccessInternal sqlAccessInternal)
        {
            _sqlAccessInternal = sqlAccessInternal;
        }


        #region RecordExpenseIncomeServices

        public async Task<IEnumerable<ExpenseIncomeRecord>> GetRecordsAsync()
        {
            var result = await _sqlAccessInternal.LoadDataAsync<ExpenseIncomeRecord, dynamic>(storedProcedure: "dbo.spGetAllExpenseIncomeRecordsWithDetails", new { });
            return result;
        }

        public async Task SaveRecordAsync(ExpenseIncomeRecordAdd expenseIncomeRecordAdd)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spAddExpenseIncomeRecord", new
            {
                Account = expenseIncomeRecordAdd.Account,
                DetailId = expenseIncomeRecordAdd.DetailId,
                IsIncomeOrExpense = expenseIncomeRecordAdd.IsIncomeOrExpense,
                Value = expenseIncomeRecordAdd.Value,
                Date = expenseIncomeRecordAdd.Date


            });
        }

        public async Task DeleteRecordAsync(int _RecordId)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spDeleteExpenseIncomeRecord", new
            {
                RecordId = _RecordId

            });
        }

        public async Task UpdateRecordAsync(int _RecordId, ExpenseIncomeRecordAdd expenseIncomeRecordAdd)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spUpdateExpenseIncomeRecord", new
            {
                RecordId = _RecordId,
                Account = expenseIncomeRecordAdd.Account,
                DetailId = expenseIncomeRecordAdd.DetailId,
                IsIncomeOrExpense = expenseIncomeRecordAdd.IsIncomeOrExpense,
                Value = expenseIncomeRecordAdd.Value,
                Date = expenseIncomeRecordAdd.Date


            });
        }

        public async Task<CurrentDayExpense?> CurrentDayExpenseAsync()
        {
            var result = await _sqlAccessInternal.LoadDataAsync<CurrentDayExpense, dynamic>(storedProcedure: "dbo.spCurrentDayExpense", new { });
            return result.FirstOrDefault();
        }

        public async Task<CurrentMonthExpense?> CurrentMonthExpenseAsync()
        {
            var result = await _sqlAccessInternal.LoadDataAsync<CurrentMonthExpense, dynamic>(storedProcedure: "dbo.spCurrentMonthExpense", new { });
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<DailyExpenseSummary>> DailyExpenseSummariesAsync(decimal limit)
        {
            var result = await _sqlAccessInternal.LoadDataAsync<DailyExpenseSummary, dynamic>(storedProcedure: "dbo.spGetDailyExpenseSummary", new
            {
                limit = limit
            });

            return result;
        }
        #endregion

        #region DetailTypesServices

        public async Task<IEnumerable<DetailTypes>> GetAllDetailTypesAsync()
        {
            var result = await _sqlAccessInternal.LoadDataAsync<DetailTypes, dynamic>(storedProcedure: "dbo.spGetAllDetails", new { });
            return result;
        }


        public async Task SaveDetailTypesAsync(DetailTypes DetailTypes)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spAddDetailIncomeExpense", new
            {


                Detail = DetailTypes.Detail,
                Type = DetailTypes.Type

            });
        }

        public async Task DeleteDetailTypesAsync(DetailTypes DetailTypes)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spDeleteDetailIncomeExpense", new
            {

                DetailId = DetailTypes.DetailId


            });
        }

        public async Task UpdateDetailTypesAsync(DetailTypes DetailTypes)
        {
            await _sqlAccessInternal.UpdateAsync(storedProcedure: "dbo.spUpdateDetailIncomeExpense", new
            {

                DetailId = DetailTypes.DetailId,
                Detail = DetailTypes.Detail,
                Type = DetailTypes.Type

            });
        }
        #endregion
    }
}


