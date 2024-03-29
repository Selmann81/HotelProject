using HotelProject.Controllers;
using HotelProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelProject
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
            string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<SiteContext>(option => option.UseMySql(mySqlConnectionStr));
            services.AddControllersWithViews();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
//namespace HotelProject
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
//            services.AddDbContextPool<SiteContext>(option => option.UseMySql(mySqlConnectionStr));
//            services.AddDbContext<SiteContext>();
//            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SiteContext>();
//            services.AddControllersWithViews();
//            services.AddMvc(config =>
//            {
//                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build(); config.Filters.Add(new AuthorizeFilter(policy));
//            });
//        }


//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//                //}
//                app.UseDeveloperExceptionPage();
//                app.UseStatusCodePages();
//                app.UseStaticFiles();

//                app.UseAuthentication();
//                app.UseHttpsRedirection();
//                app.UseStaticFiles();

//                app.UseRouting();

//                app.UseAuthorization();

//                app.UseEndpoints(endpoints =>
//                {
//                    endpoints.MapControllerRoute(
//                        name: "areas",
//                        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
//                    endpoints.MapControllerRoute(
//                        name: "default",
//                        pattern: "{controller=Home}/{action=Index}/{id?}");

//                });
//            }
//        }
//    }
//}
