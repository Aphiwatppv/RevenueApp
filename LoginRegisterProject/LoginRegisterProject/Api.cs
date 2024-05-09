using LoginRegisterProject.Model;
using System.Text.Json;

namespace LoginRegisterProject
{
    public class Api : IApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<Api> _logger;
        private readonly string? _baseUrl;

        public Api(IHttpClientFactory httpClientFactory, ILogger<Api> logger, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _baseUrl = configuration.GetValue<string>("ApiBaseUrl");
        }

        public async Task<IEnumerable<ExpenseIncomeRecord>> GetRecordsAsync()
        {
            var url = $"{_baseUrl}/GetAllRecordAsync";
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<IEnumerable<ExpenseIncomeRecord>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<ExpenseIncomeRecord>();
                }
                else
                {
                    _logger.LogWarning($"Failed to fetch records: {response.StatusCode} from {url}");
                    return new List<ExpenseIncomeRecord>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching records from {url}: {ex.Message}");
                return new List<ExpenseIncomeRecord>();
            }
        }

        public async Task<IEnumerable<DailyExpenseSummary>> GetSummaryAsync(int limit)
        {
            var url = $"{_baseUrl}/GetDailyExpenseSummariesAsync/{limit}";
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<IEnumerable<DailyExpenseSummary>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<DailyExpenseSummary>();
                }
                else
                {
                    _logger.LogWarning($"Failed to fetch summaries: {response.StatusCode} from {url}");
                    return new List<DailyExpenseSummary>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching summaries from {url}: {ex.Message}");
                return new List<DailyExpenseSummary>();
            }
        }
    }
}
