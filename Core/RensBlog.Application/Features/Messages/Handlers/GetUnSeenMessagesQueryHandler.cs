using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Messages.Queries;
using RensBlog.Application.Features.Messages.Result;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Messages.Handlers
{
    internal class GetUnSeenMessagesQueryHandler(IRepository<Message> _repository, IMapper _mapper) : IRequestHandler<GetUnSeenMessagesQuery, BaseResult<List<GetUnSeenMessagesQueryResult>>>
    {
        public async Task<BaseResult<List<GetUnSeenMessagesQueryResult>>> Handle(GetUnSeenMessagesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync(x => x.IsRead == false);
            var messages = _mapper.Map<List<GetUnSeenMessagesQueryResult>>(values);
            return BaseResult<List<GetUnSeenMessagesQueryResult>>.Success(messages);
        }
    }
}
