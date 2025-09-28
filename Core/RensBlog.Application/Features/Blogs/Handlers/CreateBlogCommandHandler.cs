using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Handlers;

public class CreateBlogCommandHandler(IRepository<Blog> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateBlogCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        var blog = _mapper.Map<Blog>(request);

        await _repository.CrateAsync(blog);
        await _unitOfWork.SaveChangesAsync();

        return BaseResult<object>.Success(blog);
    }
}
