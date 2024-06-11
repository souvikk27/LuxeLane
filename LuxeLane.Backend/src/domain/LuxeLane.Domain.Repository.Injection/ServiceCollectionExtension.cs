using LuxeLane.Domain.Repository.Products;
using Microsoft.Extensions.DependencyInjection;

namespace LuxeLane.Domain.Repository.Injection
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureRepositoryInjection(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
