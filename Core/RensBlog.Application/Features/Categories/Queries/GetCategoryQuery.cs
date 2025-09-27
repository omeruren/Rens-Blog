using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Categories.Results;

namespace RensBlog.Application.Features.Categories.Queries;

public class GetCategoryQuery : IRequest<BaseResult<List<GetCategoryQueryResult>>>
{

}
