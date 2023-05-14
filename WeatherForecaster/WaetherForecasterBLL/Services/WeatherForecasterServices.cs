using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;
using WeatherForecaster.GetJSON;

namespace WaetherForecasterBLL.Services
{
    public class WeatherForecasterServices : IWeatherForecasterServices
    {
        private readonly string[] JSONKeyConst =
        {
            "hourly",
            "time",
            "temperature_2m",
            "apparent_temperature",
            "precipitation_probability",
            "precipitation",
            "windspeed_10m",
            "winddirection_10m",
            "windgusts_10m"
        };

        private WeatherForecasterModel GetWeatherForecasterModel()
        {
            var model = new WeatherForecasterModel();
            return model;
        }

        private int GetJSONTimeArrayLength(JsonElement root)
        {
            return root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[1]).GetArrayLength();
        }

        public async Task<List<string>> GetTime(JsonElement root)
        {
            var time = new List<string>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                time.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[1])[i].GetString());
            }

            return time;
        }

        public async Task<List<double>> GetTemperature(JsonElement root)
        {
            var temperature = new List<double>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                temperature.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[2])[i].GetDouble());
            }

            return temperature;
        }

        public async Task<List<double>> GetApparentTemperature(JsonElement root)
        {
            var apparentTemperature = new List<double>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                apparentTemperature.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[3])[i].GetDouble());
            }

            return apparentTemperature;
        }

        public async Task<List<int>> GetPrecipitationProbability(JsonElement root)
        {
            var precipitationProbability = new List<int>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                precipitationProbability.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[4])[i].GetInt32());
            }

            return precipitationProbability;
        }

        public async Task<List<double>> GetPrecipitation(JsonElement root)
        {
            var precipitation = new List<double>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                precipitation.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[5])[i].GetDouble());
            }

            return precipitation;
        }

        public async Task<List<double>> GetWindSpeed(JsonElement root)
        {
            var windSpeed = new List<double>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                windSpeed.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[6])[i].GetDouble());
            }

            return windSpeed;
        }

        public async Task<List<int>> GetWindDirection(JsonElement root)
        {
            var windDirection = new List<int>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                windDirection.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[7])[i].GetInt32());
            }

            return windDirection;
        }

        public async Task<List<double>> GetWindGusts(JsonElement root)
        {
            var windGusts = new List<double>();

            for (var i = 0; i < GetJSONTimeArrayLength(root); i++)
            {
                windGusts.Add(root.GetProperty(JSONKeyConst[0]).GetProperty(JSONKeyConst[8])[i].GetDouble());
            }

            return windGusts;
        }
    }
}