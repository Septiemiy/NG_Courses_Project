using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;
using WaetherForecasterBLL.Services;
using WeatherForecasterPL.DTO;
using WeatherForecasterPL.Models;

namespace WeatherForecasterPL.Controllers
{
    public class WeatherForecasterHourlyController : Controller
    {
        private readonly IWeatherForecasterHourlyServices _services;

        public WeatherForecasterHourlyController(IWeatherForecasterHourlyServices services)
        {
            _services = services;
        }

        [Route("Hourly")]
        [HttpPost]
        public async Task<IActionResult> Hourly(WeatherForecasterHourlyDTO model)
        {
            string index = this.Request.Form["button"];

            model.WeatherForecasterHourly = await _services.GetWeatherHourlyInfo(int.Parse(index));

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}