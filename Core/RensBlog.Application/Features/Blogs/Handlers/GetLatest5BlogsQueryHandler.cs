using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Queries;
using RensBlog.Application.Features.Blogs.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Handlers;

internal class GetLatest5BlogsQueryHandler(IRepository<Blog> _repository, IMapper _mapper) : IRequestHandler<GetLatest5BlogsQuery, BaseResult<List<GetLatest5BlogsQueryResult>>>
{
    public async Task<BaseResult<List<GetLatest5BlogsQueryResult>>> Handle(GetLatest5BlogsQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetQuery().OrderByDescending(x=>x.Id).Take(5).ToList();

        var blogs = _mapper.Map<List<GetLatest5BlogsQueryResult>>(values);

        return BaseResult<List<GetLatest5BlogsQueryResult>>.Success(blogs);



    }
}
