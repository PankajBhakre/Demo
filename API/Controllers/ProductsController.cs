using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public readonly StoreContext _storecontext;
        public ProductsController(StoreContext storeContext)
        {
            _storecontext = storeContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Products()
        {
            var products =await _storecontext.products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Product(int id)
        {
            return await _storecontext.products.FindAsync(id);
        }
    }
}