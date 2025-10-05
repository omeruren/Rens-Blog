using RensBlog.Application.Base;
using RensBlog.Application.Features.Blogs.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Result;

public class GetCategoryQueryResult : BaseDto
{
    public string CategoryName { get; set; }
    public IList<GetBlogsQueryResult> Blogs { get; set; }

}
