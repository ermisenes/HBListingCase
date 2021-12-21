using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;

namespace Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public string CreateProduct(string[] commandArray)
        {
            try
            {
                var productCode = commandArray[1];
                var price = commandArray[2];
                var stock = commandArray[3];

                var product = new Product
                {
                    ProductCode = productCode,
                    Price = Convert.ToInt32(price),
                    Stock = Convert.ToInt32(stock)
                };

                _repository.AddProduct(product);
                return $"Product created; code {product.ProductCode}, price {product.Price}, stock {product.Stock}";
            }
            catch
            {
                return "create_product PRODUCTCODE PRICE STOCK";
            }
        }

        public string GetProductInfo(string[] commandArray)
        {
            try
            {
                var productCode = commandArray[1];

                var product = _repository.FindByProductCode(productCode);
                return $"Product {product.ProductCode} info; price {product.Price}, stock {product.Stock}";
            }
            catch
            {
                return "get_product_info PRODUCTCODE";
            }
        }
    }
}
