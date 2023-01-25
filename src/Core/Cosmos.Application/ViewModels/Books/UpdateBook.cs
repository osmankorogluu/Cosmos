using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Application.ViewModels.Books
{
    public class UpdateBook
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
