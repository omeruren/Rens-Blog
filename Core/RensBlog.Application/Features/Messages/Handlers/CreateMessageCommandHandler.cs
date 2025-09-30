using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Messages.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Handlers;

public class CreateMessageCommandHandler(IRepository<Message> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateMessageCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        var message = _mapper.Map<Message>(request);
        await _repository.CrateAsync(message);

        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Message created successfully");
    }
}
