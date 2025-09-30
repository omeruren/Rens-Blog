using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Handlers;

public class UpdateMessageCommandHandler(IRepository<Message> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateMessageCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value == null)
        {
            return BaseResult<object>.Fail("Message not found.");
        }

        var message = _mapper.Map(request, value);
        _repository.Update(message);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Message has been updated successfully");

    }
}
