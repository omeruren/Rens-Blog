using MediatR;
using RensBlog.Application.Base;
using RensBlog.Domain.Entities;
using System.Text.Json.Serialization;

namespace RensBlog.Application.Features.Comments.Commands;

public record CreateCommentCommand : IRequest<BaseResult<object>>
{
    public string UserId { get; init; }
    public string Body { get; init; }
    [JsonIgnore]
    public DateTime CommentDate { get; init; } = DateTime.Now;
    public Guid BlogId { get; init; }
}
