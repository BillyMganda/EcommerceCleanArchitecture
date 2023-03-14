using Ecommerce.Application.Brand;
using Ecommerce.Infrastructure.Brand;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IBrandsRepository, BrandsRepository>();

            return services;
        }
    }
}
