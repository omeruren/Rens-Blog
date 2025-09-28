using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class Comment : BaseEntity
{
    public string UserId { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    public IList<SubComment> SubComments { get; set; }
}
