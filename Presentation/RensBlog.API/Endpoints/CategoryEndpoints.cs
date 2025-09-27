﻿using MediatR;
using RensBlog.Application.Features.Categories.Queries;

namespace RensBlog.API.Endpoints
{
    public static class CategoryEndpoints
    {
        public static void RegisterCategoryEndPoints(this IEndpointRouteBuilder app)
        {
            var categories = app.MapGroup("/categories").WithTags("Categories");

            categories.MapGet("", async (IMediator _mediator) =>
            {
                var response = await _mediator.Send(new GetCategoryQuery());

                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });

        }
    }
}
