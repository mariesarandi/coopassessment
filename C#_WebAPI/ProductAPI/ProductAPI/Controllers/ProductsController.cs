using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ProductAPI.Models;
using System.Threading.Tasks;


namespace ProductAPI.Controllers
// <see also="https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio"/> 
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ItemContext _context; 

        public ProductsController(ItemContext context)
        {
            _context = context;
        }

        // GET: api/ProductItems/5
        [HttpGet("{ID}")]
        public async Task<ActionResult<ProductItem>> GetProductItem(long ID)
        {
            var productItem = await _context.Items.FindAsync(ID);

            if (productItem == null)
            {
                return NotFound();
            }

            return productItem;
        }

        // PUT: api/ProductItems/5
        [HttpPut("{ID}")]
        public async Task<IActionResult> PutProductItem(long ID, ProductItem productItem)
        {
            if (ID != productItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(productItem).State = (Microsoft.EntityFrameworkCore.EntityState)productItem.ID;

            
            {
                await _context.SaveChangesAsync();
            }
            

            return NoContent();
        }



        // DELETE: api/ProductItems/5
        [HttpDelete("{ID}")]
        public async Task<IActionResult> DeleteProductItem(long ID)
        {
            var productItem = await _context.Items.FindAsync(ID);
            if (productItem == null)
            {
                return NotFound();
            }

            _context.Items.Remove(productItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}
