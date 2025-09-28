using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Blogs.Result;

namespace RensBlog.Application.Features.Blogs.Queries;

public record GetBlogsQuery : IRequest<BaseResult<List<GetBlogsQueryResult>>>;

