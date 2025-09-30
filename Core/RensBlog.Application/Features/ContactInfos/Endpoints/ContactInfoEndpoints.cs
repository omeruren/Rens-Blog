using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using RensBlog.Application.Features.ContactInfos.Commands;
using RensBlog.Application.Features.ContactInfos.Queries;

namespace RensBlog.Application.Features.ContactInfos.Endpoints;

public static class ContactInfoEndpoints 
{
    public static void RegisterContactInfoEndpoints(this IEndpointRouteBuilder app)
    {
        var contatcInfos = app.MapGroup("/contactinfos").WithTags("ContactInfos");

        contatcInfos.MapGet(string.Empty, async (IMediator mediator) =>
        {
            var result = await mediator.Send(new GetContactInfosQuery());
            return result.IsSuccess 
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);
        });

        contatcInfos.MapGet("{id}", async (Guid id, IMediator mediator) =>
        {
            var result = await mediator.Send(new GetContactInfoByIdQuery(id));
            return result.IsSuccess 
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);
        });

        contatcInfos.MapPost(string.Empty, async (IMediator mediator, CreateContactInfoCommand command) =>
        {
            var result = await mediator.Send(command);
            return result.IsSuccess 
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);
        });

        contatcInfos.MapPut(string.Empty, async (IMediator mediator, UpdateContactInfoCommand command) =>
        {
            var result = await mediator.Send(command);
            return result.IsSuccess 
                            ? Results.Ok(result) 
                            : Results.BadRequest(result);
        });
    }

}
