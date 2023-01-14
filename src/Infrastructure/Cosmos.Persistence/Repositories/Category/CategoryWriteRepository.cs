using Cosmos.Application.Repositories;
using Cosmos.Domain.Entities;
using Cosmos.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence.Repositories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(CosmosDatabaseContext context) : base(context)
        {
        }
    }
}
