using RensBlog.API.CustomMiddlewares;
using RensBlog.API.EndpointRegistration;
using RensBlog.Application.Extensions;
using RensBlog.Persistance.Extensions;
using Scalar.AspNetCore;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication(builder.Configuration); // Application Services
builder.Services.AddPersistance(builder.Configuration); // Persistance Services



// Ignore cycle JsonSerializer Options
builder.Services.AddControllers()
    //.AddJsonOptions(cfg =>{cfg.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;})
    ;





// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseMiddleware<CustomExceptionHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGroup("/api")
   .RequireAuthorization() // Require authorization for all endpoints under /api
    .RegisterEndPoints();

app.Run();
