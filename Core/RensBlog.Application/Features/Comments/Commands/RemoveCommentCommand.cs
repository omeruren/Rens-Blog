using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Comments.Commands;

public record RemoveCommentCommand(Guid Id) : IRequest<BaseResult<object>>;

