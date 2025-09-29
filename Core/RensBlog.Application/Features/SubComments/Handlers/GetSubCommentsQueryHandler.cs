using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.SubComments.Queries;
using RensBlog.Application.Features.SubComments.Result;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.SubComments.Handlers
{
    public class GetSubCommentsQueryHandler(IRepository<SubComment> _repository, IMapper _mapper) : IRequestHandler<GetSubCommentsQuery, BaseResult<List<GetSubCommentsQueryResult>>>
    {
        public async Task<BaseResult<List<GetSubCommentsQueryResult>>> Handle(GetSubCommentsQuery request, CancellationToken cancellationToken)
        {

            var values = await _repository.GetAllAsync();
            var subComments = _mapper.Map<List<GetSubCommentsQueryResult>>(values);

            return BaseResult<List<GetSubCommentsQueryResult>>.Success(subComments);
        }
    }
}
