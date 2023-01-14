using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Persistence.Context;
using Cosmos.Application.Interfaces;
using Cosmos.Persistence.Concretes;
using Cosmos.Application.Repositories;
using Cosmos.Persistence.Repositories;

namespace Cosmos.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CosmosDatabaseContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<IBookReadRepository, BookReadRepository>();
            services.AddScoped<IBookWriteRepository, BookWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        }
    }
}
