using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RensBlog.Application.Behaviors;
using RensBlog.Application.Options;
using System.Reflection;
using System.Text.Json.Serialization;

namespace RensBlog.Application.Extensions;
public static class ServiceRegistrations
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            config.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.Configure<JwtTokenOptions>(configuration.GetSection(nameof(JwtTokenOptions)));

        // Ignore cycle in minimal API
        services.ConfigureHttpJsonOptions(cfg =>
        {
            cfg.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
    }
}
