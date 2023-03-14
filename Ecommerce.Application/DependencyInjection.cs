using Ecommerce.Application.Brand;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBrandsService, BrandsService>();

            services.AddMediatR(typeof(DependencyInjection).Assembly);


            return services;
        }
    }
}
