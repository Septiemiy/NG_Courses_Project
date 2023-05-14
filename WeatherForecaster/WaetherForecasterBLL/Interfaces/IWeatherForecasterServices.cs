using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.Interfaces
{
    public interface IWeatherForecasterServices
    {
        Task<List<string>> GetTime(JsonElement root);
        Task<List<double>> GetTemperature(JsonElement root);
        Task<List<double>> GetApparentTemperature(JsonElement root);
        Task<List<int>> GetPrecipitationProbability(JsonElement root);
        Task<List<double>> GetPrecipitation(JsonElement root);
        Task<List<double>> GetWindSpeed(JsonElement root);
        Task<List<int>> GetWindDirection(JsonElement root);
        Task<List<double>> GetWindGusts(JsonElement root);
    }
}
