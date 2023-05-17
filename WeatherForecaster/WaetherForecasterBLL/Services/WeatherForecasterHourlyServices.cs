using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.Services
{
    public class WeatherForecasterHourlyServices
    {
        private enum JSONHourlyKeyConst
        {
            Hourly,
            Time,
            Temperature,
            ApparentTemperature,
            PrecipitationProbability,
            Precipitation,
            Windspeed,
            WindDirection,
            WindGusts
        }

        private string GetDailyConst(JSONHourlyKeyConst key)
        {
            switch (key)
            {
                case JSONHourlyKeyConst.Hourly:
                    return "hourly";
                case JSONHourlyKeyConst.Time:
                    return "time";
                case JSONHourlyKeyConst.Temperature:
                    return "temperature_10m";
                case JSONHourlyKeyConst.ApparentTemperature:
                    return "apparant_temperature";
                case JSONHourlyKeyConst.PrecipitationProbability:
                    return "precipitation_probability";
                case JSONHourlyKeyConst.Precipitation:
                    return "precipitation";
                case JSONHourlyKeyConst.Windspeed:
                    return "windspeed_10m";
                case JSONHourlyKeyConst.WindDirection:
                    return "winddirection_10m";
                case JSONHourlyKeyConst.WindGusts:
                    return "windgusts_10m";
            }
            return null;
        }
    }
}
