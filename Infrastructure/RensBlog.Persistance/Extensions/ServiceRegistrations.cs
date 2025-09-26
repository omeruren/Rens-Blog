using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RensBlog.Persistance.Context;

namespace RensBlog.Persistance.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
            });
        }
    }
}
