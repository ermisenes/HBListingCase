using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTest
{
    public static class FileReader
    {
        public static List<string> FileOperattion(string path)
        {
            Startup.ConfigureServices();
            if (!File.Exists(path))
                throw new Exception("File not found!");

            List<string> baseCommands = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line = string.Empty;
                while (!string.IsNullOrWhiteSpace(line = sr.ReadLine()))
                {
                   string[] splitFunction = line.Split(" ");
                    if (splitFunction[0]== "create_product")
                    {
                        var service = Startup.ServiceProvider.GetService<IProductService>();
                        Console.WriteLine(service.CreateProduct(splitFunction));
                    }
                   else if (splitFunction[0] == "create_campaign")
                    {
                        var service = Startup.ServiceProvider.GetService<ICampaignService>();
                        Console.WriteLine(service.CreateCampaign(splitFunction));
                    }
                    else if (splitFunction[0] == "get_product_info")
                    {
                        var service = Startup.ServiceProvider.GetService<IProductService>();
                        Console.WriteLine(service.GetProductInfo(splitFunction));
                    }
                    else if(splitFunction[0] == "create_order")
                    {
                        var service = Startup.ServiceProvider.GetService<IOrderService>();
                        Console.WriteLine(service.CreateOrder(splitFunction));
                    }
                    else if (splitFunction[0] == "increase_time")
                    {                      
                        Console.WriteLine("Time Is "+ splitFunction[1]);
                    }
                }
            }
            return baseCommands;
        }
    }
}