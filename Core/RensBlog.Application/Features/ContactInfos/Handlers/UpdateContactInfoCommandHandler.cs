using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.ContactInfos.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Handlers;

public class UpdateContactInfoCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateContactInfoCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(UpdateContactInfoCommand request, CancellationToken cancellationToken)
    {
        var contactInfo = await _repository.GetByIdAsync(request.Id);
        if(contactInfo == null)
        {
            return BaseResult<object>.Fail("Contact info not found");
        }
        _mapper.Map(request, contactInfo);
        _repository.Update(contactInfo);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Contact Info has been updated successfully");
    }
}
