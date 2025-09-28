using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Users.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Users.Handlers;

public class CreateUserCommandHandler(UserManager<AppUser> _userManager, IMapper _mapper) : IRequestHandler<CreateUserCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<AppUser>(request);

        if(request.Password != request.ConfirmPassword)
        {
            return BaseResult<object>.Fail("Passwords did not match");
        }

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return BaseResult<object>.Fail(result.Errors);
        }

        return BaseResult<object>.Success(result);
    }
}
