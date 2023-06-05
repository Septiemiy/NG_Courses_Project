using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Services;
using WeatherForecaster.GetJSON;
using WeatherForecasterPL.DTO;
using WeatherForecasterPL.Models;

namespace WeatherForecasterPL.Controllers
{
    public class WeatherForecasterDailyController : Controller
    {
        private readonly IWeatherForecasterDailyServices _services;

        public WeatherForecasterDailyController(IWeatherForecasterDailyServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> Daily(WeatherForecasterDailyDTO model)
        {
            model.WeatherForecasterDaily = await _services.GetWeatherDailyInfo();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}