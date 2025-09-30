using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Messages.Result;

namespace RensBlog.Application.Features.Messages.Queries;

public record GetMessagesQuery : IRequest<BaseResult<List<GetMessagesQueryresult>>>;

