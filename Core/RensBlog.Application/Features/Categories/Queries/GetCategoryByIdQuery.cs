using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Categories.Result;

namespace RensBlog.Application.Features.Categories.Queries;

public record GetCategoryByIdQuery(Guid Id) : IRequest<BaseResult<GetCategoryByIdQueryResult>>;
