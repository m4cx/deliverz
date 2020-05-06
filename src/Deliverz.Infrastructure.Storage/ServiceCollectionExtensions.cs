using Deliverz.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Deliverz.Infrastructure.Storage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DeliverzDbContext>(options =>
            {
                // SqlServer
                options.UseSqlServer(configuration.GetConnectionString("DeliverzDatabase"));
            });

            services.AddScoped<IDeliverzDbContext>(provider => provider.GetRequiredService<DeliverzDbContext>());

            return services;
        }
    }
}
