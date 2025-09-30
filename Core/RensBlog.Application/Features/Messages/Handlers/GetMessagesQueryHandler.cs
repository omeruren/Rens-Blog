using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Messages.Queries;
using RensBlog.Application.Features.Messages.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Messages.Handlers;

public class GetMessagesQueryHandler(IRepository<Message> _repository, IMapper _mapper) : IRequestHandler<GetMessagesQuery, BaseResult<List<GetMessagesQueryResult>>>
{
    public async Task<BaseResult<List<GetMessagesQueryResult>>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
    {
        var messages = await _repository.GetAllAsync();
        var result = _mapper.Map<List<GetMessagesQueryResult>>(messages);
        return BaseResult<List<GetMessagesQueryResult>>.Success(result);
    }
}
