using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Comments.Queries;
using RensBlog.Application.Features.Comments.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Comments.Handlers;

public class GetCommentsQueryHandler(IRepository<Comment> _repository, IMapper _mapper) : IRequestHandler<GetCommentsQuery, BaseResult<List<GetCommentsQueryResult>>>
{
    public async Task<BaseResult<List<GetCommentsQueryResult>>> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();

        var comments = _mapper.Map<List<GetCommentsQueryResult>>(values);

        return BaseResult<List<GetCommentsQueryResult>>.Success(comments);
    }
}
