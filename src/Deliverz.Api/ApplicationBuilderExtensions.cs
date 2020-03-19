 using Microsoft.AspNetCore.Builder;

namespace Deliverz.Api
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDeliverzApi(this IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
