using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.JSONEnums
{
    public static class JSONEnumHourly
    {
        public enum JSONHourlyKeyConst
        {
            Hourly,
            Time,
            Temperature,
            ApparentTemperature,
            PrecipitationProbability,
            Precipitation,
            WindSpeed,
            WindDirection,
            WindGusts
        }

        public static string GetHourlyConst(JSONHourlyKeyConst key)
        {
            switch (key)
            {
                case JSONHourlyKeyConst.Hourly:
                    return "hourly";
                case JSONHourlyKeyConst.Time:
                    return "time";
                case JSONHourlyKeyConst.Temperature:
                    return "temperature_2m";
                case JSONHourlyKeyConst.ApparentTemperature:
                    return "apparent_temperature";
                case JSONHourlyKeyConst.PrecipitationProbability:
                    return "precipitation_probability";
                case JSONHourlyKeyConst.Precipitation:
                    return "precipitation";
                case JSONHourlyKeyConst.WindSpeed:
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
