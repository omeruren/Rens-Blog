using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Contracts.Persistance;

public interface IJwtService
{
    Task<GetLoginResponse> GenerateTokenASync(GetUsersQueryResult result);
}
