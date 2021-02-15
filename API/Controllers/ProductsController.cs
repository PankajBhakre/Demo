using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        [HttpGet]
        public string Products()
        {
            return "This will gives the list of products";
        }

        [HttpGet("{id}")]
         public string Product()
        {
            return "This will gives single product";
        }
    }
}