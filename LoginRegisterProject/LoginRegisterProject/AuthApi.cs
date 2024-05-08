using System.Text.Json;
using System.Text;

namespace LoginRegisterProject
{
    public class AuthApi : IAuthApi
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<EmployeeDetail> LoginAsync(EmployeeInput loginRequestModel)
        {


            var httpClient = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonSerializer.Serialize(loginRequestModel), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:8084/Login", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var sessionModel = JsonSerializer.Deserialize<EmployeeDetail>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return sessionModel ?? new EmployeeDetail();
            }


            throw new Exception("Login failed");
        }
        public async Task<string> RegisterAsync(EmployeeRegistration registerRequestModel)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonSerializer.Serialize(registerRequestModel), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:8084/Register", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var sessionModel = JsonSerializer.Deserialize<string>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return sessionModel;
            }

            // Consider throwing an exception or handling the error appropriately
            throw new Exception("Registration failed");
        }

    }
}
