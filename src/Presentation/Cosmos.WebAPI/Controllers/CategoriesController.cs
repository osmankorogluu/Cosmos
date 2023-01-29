using Cosmos.Application.Repositories;
using Cosmos.Application.ViewModels.Books;
using Cosmos.Application.ViewModels.Categories;
using Cosmos.Domain.Entities;
using Cosmos.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public async Task<IActionResult> GetAll()
        {
            return Ok(_categoryReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _categoryReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCategory category)
        {
            if (ModelState.IsValid)
            {


            }
            await _categoryWriteRepository.AddAsync(new()
            {
                CategoryName= category.CategoryName,
            });
            await _categoryWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCategory model)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(model.Id);
            category.CategoryName = model.CategoryName;
           
            await _categoryWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _categoryWriteRepository.RemoveAsync(id);
            await _categoryWriteRepository.SaveAsync();
            return Ok();
        }


    }
}
