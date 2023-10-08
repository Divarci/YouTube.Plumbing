using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.FluentValidation.WebAPplication.HomePageValidation;
using System.Reflection;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.LoadIdentityExtensions(config);

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

            return services;
        }
    }
}
