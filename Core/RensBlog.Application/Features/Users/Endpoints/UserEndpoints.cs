using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Users.Commands;

namespace RensBlog.Application.Features.Users.Endpoints
{
    public static class UserEndpoints
    {
        public static void RegisterUserEndPoints(this IEndpointRouteBuilder app)
        {
            var users = app.MapGroup("/users").WithTags("Users");

            users.MapPost("register", async (IMediator mediator, CreateUserCommand command) =>
            {
                var response = await mediator.Send(command);

                return response.IsSuccess
                                ? Results.Ok(response)
                                : Results.BadRequest(response);
            });
        }
    }
}
