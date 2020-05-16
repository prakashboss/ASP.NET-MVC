using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using WebShopDB.Data.Interface;
using WebShopDB.Models;
using WebShopDB.Repositories;

namespace WebShopDB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
options.SerializerSettings.ContractResolver = new
DefaultContractResolver());
            var connection =
            Configuration.GetConnectionString("DatabaseConnection");
            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(connection, b =>
            b.UseRowNumberForPaging()));
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });
            //services.AddTransient<IOrderRepository, OrderRepository>();add
           
            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>();

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(serviceProvider => ShoppingCart.GetCart(serviceProvider));
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
          
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

          
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseIdentity();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Run(context => { throw new Exception("error"); });
            app.UseDeveloperExceptionPage();
        }
    }
}
