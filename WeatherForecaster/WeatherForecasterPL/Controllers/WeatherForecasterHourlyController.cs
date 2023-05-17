using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Models;
using WaetherForecasterBLL.Services;
using WeatherForecasterPL.Models;

namespace WeatherForecasterPL.Controllers
{
    public class WeatherForecasterHourlyController : Controller
    {
        private readonly ILogger<WeatherForecasterHourlyController> _logger;

        public WeatherForecasterHourlyController(ILogger<WeatherForecasterHourlyController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Hourly()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
