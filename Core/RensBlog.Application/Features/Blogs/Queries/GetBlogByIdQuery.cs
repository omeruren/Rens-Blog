using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Blogs.Results;

namespace RensBlog.Application.Features.Blogs.Queries;

public record GetBlogByIdQuery(Guid Id) : IRequest<BaseResult<GetBlogByIdQueryResult>>;

