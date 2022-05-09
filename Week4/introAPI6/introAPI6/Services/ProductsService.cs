using introAPI6.Models;

namespace introAPI6.Services
{
    public class ProductsService
    {
        private List<Product> products;

        public ProductsService()
        {
            products = new List<Product>
            {
                new Product{Id = 1, Description="Product 1", Price=10,Discount=0.1,ImageUrl="",Name="Product1",Stock=100},
                new Product{Id = 2, Description="Product 2", Price=10,Discount=0.1,ImageUrl="",Name="Product2",Stock=100},
                new Product{Id = 3, Description="Product 3", Price=10,Discount=0.1,ImageUrl="",Name="Product3",Stock=100},
                new Product{Id = 4, Description="Product 4", Price=10,Discount=0.1,ImageUrl="",Name="Product4",Stock=100},
                new Product{Id = 5, Description="Product 5", Price=10,Discount=0.1,ImageUrl="",Name="Product5",Stock=100}
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.Find(x => x.Id == id);
        }

        public Product Create(Product product)
        {
            product.Id= products.Max(x => x.Id)+1;
            products.Add(product);  
            return product;
        }

    }
}
