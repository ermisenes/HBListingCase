using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductService
    {
        string CreateProduct(string[] commandLine);
        string GetProductInfo(string[] commandLine);
    }
}
