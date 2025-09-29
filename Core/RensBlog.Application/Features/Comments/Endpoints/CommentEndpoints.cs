using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Comments.Queries;

namespace RensBlog.Application.Features.Comments.Endpoints;

public static class CommentEndpoints
{
    public static void RegisterCommentEndpoints(this IEndpointRouteBuilder app)
    {
        var comments = app.MapGroup("/comments").WithTags("Comments");

        comments.MapGet(string.Empty, async (IMediator mediator) =>
        {

            var response = await mediator.Send(new GetCommentsQuery());
            return response.IsSuccess
                            ? Results.Ok(response)
                            : Results.BadRequest(response);
        });
    }
}
