using Deliverz.Application;
using Deliverz.Infrastructure.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Deliverz.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDeliverzApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistance(configuration);
            services.AddApplication();

            services.AddControllers();

            return services;
        } 
    }
}
