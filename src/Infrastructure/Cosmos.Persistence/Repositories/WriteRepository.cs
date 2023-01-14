using Cosmos.Application.Repositories;
using Cosmos.Domain.Common;
using Cosmos.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly CosmosDatabaseContext _context;

        public WriteRepository(CosmosDatabaseContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public Task<bool> AddRangeAsync(List<T> model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(List<T> model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRange(List<T> datas)
        {
            throw new NotImplementedException();
        }
    }
}
