using EntityLayer.WebApplication.Entities;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Filters.WebApplication;
using System.Reflection;

namespace ServiceLayer.Extensions.WebApplication
{
    public static class WebApplicationExtensions
    {
        public static IServiceCollection LoadWebApplicationExtensions(this IServiceCollection services)
        {

            services.AddScoped(typeof(GenericAddPreventationFilter<>));       
            services.AddScoped(typeof(GenericNotFoundFilter<>));
          

            return services;

        }
    }
}
