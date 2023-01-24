using Cosmos.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Domain.Entities
{
    public class Book: BaseEntity
    {
        
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public float Price { get; set; }
        public int NumberPages { get; set; }
        public int Stock { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public ICollection<Order> Orders { get; set; }

    
    }
}
