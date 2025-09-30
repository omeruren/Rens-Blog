using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Application.Features.Socials.Queries;

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

        socials.MapGet(string.Empty, async (IMediator mediator) =>
        {
            var result = await mediator.Send(new GetSocialsQuery());
            return result.IsSuccess
                            ? Results.Ok(result)
                            : Results.BadRequest(result);
        });

        socials.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var result = await mediator.Send(new GetSocialByIdQuery(id));
            return result.IsSuccess
                            ? Results.Ok(result)
                            : Results.BadRequest(result);
        });

        socials.MapPut(string.Empty, async (IMediator mediator, UpdateSocialCommand command) =>
        {
            var result = await mediator.Send(command);
            return result.IsSuccess
                            ? Results.Ok(result)
                            : Results.BadRequest(result);
        });

    }
}
