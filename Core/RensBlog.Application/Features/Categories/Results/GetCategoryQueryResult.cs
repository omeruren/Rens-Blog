using RensBlog.Application.Base;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Results;

public class GetCategoryQueryResult : BaseDto
{
    public string CategoryName { get; set; }
    //public IList<GetBlogQueryResult> Blogs { get; set; }

}
