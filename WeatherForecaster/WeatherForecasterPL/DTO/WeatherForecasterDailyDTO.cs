using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Models;

namespace WeatherForecasterPL.DTO
{
    public class WeatherForecasterDailyDTO
    {
        public List<WeatherForecasterDailyModel> WeatherForecasterDaily { get; set; }
    }
}
