using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Users.Queries;
using RensBlog.Application.Features.Users.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Users.Handlers;

public class GetLoginQueryHandler(UserManager<AppUser> _userManager,IMapper _mapper, IJwtService _jwtService) : IRequestHandler<GetLoginQuery, BaseResult<GetLoginQueryResult>>
{
    public async Task<BaseResult<GetLoginQueryResult>> Handle(GetLoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            return BaseResult<GetLoginQueryResult>.NotFound("User not found");
        }

        if (request.Password != request.ConfirmPassword)
        {
            return BaseResult<GetLoginQueryResult>.Fail("Passwords did not match");
        }
        
        var result = await _userManager.CheckPasswordAsync(user, request.Password);
        
        if(!result)
        {
            return BaseResult<GetLoginQueryResult>.Fail("Invalid credentials");
        }
        
        var userResult = _mapper.Map<GetUsersQueryResult>(user);
        
        var response = await _jwtService.GenerateTokenASync(userResult);
        
        if(response == null)
        {
            return BaseResult<GetLoginQueryResult>.Fail("Failed to generate token");
        }
        return BaseResult<GetLoginQueryResult>.Success(response);


    }
}
