using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Models;
using WaetherForecasterBLL.Services;
using WeatherForecasterPL.DTO;
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

        [HttpPost]
        [Route("Hourly")]
        public async Task<IActionResult> Hourly(WeatherForecasterHourlyDTO model)
        {
            string index = this.Request.Form["button"];

            var services = new WeatherForecasterHourlyServices();

            model.WeatherForecasterHourly = await services.GetWeatherHourlyInfo(int.Parse(index));

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}