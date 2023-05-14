using System.Text.Json;

namespace WeatherForecaster.GetJSON
    {
        public static class GetJSON
        {
            private static async Task<string> GetDataFromJSONAsync()
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://api.open-meteo.com/v1/forecast?latitude=48.5&longitude=32.25&hourly=temperature_2m,apparent_temperature,precipitation_probability,precipitation,rain,showers,snowfall,weathercode,windspeed_10m,windspeed_80m,windspeed_120m,windspeed_180m,winddirection_10m,winddirection_80m,winddirection_120m,winddirection_180m,windgusts_10m,temperature_80m,temperature_120m&daily=precipitation_sum&forecast_days=1&timezone=auto"),
                };

                using (var response = await client.SendAsync(request))
                {
                    var data = await response.Content.ReadAsStringAsync();

                    return data;
                }
            }

            public static async Task<JsonElement> GetJSONRoot()
            {
                JsonDocument jsonDocument = JsonDocument.Parse(await GetDataFromJSONAsync());

                JsonElement root = jsonDocument.RootElement;

                return root;
            }
        }
    }