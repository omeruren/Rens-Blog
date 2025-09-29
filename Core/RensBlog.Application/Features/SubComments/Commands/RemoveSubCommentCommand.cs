using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.SubComments.Commands;

public record RemoveSubCommentCommand(Guid Id) : IRequest<BaseResult<object>>;
