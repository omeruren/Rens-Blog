using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Messages.Commands;

public record RemoveMessageCommand(Guid Id) : IRequest<BaseResult<object>>;
