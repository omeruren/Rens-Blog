using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }
    public IList<Blog> Blogs { get; set; }
}

