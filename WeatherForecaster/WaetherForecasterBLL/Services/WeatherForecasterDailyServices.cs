using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;
using WeatherForecaster.GetJSON;
using WaetherForecasterBLL.JSONEnums;

namespace WaetherForecasterBLL.Services
{
    public class WeatherForecasterDailyServices : IWeatherForecasterDailyServices
    {
        public async Task<string> GetTime(JsonElement root, int index)
        {
            var time = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Time))[index].GetString();

            return time;
        }

        public async Task<double> GetTemperatureMAX(JsonElement root, int index)
        {
            var temperatureMAX = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.TemperatureMax))[index].GetDouble();

            return temperatureMAX;
        }

        public async Task<double> GetTemperatureMIN(JsonElement root, int index)
        {
            var temperatureMIN = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.TemperatureMin))[index].GetDouble();

            return temperatureMIN;
        }

        public async Task<double> GetApparentTemperatureMAX(JsonElement root, int index)
        {
            var apparentTemperatureMAX = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.ApparentTemperatureMax))[index].GetDouble();

            return apparentTemperatureMAX;
        }

        public async Task<double> GetApparentTemperatureMIN(JsonElement root, int index)
        {
            var apparentTemperatureMIN = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.ApparentTemperatureMin))[index].GetDouble();

            return apparentTemperatureMIN;
        }

        public async Task<double> GetPrecipitationSUM(JsonElement root, int index)
        {
            var precipitationSUM = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.PrecipitationSum))[index].GetDouble();

            return precipitationSUM;
        }

        public async Task<double> GetPrecipitationHours(JsonElement root, int index)
        {
            var precipitationHours = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.PrecipitationHours))[index].GetDouble();

            return precipitationHours;
        }

        public async Task<int> GetPrecipitationProbabilityMAX(JsonElement root, int index)
        {
            var precipitationProbabilityMAX = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.PrecipitationProbabilityMax))[index].GetInt32();

            return precipitationProbabilityMAX;
        }

        public async Task<double> GetWindSpeedMAX(JsonElement root, int index)
        {
            var windSpeedMAX = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.WindSpeedMax))[index].GetDouble();

            return windSpeedMAX;
        }

        public async Task<double> GetWindGustsMAX(JsonElement root, int index)
        {
            var windGustsMAX = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.WindGustsMax))[index].GetDouble();

            return windGustsMAX;
        }

        public async Task<int> GetWindDirectionDominant(JsonElement root, int index)
        {
            var windDirectionDominant = root.GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.Daily)).GetProperty(JSONEnumDaily.GetDailyConst(JSONEnumDaily.JSONDailyKeyConst.WindDirectionDominant))[index].GetInt32();

            return windDirectionDominant;
        }

        public async Task<List<WeatherForecasterDailyModel>> GetWeatherDailyInfo()
        {
            var root = await GetJSON.GetJSONRoot();

            var objectsList = new List<WeatherForecasterDailyModel>();

            for (int index = 0; index < 7; index++)
            {
                objectsList.Add(new WeatherForecasterDailyModel(
                    await GetTime(root, index),
                    await GetTemperatureMAX(root, index),
                    await GetTemperatureMIN(root, index),
                    await GetApparentTemperatureMAX(root, index),
                    await GetApparentTemperatureMIN(root, index),
                    await GetPrecipitationSUM(root, index),
                    await GetPrecipitationHours(root, index),
                    await GetPrecipitationProbabilityMAX(root, index),
                    await GetWindSpeedMAX(root, index),
                    await GetWindGustsMAX(root, index),
                    await GetWindDirectionDominant(root, index)));
            }

            return objectsList;
        }
    }
}