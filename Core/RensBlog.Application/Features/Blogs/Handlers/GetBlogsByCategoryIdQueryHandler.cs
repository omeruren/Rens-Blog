using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Queries;
using RensBlog.Application.Features.Blogs.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Handlers;

public class GetBlogsByCategoryIdQueryHandler(IRepository<Blog> _repository, IMapper _mapper) : IRequestHandler<GetBlogsByCategoryIdQuery, BaseResult<List<GetBlogsByCategoryIdQueryResult>>>
{
    public async Task<BaseResult<List<GetBlogsByCategoryIdQueryResult>>> Handle(GetBlogsByCategoryIdQuery request, CancellationToken cancellationToken)
    {
        var query = _repository.GetQuery();
        var values = query.Where(x => x.CategoryId == request.CategoryId).ToList();

        var blogs = _mapper.Map<List<GetBlogsByCategoryIdQueryResult>>(values);

        return BaseResult<List<GetBlogsByCategoryIdQueryResult>>.Success(blogs);
    }
}
