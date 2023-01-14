using Cosmos.Application.Repositories;
using Cosmos.Domain.Entities;
using Cosmos.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly  ICategoryReadRepository _categoryReadRepository;
        private readonly  ICategoryWriteRepository _categoryWriteRepository;

        public CategoriesController( ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository)
        {
            
            _categoryWriteRepository = categoryWriteRepository;
            _categoryReadRepository = categoryReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _categoryWriteRepository.AddRangeAsync(new()
            {
                new() { CategoryName="Roman"},
                new() { CategoryName="Bilim Kurgu"},
                new() { CategoryName="Şiir"},

            });
            var count = await _categoryWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(id);
            return Ok(category);
        }

    }
}
