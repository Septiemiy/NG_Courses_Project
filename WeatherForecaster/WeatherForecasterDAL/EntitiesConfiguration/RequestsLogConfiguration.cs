using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.Entities;

namespace WeatherForecasterDAL.EntitiesConfiguration
{
    public class RequestsLogConfiguration : IEntityTypeConfiguration<RequestsLog>
    {
        public void Configure(EntityTypeBuilder<RequestsLog> builder) 
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.MethodType).IsRequired();

            builder.Property(x => x.EndpointName).IsRequired();
        }
    }
}
