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

namespace WaetherForecasterBLL.Services
{
    public class WeatherForecasterDailyServices : IWeatherForecasterDailyServices
    {
        private enum JSONDailyKeyConst
        {
            Daily,
            Time,
            TemperatureMax,
            TemperatureMin,
            ApparentTemperatureMax,
            ApparentTemperatureMin,
            PrecipitationSum,
            PrecipitationHours,
            PrecipitationProbabilityMax,
            WindSpeedMax,
            WindGustsMax,
            WindDirectionDominant
        };

        private string GetDailyConst(JSONDailyKeyConst key)
        {
            switch (key)
            {
                case JSONDailyKeyConst.Daily:
                    return "daily";
                case JSONDailyKeyConst.Time:
                    return "time";
                case JSONDailyKeyConst.TemperatureMax:
                    return "temperature_2m_max";
                case JSONDailyKeyConst.TemperatureMin:
                    return "temperature_2m_min";
                case JSONDailyKeyConst.ApparentTemperatureMax:
                    return "apparent_temperature_max";
                case JSONDailyKeyConst.ApparentTemperatureMin:
                    return "apparent_temperature_min";
                case JSONDailyKeyConst.PrecipitationSum:
                    return "precipitation_sum";
                case JSONDailyKeyConst.PrecipitationHours:
                    return "precipitation_hours";
                case JSONDailyKeyConst.PrecipitationProbabilityMax:
                    return "precipitation_probability_max";
                case JSONDailyKeyConst.WindSpeedMax:
                    return "windspeed_10m_max";
                case JSONDailyKeyConst.WindGustsMax:
                    return "windgusts_10m_max";
                case JSONDailyKeyConst.WindDirectionDominant:
                    return "winddirection_10m_dominant";
            }
            return null;
        }

        public async Task<string> GetTime(JsonElement root, int index)
        {
            var time = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.Time))[index].GetString();

            return time;
        }

        public async Task<double> GetTemperatureMAX(JsonElement root, int index)
        {
            var temperatureMAX = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.TemperatureMax))[index].GetDouble();

            return temperatureMAX;
        }

        public async Task<double> GetTemperatureMIN(JsonElement root, int index)
        {
            var temperatureMIN = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.TemperatureMin))[index].GetDouble();

            return temperatureMIN;
        }

        public async Task<double> GetApparentTemperatureMAX(JsonElement root, int index)
        {
            var apparentTemperatureMAX = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.ApparentTemperatureMax))[index].GetDouble();

            return apparentTemperatureMAX;
        }

        public async Task<double> GetApparentTemperatureMIN(JsonElement root, int index)
        {
            var apparentTemperatureMIN = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.ApparentTemperatureMin))[index].GetDouble();

            return apparentTemperatureMIN;
        }

        public async Task<double> GetPrecipitationSUM(JsonElement root, int index)
        {
            var precipitationSUM = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.PrecipitationSum))[index].GetDouble();

            return precipitationSUM;
        }

        public async Task<double> GetPrecipitationHours(JsonElement root, int index)
        {
            var precipitationHours = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.PrecipitationHours))[index].GetDouble();

            return precipitationHours;
        }

        public async Task<int> GetPrecipitationProbabilityMAX(JsonElement root, int index)
        {
            var precipitationProbabilityMAX = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.PrecipitationProbabilityMax))[index].GetInt32();

            return precipitationProbabilityMAX;
        }

        public async Task<double> GetWindSpeedMAX(JsonElement root, int index)
        {
            var windSpeedMAX = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.WindSpeedMax))[index].GetDouble();

            return windSpeedMAX;
        }

        public async Task<double> GetWindGustsMAX(JsonElement root, int index)
        {
            var windGustsMAX = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.WindGustsMax))[index].GetDouble();

            return windGustsMAX;
        }

        public async Task<int> GetWindDirectionDominant(JsonElement root, int index)
        {
            var windDirectionDominant = root.GetProperty(GetDailyConst(JSONDailyKeyConst.Daily)).GetProperty(GetDailyConst(JSONDailyKeyConst.WindDirectionDominant))[index].GetInt32();

            return windDirectionDominant;
        }

        public async Task<List<WeatherForecasterDailyModel>> GetWeatherDailyInfo()
        {
            var root = await GetJSON.GetJSONRoot();

            var objectsList = new List<WeatherForecasterDailyModel>()
            {
                new WeatherForecasterDailyModel(await GetTime(root, 0), await GetTemperatureMAX(root, 0), await GetTemperatureMIN(root, 0), await GetApparentTemperatureMAX(root, 0), await GetApparentTemperatureMIN(root, 0), await GetPrecipitationSUM(root, 0), await GetTemperatureMAX(root, 0), await GetPrecipitationProbabilityMAX(root, 0), await GetWindSpeedMAX(root, 0), await GetWindGustsMAX(root, 0), await GetWindDirectionDominant(root, 0)),
                new WeatherForecasterDailyModel(await GetTime(root, 1), await GetTemperatureMAX(root, 1), await GetTemperatureMIN(root, 1), await GetApparentTemperatureMAX(root, 1), await GetApparentTemperatureMIN(root, 1), await GetPrecipitationSUM(root, 1), await GetTemperatureMAX(root, 1), await GetPrecipitationProbabilityMAX(root, 1), await GetWindSpeedMAX(root, 1), await GetWindGustsMAX(root, 1), await GetWindDirectionDominant(root, 1)),
                new WeatherForecasterDailyModel(await GetTime(root, 2), await GetTemperatureMAX(root, 2), await GetTemperatureMIN(root, 2), await GetApparentTemperatureMAX(root, 2), await GetApparentTemperatureMIN(root, 2), await GetPrecipitationSUM(root, 2), await GetTemperatureMAX(root, 2), await GetPrecipitationProbabilityMAX(root, 2), await GetWindSpeedMAX(root, 2), await GetWindGustsMAX(root, 2), await GetWindDirectionDominant(root, 2)),
                new WeatherForecasterDailyModel(await GetTime(root, 3), await GetTemperatureMAX(root, 3), await GetTemperatureMIN(root, 3), await GetApparentTemperatureMAX(root, 3), await GetApparentTemperatureMIN(root, 3), await GetPrecipitationSUM(root, 3), await GetTemperatureMAX(root, 3), await GetPrecipitationProbabilityMAX(root, 3), await GetWindSpeedMAX(root, 3), await GetWindGustsMAX(root, 3), await GetWindDirectionDominant(root, 3)),
                new WeatherForecasterDailyModel(await GetTime(root, 4), await GetTemperatureMAX(root, 4), await GetTemperatureMIN(root, 4), await GetApparentTemperatureMAX(root, 4), await GetApparentTemperatureMIN(root, 4), await GetPrecipitationSUM(root, 4), await GetTemperatureMAX(root, 4), await GetPrecipitationProbabilityMAX(root, 4), await GetWindSpeedMAX(root, 4), await GetWindGustsMAX(root, 4), await GetWindDirectionDominant(root, 4)),
                new WeatherForecasterDailyModel(await GetTime(root, 5), await GetTemperatureMAX(root, 5), await GetTemperatureMIN(root, 5), await GetApparentTemperatureMAX(root, 5), await GetApparentTemperatureMIN(root, 5), await GetPrecipitationSUM(root, 5), await GetTemperatureMAX(root, 5), await GetPrecipitationProbabilityMAX(root, 5), await GetWindSpeedMAX(root, 5), await GetWindGustsMAX(root, 5), await GetWindDirectionDominant(root, 5)),
                new WeatherForecasterDailyModel(await GetTime(root, 6), await GetTemperatureMAX(root, 6), await GetTemperatureMIN(root, 6), await GetApparentTemperatureMAX(root, 6), await GetApparentTemperatureMIN(root, 6), await GetPrecipitationSUM(root, 6), await GetTemperatureMAX(root, 6), await GetPrecipitationProbabilityMAX(root, 6), await GetWindSpeedMAX(root, 6), await GetWindGustsMAX(root, 6), await GetWindDirectionDominant(root, 6)),
            };

            return objectsList;
        }
    }
}