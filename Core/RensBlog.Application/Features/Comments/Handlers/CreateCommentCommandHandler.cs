using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Comments.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Handlers;

public class CreateCommentCommandHandler(IRepository<Comment> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateCommentCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = _mapper.Map<Comment>(request);
        await _repository.CrateAsync(comment);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success(comment);
    }
}
