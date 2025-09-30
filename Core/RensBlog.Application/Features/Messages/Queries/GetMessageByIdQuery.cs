using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Messages.Result;

namespace RensBlog.Application.Features.Messages.Queries;

public record class GetMessageByIdQuery(Guid Id) : IRequest<BaseResult<GetMessageByIdQueryResult>>;
