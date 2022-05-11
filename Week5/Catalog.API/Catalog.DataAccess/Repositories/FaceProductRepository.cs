using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositories
{
    public class FaceProductRepository : IProductRepository
    {
        private List<Product> products;

        public FaceProductRepository()
        {
            products = new List<Product>
            {
                new Product{ Id = 1, Name = "Product 1",Price =100,CategoryId = 1,Description ="Product 1 description", ImageUrl =""},
                new Product{ Id = 2, Name = "Product 1",Price =200,CategoryId = 1,Description ="Product 1 description", ImageUrl =""},
                new Product{ Id = 3, Name = "Product 1",Price =300,CategoryId = 1,Description ="Product 1 description", ImageUrl =""},
                new Product{ Id = 4, Name = "Product 1",Price =400,CategoryId = 1,Description ="Product 1 description", ImageUrl =""},
                new Product{ Id = 5, Name = "Product 1",Price =500,CategoryId = 1,Description ="Product 1 description", ImageUrl =""}

            };
        }

        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetAll()
        {
            return products;
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<Product> IRepository<Product>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
