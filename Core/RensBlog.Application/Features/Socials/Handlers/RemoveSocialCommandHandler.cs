using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Socials.Handlers
{
    internal class RemoveSocialCommandHandler(IRepository<Social> _repository, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveSocialCommand, BaseResult<object>>
    {
        public async Task<BaseResult<object>> Handle(RemoveSocialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null)
            {
                return BaseResult<object>.Fail("Social not found");
            }
            _repository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
            return BaseResult<object>.Success("Social removed successfully");
        }
    }
}
