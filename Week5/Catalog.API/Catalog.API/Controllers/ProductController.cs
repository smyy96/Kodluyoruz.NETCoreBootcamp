using Catalog.Business;
using Catalog.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService productService)
        {
            service = productService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProduct()//async, bu uygulama calısırken baska bir uygulamayıda calıstırabiliriz es zamanlı calısıyor. async her zaman Task ile çalışır
        {
            
            var products=await service.GetProducts();
            return Ok(products);
        }
    }
}
