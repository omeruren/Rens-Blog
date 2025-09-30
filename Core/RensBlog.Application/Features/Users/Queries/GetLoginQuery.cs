using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Features.Users.Queries;

public class GetLoginQuery : IRequest<BaseResult<GetLoginQueryResult>>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
