using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Persistence.Context;

namespace Cosmos.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
           // services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<CosmosDatabaseContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
