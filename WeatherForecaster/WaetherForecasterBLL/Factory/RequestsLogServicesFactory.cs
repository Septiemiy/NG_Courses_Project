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
    public class RequestsLogServicesFactory : IRequestsLogServicesFactory
    {
        private readonly IServiceProvider _provider;

        public RequestsLogServicesFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IRequestsLogServices Create()
        {
            return _provider.GetRequiredService<IRequestsLogServices>();
        }
    }
}
