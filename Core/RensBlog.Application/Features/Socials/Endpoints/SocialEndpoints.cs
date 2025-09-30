using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Socials.Commands;

namespace RensBlog.Application.Features.Socials.Endpoints;

public static class SocialEndpoints
{
    public static void RegisterSocialEndpoints(this IEndpointRouteBuilder app)
    {
        var socials = app.MapGroup("/socials").WithTags("Socials");

        socials.MapPost(string.Empty, async (IMediator mediator, CreateSocialCommand command) =>
        {
            var result = await mediator.Send(command);
            return result.IsSuccess 
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);
        });
    }
}
