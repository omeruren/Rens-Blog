using MediatR;
using RensBlog.Application.Features.Users.Commands;

namespace RensBlog.API.Endpoints
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
