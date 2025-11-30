using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context  )
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpGet("{id}")]
        
        public async Task<IActionResult> Get(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]

        public async Task<IActionResult> Post(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Product product)
        {
            var obj = await _context.Products.FindAsync(id);    
            if (obj == null)
                return NotFound();
            obj.Name = product.Name;
            obj.Price = product.Price;
            obj.Description = product.Description;
            await _context.SaveChangesAsync();
            return Ok(obj);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _context.Products.FindAsync(id);
            if (obj == null)
                return NotFound();
            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }

}
