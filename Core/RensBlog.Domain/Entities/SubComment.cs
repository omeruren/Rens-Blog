using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class SubComment 
{
    public string UserId { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    public Guid CommentId { get; set; }
    public Comment Comment { get; set; }
}
