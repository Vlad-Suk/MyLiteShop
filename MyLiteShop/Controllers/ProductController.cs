using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLiteShop.Models;

namespace MyLiteShop.Controllers
{
    [Route("shop/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public ProductController(ShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductItem(int id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            var productItem = await _context.Products.FindAsync(id);

            if (productItem == null)
            {
                return NotFound();
            }
            return productItem;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ShopDbContext.Produsrs'  is null.");
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductItem), new {id = product.Id}, product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            var productItem = await _context.Products.FindAsync(id);
            if (productItem == null)
            {
                return NotFound();
            }

            _context.Products.Remove(productItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
