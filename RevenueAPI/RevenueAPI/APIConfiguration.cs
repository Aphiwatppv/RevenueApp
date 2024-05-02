using System.Runtime.CompilerServices;

namespace RevenueAPI
{
    public static class APIConfiguration
    {
        public static void ApiConfig(this WebApplication app)
        {
            app.MapGet(pattern: "/GetAllRecordAsync", GetAllRecordAsync);
            app.MapGet(pattern: "/GetDailyExpenseSummariesAsync/{limit}", GetDailyExpenseSummariesAsync);

        }


        public static async Task<IResult> GetAllRecordAsync(IServices services)
        {
            try
            {
                return Results.Ok(await services.ExpenseIncomeRecordAsync());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        public static async Task<IResult> GetDailyExpenseSummariesAsync(IServices services , decimal limit)
        {
            try
            {
                return Results.Ok(await services.DailyExpenseSummariesAsync(limit));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
