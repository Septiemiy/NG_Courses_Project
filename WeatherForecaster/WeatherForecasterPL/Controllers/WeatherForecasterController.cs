using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WaetherForecasterBLL.Models;
using WaetherForecasterBLL.Services;
using WeatherForecaster.GetJSON;
using WeatherForecasterPL.Models;

namespace WeatherForecasterPL.Controllers
{
    public class WeatherForecasterController : Controller
    {
        private readonly ILogger<WeatherForecasterController> _logger;

        public WeatherForecasterController(ILogger<WeatherForecasterController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Hourly(WeatherForecasterModel model, WeatherForecasterServices services)
        {
            var root = await GetJSON.GetJSONRoot();

            model.Time = await services.GetTime(root);
            model.Temperature = await services.GetTemperature(root);
            model.ApparrentTemperature = await services.GetApparentTemperature(root);
            model.PrecipitationProbability = await services.GetPrecipitationProbability(root);
            model.Precipitation = await services.GetPrecipitation(root);
            model.WindSpeed = await services.GetWindSpeed(root);
            model.WindDirection = await services.GetWindDirection(root);
            model.WindGusts = await services.GetWindGusts(root);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}