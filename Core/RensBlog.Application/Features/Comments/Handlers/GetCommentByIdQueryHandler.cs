using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Comments.Queries;
using RensBlog.Application.Features.Comments.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Handlers;

public class GetCommentByIdQueryHandler(IRepository<Comment> _repository, IMapper _mapper) : IRequestHandler<GetCommentByIdQuery, BaseResult<GetCommentByIdQueryResult>>
{
    public async Task<BaseResult<GetCommentByIdQueryResult>> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value is  null)
        {
            return BaseResult<GetCommentByIdQueryResult>.Fail("Comment not found");
        }
        var comment = _mapper.Map<GetCommentByIdQueryResult>(value);
        return BaseResult<GetCommentByIdQueryResult>.Success(comment);
    }
}
