using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.SubComments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.SubComments.Handlers;

public class RemoveSubCommentCommandHandler(IRepository<SubComment> _repository, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveSubCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(RemoveSubCommentCommand request, CancellationToken cancellationToken)
    {
        var subComment = await _repository.GetByIdAsync(request.Id);

        if (subComment == null)
        {
            return BaseResult<object>.Fail("SubComment not found");
        }
        _repository.Delete(subComment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("SubComment has been deleted successfully");
    }
}
