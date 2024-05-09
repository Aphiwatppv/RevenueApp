using LoginRegisterProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginRegisterProject.Pages
{
    public class PersonalSumModel : PageModel
    {
        private readonly IApi _api;
        public IEnumerable<ExpenseIncomeRecord> Records { get; private set; }

        public IEnumerable<DailyExpenseSummary> dailyExpenseSummaries { get; private set; }
        public PersonalSumModel(IApi api)
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
