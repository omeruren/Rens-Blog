using Microsoft.AspNetCore.Identity;

namespace RensBlog.Domain.Entities;

public class AppUser : IdentityUser<string>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? ImageUrl { get; set; }

    public IList<Blog> Blogs { get; set; }
    public IList<Comment> Comments { get; set; }
    public IList<SubComment> SubComments { get; set; }
}
