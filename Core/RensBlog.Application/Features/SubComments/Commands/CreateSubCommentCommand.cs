using MediatR;
using RensBlog.Application.Base;
using RensBlog.Domain.Entities;
using System.Text.Json.Serialization;

namespace RensBlog.Application.Features.SubComments.Commands;

public record CreateSubCommentCommand : IRequest<BaseResult<object>>
{
    public string UserId { get; init; }
    public string Body { get; init; }
    [JsonIgnore]
    public DateTime CommentDate { get; init; } = DateTime.Now;
    public Guid CommentId { get; init; }
}
