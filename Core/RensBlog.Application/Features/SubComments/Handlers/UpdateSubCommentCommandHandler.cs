using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.SubComments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.SubComments.Handlers;

public class UpdateSubCommentCommandHandler(IRepository<SubComment> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateSubCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(UpdateSubCommentCommand request, CancellationToken cancellationToken)
    {
        var subComment = await _repository.GetByIdAsync(request.Id);

        if (subComment is null)
        {
            return BaseResult<object>.Fail("SubComment not found");
        }

        subComment = _mapper.Map(request, subComment);
        _repository.Update(subComment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("SubComment has been updated successfully");


    }
}
