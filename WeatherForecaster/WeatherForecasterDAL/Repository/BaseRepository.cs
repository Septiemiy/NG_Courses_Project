using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.DbStartUp;
using WeatherForecasterDAL.Entities;
using WeatherForecasterDAL.Repository.Interfaces;

namespace WeatherForecasterDAL.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DBContext _context;

        public BaseRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result = _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().Select(x => x).ToListAsync();
            return result;
        }
    }
}
