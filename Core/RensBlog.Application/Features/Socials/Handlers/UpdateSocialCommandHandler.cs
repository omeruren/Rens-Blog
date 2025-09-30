using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Socials.Handlers
{
    internal class UpdateSocialCommandHandler(IRepository<Social> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<UpdateSocialCommand, BaseResult<object>>
    {
        public async Task<BaseResult<object>> Handle(UpdateSocialCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null)
            {
                return BaseResult<object>.Fail("Social not found");
            }
            var social = _mapper.Map(request, value);
            _repository.Update(social);
            await _unitOfWork.SaveChangesAsync();
            return BaseResult<object>.Success("Social has been updated successfully");
        }
    }
}
