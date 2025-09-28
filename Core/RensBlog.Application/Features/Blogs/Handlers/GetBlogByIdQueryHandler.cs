using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Queries;
using RensBlog.Application.Features.Blogs.Results;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Handlers;

public class GetBlogByIdQueryHandler(IRepository<Blog> _repository, IMapper _mapper) : IRequestHandler<GetBlogByIdQuery, BaseResult<GetBlogByIdQueryResult>>
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
