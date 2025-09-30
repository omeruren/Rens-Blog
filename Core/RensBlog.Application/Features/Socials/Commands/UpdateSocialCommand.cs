using MediatR;
using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Socials.Commands;

public record UpdateSocialCommand(Guid Id, string Title, string Url, string Icon) : IRequest<BaseResult<object>>;
