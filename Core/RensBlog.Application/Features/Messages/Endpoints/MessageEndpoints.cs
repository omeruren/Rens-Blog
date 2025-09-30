using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.Messages.Commands;

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

    }
}
