using introAPI6.Models;
using introAPI6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introAPI6.Controllers
{
    [Route("api/[controller]")]//tarayıcıya api/products yazarak bu controller a erişebiliyoruz
    [ApiController] 
    public class ProductsController : ControllerBase
    {
        List<Product> products;

        private ProductsService productsService;
        public ProductsController()
        {
            productsService = new ProductsService();
        //    products = new List<Product> // bunu products service kısmıne ekledik
        //    {
        //        new Product{Id = 1, Description="Product 1", Price=10,Discount=0.1,ImageUrl="",Name="Product1",Stock=100},
        //        new Product{Id = 2, Description="Product 2", Price=10,Discount=0.1,ImageUrl="",Name="Product2",Stock=100},
        //        new Product{Id = 3, Description="Product 3", Price=10,Discount=0.1,ImageUrl="",Name="Product3",Stock=100},
        //        new Product{Id = 4, Description="Product 4", Price=10,Discount=0.1,ImageUrl="",Name="Product4",Stock=100},
        //        new Product{Id = 5, Description="Product 5", Price=10,Discount=0.1,ImageUrl="",Name="Product5",Stock=100}
        //    };
        }

        [HttpGet]
        public IActionResult GetProducts() // IActionResult bir interfacedır. IActionResult: HTTP durum kodlarını temsil ediyor.  BadRequestResult 400), NotFoundResult (404) ve OkObjectResult (200) türleridir. 
        {
            /*var products = new List<Product>
            {
                new Product{Id = 1, Description="Product 1", Price=10,Discount=0.1,ImageUrl="",Name="Product1",Stock=100},
                new Product{Id = 2, Description="Product 2", Price=10,Discount=0.1,ImageUrl="",Name="Product2",Stock=100},
                new Product{Id = 3, Description="Product 3", Price=10,Discount=0.1,ImageUrl="",Name="Product3",Stock=100},
                new Product{Id = 4, Description="Product 4", Price=10,Discount=0.1,ImageUrl="",Name="Product4",Stock=100},
                new Product{Id = 5, Description="Product 5", Price=10,Discount=0.1,ImageUrl="",Name="Product5",Stock=100}
            };*/
            var products = productsService.GetAll();
            return Ok(products);// Ok 200 döndürür yani basarılı.
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)// gelen request ten alınan veriler. Product product
        {
            //Model Binder, Http request body'sinden gelen verileri Product nesnesine dönüştürür.
            if (ModelState.IsValid)// her product da hersey yolundaysa verilerde hata yoksa boş veri gibi ya da int degere string girmek gibi burası calısır
            {
                productsService.Create(product);
                //return Ok("Complete"); // aldıgımız veriler kurallara uygunsa success dönüyor.
                return CreatedAtAction(nameof(GetProduct), routeValues: new {id=5},value: product); //yönlendirilme yapılıyor. link belirleniyor
            }

            return BadRequest(ModelState);// hata varsa verilerde badrequest döndürdük
        }


        [HttpGet("{id}")] // adres cubugundan id alıyor
        public IActionResult GetProduct([FromRoute]int id)// id degeri route dan geliyor 
        {
            //var product=products.Find(x => x.Id == id); // dısardan gelen id var mı yok mu diye kontrol ediyor
            var product = productsService.GetById(id);
            if (product==null)
            {
                return NotFound(new { message = $"{id} numaralı ürün bulunamadı" }); // id numarasına ait ürün yoksa
            }
            return Ok(product);
        }
    }
}
