using POC_Rest.Model;
using System.Collections.Generic;
using System.Threading;

namespace POC_Rest.Services.Implementations
{
    public class ProductServiceImplamentation : IProductService
    {
        private volatile int count;

        public Product Create(Product product)
        {
            return product;
        }

        public Product Delete(long id)
        {
            return new Product { };
        }

        public List<Product> FindAll()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 8; i++)
            {
                Product product = MockProduct(i);
                products.Add(product);
            }
            return products;
        }
                
        public Product FindById(long id)
        {
            return new Product
            {
                Id = IncrementANdGet(),
                Name = "Cerveja",
                UnitOfMeasurement = "Litro",
                Liter = 1,
                Weight = 0,
                Price = 5
            };
        }

        public Product Update(Product product)
        {
            return product;
        }

        private Product MockProduct(int i)
        {
            return new Product
            {
                Id = IncrementANdGet(),
                Name = "Nome do Produto " + i,
                UnitOfMeasurement = "Unidade de medida " + i,
                Liter = 1,
                Weight = 0,
                Price = 5
            };
        }

        private long IncrementANdGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
