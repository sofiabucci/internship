using Microsoft.AspNetCore.Mvc;
using Project.Domain.Interfaces;
using Project.Domain.Models;


namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            var result = await _repository.Add(product);

            if (!result)
            {
                return BadRequest();
            }

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repository.Delete(id);

            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetAll();

            if (!result.Any())
            {
                return NoContent();
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] Product product)
        {
            if (await _repository.GetById(id) == null)
                return NotFound();

            if (!await _repository.Update(id, product))
                return BadRequest();

            return Ok();
        }
    }
}