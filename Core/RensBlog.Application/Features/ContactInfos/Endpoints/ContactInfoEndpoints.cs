using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
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
    }

}
