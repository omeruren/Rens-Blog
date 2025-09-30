﻿using RensBlog.Application.Base;

namespace RensBlog.Application.Features.Socials.Result;

public class GetSocialsQueryResult : BaseDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
