using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Application.Features.Messages.Queries;

namespace RensBlog.Application.Features.Messages.Endpoints;

public static class MessageEndpoints
{
    public static void RegisterMessageEndpoints(this IEndpointRouteBuilder app)
    {
        var messages = app.MapGroup("/messages").WithTags("Messages");

        messages.MapPost(string.Empty, async (IMediator mediator, CreateMessageCommand command) =>
        {
            var result = await mediator.Send(command);
            
            return result.IsSuccess
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);  

        });

        messages.MapGet(string.Empty, async (IMediator mediator) =>
        {
            var response = await mediator.Send(new GetMessagesQuery());
            return response.IsSuccess
                            ? Results.Ok(response)
                            : Results.BadRequest(response);
        });

        messages.MapGet("/{id}", async (IMediator mediator, Guid id) =>
        {
            var response = await mediator.Send(new GetMessageByIdQuery(id));
            return response.IsSuccess
                            ? Results.Ok(response)
                            : Results.BadRequest(response);
        });

        messages.MapPut(string.Empty, async (IMediator mediator,UpdateMessageCommand command) =>
        {
            
            var response = await mediator.Send(command);
            return response.IsSuccess
                            ? Results.Ok(response)
                            : Results.BadRequest(response);
        });
    }
}
