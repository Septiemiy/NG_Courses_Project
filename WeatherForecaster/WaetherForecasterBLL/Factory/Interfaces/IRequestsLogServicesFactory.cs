using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;

namespace WaetherForecasterBLL.Factory.Interfaces
{
    public interface IRequestsLogServicesFactory
    {
        IRequestsLogServices Create();
    }
}
