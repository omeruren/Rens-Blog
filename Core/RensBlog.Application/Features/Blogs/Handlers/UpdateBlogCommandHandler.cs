using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Handlers;

public class UpdateBlogCommandHandler(IRepository<Blog> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateBlogCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var blog = _mapper.Map<Blog>(request);

         _repository.Update(blog);
        await _unitOfWork.SaveChangesAsync();

        return BaseResult<object>.Success("Blog has been updated successfully");
    }
}
