using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Handlers;

public class RemoveMessageCommandHandler(IRepository<Message> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveMessageCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(RemoveMessageCommand request, CancellationToken cancellationToken)
    {
        var message = await _repository.GetByIdAsync(request.Id);
        if (message == null)
        {
            return BaseResult<object>.Fail("Message not found");
        }
        _repository.Delete(message);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Message removed successfully");
    }
}
