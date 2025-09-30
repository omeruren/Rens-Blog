using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.ContactInfos.Commands;

public record RemoveContatcInfoCommand (Guid Id) : IRequest<BaseResult<object>>;

