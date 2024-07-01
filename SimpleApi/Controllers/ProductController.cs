using SimpleApi.Context;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDataContext _db;
        public ProductController(ApplicationDataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _db.Product.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _db.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound("Non existed product");
            }

            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _db.Product.Add(product);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(Guid id, Product productRequest)
        {
            var product = await _db.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound("Non existed product");
            }

            product.Name = productRequest.Name;
            product.Category = productRequest.Category;
            product.Price = productRequest.Price;

            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _db.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound("Non existed product");
            }

            _db.Product.Remove(product);
            await _db.SaveChangesAsync();

            return NoContent();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
