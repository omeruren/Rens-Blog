using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.ContactInfos.Queries;
using RensBlog.Application.Features.ContactInfos.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Handlers;

public class GetContactInfosQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactInfosQuery, BaseResult<List<GetContactInfosQueryResult>>>
{
    public async Task<BaseResult<List<GetContactInfosQueryResult>>> Handle(GetContactInfosQuery request, CancellationToken cancellationToken)
    {
        var contactInfos = await _repository.GetAllAsync();

        var result = _mapper.Map<List<GetContactInfosQueryResult>>(contactInfos);

        return BaseResult<List<GetContactInfosQueryResult>>.Success(result);
    }
}
