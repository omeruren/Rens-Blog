using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Socials.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Socials.Queries
{
    public record GetSocialsQuery : IRequest<BaseResult<List<GetSocialsQueryResult>>>;
}
