using RensBlog.Application.Features.Blogs.Result;
using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Features.Comments.Result;

public class GetCommentsQueryResult
{
    public string UserId { get; set; }
    public GetUsersQueryResult User { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    //public virtual IList<SubComment> SubComments { get; set; }
    public Guid BlogId { get; set; }
    public GetBlogsQueryResult Blog { get; set; }
}
