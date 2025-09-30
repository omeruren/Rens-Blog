using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.ContactInfos.Queries;
using RensBlog.Application.Features.ContactInfos.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Handlers;

public class GetContactInfoByIdQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactInfoByIdQuery, BaseResult<GetContactInfoByIdQueryResult>>
{
    public async Task<BaseResult<GetContactInfoByIdQueryResult>> Handle(GetContactInfoByIdQuery request, CancellationToken cancellationToken)
    {
        var contatcInfo = await _repository.GetByIdAsync(request.Id);

        if (contatcInfo == null)
        {
            return BaseResult<GetContactInfoByIdQueryResult>.Fail("Contact info not found");
        }
        var result = _mapper.Map<GetContactInfoByIdQueryResult>(contatcInfo);
        return BaseResult<GetContactInfoByIdQueryResult>.Success(result);
    }
}
