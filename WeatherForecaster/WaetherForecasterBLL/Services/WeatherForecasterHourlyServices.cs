using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.JSONEnums;
using WaetherForecasterBLL.Models;
using WeatherForecaster.GetJSON;

namespace WaetherForecasterBLL.Services
{
    public class WeatherForecasterHourlyServices : IWeatherForecasterHourlyServices
    {
        public async Task<string> GetTime(JsonElement root, int index)
        {
            var time = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Time))[index].GetString();
        
            return time;
        }

        public async Task<string> HoursWithoutDate(JsonElement root, int index)
        {
            var time = await GetTime(root, index);

            string hour = time.Split('T').Last();

            return hour;
        }
        
        public async Task<double> GetTemperature(JsonElement root, int index)
        {
            var temperature = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Temperature))[index].GetDouble();
        
            return temperature;
        }
        
        public async Task<double> GetApparentTemperature(JsonElement root, int index)
        {
            var ApparentTemperature = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.ApparentTemperature))[index].GetDouble();
        
            return ApparentTemperature;
        }

        public async Task<double> GetPrecipitation(JsonElement root, int index)
        {
            var precipitation = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Precipitation))[index].GetDouble();

            return precipitation;
        }

        public async Task<int> GetPrecipitationProbability(JsonElement root, int index)
        {
            var precipitationProbability = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.PrecipitationProbability))[index].GetInt32();
        
            return precipitationProbability;
        }
        
        public async Task<double> GetWindSpeed(JsonElement root, int index)
        {
            var windSpeed = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.WindSpeed))[index].GetDouble();
        
            return windSpeed;
        }

        public async Task<double> GetWindGusts(JsonElement root, int index)
        {
            var windGusts = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.WindGusts))[index].GetDouble();

            return windGusts;
        }

        public async Task<int> GetWindDirection(JsonElement root, int index)
        {
            var windDirection = root.GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.Hourly)).GetProperty(JSONEnumHourly.GetHourlyConst(JSONEnumHourly.JSONHourlyKeyConst.WindDirection))[index].GetInt32();
        
            return windDirection;
        }

        public async Task<List<WeatherForecasterHourlyModel>> GetWeatherHourlyInfo(int startIndex)
        {
            var root = await GetJSON.GetJSONRoot();

            var objectsList = new List<WeatherForecasterHourlyModel>();

            for (int index = startIndex; index < 24 + startIndex; index++)
            {
                objectsList.Add(new WeatherForecasterHourlyModel(
                    await HoursWithoutDate(root, index),
                    await GetTemperature(root, index),
                    await GetApparentTemperature(root, index),
                    await GetPrecipitationProbability(root, index),
                    await GetPrecipitation(root, index),
                    await GetWindSpeed(root, index),
                    await GetWindGusts(root, index),
                    await GetWindDirection(root, index)));
            }

            return objectsList;
        }
    }
}