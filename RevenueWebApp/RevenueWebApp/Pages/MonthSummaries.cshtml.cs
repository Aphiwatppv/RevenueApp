using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RevenueWebApp.API;
using RevenueWebApp.Model;

namespace RevenueWebApp.Pages
{
    public class RevenueSummariesModel : PageModel
    {

        private readonly IApi _api;
        public IEnumerable<ExpenseIncomeRecord> Records { get; private set; }

        public IEnumerable<DailyExpenseSummary> dailyExpenseSummaries { get; private set; }
        public RevenueSummariesModel(IApi api)
        {
            _api = api;
        }

        public async Task OnGetAsync()
        {
            Records = await _api.GetRecordsAsync();
            dailyExpenseSummaries = await _api.GetSummaryAsync(300);
        }
    }
}
