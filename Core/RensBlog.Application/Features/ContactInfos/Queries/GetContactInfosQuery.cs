using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.ContactInfos.Result;

namespace RensBlog.Application.Features.ContactInfos.Queries;

public class GetContactInfosQuery : IRequest<BaseResult<List<GetContactInfosQueryResult>>>
{
}
