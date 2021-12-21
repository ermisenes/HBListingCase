using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Interfaces
{
  public  interface IOrderRepository
    {
        Order AddOrder(Order order);
        int OrderCountByProductCode(string productCode);
        IList<double> OrderPricesByProductCode(string productCode);
        int FindSoldProductCount(string orderProductProductCode);
    }
}
