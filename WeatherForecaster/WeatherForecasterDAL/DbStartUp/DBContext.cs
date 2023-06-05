using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.Entities;
using WeatherForecasterDAL.EntitiesConfiguration;

namespace WeatherForecasterDAL.DbStartUp
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        
        public DbSet<RequestsLog> RequestsLog { get; set; }
        public DbSet<ErrorLog> ErrorsLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestsLogConfiguration());
            modelBuilder.ApplyConfiguration(new ErrorLogConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
