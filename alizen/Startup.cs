using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using alizen.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Aqui
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using alizen.Models;
using alizen.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace alizen {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.Configure<CookiePolicyOptions> (options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //BookStore
            //services.Configure<BookstoreDatabaseSettings> (
            services.Configure<StoreDatabaseSettings> (
                //Configuration.GetSection (nameof (BookstoreDatabaseSettings)));
                Configuration.GetSection (nameof (StoreDatabaseSettings)));

           
            //services.AddSingleton<IBookstoreDatabaseSettings> (sp =>
            services.AddSingleton<IStoreDatabaseSettings> (sp =>
                //sp.GetRequiredService<IOptions<BookstoreDatabaseSettings>> ().Value);
                sp.GetRequiredService<IOptions<StoreDatabaseSettings>> ().Value);

            services.AddSingleton<BookService> ();
            services.AddSingleton<ProductService> ();
           
           
            // services.AddControllers();

            services.AddDbContext<ApplicationDbContext> (options =>
                options.UseSqlite (
                    Configuration.GetConnectionString ("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser> ()
                .AddDefaultUI (UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext> ();

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                app.UseDatabaseErrorPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseCookiePolicy ();

            app.UseAuthentication ();
            
            // Agregando MVC
            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}