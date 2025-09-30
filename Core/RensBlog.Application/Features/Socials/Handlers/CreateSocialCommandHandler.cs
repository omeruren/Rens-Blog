using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Socials.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Socials.Handlers;

public class CreateSocialCommandHandler(IRepository<Social> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) : IRequestHandler<CreateSocialCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateSocialCommand request, CancellationToken cancellationToken)
    {
        var social = _mapper.Map<Social>(request);
        await _repository.CrateAsync(social);
        await _unitOfWork.SaveChangesAsync();
        return BaseResult<object>.Success(social);
    }
}
