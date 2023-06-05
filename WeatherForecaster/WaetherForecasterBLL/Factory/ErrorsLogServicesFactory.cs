using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Factory.Interfaces;
using WaetherForecasterBLL.Interfaces;

namespace WaetherForecasterBLL.Factory
{
    public class ErrorsLogServicesFactory : IErrorsLogServicesFactory
    {
        private readonly IServiceProvider _provider;

        public ErrorsLogServicesFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IErrorsLogServices Create()
        {
            return _provider.GetRequiredService<IErrorsLogServices>();
        }
    }
}
