using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.SubComments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.SubComments.Handlers;

public class CreateSubCommentCommandHandler(IRepository<SubComment> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateSubCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateSubCommentCommand request, CancellationToken cancellationToken)
    {
        var subComment = _mapper.Map<SubComment>(request);
        await _repository.CrateAsync(subComment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success(subComment);
    }
}
