using Microsoft.AspNetCore.Mvc;
using Project.Domain.Interfaces.IBrand;
using Project.Domain.Models;


namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _repository;

        public BrandController(IBrandRepository repository)
        {
            _repository = repository;
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

        [HttpPost]
        public async Task<IActionResult> Add(Brand brand)
        {
            var result = await _repository.Add(brand);

            if (!result)
            {
                return BadRequest();
            }

            return Ok(brand);
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] Brand brand)
        {
            if (await _repository.GetById(id) == null)
                return NotFound();

            if (!await _repository.Update(id, brand))
                return BadRequest();

            return Ok();
        }
    }
}