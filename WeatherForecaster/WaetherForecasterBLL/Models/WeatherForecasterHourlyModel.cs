using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.Models
{
    public class WeatherForecasterHourlyModel
    {
        public string Time { get; set; }
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double Precipitation { get; set; }
        public int PrecipitationProbability { get; set; }
        public double WindSpeed { get; set; }
        public double WindGusts { get; set; }
        public int WindDirection { get; set; }

        public WeatherForecasterHourlyModel(string time, double temperature, double apparentTemperature, int precipitationProbability, double precipitation, double windSpeed, double windGusts, int windDirection)
        {
            Time = time;
            Temperature = temperature;
            ApparentTemperature = apparentTemperature;
            Precipitation = precipitation;
            PrecipitationProbability = precipitationProbability;
            WindSpeed = windSpeed;
            WindGusts = windGusts;
            WindDirection = windDirection;
        }
    }
}
