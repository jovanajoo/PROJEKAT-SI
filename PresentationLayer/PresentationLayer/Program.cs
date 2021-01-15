using BusinessLayer;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var main = serviceProvider.GetRequiredService<Form1>();
                Application.Run(main);
            }

        }
        private static void ConfigureServices(ServiceCollection services)
        {

            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<ICategoryBusiness, CategoryBusiness>();

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductBusiness, ProductBusiness>();

            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<ICustomerBusiness, CustomerBusiness>();

            services.AddSingleton<IOrder_ItemRepository, Order_ItemRepository>();
            services.AddSingleton<IOrder_ItemBusiness, Order_ItemBusiness>();

            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<IOrderBusiness, OrderBusiness>();

            services.AddSingleton<Form1>();
            services.AddSingleton<Login>();
            services.AddSingleton<Registration>();
            services.AddSingleton<UpdateProduct>();
            services.AddSingleton<AddProduct>();
            services.AddSingleton<DeleteProduct>();
            
            
        }
    }
}
