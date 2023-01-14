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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(CosmosDatabaseContext context) : base(context)
        {
        }
    }
}
