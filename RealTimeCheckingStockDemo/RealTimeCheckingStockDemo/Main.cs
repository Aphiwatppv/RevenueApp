using Newtonsoft.Json.Linq;

namespace RealTimeCheckingStockDemo
{
    public partial class Main : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Main()
        {
            InitializeComponent();
        }

        private async void buttonTakePrice_Click(object sender, EventArgs e)
        {
            string stockSymbol = "MU"; // Example stock symbol
            string apiKey = "AH5XZN3S3083YAK7"; // Your Alpha Vantage API key

            var result = await GetStockPriceAsync(stockSymbol, apiKey);

            label1.Text = result;
        }



        public static async Task<string> GetStockPriceAsync(string symbol, string apiKey)
        {
            // Define the API endpoint with your stock symbol and API key
            string apiUrl = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval=1min&apikey={apiKey}";

            // Send a GET request to the API
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                // Parse the JSON response
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                // Extract the latest stock price from the time series data
                var timeSeries = json["Time Series (1min)"];
                var latestEntry = timeSeries.First;
                string latestTimestamp = latestEntry.Path; // Gets the key representing the timestamp
                string closingPrice = latestEntry.First["4. close"].ToString();
                var result = $"Latest price for {symbol} at {latestTimestamp}: {closingPrice}";
                return result;
            }
            else
            {
                return "Failed to fetch stock price.";
               
            }
        }
    }
}
