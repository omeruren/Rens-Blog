using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Queries;
using RensBlog.Application.Features.Blogs.Results;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Blogs.Handlers
{
    internal class GetBlogByIdQueryHandler(IRepository<Blog> _repository, IMapper _mapper) : IRequestHandler<GetBlogByIdQuery, BaseResult<GetBlogByIdQueryResult>>
    {
        public async Task<BaseResult<GetBlogByIdQueryResult>> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value is null)
                return BaseResult<GetBlogByIdQueryResult>.NotFound("Blog not found");

            var blog = _mapper.Map<GetBlogByIdQueryResult>(value);

            return BaseResult<GetBlogByIdQueryResult>.Success(blog);
        }
    }
}
