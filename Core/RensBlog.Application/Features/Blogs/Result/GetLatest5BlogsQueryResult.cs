using RensBlog.Application.Base;
using RensBlog.Application.Features.Categories.Result;
using RensBlog.Application.Features.Comments.Result;
using RensBlog.Application.Features.Users.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Blogs.Result
{
    public class GetLatest5BlogsQueryResult : BaseDto
    {
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string BlogImage { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public GetCategoryQueryResult Category { get; set; }
        public string UserId { get; set; }

        public GetUsersQueryResult User { get; set; }

        public IList<GetCommentsQueryResult> Comments { get; set; }
    }
}
