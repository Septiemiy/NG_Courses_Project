using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaetherForecasterBLL.Models;

namespace WaetherForecasterBLL.Interfaces
{
    public interface IWeatherForecasterHourlyServices
    {
        Task<string> GetTime(JsonElement root, int index);
        Task<string> HoursWithoutDate(JsonElement root, int index);
        Task<double> GetTemperature(JsonElement root, int index);
        Task<double> GetApparentTemperature(JsonElement root, int index);
        Task<int> GetPrecipitationProbability(JsonElement root, int index);
        Task<double> GetPrecipitation(JsonElement root, int index);
        Task<double> GetWindSpeed(JsonElement root, int index);
        Task<int> GetWindDirection(JsonElement root, int index);
        Task<double> GetWindGusts(JsonElement root, int index);
        Task<List<WeatherForecasterHourlyModel>> GetWeatherHourlyInfo(int startIndex);
    }
}
