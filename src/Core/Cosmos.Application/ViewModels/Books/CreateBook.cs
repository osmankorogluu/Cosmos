using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Application.ViewModels.Books
{
    public class CreateBook
    {
        public string Name { get; set; }
        public string Writer { get; set; }
        public float Price { get; set; }
        public int NumberPages { get; set; }
        public int Stock { get; set; }
    }
}
