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
  public  class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly ICampaignRepository _campaignRepository;
        private readonly IProductRepository _productRepository;
        public OrderService(IOrderRepository repository, ICampaignRepository campaignRepository,
           IProductRepository productRepository)
        {
            _repository = repository;
            _campaignRepository = campaignRepository;
            _productRepository = productRepository;
        }

        public string CreateOrder(string[] commandArray)
        {
            try
            {
                var productCode = commandArray[1];
                var quantity = commandArray[2];

                var order = new Order
                {
                    ProductCode = productCode,
                    Quantity = Convert.ToInt32(quantity)
                };

                _repository.AddOrder(order);
                return $"Order created; product {order.ProductCode}, quantity {order.Quantity}";
            }
            catch(Exception ex)
            {
                return "create_order PRODUCTCODE QUANTITY ";
            }
        }
      
    }
}
