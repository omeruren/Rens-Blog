﻿using RensBlog.Application.Base;
using RensBlog.Application.Features.Categories.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Blogs.Result;

public class GetBlogsQueryResult : BaseDto
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string BlogImage { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public GetCategoryQueryResult Category { get; set; }
    public string UserId { get; set; }
    //public AppUser User { get; set; }

    //public IList<Comment> Comments { get; set; }
}
