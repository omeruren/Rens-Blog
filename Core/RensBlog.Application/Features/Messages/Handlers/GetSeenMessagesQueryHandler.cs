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
    internal class GetSeenMessagesQueryHandler(IRepository<Message> _repository, IMapper _mapper) : IRequestHandler<GetSeenMessagesQuery, BaseResult<List<GetSeenMessagesQueryResult>>>
    {
        public async Task<BaseResult<List<GetSeenMessagesQueryResult>>> Handle(GetSeenMessagesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync(x => x.IsRead == true);

            var messages = _mapper.Map<List<GetSeenMessagesQueryResult>>(values);

            return BaseResult<List<GetSeenMessagesQueryResult>>.Success(messages);
        }

    }
}
