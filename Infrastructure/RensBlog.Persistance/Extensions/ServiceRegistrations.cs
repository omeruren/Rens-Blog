using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Domain.Entities;
using RensBlog.Persistance.Concrete;
using RensBlog.Persistance.Context;
using RensBlog.Persistance.Interceptors;

namespace RensBlog.Persistance.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
                options.AddInterceptors(new AuditDbContextIntercaptor());
            });

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                
            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

        }
    }
}
