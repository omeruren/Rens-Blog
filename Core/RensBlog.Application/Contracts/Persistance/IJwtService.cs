using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Contracts.Persistance;

public interface IJwtService
{
    Task<GetLoginQueryResult> GenerateTokenASync(GetUsersQueryResult result);
}
