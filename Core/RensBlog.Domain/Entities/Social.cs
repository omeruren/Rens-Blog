using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class Social : BaseEntity
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
