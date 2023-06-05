using System.Diagnostics;
using WaetherForecasterBLL.Factory.Interfaces;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;

namespace WeatherForecasterPL.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var requestsLogServicesFactory = context.RequestServices.GetRequiredService<IRequestsLogServicesFactory>();
            
            var requestsLogServices = requestsLogServicesFactory.Create();

            var requestLogging = new RequestsLogModel
            {
                MethodType = context.Request.Method,
                EndpointName = context.GetEndpoint().DisplayName,
            };

            await requestsLogServices.AddRequests(requestLogging);

            await _next.Invoke(context);
        }
    }
}
