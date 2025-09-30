using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.ContactInfos.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.ContactInfos.Handlers;

public class RemoveContatcInfoCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveContatcInfoCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(RemoveContatcInfoCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value == null)
        {
            return BaseResult<object>.Fail("Contact info not found.");
        }
        _repository.Delete(value);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Contact info has been removed successfully");
    }
}
