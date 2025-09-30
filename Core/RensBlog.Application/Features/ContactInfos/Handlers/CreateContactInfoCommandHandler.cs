using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.ContactInfos.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Handlers;

public class CreateContactInfoCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateContactInfoCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateContactInfoCommand request, CancellationToken cancellationToken)
    {
        var contactInfo = _mapper.Map<ContactInfo>(request);
        await _repository.CrateAsync(contactInfo);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success(contactInfo);
    }
}
