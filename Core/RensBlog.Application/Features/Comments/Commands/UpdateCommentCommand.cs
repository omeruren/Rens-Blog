using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Comments.Commands;

public class UpdateCommentCommand : IRequest<BaseResult<object>>
{
    public Guid Id { get; set; }
    public string UserId { get; init; }
    public string Body { get; init; }
    public Guid BlogId { get; init; }
}
