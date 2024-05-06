using RevenueWebApp.Model;
using System.Text.Json;
using System.Text;
using System.Collections.Generic;

namespace RevenueWebApp.API
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

        public async Task<StatusCodeRegistering> RegisterUserAsync(RegisteringUserInput userInput, string password)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var url = $"{_baseUrl}/Register";

            var requestContent = new
            {
                registeringUserInput = userInput,
                password = password
            };

            string jsonContent = JsonSerializer.Serialize(requestContent);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    // Assuming the API might return a JSON object that includes a status code or similar indicator
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<ApiResponse>(responseContent);

                    if (result != null && result.StatusCode == 1) // Check if the status code returned is 1 for success
                    {
                        return StatusCodeRegistering.Success;
                    }
                    else
                    {
                        _logger.LogWarning($"Registration failed with status: {result?.StatusCode}");
                        return StatusCodeRegistering.Failure;
                    }
                }
                else
                {
                    _logger.LogWarning($"Failed to register user: {response.StatusCode}");
                    return StatusCodeRegistering.Failure;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred during registration: {ex.Message}");
                return StatusCodeRegistering.Failure;
            }
        }

        // Helper class to interpret response from the API
        public class ApiResponse
        {
            public int StatusCode { get; set; }
        }


    }
}
