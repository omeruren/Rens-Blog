using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Blogs.Result;

namespace RensBlog.Application.Features.Blogs.Queries;

public record GetLatest5BlogsQuery : IRequest<BaseResult<List<GetLatest5BlogsQueryResult>>>
{
}
