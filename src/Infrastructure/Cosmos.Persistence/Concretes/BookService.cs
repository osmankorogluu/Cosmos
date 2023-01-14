using Cosmos.Application.Interfaces;
using Cosmos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Persistence.Concretes
{
    public class BookService : IBookService
    {
        public List<Book> GetBooks()
            => new()
        {
            new(){ Id = Guid.NewGuid(), Name ="Product1",Stock= 10 },
            new(){ Id = Guid.NewGuid(), Name ="Product2", Stock= 10 },
            new(){ Id = Guid.NewGuid(), Name ="Product3",Stock= 10 },
            new(){ Id = Guid.NewGuid(), Name ="Product4", Stock= 10 },
            new(){ Id = Guid.NewGuid(), Name ="Product5", Stock= 10 },
        };
    }
}
