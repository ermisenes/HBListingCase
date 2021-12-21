using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;

namespace Data.EntitiyFrameWork
{
    public class ProductRepository : IProductRepository
    {
        private readonly HepsiBuradaDbContext _context;

        public ProductRepository(HepsiBuradaDbContext context)
        {
            _context = context;
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product FindByProductCode(string productCode)
        {
            return _context.Products.FirstOrDefault(x => x.ProductCode.ToLower().Contains(productCode.ToLower()));
        }
    }
}
