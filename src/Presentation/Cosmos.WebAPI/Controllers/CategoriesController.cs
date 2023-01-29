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

        [HttpGet("{categoryNumber}")]
        public async Task<IActionResult> Get([FromRoute] string categoryNumber)
        {
            return Ok(await _categoryReadRepository.GetByIdAsync(categoryNumber, false));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Post([FromRoute] CreateCategory category)
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
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Put([FromRoute] UpdateCategory model)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(model.Id);
            category.CategoryName = model.CategoryName;
           
            await _categoryWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{categoryNumber}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete([FromRoute] string categoryNumber)
        {
            await _categoryWriteRepository.RemoveAsync(categoryNumber);
            await _categoryWriteRepository.SaveAsync();
            return Ok();
        }


    }
}
