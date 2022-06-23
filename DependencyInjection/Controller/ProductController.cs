using DependencyInjection.Factory;
using DependencyInjection.InterfaceFactory;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        [Route("GetProduct")]
        [HttpGet]
        public IActionResult GetProduct()
        {
            var List = _product.Products;
            return new JsonResult(List);
        }
    }
}
