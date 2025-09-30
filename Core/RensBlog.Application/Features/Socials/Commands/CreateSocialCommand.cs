using MediatR;
using RensBlog.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Socials.Commands;

public record CreateSocialCommand : IRequest<BaseResult<object>>
{
    public string Title { get; init; }
    public string Url { get; init; }
    public string Icon { get; init; }
}
