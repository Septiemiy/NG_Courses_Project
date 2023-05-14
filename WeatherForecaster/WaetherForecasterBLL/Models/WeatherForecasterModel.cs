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
    public class WeatherForecasterModel
    {
        public List<string> Time { get; set; }
        public List<double> Temperature { get; set; }
        public List<double> ApparrentTemperature { get; set; }
        public List<int> PrecipitationProbability { get; set; }
        public List<double> Precipitation { get; set; }
        public List<double> WindSpeed { get; set; }
        public List<int> WindDirection { get; set; }
        public List<double> WindGusts { get; set; }

        public WeatherForecasterModel()
        {
            Time = new List<string>();
            Temperature = new List<double>();
            ApparrentTemperature = new List<double>();
            PrecipitationProbability = new List<int>();
            Precipitation = new List<double>();
            WindSpeed = new List<double>();
            WindDirection = new List<int>();
            WindGusts = new List<double>();
        }
    }
}
