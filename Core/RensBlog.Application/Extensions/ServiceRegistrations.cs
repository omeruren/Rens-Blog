using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RensBlog.Application.Extensions;
public static class ServiceRegistrations
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
