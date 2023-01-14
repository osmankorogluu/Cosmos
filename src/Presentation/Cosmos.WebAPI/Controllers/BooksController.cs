using Cosmos.Application.Interfaces;
using Cosmos.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IBookWriteRepository _bookWriteRepository;

        public BooksController(IBookReadRepository _bookReadRepository, IBookWriteRepository bookWriteRepository)
        {
            _bookWriteRepository = bookWriteRepository;
            _bookReadRepository = _bookReadRepository;
        }
        //[HttpGet]
        //public async void Get()
        //{
        //    await _bookWriteRepository.AddRangeAsync(new()
        //    {
        //        new() {Id = Guid.NewGuid(), Name = "Product 1", Price =100, CreateDate = DateTime.UtcNow,Stock=10},
        //        new() { Id = Guid.NewGuid(), Name = "Product 2", Price =200, CreateDate = DateTime.UtcNow,Stock=10},
        //        new() { Id = Guid.NewGuid(), Name = "Product 3", Price =300, CreateDate = DateTime.UtcNow,Stock=10},
        //        new() { Id = Guid.NewGuid(), Name = "Product 4", Price =400, CreateDate = DateTime.UtcNow,Stock=10},
        //    });
        //   var count = await _bookWriteRepository.SaveAsync();



        //}
    }
}
