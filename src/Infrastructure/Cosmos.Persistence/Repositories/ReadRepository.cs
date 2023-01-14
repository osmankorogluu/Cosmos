﻿using Cosmos.Application.Repositories;
using Cosmos.Domain.Common;
using Cosmos.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly CosmosDatabaseContext _context;

        public ReadRepository(CosmosDatabaseContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
         => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
         => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

       
    }
}
