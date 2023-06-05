using WaetherForecasterBLL.Factory.Interfaces;
using WaetherForecasterBLL.Models;

namespace WeatherForecasterPL.Middleware
{
    public class ErrorsLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorsLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex) 
            {
                var errorsLogServicesFactory = context.RequestServices.GetRequiredService<IErrorsLogServicesFactory>();

                var errorsLogServices = errorsLogServicesFactory.Create();

                var errorLogging = new ErrorLogModel
                {
                    ErrorText = ex.Message,
                    MethodType = context.Request.Method,
                    EndpointName = context.GetEndpoint().DisplayName,
                };

                await errorsLogServices.AddError(errorLogging);
            }
        }
    }
}
