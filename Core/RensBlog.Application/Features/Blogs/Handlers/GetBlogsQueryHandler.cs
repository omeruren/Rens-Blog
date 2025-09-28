using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Queries;
using RensBlog.Application.Features.Blogs.Results;
using RensBlog.Domain.Entities;
using System.ComponentModel;

namespace RensBlog.Application.Features.Blogs.Handlers;

public class GetBlogsQueryHandler(IRepository<Blog> _repository, IMapper _mapper) : IRequestHandler<GetBlogsQuery, BaseResult<List<GetBlogsQueryResult>>>
{
    public async Task<BaseResult<List<GetBlogsQueryResult>>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();

        var blogs = _mapper.Map<List<GetBlogsQueryResult>>(values);

        return BaseResult<List<GetBlogsQueryResult>>.Success(blogs);
    }
}
