using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Socials.Queries;
using RensBlog.Application.Features.Socials.Result;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Socials.Handlers
{
    internal class GetsocialsQueryHandler(IRepository<Social> _repository, IMapper _mapper) : IRequestHandler<GetSocialsQuery, BaseResult<List<GetSocialsQueryResult>>>
    {
        public async Task<BaseResult<List<GetSocialsQueryResult>>> Handle(GetSocialsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var socials = _mapper.Map<List<GetSocialsQueryResult>>(values);
            return BaseResult<List<GetSocialsQueryResult>>.Success(socials);
        }
    }
}
