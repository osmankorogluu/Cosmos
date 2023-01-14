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
    public class BookWriteRepository : WriteRepository<Book>, IBookWriteRepository
    {
        public BookWriteRepository(CosmosDatabaseContext context) : base(context)
        {
        }
    }
}
