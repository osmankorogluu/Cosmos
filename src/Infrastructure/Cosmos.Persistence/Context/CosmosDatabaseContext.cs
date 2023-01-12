using Cosmos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence.Context
{
    public class CosmosDatabaseContext: DbContext
    {
        public CosmosDatabaseContext()
        {

        }
        public CosmosDatabaseContext(DbContextOptions<CosmosDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
