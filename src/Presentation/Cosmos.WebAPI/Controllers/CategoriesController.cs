using Cosmos.Application.Repositories;
using Cosmos.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoriesController(ICategoryReadRepository _categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = _categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _categoryWriteRepository.AddRangeAsync(new()
            {
                new() { CategoryName="Roman"},
                new() { CategoryName="Bilim Kurgu"},
                new() { CategoryName="Şiir"},

            });
            var count = await _categoryWriteRepository.SaveAsync();

        }
    }
}
