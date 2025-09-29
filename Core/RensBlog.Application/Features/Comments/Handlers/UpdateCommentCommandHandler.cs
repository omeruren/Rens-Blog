using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Commands;
using RensBlog.Application.Features.Comments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Handlers;

public class UpdateCommentCommandHandler(IRepository<Comment> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = _mapper.Map<Comment>(request);
        _repository.Update(comment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success("Comment updated successfully");
    }

}
