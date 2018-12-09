using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Concrete;
using Contracts;
using DataAccess;
using EfRepository;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SPA_AngularJS_MVC_Core
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
            services.AddDbContext<SpaAppContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:Conn1:ConnectionString"],
                    builder => builder.MigrationsAssembly(typeof(SpaAppContext).Assembly.FullName)));

            services.AddTransient(typeof(IMovieRepo), typeof(MovieRepo));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddMvc();
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

            app.UseStaticFiles();
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultApi",
                    template: "api/{controller}/{action}/{id?}");


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Movie}/{action=Index}/{id?}");
            });
        }
    }
}
