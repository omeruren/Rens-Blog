using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.SubComments.Result;

namespace RensBlog.Application.Features.SubComments.Queries;

public record GetSubCommentsQuery : IRequest<BaseResult<List<GetSubCommentsQueryResult>>>;
