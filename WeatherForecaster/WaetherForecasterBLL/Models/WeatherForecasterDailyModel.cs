using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaetherForecasterBLL.Services;
using WeatherForecaster.GetJSON;

namespace WaetherForecasterBLL.Models
{
    public class WeatherForecasterDailyModel
    {
        public string Time { get; set; }
        public double TemperatureMax { get; set; }
        public double TemperatureMin { get; set; }
        public double ApparentTemperatureMax { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public double PrecipitationSum { get; set; }
        public double PrecipitationHours { get; set; }
        public int PrecipitationProbabilityMax { get; set; }
        public double WindSpeedMax { get; set; }
        public double WindGustsMax { get; set; }
        public int WindDirectionDominant { get; set; }

        public WeatherForecasterDailyModel(string time, double temperatureMax, double temperatureMin, double apparentTemperatureMax, double apparentTemperatureMin, double precipitationSum, double precipitationHours, int precipitationProbabilityMax, double windSpeedMax, double windGustsMax, int windDirectionDominant)
        {
            Time = time;
            TemperatureMax = temperatureMax;
            TemperatureMin = temperatureMin;
            ApparentTemperatureMax = apparentTemperatureMax;
            ApparentTemperatureMin = apparentTemperatureMin;
            PrecipitationSum = precipitationSum;
            PrecipitationHours = precipitationHours;
            PrecipitationProbabilityMax = precipitationProbabilityMax;
            WindSpeedMax = windSpeedMax;
            WindGustsMax = windGustsMax;
            WindDirectionDominant = windDirectionDominant;
        }
    }
}