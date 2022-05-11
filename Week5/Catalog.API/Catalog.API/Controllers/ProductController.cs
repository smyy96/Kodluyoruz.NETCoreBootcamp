using Catalog.API.Filters;
using Catalog.Business;
using Catalog.DataTransferObjects.Requests;
using Catalog.DataTransferObjects.Responses;
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

            var products = await service.GetProducts();
            return Ok(products);
        }


        [HttpGet("{id}")] // id ye göre getirme
        public async Task<IActionResult> GetProductById(int id)
        {
            ProductDisplayResponse product = await service.GetProducts(id);
            return Ok(product);
        }

        [HttpGet("Search/{key}")] //kelime ile arama yapıp getirme
        public async Task<IActionResult> Search(string key)
        {
            var responses = await service.GetProductsByName(key);
            return Ok(responses);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductRequest addProductRequest)
        {
            if (ModelState.IsValid)//kurallara uyulursa
            {

                int productid = await service.AddProduct(addProductRequest);
                return CreatedAtAction(nameof(GetProductById), routeValues: new { id = productid }, value: null);// ekleme işlemi yaptıktan sonra dönüş olarak id döner. id linke ekliyoruz 
            }
            return BadRequest(ModelState);
        }



        [HttpPut("{id}")]
        [IsExists]
        public async Task<IActionResult> Update(int id, UpdateProductRequest updateProductRequest)
        {
            //if (await service.IsProductExists(id))
            //{
                if (ModelState.IsValid)
                {
                    await service.UpdateProduct(updateProductRequest);
                    return Ok();
                }
                return BadRequest(ModelState);
            //}

            //return NotFound(new { message = $"{id} id'li ürün bulunamadı." });
        }


        [HttpDelete("{id}")]
        [IsExists]
        public async Task<IActionResult> Delete(int id)
        {
            await service.DeleteProduct(id);
            return Ok();

        }


    }
}
