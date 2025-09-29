using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Comments.Result;

namespace RensBlog.Application.Features.Comments.Queries;

public record GetCommentsQuery : IRequest<BaseResult<List<GetCommentsQueryResult>>>;

