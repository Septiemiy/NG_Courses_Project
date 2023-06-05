using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;
using WeatherForecasterDAL.Entities;
using WeatherForecasterDAL.Repository.Interfaces;

namespace WaetherForecasterBLL.Services
{
    public class ErrorsLogServices : IErrorsLogServices
    {
        private readonly IErrorLogRepository _errorRepository;
        private readonly IMapper _mapper;

        public ErrorsLogServices(IErrorLogRepository errorRepository, IMapper mapper)
        {
            _errorRepository = errorRepository;
            _mapper = mapper;
        }

        public async Task AddError(ErrorLogModel error)
        {
            var mapped = _mapper.Map<ErrorLog>(error);
            await _errorRepository.AddAsync(mapped);
        }
    }
}
