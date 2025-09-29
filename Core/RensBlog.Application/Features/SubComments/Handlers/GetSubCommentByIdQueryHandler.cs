using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.SubComments.Queries;
using RensBlog.Application.Features.SubComments.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.SubComments.Handlers;

public class GetSubCommentByIdQueryHandler(IRepository<SubComment> _repository, IMapper _mapper) : IRequestHandler<GetSubCommentByIdQuery, BaseResult<GetSubCommentByIdQueryResult>>
{
    public async Task<BaseResult<GetSubCommentByIdQueryResult>> Handle(GetSubCommentByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);

        if (value is null)
        {
            return BaseResult<GetSubCommentByIdQueryResult>.Fail("SubComment not found");
        }
        var subComment = _mapper.Map<GetSubCommentByIdQueryResult>(value);
        return BaseResult<GetSubCommentByIdQueryResult>.Success(subComment);
    }
}
