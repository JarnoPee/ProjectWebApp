using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectWebApp.Data.Repository;
using ProjectWebApp.Data.UnitOfWork;
using Microsoft.AspNetCore.Identity.UI.Services;
using ProjectWebApp.Utility;

namespace ProjectWebApp
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddSingleton<IEmailSender, EmailSender>();
            services.Configure<EmailOptions>(Configuration);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });
            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = "229009675291278";
                options.AppSecret = "f0872997ba9bbc8fc3fa68beea6a802a";
            });
            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "432094131487-pdeunmad84c8u54g03valhsdv8shf9hn.apps.googleusercontent.com";
                options.ClientSecret = "p85PnwMDXKfN-VZD8BZ1h-5P";

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Klant}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            //CreateUserRoles(serviceProvider).Wait();
        }
        private async Task CreateUserRoles(IServiceProvider serviceProvider )
        {
            RoleManager<IdentityRole> RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ApplicationDbContext Context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            IdentityResult roleResult;
            // Adding Admin Role.
            bool rolAdmin = await RoleManager.RoleExistsAsync(StatischeDetails.Role_Admin);
            if (!rolAdmin)
            {
                // create the roles and seed them to the database.
                roleResult = await RoleManager.CreateAsync(new IdentityRole(StatischeDetails.Role_Admin));
            }
            bool rolIndi = await RoleManager.RoleExistsAsync(StatischeDetails.Role_User_Indi);
            if (!rolIndi)
            {
                // create the roles and seed them to the database.
                roleResult = await RoleManager.CreateAsync(new IdentityRole(StatischeDetails.Role_User_Indi));
            }
        }

    }
}
