using RensBlog.Application.Base;
using RensBlog.Application.Features.Blogs.Result;
using RensBlog.Application.Features.Users.Result;

namespace RensBlog.Application.Features.Comments.Result;

public class GetCommentsQueryResult : BaseDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    //public virtual IList<SubComment> SubComments { get; set; }
    public Guid BlogId { get; set; }
    public GetBlogsQueryResult Blog { get; set; }
}
