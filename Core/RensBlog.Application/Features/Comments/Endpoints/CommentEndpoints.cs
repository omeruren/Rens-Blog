using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Comments.Commands;
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

        comments.MapPost(string.Empty, async (CreateCommentCommand commamnd, IMediator mediator) =>
        {
            var response = await mediator.Send(commamnd);
            return response.IsSuccess
                           ? Results.Ok(response)
                           : Results.BadRequest(response);
        });

        comments.MapGet("{id}", async (Guid id, IMediator mediator) =>
        {
            var response = await mediator.Send(new GetCommentByIdQuery(id));
            return response.IsSuccess
                         ? Results.Ok(response)
                         : Results.BadRequest(response);
        });

        comments.MapPut(string.Empty, async (UpdateCommentCommand command, IMediator mediator) =>
        {

            var response = await mediator.Send(command);
            return response.IsSuccess
                      ? Results.Ok(response)
                      : Results.BadRequest(response);
        });
    }
}
