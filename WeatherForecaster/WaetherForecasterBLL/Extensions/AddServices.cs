using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Services;
using AutoMapper;

namespace WaetherForecasterBLL.Extensions
{
    public static class AddServices
    {
        public static void AddServiceInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppMappingProfile));

            services.AddScoped<IRequestsLogServices, RequestsLogServices>();
            services.AddScoped<IErrorsLogServices, ErrorsLogServices>();
            services.AddScoped<IWeatherForecasterDailyServices, WeatherForecasterDailyServices>();
            services.AddScoped<IWeatherForecasterHourlyServices, WeatherForecasterHourlyServices>();
        }
    }
}
