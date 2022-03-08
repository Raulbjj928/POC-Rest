using POC_Rest.Model;
using POC_Rest.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace POC_Rest.Services.Implementations
{
    public class ProductServiceImplamentation : IProductService
    {
        private MySQLContext _context;

        public ProductServiceImplamentation(MySQLContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            try
            {
                _context.Add(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return product;
        }

        public Product FindById(long id)
        {
            return _context.Products.SingleOrDefault(p => p.Id.Equals(id));
        }

        public List<Product> FindAll()
        {
            return _context.Products.ToList();
        }

        public Product Update(Product product)
        {
            if (!Exists(product.Id)) return new Product();

            var result = _context.Products.SingleOrDefault(b => b.Id == product.Id);

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(product);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        public void Delete(long id)
        {
            var result = _context.Products.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null)
                {
                    _context.Products.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
        private bool Exists(long? id)
        {
            return _context.Products.Any(p => p.Id.Equals(id));
        }
    }
}
