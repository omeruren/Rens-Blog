using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Blogs.Commands;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Blogs.Handlers
{
    internal class RemoveBlogCommandHandler(IRepository<Blog> _repository, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveBlogCommand, BaseResult<object>>
    {
        public async Task<BaseResult<object>> Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _repository.GetByIdAsync(request.Id);

            if(blog is  null)
            {
                return BaseResult<object>.NotFound("Blog not found");
            }

            _repository.Delete(blog);
            _unitOfWork.SaveChangesAsync();
            return BaseResult<object>.Success("Blog has been removed successfully");

        }
    }
}
