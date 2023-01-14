using Cosmos.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CosmosDatabaseContext>
    {
        public CosmosDatabaseContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<CosmosDatabaseContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
