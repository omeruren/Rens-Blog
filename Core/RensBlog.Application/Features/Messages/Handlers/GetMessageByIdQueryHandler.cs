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
    public class GetMessageByIdQueryHandler(IRepository<Message> _repository, IMapper _mapper) : IRequestHandler<GetMessageByIdQuery, BaseResult<GetMessageByIdQueryResult>>
    {
        public async Task<BaseResult<GetMessageByIdQueryResult>> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var message = await _repository.GetByIdAsync(request.Id);
            if (message == null)
            {
                return BaseResult<GetMessageByIdQueryResult>.Fail("Message not found");
            }

            var result = _mapper.Map<GetMessageByIdQueryResult>(message);
            return BaseResult<GetMessageByIdQueryResult>.Success(result);
        }
    }
}
