using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.Entities;

namespace WeatherForecasterDAL.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class 
    {
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<ICollection<T>> GetAllAsync();
    }
}
