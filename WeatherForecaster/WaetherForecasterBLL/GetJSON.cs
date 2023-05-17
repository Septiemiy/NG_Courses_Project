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
                    RequestUri = new Uri("https://api.open-meteo.com/v1/forecast?latitude=48.5&longitude=32.25&hourly=temperature_2m,apparent_temperature,precipitation_probability,precipitation,windspeed_10m,winddirection_10m,windgusts_10m&daily=temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_sum,precipitation_hours,precipitation_probability_max,windspeed_10m_max,windgusts_10m_max,winddirection_10m_dominant&timezone=auto"),
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