using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Models;

namespace WaetherForecasterBLL.Interfaces
{
    public interface IRequestsLogServices
    {
        Task AddRequests(RequestsLogModel requests);
    }
}
