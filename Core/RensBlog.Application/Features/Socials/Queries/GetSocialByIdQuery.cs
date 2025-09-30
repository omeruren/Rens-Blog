using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Socials.Result;

namespace RensBlog.Application.Features.Socials.Queries;

public record GetSocialByIdQuery(Guid Id) : IRequest<BaseResult<GetSocialByIdQueryResult>>;
