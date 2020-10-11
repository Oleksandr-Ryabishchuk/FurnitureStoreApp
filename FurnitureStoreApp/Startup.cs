using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureStoreApp.DataAccessLayer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FurnitureStoreApp.DataAccessLayer.UnitOfWork;
using FurnitureStoreApp.DataAccessLayer.Repository;
using FurnitureStoreApp.BusinessLayer.Interfaces;
using FurnitureStoreApp.BusinessLayer.Managers;
using AutoMapper;

namespace FurnitureStoreApp
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
            services.AddControllers();
            
            services.AddDbContext<DataContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString("DefaultConnection"), 
            b => b.MigrationsAssembly("FurnitureStoreApp.DataAccessLayer")));

            services.AddAutoMapper(typeof(Administrator).Assembly);
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
           
            services.AddTransient<IAdministrator, Administrator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
