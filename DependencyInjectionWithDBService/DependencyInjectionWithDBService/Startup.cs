using DependencyInjectionWithDBService.DAO.StudentDAO;
using DependencyInjectionWithDBService.Services.DBContext;
using DependencyInjectionWithDBService.Services.Interface;
using DependencyInjectionWithDBService.Services.StudentService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService
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
            //get connectionstring from appsetting
            var connectionString = Configuration.GetConnectionString("MyConnection");

            //add connection string into EFDbContext to use sql database connection
            services.AddDbContext<EFDBContext>(options => options.UseSqlServer(connectionString));

            #region RegisterMyServices

            services.AddScoped<StudentDAO>();
            services.AddScoped<IStudentInterface, StudentService>();

            #endregion

            services.AddControllers();
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
