using RensBlog.Application.Base;
using RensBlog.Application.Features.Comments.Result;
using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Features.SubComments.Result;

public class GetSubCommentByIdQueryResult : BaseDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    public Guid CommentId { get; set; }
    public GetCommentsQueryResult Comment { get; set; }
}
