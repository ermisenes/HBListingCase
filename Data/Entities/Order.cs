using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;

namespace Data.Entities
{
    public class Order : BaseModel
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
