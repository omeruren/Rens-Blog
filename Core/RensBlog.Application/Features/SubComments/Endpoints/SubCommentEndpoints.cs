using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.SubComments.Commands;

namespace RensBlog.Application.Features.SubComments.Endpoints;

public static class SubCommentEndpoints
{
    public static void RegisterSubCommentEndpoints(this IEndpointRouteBuilder app)
    {
        var subComments = app.MapGroup("/subComments").WithTags("SubComments");

        subComments.MapPost(string.Empty, async (CreateSubCommentCommand command, IMediator mediator) =>
        {

            var response = await mediator.Send(command);

            return response.IsSuccess 
                            ? Results.Ok(response)
                            : Results.BadRequest(response);
        });
    }
}
