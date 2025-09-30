using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Users.Commands;
using RensBlog.Application.Features.Users.Queries;

namespace RensBlog.Application.Features.Users.Endpoints
{
    public static class UserEndpoints
    {
        public static void RegisterUserEndPoints(this IEndpointRouteBuilder app)
        {
            var users = app.MapGroup("/users").WithTags("Users")
                .AllowAnonymous(); // All endpoints in this group allow anonymous access

            users.MapPost("register", async (IMediator mediator, CreateUserCommand command) =>
            {
                var response = await mediator.Send(command);

                return response.IsSuccess
                                ? Results.Ok(response) // 200 Ok 
                                : Results.BadRequest(response); // 400 bad requeest
            });

            users.MapPost("login", async (IMediator mediator, GetLoginQuery query) =>
            {
                var response = await mediator.Send(query);
                return response.IsSuccess
                                ? Results.Ok(response)
                                : Results.BadRequest(response); 
            });
        }
    }
}
