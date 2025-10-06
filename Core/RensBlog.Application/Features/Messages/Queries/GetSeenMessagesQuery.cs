using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Messages.Result;

namespace RensBlog.Application.Features.Messages.Queries
{
    public record GetSeenMessagesQuery : IRequest<BaseResult<List<GetSeenMessagesQueryResult>>>;
    
}
