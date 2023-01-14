using Cosmos.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService productService)
        {
            this._bookService = productService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var product = _bookService.GetBooks();
            return Ok(product);
        }
    }
}
