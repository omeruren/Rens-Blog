using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Blogs.Commands;

public record RemoveBlogCommand(Guid Id) : IRequest<BaseResult<object>>;

