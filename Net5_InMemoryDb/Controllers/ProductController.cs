using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Net5_InMemoryDb.Data;
using Net5_InMemoryDb.Models;
using System.Linq;

namespace Net5_InMemoryDb.Controllers
{

    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {

        //Now use [FromServices] to inject deps

        // private DataContext _context;

        // public  ProductController(DataContext context)
        // {
        //     _context = context;
        // }


        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get(
            [FromServices] DataContext context
        )
        {
            var products = await context.Products
            .Include(x => x.Category)
            .ToListAsync();
            return products;
        }



        [HttpGet]
        [Route("{id:int}")] //validate integer params
        public async Task<ActionResult<Product>> GetById(
            [FromServices] DataContext context, int id
        )
        {
            var product = await context.Products
            .Include(x => x.Category)
            .AsNoTracking() // makes ef don't create proxy with objects on manipulations
            .FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        [HttpGet]
        [Route("categories/{id:int}")] //validate integer params
        public async Task<ActionResult<List<Product>>> GetByCategory(
        [FromServices] DataContext context, int id
)
        {
            var products = await context.Products
            .Include(x => x.Category)
            .AsNoTracking() // makes ef don't create proxy with objects on manipulations
            .Where(x => x.CategoryId == id)
            .ToListAsync(); //aways at final
            return products;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post(
            [FromServices] DataContext context,
            [FromBody] Product model
        )
        {

            if (ModelState.IsValid)
            {
                context.Products.Add(model);
                await context.SaveChangesAsync(); //onlypersists if save changes
                return model;
            }
            else
            {
                return BadRequest(ModelState); //to call validation errors
            }


        }
    }
}