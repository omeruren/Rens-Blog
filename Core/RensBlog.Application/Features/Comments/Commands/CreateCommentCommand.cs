using MediatR;
using RensBlog.Application.Base;
using RensBlog.Domain.Entities;
using System.Text.Json.Serialization;

namespace RensBlog.Application.Features.Comments.Commands;

public record CreateCommentCommand : IRequest<BaseResult<object>>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Body { get; init; }
    [JsonIgnore]
    public DateTime CommentDate { get; init; } = DateTime.Now;
    public Guid BlogId { get; init; }
}
