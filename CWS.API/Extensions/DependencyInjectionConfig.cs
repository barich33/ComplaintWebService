using CWS.Service.categories;
using Microsoft.Extensions.DependencyInjection;

namespace CWS.API.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static void AddScope(IServiceCollection services)
        {
            //Services
            services.AddScoped<ICategoryService, CategoryService>();
        
        }
    }
}
