using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaetherForecasterBLL.JSONEnums
{
    public static class JSONEnumDaily
    {
        public enum JSONDailyKeyConst
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

        public static string GetDailyConst(JSONDailyKeyConst key)
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
    }
}
