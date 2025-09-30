using RensBlog.Application.Base;

namespace RensBlog.Application.Features.ContactInfos.Result;

public class GetContactInfosQueryResult : BaseDto
{
    public string Address { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public string MapUrl { get; set; }
}
