using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Core.EF;
using NetCoreBookStore.Core.Entities;

namespace NetCoreBookStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {           
            services.AddDirectoryBrowser();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<AppUser>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            //services.AddIdentityCore<IdentityUser<Guid>, IdentityRole<Guid>>().AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddScoped<ShoppingCartRepository>(sp => ShoppingCartRepository.GetCart(sp));
            
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddRazorPages();

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

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"MyStaticFiles")),
                RequestPath = new PathString("/MyStaticFiles")
            });

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
