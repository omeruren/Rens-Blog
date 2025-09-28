﻿using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class Comment : BaseEntity
{
    public string UserId { get; set; }
    public virtual AppUser User { get; set; }
    public string Body { get; set; }
    public DateTime CommentDate { get; set; }

    public virtual IList<SubComment> SubComments { get; set; }
    public  Guid BlogId { get; set; }
    public virtual Blog Blog { get; set; }
}
