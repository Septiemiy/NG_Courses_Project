using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.Interfaces
{
    public interface IWeatherForecasterHourlyServices
    {
        Task<string> GetTime(JsonElement root);
        Task<double> GetTemperature(JsonElement root);
        Task<double> GetApparentTemperature(JsonElement root);
        Task<int> GetPrecipitationProbability(JsonElement root);
        Task<double> GetPrecipitation(JsonElement root);
        Task<double> GetWindSpeed(JsonElement root);
        Task<int> GetWindDirection(JsonElement root);
        Task<double> GetWindGusts(JsonElement root);
    }
}
