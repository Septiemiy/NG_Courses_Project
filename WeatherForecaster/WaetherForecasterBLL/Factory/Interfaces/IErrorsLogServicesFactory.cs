using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Services;

namespace WaetherForecasterBLL.Factory.Interfaces
{
    public interface IErrorsLogServicesFactory
    {
        IErrorsLogServices Create();
    }
}
