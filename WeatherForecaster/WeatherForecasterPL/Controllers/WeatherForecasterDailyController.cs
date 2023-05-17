using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Models;
using WaetherForecasterBLL.Services;
using WeatherForecaster.GetJSON;
using WeatherForecasterPL.Models;

namespace WeatherForecasterPL.Controllers
{
    public class WeatherForecasterDailyController : Controller
    {
        private readonly ILogger<WeatherForecasterDailyController> _logger;

        public WeatherForecasterDailyController(ILogger<WeatherForecasterDailyController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Daily()
        {
            var services = new WeatherForecasterDailyServices();

            var model = new WeatherForecasterDailyForPLModel();

            model.WeatherForecasterDaily = await services.GetWeatherDailyInfo();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}