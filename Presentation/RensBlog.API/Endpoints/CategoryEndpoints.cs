using MediatR;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Application.Features.Categories.Queries;

namespace RensBlog.API.Endpoints
{
    public static class CategoryEndpoints
    {
        public static void RegisterCategoryEndPoints(this IEndpointRouteBuilder app)
        {
            var categories = app.MapGroup("/categories").WithTags("Categories");

            categories.MapGet(string.Empty, async (IMediator mediator) =>
            {
                var response = await mediator.Send(new GetCategoryQuery());

                return response.IsSuccess 
                ? Results.Ok(response) 
                : Results.BadRequest(response);
            });


            categories.MapPost(string.Empty, async (CreateCategoryCommand command, IMediator mediator) =>
            {
                var response = await mediator.Send(command);
                return response.IsSuccess 
                ? Results.Ok(response) 
                : Results.BadRequest(response);
            });

            categories.MapGet("{id}",
                async (Guid id, IMediator mediator) =>
                {
                    var response = await mediator.Send(new GetCategoryByIdQuery(id));
                    return response.IsSuccess 
                    ? Results.Ok(response) 
                    : Results.BadRequest(response);
                });

            categories.MapPut(string.Empty,
                async (UpdateCategoryCommand command, IMediator mediator) =>
                {
                    var response = await mediator.Send(command);

                    return response.IsSuccess 
                    ? Results.Ok(response)
                    : Results.BadRequest(response);
                });
        }
    }
}
