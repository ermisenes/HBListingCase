using System;
using Data;
using Data.EntitiyFrameWork;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Concrete;
using Services.Interfaces;

namespace UnitTest
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider;

        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<HepsiBuradaDbContext>(opt =>
              opt.UseInMemoryDatabase("HepsiBuradaDb"));

            services.AddServices();

            ServiceProvider = services.BuildServiceProvider();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICampaignRepository, CampaignRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IAppTimeRepository, AppTimeRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICampaignService, CampaignService>();
        }
        private static string GetDbConnectionByName(string ConnectionName)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            return configuration.GetConnectionString(ConnectionName);
        }
    }
}
