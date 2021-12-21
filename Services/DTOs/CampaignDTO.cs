using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;

namespace Services.DTOs
{
    class CampaignDTO : BaseModel
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int TargetSales { get; set; }
        public int TotalSales { get; set; }
        public int Turnover { get; set; }
        public double AverageItemPrice { get; set; }
    }
}
