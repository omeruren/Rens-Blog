using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Users.Result;
using RensBlog.Application.Options;
using RensBlog.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RensBlog.Persistance.Concrete;

public class JwtService(UserManager<AppUser> _userManager, IOptions<JwtTokenOptions> tokenOptions) : IJwtService
{
    private readonly JwtTokenOptions _jwtTokenOptions = tokenOptions.Value;
    public async Task<GetLoginResponse> GenerateTokenASync(GetUsersQueryResult result)
    {
        var user = await _userManager.FindByNameAsync(result.UserName);

        SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes(_jwtTokenOptions.Key));
        var dateTimeNow = DateTime.UtcNow;

        List<Claim> claims = new()
        {
            new (JwtRegisteredClaimNames.Name, user.UserName),
            new (JwtRegisteredClaimNames.Sub, user.Id),
            new (JwtRegisteredClaimNames.Sub, user.Email),
            new ("fullName", string.Join(" ", user.FirstName, user.LastName))
        };

        JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwtTokenOptions.Issuer,
            audience: _jwtTokenOptions.Audience,
            claims: claims,
            notBefore: dateTimeNow,
            expires: dateTimeNow.AddMinutes(_jwtTokenOptions.ExpireInMunites),
            signingCredentials: new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256)
            );

        GetLoginResponse response = new();
        response.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        response.ExpirationTime = dateTimeNow.AddMinutes(_jwtTokenOptions.ExpireInMunites);
        return response;
    }

}
