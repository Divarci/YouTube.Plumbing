using EntityLayer.Identity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;

namespace ServiceLayer.Extensions.Identity
{
    public static class IdentityConfigurations
    {
        public static IServiceCollection LoadIdentityConfigurations(this IServiceCollection services)
        {

            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                opt.Password.RequiredUniqueChars = 2;
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 10;
            })
                .AddRoleManager<RoleManager<AppRole>>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(opt =>
            {
                var cookieBuilder = new CookieBuilder();

                cookieBuilder.Name = "PlumbingCompany";
                opt.LoginPath = new PathString("Authentication/SignIn");
                opt.LogoutPath = new PathString("Authentication/LogOut");
                opt.AccessDeniedPath = new PathString("Authentication/AccessDenied");
                opt.Cookie = cookieBuilder;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);

            });

            return services;


        }
    }
}
