using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookstoreProject
{
    public class Startup
    {
        public Startup(IConfiguration temp)
        {
            Configuration = temp;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<BookstoreContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BookstoreDBConnection"]);
            });

            services.AddDbContext<AppIdentityDBContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:IdentityConnection"]);
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDBContext>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                    options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
            });

            services.AddScoped<IBookstoreProjectRepository, EFBookstoreProjectRepository>();
            services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddServerSideBlazor();

            services.AddScoped<Cart>(x => SessionCart.GetCart(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("categoryPage", "{bookCategory}/Page{pageNum}", new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("Paging", "Page{pageNum}", new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapControllerRoute("category", "{bookCategory}", new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();

                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{catchall}", "/Admin/Index");
            });

            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
