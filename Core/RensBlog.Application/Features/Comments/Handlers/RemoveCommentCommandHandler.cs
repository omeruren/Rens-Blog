using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Comments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Handlers;

public class RemoveCommentCommandHandler(IRepository<Comment> _repository, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(RemoveCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = await _repository.GetByIdAsync(request.Id);
        if (comment is null)
        {
            return BaseResult<object>.Fail("Comment not found");
        }
        _repository.Delete(comment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Comment  has been removed successfully");
    }


}
