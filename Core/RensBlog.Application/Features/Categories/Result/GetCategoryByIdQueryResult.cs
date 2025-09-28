using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Categories.Result;

public class GetCategoryByIdQueryResult : BaseDto
{
    public string CategoryName { get; set; }
    //public IList<GetBlogQueryResult> Blogs { get; set; }
}
