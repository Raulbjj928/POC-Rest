using POC_Rest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_Rest.Services
{
    public interface IProductService
    {
        Product Create(Product product);
        Product FindById(long id);
        List<Product> FindAll();
        Product Update(Product product);
        Product Delete(long id);
    }
}
