using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.ContactInfos.Commands;

public record CreateContactInfoCommand : IRequest<BaseResult<object>>
{
    public string Address { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string MapUrl { get; init; }
}
