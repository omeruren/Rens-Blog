using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Socials.Queries;
using RensBlog.Application.Features.Socials.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Socials.Handlers;

public class GetSocialByIdQueryHandler(IRepository<Social> _repository, IMapper _mapper) : IRequestHandler<GetSocialByIdQuery, BaseResult<GetSocialByIdQueryResult>>
{
    public async Task<BaseResult<GetSocialByIdQueryResult>> Handle(GetSocialByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value == null)
        {
            return BaseResult<GetSocialByIdQueryResult>.Fail("Social not found");
        }
        var social = _mapper.Map<GetSocialByIdQueryResult>(value);
        return BaseResult<GetSocialByIdQueryResult>.Success(social);
    }
}
