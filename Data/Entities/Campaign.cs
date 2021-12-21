using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;

namespace Data.Entities
{
    public class Campaign : BaseModel
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public double CampaignProductPrice { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSalesCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public int Turnover { get; set; }
        public int TotalSales { get; set; }
        public double AverageItemPrice { get; set; }
    }
}
