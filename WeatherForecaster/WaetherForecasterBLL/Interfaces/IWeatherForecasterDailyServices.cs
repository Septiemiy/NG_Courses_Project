using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.Interfaces
{
    public interface IWeatherForecasterDailyServices
    {
        Task<string> GetTime(JsonElement root, int index);
        Task<double> GetTemperatureMAX(JsonElement root, int index);
        Task<double> GetTemperatureMIN(JsonElement root, int index);
        Task<double> GetApparentTemperatureMAX(JsonElement root, int index);
        Task<double> GetApparentTemperatureMIN(JsonElement root, int index);
        Task<double> GetPrecipitationSUM(JsonElement root, int index);
        Task<double> GetPrecipitationHours(JsonElement root, int index);
        Task<int> GetPrecipitationProbabilityMAX(JsonElement root, int index);
        Task<double> GetWindSpeedMAX(JsonElement root, int index);
        Task<double> GetWindGustsMAX(JsonElement root, int index);
        Task<int> GetWindDirectionDominant(JsonElement root, int index);
    }
}
