using Cosmos.Application.Interfaces;
using Cosmos.Application.Repositories;
using Cosmos.Application.ViewModels.Books;
using Cosmos.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_bookReadRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _bookReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateBook book) 
        {
            _bookWriteRepository.AddAsync(new()
            {
                Name = book.Name,
                Price = book.Price,
                Stock = book.Stock,
            });
            await _bookWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateBook model)
        {
            Book book = await _bookReadRepository.GetByIdAsync(model.Id);
            book.Stock = model.Stock;
            book.Price = model.Price;
            book.Name = model.Name;
           await _bookWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _bookWriteRepository.RemoveAsync(id);
            await _bookWriteRepository.SaveAsync();
            return Ok();
        }


    }
}
