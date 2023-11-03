using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NToastNotify;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.Extensions.WebApplication;
using ServiceLayer.FluentValidation.WebAPplication.HomePageValidation;
using ServiceLayer.Helpers.Generic.Image;
using ServiceLayer.Services.Identity.Abstract;
using ServiceLayer.Services.Identity.Concrete;
using System.Reflection;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.LoadIdentityExtensions(config);
            services.LoadWebApplicationExtensions();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.Name.EndsWith("Service"));

            foreach (var serviceType in types)
            {
                var iServiceType = serviceType.GetInterfaces().FirstOrDefault(x => x.Name == $"I{serviceType.Name}");

                if (iServiceType != null)
                {
                    services.AddScoped(iServiceType, serviceType);
                }
            }


            services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
            });

            services.AddValidatorsFromAssemblyContaining<HomePageAddValidation>();


            services.AddScoped<IImageHelper, ImageHelper>();



            return services;
        }
    }
}
