using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RensBlog.Application.Behaviors;
using System.Reflection;

namespace RensBlog.Application.Extensions;
public static class ServiceRegistrations
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            config.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
